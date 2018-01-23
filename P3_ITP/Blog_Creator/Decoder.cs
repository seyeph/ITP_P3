/**
 * author:      Fragner Julian
 * class:       4aHIT 1718
 * project:     P02 - RemoteControl
 * purpose:    Receives Text from an FTP-Server and passes it to an microcontroller
*/

using System.Text;

namespace Blog_Creator
{
    class Decoder
    {
        #region StaticFunctions
        public static string ByteArrayToString (byte[] arr)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            return ascii.GetString(arr);
        }
        #endregion
    }
}

// END OF FILE
