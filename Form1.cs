using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

using System.Threading;

namespace TELEMETRIAOBSIDIAN
{
    public partial class Form1 : Form
    {
        #region Variables
        List<string> keys = new List<string> { "t", "T", "A", "P", "gx", "gy", "gz", "acx", "acy", "acz", "Pa", "V" };
        Dictionary<string, string> data = new Dictionary<string, string>();
        //double tiempo = 0;
        #endregion

        #region Config Formulario 1
        //-----------------------------Conf del formulario ----------------------------------
        public Form1()
        {
            InitializeComponent();
            Form4 form4 = new Form4();
            form4.Show();
            form4.Hide();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    maximizeBtn.Image = Properties.Resources.minimize_window;
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    maximizeBtn.Image = Properties.Resources.newer_maximize;
                }

                CheckForIllegalCrossThreadCalls = false;
                ComForms.pictureBoxRocketComState = pictureBoxRocketComState;
                ComForms.pictureBoxBaseComState = pictureBoxBaseComState;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialCom.serialPort1.IsOpen)
            {
                try
                {
                    SerialCom.serialPort1.Close();
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
            if (SerialCom.serialPort1.IsOpen)
            {
                SerialCom.serialPort1.WriteLine("$Stop");
                Thread.Sleep(10);
                SerialCom.serialPort1.Close();
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
            if (this.WindowState == FormWindowState.Normal)
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
            catch (Exception error)
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

        //#region Boton de Conexion Serial

        ////-------------------------------Conf Botón de conexión -------------------------------------
        //private void buttonOpen_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (SerialCom.serialPort1.IsOpen)
        //        {
        //            SerialCom.serialPort1.WriteLine("$Stop");
        //            SerialCom.serialPort1.Close();
        //            comboBoxBaud.Enabled = true;
        //            comboBoxPort.Enabled = true;
        //            buttonRefresh.Enabled = true;
        //            buttonOpen.Text = "Iniciar Comunicación";

        //        }
        //        else
        //        {
        //            SerialCom.serialPort1.PortName = comboBoxPort.Text;
        //            SerialCom.serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
        //            SerialCom.serialPort1.Open();

        //            comboBoxBaud.Enabled = false;
        //            comboBoxPort.Enabled = false;
        //            buttonRefresh.Enabled = false;

        //            buttonOpen.Text = "Detener Comunicación";

        //            SerialCom.serialPort1.WriteLine("$Start");
        //        }


        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }
        //}
        //#endregion

        //#region Boton de refrescar
        ////------------------------------- Conf Botón de Refrescar ----------------------------------
        //private void buttonRefresh_Click(object sender, EventArgs e)
        //{
        //    string[] portList = SerialPort.GetPortNames();
        //    comboBoxPort.DataSource = portList;
        //}
        //#endregion



        #region Control Formularios

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelbase.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelbase.Controls.Add(formulario);
                panelbase.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();

            }
        }
        #endregion

        private void btnSerial_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }

        private void btnComms_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form5>();
        }


    }
}
