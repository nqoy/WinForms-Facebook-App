namespace AppLogic
{
    using System.IO;

    public static class FilePath
    {
        private static readonly string sr_FilePath;

        static FilePath()
        {
            sr_FilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\"));
        }

        public static string GetResourcePath(string i_FileName)
        {
            return Path.Combine(sr_FilePath, "Resources", i_FileName);
        }
    }
}
