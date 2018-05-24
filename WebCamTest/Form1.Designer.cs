namespace WebCamTest
{
    partial class Form1
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
            this.btnStartCam = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCam
            // 
            this.btnStartCam.Location = new System.Drawing.Point(13, 440);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(229, 106);
            this.btnStartCam.TabIndex = 0;
            this.btnStartCam.Text = "Start WebCam";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(13, 13);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(463, 337);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.Visible = false;
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(13, 370);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(262, 21);
            this.cmbDevices.TabIndex = 2;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(249, 440);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(227, 106);
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 570);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnStartCam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnCapture;
    }
}

