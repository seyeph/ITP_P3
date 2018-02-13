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
        public static bool WriteConfig(string path, Configuration config)   //write settings from program to file
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

        public static Configuration ReadConfig(string path)                 //read settings from file to program
        {
            string rowValue;        //the whole file is read in rows, here the whole row is saved
            string[] cellValues;    //the rowValue is splitten into the several cellValues into an array
            Configuration config = new Configuration(); //in config, everything is saved

            try
            {
                using (StreamReader sr = new StreamReader(path))    //StreamReader to read the file in rows
                {
                    // read enginePause from first line
                    if (sr.Peek() != -1)                            //if file is not empty
                    {
                        rowValue = sr.ReadLine();                   //first line is read
                        config.EnginePause = Int32.Parse(rowValue); //whole line is converted to integer and saved in config
                    }
                    else                                            //file is empty
                    {
                        throw new IOException("file is empty");     //throw exception with message
                    }

                    // read saved Positions from other lines
                    for (int i = 0; sr.Peek() != -1; i++)           //while file-end is not reached
                    {
                        rowValue = sr.ReadLine();                   //read next line in file
                        cellValues = rowValue.Split(';');           //whole line is splitted into cellValues

                        config.StandardPositions.Add(new SavedPosition( //every line is saved in config
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
            catch (Exception e)                     //if something went wrong exception is thrown
            {
                throw new Exception(e.Message);     //throw exception
            }
            
            return config;                          //return whole configuration
        }

        public static bool WriteMovement(string path, ControlList list)     //write movements from program to file
        {
            return true;
        }
    }
}
