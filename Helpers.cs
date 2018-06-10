using System.IO;

namespace PeopleSearch
{
    public class Helpers
    {
        public static byte[] FileToByteArray(string path){
            FileInfo fileInfo = new FileInfo(path);

            byte[] data = new byte[fileInfo.Length];

            using (FileStream fs = fileInfo.OpenRead())
            {
                fs.Read(data, 0, data.Length);
            }

            return data;
        }
    }
}