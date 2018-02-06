using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITP_P3_Braccio
{
    class FileOperator
    {
        public bool writeFile(string path, string coords) {
            bool operatingWell = true;

            StreamWriter sw = new StreamWriter(path);

            try
            {
                sw.Write(coords);
            }
            catch (Exception e)
            {
                operatingWell = false;
                throw new Exception(e.Message);
            }
            finally
            {
                sw.Close();
            }
            return operatingWell;
        }

        /*public bool readFile(string path)
        {
            bool operatingWell = true;

            //was i nu ned :D
        }*/
    }
}
