namespace AppLogic
{
    using System.IO;
    using System.Xml.Serialization;

    public class AppSettings
    {
        private static readonly string sr_SettingsFilePath = FilePath.GetResourcePath("N&BSetting.xml");
        public string LastLoginAccessToken { get; set; }
        public bool IsRememberMeChecked { get; set; }

        public static AppSettings LoadFromXmlFile()
        {
            AppSettings userSetting = new AppSettings();

            if (File.Exists(sr_SettingsFilePath))
            {
                using (Stream stream = new FileStream(sr_SettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));

                    userSetting = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return userSetting;
        }

        public void SaveToXmlFile()
        {
            if (!File.Exists(sr_SettingsFilePath))
            {
                Stream stream = new FileStream(sr_SettingsFilePath, FileMode.Create);

                stream.Dispose();
            }

            using (Stream stream = new FileStream(sr_SettingsFilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());

                serializer.Serialize(stream, this);
            }
        }
    }
}
