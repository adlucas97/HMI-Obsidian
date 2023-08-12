
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dragPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelbase = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxFondoCohete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxRocketComState = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxBaseComState = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnComms = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnSerial = new System.Windows.Forms.Button();
            this.btnPaegua = new System.Windows.Forms.Button();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.maximizeBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dragPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelbase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondoCohete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocketComState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaseComState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1600, 12);
            this.topPanel.TabIndex = 0;
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.dragPanel.Controls.Add(this.btnPaegua);
            this.dragPanel.Controls.Add(this.minimizeBtn);
            this.dragPanel.Controls.Add(this.maximizeBtn);
            this.dragPanel.Controls.Add(this.closeBtn);
            this.dragPanel.Controls.Add(this.guna2Button1);
            this.dragPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.dragPanel.Size = new System.Drawing.Size(1432, 36);
            this.dragPanel.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.dragPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.Controls.Add(this.btnComms);
            this.guna2Panel2.Controls.Add(this.btnResumen);
            this.guna2Panel2.Controls.Add(this.btnDatos);
            this.guna2Panel2.Controls.Add(this.btnSerial);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 36);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(165, 764);
            this.guna2Panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBoxRocketComState);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxBaseComState);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 115);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "COHETE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "BASE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO DE CONEXIÓN";
            // 
            // panelbase
            // 
            this.panelbase.Controls.Add(this.pictureBoxFondoCohete);
            this.panelbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbase.Location = new System.Drawing.Point(165, 36);
            this.panelbase.Name = "panelbase";
            this.panelbase.Size = new System.Drawing.Size(1267, 764);
            this.panelbase.TabIndex = 11;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Size = new System.Drawing.Size(165, 36);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // pictureBoxFondoCohete
            // 
            this.pictureBoxFondoCohete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFondoCohete.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.rocket_planet_angle_1;
            this.pictureBoxFondoCohete.ImageRotate = 0F;
            this.pictureBoxFondoCohete.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFondoCohete.Name = "pictureBoxFondoCohete";
            this.pictureBoxFondoCohete.Size = new System.Drawing.Size(1267, 764);
            this.pictureBoxFondoCohete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFondoCohete.TabIndex = 0;
            this.pictureBoxFondoCohete.TabStop = false;
            // 
            // pictureBoxRocketComState
            // 
            this.pictureBoxRocketComState.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.default_rocket;
            this.pictureBoxRocketComState.ImageRotate = 0F;
            this.pictureBoxRocketComState.Location = new System.Drawing.Point(101, 45);
            this.pictureBoxRocketComState.Name = "pictureBoxRocketComState";
            this.pictureBoxRocketComState.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRocketComState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRocketComState.TabIndex = 3;
            this.pictureBoxRocketComState.TabStop = false;
            // 
            // pictureBoxBaseComState
            // 
            this.pictureBoxBaseComState.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.default_base;
            this.pictureBoxBaseComState.ImageRotate = 0F;
            this.pictureBoxBaseComState.Location = new System.Drawing.Point(30, 45);
            this.pictureBoxBaseComState.Name = "pictureBoxBaseComState";
            this.pictureBoxBaseComState.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxBaseComState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBaseComState.TabIndex = 1;
            this.pictureBoxBaseComState.TabStop = false;
            // 
            // btnComms
            // 
            this.btnComms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnComms.FlatAppearance.BorderSize = 0;
            this.btnComms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComms.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComms.ForeColor = System.Drawing.Color.White;
            this.btnComms.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.wifi;
            this.btnComms.Location = new System.Drawing.Point(0, 461);
            this.btnComms.Name = "btnComms";
            this.btnComms.Size = new System.Drawing.Size(165, 60);
            this.btnComms.TabIndex = 10;
            this.btnComms.Text = " COMMS";
            this.btnComms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComms.UseVisualStyleBackColor = false;
            this.btnComms.Click += new System.EventHandler(this.btnComms_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.ForeColor = System.Drawing.Color.White;
            this.btnResumen.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.rocket;
            this.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.Location = new System.Drawing.Point(0, 273);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResumen.Size = new System.Drawing.Size(165, 60);
            this.btnResumen.TabIndex = 9;
            this.btnResumen.Text = " RESUMEN";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.White;
            this.btnDatos.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.database_white;
            this.btnDatos.Location = new System.Drawing.Point(0, 405);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(165, 60);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.Text = " DATOS";
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnSerial
            // 
            this.btnSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnSerial.FlatAppearance.BorderSize = 0;
            this.btnSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerial.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerial.ForeColor = System.Drawing.Color.White;
            this.btnSerial.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.terminal_white;
            this.btnSerial.Location = new System.Drawing.Point(0, 339);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(165, 60);
            this.btnSerial.TabIndex = 3;
            this.btnSerial.Text = " SERIAL";
            this.btnSerial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSerial.UseVisualStyleBackColor = false;
            this.btnSerial.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnPaegua
            // 
            this.btnPaegua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnPaegua.BackgroundImage = global::TELEMETRIAOBSIDIAN.Properties.Resources.Group_109;
            this.btnPaegua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaegua.FlatAppearance.BorderSize = 0;
            this.btnPaegua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaegua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnPaegua.Location = new System.Drawing.Point(0, 0);
            this.btnPaegua.Name = "btnPaegua";
            this.btnPaegua.Size = new System.Drawing.Size(165, 36);
            this.btnPaegua.TabIndex = 2;
            this.btnPaegua.UseVisualStyleBackColor = false;
            this.btnPaegua.Click += new System.EventHandler(this.btnPaegua_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.new_minimize;
            this.minimizeBtn.ImageRotate = 0F;
            this.minimizeBtn.Location = new System.Drawing.Point(1220, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(72, 36);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.maximizeBtn.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.minimize_window;
            this.maximizeBtn.ImageRotate = 0F;
            this.maximizeBtn.Location = new System.Drawing.Point(1289, 0);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(72, 36);
            this.maximizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.closeBtn.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.new_close;
            this.closeBtn.ImageRotate = 0F;
            this.closeBtn.Location = new System.Drawing.Point(1360, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(72, 36);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1432, 800);
            this.Controls.Add(this.panelbase);
            this.Controls.Add(this.guna2Panel2);
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
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondoCohete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocketComState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaseComState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel dragPanel;
        private Guna.UI2.WinForms.Guna2PictureBox closeBtn;
        private Guna.UI2.WinForms.Guna2PictureBox maximizeBtn;
        private Guna.UI2.WinForms.Guna2PictureBox minimizeBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Button btnComms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxBaseComState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxRocketComState;
        private System.Windows.Forms.Panel panelbase;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxFondoCohete;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button btnPaegua;
    }
}

