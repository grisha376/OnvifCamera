namespace OnvifCamera
{
    partial class Camera
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StreamPlayer = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.ContextItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьКнопкиУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BitrateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionDataPanel = new System.Windows.Forms.Panel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ContextItems.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ConnectionDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StreamPlayer
            // 
            this.StreamPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.StreamPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StreamPlayer.ContextMenuStrip = this.ContextItems;
            this.StreamPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreamPlayer.Location = new System.Drawing.Point(0, 0);
            this.StreamPlayer.Name = "StreamPlayer";
            this.StreamPlayer.Size = new System.Drawing.Size(468, 290);
            this.StreamPlayer.TabIndex = 0;
            // 
            // ContextItems
            // 
            this.ContextItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьКнопкиУправленияToolStripMenuItem});
            this.ContextItems.Name = "ContextItems";
            this.ContextItems.Size = new System.Drawing.Size(245, 26);
            // 
            // показатьКнопкиУправленияToolStripMenuItem
            // 
            this.показатьКнопкиУправленияToolStripMenuItem.Name = "показатьКнопкиУправленияToolStripMenuItem";
            this.показатьКнопкиУправленияToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.показатьКнопкиУправленияToolStripMenuItem.Text = "[Показать] Кнопки управления";
            this.показатьКнопкиУправленияToolStripMenuItem.Click += new System.EventHandler(this.показатьКнопкиУправленияToolStripMenuItem_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(9, 27);
            this.btnUp.MaximumSize = new System.Drawing.Size(55, 23);
            this.btnUp.MinimumSize = new System.Drawing.Size(55, 23);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(9, 56);
            this.btnLeft.MaximumSize = new System.Drawing.Size(55, 23);
            this.btnLeft.MinimumSize = new System.Drawing.Size(55, 23);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(9, 85);
            this.btnRight.MaximumSize = new System.Drawing.Size(55, 23);
            this.btnRight.MinimumSize = new System.Drawing.Size(55, 23);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(9, 114);
            this.btnDown.MaximumSize = new System.Drawing.Size(55, 23);
            this.btnDown.MinimumSize = new System.Drawing.Size(55, 23);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Visible = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.ForeColor = System.Drawing.Color.White;
            this.btnZoomIn.Location = new System.Drawing.Point(9, 143);
            this.btnZoomIn.MaximumSize = new System.Drawing.Size(55, 23);
            this.btnZoomIn.MinimumSize = new System.Drawing.Size(55, 23);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(55, 23);
            this.btnZoomIn.TabIndex = 7;
            this.btnZoomIn.Text = "Zoom +";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Visible = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.White;
            this.btnZoomOut.Location = new System.Drawing.Point(9, 172);
            this.btnZoomOut.MaximumSize = new System.Drawing.Size(55, 23);
            this.btnZoomOut.MinimumSize = new System.Drawing.Size(55, 23);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(55, 23);
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.Text = "Zoom -";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Visible = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FpsLabel,
            this.BitrateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 268);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "sdf";
            // 
            // FpsLabel
            // 
            this.FpsLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FpsLabel.Name = "FpsLabel";
            this.FpsLabel.Size = new System.Drawing.Size(25, 17);
            this.FpsLabel.Text = "Fps";
            // 
            // BitrateLabel
            // 
            this.BitrateLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BitrateLabel.Name = "BitrateLabel";
            this.BitrateLabel.Size = new System.Drawing.Size(41, 17);
            this.BitrateLabel.Text = "Bitrate";
            // 
            // ConnectionDataPanel
            // 
            this.ConnectionDataPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectionDataPanel.Controls.Add(this.ConnectButton);
            this.ConnectionDataPanel.Controls.Add(this.PasswordTextBox);
            this.ConnectionDataPanel.Controls.Add(this.PasswordLabel);
            this.ConnectionDataPanel.Controls.Add(this.LoginTextBox);
            this.ConnectionDataPanel.Controls.Add(this.LoginLabel);
            this.ConnectionDataPanel.Controls.Add(this.IPTextBox);
            this.ConnectionDataPanel.Controls.Add(this.IPLabel);
            this.ConnectionDataPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConnectionDataPanel.Location = new System.Drawing.Point(0, 247);
            this.ConnectionDataPanel.Name = "ConnectionDataPanel";
            this.ConnectionDataPanel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ConnectionDataPanel.Size = new System.Drawing.Size(468, 21);
            this.ConnectionDataPanel.TabIndex = 12;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConnectButton.Location = new System.Drawing.Point(386, 0);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 21);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PasswordTextBox.Location = new System.Drawing.Point(296, 0);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(90, 20);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.Text = "lkds2021";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PasswordLabel.Location = new System.Drawing.Point(240, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 21);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginTextBox.Location = new System.Drawing.Point(150, 0);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(90, 20);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.Text = "admin";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginLabel.Location = new System.Drawing.Point(112, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 21);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин:";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IPTextBox.Location = new System.Drawing.Point(22, 0);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(90, 20);
            this.IPTextBox.TabIndex = 2;
            this.IPTextBox.Text = "10.0.0.166";
            // 
            // IPLabel
            // 
            this.IPLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IPLabel.Location = new System.Drawing.Point(2, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(20, 21);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP:";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ConnectionDataPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.StreamPlayer);
            this.Name = "Camera";
            this.Size = new System.Drawing.Size(468, 290);
            this.Load += new System.EventHandler(this.Camera_Load);
            this.ContextItems.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ConnectionDataPanel.ResumeLayout(false);
            this.ConnectionDataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl StreamPlayer;
        private System.Windows.Forms.ContextMenuStrip ContextItems;
        private System.Windows.Forms.ToolStripMenuItem показатьКнопкиУправленияToolStripMenuItem;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FpsLabel;
        private System.Windows.Forms.ToolStripStatusLabel BitrateLabel;
        private System.Windows.Forms.Panel ConnectionDataPanel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label IPLabel;
    }
}
