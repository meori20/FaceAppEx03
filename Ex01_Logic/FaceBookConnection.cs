using System;
using FacebookWrapper;

namespace Ex01_Logic
{   
    public sealed class FaceBookConnection
    {
        private static FaceBookConnection s_FaceBookConnection = null;
        private static Object s_LockObject = new object();
        public LoginResult Connection { get; private set; }

        private FaceBookConnection()
        {
        }

        public static FaceBookConnection ConnectToFacebookAPI(string i_AccessToken)
        {
            if (s_FaceBookConnection == null)
            {
                lock (s_LockObject)
                {
                    if (s_FaceBookConnection == null)
                    {
                        if (s_FaceBookConnection == null)
                        {
                            s_FaceBookConnection = new FaceBookConnection();
                            s_FaceBookConnection.Connection = FacebookService.Connect(i_AccessToken);
                        }
                    }
                }
            }

            return s_FaceBookConnection;
        }

        public static FaceBookConnection GetFacebookConnection()
        {
            if (s_FaceBookConnection == null)
            {
                lock (s_LockObject)
                {
                    if (s_FaceBookConnection == null)
                    {
                        s_FaceBookConnection = new FaceBookConnection();
                        s_FaceBookConnection.Connection = FacebookService.Login("270527433431234", "publish_actions",
                            "public_profile",
                            "email", "user_birthday", "user_relationships", "user_relationship_details", "user_likes",
                            "user_hometown", "user_location", "user_education_history", "user_friends", "user_posts",
                            "user_photos", "user_events", "rsvp_event");
                    }
                }
            }

            return s_FaceBookConnection;
        }

        public String GetAccsessToken()
        {
            string accessToken = null;
            if (s_FaceBookConnection != null)
            {
                accessToken = s_FaceBookConnection.Connection.AccessToken;
            }

            return accessToken;
        }

        public static FaceBookConnection LogOut()
        {
            FacebookService.Logout(() => { });
            s_FaceBookConnection = null;
            return s_FaceBookConnection;
        }
    }   
}
