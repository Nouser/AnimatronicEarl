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
using System.Threading;
using System.Media;
using NAudio;
using NAudio.Wave;
using NAudio.CoreAudioApi;
namespace EARL_Program
{
    public partial class frmRun : Form
    {
        public int currentStep = 0;
        public SerialPort myArduino;
        public frmMain mainForm;
        public frmRun(SerialPort arduino, frmMain mainForm1)
        {
            mainForm = mainForm1;
            myArduino = arduino;
            InitializeComponent();
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {            
            WaveFileReader scriptReader = new NAudio.Wave.WaveFileReader("Dialogue.wav");
            var scriptOut = new NAudio.Wave.WaveOut();
            scriptOut.DeviceNumber = Decimal.ToInt32(nudScript.Value);
            var scriptOutput = scriptOut;
            scriptOutput.Init(scriptReader);
            scriptOutput.Play();

            WaveFileReader toneReader = new NAudio.Wave.WaveFileReader("Tone.wav");
            var toneOut = new NAudio.Wave.WaveOut();
            toneOut.DeviceNumber = Decimal.ToInt32(nud48.Value);
            var toneOutput = toneOut;
            toneOutput.Init(toneReader);
            toneOutput.Play();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            btnFAQ2.Location = new Point(250, 125);
            btnFAQ2.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentStep = 0;
            panel1.Show();
            panel2.Show();
            btnFAQ2.Visible = false;
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            int waveInDevices = WaveOut.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(waveInDevice);
                MessageBox.Show("Device {" + waveInDevice + "} " + deviceInfo.ProductName + ", {" + deviceInfo.Channels + "} channels");
            }
        }
    }
}
