namespace AppLogic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    public class FakeUser
    {
        public string Name { get; set; }
        public List<string> Movies { get; set; }
        public List<string> Musics { get; set; }
        public List<string> Books { get; set; }
        public List<string> Sports { get; set; }
        public List<string> Seasons { get; set; }
        public List<string> Holiday { get; set; }
        public List<string> Groups { get; set; }

        public static Dictionary<int, FakeUser> LoadFriends()
        {
            List<FakeUser> friendsList = new List<FakeUser>();
            string friendListFilePath = FilePath.GetResourcePath("FriendsList.xml");
            Dictionary<int, FakeUser> friendDictionary = new Dictionary<int, FakeUser>();

            if (File.Exists(friendListFilePath))
            {
                using (Stream stream = new FileStream(friendListFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(friendsList.GetType());

                    friendsList = serializer.Deserialize(stream) as List<FakeUser>;
                }

                for (int i = 0; i < friendsList.Count; i++)
                {
                    friendDictionary.Add(i, friendsList[i]);
                }
            }
            else
            {
                throw new FileNotFoundException("Could not find FriendsList.xml");
            }

            return friendDictionary;
        }

        public static string GetFakeUserImage(string i_SelectedFakeUserName)
        {
            string friendImage = $"{i_SelectedFakeUserName}.jpg";
            string filePath = FilePath.GetResourcePath(friendImage);

            return filePath;
        }
    }
}