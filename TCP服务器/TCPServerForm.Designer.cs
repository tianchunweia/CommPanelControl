namespace CommPanelControl
{
    partial class TCPServerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPServerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置通讯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTCPsevername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCPstat = new WindowsFormsControlLibrary1.IOControl();
            this.TCPonoff = new toggle.UserControl1();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.lbTCPsevername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 24);
            this.panel1.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem,
            this.配置通讯ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 配置通讯ToolStripMenuItem
            // 
            this.配置通讯ToolStripMenuItem.Name = "配置通讯ToolStripMenuItem";
            this.配置通讯ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.配置通讯ToolStripMenuItem.Text = "配置通讯";
            this.配置通讯ToolStripMenuItem.Click += new System.EventHandler(this.配置通讯ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // lbTCPsevername
            // 
            this.lbTCPsevername.AutoSize = true;
            this.lbTCPsevername.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTCPsevername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTCPsevername.ForeColor = System.Drawing.Color.White;
            this.lbTCPsevername.Location = new System.Drawing.Point(0, 0);
            this.lbTCPsevername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTCPsevername.Name = "lbTCPsevername";
            this.lbTCPsevername.Size = new System.Drawing.Size(88, 21);
            this.lbTCPsevername.TabIndex = 12;
            this.lbTCPsevername.Text = "TCP服务端";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 0);
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
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "连接状态:";
            // 
            // TCPstat
            // 
            this.TCPstat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TCPstat.BackgroundImage")));
            this.TCPstat.ContextMenuStrip = this.contextMenuStrip1;
            this.TCPstat.imageonoroff = false;
            this.TCPstat.Location = new System.Drawing.Point(132, 55);
            this.TCPstat.Name = "TCPstat";
            this.TCPstat.offimage = ((System.Drawing.Image)(resources.GetObject("TCPstat.offimage")));
            this.TCPstat.onimage = ((System.Drawing.Image)(resources.GetObject("TCPstat.onimage")));
            this.TCPstat.Size = new System.Drawing.Size(72, 24);
            this.TCPstat.TabIndex = 26;
            // 
            // TCPonoff
            // 
            this.TCPonoff.Checked = false;
            this.TCPonoff.CheckedFalseColor = System.Drawing.Color.Gray;
            this.TCPonoff.CheckedFalseTextColor = System.Drawing.Color.Black;
            this.TCPonoff.CheckedTrueColor = System.Drawing.Color.Green;
            this.TCPonoff.CheckedTrueTextColor = System.Drawing.Color.Blue;
            this.TCPonoff.ContextMenuStrip = this.contextMenuStrip1;
            this.TCPonoff.FalseText = null;
            this.TCPonoff.Location = new System.Drawing.Point(60, 105);
            this.TCPonoff.Margin = new System.Windows.Forms.Padding(4);
            this.TCPonoff.Name = "TCPonoff";
            this.TCPonoff.Size = new System.Drawing.Size(107, 34);
            this.TCPonoff.SwitchType = toggle.SwitchType.Ellipse;
            this.TCPonoff.TabIndex = 27;
            this.TCPonoff.TrueText = null;
            this.TCPonoff.CheckedChanged += new System.EventHandler(this.TCPonoff_CheckedChanged);
            this.TCPonoff.Load += new System.EventHandler(this.TCPonoff_Load);
            // 
            // TCPServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 167);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.TCPonoff);
            this.Controls.Add(this.TCPstat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCPServerForm";
            this.Text = "TCPServerformForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTCPsevername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.IOControl TCPstat;
        private toggle.UserControl1 TCPonoff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置通讯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}