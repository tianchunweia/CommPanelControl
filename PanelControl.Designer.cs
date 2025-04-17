namespace CommPanelControl
{
    partial class PanelControl
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMitsubishi = new System.Windows.Forms.Button();
            this.btnUdp = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1051, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "通讯控制";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.11717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.88283F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 550);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnMitsubishi);
            this.groupBox3.Controls.Add(this.btnUdp);
            this.groupBox3.Controls.Add(this.btnClient);
            this.groupBox3.Controls.Add(this.btnServer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(213, 540);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "通讯工具";
            // 
            // btnMitsubishi
            // 
            this.btnMitsubishi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.btnMitsubishi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMitsubishi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMitsubishi.ForeColor = System.Drawing.Color.White;
            this.btnMitsubishi.Location = new System.Drawing.Point(4, 205);
            this.btnMitsubishi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMitsubishi.Name = "btnMitsubishi";
            this.btnMitsubishi.Size = new System.Drawing.Size(205, 58);
            this.btnMitsubishi.TabIndex = 3;
            this.btnMitsubishi.Text = "三菱PLC";
            this.btnMitsubishi.UseVisualStyleBackColor = false;
            // 
            // btnUdp
            // 
            this.btnUdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.btnUdp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUdp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUdp.ForeColor = System.Drawing.Color.White;
            this.btnUdp.Location = new System.Drawing.Point(4, 147);
            this.btnUdp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUdp.Name = "btnUdp";
            this.btnUdp.Size = new System.Drawing.Size(205, 58);
            this.btnUdp.TabIndex = 2;
            this.btnUdp.Text = "UDP";
            this.btnUdp.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(4, 89);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(205, 58);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "TCP客户端";
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.btnServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Location = new System.Drawing.Point(4, 31);
            this.btnServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(205, 58);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "TCP服务端";
            this.btnServer.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(225, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(822, 540);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯配置";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 504);
            this.panel1.TabIndex = 0;
            // 
            // PanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PanelControl";
            this.Size = new System.Drawing.Size(1051, 594);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMitsubishi;
        private System.Windows.Forms.Button btnUdp;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}
