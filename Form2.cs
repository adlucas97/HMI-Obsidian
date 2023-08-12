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



        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            
            if (SerialCom.serialPort1.IsOpen)
            {
                if (!transButtonState)
                {
                    SerialCom.serialPort1.WriteLine("$SendData");
                    buttonStartTrans.Text = "DETENER TRANSMISIÓN";
                    buttonStartTrans.BackColor = Color.FromArgb(255, 71, 15, 149);
                    buttonStartTrans.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    transButtonState = true;
                }
                else
                {
                    SerialCom.serialPort1.WriteLine("$StopData");
                    buttonStartTrans.Text = "INICIAR TRANSMISIÓN";
                    buttonStartTrans.BackColor = Color.FromArgb(255, 71, 15, 149);
                    buttonStartTrans.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    transButtonState = false;
                }
                

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttonStartTrans.Enabled = ComForms.comRocketState1;
            if (buttonStartTrans.Enabled)
            {
                buttonStartTrans.BackColor = Color.FromArgb(255, 138, 150, 150);
            }
            else
            {
                buttonStartTrans.BackColor = Color.FromArgb(255, 138, 150, 150);
                buttonStartTrans.ForeColor = Color.FromArgb(255, 255, 255, 255);
            }
            ComForms.startTransButton = buttonStartTrans;
            ComForms.accelerationChart = chartAcceleration;
            ComForms.altitudChart = chartAltitud;
            ComForms.temperatureChart = chartTemp;
            //ComForms.velocityChart = chartVelocity;

            ComForms.labelAcceleration = labelAcceleration;
            ComForms.labelAlt = labelAlt;
            ComForms.labelTemp = labelTemp;
            ComForms.parachuteStateLabel = parachuteStateLabel;
            CheckForIllegalCrossThreadCalls = false;

            ComForms.parachutePictureBox = parachutePictureBox;
        }

        private void buttonStartTrans_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonStartTrans.Enabled)
            {
                buttonStartTrans.BackColor = Color.FromArgb(255, 138, 150, 150);
            }
            else
            {
                buttonStartTrans.BackColor = Color.FromArgb(255, 138, 150, 150);
                buttonStartTrans.ForeColor = Color.FromArgb(255, 255,255,255);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
