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
        public bool writeConfig(string path, Configuration config)
        {

            bool operatingWell = true;
            string textToWrite = "";
            TextWriter tw = new StreamWriter(path);
            StringBuilder sb = new StringBuilder();

            sb.Append(config.EnginePause);
            sb.Append("\r\n");

            foreach(SavedPosition p in config.StandardPositions)
            {
                sb.Append(p.Name);
                sb.Append(';');
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

        public Configuration readConfig(string path)
        {
            string rowValue;
            string[] cellValues;
            Configuration config = new Configuration();

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                try
                {
                    // read enginePause from first line
                    if(sr.Peek() != -1)
                    {
                        rowValue = sr.ReadLine();
                        config.EnginePause = Int32.Parse(rowValue);
                    }

                    // read saved Positions from other lines
                    for(int i = 0; sr.Peek() != -1; i++)
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
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sr.Close();
                }
            }
            return config;
        }
    }
}
