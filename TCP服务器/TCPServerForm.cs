using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommPanelControl
{
    public partial class TCPServerForm : Form
    {
        private readonly TcpServerManager _manager;
        private readonly CommConfig _config;

        // 构造：接收模块实例
        public TCPServerForm(TcpServerManager manager)
        {
            InitializeComponent();
            _manager = manager;
            _config = manager.Config;

            // 初始化 UI
            lbTCPsevername.Text = _config.Name;
            TCPonoff.Checked = false;
            TCPstat.imageonoroff = false;

            // 订阅模块事件
            _manager.StatusChanged += Manager_StatusChanged;
            _manager.DataReceived += Manager_DataReceived;
            _manager.ErrorOccurred += (s, e) => MessageBox.Show(e.Message, "错误");
        }

        private void Manager_StatusChanged(object sender, bool running)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, bool>(Manager_StatusChanged), sender, running);
                return;
            }
            TCPonoff.Checked = running;
            TCPstat.imageonoroff = running;

            // 更新 AutoStart 设置并保存
            _config.Settings["AutoStart"] = running.ToString().ToLower();
            CommConfigManager.Save(_config);
        }

        private void Manager_DataReceived(object sender, Tuple<object, byte[]> data)
        {
            // TODO: 将接收到的数据追加到日志 TextBox
        }

        private void Manager_ServerStatusChanged(object sender, bool running)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, bool>(Manager_ServerStatusChanged), sender, running);
                return;
            }
            TCPonoff.Checked = running ? true : false;
            TCPstat.imageonoroff = running ? true : false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 停止服务
            _manager.Stop();

            // 删除配置文件
            var configFile = Path.Combine(Application.StartupPath, "Configs", _config.Name + ".cfg");
            if (File.Exists(configFile))
                File.Delete(configFile);

            // 从布局文件移除对应项
            var layout = CommConfigManager.LoadLayout();
            layout.RemoveAll(c => c.Name == _config.Name);
            CommConfigManager.SaveLayout(layout);

            // 移除当前窗体的宿主 Panel
            if (this.Parent != null && this.Parent.Parent != null)
            {
                var hostPanel = this.Parent;
                var container = hostPanel.Parent;
                container.Controls.Remove(hostPanel);
                hostPanel.Dispose();
            }

            // 释放自身资源
            this.Dispose();
        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newName = Interaction.InputBox("请输入新的名称：", "重命名", lbTCPsevername.Text);
            if (!string.IsNullOrWhiteSpace(newName))
            {
                // 重命名并保存 layout
                var oldName = _config.Name;
                _config.Name = newName;
                lbTCPsevername.Text = newName;

                // 重命名配置文件
                var oldPath = Path.Combine(Application.StartupPath, "Configs", oldName + ".cfg");
                var newPath = Path.Combine(Application.StartupPath, "Configs", newName + ".cfg");
                if (File.Exists(oldPath)) File.Move(oldPath, newPath);
                CommConfigManager.Save(_config);

                // 更新布局
                var layout = CommConfigManager.LoadLayout();
                var item = layout.Find(c => c.Name == oldName);
                if (item != null)
                {
                    item.Name = newName;
                    CommConfigManager.SaveLayout(layout);
                }
            }
        }

        private void 配置通讯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var setForm = new TCPServerSetForm(_config.Name);
            if (setForm.ShowDialog() == DialogResult.OK)
            {
                lbTCPsevername.Text = _config.Name; // updated name if changed
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void TCPonoff_CheckedChanged(object sender, EventArgs e)
        {
            if (TCPonoff.Checked)
            {
                // 打开服务端
                _manager.Start();
                _config.Settings["AutoStart"] = "true";
            }
            else
            {
                // 关闭服务端
                _manager.Stop();
                _config.Settings["AutoStart"] = "false";
            }
            // 保存单模块配置
            CommConfigManager.Save(_config);

            // 同步更新布局文件中的 AutoStart 设置
            var layout = CommConfigManager.LoadLayout();
            var item = layout.Find(c => c.Name == _config.Name);
            if (item != null)
            {
                item.Settings["AutoStart"] = _config.Settings["AutoStart"];
                CommConfigManager.SaveLayout(layout);
            }
            else
            {
                // 关闭服务端
                _manager.Stop();
                // 更新配置关闭自动启动
                _config.Settings["AutoStart"] = "false";
            }
            // 保存配置文件
            CommConfigManager.Save(_config);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void TCPonoff_Load(object sender, EventArgs e)
        {
        }
    }
}