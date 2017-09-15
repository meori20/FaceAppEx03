using System;
using System.Windows.Forms;

namespace Ex01_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maleAndFemalePrecentageLabel;
            System.Windows.Forms.Label singlePercentageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HomeTab = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.PostButton = new System.Windows.Forms.Button();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.FriendPictureBox = new System.Windows.Forms.PictureBox();
            this.FriendsListLable = new System.Windows.Forms.Label();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.personalDetailsBox = new System.Windows.Forms.GroupBox();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.RememberBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FriendsTab = new System.Windows.Forms.TabPage();
            this.maleAndFemalePrecentageLabel1 = new System.Windows.Forms.Label();
            this.friendsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singlePercentageLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthdayFriends = new System.Windows.Forms.ListView();
            this.FriendsBirthName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopLikers = new System.Windows.Forms.ListView();
            this.CollumName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Likes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FriendsNumberPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.FriendsNumberLabel = new System.Windows.Forms.Label();
            this.TimeLineTab = new System.Windows.Forms.TabPage();
            this.ImageInfo = new System.Windows.Forms.GroupBox();
            this.DUploadDate = new System.Windows.Forms.Label();
            this.DLikes = new System.Windows.Forms.Label();
            this.DPostedBy = new System.Windows.Forms.Label();
            this.UploadDateLabel = new System.Windows.Forms.Label();
            this.LikesLabel = new System.Windows.Forms.Label();
            this.PostByLabel = new System.Windows.Forms.Label();
            this.FetchPhotoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MostLikedPictureBox = new System.Windows.Forms.PictureBox();
            this.advanceInfoTab = new System.Windows.Forms.TabPage();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.HeadlineInfoLabel = new System.Windows.Forms.Label();
            this.ActionChooseComboBox = new System.Windows.Forms.ComboBox();
            this.PictureChangingTimer = new System.Windows.Forms.Timer(this.components);
            maleAndFemalePrecentageLabel = new System.Windows.Forms.Label();
            singlePercentageLabel = new System.Windows.Forms.Label();
            this.HomeTab.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FriendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsListBindingSource)).BeginInit();
            this.FriendsNumberPanel.SuspendLayout();
            this.TimeLineTab.SuspendLayout();
            this.ImageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostLikedPictureBox)).BeginInit();
            this.advanceInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // maleAndFemalePrecentageLabel
            // 
            maleAndFemalePrecentageLabel.AutoSize = true;
            maleAndFemalePrecentageLabel.Location = new System.Drawing.Point(345, 31);
            maleAndFemalePrecentageLabel.Name = "maleAndFemalePrecentageLabel";
            maleAndFemalePrecentageLabel.Size = new System.Drawing.Size(169, 17);
            maleAndFemalePrecentageLabel.TabIndex = 5;
            maleAndFemalePrecentageLabel.Text = "Male/Female Precentage:";
            // 
            // singlePercentageLabel
            // 
            singlePercentageLabel.AutoSize = true;
            singlePercentageLabel.Location = new System.Drawing.Point(345, 54);
            singlePercentageLabel.Name = "singlePercentageLabel";
            singlePercentageLabel.Size = new System.Drawing.Size(128, 17);
            singlePercentageLabel.TabIndex = 7;
            singlePercentageLabel.Text = "Single Percentage:";
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.Home);
            this.HomeTab.Controls.Add(this.FriendsTab);
            this.HomeTab.Controls.Add(this.TimeLineTab);
            this.HomeTab.Controls.Add(this.advanceInfoTab);
            this.HomeTab.Location = new System.Drawing.Point(12, 12);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.SelectedIndex = 0;
            this.HomeTab.Size = new System.Drawing.Size(677, 568);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.SelectedIndexChanged += new System.EventHandler(this.HomeTab_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Home.Controls.Add(this.PostButton);
            this.Home.Controls.Add(this.PostTextBox);
            this.Home.Controls.Add(this.FriendPictureBox);
            this.Home.Controls.Add(this.FriendsListLable);
            this.Home.Controls.Add(this.FriendsListBox);
            this.Home.Controls.Add(this.personalDetailsBox);
            this.Home.Controls.Add(this.WelcomeText);
            this.Home.Controls.Add(this.RememberBox);
            this.Home.Controls.Add(this.LoginButton);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(669, 539);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.PostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PostButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.PostButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostButton.Location = new System.Drawing.Point(503, 109);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(70, 31);
            this.PostButton.TabIndex = 9;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = false;
            this.PostButton.Visible = false;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // PostTextBox
            // 
            this.PostTextBox.Location = new System.Drawing.Point(157, 82);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PostTextBox.Size = new System.Drawing.Size(332, 58);
            this.PostTextBox.TabIndex = 8;
            this.PostTextBox.Visible = false;
            // 
            // FriendPictureBox
            // 
            this.FriendPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FriendPictureBox.BackgroundImage")));
            this.FriendPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FriendPictureBox.ImageLocation = string.Empty;
            this.FriendPictureBox.Location = new System.Drawing.Point(543, 183);
            this.FriendPictureBox.Name = "FriendPictureBox";
            this.FriendPictureBox.Size = new System.Drawing.Size(104, 122);
            this.FriendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendPictureBox.TabIndex = 7;
            this.FriendPictureBox.TabStop = false;
            this.FriendPictureBox.Visible = false;
            // 
            // FriendsListLable
            // 
            this.FriendsListLable.AutoSize = true;
            this.FriendsListLable.Location = new System.Drawing.Point(345, 158);
            this.FriendsListLable.Name = "FriendsListLable";
            this.FriendsListLable.Size = new System.Drawing.Size(115, 17);
            this.FriendsListLable.TabIndex = 6;
            this.FriendsListLable.Text = "Your Friends List";
            this.FriendsListLable.Visible = false;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 16;
            this.FriendsListBox.Location = new System.Drawing.Point(348, 182);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(299, 276);
            this.FriendsListBox.TabIndex = 5;
            this.FriendsListBox.Visible = false;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.FriendsListBox_SelectedIndexChanged);
            // 
            // personalDetailsBox
            // 
            this.personalDetailsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.personalDetailsBox.Location = new System.Drawing.Point(6, 181);
            this.personalDetailsBox.Name = "personalDetailsBox";
            this.personalDetailsBox.Size = new System.Drawing.Size(336, 277);
            this.personalDetailsBox.TabIndex = 4;
            this.personalDetailsBox.TabStop = false;
            this.personalDetailsBox.Text = "Personal Details";
            this.personalDetailsBox.Visible = false;
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WelcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.WelcomeText.Location = new System.Drawing.Point(151, 6);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(309, 64);
            this.WelcomeText.TabIndex = 3;
            this.WelcomeText.Text = "To proceed, please log in\r\nto your facebook account";
            // 
            // RememberBox
            // 
            this.RememberBox.AutoSize = true;
            this.RememberBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RememberBox.Location = new System.Drawing.Point(503, 59);
            this.RememberBox.Name = "RememberBox";
            this.RememberBox.Size = new System.Drawing.Size(144, 27);
            this.RememberBox.TabIndex = 2;
            this.RememberBox.Text = "Remember me";
            this.RememberBox.UseVisualStyleBackColor = true;
            this.RememberBox.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(503, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(144, 47);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FriendsTab
            // 
            this.FriendsTab.AutoScroll = true;
            this.FriendsTab.BackColor = System.Drawing.Color.White;
            this.FriendsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FriendsTab.Controls.Add(maleAndFemalePrecentageLabel);
            this.FriendsTab.Controls.Add(this.maleAndFemalePrecentageLabel1);
            this.FriendsTab.Controls.Add(singlePercentageLabel);
            this.FriendsTab.Controls.Add(this.singlePercentageLabel1);
            this.FriendsTab.Controls.Add(this.label3);
            this.FriendsTab.Controls.Add(this.label2);
            this.FriendsTab.Controls.Add(this.BirthdayFriends);
            this.FriendsTab.Controls.Add(this.TopLikers);
            this.FriendsTab.Controls.Add(this.FriendsNumberPanel);
            this.FriendsTab.Location = new System.Drawing.Point(4, 25);
            this.FriendsTab.Name = "FriendsTab";
            this.FriendsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FriendsTab.Size = new System.Drawing.Size(669, 539);
            this.FriendsTab.TabIndex = 1;
            this.FriendsTab.Text = "Friends Info";
            // 
            // maleAndFemalePrecentageLabel1
            // 
            this.maleAndFemalePrecentageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsListBindingSource, "MaleAndFemalePrecentage", true));
            this.maleAndFemalePrecentageLabel1.Location = new System.Drawing.Point(537, 31);
            this.maleAndFemalePrecentageLabel1.Name = "maleAndFemalePrecentageLabel1";
            this.maleAndFemalePrecentageLabel1.Size = new System.Drawing.Size(127, 23);
            this.maleAndFemalePrecentageLabel1.TabIndex = 6;
            this.maleAndFemalePrecentageLabel1.Text = "label5";
            // 
            // friendsListBindingSource
            // 
            this.friendsListBindingSource.DataSource = typeof(Ex01_Logic.ExtendedFriendsOptions);
            // 
            // singlePercentageLabel1
            // 
            this.singlePercentageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsListBindingSource, "SinglePercentage", true));
            this.singlePercentageLabel1.Location = new System.Drawing.Point(540, 54);
            this.singlePercentageLabel1.Name = "singlePercentageLabel1";
            this.singlePercentageLabel1.Size = new System.Drawing.Size(109, 23);
            this.singlePercentageLabel1.TabIndex = 8;
            this.singlePercentageLabel1.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Up coming birthdays";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Top Likers";
            // 
            // BirthdayFriends
            // 
            this.BirthdayFriends.AllowColumnReorder = true;
            this.BirthdayFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FriendsBirthName,
            this.Birthdate});
            this.BirthdayFriends.Location = new System.Drawing.Point(292, 197);
            this.BirthdayFriends.Name = "BirthdayFriends";
            this.BirthdayFriends.Size = new System.Drawing.Size(323, 271);
            this.BirthdayFriends.TabIndex = 3;
            this.BirthdayFriends.UseCompatibleStateImageBehavior = false;
            this.BirthdayFriends.View = System.Windows.Forms.View.Details;
            // 
            // FriendsBirthName
            // 
            this.FriendsBirthName.Text = "Name";
            this.FriendsBirthName.Width = 105;
            // 
            // Birthdate
            // 
            this.Birthdate.Text = "Birth date";
            this.Birthdate.Width = 132;
            // 
            // TopLikers
            // 
            this.TopLikers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CollumName,
            this.Likes});
            this.TopLikers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopLikers.Location = new System.Drawing.Point(19, 197);
            this.TopLikers.Name = "TopLikers";
            this.TopLikers.Size = new System.Drawing.Size(249, 271);
            this.TopLikers.TabIndex = 3;
            this.TopLikers.UseCompatibleStateImageBehavior = false;
            this.TopLikers.View = System.Windows.Forms.View.Details;
            // 
            // CollumName
            // 
            this.CollumName.Text = "Name";
            this.CollumName.Width = 100;
            // 
            // Likes
            // 
            this.Likes.Text = "Likes";
            this.Likes.Width = 45;
            // 
            // FriendsNumberPanel
            // 
            this.FriendsNumberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.FriendsNumberPanel.Controls.Add(this.label1);
            this.FriendsNumberPanel.Controls.Add(this.numberLabel);
            this.FriendsNumberPanel.Controls.Add(this.FriendsNumberLabel);
            this.FriendsNumberPanel.Location = new System.Drawing.Point(19, 17);
            this.FriendsNumberPanel.Name = "FriendsNumberPanel";
            this.FriendsNumberPanel.Size = new System.Drawing.Size(302, 94);
            this.FriendsNumberPanel.TabIndex = 2;
            this.FriendsNumberPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberLabel.ForeColor = System.Drawing.Color.White;
            this.numberLabel.Location = new System.Drawing.Point(223, 29);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 32);
            this.numberLabel.TabIndex = 0;
            // 
            // FriendsNumberLabel
            // 
            this.FriendsNumberLabel.AutoSize = true;
            this.FriendsNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FriendsNumberLabel.ForeColor = System.Drawing.Color.White;
            this.FriendsNumberLabel.Location = new System.Drawing.Point(10, 29);
            this.FriendsNumberLabel.Name = "FriendsNumberLabel";
            this.FriendsNumberLabel.Size = new System.Drawing.Size(207, 32);
            this.FriendsNumberLabel.TabIndex = 0;
            this.FriendsNumberLabel.Text = "Friends Number:";
            // 
            // TimeLineTab
            // 
            this.TimeLineTab.Controls.Add(this.ImageInfo);
            this.TimeLineTab.Controls.Add(this.FetchPhotoButton);
            this.TimeLineTab.Controls.Add(this.label4);
            this.TimeLineTab.Controls.Add(this.MostLikedPictureBox);
            this.TimeLineTab.Location = new System.Drawing.Point(4, 25);
            this.TimeLineTab.Name = "TimeLineTab";
            this.TimeLineTab.Size = new System.Drawing.Size(669, 539);
            this.TimeLineTab.TabIndex = 2;
            this.TimeLineTab.Text = "Time Line";
            this.TimeLineTab.UseVisualStyleBackColor = true;
            // 
            // ImageInfo
            // 
            this.ImageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ImageInfo.Controls.Add(this.DUploadDate);
            this.ImageInfo.Controls.Add(this.DLikes);
            this.ImageInfo.Controls.Add(this.DPostedBy);
            this.ImageInfo.Controls.Add(this.UploadDateLabel);
            this.ImageInfo.Controls.Add(this.LikesLabel);
            this.ImageInfo.Controls.Add(this.PostByLabel);
            this.ImageInfo.Location = new System.Drawing.Point(202, 386);
            this.ImageInfo.Name = "ImageInfo";
            this.ImageInfo.Size = new System.Drawing.Size(209, 140);
            this.ImageInfo.TabIndex = 6;
            this.ImageInfo.TabStop = false;
            this.ImageInfo.Text = "Image Info";
            // 
            // DUploadDate
            // 
            this.DUploadDate.AutoSize = true;
            this.DUploadDate.Location = new System.Drawing.Point(101, 101);
            this.DUploadDate.Name = "DUploadDate";
            this.DUploadDate.Size = new System.Drawing.Size(0, 17);
            this.DUploadDate.TabIndex = 0;
            // 
            // DLikes
            // 
            this.DLikes.AutoSize = true;
            this.DLikes.Location = new System.Drawing.Point(73, 63);
            this.DLikes.Name = "DLikes";
            this.DLikes.Size = new System.Drawing.Size(0, 17);
            this.DLikes.TabIndex = 0;
            // 
            // DPostedBy
            // 
            this.DPostedBy.AutoSize = true;
            this.DPostedBy.Location = new System.Drawing.Point(73, 22);
            this.DPostedBy.Name = "DPostedBy";
            this.DPostedBy.Size = new System.Drawing.Size(0, 17);
            this.DPostedBy.TabIndex = 0;
            // 
            // UploadDateLabel
            // 
            this.UploadDateLabel.AutoSize = true;
            this.UploadDateLabel.Location = new System.Drawing.Point(7, 101);
            this.UploadDateLabel.Name = "UploadDateLabel";
            this.UploadDateLabel.Size = new System.Drawing.Size(89, 17);
            this.UploadDateLabel.TabIndex = 0;
            this.UploadDateLabel.Text = "Upload date:";
            // 
            // LikesLabel
            // 
            this.LikesLabel.AutoSize = true;
            this.LikesLabel.Location = new System.Drawing.Point(8, 63);
            this.LikesLabel.Name = "LikesLabel";
            this.LikesLabel.Size = new System.Drawing.Size(45, 17);
            this.LikesLabel.TabIndex = 0;
            this.LikesLabel.Text = "Likes:";
            // 
            // PostByLabel
            // 
            this.PostByLabel.AutoSize = true;
            this.PostByLabel.Location = new System.Drawing.Point(6, 22);
            this.PostByLabel.Name = "PostByLabel";
            this.PostByLabel.Size = new System.Drawing.Size(60, 17);
            this.PostByLabel.TabIndex = 0;
            this.PostByLabel.Text = "Post By:";
            // 
            // FetchPhotoButton
            // 
            this.FetchPhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.FetchPhotoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FetchPhotoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FetchPhotoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FetchPhotoButton.Location = new System.Drawing.Point(106, 26);
            this.FetchPhotoButton.Name = "FetchPhotoButton";
            this.FetchPhotoButton.Size = new System.Drawing.Size(416, 47);
            this.FetchPhotoButton.TabIndex = 2;
            this.FetchPhotoButton.Text = "Fetch the most liked photos";
            this.FetchPhotoButton.UseVisualStyleBackColor = false;
            this.FetchPhotoButton.Click += new System.EventHandler(this.FetchPhotoButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // MostLikedPictureBox
            // 
            this.MostLikedPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.MostLikedPictureBox.Location = new System.Drawing.Point(106, 79);
            this.MostLikedPictureBox.Name = "MostLikedPictureBox";
            this.MostLikedPictureBox.Size = new System.Drawing.Size(416, 293);
            this.MostLikedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MostLikedPictureBox.TabIndex = 0;
            this.MostLikedPictureBox.TabStop = false;
            // 
            // advanceInfoTab
            // 
            this.advanceInfoTab.Controls.Add(this.AcceptButton);
            this.advanceInfoTab.Controls.Add(this.HeadlineInfoLabel);
            this.advanceInfoTab.Controls.Add(this.ActionChooseComboBox);
            this.advanceInfoTab.Location = new System.Drawing.Point(4, 25);
            this.advanceInfoTab.Name = "advanceInfoTab";
            this.advanceInfoTab.Size = new System.Drawing.Size(669, 539);
            this.advanceInfoTab.TabIndex = 3;
            this.advanceInfoTab.Text = "Advance info";
            this.advanceInfoTab.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AcceptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptButton.Location = new System.Drawing.Point(183, 54);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(144, 47);
            this.AcceptButton.TabIndex = 5;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // HeadlineInfoLabel
            // 
            this.HeadlineInfoLabel.AutoSize = true;
            this.HeadlineInfoLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HeadlineInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.HeadlineInfoLabel.Location = new System.Drawing.Point(12, 16);
            this.HeadlineInfoLabel.Name = "HeadlineInfoLabel";
            this.HeadlineInfoLabel.Size = new System.Drawing.Size(183, 32);
            this.HeadlineInfoLabel.TabIndex = 4;
            this.HeadlineInfoLabel.Text = "Choose action:";
            // 
            // ActionChooseComboBox
            // 
            this.ActionChooseComboBox.FormattingEnabled = true;
            this.ActionChooseComboBox.Items.AddRange(new object[] {
            "Events Info",
            "Pages Info"});
            this.ActionChooseComboBox.Location = new System.Drawing.Point(18, 68);
            this.ActionChooseComboBox.Name = "ActionChooseComboBox";
            this.ActionChooseComboBox.Size = new System.Drawing.Size(144, 24);
            this.ActionChooseComboBox.TabIndex = 0;
            // 
            // PictureChangingTimer
            // 
            this.PictureChangingTimer.Interval = 3000;
            this.PictureChangingTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(703, 592);
            this.Controls.Add(this.HomeTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facebook App";
            this.HomeTab.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FriendsTab.ResumeLayout(false);
            this.FriendsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsListBindingSource)).EndInit();
            this.FriendsNumberPanel.ResumeLayout(false);
            this.FriendsNumberPanel.PerformLayout();
            this.TimeLineTab.ResumeLayout(false);
            this.ImageInfo.ResumeLayout(false);
            this.ImageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostLikedPictureBox)).EndInit();
            this.advanceInfoTab.ResumeLayout(false);
            this.advanceInfoTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HomeTab;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage FriendsTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox RememberBox;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.GroupBox personalDetailsBox;
        private System.Windows.Forms.Label FriendsListLable;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.PictureBox FriendPictureBox;
        private System.Windows.Forms.Label FriendsNumberLabel;
        private System.Windows.Forms.Panel FriendsNumberPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView BirthdayFriends;
        private System.Windows.Forms.ListView TopLikers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberLabel;
        private ColumnHeader CollumName;
        private System.Windows.Forms.ColumnHeader Likes;
        private ColumnHeader FriendsBirthName;
        private ColumnHeader Birthdate;
        private TabPage TimeLineTab;
        private PictureBox MostLikedPictureBox;
        private Timer PictureChangingTimer;
        private Label label4;
        private Button FetchPhotoButton;
        private GroupBox ImageInfo;
        private Label DUploadDate;
        private Label DLikes;
        private Label DPostedBy;
        private Label UploadDateLabel;
        private Label LikesLabel;
        private Label PostByLabel;
        private BindingSource friendsListBindingSource;
        private Label maleAndFemalePrecentageLabel1;
        private Label singlePercentageLabel1;
        private TabPage advanceInfoTab;
        private Label HeadlineInfoLabel;
        private ComboBox ActionChooseComboBox;
        private Button AcceptButton;
        private Button PostButton;
        private TextBox PostTextBox;
    }
}
