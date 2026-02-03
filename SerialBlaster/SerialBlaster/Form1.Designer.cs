namespace SerialBlaster
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
            this.components = new System.ComponentModel.Container();
            this.UI_Serial = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.UI_TB_RX = new System.Windows.Forms.TextBox();
            this.UI_CB_PortSel = new System.Windows.Forms.ComboBox();
            this.UI_L_Status = new System.Windows.Forms.Label();
            this.UI_B_Blast = new System.Windows.Forms.Button();
            this.UI_CB_Random = new System.Windows.Forms.CheckBox();
            this.UI_TIM_MAIN = new System.Windows.Forms.Timer(this.components);
            this.UI_NUD_Interval = new System.Windows.Forms.NumericUpDown();
            this.UI_CB_BAUD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NUD_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Serial
            // 
            this.UI_Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UI_Serial_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UI_TB_RX
            // 
            this.UI_TB_RX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_TB_RX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TB_RX.Location = new System.Drawing.Point(12, 89);
            this.UI_TB_RX.Multiline = true;
            this.UI_TB_RX.Name = "UI_TB_RX";
            this.UI_TB_RX.ReadOnly = true;
            this.UI_TB_RX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UI_TB_RX.Size = new System.Drawing.Size(776, 349);
            this.UI_TB_RX.TabIndex = 1;
            // 
            // UI_CB_PortSel
            // 
            this.UI_CB_PortSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_CB_PortSel.FormattingEnabled = true;
            this.UI_CB_PortSel.Location = new System.Drawing.Point(12, 12);
            this.UI_CB_PortSel.Name = "UI_CB_PortSel";
            this.UI_CB_PortSel.Size = new System.Drawing.Size(121, 21);
            this.UI_CB_PortSel.TabIndex = 2;
            // 
            // UI_L_Status
            // 
            this.UI_L_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_L_Status.BackColor = System.Drawing.Color.PowderBlue;
            this.UI_L_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_L_Status.Location = new System.Drawing.Point(12, 65);
            this.UI_L_Status.Name = "UI_L_Status";
            this.UI_L_Status.Size = new System.Drawing.Size(776, 21);
            this.UI_L_Status.TabIndex = 3;
            this.UI_L_Status.Text = "label1";
            this.UI_L_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_B_Blast
            // 
            this.UI_B_Blast.Location = new System.Drawing.Point(713, 12);
            this.UI_B_Blast.Name = "UI_B_Blast";
            this.UI_B_Blast.Size = new System.Drawing.Size(75, 23);
            this.UI_B_Blast.TabIndex = 4;
            this.UI_B_Blast.Text = "Blast Data";
            this.UI_B_Blast.UseVisualStyleBackColor = true;
            this.UI_B_Blast.Click += new System.EventHandler(this.UI_B_Blast_Click);
            // 
            // UI_CB_Random
            // 
            this.UI_CB_Random.AutoSize = true;
            this.UI_CB_Random.Enabled = false;
            this.UI_CB_Random.Location = new System.Drawing.Point(12, 40);
            this.UI_CB_Random.Name = "UI_CB_Random";
            this.UI_CB_Random.Size = new System.Drawing.Size(66, 17);
            this.UI_CB_Random.TabIndex = 5;
            this.UI_CB_Random.Text = "Random";
            this.UI_CB_Random.UseVisualStyleBackColor = true;
            this.UI_CB_Random.CheckedChanged += new System.EventHandler(this.UI_CB_Random_CheckedChanged);
            // 
            // UI_TIM_MAIN
            // 
            this.UI_TIM_MAIN.Enabled = true;
            this.UI_TIM_MAIN.Interval = 500;
            this.UI_TIM_MAIN.Tick += new System.EventHandler(this.UI_TIM_MAIN_Tick);
            // 
            // UI_NUD_Interval
            // 
            this.UI_NUD_Interval.Location = new System.Drawing.Point(84, 39);
            this.UI_NUD_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UI_NUD_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NUD_Interval.Name = "UI_NUD_Interval";
            this.UI_NUD_Interval.Size = new System.Drawing.Size(120, 20);
            this.UI_NUD_Interval.TabIndex = 6;
            this.UI_NUD_Interval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.UI_NUD_Interval.ValueChanged += new System.EventHandler(this.UI_NUD_Interval_ValueChanged);
            // 
            // UI_CB_BAUD
            // 
            this.UI_CB_BAUD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_CB_BAUD.FormattingEnabled = true;
            this.UI_CB_BAUD.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.UI_CB_BAUD.Location = new System.Drawing.Point(140, 11);
            this.UI_CB_BAUD.Name = "UI_CB_BAUD";
            this.UI_CB_BAUD.Size = new System.Drawing.Size(121, 21);
            this.UI_CB_BAUD.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_CB_BAUD);
            this.Controls.Add(this.UI_NUD_Interval);
            this.Controls.Add(this.UI_CB_Random);
            this.Controls.Add(this.UI_B_Blast);
            this.Controls.Add(this.UI_L_Status);
            this.Controls.Add(this.UI_CB_PortSel);
            this.Controls.Add(this.UI_TB_RX);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Form1";
            this.Text = "CNT Micro Serial Utility R1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_NUD_Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort UI_Serial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UI_TB_RX;
        private System.Windows.Forms.ComboBox UI_CB_PortSel;
        private System.Windows.Forms.Label UI_L_Status;
        private System.Windows.Forms.Button UI_B_Blast;
        private System.Windows.Forms.CheckBox UI_CB_Random;
        private System.Windows.Forms.Timer UI_TIM_MAIN;
        private System.Windows.Forms.NumericUpDown UI_NUD_Interval;
        private System.Windows.Forms.ComboBox UI_CB_BAUD;
    }
}

