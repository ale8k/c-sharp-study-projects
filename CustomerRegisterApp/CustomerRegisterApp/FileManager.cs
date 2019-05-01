using System.IO;
namespace CustomerRegisterApp
{
    public class FileManager
    {
        private readonly FileInfo _fi;
        private string path = Path.GetFullPath("Customers"); // wasn't sure if this is good practice...

        public FileManager()
        {
            _fi = new FileInfo(path);

            CreateDirectory(path);
        }

        private void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
