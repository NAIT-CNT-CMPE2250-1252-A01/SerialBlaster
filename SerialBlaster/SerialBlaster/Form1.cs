using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialBlaster
{
    public partial class Form1 : Form
    {
        private static Random _rnd = new Random();

        private int _totalCharacters = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // if open, do close
                if (UI_Serial.IsOpen)
                {
                    UI_Serial.Close();
                    button1.Text = "Open Port";
                    return;
                }

                // otherwise do open
                UI_Serial.PortName = UI_CB_PortSel.Text;
                UI_Serial.Open();
                UI_Serial.BaudRate = int.Parse(UI_CB_BAUD.Text);

                if (UI_Serial.IsOpen)
                {
                    UI_Serial.DiscardInBuffer();
                    UI_CB_Random.Enabled = true;
                    button1.Text = "Close Port";
                    UI_L_Status.Text = $"Port {UI_CB_PortSel.Text} opened";
                }
                else
                {
                    UI_L_Status.Text = $"Unable to open {UI_CB_PortSel.Text}";
                }
            }
            catch (Exception ex)
            {
                UI_L_Status.Text = $"Error with port: {ex.Message}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_CB_BAUD.SelectedIndex = 3; // 9600 BAUD

            UI_L_Status.Text = "Enumerating ports...";
            string[] ports = SerialPort.GetPortNames();

            UI_CB_PortSel.Items.Clear();
            foreach (string port in ports)
                UI_CB_PortSel.Items.Add(port);
            if (UI_CB_PortSel.Items.Count > 0)
            {
                UI_CB_PortSel.SelectedIndex = 0;
                UI_L_Status.Text = "Ports enumerated, please select the desired port.";
            }
            else
            {
                UI_L_Status.Text = "No ports appear to be present on the system.";
            }           
        }

        private void UI_Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    string rxtransient = UI_Serial.ReadExisting();
                    UI_TB_RX.Text += rxtransient;
                    _totalCharacters += rxtransient.Length;
                    UI_L_Status.Text = $"{_totalCharacters} bytes total rx'ed";
                }));
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.Write(err.ToString());
            }
        }

        private void UI_B_Blast_Click(object sender, EventArgs e)
        {
            string teststring = "abcdefghijklmnopqrstuvwxyz0123456789";

            if (UI_Serial.IsOpen)
            {
                //System.Diagnostics.Trace.WriteLine(UI_Serial.PortName);
                for (int i = 0; i < 50; ++i)
                    UI_Serial.WriteLine(teststring);
            }
            else
                UI_L_Status.Text = "Open a port first...";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UI_Serial.IsOpen)
            {
                UI_Serial.Close();
            }
        }

        private void UI_CB_Random_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UI_TIM_MAIN_Tick(object sender, EventArgs e)
        {
            if (UI_Serial.IsOpen)
            {
                if (UI_CB_Random.Checked)
                {
                    char[] buffer = new char[1];
                    buffer[0] = (char)_rnd.Next('A', 'Z' + 1);
                    UI_Serial.Write(buffer, 0, 1);
                }
            }
        }

        private void UI_NUD_Interval_ValueChanged(object sender, EventArgs e)
        {
            UI_TIM_MAIN.Interval = (int)UI_NUD_Interval.Value;
        }
    }
}
