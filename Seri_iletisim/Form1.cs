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

namespace Seri_iletisim
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        

        public Form1()
        {
            InitializeComponent();
            _serialPort = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
                //tbRX.Text = "port opened :) ";
                _serialPort.DiscardInBuffer();
            }
            
           // else
                //tbRX.Text = "port busy :( ";

            _serialPort.DataReceived += _serialPort_DataReceived;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private string rxString;

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = _serialPort.BytesToRead;
            byte[] buffer = new byte[bytes];
            _serialPort.Read(buffer, 0, bytes);
            rxString = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            this.Invoke(new EventHandler(displayText));
            
           
        }

        private void displayText(object o, EventArgs e)
        {
            txtAlinacak.AppendText(rxString);
        }


        private void txtGonderilecek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                Byte[] ch = new Byte[1];
                ch[0] = (byte)e.KeyChar;
                _serialPort.Write(ch, 0, 1);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serialPort.Close();
        }

        private void btnYolla_Click(object sender, EventArgs e)
        {
            _serialPort.Write(txtGonderilecek.Text);
        }
    }



}
