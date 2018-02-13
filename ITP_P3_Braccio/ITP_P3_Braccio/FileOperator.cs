using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITP_P3_Braccio
{
    public static class FileOperator
    {
        public static bool WriteConfig(string path, Configuration config)
        {
            bool operatingWell = true;              //shows, if operation has gone fine or wrong
            StringBuilder sb = new StringBuilder(); //in sb the whole text, which has to be saved in the file, is stored
            TextWriter tw;                          //TextWrite to write into the file

            try
            {
                using (tw = new StreamWriter(path)) // disposes tw after use
                {
                    sb.Append(config.EnginePause);  //write(append) EnginePause(first line in file) into sb
                    sb.Append("\r\n");

                    foreach (SavedPosition p in config.StandardPositions) //run through all Positions in config
                    {
                        sb.Append(p.Name);          //always append one part of the config to the sb
                        sb.Append(';');             //and then always append a simicolon or carriage return line feed
                        sb.Append(p.BasicAngle);
                        sb.Append(';');
                        sb.Append(p.SoulderAngle);
                        sb.Append(';');
                        sb.Append(p.EllbowAngle);
                        sb.Append(';');
                        sb.Append(p.HandAngle_ver);
                        sb.Append(';');
                        sb.Append(p.HandAngle_rot);
                        sb.Append(';');
                        sb.Append(p.Gripper);
                        sb.Append("\r\n");
                    }

                    tw.Write(sb.ToString());        //now the content of sb is really written into the file
                }
            }
            catch (Exception ex)                    //if something went wrong exception is thrown and "false" is returned
            {
                operatingWell = false;
                throw new Exception(ex.Message);
            }
            
            return operatingWell;
        }

        public static Configuration ReadConfig(string path)
        {
            string rowValue;
            string[] cellValues;
            Configuration config = new Configuration();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    // read enginePause from first line
                    if (sr.Peek() != -1)
                    {
                        rowValue = sr.ReadLine();
                        config.EnginePause = Int32.Parse(rowValue);
                    }
                    else
                    {
                        throw new IOException("file is empty");
                    }

                    // read saved Positions from other lines
                    for (int i = 0; sr.Peek() != -1; i++)
                    {
                        rowValue = sr.ReadLine();
                        cellValues = rowValue.Split(';');

                        config.StandardPositions.Add(new SavedPosition(
                                cellValues[0],  // Name 
                                Int32.Parse(cellValues[1]), // BaseAngle
                                Int32.Parse(cellValues[2]), // ShoulderAngle
                                Int32.Parse(cellValues[3]), // EllbowAngle
                                Int32.Parse(cellValues[4]), // Wrist_vert
                                Int32.Parse(cellValues[5]), // Wrist_rot
                                Int32.Parse(cellValues[6])  // Gripper
                                ));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
            return config;
        }

        public static bool WriteMovement(string path, ControlList list)
        {
            return true;
        }
    }
}
