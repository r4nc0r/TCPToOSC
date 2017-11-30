using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCPToOSC
{
    public partial class Form1 : Form
    {
        private SensorServer<SensorEmitterReading> Server;
        private bool oscEnabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Server = new SensorServer<SensorEmitterReading>();
            Server.ExceptionOccured += (s, ex) =>
            {
                Console.WriteLine();
                /* Handle a possible exception */
            };
            Server.ValuesReceived += (s, ex) =>
            {
                
                ShowTCPData(ex.SensorReading);
                SendOSCData(ex.SensorReading);
           
                /* New sensor data received! Do cool stuff here */
            };
            Server.Start();
            ServerStateLabel.Text = @"Online";
            ServerStateLabel.BackColor = Color.Green;

        }

        private void ShowTCPData(SensorEmitterReading values)
        {
            if (values.MagnetometerDataValid)
            {
                MagnetX.Text = values.MagnetometerX.ToString();
                MagnetY.Text = values.MagnetometerY.ToString();
                MagnetZ.Text = values.MagnetometerZ.ToString();
                MagnetHeading.Text = values.MagneticHeading.ToString();
            }
            GarvityX.Text = values.GravityX.ToString();
            GarvityY.Text = values.GravityY.ToString();
            GarvityZ.Text = values.GravityZ.ToString();

            QuatnernionX.Text = values.QuaternionX.ToString();
            QuatnernionY.Text = values.QuaternionY.ToString();
            QuatnernionZ.Text = values.QuaternionZ.ToString();
            QuatnernionW.Text = values.QuaternionW.ToString();

            AcclerationX.Text = values.LinearAccelerationX.ToString();
            AcclerationY.Text = values.LinearAccelerationY.ToString();
            AcclerationZ.Text = values.LinearAccelerationZ.ToString();

            RotationX.Text = values.RotationRateX.ToString();
            RotationY.Text = values.RotationRateY.ToString();
            RotationZ.Text = values.RotationRateZ.ToString();
            RotationRoll.Text = values.RotationRoll.ToString();
            RotationPitch.Text = values.RotationPitch.ToString();
            RotationYaw.Text = values.RotationYaw.ToString();
        }

        private void SendOSCData(SensorEmitterReading values)
        {
            if (oscEnabled)
            {
                var sender = new SharpOSC.UDPSender("127.0.0.1", 9000);
                if (magnetchk.Checked)
                {
                    if (values.MagnetometerDataValid)
                    {
                        var message = new SharpOSC.OscMessage("/magnet/", (float)values.MagnetometerX, (float)values.MagnetometerY, (float)values.MagnetometerZ, (float)values.MagneticHeading);
                        sender.Send(message);
                    }
                }
                if (gravitychk.Checked)
                {
                    var message = new SharpOSC.OscMessage("/gravity/", (float)values.GravityX, (float)values.GravityY, (float)values.GravityZ);
                    sender.Send(message);
                }
                if (quaternionchk.Checked)
                {
                    var message = new SharpOSC.OscMessage("/quaternin/", (float)values.QuaternionX, (float)values.QuaternionY, (float)values.QuaternionZ,(float)values.QuaternionW);
                    sender.Send(message);
                }
                if (acclerationchk.Checked)
                {
                    var message = new SharpOSC.OscMessage("/accleration/", (float)values.LinearAccelerationX, (float)values.LinearAccelerationY, (float)values.LinearAccelerationZ);
                    sender.Send(message);
                }
                if (rotationchk.Checked)
                {
                    var message = new SharpOSC.OscMessage("/rotation/", (float)values.RotationRateX, (float)values.RotationRateY, (float)values.RotationRateZ, (float)values.RotationRoll, (float)values.RotationYaw, (float)values.RotationPitch);
                    sender.Send(message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Server.Dispose();
            ServerStateLabel.Text = @"Offline";
            ServerStateLabel.BackColor = Color.Red;
        }

        private void oscStartbtn_Click(object sender, EventArgs e)
        {
            oscEnabled = true;
            OSCStatus.Text = @"Online";
            OSCStatus.BackColor = Color.Green;
        }

        private void oscStopbtn_Click(object sender, EventArgs e)
        {
            oscEnabled = false;
            OSCStatus.Text = @"Offline";
            OSCStatus.BackColor = Color.Red;
        }
    }
}
