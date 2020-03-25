namespace JangSwitch
{
    partial class Function
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function));
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button_close2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_closeDebugBox = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_LED4 = new System.Windows.Forms.Button();
            this.button_key3 = new System.Windows.Forms.Button();
            this.button_LED7 = new System.Windows.Forms.Button();
            this.button_key2 = new System.Windows.Forms.Button();
            this.button_LED6 = new System.Windows.Forms.Button();
            this.button_key1 = new System.Windows.Forms.Button();
            this.button_LED3 = new System.Windows.Forms.Button();
            this.button_LED2 = new System.Windows.Forms.Button();
            this.button_LED1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_LED5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_comLED = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_Debug.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Debug.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Debug.Location = new System.Drawing.Point(0, 0);
            this.textBox_Debug.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Debug.Multiline = true;
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.Size = new System.Drawing.Size(160, 252);
            this.textBox_Debug.TabIndex = 1;
            this.textBox_Debug.UseSystemPasswordChar = true;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // button_close2
            // 
            this.button_close2.CausesValidation = false;
            this.button_close2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_close2.FlatAppearance.BorderSize = 0;
            this.button_close2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_close2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close2.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close2.Image = global::JangSwitch.Properties.Resources.windows_close;
            this.button_close2.Location = new System.Drawing.Point(136, 2);
            this.button_close2.Margin = new System.Windows.Forms.Padding(0);
            this.button_close2.Name = "button_close2";
            this.button_close2.Size = new System.Drawing.Size(20, 20);
            this.button_close2.TabIndex = 24;
            this.button_close2.UseVisualStyleBackColor = false;
            this.button_close2.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JangSwitch.Properties.Resources.function_background;
            this.panel1.Controls.Add(this.button_closeDebugBox);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.button_LED4);
            this.panel1.Controls.Add(this.button_key3);
            this.panel1.Controls.Add(this.button_LED7);
            this.panel1.Controls.Add(this.button_key2);
            this.panel1.Controls.Add(this.button_LED6);
            this.panel1.Controls.Add(this.button_key1);
            this.panel1.Controls.Add(this.button_LED3);
            this.panel1.Controls.Add(this.button_LED2);
            this.panel1.Controls.Add(this.button_LED1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button_LED5);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 696);
            this.panel1.TabIndex = 22;
            // 
            // button_closeDebugBox
            // 
            this.button_closeDebugBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_closeDebugBox.CausesValidation = false;
            this.button_closeDebugBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_closeDebugBox.FlatAppearance.BorderSize = 0;
            this.button_closeDebugBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_closeDebugBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_closeDebugBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_closeDebugBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_closeDebugBox.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_closeDebugBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_closeDebugBox.Image = global::JangSwitch.Properties.Resources.btn_close;
            this.button_closeDebugBox.Location = new System.Drawing.Point(4, 2);
            this.button_closeDebugBox.Margin = new System.Windows.Forms.Padding(0);
            this.button_closeDebugBox.Name = "button_closeDebugBox";
            this.button_closeDebugBox.Size = new System.Drawing.Size(17, 17);
            this.button_closeDebugBox.TabIndex = 23;
            this.button_closeDebugBox.UseVisualStyleBackColor = false;
            this.button_closeDebugBox.Click += new System.EventHandler(this.Button_closeDebugBox_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.CausesValidation = false;
            this.button_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.Image = global::JangSwitch.Properties.Resources.btn_close;
            this.button_close.Location = new System.Drawing.Point(137, 2);
            this.button_close.Margin = new System.Windows.Forms.Padding(0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(17, 17);
            this.button_close.TabIndex = 1;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_LED4
            // 
            this.button_LED4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED4.BackgroundImage")));
            this.button_LED4.CausesValidation = false;
            this.button_LED4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED4.FlatAppearance.BorderSize = 0;
            this.button_LED4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED4.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_LED4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED4.Image = ((System.Drawing.Image)(resources.GetObject("button_LED4.Image")));
            this.button_LED4.Location = new System.Drawing.Point(86, 410);
            this.button_LED4.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED4.Name = "button_LED4";
            this.button_LED4.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED4.Size = new System.Drawing.Size(60, 60);
            this.button_LED4.TabIndex = 18;
            this.button_LED4.UseCompatibleTextRendering = true;
            this.button_LED4.UseVisualStyleBackColor = false;
            this.button_LED4.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button_key3
            // 
            this.button_key3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_key3.BackgroundImage")));
            this.button_key3.CausesValidation = false;
            this.button_key3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key3.FlatAppearance.BorderSize = 0;
            this.button_key3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_key3.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_key3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_key3.Image = global::JangSwitch.Properties.Resources.key_1;
            this.button_key3.Location = new System.Drawing.Point(20, 599);
            this.button_key3.Margin = new System.Windows.Forms.Padding(0);
            this.button_key3.Name = "button_key3";
            this.button_key3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_key3.Size = new System.Drawing.Size(60, 60);
            this.button_key3.TabIndex = 21;
            this.button_key3.UseVisualStyleBackColor = false;
            this.button_key3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_key_click);
            // 
            // button_LED7
            // 
            this.button_LED7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED7.BackgroundImage")));
            this.button_LED7.CausesValidation = false;
            this.button_LED7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_LED7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED7.FlatAppearance.BorderSize = 0;
            this.button_LED7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED7.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold);
            this.button_LED7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED7.Image = global::JangSwitch.Properties.Resources.btn_default;
            this.button_LED7.Location = new System.Drawing.Point(20, 473);
            this.button_LED7.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED7.Name = "button_LED7";
            this.button_LED7.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED7.Size = new System.Drawing.Size(60, 60);
            this.button_LED7.TabIndex = 13;
            this.button_LED7.Text = "강제\r\n실행";
            this.button_LED7.UseCompatibleTextRendering = true;
            this.button_LED7.UseVisualStyleBackColor = false;
            this.button_LED7.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button_key2
            // 
            this.button_key2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_key2.BackgroundImage")));
            this.button_key2.CausesValidation = false;
            this.button_key2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key2.FlatAppearance.BorderSize = 0;
            this.button_key2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_key2.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_key2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_key2.Image = global::JangSwitch.Properties.Resources.key_1;
            this.button_key2.Location = new System.Drawing.Point(20, 536);
            this.button_key2.Margin = new System.Windows.Forms.Padding(0);
            this.button_key2.Name = "button_key2";
            this.button_key2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_key2.Size = new System.Drawing.Size(60, 60);
            this.button_key2.TabIndex = 20;
            this.button_key2.UseVisualStyleBackColor = false;
            this.button_key2.Click += new System.EventHandler(this.btn_key_click);
            // 
            // button_LED6
            // 
            this.button_LED6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED6.BackgroundImage")));
            this.button_LED6.CausesValidation = false;
            this.button_LED6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED6.FlatAppearance.BorderSize = 0;
            this.button_LED6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED6.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold);
            this.button_LED6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED6.Image = global::JangSwitch.Properties.Resources.btn_default;
            this.button_LED6.Location = new System.Drawing.Point(86, 284);
            this.button_LED6.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED6.Name = "button_LED6";
            this.button_LED6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED6.Size = new System.Drawing.Size(60, 60);
            this.button_LED6.TabIndex = 14;
            this.button_LED6.Text = "시스템\r\n허가";
            this.button_LED6.UseCompatibleTextRendering = true;
            this.button_LED6.UseVisualStyleBackColor = false;
            this.button_LED6.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button_key1
            // 
            this.button_key1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_key1.BackgroundImage")));
            this.button_key1.CausesValidation = false;
            this.button_key1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key1.FlatAppearance.BorderSize = 0;
            this.button_key1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_key1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_key1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_key1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_key1.Image = global::JangSwitch.Properties.Resources.key_1;
            this.button_key1.Location = new System.Drawing.Point(20, 287);
            this.button_key1.Margin = new System.Windows.Forms.Padding(0);
            this.button_key1.Name = "button_key1";
            this.button_key1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_key1.Size = new System.Drawing.Size(60, 60);
            this.button_key1.TabIndex = 19;
            this.button_key1.UseVisualStyleBackColor = false;
            this.button_key1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_key_click);
            // 
            // button_LED3
            // 
            this.button_LED3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED3.BackgroundImage")));
            this.button_LED3.CausesValidation = false;
            this.button_LED3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED3.FlatAppearance.BorderSize = 0;
            this.button_LED3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED3.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_LED3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED3.Image = global::JangSwitch.Properties.Resources.btn_default;
            this.button_LED3.Location = new System.Drawing.Point(86, 473);
            this.button_LED3.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED3.Name = "button_LED3";
            this.button_LED3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED3.Size = new System.Drawing.Size(60, 60);
            this.button_LED3.TabIndex = 19;
            this.button_LED3.Text = "바이\r\n패스";
            this.button_LED3.UseCompatibleTextRendering = true;
            this.button_LED3.UseVisualStyleBackColor = false;
            this.button_LED3.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button_LED2
            // 
            this.button_LED2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED2.BackgroundImage")));
            this.button_LED2.CausesValidation = false;
            this.button_LED2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED2.FlatAppearance.BorderSize = 0;
            this.button_LED2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED2.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_LED2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED2.Image = global::JangSwitch.Properties.Resources.btn_default;
            this.button_LED2.Location = new System.Drawing.Point(86, 536);
            this.button_LED2.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED2.Name = "button_LED2";
            this.button_LED2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED2.Size = new System.Drawing.Size(60, 60);
            this.button_LED2.TabIndex = 20;
            this.button_LED2.Text = "AOS\r\n전원허가";
            this.button_LED2.UseCompatibleTextRendering = true;
            this.button_LED2.UseVisualStyleBackColor = false;
            this.button_LED2.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button_LED1
            // 
            this.button_LED1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED1.BackgroundImage")));
            this.button_LED1.CausesValidation = false;
            this.button_LED1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED1.FlatAppearance.BorderSize = 0;
            this.button_LED1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_LED1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED1.Image = global::JangSwitch.Properties.Resources.btn_default;
            this.button_LED1.Location = new System.Drawing.Point(86, 599);
            this.button_LED1.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED1.Name = "button_LED1";
            this.button_LED1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED1.Size = new System.Drawing.Size(60, 60);
            this.button_LED1.TabIndex = 21;
            this.button_LED1.Text = "MAS\r\n전원허가";
            this.button_LED1.UseCompatibleTextRendering = true;
            this.button_LED1.UseVisualStyleBackColor = false;
            this.button_LED1.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.CausesValidation = false;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = global::JangSwitch.Properties.Resources.btn_green;
            this.button9.Location = new System.Drawing.Point(86, 347);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 16;
            this.button9.Text = "콘솔\r\n켬/끔";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button_LED5
            // 
            this.button_LED5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LED5.BackgroundImage")));
            this.button_LED5.CausesValidation = false;
            this.button_LED5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED5.FlatAppearance.BorderSize = 0;
            this.button_LED5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LED5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LED5.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_LED5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LED5.Image = ((System.Drawing.Image)(resources.GetObject("button_LED5.Image")));
            this.button_LED5.Location = new System.Drawing.Point(20, 410);
            this.button_LED5.Margin = new System.Windows.Forms.Padding(0);
            this.button_LED5.Name = "button_LED5";
            this.button_LED5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button_LED5.Size = new System.Drawing.Size(60, 60);
            this.button_LED5.TabIndex = 17;
            this.button_LED5.Text = "긴급\r\n전원차단";
            this.button_LED5.UseCompatibleTextRendering = true;
            this.button_LED5.UseVisualStyleBackColor = false;
            this.button_LED5.Click += new System.EventHandler(this.btn_switch_click);
            this.button_LED5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_switch_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.CausesValidation = false;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Image = global::JangSwitch.Properties.Resources.btn_green;
            this.button8.Location = new System.Drawing.Point(20, 347);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 15;
            this.button8.Text = "시스템\r\n켬/끔";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button_comLED
            // 
            this.button_comLED.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_comLED.CausesValidation = false;
            this.button_comLED.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_comLED.FlatAppearance.BorderSize = 0;
            this.button_comLED.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_comLED.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_comLED.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_comLED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_comLED.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_comLED.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_comLED.Image = global::JangSwitch.Properties.Resources.led_off;
            this.button_comLED.Location = new System.Drawing.Point(122, 5);
            this.button_comLED.Margin = new System.Windows.Forms.Padding(0);
            this.button_comLED.Name = "button_comLED";
            this.button_comLED.Size = new System.Drawing.Size(13, 13);
            this.button_comLED.TabIndex = 2;
            this.button_comLED.UseVisualStyleBackColor = false;
            this.button_comLED.Click += new System.EventHandler(this.button_comLED_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(160, 1200);
            this.ControlBox = false;
            this.Controls.Add(this.button_close2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_comLED);
            this.Controls.Add(this.textBox_Debug);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1920, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(160, 1200);
            this.Name = "Function";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "기능스위치";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FunctionForm_FormClosing);
            this.Load += new System.EventHandler(this.FunctionForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LED4;
        private System.Windows.Forms.TextBox textBox_Debug;
        private System.Windows.Forms.Button button_LED7;
        private System.Windows.Forms.Button button_LED6;
        private System.Windows.Forms.Button button_LED3;
        private System.Windows.Forms.Button button_LED2;
        private System.Windows.Forms.Button button_LED1;
        private System.Windows.Forms.Button button_LED5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button_key2;
        private System.Windows.Forms.Button button_key3;
        private System.Windows.Forms.Button button_comLED;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_closeDebugBox;
        private System.Windows.Forms.Button button_close2;
        private System.Windows.Forms.Button button_key1;
    }
}