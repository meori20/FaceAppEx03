using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ex01_Logic
{
    public abstract class FaceBookInfoDisplay
    {
        protected Label m_HeadLineLabel = new Label();
        protected Label m_NameLabel = new Label();
        protected Label m_UrlLable = new Label();
        protected ListBox m_ListBox = new ListBox();
        protected PictureBox m_Picture = new PictureBox();
        protected UserDataFacade m_UserData;

        protected FaceBookInfoDisplay(UserDataFacade i_userData)
        {
            m_UserData = i_userData;
        }

        public List<Control> GetInfoDisplay()
        {
            List<Control> controls = new List<Control>();
            m_HeadLineLabel.Location = new Point(6, 3);
            m_HeadLineLabel.AutoSize = true;
            m_HeadLineLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 177);
            m_HeadLineLabel.ForeColor = System.Drawing.Color.FromArgb(139, 157, 195);
            m_ListBox.Location = new Point(6, 78);
            m_ListBox.Size = new Size(207, 186);
            m_Picture.Location = new Point(232, 78);
            m_Picture.Size = new Size(90, 90);
            m_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            m_NameLabel.Location = new Point(6, 292);
            m_UrlLable.Location = new Point(6, 328);
            m_UrlLable.AutoSize = true;

            PopulateListBox();
            controls.Add(m_UrlLable);
            controls.Add(m_NameLabel);
            controls.Add(m_Picture);
            controls.Add(m_ListBox);
            controls.Add(m_HeadLineLabel);
            return controls;
        }

        protected abstract void PopulateListBox();
    }
}
