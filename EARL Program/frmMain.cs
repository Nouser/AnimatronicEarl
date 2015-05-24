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

namespace EARL_Program
{
    public partial class frmMain : Form
    {
        public bool ready = false;
        public SerialPort myArduino = new SerialPort();
        public frmMain()
        {
            InitializeComponent();
            cbSerialPort.Items.AddRange(SerialPort.GetPortNames());
            //Change to 2000
            myArduino.ReadTimeout = 20;
            cbSerialPort.SelectedIndex = 0;
        }
        private void btnCheckPort_Click_1(object sender, EventArgs e)
        {
            CheckPort();

         }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ready = true;
            //CheckPort();
            if (ready)
            {
                frmRun runWindow = new frmRun(myArduino, this);
                this.Hide();
                runWindow.Show();
            }
        }
        public void CheckPort()
        {
            label2.ForeColor = Color.Red;
            label2.Text = "Not Ready";
            btnStart.Hide();
            try
            {
                if (myArduino.IsOpen)
                    myArduino.Close();
                myArduino.PortName = cbSerialPort.SelectedItem.ToString();
                myArduino.BaudRate = 9600;
                myArduino.Open();
                myArduino.Write("z");
                char[] testRange = new char[1];
                myArduino.Read(testRange, 0, 1);
                String testString = testRange[0].ToString();
                //for (int i = 0; i < 4; i++)
                //    testString += testRange[i];
               
                if (testString.ToLowerInvariant().Equals("x")) 
                    ready = true;
                else
                    MessageBox.Show("Error; wrong port!  Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                catch         
                {
                    ready = false;
                    MessageBox.Show("Error; wrong port!  Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //Comment out later
            ready = true;
            if (ready)
            {
                btnStart.Show();
                label2.ForeColor = Color.Green;
                label2.Text = "Ready!";
            }
        }
        }
    }

