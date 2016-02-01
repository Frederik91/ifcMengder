namespace ArduinoBil
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
            this.toggleConnectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.ServoSlider = new System.Windows.Forms.TrackBar();
            this.SpeedBox = new System.Windows.Forms.TextBox();
            this.AngleBox = new System.Windows.Forms.TextBox();
            this.SetAngleButton = new System.Windows.Forms.Button();
            this.setSpeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleConnectBtn
            // 
            this.toggleConnectBtn.Location = new System.Drawing.Point(139, 9);
            this.toggleConnectBtn.Name = "toggleConnectBtn";
            this.toggleConnectBtn.Size = new System.Drawing.Size(104, 23);
            this.toggleConnectBtn.TabIndex = 0;
            this.toggleConnectBtn.Text = "Connect";
            this.toggleConnectBtn.UseVisualStyleBackColor = true;
            this.toggleConnectBtn.Click += new System.EventHandler(this.toggleConnectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(525, 12);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(94, 17);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Disconnected";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(12, 9);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 24);
            this.cbPorts.TabIndex = 3;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(12, 39);
            this.SpeedBar.Maximum = 255;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SpeedBar.Size = new System.Drawing.Size(56, 243);
            this.SpeedBar.TabIndex = 4;
            this.SpeedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
            // 
            // ServoSlider
            // 
            this.ServoSlider.Location = new System.Drawing.Point(74, 118);
            this.ServoSlider.Maximum = 179;
            this.ServoSlider.Name = "ServoSlider";
            this.ServoSlider.Size = new System.Drawing.Size(243, 56);
            this.ServoSlider.TabIndex = 5;
            this.ServoSlider.Scroll += new System.EventHandler(this.ServoSlider_Scroll);
            // 
            // SpeedBox
            // 
            this.SpeedBox.Location = new System.Drawing.Point(61, 246);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(63, 22);
            this.SpeedBox.TabIndex = 6;
            this.SpeedBox.TextChanged += new System.EventHandler(this.SpeedBox_TextChanged);
            // 
            // AngleBox
            // 
            this.AngleBox.Location = new System.Drawing.Point(157, 90);
            this.AngleBox.Name = "AngleBox";
            this.AngleBox.Size = new System.Drawing.Size(63, 22);
            this.AngleBox.TabIndex = 7;
            this.AngleBox.TextChanged += new System.EventHandler(this.AngleBox_TextChanged);
            // 
            // SetAngleButton
            // 
            this.SetAngleButton.Location = new System.Drawing.Point(227, 89);
            this.SetAngleButton.Name = "SetAngleButton";
            this.SetAngleButton.Size = new System.Drawing.Size(63, 23);
            this.SetAngleButton.TabIndex = 8;
            this.SetAngleButton.Text = "Set";
            this.SetAngleButton.UseVisualStyleBackColor = true;
            this.SetAngleButton.Click += new System.EventHandler(this.SetAngleButton_Click);
            // 
            // setSpeedButton
            // 
            this.setSpeedButton.Location = new System.Drawing.Point(139, 245);
            this.setSpeedButton.Name = "setSpeedButton";
            this.setSpeedButton.Size = new System.Drawing.Size(63, 23);
            this.setSpeedButton.TabIndex = 9;
            this.setSpeedButton.Text = "Set";
            this.setSpeedButton.UseVisualStyleBackColor = true;
            this.setSpeedButton.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 280);
            this.Controls.Add(this.setSpeedButton);
            this.Controls.Add(this.SetAngleButton);
            this.Controls.Add(this.AngleBox);
            this.Controls.Add(this.SpeedBox);
            this.Controls.Add(this.ServoSlider);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleConnectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleConnectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.TrackBar ServoSlider;
        private System.Windows.Forms.TextBox SpeedBox;
        private System.Windows.Forms.TextBox AngleBox;
        private System.Windows.Forms.Button SetAngleButton;
        private System.Windows.Forms.Button setSpeedButton;
    }
}

