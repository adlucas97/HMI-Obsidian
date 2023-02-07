using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TELEMETRIAOBSIDIAN
{
    public partial class Form1 : Form
    {
        #region Variables
        List<string> keys = new List<string> { "t", "T", "A", "P", "ax", "ay", "az", "acx", "acy", "acz", "Pa", "V" };
        Dictionary<string, string> data = new Dictionary<string, string>();
        #endregion

        #region Config Formulario
        //-----------------------------Conf del formulario ----------------------------------
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] portList = SerialPort.GetPortNames();
                comboBoxPort.Items.AddRange(portList);
                String[] baudRates = { "9600","38400","57600", "115200"};
                comboBoxBaud.DataSource = baudRates;
                
                if(this.WindowState == FormWindowState.Maximized)
                {
                    maximizeBtn.Image = Properties.Resources.minimize_window;
                }
                else if(this.WindowState == FormWindowState.Normal)
                {
                    maximizeBtn.Image = Properties.Resources.newer_maximize;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        #endregion

        #region Boton de cierre
        //------------------------ Conf Boton de cerrado -------------------------------
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("$Stop");
                serialPort1.Close();
            }
                

            this.Close();
        }
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(255, 144, 144, 144);
        }
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(255, 81, 81, 84);
        }
        #endregion

        #region Boton de Maximizar
        //------------------- Conf Botón de maximizar -------------------------------------
        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizeBtn.Image = Properties.Resources.minimize_window;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maximizeBtn.Image = Properties.Resources.newer_maximize;
            }

        }
        private void maximizeBtn_MouseEnter(object sender, EventArgs e)
        {
            maximizeBtn.BackColor = Color.FromArgb(255, 144, 144, 144);
        }

        private void maximizeBtn_MouseLeave(object sender, EventArgs e)
        {
            maximizeBtn.BackColor = Color.FromArgb(255, 81, 81, 84);
        }
        #endregion

        #region Boton de Minimizar
        //--------------------------- Conf Botón de Minimizar --------------------------------------
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
        private void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.FromArgb(255, 144, 144, 144);
        }

        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.FromArgb(255, 81, 81, 84);
        }

        #endregion

        #region Boton de Conexion Serial

        //-------------------------------Conf Botón de conexión -------------------------------------
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("$Stop");
                    serialPort1.Close();
                    comboBoxBaud.Enabled = true;
                    comboBoxPort.Enabled = true;
                    buttonRefresh.Enabled = true;
                    buttonOpen.Text = "Iniciar Comunicación";

                }
                else
                {
                    serialPort1.PortName = comboBoxPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    serialPort1.Open();

                    comboBoxBaud.Enabled = false;
                    comboBoxPort.Enabled = false;
                    buttonRefresh.Enabled = false;

                    buttonOpen.Text = "Detener Comunicación";

                    serialPort1.WriteLine("$Start");
                }
                

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion

        #region Boton de refrescar
        //------------------------------- Conf Botón de Refrescar ----------------------------------
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBoxPort.DataSource = portList;
        }
        #endregion

        #region Comunicacion Serial y Lectura de datos
        //--------------------------------Conf de lectura serial y acciones --------------------------       
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while(serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                try
                {
                    string serialData = serialPort1.ReadLine();
                    string[] measures = serialData.Split(',');
                    List<string> receivedKeys = new List<string>();
                    Console.WriteLine(serialData);
                    foreach (string measure in measures)
                    {
                        // Verificar el formato correcto
                        string[] parts = measure.Split('=');
                        if (parts.Length != 2)
                        {
                            Console.WriteLine("Error en el formato: " + measure);

                            return;
                        }

                        // Verificar que el identificador esté en la lista de identificadores predefinidos
                        string key = parts[0];
                        if (!keys.Contains(key))
                        {
                            Console.WriteLine("Identificador desconocido: " + key);
                            return;
                        }
                        else
                        {
                            // Guardar el valor en el diccionario
                            receivedKeys.Add(key);
                            string pattern = @"\r\n|\r|\n";
                            string value = parts[1];
                            value = Regex.Replace(value, pattern, "");
                            data[key] = value;
                            Console.WriteLine("Key: " + key + " value: " + value);

                        }
                    }

                    CheckForIllegalCrossThreadCalls = false;
                    foreach (var key in receivedKeys)
                    {
                        switch (key)
                        {
                            case "t":
                                break;
                            case "T":
                                labelTemp.Text = data[key];
                                chartTemp.Invoke((MethodInvoker)(() => chartTemp.Series["Temperatura"].Points.AddY(Convert.ToInt32(data[key]))));
                                break;
                            case "A":
                                labelAlt.Text = data[key];
                                chartAltitud.Invoke((MethodInvoker)(() => chartAltitud.Series["Altitud"].Points.AddY(Convert.ToInt32(data[key]))));
                                break;
                            case "P":
                                string valor = data[key];
                                if (valor == "1")
                                {
                                    parachutePictureBox.Image = Properties.Resources.parachute;
                                    parachuteStateLabel.Text = "Desplegado";

                                }
                                Console.WriteLine("P: " + data[key]);
                                break;
                            case "ax":
                                Console.WriteLine("ax: " + data[key]);
                                break;
                            case "ay":
                                Console.WriteLine("ay: " + data[key]);
                                break;
                            case "az":
                                Console.WriteLine("az: " + data[key]);
                                break;
                            case "acx":
                                Console.WriteLine("acx: " + data[key]);
                                break;
                            case "acy":
                                Console.WriteLine("acy: " + data[key]);
                                break;
                            case "acz":
                                Console.WriteLine("acz: " + data[key]);
                                break;
                            case "Pa":
                                break;
                        }
                    }
                    // Verificar si existe el archivo mediciones.txt
                    string fileName = "mediciones.txt";
                    if (!File.Exists(fileName))
                    {
                        // Crear el archivo si no existe
                        using (StreamWriter writer = File.CreateText(fileName))
                        {
                            // Escribir los datos en el archivo
                            foreach (KeyValuePair<string, string> entry in data)
                            {
                                writer.WriteLine(entry.Key + "=" + entry.Value);
                            }
                        }
                    }
                    else
                    {
                        // Agregar los datos al archivo si ya existe
                        using (StreamWriter writer = File.AppendText(fileName))
                        {
                            // Escribir los datos en el archivo
                            foreach (KeyValuePair<string, string> entry in data)
                            {
                                writer.WriteLine(entry.Key + "=" + entry.Value);
                            }
                        }
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                

            }
        }

        #endregion

    }
}
