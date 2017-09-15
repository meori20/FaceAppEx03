using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01_Logic
{
    public class EventsInfoDisplay : FaceBookInfoDisplay
    {
        public EventsInfoDisplay(UserDataFacade i_userData) : base(i_userData)
        {
        }

        protected override void PopulateListBox()
        {
            m_HeadLineLabel.Text = "Your liked events info:";
            m_ListBox.DisplayMember = "Name";
            foreach (Event likedEvent in m_UserData.Events)
            {
                m_ListBox.Items.Add(likedEvent);
            }

            m_ListBox.SelectedIndexChanged += delegate(object i_Sender, EventArgs i_Args)
            {
                Event selcetedEvent = m_ListBox.SelectedItem as Event;
                if (selcetedEvent != null)
                {
                    m_Picture.Load(selcetedEvent.PictureNormalURL);
                    m_UrlLable.Text = "Event link: " + selcetedEvent.LinkToFacebook;
                    m_NameLabel.Text = "Name: " + selcetedEvent.Name;
                }
            };
        }
    }
}
