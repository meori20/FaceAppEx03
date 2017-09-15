using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01_Logic
{
    public class PageInfoDisplay : FaceBookInfoDisplay
    {
        public PageInfoDisplay(UserDataFacade i_userData) : base(i_userData)
        {
        }

        protected override void PopulateListBox()
        {
            m_HeadLineLabel.Text = "Your liked page info:";
            m_ListBox.DisplayMember = "Name";
            foreach (Page page in m_UserData.Pages)
            {
                m_ListBox.Items.Add(page);
            }

            m_ListBox.SelectedIndexChanged += delegate(object i_Sender, EventArgs i_Args)
            {
                Page selcetedPage = m_ListBox.SelectedItem as Page;
                if (selcetedPage != null)
                {
                    m_Picture.Load(selcetedPage.PictureURL);
                    m_UrlLable.Text = "Page link: " + selcetedPage.URL;
                    m_NameLabel.Text = "Name: " + selcetedPage.Name;
                }
            };
        }
    }
}
