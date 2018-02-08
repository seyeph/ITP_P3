using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace ITP_P3_Braccio
{
    public static class Communication
    {
        public static void Move(string port, int motorPause, ControlList controlList)
        {
            SerialPort sPort = new SerialPort(port);
            StringBuilder sb = new StringBuilder();
            try
            {
                sPort.Open();
                sb.Clear();
                foreach (IMovement m in controlList)
                {
                    // parses the IMovement into a Position if possible
                    // and writes it to the serial port
                    if (m is Position position) 
                    {
                        sb.Append(motorPause);
                        sb.Append(';');
                        sb.Append(position.BasicAngle);
                        sb.Append(';');
                        sb.Append(position.SoulderAngle);
                        sb.Append(';');
                        sb.Append(position.EllbowAngle);
                        sb.Append(';');
                        sb.Append(position.HandAngle_ver);
                        sb.Append(';');
                        sb.Append(position.HandAngle_rot);
                        sb.Append(';');
                        sb.Append(position.Gripper);

                        sPort.Write(sb.ToString());
                        sPort.ReadExisting();   // wait for message
                    }
                    else
                    {
                        if (m is Pause)
                        {
                            Task.Delay(((Pause)m).Pause_ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sPort.Close();
            }
        }
    }
}
