
namespace TELEMETRIAOBSIDIAN
{
    partial class Form6
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
            this.pictureBoxFondoCohete = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondoCohete)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFondoCohete
            // 
            this.pictureBoxFondoCohete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFondoCohete.Image = global::TELEMETRIAOBSIDIAN.Properties.Resources.rocket_planet_angle_1;
            this.pictureBoxFondoCohete.ImageRotate = 0F;
            this.pictureBoxFondoCohete.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFondoCohete.Name = "pictureBoxFondoCohete";
            this.pictureBoxFondoCohete.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxFondoCohete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFondoCohete.TabIndex = 1;
            this.pictureBoxFondoCohete.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFondoCohete);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondoCohete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxFondoCohete;
    }
}