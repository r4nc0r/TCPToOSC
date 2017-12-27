using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TCPToOSC
{
    public partial class Form1 : Form
    {

        private SensorServer<SensorEmitterReading> Server;
        private bool oscEnabled = false;
        private DateTime lastSignal;
        private double height;
        private int counter;

        public Form1()
        {
            InitializeComponent();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPLabel.Text += ip.ToString()+@":3547";
                }
            }
            lastSignal = DateTime.Now;
            height = 0;
            counter = 0;
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
                    ex.SensorReading = RoundData(ex.SensorReading);
                    if (counter % 10 ==0)
                    {
                         CalculateHeight(ex.SensorReading.LinearAccelerationZ);
                    }
                    DebugLabel.Text=counter.ToString();
                    ShowTCPData(ex.SensorReading);
                    SendOscData(ex.SensorReading);
                    LatencyLabel.Text = (DateTime.Now - lastSignal).Milliseconds.ToString();
                    lastSignal = DateTime.Now;
                    /* New sensor data received! Do cool stuff here */
                };
                Server.Start();
                ServerStateLabel.Text = @"Online";
                ServerStateLabel.BackColor = Color.Green;
            
        
            


        }

        private void CalculateHeight(double accleration)
        {
            height += accleration * 9.81 / 1000000 *Math.Pow((DateTime.Now-lastSignal).Milliseconds,2);
            HeigthLabel.Text=height.ToString();

        }

        private SensorEmitterReading RoundData(SensorEmitterReading values)
        {
            values.LinearAccelerationX = Math.Round(values.LinearAccelerationX, 3);
            values.LinearAccelerationY = Math.Round(values.LinearAccelerationY, 3);
            values.LinearAccelerationZ = Math.Round(values.LinearAccelerationZ, 3);

            values.MagnetometerX = Math.Round(values.MagnetometerX, 3);
            values.MagnetometerY = Math.Round(values.MagnetometerY, 3);
            values.MagnetometerZ = Math.Round(values.MagnetometerZ, 3);
            values.MagneticHeading = Math.Round(values.MagneticHeading, 3);

            values.GravityX= Math.Round(values.GravityX, 3);
            values.GravityY= Math.Round(values.GravityY, 3);
            values.GravityZ= Math.Round(values.GravityZ, 3);

            values.QuaternionX= Math.Round(values.QuaternionX, 3);
            values.QuaternionY= Math.Round(values.QuaternionY, 3);
            values.QuaternionZ= Math.Round(values.QuaternionZ, 3);
            values.QuaternionW= Math.Round(values.QuaternionW, 3);

            values.RotationRateX= Math.Round(values.RotationRateX, 3);
            values.RotationRateY= Math.Round(values.RotationRateY, 3);
            values.RotationRateZ= Math.Round(values.RotationRateZ, 3);
            values.RotationPitch= Math.Round(values.RotationPitch, 3);
            values.RotationRoll= Math.Round(values.RotationRoll, 3);
            values.RotationYaw= Math.Round(values.RotationYaw, 3);
           
            return values;
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

        private void SendOscData(SensorEmitterReading values)
        {
            if (oscEnabled)
            {
                var sender = new SharpOSC.UDPSender(OSCIP.Text, decimal.ToInt32(OSCIPPort.Value));
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
            try
            {
                Server.Dispose();
                ServerStateLabel.Text = @"Offline";
                ServerStateLabel.BackColor = Color.Red;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        
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

        private void Calibrate_Click(object sender, EventArgs e)
        {
            height = 0;
        }
    }
}
