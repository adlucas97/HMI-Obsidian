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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(portList);
            String[] baudRates = { "9600", "38400", "57600", "115200" };
            comboBoxBaud.DataSource = baudRates;
            Console.WriteLine("Se inicio ventana de com");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBoxPort.DataSource = portList;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialCom.serialPort1.IsOpen)
                {
                    SerialCom.serialPort1.WriteLine("$Stop");
                    SerialCom.serialPort1.Close();
                    comboBoxBaud.Enabled = true;
                    comboBoxPort.Enabled = true;
                    buttonRefresh.Enabled = true;
                    buttonOpen.Text = "INICIAR COMUNICACIÓN";
                    buttonRefresh.BackColor = Color.FromArgb(255, 71, 15, 149);
                    buttonOpen.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    buttonRefresh.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    ComForms.ChangeRocketComState1(0);
                    ComForms.ChangebaseComState1(0);
                }
                else
                {
                    SerialCom.serialPort1.PortName = comboBoxPort.Text;
                    SerialCom.serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    SerialCom.serialPort1.Open();

                    comboBoxBaud.Enabled = false;
                    comboBoxPort.Enabled = false;
                    buttonRefresh.Enabled = false;
                    buttonRefresh.BackColor = Color.FromArgb(255, 110, 106, 170);
                    buttonRefresh.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    buttonOpen.Text = "DETENER COMUNICACIÓN";

                    SerialCom.serialPort1.WriteLine("$Start");
                    ComForms.ChangebaseComState1(1);
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
