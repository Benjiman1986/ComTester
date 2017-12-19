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

namespace ComConnectTester
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort m_Receiver = null;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

		//private void Form1_Load(object sender, EventArgs e)
		//{
		//	COM2 = new System.IO.Ports.SerialPort("COM2");
		//	COM2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Com2_DataReceived);
		//	COM2.Open();
		//}

		//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		//{
		//	COM2.Close();
		//	COM2 = null;
		//}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	System.IO.Ports.SerialPort com1 = new System.IO.Ports.SerialPort("COM1");
		//	com1.Open();
		//	byte[] send = { 0x01, 0x05, 0x00, 0x10, 0xFF, 0x00, 0x8D, 0xFF };
		//	com1.Write(send, 0, send.Length);
		//	com1.Close();
		//}

		//private void Com2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		//{
		//	System.IO.Ports.SerialPort com = (System.IO.Ports.SerialPort)sender;
		//	MessageBox.Show(com.ReadExisting());
		//}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			m_Receiver.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//com1.Open();
			var COM1 = new System.IO.Ports.SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			COM1.Open();
			byte[] send = { 0x01, 0x05, 0x00, 0x10, 0xFF, 0x00, 0x8D, 0xFF };
			COM1.Write(send, 0, send.Length);
			//com1.Close();
		}

		private void Com2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			System.IO.Ports.SerialPort com = (System.IO.Ports.SerialPort)sender;
			MessageBox.Show(com.ReadExisting());
			MessageBox.Show(com.ReadExisting());
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			var names = SerialPort.GetPortNames();
			if ((names != null) && (names.Length > 0))
			{
				this.m_wndPortNames.Items.AddRange(names);
				this.m_wndPortNames.SelectedIndex = 0;

				this.m_wndWritePort.Items.AddRange(names);
				this.m_wndWritePort.SelectedIndex = 0;
			}
		}

		private void m_wndRead_Click(object sender, EventArgs e)
		{
			//端口名、波特率、奇偶校验位、数据位和停止位
			m_Receiver = new System.IO.Ports.SerialPort(m_wndPortNames.SelectedItem.ToString(), 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			m_Receiver.DataReceived += m_Receiver_DataReceived;
			if (!m_Receiver.IsOpen)
			{
				m_Receiver.Open();
			}

			m_Receiver.WriteLine(m_wndText.Text.Trim());
		}

		void m_Receiver_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			var text = m_Receiver.ReadLine();
			MessageBox.Show(text);
		}

		private void m_wndWriteButton_Click(object sender, EventArgs e)
		{
			var writer = new SerialPort(m_wndWritePort.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
			if (!writer.IsOpen)
			{
				writer.Open();
			}
			
			writer.WriteLine(m_wndText.Text.Trim());
		}

		private void m_wndText_TextChanged(object sender, EventArgs e)
		{
			this.m_wndWriteButton.Enabled = !string.IsNullOrWhiteSpace(m_wndText.Text.Trim());
		}
    }
}
