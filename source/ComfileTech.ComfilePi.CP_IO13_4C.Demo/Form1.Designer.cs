namespace ComfileTech.ComfilePi.CP_IO13_4C.Demo
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
            this._digitalOutputPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._digitalInputPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._repositoryUrl = new System.Windows.Forms.LinkLabel();
            this._closeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._serial2Button = new System.Windows.Forms.Button();
            this._serial3Button = new System.Windows.Forms.Button();
            this._serial2Result = new System.Windows.Forms.Label();
            this._serial3Result = new System.Windows.Forms.Label();
            this.lamp1 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.lamp2 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.lamp3 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.lamp4 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.lamp5 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.lamp6 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.lamp7 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Lamp();
            this.button1 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Button();
            this.button2 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Button();
            this.button3 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Button();
            this.button4 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Button();
            this.button5 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Button();
            this.button6 = new ComfileTech.ComfilePi.CP_IO13_4C.Demo.Button();
            this._digitalOutputPanel.SuspendLayout();
            this._digitalInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _digitalOutputPanel
            // 
            this._digitalOutputPanel.Controls.Add(this.button1);
            this._digitalOutputPanel.Controls.Add(this.button2);
            this._digitalOutputPanel.Controls.Add(this.button3);
            this._digitalOutputPanel.Controls.Add(this.button4);
            this._digitalOutputPanel.Controls.Add(this.button5);
            this._digitalOutputPanel.Controls.Add(this.button6);
            this._digitalOutputPanel.Location = new System.Drawing.Point(184, 210);
            this._digitalOutputPanel.Margin = new System.Windows.Forms.Padding(2);
            this._digitalOutputPanel.Name = "_digitalOutputPanel";
            this._digitalOutputPanel.Size = new System.Drawing.Size(423, 72);
            this._digitalOutputPanel.TabIndex = 0;
            // 
            // _digitalInputPanel
            // 
            this._digitalInputPanel.Controls.Add(this.lamp1);
            this._digitalInputPanel.Controls.Add(this.lamp2);
            this._digitalInputPanel.Controls.Add(this.lamp3);
            this._digitalInputPanel.Controls.Add(this.lamp4);
            this._digitalInputPanel.Controls.Add(this.lamp5);
            this._digitalInputPanel.Controls.Add(this.lamp6);
            this._digitalInputPanel.Controls.Add(this.lamp7);
            this._digitalInputPanel.Location = new System.Drawing.Point(149, 88);
            this._digitalInputPanel.Name = "_digitalInputPanel";
            this._digitalInputPanel.Size = new System.Drawing.Size(495, 73);
            this._digitalInputPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(276, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIGITAL INPUTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NanumGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(258, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIGITAL OUTPUTS";
            // 
            // _repositoryUrl
            // 
            this._repositoryUrl.ActiveLinkColor = System.Drawing.Color.White;
            this._repositoryUrl.AutoSize = true;
            this._repositoryUrl.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._repositoryUrl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this._repositoryUrl.LinkColor = System.Drawing.Color.White;
            this._repositoryUrl.Location = new System.Drawing.Point(81, 452);
            this._repositoryUrl.Margin = new System.Windows.Forms.Padding(0);
            this._repositoryUrl.Name = "_repositoryUrl";
            this._repositoryUrl.Size = new System.Drawing.Size(651, 19);
            this._repositoryUrl.TabIndex = 8;
            this._repositoryUrl.TabStop = true;
            this._repositoryUrl.Text = "https://github.com/COMFILE-Technology/ComfileTech.ComfilePi.CP_IO13_4C.Demo";
            this._repositoryUrl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._repositoryUrl.VisitedLinkColor = System.Drawing.Color.White;
            this._repositoryUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._repositoryUrl_LinkClicked);
            // 
            // _closeButton
            // 
            this._closeButton.BackColor = System.Drawing.Color.Maroon;
            this._closeButton.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._closeButton.Location = new System.Drawing.Point(760, 9);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(32, 32);
            this._closeButton.TabIndex = 9;
            this._closeButton.Text = "X";
            this._closeButton.UseVisualStyleBackColor = false;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(270, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Connect RX to TX for each port.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "SERIAL PORT LOOPBACK TEST";
            // 
            // _serial2Button
            // 
            this._serial2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._serial2Button.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._serial2Button.Location = new System.Drawing.Point(222, 356);
            this._serial2Button.Name = "_serial2Button";
            this._serial2Button.Size = new System.Drawing.Size(134, 35);
            this._serial2Button.TabIndex = 29;
            this._serial2Button.Text = "Test Serial2";
            this._serial2Button.UseVisualStyleBackColor = true;
            this._serial2Button.Click += new System.EventHandler(this._serial2Button_Click);
            // 
            // _serial3Button
            // 
            this._serial3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._serial3Button.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._serial3Button.Location = new System.Drawing.Point(432, 356);
            this._serial3Button.Name = "_serial3Button";
            this._serial3Button.Size = new System.Drawing.Size(134, 35);
            this._serial3Button.TabIndex = 30;
            this._serial3Button.Text = "Test Serial3";
            this._serial3Button.UseVisualStyleBackColor = true;
            this._serial3Button.Click += new System.EventHandler(this._serial3Button_Click);
            // 
            // _serial2Result
            // 
            this._serial2Result.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._serial2Result.Location = new System.Drawing.Point(187, 394);
            this._serial2Result.Name = "_serial2Result";
            this._serial2Result.Size = new System.Drawing.Size(204, 20);
            this._serial2Result.TabIndex = 31;
            this._serial2Result.Text = "PASS";
            this._serial2Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _serial3Result
            // 
            this._serial3Result.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._serial3Result.Location = new System.Drawing.Point(397, 394);
            this._serial3Result.Name = "_serial3Result";
            this._serial3Result.Size = new System.Drawing.Size(204, 20);
            this._serial3Result.TabIndex = 32;
            this._serial3Result.Text = "PASS";
            this._serial3Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lamp1
            // 
            this.lamp1.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp1.Location = new System.Drawing.Point(3, 3);
            this.lamp1.Name = "lamp1";
            this.lamp1.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp1.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp1.Size = new System.Drawing.Size(64, 64);
            this.lamp1.State = false;
            this.lamp1.TabIndex = 0;
            this.lamp1.Text = "N";
            // 
            // lamp2
            // 
            this.lamp2.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp2.Location = new System.Drawing.Point(73, 3);
            this.lamp2.Name = "lamp2";
            this.lamp2.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp2.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp2.Size = new System.Drawing.Size(64, 64);
            this.lamp2.State = false;
            this.lamp2.TabIndex = 1;
            this.lamp2.Text = "N";
            // 
            // lamp3
            // 
            this.lamp3.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp3.Location = new System.Drawing.Point(143, 3);
            this.lamp3.Name = "lamp3";
            this.lamp3.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp3.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp3.Size = new System.Drawing.Size(64, 64);
            this.lamp3.State = false;
            this.lamp3.TabIndex = 2;
            this.lamp3.Text = "N";
            // 
            // lamp4
            // 
            this.lamp4.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp4.Location = new System.Drawing.Point(213, 3);
            this.lamp4.Name = "lamp4";
            this.lamp4.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp4.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp4.Size = new System.Drawing.Size(64, 64);
            this.lamp4.State = false;
            this.lamp4.TabIndex = 3;
            this.lamp4.Text = "N";
            // 
            // lamp5
            // 
            this.lamp5.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp5.Location = new System.Drawing.Point(283, 3);
            this.lamp5.Name = "lamp5";
            this.lamp5.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp5.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp5.Size = new System.Drawing.Size(64, 64);
            this.lamp5.State = false;
            this.lamp5.TabIndex = 4;
            this.lamp5.Text = "N";
            // 
            // lamp6
            // 
            this.lamp6.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp6.Location = new System.Drawing.Point(353, 3);
            this.lamp6.Name = "lamp6";
            this.lamp6.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp6.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp6.Size = new System.Drawing.Size(64, 64);
            this.lamp6.State = false;
            this.lamp6.TabIndex = 5;
            this.lamp6.Text = "N";
            // 
            // lamp7
            // 
            this.lamp7.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lamp7.Location = new System.Drawing.Point(423, 3);
            this.lamp7.Name = "lamp7";
            this.lamp7.OffImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_off;
            this.lamp7.OnImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.green_on;
            this.lamp7.Size = new System.Drawing.Size(64, 64);
            this.lamp7.State = false;
            this.lamp7.TabIndex = 6;
            this.lamp7.Text = "N";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.PressedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_on;
            this.button1.ReleasedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_off;
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.State = false;
            this.button1.TabIndex = 0;
            this.button1.Text = "N";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(73, 3);
            this.button2.Name = "button2";
            this.button2.PressedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_on;
            this.button2.ReleasedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_off;
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.State = false;
            this.button2.TabIndex = 1;
            this.button2.Text = "N";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(143, 3);
            this.button3.Name = "button3";
            this.button3.PressedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_on;
            this.button3.ReleasedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_off;
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.State = false;
            this.button3.TabIndex = 2;
            this.button3.Text = "N";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(213, 3);
            this.button4.Name = "button4";
            this.button4.PressedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_on;
            this.button4.ReleasedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_off;
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.State = false;
            this.button4.TabIndex = 3;
            this.button4.Text = "N";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(283, 3);
            this.button5.Name = "button5";
            this.button5.PressedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_on;
            this.button5.ReleasedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_off;
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.State = false;
            this.button5.TabIndex = 4;
            this.button5.Text = "N";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("NanumGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(353, 3);
            this.button6.Name = "button6";
            this.button6.PressedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_on;
            this.button6.ReleasedImage = global::ComfileTech.ComfilePi.CP_IO13_4C.Demo.Properties.Resources.blue_off;
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.State = false;
            this.button6.TabIndex = 5;
            this.button6.Text = "N";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this._serial3Result);
            this.Controls.Add(this._serial2Result);
            this.Controls.Add(this._serial3Button);
            this.Controls.Add(this._serial2Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._repositoryUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._digitalInputPanel);
            this.Controls.Add(this._digitalOutputPanel);
            this.Font = new System.Drawing.Font("NanumGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP-IO13-4C Demo";
            this._digitalOutputPanel.ResumeLayout(false);
            this._digitalInputPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _digitalOutputPanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private System.Windows.Forms.FlowLayoutPanel _digitalInputPanel;
        private Lamp lamp1;
        private Lamp lamp2;
        private Lamp lamp3;
        private Lamp lamp4;
        private Lamp lamp5;
        private Lamp lamp6;
        private Lamp lamp7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel _repositoryUrl;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _serial2Button;
        private System.Windows.Forms.Button _serial3Button;
        private System.Windows.Forms.Label _serial2Result;
        private System.Windows.Forms.Label _serial3Result;
    }
}

