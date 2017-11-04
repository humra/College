using Accord.Video;
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

namespace ArduinoDriveWithCamera
{
    public partial class Form1 : Form
    {

        SerialPort port = new SerialPort();
        private long lastSendTime;
        private string server = @"http://192.168.1.2:8080/arduino";

        private List<Keys> validKeys = new List<Keys>();

        public Form1()
        {
            InitializeComponent();
            port.PortName = "COM5";

            validKeys.Add(Keys.W);
            validKeys.Add(Keys.A);
            validKeys.Add(Keys.S);
            validKeys.Add(Keys.D);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            closeCurrentSource();
            MJPEGStream src = new MJPEGStream(server);
            videoSourcePlayer1.VideoSource = src;
            videoSourcePlayer1.Start();
        }

        private void closeCurrentSource()
        {
            if(videoSourcePlayer1.VideoSource != null)
            {
                videoSourcePlayer1.Stop();
                System.Threading.Thread.Sleep(3000);
                videoSourcePlayer1.VideoSource = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lastSendTime = DateTime.Now.Ticks;

            try
            {
                port.Open();
            }
            catch(Exception ex)
            {
                //TO-DO
            }
        }

        private void send(char message)
        {
            try
            {
                char[] sending = new char[] { message };
                port.Write(sending, 0, sending.Length);
            }
            catch(Exception ex)
            {
                //TO-DO
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(!canSend())
            {
                return;
            }
            
            if(!checkKeys(e.KeyCode))
            {
                return;
            }

            switch(e.KeyCode)
            {
                case Keys.A:
                    send('1');
                    break;
                case Keys.W:
                    send('3');
                    break;
                case Keys.S:
                    send('4');
                    break;
                case Keys.D:
                    send('2');
                    break;
                default:
                    break;
            }

            lastSendTime = DateTime.Now.Ticks;
        }

        private bool checkKeys(Keys keyCode)
        {
            if(validKeys.Contains(keyCode))
            {
                return true;
            }

            return false;
        }

        private bool canSend()
        {
            long elapsedTime = DateTime.Now.Ticks - lastSendTime;

            if(elapsedTime / TimeSpan.TicksPerMillisecond > 100)
            {
                return true;
            }

            return false;
        }
    }
}
