namespace OnvifCamera
{
    partial class Video
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
            this.camera1 = new OnvifCamera.Camera();
            this.SuspendLayout();
            // 
            // camera1
            // 
            this.camera1.BackColor = System.Drawing.Color.White;
            this.camera1.Location = new System.Drawing.Point(0, 0);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(468, 290);
            this.camera1.TabIndex = 0;
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 296);
            this.Controls.Add(this.camera1);
            this.Name = "Video";
            this.Text = "Video";
            this.ResumeLayout(false);

        }

        #endregion

        private Camera camera1;
    }
}