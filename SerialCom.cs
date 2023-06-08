using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace TELEMETRIAOBSIDIAN
{
    static public class SerialCom
    {
        public static SerialPort serialPort1 { get; set; } = new SerialPort();
        //private static System.Timers.Timer aTimer;
        static SerialCom()
        {
            InitializeSerialPort();
        }
        private static void InitializeSerialPort()
        {
            // Suscribirse al evento DataReceived
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }


        #region Comunicacion Serial y Lectura de datos
        //--------------------------------Conf de lectura serial y acciones --------------------------       

        private static void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                try
                {
                    string pattern = @"\r\n|\r|\n";
                    string serialData = serialPort1.ReadLine();
                    serialData = Regex.Replace(serialData, pattern, "");
                    ComForms.WriteToConsole(serialData);

                    if (serialData.StartsWith("$Data:"))
                    {
                        ComForms.ModifyCharts(serialData);
                        ComForms.ChangeRocketComState1(1);
                    }
                    else if (serialData == "$GoodCom")
                    {

                        ComForms.ChangeRocketComState1(1);
                    }
                    else if(serialData == "$ErrorCom")
                    {
                        ComForms.ChangeRocketComState1(2);
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }


            }
        }

        #endregion
        
    }


}
