
namespace ECE_501_Front_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Command = new System.Windows.Forms.ComboBox();
            this.localLoop = new System.Windows.Forms.RadioButton();
            this.LED = new System.Windows.Forms.RadioButton();
            this.Buzzer = new System.Windows.Forms.RadioButton();
            this.Microphone = new System.Windows.Forms.RadioButton();
            this.deviceGroupBox = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.commandsGroupBox = new System.Windows.Forms.GroupBox();
            this.connectivityGroupBox = new System.Windows.Forms.GroupBox();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.connectivityBox = new System.Windows.Forms.TextBox();
            this.Ping = new System.Windows.Forms.Button();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.umassLogo = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.deviceGroupBox.SuspendLayout();
            this.commandsGroupBox.SuspendLayout();
            this.connectivityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umassLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command.FormattingEnabled = true;
            this.Command.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.Command.Location = new System.Drawing.Point(13, 30);
            this.Command.Margin = new System.Windows.Forms.Padding(4);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(383, 28);
            this.Command.TabIndex = 1;
            // 
            // localLoop
            // 
            this.localLoop.AutoSize = true;
            this.localLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localLoop.Location = new System.Drawing.Point(13, 31);
            this.localLoop.Margin = new System.Windows.Forms.Padding(4);
            this.localLoop.Name = "localLoop";
            this.localLoop.Size = new System.Drawing.Size(105, 24);
            this.localLoop.TabIndex = 2;
            this.localLoop.TabStop = true;
            this.localLoop.Text = "Local Loop";
            this.localLoop.UseVisualStyleBackColor = true;
            this.localLoop.CheckedChanged += new System.EventHandler(this.localLoop_CheckedChanged);
            // 
            // LED
            // 
            this.LED.AutoSize = true;
            this.LED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED.Location = new System.Drawing.Point(13, 68);
            this.LED.Margin = new System.Windows.Forms.Padding(4);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(59, 24);
            this.LED.TabIndex = 3;
            this.LED.TabStop = true;
            this.LED.Text = "LED";
            this.LED.UseVisualStyleBackColor = true;
            this.LED.CheckedChanged += new System.EventHandler(this.LED_CheckedChanged);
            // 
            // Buzzer
            // 
            this.Buzzer.AutoSize = true;
            this.Buzzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buzzer.Location = new System.Drawing.Point(13, 105);
            this.Buzzer.Margin = new System.Windows.Forms.Padding(4);
            this.Buzzer.Name = "Buzzer";
            this.Buzzer.Size = new System.Drawing.Size(77, 24);
            this.Buzzer.TabIndex = 4;
            this.Buzzer.TabStop = true;
            this.Buzzer.Text = "Buzzer";
            this.Buzzer.UseVisualStyleBackColor = true;
            this.Buzzer.CheckedChanged += new System.EventHandler(this.Buzzer_CheckedChanged);
            // 
            // Microphone
            // 
            this.Microphone.AutoSize = true;
            this.Microphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Microphone.Location = new System.Drawing.Point(13, 142);
            this.Microphone.Margin = new System.Windows.Forms.Padding(4);
            this.Microphone.Name = "Microphone";
            this.Microphone.Size = new System.Drawing.Size(110, 24);
            this.Microphone.TabIndex = 5;
            this.Microphone.TabStop = true;
            this.Microphone.Text = "Microphone";
            this.Microphone.UseVisualStyleBackColor = true;
            this.Microphone.CheckedChanged += new System.EventHandler(this.Microphone_CheckedChanged);
            // 
            // deviceGroupBox
            // 
            this.deviceGroupBox.Controls.Add(this.Microphone);
            this.deviceGroupBox.Controls.Add(this.Buzzer);
            this.deviceGroupBox.Controls.Add(this.LED);
            this.deviceGroupBox.Controls.Add(this.localLoop);
            this.deviceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceGroupBox.Location = new System.Drawing.Point(16, 137);
            this.deviceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.deviceGroupBox.Name = "deviceGroupBox";
            this.deviceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.deviceGroupBox.Size = new System.Drawing.Size(148, 191);
            this.deviceGroupBox.TabIndex = 6;
            this.deviceGroupBox.TabStop = false;
            this.deviceGroupBox.Text = "Devices";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.DarkBlue;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.outputBox.Location = new System.Drawing.Point(452, 137);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(425, 352);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(16, 430);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(135, 47);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(162, 430);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(135, 47);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // commandsGroupBox
            // 
            this.commandsGroupBox.Controls.Add(this.Command);
            this.commandsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandsGroupBox.Location = new System.Drawing.Point(16, 335);
            this.commandsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.commandsGroupBox.Name = "commandsGroupBox";
            this.commandsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.commandsGroupBox.Size = new System.Drawing.Size(428, 78);
            this.commandsGroupBox.TabIndex = 10;
            this.commandsGroupBox.TabStop = false;
            this.commandsGroupBox.Text = "Commands";
            // 
            // connectivityGroupBox
            // 
            this.connectivityGroupBox.Controls.Add(this.ipAddressBox);
            this.connectivityGroupBox.Controls.Add(this.connectivityBox);
            this.connectivityGroupBox.Controls.Add(this.Ping);
            this.connectivityGroupBox.Controls.Add(this.ipAddressLabel);
            this.connectivityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectivityGroupBox.Location = new System.Drawing.Point(172, 137);
            this.connectivityGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectivityGroupBox.Name = "connectivityGroupBox";
            this.connectivityGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.connectivityGroupBox.Size = new System.Drawing.Size(272, 191);
            this.connectivityGroupBox.TabIndex = 11;
            this.connectivityGroupBox.TabStop = false;
            this.connectivityGroupBox.Text = "Check Connectivity";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressBox.Location = new System.Drawing.Point(124, 39);
            this.ipAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(139, 22);
            this.ipAddressBox.TabIndex = 5;
            this.ipAddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectivityBox
            // 
            this.connectivityBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.connectivityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectivityBox.Location = new System.Drawing.Point(8, 142);
            this.connectivityBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectivityBox.Name = "connectivityBox";
            this.connectivityBox.ReadOnly = true;
            this.connectivityBox.Size = new System.Drawing.Size(255, 22);
            this.connectivityBox.TabIndex = 4;
            this.connectivityBox.Text = "Check Connection";
            this.connectivityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ping
            // 
            this.Ping.Location = new System.Drawing.Point(8, 73);
            this.Ping.Margin = new System.Windows.Forms.Padding(4);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(256, 62);
            this.Ping.TabIndex = 2;
            this.Ping.Text = "Ping";
            this.Ping.UseVisualStyleBackColor = true;
            this.Ping.Click += new System.EventHandler(this.Ping_Click);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressLabel.Location = new System.Drawing.Point(3, 41);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(83, 18);
            this.ipAddressLabel.TabIndex = 1;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // umassLogo
            // 
            this.umassLogo.Image = ((System.Drawing.Image)(resources.GetObject("umassLogo.Image")));
            this.umassLogo.Location = new System.Drawing.Point(179, 24);
            this.umassLogo.Margin = new System.Windows.Forms.Padding(4);
            this.umassLogo.Name = "umassLogo";
            this.umassLogo.Size = new System.Drawing.Size(547, 88);
            this.umassLogo.TabIndex = 0;
            this.umassLogo.TabStop = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(309, 430);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(135, 47);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save Log";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.Clear;
            this.ClientSize = new System.Drawing.Size(890, 502);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.connectivityGroupBox);
            this.Controls.Add(this.commandsGroupBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.umassLogo);
            this.Controls.Add(this.deviceGroupBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ccf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.deviceGroupBox.ResumeLayout(false);
            this.deviceGroupBox.PerformLayout();
            this.commandsGroupBox.ResumeLayout(false);
            this.connectivityGroupBox.ResumeLayout(false);
            this.connectivityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umassLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox umassLogo;
        private System.Windows.Forms.ComboBox Command;
        private System.Windows.Forms.RadioButton localLoop;
        private System.Windows.Forms.RadioButton LED;
        private System.Windows.Forms.RadioButton Buzzer;
        private System.Windows.Forms.RadioButton Microphone;
        private System.Windows.Forms.GroupBox deviceGroupBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox commandsGroupBox;
        private System.Windows.Forms.GroupBox connectivityGroupBox;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Button Ping;
        private System.Windows.Forms.TextBox connectivityBox;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.Button Save;
    }
}

