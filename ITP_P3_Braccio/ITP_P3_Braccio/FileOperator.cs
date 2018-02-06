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
        public bool writeFile(string path, Position input) {

            bool operatingWell = true;
            string textToWrite = "";
            TextWriter tw = new StreamWriter(path);

            // textToWrite = ...

            try
            {
                sw.Write(textToWrite);
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

        public bool readFile(string path) //not finally
        {
            bool operatingWell = true;
            string readValue = "";
            //Bewegung readInputBewegung = new Bewegung();

            TextReader tr = new StreamReader(path);

            try
            {
                readValue = sr.ReadToEnd();

                //readInputBewegung = 
            }
            catch (Exception e)
            {
                operatingWell = false;
                throw new Exception(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return operatingWell;
        }
    }
}
