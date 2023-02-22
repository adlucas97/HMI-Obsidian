
namespace TELEMETRIAOBSIDIAN
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelComPort = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.guna2Panel3.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(15)))), ((int)(((byte)(149)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(15)))), ((int)(((byte)(149)))));
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1482, 50);
            this.guna2Panel3.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(866, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 45);
            this.label11.TabIndex = 0;
            this.label11.Text = "COMMS";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.BackColor = System.Drawing.Color.Transparent;
            this.labelBaud.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.ForeColor = System.Drawing.Color.Black;
            this.labelBaud.Location = new System.Drawing.Point(303, 37);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(88, 20);
            this.labelBaud.TabIndex = 18;
            this.labelBaud.Text = "BAUD RATE";
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
            this.comboBoxBaud.Location = new System.Drawing.Point(397, 37);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaud.TabIndex = 17;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(123, 37);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPort.TabIndex = 15;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(560, 31);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(121, 32);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "ACTUALIZAR";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.BackColor = System.Drawing.Color.Transparent;
            this.labelComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelComPort.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPort.ForeColor = System.Drawing.Color.Black;
            this.labelComPort.Location = new System.Drawing.Point(14, 37);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(103, 20);
            this.labelComPort.TabIndex = 16;
            this.labelComPort.Text = "PUERTO COM";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(15)))), ((int)(((byte)(149)))));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(687, 31);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(211, 32);
            this.buttonOpen.TabIndex = 20;
            this.buttonOpen.Text = "INICIAR COMUNICACIÓN";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.panel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.panel1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(431, 155);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1016, 539);
            this.guna2CustomGradientPanel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "PUERTO 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelComPort);
            this.panel1.Controls.Add(this.labelBaud);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.comboBoxPort);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.comboBoxBaud);
            this.panel1.Location = new System.Drawing.Point(52, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 100);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "PUERTO 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(52, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 100);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "PUERTO COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(303, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "BAUD RATE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(15)))), ((int)(((byte)(149)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(687, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "INICIAR COMUNICACIÓN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(560, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(397, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 673);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label11;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Button buttonOpen;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}