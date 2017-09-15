using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Ex01_Logic
{
    public class AppSettings
    {
        public String AcssessToken { get; set; }
        public Point StartingLocation { get; set; }
        public bool RememberMe { get; set; }

        private AppSettings()
        {
            AcssessToken = null;
            StartingLocation = new Point(500, 500);
            RememberMe = false;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();
            if (File.Exists(@"AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }
    }
}
