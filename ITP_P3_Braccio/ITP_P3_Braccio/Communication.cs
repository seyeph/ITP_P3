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
        public static void Move(string Port, ControlList controlList)
        {
            SerialPort port = new SerialPort(Port);
            try
            {
                port.Open();
                foreach (Movement m in controlList)
                {
                    if (m is Position)
                    {
                        Position position = (Position)m;

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
                port.Close();
            }
        }
    }
}
