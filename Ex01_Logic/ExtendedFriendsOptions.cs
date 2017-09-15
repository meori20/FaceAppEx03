using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01_Logic
{
    public class ExtendedFriendsOptions
    {
        public FacebookObjectCollection<User> FriendList { get; private set; }
        public string SinglePercentage { get; private set; }
        public string MaleAndFemalePrecentage { get; private set; }

        public ExtendedFriendsOptions(FacebookObjectCollection<User> i_FriendList)
        {
            FriendList = i_FriendList;
            setSinglePercentage();
            setMaleAndFemalePrecentage();
        }

        private void setSinglePercentage()
        {
            SinglePercentage = null;
            float attendingSingle = 0;
            foreach (User attendingUser in FriendList)
            {
                if (attendingUser.RelationshipStatus == User.eRelationshipStatus.Single)
                {
                    attendingSingle++;
                }              
            }

            if (FriendList.Count != 0)
            {
                SinglePercentage = string.Format(@"{0:0.#}%", (attendingSingle / FriendList.Count) * 100f);
            }
        }

        private void setMaleAndFemalePrecentage()
        {
            float maleCount = 0;
            MaleAndFemalePrecentage = null;
            foreach (User friend in FriendList)
            {
                if (friend.Gender == User.eGender.male)
                {
                    maleCount++;
                }
            }

            MaleAndFemalePrecentage =
                string.Format(@"{0:0.#}%/{1:0.#}", maleCount / FriendList.Count * 100f,
                    100 - (maleCount / FriendList.Count * 100f));
        } 
    }   
}