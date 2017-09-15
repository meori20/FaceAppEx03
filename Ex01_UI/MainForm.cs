using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Ex01_Logic;

namespace Ex01_UI
{
    public partial class MainForm : Form
    {
        private UserDataFacade m_UserData;
        private FaceBookConnection m_Connection;
        private AppSettings m_AppSettings;
        private volatile List<object[]> m_TopImagesList;
        private bool m_FriendsLoaded = false;
        private bool m_PhotosLoaded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public void FriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedFriend();
        }

        public void DisplaySelectedFriend()
        {
            Dictionary<string, string> friendList = this.m_UserData.FriendList;
            if (FriendsListBox.SelectedItems.Count == 1)
            {
                string name = FriendsListBox.SelectedItem as string;

                if (friendList[name] != null)
                {
                    FriendPictureBox.LoadAsync(friendList[name]);
                }
                else
                {
                    FriendPictureBox.LoadAsync("no-pic.png");
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_AppSettings = AppSettings.LoadFromFile();
            this.Location = m_AppSettings.StartingLocation;
            if (m_AppSettings.RememberMe && !string.IsNullOrEmpty(m_AppSettings.AcssessToken))
            {
                m_Connection = FaceBookConnection.ConnectToFacebookAPI(m_AppSettings.AcssessToken);
                new Thread(populateAppFromFacebook).Start();
                RememberBox.Checked = true;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (m_Connection != null)
            {
                m_AppSettings.AcssessToken = m_Connection.GetAccsessToken();
            }

            m_AppSettings.StartingLocation = this.Location;
            m_AppSettings.RememberMe = RememberBox.Checked;
            m_AppSettings.SaveToFile();
        }

        private void populateAppFromFacebook()
        {
            try
            {
                this.m_UserData = new UserDataFacade(m_Connection);
                pictureBox1.LoadAsync(m_UserData.ProfilePicture);
                LoginButton.Text = @"Log Out";
                updateVisibleComponents();
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
}
      
        private void unPopulateApp()
        {
            pictureBox1.LoadAsync("no-pic.png");
            m_Connection = FaceBookConnection.LogOut();
            LoginButton.Text = @"Log In";
            this.updateVisibleComponentsWhenLogOut();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (m_Connection == null)
            {
                try
                {
                    m_Connection = FaceBookConnection.GetFacebookConnection();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                populateAppFromFacebook();
            }
            else
            {
                this.unPopulateApp();
            }
        }

        private void updateVisibleComponentsWhenLogOut()
        {
            TopLikers.Items.Clear();
            BirthdayFriends.Items.Clear();
            m_FriendsLoaded = false;
            FriendPictureBox.Visible = false;
            RememberBox.Visible = false;
            FriendsListLable.Visible = false;
            FriendsListBox.Visible = false;
            personalDetailsBox.Visible = false;
            FriendsTab.Visible = false;
            FriendsListBox.Items.Clear();
            MostLikedPictureBox.Image = null;
            DLikes.Text = string.Empty;
            DUploadDate.Text = string.Empty;
            DPostedBy.Text = string.Empty;
            PostTextBox.Visible = false;
            PostButton.Visible = false;
            personalDetailsBox.Controls.Clear();
            WelcomeText.Text = @"To proceed, please log in
to your facebook account ";
        }

        private void updateVisibleComponents()
        {
            PostTextBox.Visible = true;
            PostButton.Visible = true;
            RememberBox.Visible = true;
            FriendsListLable.Visible = true;
            FriendPictureBox.Visible = true;
            FriendsListBox.Visible = true;
            personalDetailsBox.Visible = true;
            this.FriendsTab.Enabled = true;
            new Thread(loadPesonalDetailsBox).Start();
            new Thread(loadFriednsListBox).Start();
            WelcomeText.Invoke(new Action(() => WelcomeText.Text = @"Welcome " + m_UserData.FullName));
        }

        private void loadFriednsListBox()
        {
            FriendPictureBox.LoadAsync("no-pic.png");
            
            foreach (KeyValuePair<string, string> friend in m_UserData.FriendList)
            {
                FriendsListBox.Invoke(new Action(() => FriendsListBox.Items.Add(friend.Key)));
            }
        }

        private void loadPesonalDetailsBox()
        {
            Point startingPoint = new Point(6, 33);
            List<KeyValuePair<string, string>> personalDetails = m_UserData.GetPersonalDetails();
            foreach (KeyValuePair<string, string> personalDetail in personalDetails)
            {
                Label newDetailLabel1 = new Label();
                Label newDetailLabel2 = new Label();
                newDetailLabel1.AutoSize = true;
                newDetailLabel1.Text = personalDetail.Key;
                newDetailLabel1.Location = startingPoint;
                newDetailLabel1.Font = new Font("Segoe UI", 7.8F, (FontStyle)(FontStyle.Bold | FontStyle.Underline), System.Drawing.GraphicsUnit.Point, (byte)0);
                newDetailLabel2.AutoSize = true;
                newDetailLabel2.Location = new Point(startingPoint.X + 80, startingPoint.Y);
                newDetailLabel2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
                newDetailLabel2.Text = personalDetail.Value;
                personalDetailsBox.Invoke(new Action(() => personalDetailsBox.Controls.Add(newDetailLabel1)));
                personalDetailsBox.Invoke(new Action(() => personalDetailsBox.Controls.Add(newDetailLabel2)));
                startingPoint.Y += 25;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(
            Pens.Black,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            OnPaint(e);
        }

        private void HomeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureChangingTimer.Enabled = false;
            TabControl tabControl = sender as TabControl;
            if (tabControl != null && (tabControl.SelectedIndex == 1 && m_Connection != null) && !m_FriendsLoaded) 
            { 
                m_FriendsLoaded = true;
                numberLabel.Text = m_UserData.FriendsNumber.ToString();
                new Thread(new ThreadStart(delegate
                {
                        List<KeyValuePair<String, int>> topFriendsLike = m_UserData.GetFriendLikes();

                        foreach (KeyValuePair<string, int> friend in topFriendsLike)
                        {
                            ListViewItem listViewItem = new ListViewItem(friend.Key);
                            listViewItem.SubItems.Add(friend.Value.ToString());
                            TopLikers.Invoke(new Action(() => TopLikers.Items.Add(listViewItem)));
                        }
                })).Start();
                new Thread(new ThreadStart(delegate
                {
                    List<KeyValuePair<string, DateTime>> friendsBirthdays =
                        m_UserData.GetFriendsBirthdays();
                    foreach (KeyValuePair<string, DateTime> friend in friendsBirthdays)
                    {
                        ListViewItem listViewItem = new ListViewItem(friend.Key);
                        listViewItem.SubItems.Add(friend.Value.ToShortDateString());
                        BirthdayFriends.Invoke(new Action(() => BirthdayFriends.Items.Add(listViewItem)));
                    }
                })).Start();
                friendsListBindingSource.DataSource = m_UserData.ExtendedFriendsList;
            }
            else if (tabControl != null && tabControl.SelectedIndex == 2 && m_PhotosLoaded)
            {
                PictureChangingTimer.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random randommizer = new Random();
            if (m_TopImagesList != null)
            {
                int index;
                do
                {
                    index = randommizer.Next(4);
                }
                while (((string)m_TopImagesList[index][0]) == MostLikedPictureBox.ImageLocation);
                MostLikedPictureBox.Load((string)m_TopImagesList[index][0]);
                DLikes.Text = m_TopImagesList[index][1].ToString();
                DUploadDate.Text = m_TopImagesList[index][2].ToString();
                DPostedBy.Text = (string)m_TopImagesList[index][3];
            }
        }

        private void FetchPhotoButton_Click(object sender, EventArgs e)
        {
            new Thread(fetchPhotos).Start();
            PictureChangingTimer.Enabled = true;
            m_PhotosLoaded = true;
        }

        private void fetchPhotos()
        { 
            m_TopImagesList = m_UserData.GetTopLikedImages();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (ActionChooseComboBox.SelectedItem == null)
            {          
              MessageBox.Show("You have to choose one of the options."); 
            }
            else if (!String.IsNullOrEmpty(ActionChooseComboBox.SelectedItem.ToString()))
            {
                FaceBookInfoDisplay faceBookInfoDisplay =
                    FaceBookInfoDisplayFactory.Create(ActionChooseComboBox.SelectedItem.ToString(), m_UserData);
                advanceInfoTab.Controls.AddRange(faceBookInfoDisplay.GetInfoDisplay().ToArray());
                AcceptButton.Visible = false;
                ActionChooseComboBox.Visible = false;
                HeadlineInfoLabel.Visible = false;
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PostTextBox.Text))
            {
                try
                {
                    m_UserData.PostOnFaceBook(PostTextBox.Text);
                    MessageBox.Show("Your post successfully posted.");
                    PostTextBox.Clear();
                }
                catch (Exception postException)
                {
                    Console.WriteLine(postException.Message);
                    throw;
                }
            }
        }
    }
}
