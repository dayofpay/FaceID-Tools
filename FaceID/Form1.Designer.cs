namespace FaceID
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
            this.faceDetect = new System.Windows.Forms.Button();
            this.faceFrame = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.geyBody = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faceFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // faceDetect
            // 
            this.faceDetect.Location = new System.Drawing.Point(656, 12);
            this.faceDetect.Name = "faceDetect";
            this.faceDetect.Size = new System.Drawing.Size(75, 23);
            this.faceDetect.TabIndex = 0;
            this.faceDetect.Text = "Get Face";
            this.faceDetect.UseVisualStyleBackColor = true;
            this.faceDetect.Click += new System.EventHandler(this.faceDetect_Click);
            // 
            // faceFrame
            // 
            this.faceFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.faceFrame.Location = new System.Drawing.Point(0, 2);
            this.faceFrame.Name = "faceFrame";
            this.faceFrame.Size = new System.Drawing.Size(650, 436);
            this.faceFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.faceFrame.TabIndex = 1;
            this.faceFrame.TabStop = false;
            this.faceFrame.Click += new System.EventHandler(this.faceFrame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Eyes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // geyBody
            // 
            this.geyBody.Location = new System.Drawing.Point(656, 70);
            this.geyBody.Name = "geyBody";
            this.geyBody.Size = new System.Drawing.Size(75, 23);
            this.geyBody.TabIndex = 3;
            this.geyBody.Text = "Get Body";
            this.geyBody.UseVisualStyleBackColor = true;
            this.geyBody.Click += new System.EventHandler(this.geyBody_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.geyBody);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.faceFrame);
            this.Controls.Add(this.faceDetect);
            this.Name = "Form1";
            this.Text = "Face ID";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faceFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button faceDetect;
        private System.Windows.Forms.PictureBox faceFrame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button geyBody;
    }
}

