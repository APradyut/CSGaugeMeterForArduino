using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Gauge
{
    public partial class Form1 : Form
    {
        private int stop = 0;
        private SerialPort arduino;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arduino = new SerialPort(textBox1.Text, 9600);
                arduino.Open();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            for (int i = 0;stop != 1 ; i++)
            {
                try
                {
                    meter.Value = Convert.ToInt32(arduino.ReadLine().ToString());
                    checkStop();
                }
                catch (Exception exp)
                {
                }

            }
        }
        public void close()
        {
            arduino.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = 1;
        }
    }
}
