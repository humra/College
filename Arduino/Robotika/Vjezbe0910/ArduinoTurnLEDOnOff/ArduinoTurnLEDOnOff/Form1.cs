using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTurnLEDOnOff
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            port.PortName = "COM5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            send(new char[] { '1' });
        }

        private void send(char[] v)
        {
            port.Open();
            port.Write(v, 0, 1);
            port.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            send(new char[] { '0' });
        }
    }
}
