using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
namespace TELEMETRIAOBSIDIAN
{
    public class ComForms
    {
        #region Formulario 1 General

        static public PictureBox pictureBoxBaseComState;
        static public PictureBox pictureBoxRocketComState;

        #endregion

        #region Formulario 2 Resumen

        static public Button startTransButton;

        static public Chart accelerationChart;
        static public Chart temperatureChart;
        static public Chart altitudChart;
        static public Chart velocityChart;

        static public Label labelTemp;
        static public Label labelAlt;
        static public Label labelAcceleration;
        static public Label parachuteStateLabel;

        static public PictureBox parachutePictureBox;

        static public bool comRocketState1 = false;

        static public RichTextBox richTextBox1;
        static public void ModifyCharts(string serialData)
        {
            List<string> keys = new List<string> { "t", "T", "A", "P", "ax", "ay", "az", "acx", "acy", "acz", "Pa", "V" };
            Dictionary<string, string> data = new Dictionary<string, string>();
            string[] measures = serialData.Substring(6).Split(',');
            List<string> receivedKeys = new List<string>();
            Console.WriteLine(serialData);
            foreach (string measure in measures)
            {
                //Verificar el formato correcto
                string[] parts = measure.Split('=');
                if (parts.Length != 2)
                {
                    Console.WriteLine("Error en el formato: " + measure);

                }

                //Verificar que el identificador esté en la lista de identificadores predefinidos
                string key = parts[0];
                if (!keys.Contains(key))
                {
                    Console.WriteLine("Identificador desconocido: " + key);
                }
                else
                {
                    //Guardar el valor en el diccionario
                    receivedKeys.Add(key);
                    string value = parts[1];
                    data[key] = value;
                    Console.WriteLine("Key: " + key + " value: " + value);
                }
            }
            
            foreach (var key in receivedKeys)
            {
                switch (key)
                {
                    case "t":
                        break;
                    case "T":
                        labelTemp.Text = data[key];
                        temperatureChart.Invoke((MethodInvoker)(() => temperatureChart.Series["Temperatura"].Points.AddY(Convert.ToInt32(data[key]))));
                        break;
                    case "A":
                        labelAlt.Text = data[key];
                        altitudChart.Invoke((MethodInvoker)(() => altitudChart.Series["Altitud"].Points.AddY(Convert.ToInt32(data[key]))));
                        break;
                    case "P":
                        string valor = data[key];
                        if (valor == "1")
                        {
                            parachutePictureBox.Image = Properties.Resources._256px_rocket_parachute;
                            parachuteStateLabel.Text = "Desplegado";

                        }
                        Console.WriteLine("P: " + data[key]);
                        break;
                    case "gx":
                        Console.WriteLine("gx: " + data[key]);
                        break;
                    case "gy":
                        Console.WriteLine("gy: " + data[key]);
                        break;
                    case "gz":
                        Console.WriteLine("gz: " + data[key]);
                        break;
                    case "acx":

                        Console.WriteLine("acx: " + data[key]);
                        break;
                    case "acy":
                        Console.WriteLine("acy: " + data[key]);
                        break;
                    case "acz":
                        labelAcceleration.Text = data[key];
                        accelerationChart.Invoke((MethodInvoker)(() => accelerationChart.Series["Aceleración Z"].Points.AddY(Convert.ToInt32(data[key]))));
                        Console.WriteLine("acz: " + data[key]);
                        break;
                    case "Pa":
                        break;
                }
            }
        }
        #endregion
        static public void ChangeRocketComState1(int comState1 = 0)
        {

            switch (comState1)
            {
                case 0: // Desconectado
                    pictureBoxRocketComState.Image = Properties.Resources.default_rocket;
                    comRocketState1 = false;
                    if (startTransButton != null)
                    {
                        startTransButton.Enabled = comRocketState1;
                        if (!startTransButton.Enabled)
                        {
                            startTransButton.BackColor = Color.FromArgb(255, 71, 15, 149);
                        }
                    }
                    break;
                case 1: // Conectado $GoodCom o si hay transmision
                    pictureBoxRocketComState.Image = Properties.Resources.success_rocket;
                    comRocketState1 = true;
                    if (startTransButton != null)
                        startTransButton.Enabled = comRocketState1;
                    break;
                case 2: // Error
                    pictureBoxRocketComState.Image = Properties.Resources.fail_rocket;
                    comRocketState1 = false;
                    if (startTransButton != null)
                        startTransButton.Enabled = comRocketState1;
                    break;
            }
        }

        static public void ChangebaseComState1(int comState1 = 0)
        {
            switch (comState1)
            {
                case 0: // Desconectado
                    pictureBoxBaseComState.Image = Properties.Resources.default_base;
                    break;
                case 1: // Conectado 
                    pictureBoxBaseComState.Image = Properties.Resources.success_base;
                    break;
                case 2: // Error
                    pictureBoxBaseComState.Image = Properties.Resources.fail_base;
                    break;
            }
        }

        public static void WriteToConsole(string text)
        {
            richTextBox1.AppendText(text + "\n");
        }


    }
}
