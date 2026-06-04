using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComfileTech.ComfilePi.CP_IO13_4C.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var uiContext = SynchronizationContext.Current;

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
                var lamp = lamps[index];
                lamp.State = input.State;
                lamp.Text = input.Number.ToString();

                input.StateChanged += di =>
                {
                    if (uiContext != null)
                    {
                        uiContext.Post(_ =>
                        {
                            if (!IsDisposed && !lamp.IsDisposed)
                            {
                                lamp.State = di.State;
                            }
                        }, null);
                    }
                    else if (!IsDisposed && !lamp.IsDisposed)
                    {
                        lamp.State = di.State;
                    }
                };

                index++;
            }

            // On Linux, bind the digital output buttons to the IO board's digital outputs
            var buttons = _digitalOutputPanel.Controls.OfType<Button>().ToArray();

            index = 0;
            foreach (var output in CP_IO13_4C.Instance.DigitalOutputs)
            {
                var button = buttons[index];
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
            if (sender is LinkLabel linkLabel)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkLabel.Text,
                    UseShellExecute = true
                });
            }
        }

        async Task SerialTestAsync(SerialPort port, Label label, System.Windows.Forms.Button button)
        {
            button.Enabled = false;
            SetSerialTestResult(label, string.Empty, Color.White);

            var progress = new Progress<string>(status =>
            {
                SetSerialTestResult(label, status, Color.White);
            });

            try
            {
                await Task.Run(() => SerialTest(port, progress));

                SetSerialTestResult(label, "PASS", Color.FromArgb(128, 255, 128));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                SetSerialTestResult(label, "FAIL", Color.FromArgb(255, 128, 128));
            }
            finally
            {
                if (port.IsOpen)
                {
                    port.Close();
                }

                button.Enabled = true;
            }
        }

        static void SetSerialTestResult(Label label, string text, Color color)
        {
            label.Text = text;
            label.ForeColor = color;
            label.Update();
        }

        static void SerialTest(SerialPort port, IProgress<string> progress)
        {

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
                        progress.Report($"Testing {baud},{parity}");

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
            }
            finally
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void _serial2Button_Click(object sender, EventArgs e)
        {
            await SerialTestAsync(CP_IO13_4C.Instance.SerialPorts[0], _serial2Result, _serial2Button);
        }

        private async void _serial3Button_Click(object sender, EventArgs e)
        {
            await SerialTestAsync(CP_IO13_4C.Instance.SerialPorts[1], _serial3Result, _serial3Button);
        }
    }
}
