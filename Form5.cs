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
    }
}
