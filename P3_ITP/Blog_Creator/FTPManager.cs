/**
 * author:      Fragner Julian
 * class:       4aHIT 1718
 * project:     P02 - RemoteControl
 * purpose:    Receives Text from an FTP-Server and passes it to an microcontroller
*/

using System.Net;

namespace Blog_Creator
{
    class FTPManager
    {
        #region StaticFunctions
        public static byte[] getFileData(string url, string user, string passw)
        {
            WebClient request = new WebClient();
            request.Credentials = new NetworkCredential(user, passw);

            byte[] newFileData = request.DownloadData(url);

            return newFileData;
        }
        #endregion
    }
}

// END OF FILE
