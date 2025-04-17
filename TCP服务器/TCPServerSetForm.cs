using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommPanelControl
{
    public partial class TCPServerSetForm : Form
    {
        private readonly CommConfig _config;
        public string ServerIP { get; private set; }
        public int ServerPort { get; private set; }

        public TCPServerSetForm(string name)
        {
            InitializeComponent();
            _config = CommConfigManager.Load(name, "TcpServer");
            txtTCPIPAddress.Text = _config.Settings.ContainsKey("IP") ? _config.Settings["IP"] : "127.0.0.1";
            txtTCPPort.Text = _config.Settings.ContainsKey("Port") ? _config.Settings["Port"] : "8000";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ServerIP = txtTCPIPAddress.Text;
            ServerPort = int.TryParse(txtTCPPort.Text, out var p) ? p : 8000;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnClearReceivedData_Click(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ServerIP = txtTCPIPAddress.Text;
            ServerPort = int.TryParse(txtTCPPort.Text, out var p) ? p : 8000;
            _config.Settings["IP"] = ServerIP;
            _config.Settings["Port"] = ServerPort.ToString();
            CommConfigManager.Save(_config);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}