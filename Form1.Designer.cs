
namespace TELEMETRIAOBSIDIAN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dragPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.maximizeBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.groupBoxTemp = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxAlt = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelAlt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartAltitud = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.labelComPort = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.parachuteStateLabel = new System.Windows.Forms.Label();
            this.parachutePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groupBoxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.groupBoxAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitud)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parachutePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1326, 12);
            this.topPanel.TabIndex = 0;
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Gray;
            this.dragPanel.Controls.Add(this.minimizeBtn);
            this.dragPanel.Controls.Add(this.maximizeBtn);
            this.dragPanel.Controls.Add(this.closeBtn);
            this.dragPanel.Controls.Add(this.guna2PictureBox1);
            this.dragPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 12);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1326, 50);
            this.dragPanel.TabIndex = 1;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.minus;
            this.minimizeBtn.ImageRotate = 0F;
            this.minimizeBtn.Location = new System.Drawing.Point(1190, 18);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(39, 37);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.minimizeBtn_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.minimizeBtn_MouseLeave);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeBtn.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.maximize;
            this.maximizeBtn.ImageRotate = 0F;
            this.maximizeBtn.Location = new System.Drawing.Point(1234, 5);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(39, 37);
            this.maximizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizeBtn.TabIndex = 2;
            this.maximizeBtn.TabStop = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            this.maximizeBtn.MouseEnter += new System.EventHandler(this.maximizeBtn_MouseEnter);
            this.maximizeBtn.MouseLeave += new System.EventHandler(this.maximizeBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.close;
            this.closeBtn.ImageRotate = 0F;
            this.closeBtn.Location = new System.Drawing.Point(1284, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.white_logo_letters;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(219, 38);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.dragPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // groupBoxTemp
            // 
            this.groupBoxTemp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTemp.Controls.Add(this.labelTemp);
            this.groupBoxTemp.Controls.Add(this.label1);
            this.groupBoxTemp.Controls.Add(this.chartTemp);
            this.groupBoxTemp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxTemp.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTemp.Location = new System.Drawing.Point(12, 157);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.Size = new System.Drawing.Size(450, 330);
            this.groupBoxTemp.TabIndex = 2;
            this.groupBoxTemp.Text = "Temperatura";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(145, 278);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(17, 20);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura (C°): ";
            // 
            // chartTemp
            // 
            this.chartTemp.BorderlineColor = System.Drawing.Color.Black;
            this.chartTemp.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartTemp.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(14, 55);
            this.chartTemp.Name = "chartTemp";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(410, 205);
            this.chartTemp.TabIndex = 1;
            this.chartTemp.Text = "chart2";
            // 
            // groupBoxAlt
            // 
            this.groupBoxAlt.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAlt.Controls.Add(this.labelAlt);
            this.groupBoxAlt.Controls.Add(this.label2);
            this.groupBoxAlt.Controls.Add(this.chartAltitud);
            this.groupBoxAlt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxAlt.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAlt.Location = new System.Drawing.Point(497, 157);
            this.groupBoxAlt.Name = "groupBoxAlt";
            this.groupBoxAlt.Size = new System.Drawing.Size(450, 330);
            this.groupBoxAlt.TabIndex = 3;
            this.groupBoxAlt.Text = "Altitud";
            // 
            // labelAlt
            // 
            this.labelAlt.AutoSize = true;
            this.labelAlt.Location = new System.Drawing.Point(100, 278);
            this.labelAlt.Name = "labelAlt";
            this.labelAlt.Size = new System.Drawing.Size(17, 20);
            this.labelAlt.TabIndex = 3;
            this.labelAlt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altitud (m):";
            // 
            // chartAltitud
            // 
            this.chartAltitud.BorderlineColor = System.Drawing.Color.Black;
            this.chartAltitud.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartAltitud.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chartAltitud.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartAltitud.Legends.Add(legend2);
            this.chartAltitud.Location = new System.Drawing.Point(14, 55);
            this.chartAltitud.Name = "chartAltitud";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Altitud";
            this.chartAltitud.Series.Add(series2);
            this.chartAltitud.Size = new System.Drawing.Size(410, 205);
            this.chartAltitud.TabIndex = 1;
            this.chartAltitud.Text = "chart2";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.buttonOpen);
            this.guna2Panel1.Controls.Add(this.buttonRefresh);
            this.guna2Panel1.Controls.Add(this.labelBaud);
            this.guna2Panel1.Controls.Add(this.comboBoxBaud);
            this.guna2Panel1.Controls.Add(this.labelComPort);
            this.guna2Panel1.Controls.Add(this.comboBoxPort);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1326, 46);
            this.guna2Panel1.TabIndex = 4;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(637, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(173, 23);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Iniciar Comunicación";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(523, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Actualizar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.BackColor = System.Drawing.Color.Transparent;
            this.labelBaud.Enabled = false;
            this.labelBaud.Location = new System.Drawing.Point(277, 15);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(79, 17);
            this.labelBaud.TabIndex = 3;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(372, 12);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.BackColor = System.Drawing.Color.Transparent;
            this.labelComPort.Enabled = false;
            this.labelComPort.Location = new System.Drawing.Point(30, 15);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(86, 17);
            this.labelComPort.TabIndex = 1;
            this.labelComPort.Text = "Puerto Com:";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(125, 12);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPort.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.parachuteStateLabel);
            this.guna2GroupBox1.Controls.Add(this.parachutePictureBox);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(988, 157);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(300, 330);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Estado del Paracaídas";
            // 
            // parachuteStateLabel
            // 
            this.parachuteStateLabel.AutoSize = true;
            this.parachuteStateLabel.BackColor = System.Drawing.Color.Transparent;
            this.parachuteStateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parachuteStateLabel.Location = new System.Drawing.Point(64, 270);
            this.parachuteStateLabel.Name = "parachuteStateLabel";
            this.parachuteStateLabel.Size = new System.Drawing.Size(177, 28);
            this.parachuteStateLabel.TabIndex = 1;
            this.parachuteStateLabel.Text = "NO DESPLEGADO";
            // 
            // parachutePictureBox
            // 
            this.parachutePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.parachutePictureBox.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.bag;
            this.parachutePictureBox.ImageRotate = 0F;
            this.parachutePictureBox.Location = new System.Drawing.Point(80, 78);
            this.parachutePictureBox.Name = "parachutePictureBox";
            this.parachutePictureBox.Size = new System.Drawing.Size(141, 149);
            this.parachutePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.parachutePictureBox.TabIndex = 0;
            this.parachutePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1326, 802);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.groupBoxAlt);
            this.Controls.Add(this.groupBoxTemp);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groupBoxTemp.ResumeLayout(false);
            this.groupBoxTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.groupBoxAlt.ResumeLayout(false);
            this.groupBoxAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitud)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parachutePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel dragPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox closeBtn;
        private Guna.UI2.WinForms.Guna2PictureBox maximizeBtn;
        private Guna.UI2.WinForms.Guna2PictureBox minimizeBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAltitud;
        private System.IO.Ports.SerialPort serialPort1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelAlt;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox parachutePictureBox;
        private System.Windows.Forms.Label parachuteStateLabel;
    }
}

