using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoBil
{
    public partial class Form1 : Form
    {
        public enum ArduinoStatus
        {
            Connected,
            Connecting,
            Disconnected
        }

        private ArduinoStatus StatusEnum = ArduinoStatus.Disconnected;
        private SerialPort _arduinoPort;

        public Form1()
        {
            InitializeComponent();
            cbPorts.Items.AddRange(SerialPort.GetPortNames());
            cbPorts.SelectedIndex = 0;

        }

        private void toggleConnectBtn_Click(object sender, EventArgs e)
        {
            switch (StatusEnum)
            {
                case ArduinoStatus.Connected:
                    try
                    {
                        setMotorSpeed(0);

                        _arduinoPort.Close();
                        StatusLabel.Text = "Disconnected";
                        toggleConnectBtn.Text = "Connect";
                        StatusEnum = ArduinoStatus.Disconnected;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        StatusLabel.Text = "Error";
                    }
                    break;
                case ArduinoStatus.Connecting:
                    break;
                case ArduinoStatus.Disconnected:
                    StatusEnum = ArduinoStatus.Connecting;
                    _arduinoPort = new SerialPort(cbPorts.SelectedItem.ToString());
                    _arduinoPort.BaudRate = 9600;

                    try
                    {
                        _arduinoPort.Open();
                        setMotorSpeed(SpeedBar.Value);
                        StatusEnum = ArduinoStatus.Connected;
                        StatusLabel.Text = "Connected";
                        toggleConnectBtn.Text = "Disconnect";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        StatusLabel.Text = "Error";
                    }

                    break;
            }

        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            if (StatusEnum == ArduinoStatus.Connected)
            {
                setMotorSpeed(SpeedBar.Value);
                SpeedBox.Text = SpeedBar.Value.ToString();
            }
        }

        private void setMotorSpeed(int speed)
        {
            byte[] buffer2 = new byte[2];
            buffer2[0] = 16;
            buffer2[1] = (byte)speed;
            _arduinoPort.Write(buffer2, 0, 2);
            Thread.Sleep(15);

        }

        private void setServoPosition(int angle)
        {
            byte[] buffer2 = new byte[2];
            buffer2[0] = 32;
            buffer2[1] = (byte)angle;
            _arduinoPort.Write(buffer2, 0, 2);
            Thread.Sleep(15);

        }

        private void ServoSlider_Scroll(object sender, EventArgs e)
        {
            if (StatusEnum == ArduinoStatus.Connected)
            {
                setServoPosition(ServoSlider.Value);
                AngleBox.Text = ServoSlider.Value.ToString();
            }
        }

        private void SpeedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AngleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setSpeedButton_Click(object sender, EventArgs e)
        {
            try
            {
                var value = Convert.ToInt32(SpeedBox.Text);
                setMotorSpeed(value);
                SpeedBar.Value = value;
            }
            catch (Exception)
            {
                SpeedBox.Text = "Invalid";
            }
        }

        private void SetAngleButton_Click(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(AngleBox.Text);
            try
            {
                setServoPosition(value);
                ServoSlider.Value = value;
            }
            catch (Exception)
            {
                AngleBox.Text = "Invalid";
            }
        }
    }
}
