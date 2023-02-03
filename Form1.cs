using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.IO.Ports;

namespace TELEMETRIAOBSIDIAN
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        #region Config Formulario
        //-----------------------------Conf del formulario ----------------------------------
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
                string serialData = serialPort1.ReadLine();
                string[] measures = serialData.Split(',');

                int cont = 0;
                foreach(var measure in measures)
                {
                    int value = Convert.ToInt32(measure);
                    switch (cont)
                    {
                        case 0:
                            cont++;
                            labelTemp.Text = measure;
                            chartTemp.Invoke((MethodInvoker)(() => chartTemp.Series["Temperatura"].Points.AddY(value)));
                            break;
                        case 1:
                            cont++;
                            labelAlt.Text = measure;
                            chartAltitud.Invoke((MethodInvoker)(() => chartAltitud.Series["Altitud"].Points.AddY(value)));
                            break;
                        case 3:
                            cont++;
                            if(measure == "1")
                            {
                                parachutePictureBox.Image = Properties.Resources.parachute;
                                parachuteStateLabel.Text = "Desplegado";
                            }
                            break;
                    }
                    if(cont == measures.Count())
                    {
                        cont = 0;
                    }
                }
            }
        }


        #endregion

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
