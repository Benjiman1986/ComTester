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
	public partial class Form2 : Form
	{
		SerialPort CurrentPort = null;
		public Form2()
		{
			InitializeComponent();
			var names = SerialPort.GetPortNames();
			this.m_portList.DataSource = names;
			CurrentPort = new SerialPort();
		}

		private void btn_open_Click(object sender, EventArgs e)
		{
			CurrentPort.PortName = m_portList.SelectedItem.ToString();
			CurrentPort.BaudRate = 9600;
			CurrentPort.Parity = Parity.None;
			CurrentPort.DataBits = 8;
			CurrentPort.StopBits = StopBits.One;

			CurrentPort.DataReceived += new SerialDataReceivedEventHandler(CurrentPort_DataReceived);
			try
			{
				CurrentPort.Open();
				if (CurrentPort.IsOpen)
				{
					received_message.Text += "The port opend succeed!" + "\n";
				}
				else
				{
					received_message.Text += "The port opend failed!" + "\n";
				}
			}
			catch (Exception ex)
			{
				received_message.Text += "The port opend failed!" + ex + "\n";
			}
		}

		void CurrentPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				string currentLine = "";
				byte[] receivedData = new byte[CurrentPort.BytesToRead];
				CurrentPort.Read(receivedData, 0, receivedData.Length);
				CurrentPort.DiscardInBuffer();

				foreach (var data in receivedData)
				{
					currentLine += data.ToString("X2");
				}

				received_message.Text += currentLine + "\r\n";
			}
			catch (Exception ex)
			{
				received_message.Text += "The port receive message failed!" + ex + "\n";
			}
		}

		private void btn_send_Click(object sender, EventArgs e)
		{
			byte[] writeBuffer = Encoding.ASCII.GetBytes(send_Text.Text.Trim());
			//byte[] writeBuffer = { 0x01, 0x05, 0x00, 0x10, 0xFF, 0x00, 0x8D, 0xFF };
			CurrentPort.Write(writeBuffer, 0, writeBuffer.Length);
		}
	}
}
