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
        public bool writeConfig(string path, Configuration listofPositions)
        {

            bool operatingWell = true;
            string textToWrite = "";
            TextWriter tw = new StreamWriter(path);

            // textToWrite = ...

            try
            {
                tw.Write(textToWrite);
            }
            catch (Exception e)
            {
                operatingWell = false;
                throw new Exception(e.Message);
            }
            finally
            {
                tw.Close();
            }
            return operatingWell;
        }

        public object readConfig(string path)
        {
            string rowValue;
            string[] cellValues;
            Position[] fileInput = new Position[100];

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                try
                {
                    for(int i = 0; sr.Peek() != -1; i++)
                    {
                        rowValue = sr.ReadLine();
                        cellValues = rowValue.Split(';');

                        fileInput[i] = new Position(
                                Int32.Parse(cellValues[0].ToString()),
                                Int32.Parse(cellValues[1].ToString()),
                                Int32.Parse(cellValues[2].ToString()),
                                Int32.Parse(cellValues[3].ToString()),
                                Int32.Parse(cellValues[4].ToString()),
                                Int32.Parse(cellValues[5].ToString())
                                );

                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sr.Close();
                }
            }
            return null;
        }
    }
}
