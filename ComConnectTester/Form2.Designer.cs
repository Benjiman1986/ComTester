namespace ComConnectTester
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.send_Text = new System.Windows.Forms.TextBox();
			this.m_portList = new System.Windows.Forms.ComboBox();
			this.btn_open = new System.Windows.Forms.Button();
			this.btn_send = new System.Windows.Forms.Button();
			this.received_message = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// send_Text
			// 
			this.send_Text.Location = new System.Drawing.Point(95, 88);
			this.send_Text.Name = "send_Text";
			this.send_Text.Size = new System.Drawing.Size(149, 20);
			this.send_Text.TabIndex = 0;
			// 
			// m_portList
			// 
			this.m_portList.FormattingEnabled = true;
			this.m_portList.Location = new System.Drawing.Point(95, 52);
			this.m_portList.Name = "m_portList";
			this.m_portList.Size = new System.Drawing.Size(149, 21);
			this.m_portList.TabIndex = 1;
			// 
			// btn_open
			// 
			this.btn_open.Location = new System.Drawing.Point(265, 52);
			this.btn_open.Name = "btn_open";
			this.btn_open.Size = new System.Drawing.Size(75, 23);
			this.btn_open.TabIndex = 2;
			this.btn_open.Text = "Open";
			this.btn_open.UseVisualStyleBackColor = true;
			this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(265, 84);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(75, 23);
			this.btn_send.TabIndex = 3;
			this.btn_send.Text = "Send";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// received_message
			// 
			this.received_message.Location = new System.Drawing.Point(95, 126);
			this.received_message.Name = "received_message";
			this.received_message.Size = new System.Drawing.Size(421, 119);
			this.received_message.TabIndex = 5;
			this.received_message.Text = "";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 257);
			this.Controls.Add(this.received_message);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.btn_open);
			this.Controls.Add(this.m_portList);
			this.Controls.Add(this.send_Text);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox send_Text;
		private System.Windows.Forms.ComboBox m_portList;
		private System.Windows.Forms.Button btn_open;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.RichTextBox received_message;
	}
}