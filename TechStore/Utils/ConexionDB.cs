

namespace TechStore.Utils
{
    public class ConexionDB
    {
        public static string DevolverRuta(string nombreDB)
        {
            string pathDB = string.Empty;

            if(DeviceInfo.Platform == DevicePlatform.Android)
            {
                pathDB = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                pathDB = Path.Combine(pathDB, nombreDB);

            } else if(DeviceInfo.Platform == DevicePlatform.iOS)
            {
                pathDB = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                pathDB = Path.Combine(pathDB, "..", "Library", nombreDB);

            } 

            return pathDB;

        }
        
    }
}