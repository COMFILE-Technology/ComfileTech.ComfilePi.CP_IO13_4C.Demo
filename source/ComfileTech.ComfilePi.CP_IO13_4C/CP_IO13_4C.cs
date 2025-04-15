using System.Collections.Generic;
using System.IO.Ports;

namespace ComfileTech.ComfilePi.CP_IO13_4C
{
    /// <summary>
    /// Represents the CP-IO13-4C IO board connected to the ComfilePi.
    /// </summary>
    public class CP_IO13_4C
    {
        static CP_IO13_4C()
        {
            Instance = new CP_IO13_4C();
        }

        /// <summary>
        /// The singleton instance of this class.
        /// </summary>
        public static CP_IO13_4C Instance
        {
            get; private set;
        }

        private CP_IO13_4C()
        {
            // Create the digital inputs
            {
                var list = new List<DigitalInput>();
                for (int i = 6; i <= 7; i++)
                {
                    list.Add(new DigitalInput(i));
                }
                for (int i = 10; i <= 11; i++)
                {
                    list.Add(new DigitalInput(i));
                }
                for (int i = 16; i <= 18; i++)
                {
                    list.Add(new DigitalInput(i));
                }
                DigitalInputs = list.AsReadOnly();
            }

            // Create the digital outputs
            {
                var list = new List<DigitalOutput>();
                for (int i = 19; i <= 24; i++)
                {
                    list.Add(new DigitalOutput(i));
                }
                DigitalOutputs = list.AsReadOnly();
            }

            // Create the serial ports
            {
                var list = new List<SerialPort>();
                for (int i = 2; i <= 3; i++)
                {
                    list.Add(new SerialPort($"/dev/serial{i}"));
                }
                SerialPorts = list.AsReadOnly();
            }
        }

        /// <summary>
        /// The digital inputs for the IO board.
        /// </summary>
        public IReadOnlyList<DigitalInput> DigitalInputs
        {
            get;
        }

        /// <summary>
        /// The digital outputs for the IO board.
        /// </summary>
        public IReadOnlyList<DigitalOutput> DigitalOutputs
        {
            get;
        }

        /// <summary>
        /// The serial ports for the IO board.
        /// </summary>
        public IReadOnlyList<SerialPort> SerialPorts
        {
            get;
        }
    }
}
