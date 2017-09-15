using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01_Logic
{
    public class UserDataFacade
    {
        public string FullName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string ProfilePicture { get; }
        public string Birthday { get; }
        public string Email { get; }
        public string Location { get; }
        public string Gender { get; }
        public int FriendsNumber { get; }
        public string RelationshipStatus { get; }        
        public Dictionary<string, string> FriendList { get; }
        public ExtendedFriendsOptions ExtendedFriendsList { get; }
        public FacebookObjectCollection<Page> Pages { get; }
        public FacebookObjectCollection<Event> Events { get; }
        public FaceBookConnection FaceBookConnection { get; }

        public UserDataFacade(FaceBookConnection i_FaceBookConnection)
        {
            this.FaceBookConnection = i_FaceBookConnection;
            FullName =
                $"{FaceBookConnection.Connection.LoggedInUser.FirstName} {this.FaceBookConnection.Connection.LoggedInUser.LastName}";
            FirstName = this.FaceBookConnection.Connection.LoggedInUser.FirstName;
            LastName = FaceBookConnection.Connection.LoggedInUser.LastName;
            ProfilePicture = FaceBookConnection.Connection.LoggedInUser.PictureNormalURL;
            Birthday = FaceBookConnection.Connection.LoggedInUser.Birthday;
            Email = FaceBookConnection.Connection.LoggedInUser.Email;
            Location = FaceBookConnection.Connection.LoggedInUser.Location.Name;
            Gender = FaceBookConnection.Connection.LoggedInUser.Gender.ToString();
            RelationshipStatus = FaceBookConnection.Connection.LoggedInUser.RelationshipStatus.ToString();
            FriendsNumber = FaceBookConnection.Connection.LoggedInUser.Friends.Count;
            FriendList = new Dictionary<string, string>();
            ExtendedFriendsList = new ExtendedFriendsOptions(FaceBookConnection.Connection.LoggedInUser.Friends);
            Pages = FaceBookConnection.Connection.LoggedInUser.LikedPages;
            Events = FaceBookConnection.Connection.LoggedInUser.Events;
            foreach (User friend in FaceBookConnection.Connection.LoggedInUser.Friends)
            {
                FriendList.Add(
                    friend.FirstName + " " +
                    friend.LastName,
                    friend.PictureNormalURL);
            }
        }

        public List<KeyValuePair<string, int>> GetFriendLikes()
        {
            Dictionary<string, int> FriendsLikesDictionary = new Dictionary<string, int>();
            foreach (Post post in FaceBookConnection.Connection.LoggedInUser.Posts)
            {
                if (FaceBookConnection.Connection.LoggedInUser.Name == post.From.Name)
                {
                    foreach (User user in post.LikedBy)
                    {
                        if (FriendsLikesDictionary.ContainsKey(user.Name))
                        {
                            FriendsLikesDictionary[user.Name]++;
                        }
                        else
                        {
                            FriendsLikesDictionary.Add(user.Name, 1);
                        }
                    }    
                }
            }

            List<KeyValuePair<string, int>> friendsLikes = FriendsLikesDictionary.ToList();
            friendsLikes.Sort((i_Pair1, i_Pair2) => i_Pair2.Value.CompareTo(i_Pair1.Value));
            return friendsLikes;
        }

        public List<KeyValuePair<string, string>> GetPersonalDetails()
        {
            List<KeyValuePair<string, string>> personalDetails = new List<KeyValuePair<string, string>>();
            if (!string.IsNullOrEmpty(Birthday))
            {
                personalDetails.Add(new KeyValuePair<string, string>("Birthday: ", Birthday));
            }

            if (!string.IsNullOrEmpty(Email))
            {
                personalDetails.Add(new KeyValuePair<string, string>("Email: ", Email));
            }

            if (!string.IsNullOrEmpty(Location))
            {
                personalDetails.Add(new KeyValuePair<string, string>("Location: ", Location));
            }
            
            if (!string.IsNullOrEmpty(Gender))
            {
                personalDetails.Add(new KeyValuePair<string, string>("Gender: ", Gender));
            }

            if (!string.IsNullOrEmpty(RelationshipStatus))
            {
                personalDetails.Add(new KeyValuePair<string, string>("Relationship\nStatus: ", RelationshipStatus));
            }

            return personalDetails;
        }

        public List<KeyValuePair<string, DateTime>> GetFriendsBirthdays()
        {
            List<KeyValuePair<string, DateTime>> friendsBirthdays;
            Dictionary<string, DateTime> friendsBirthdaysDictionary = new Dictionary<string, DateTime>();
            foreach (User user in FaceBookConnection.Connection.LoggedInUser.Friends)
            {
                friendsBirthdaysDictionary.Add(user.Name, DateTime.Parse(user.Birthday));
            }

            friendsBirthdays = friendsBirthdaysDictionary.ToList();
            friendsBirthdays.Sort(delegate(KeyValuePair<string, DateTime> pair1,
                KeyValuePair<string, DateTime> pair2)
            {
                DateTime nowDate = DateTime.Now;
                DateTime firstDateToCompare = new DateTime(nowDate.Year, pair1.Value.Month, pair1.Value.Day);
                DateTime secondDateToCompare = new DateTime(nowDate.Year, pair2.Value.Month, pair2.Value.Day);
                
                if (firstDateToCompare.CompareTo(nowDate) < 0)
                {
                    firstDateToCompare = firstDateToCompare.AddYears(1);
                }

                if (secondDateToCompare.CompareTo(nowDate) < 0)
                {
                    secondDateToCompare = secondDateToCompare.AddYears(1);
                }

                TimeSpan t1 = nowDate - firstDateToCompare;
                TimeSpan t2 = nowDate - secondDateToCompare;
                return t2.Days - t1.Days;
            });

            return friendsBirthdays;
        }

        public List<Object[]> GetTopLikedImages()
        {
            List<Object[]> topLikedImages = new List<object[]>();
            lock (Thread.CurrentThread) 
            {
                FacebookService.s_CollectionLimit = 50;
                List<Photo> photosOrderedByLikes = FaceBookConnection.Connection.LoggedInUser.PhotosTaggedIn.ToList();
                FacebookService.s_CollectionLimit = 1000;
                photosOrderedByLikes.Sort(delegate(Photo i_Photo, Photo i_Photo1)
                {
                    return i_Photo1.LikedBy.Count - i_Photo.LikedBy.Count;
                });
                for (int i = 0; i < 5; i++)
                {
                    object[] photoToAdd = new object[4];
                    photoToAdd[0] = photosOrderedByLikes[i].PictureNormalURL;
                    photoToAdd[1] = photosOrderedByLikes[i].LikedBy.Count;
                    photoToAdd[2] = photosOrderedByLikes[i].CreatedTime.Value.ToShortDateString().ToString();
                    photoToAdd[3] = photosOrderedByLikes[i].From.Name;
                    topLikedImages.Add(photoToAdd);
                }

                FacebookService.s_CollectionLimit = 25;
                return topLikedImages;
            }
        }

        public void PostOnFaceBook(string i_post)
        {
            FaceBookConnection.Connection.LoggedInUser.PostStatus(i_post);
        }
    }
}
