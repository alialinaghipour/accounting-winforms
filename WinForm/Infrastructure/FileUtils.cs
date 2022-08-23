namespace WinForm.Infrastructure
{
    internal static class FileUtils
    {
        public static void Delete(string path)
        {
            System.IO.File.Delete(path);
        }

        public static string GetExtension(string location)
        {
            return System.IO.Path.GetExtension(location);
        }
    }
}
