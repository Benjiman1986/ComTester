namespace ComConnectTester
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.m_wndPortNames = new System.Windows.Forms.ComboBox();
			this.m_wndRead = new System.Windows.Forms.Button();
			this.m_wndWritePort = new System.Windows.Forms.ComboBox();
			this.m_wndWriteButton = new System.Windows.Forms.Button();
			this.m_wndText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// m_wndPortNames
			// 
			this.m_wndPortNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_wndPortNames.FormattingEnabled = true;
			this.m_wndPortNames.Location = new System.Drawing.Point(30, 38);
			this.m_wndPortNames.Name = "m_wndPortNames";
			this.m_wndPortNames.Size = new System.Drawing.Size(96, 21);
			this.m_wndPortNames.TabIndex = 1;
			// 
			// m_wndRead
			// 
			this.m_wndRead.Location = new System.Drawing.Point(132, 38);
			this.m_wndRead.Name = "m_wndRead";
			this.m_wndRead.Size = new System.Drawing.Size(75, 23);
			this.m_wndRead.TabIndex = 2;
			this.m_wndRead.Text = "OpenRead";
			this.m_wndRead.UseVisualStyleBackColor = true;
			this.m_wndRead.Click += new System.EventHandler(this.m_wndRead_Click);
			// 
			// m_wndWritePort
			// 
			this.m_wndWritePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_wndWritePort.FormattingEnabled = true;
			this.m_wndWritePort.Location = new System.Drawing.Point(30, 186);
			this.m_wndWritePort.Name = "m_wndWritePort";
			this.m_wndWritePort.Size = new System.Drawing.Size(112, 21);
			this.m_wndWritePort.TabIndex = 3;
			// 
			// m_wndWriteButton
			// 
			this.m_wndWriteButton.Enabled = false;
			this.m_wndWriteButton.Location = new System.Drawing.Point(148, 186);
			this.m_wndWriteButton.Name = "m_wndWriteButton";
			this.m_wndWriteButton.Size = new System.Drawing.Size(75, 21);
			this.m_wndWriteButton.TabIndex = 4;
			this.m_wndWriteButton.Text = "WriteLine";
			this.m_wndWriteButton.UseVisualStyleBackColor = true;
			this.m_wndWriteButton.Click += new System.EventHandler(this.m_wndWriteButton_Click);
			// 
			// m_wndText
			// 
			this.m_wndText.Location = new System.Drawing.Point(30, 213);
			this.m_wndText.Name = "m_wndText";
			this.m_wndText.Size = new System.Drawing.Size(193, 20);
			this.m_wndText.TabIndex = 5;
			this.m_wndText.TextChanged += new System.EventHandler(this.m_wndText_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 284);
			this.Controls.Add(this.m_wndText);
			this.Controls.Add(this.m_wndWriteButton);
			this.Controls.Add(this.m_wndWritePort);
			this.Controls.Add(this.m_wndRead);
			this.Controls.Add(this.m_wndPortNames);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox m_wndPortNames;
		private System.Windows.Forms.Button m_wndRead;
		private System.Windows.Forms.ComboBox m_wndWritePort;
		private System.Windows.Forms.Button m_wndWriteButton;
		private System.Windows.Forms.TextBox m_wndText;
    }
}

