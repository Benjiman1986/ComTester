using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComConnectTester
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort COM2 = null;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            COM2 = new System.IO.Ports.SerialPort("COM2");
            COM2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Com2_DataReceived);
            COM2.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            COM2.Close();
            COM2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Ports.SerialPort com1 = new System.IO.Ports.SerialPort("COM1");
            com1.Open();
            byte[] send = { 0x01, 0x05, 0x00, 0x10, 0xFF, 0x00, 0x8D, 0xFF };
            com1.Write(send, 0, send.Length);
            com1.Close();
        }

        private void Com2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort com = (System.IO.Ports.SerialPort)sender;
            MessageBox.Show(com.ReadExisting());
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //端口名、波特率、奇偶校验位、数据位和停止位
        //    //COM1 = new System.IO.Ports.SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
        //    //COM1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Com1_DataReceived);
        //    //COM1.Open();
        //    //Console.WriteLine("sdadsad");
        //}

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    COM1.Close();
        //    COM1 = null;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //com1.Open();
        //    COM1 = new System.IO.Ports.SerialPort("COM3", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
        //    COM1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Com1_DataReceived);
        //    COM1.Open();
        //    byte[] send = { 0x01, 0x05, 0x00, 0x10, 0xFF, 0x00, 0x8D, 0xFF };
        //    COM1.Write(send, 0, send.Length);
        //    //com1.Close();
        //}

        //private void Com1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    System.IO.Ports.SerialPort com = (System.IO.Ports.SerialPort)sender;
        //    MessageBox.Show(com.ReadExisting());
        //}
    }
}
