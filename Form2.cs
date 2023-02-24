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
    public partial class Form2 : Form
    {
        #region Variables
        List<string> keys = new List<string> { "t", "T", "A", "P", "ax", "ay", "az", "acx", "acy", "acz", "Pa", "V" };
        Dictionary<string, string> data = new Dictionary<string, string>();

        bool transButtonState = false;
        #endregion

        public Form2()
        {
            InitializeComponent();
        }

       // #region Comunicacion Serial y Lectura de datos
       //// --------------------------------Conf de lectura serial y acciones --------------------------       
       // private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
       // {
       //     while (SerialCom.serialPort1.IsOpen && SerialCom.serialPort1.BytesToRead > 0)
       //     {
       //         try
       //         {
       //             string pattern = @"\r\n|\r|\n";
       //             string serialData = SerialCom.serialPort1.ReadLine();
       //             serialData = Regex.Replace(serialData, pattern, "");
       //             Console.WriteLine(serialData);
       //             if (serialData.StartsWith("$Data:"))
       //             {
       //                 string[] measures = serialData.Substring(6).Split(',');
       //                 List<string> receivedKeys = new List<string>();
       //                 Console.WriteLine(serialData);
       //                 foreach (string measure in measures)
       //                 {
       //                     //Verificar el formato correcto
       //                     string[] parts = measure.Split('=');
       //                     if (parts.Length != 2)
       //                     {
       //                         Console.WriteLine("Error en el formato: " + measure);

       //                     }

       //                     //Verificar que el identificador esté en la lista de identificadores predefinidos
       //                     string key = parts[0];
       //                     if (!keys.Contains(key))
       //                     {
       //                         Console.WriteLine("Identificador desconocido: " + key);
       //                     }
       //                     else
       //                     {
       //                         //Guardar el valor en el diccionario
       //                         receivedKeys.Add(key);
       //                         string value = parts[1];
       //                         value = Regex.Replace(value, pattern, "");
       //                         data[key] = value;
       //                         Console.WriteLine("Key: " + key + " value: " + value);

       //                     }
       //                 }

       //                 CheckForIllegalCrossThreadCalls = false;
       //                 foreach (var key in receivedKeys)
       //                 {
       //                     switch (key)
       //                     {
       //                         case "t":
       //                             break;
       //                         case "T":
       //                             labelTemp.Text = data[key];
       //                             chartTemp.Invoke((MethodInvoker)(() => chartTemp.Series["Temperatura"].Points.AddY(Convert.ToInt32(data[key]))));
       //                             break;
       //                         case "A":
       //                             labelAlt.Text = data[key];
       //                             chartAltitud.Invoke((MethodInvoker)(() => chartAltitud.Series["Altitud"].Points.AddY(Convert.ToInt32(data[key]))));
       //                             break;
       //                         case "P":
       //                             string valor = data[key];
       //                             if (valor == "1")
       //                             {
       //                                 parachutePictureBox.Image = Properties.Resources.parachute;
       //                                 parachuteStateLabel.Text = "Desplegado";

       //                             }
       //                             Console.WriteLine("P: " + data[key]);
       //                             break;
       //                         case "gx":
       //                             Console.WriteLine("gx: " + data[key]);
       //                             break;
       //                         case "gy":
       //                             Console.WriteLine("gy: " + data[key]);
       //                             break;
       //                         case "gz":
       //                             Console.WriteLine("gz: " + data[key]);
       //                             break;
       //                         case "acx":

       //                             Console.WriteLine("acx: " + data[key]);
       //                             break;
       //                         case "acy":
       //                             Console.WriteLine("acy: " + data[key]);
       //                             break;
       //                         case "acz":
       //                             labelAcceleration.Text = data[key];
       //                             chartAcceleration.Invoke((MethodInvoker)(() => chartAcceleration.Series["Aceleracion"].Points.AddY(Convert.ToInt32(data[key]))));
       //                             Console.WriteLine("acz: " + data[key]);
       //                             break;
       //                         case "Pa":
       //                             break;
       //                     }
       //                 }
       //                 //Verificar si existe el archivo mediciones.txt
       //                 //string filePath = @"D:\OneDrive\Documentos\PAEGUA\GUI\GUI Telemetria PAEGUA\Share HMI\HMI-Obsidian\mediciones.txt";
       //                 string fileName = "mediciones.txt";
       //                 if (!File.Exists(fileName))
       //                 {
       //                     //Crear el archivo si no existe
       //                     using (StreamWriter writer = File.CreateText(fileName))
       //                     {
       //                         //Escribir los datos en el archivo
       //                         foreach (KeyValuePair<string, string> entry in data)
       //                         {
       //                             writer.WriteLine(entry.Key + "=" + entry.Value);
       //                         }
       //                     }
       //                 }
       //                 else
       //                 {
       //                     //Agregar los datos al archivo si ya existe
       //                     using (StreamWriter writer = File.AppendText(fileName))
       //                     {
       //                         //Escribir los datos en el archivo
       //                         foreach (KeyValuePair<string, string> entry in data)
       //                         {
       //                             writer.WriteLine(entry.Key + "=" + entry.Value);
       //                         }
       //                     }
       //                 }
       //             }

       //             else if (serialData == "$ErrorCom")
       //             {
       //                 Console.WriteLine("Error en comunicación con cohete");
       //             }
       //             else if (serialData == "$GoodCom")
       //             {

       //             }
       //         }
       //         catch (Exception error)
       //         {
       //             Console.WriteLine(error.Message);
       //         }


       //     }
       // }

       // #endregion

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            
            if (SerialCom.serialPort1.IsOpen)
            {
                if (!transButtonState)
                {
                    SerialCom.serialPort1.WriteLine("$SendData");
                    buttonStartTrans.Text = "Detener Transmision";
                    transButtonState = true;
                }
                else
                {
                    SerialCom.serialPort1.WriteLine("$StopData");
                    buttonStartTrans.Text = "iniciar Transmisión";
                    transButtonState = false;
                }
                

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttonStartTrans.Enabled = ComForms.comRocketState1;
            ComForms.startTransButton = buttonStartTrans;
            ComForms.accelerationChart = chartAcceleration;
            ComForms.altitudChart = chartAltitud;
            ComForms.temperatureChart = chartTemp;
            ComForms.velocityChart = chartVelocity;

            ComForms.labelAcceleration = labelAcceleration;
            ComForms.labelAlt = labelAlt;
            ComForms.labelTemp = labelTemp;
            ComForms.parachuteStateLabel = parachuteStateLabel;
            CheckForIllegalCrossThreadCalls = false;

            ComForms.parachutePictureBox = parachutePictureBox;
        }

    }
}
