using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComfileTech.ComfilePi.CP_IO13_4C.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                var model = File.ReadAllText("/proc/device-tree/model").Trim();
                if (!model.Contains("Compute Module 4 "))
                {
                    MessageBox.Show("This application should only be run on a CPi-C series panel PC.", Text);
                    Environment.Exit(0);
                }

                // Workaround for fullscreen on Raspberry Pi OS Bookworm with Wayland and LabWC
                LocationChanged += (s, e) => { Location = new Point(0, 0); };
            }

            // On Linux, bind the digital input lamps to the IO board's digital inputs
            var lamps = _digitalInputPanel.Controls.OfType<Lamp>().ToArray();

            int index = 0;
            foreach (var input in CP_IO13_4C.Instance.DigitalInputs)
            {
                int i = index;

                var lamp = lamps[i];
                lamp.State = input.State;
                lamp.Text = input.Number.ToString();

                input.StateChanged += (di) =>
                {
                    lamp.State = di.State;
                };

                index++;
            }

            // On Linux, bind the digital output buttons to the IO board's digital outputs
            var buttons = _digitalOutputPanel.Controls.OfType<Button>().ToArray();

            index = 0;
            foreach (var output in CP_IO13_4C.Instance.DigitalOutputs)
            {
                int i = index;

                var button = buttons[i];
                button.State = output.State;
                button.Text = output.Number.ToString();

                button.StateChanged += (s, e) =>
                {
                    output.State = button.State;
                };

                index++;
            }
        }

        private void _repositoryUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            System.Diagnostics.Process.Start(linkLabel.Text);
        }

        void SerialTest(SerialPort port, Label label)
        {
            label.Text = string.Empty;
            label.ForeColor = Color.White;
            label.Update();

            var baudrates = new int[]
            {
                    9600,
                    19200,
                    38400,
                    57600,
                    115200,
                    230400,
                    460800
            };

            var parities = new List<Parity>();
            parities.AddRange(new Parity[]
            {
                Parity.None,
                Parity.Odd,
                Parity.Even
            });

            try
            {
                port.ReadTimeout = 500;
                port.WriteTimeout = 500;
                port.ReadBufferSize = 2048;
                port.WriteBufferSize = 2048;

                port.Open();
                port.DiscardInBuffer();
                port.DiscardOutBuffer();

                byte[] txBytes = new byte[256];
                for (int i = 0; i < txBytes.Length; i++)
                {
                    txBytes[i] = (byte)i;
                }

                foreach (var baud in baudrates)
                {
                    foreach (var parity in parities)
                    {
                        label.Text = $"Testing {baud},{parity}";
                        label.ForeColor = Color.White;
                        label.Update();

                        port.Write(txBytes, 0, txBytes.Length);

                        byte[] rxBytes = new byte[256];
                        int bc = 0;
                        while (bc != txBytes.Length)
                        {
                            bc += port.Read(rxBytes, bc, txBytes.Length - bc);
                        }

                        if (!rxBytes.SequenceEqual(txBytes))
                        {
                            throw new Exception("Data mismatch");
                        }
                    }
                }

                port.Close();

                label.Text = "PASS";
                label.ForeColor = Color.FromArgb(128, 255, 128);
                label.Update();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                label.Text = "FAIL";
                label.ForeColor = Color.FromArgb(255, 128, 128);
                label.Update();
            }
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _serial2Button_Click(object sender, EventArgs e)
        {
            SerialTest(CP_IO13_4C.Instance.SerialPorts[0], _serial2Result);
        }

        private void _serial3Button_Click(object sender, EventArgs e)
        {
            SerialTest(CP_IO13_4C.Instance.SerialPorts[1], _serial3Result);
        }
    }
}
