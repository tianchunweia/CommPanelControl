namespace CommPanelControl
{
    partial class TCPServerSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPServerSetForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCPIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTCPPort = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTCPReceivedData = new System.Windows.Forms.TextBox();
            this.btnClearReceivedData = new System.Windows.Forms.Button();
            this.chkReceiveHexDisplay = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTCPSendDataInput = new System.Windows.Forms.TextBox();
            this.btnSendMsgToOnlineClients = new System.Windows.Forms.Button();
            this.btnClearSendBox = new System.Windows.Forms.Button();
            this.chkSendHex = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 24);
            this.panel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "TCP服务端";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(713, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(101, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "本机IP:";
            // 
            // txtTCPIPAddress
            // 
            this.txtTCPIPAddress.Location = new System.Drawing.Point(181, 57);
            this.txtTCPIPAddress.Multiline = true;
            this.txtTCPIPAddress.Name = "txtTCPIPAddress";
            this.txtTCPIPAddress.Size = new System.Drawing.Size(131, 26);
            this.txtTCPIPAddress.TabIndex = 27;
            this.txtTCPIPAddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(400, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "本机端口:";
            // 
            // txtTCPPort
            // 
            this.txtTCPPort.Location = new System.Drawing.Point(485, 57);
            this.txtTCPPort.Multiline = true;
            this.txtTCPPort.Name = "txtTCPPort";
            this.txtTCPPort.Size = new System.Drawing.Size(54, 26);
            this.txtTCPPort.TabIndex = 29;
            this.txtTCPPort.Text = "5000";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 25);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "自动重连";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtTCPIPAddress);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTCPPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 228);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(632, 53);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 29);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "保存配置";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 243);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据测试";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 215);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTCPReceivedData);
            this.tabPage1.Controls.Add(this.btnClearReceivedData);
            this.tabPage1.Controls.Add(this.chkReceiveHexDisplay);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "接收数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTCPReceivedData
            // 
            this.txtTCPReceivedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTCPReceivedData.Location = new System.Drawing.Point(3, 3);
            this.txtTCPReceivedData.Multiline = true;
            this.txtTCPReceivedData.Name = "txtTCPReceivedData";
            this.txtTCPReceivedData.Size = new System.Drawing.Size(725, 150);
            this.txtTCPReceivedData.TabIndex = 36;
            // 
            // btnClearReceivedData
            // 
            this.btnClearReceivedData.Location = new System.Drawing.Point(643, 150);
            this.btnClearReceivedData.Name = "btnClearReceivedData";
            this.btnClearReceivedData.Size = new System.Drawing.Size(85, 29);
            this.btnClearReceivedData.TabIndex = 35;
            this.btnClearReceivedData.Text = "清空";
            this.btnClearReceivedData.UseVisualStyleBackColor = true;
            this.btnClearReceivedData.Click += new System.EventHandler(this.btnClearReceivedData_Click);
            // 
            // chkReceiveHexDisplay
            // 
            this.chkReceiveHexDisplay.AutoSize = true;
            this.chkReceiveHexDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkReceiveHexDisplay.Location = new System.Drawing.Point(3, 153);
            this.chkReceiveHexDisplay.Name = "chkReceiveHexDisplay";
            this.chkReceiveHexDisplay.Size = new System.Drawing.Size(725, 25);
            this.chkReceiveHexDisplay.TabIndex = 32;
            this.chkReceiveHexDisplay.Text = "16进制显示";
            this.chkReceiveHexDisplay.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTCPSendDataInput);
            this.tabPage2.Controls.Add(this.btnSendMsgToOnlineClients);
            this.tabPage2.Controls.Add(this.btnClearSendBox);
            this.tabPage2.Controls.Add(this.chkSendHex);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "发送数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTCPSendDataInput
            // 
            this.txtTCPSendDataInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTCPSendDataInput.Location = new System.Drawing.Point(3, 3);
            this.txtTCPSendDataInput.Multiline = true;
            this.txtTCPSendDataInput.Name = "txtTCPSendDataInput";
            this.txtTCPSendDataInput.Size = new System.Drawing.Size(725, 150);
            this.txtTCPSendDataInput.TabIndex = 37;
            // 
            // btnSendMsgToOnlineClients
            // 
            this.btnSendMsgToOnlineClients.Location = new System.Drawing.Point(552, 151);
            this.btnSendMsgToOnlineClients.Name = "btnSendMsgToOnlineClients";
            this.btnSendMsgToOnlineClients.Size = new System.Drawing.Size(85, 29);
            this.btnSendMsgToOnlineClients.TabIndex = 35;
            this.btnSendMsgToOnlineClients.Text = "发送";
            this.btnSendMsgToOnlineClients.UseVisualStyleBackColor = true;
            this.btnSendMsgToOnlineClients.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClearSendBox
            // 
            this.btnClearSendBox.Location = new System.Drawing.Point(643, 151);
            this.btnClearSendBox.Name = "btnClearSendBox";
            this.btnClearSendBox.Size = new System.Drawing.Size(85, 29);
            this.btnClearSendBox.TabIndex = 34;
            this.btnClearSendBox.Text = "清空";
            this.btnClearSendBox.UseVisualStyleBackColor = true;
            // 
            // chkSendHex
            // 
            this.chkSendHex.AutoSize = true;
            this.chkSendHex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkSendHex.Location = new System.Drawing.Point(3, 153);
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.Size = new System.Drawing.Size(725, 25);
            this.chkSendHex.TabIndex = 33;
            this.chkSendHex.Text = "16进制显示";
            this.chkSendHex.UseVisualStyleBackColor = true;
            // 
            // TCPServerSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TCPServerSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCPServerformForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCPIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCPPort;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkReceiveHexDisplay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClearReceivedData;
        private System.Windows.Forms.Button btnSendMsgToOnlineClients;
        private System.Windows.Forms.Button btnClearSendBox;
        private System.Windows.Forms.CheckBox chkSendHex;
        private System.Windows.Forms.TextBox txtTCPReceivedData;
        private System.Windows.Forms.TextBox txtTCPSendDataInput;
        private System.Windows.Forms.Button btnOk;
    }
}