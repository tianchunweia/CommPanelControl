using System;
using System.Windows.Forms;

namespace CommPanelControl
{
    /// <summary>
    /// 通讯面板主控件，支持拖拽添加模块并自动加载保存的布局
    /// </summary>
    /// <summary>
    /// 通讯面板主控件，支持拖拽添加模块并自动加载保存的布局
    /// </summary>
    public partial class PanelControl : UserControl
    {
        private int _tcpServerCount = 0; // TCPServer 计数器（可用于自动命名）
        private const string PROTOCOL_TCP_SERVER = "TcpServer";
        private int _moduleCount = 0; // 总模块数，用于生成唯一名称

        public PanelControl()
        {
            InitializeComponent();

            panel1.AllowDrop = true;
            panel1.DragEnter += Panel1_DragEnter;
            panel1.DragDrop += Panel1_DragDrop;

            // 拖拽初始化：假设 btnServer 是 TCPServer 拖动按钮
            btnServer.MouseDown += (s, e) =>
                btnServer.DoDragDrop(PROTOCOL_TCP_SERVER, DragDropEffects.Copy);

            LoadSavedLayout();
        }

        /// <summary>
        /// 加载保存的模块布局（来自 layout.txt）
        /// </summary>
        private void LoadSavedLayout()
        {
            var configs = CommConfigManager.LoadLayout();
            foreach (var cfg in configs)
            {
                var module = CommModuleFactory.Create(cfg);
                module.StatusChanged += Module_StatusChanged;
                module.DataReceived += Module_DataReceived;
                module.ErrorOccurred += Module_ErrorOccurred;

                // 创建宿主 Panel 用于嵌入窗体
                var hostPanel = new Panel
                {
                    Width = 250,
                    Height = 200,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                Form form;
                switch (cfg.Type)
                {
                    case PROTOCOL_TCP_SERVER:
                        var tcpModule = module as TcpServerManager;
                        form = new TCPServerForm(tcpModule);

                        try
                        {
                            // 根据配置自动启动服务端
                            if (cfg.Settings.TryGetValue("AutoStart", out string auto) && auto.Equals("true", StringComparison.OrdinalIgnoreCase))
                            {
                                if (!tcpModule.IsRunning)
                                    tcpModule.Start();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"启动 TCP 服务端失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;

                    default:
                        continue; // 不支持的类型忽略
                }

                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                hostPanel.Controls.Add(form);
                form.Show();
                panel1.Controls.Add(hostPanel);
            }
        }

        /// <summary>
        /// 拖动进入 panel 区域时设置允许效果
        /// </summary>
        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// 拖放模块生成实例并添加到界面
        /// </summary>
        private void Panel1_DragDrop(object sender, DragEventArgs e)
        {
            string typeKey = (string)e.Data.GetData(DataFormats.Text);
            _moduleCount++;
            string instanceName = typeKey + _moduleCount;

            // 读取配置（若不存在则返回默认类型）
            var cfg = CommConfigManager.Load(instanceName, typeKey);

            // 新建模块时默认设置自动启动
            if (!cfg.Settings.ContainsKey("AutoStart"))
                cfg.Settings["AutoStart"] = "true";

            var module = CommModuleFactory.Create(cfg);

            module.StatusChanged += Module_StatusChanged;
            module.DataReceived += Module_DataReceived;
            module.ErrorOccurred += Module_ErrorOccurred;

            // 创建宿主 Panel
            var hostPanel = new Panel
            {
                Width = 250,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Form form;
            switch (cfg.Type)
            {
                case PROTOCOL_TCP_SERVER:
                    form = new TCPServerForm(module as TcpServerManager);
                    break;

                default:
                    MessageBox.Show($"暂不支持类型: {cfg.Type}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            hostPanel.Controls.Add(form);
            form.Show();
            panel1.Controls.Add(hostPanel);

            // 拖拽添加后保存当前配置
            CommConfigManager.Save(cfg);
            var currentLayout = CommConfigManager.LoadLayout();
            if (!currentLayout.Exists(c => c.Name == cfg.Name))
            {
                currentLayout.Add(cfg);
                CommConfigManager.SaveLayout(currentLayout);
            }
        }

        /// <summary>
        /// 模块状态变化事件（如启动/停止）
        /// </summary>
        private void Module_StatusChanged(object sender, bool running)
        {
            // TODO: 可用于更新按钮状态
        }

        /// <summary>
        /// 模块收到数据事件
        /// </summary>
        private void Module_DataReceived(object sender, Tuple<object, byte[]> data)
        {
            // TODO: 可用于展示数据到日志面板
        }

        /// <summary>
        /// 模块发生错误事件
        /// </summary>
        private void Module_ErrorOccurred(object sender, Exception ex)
        {
            MessageBox.Show(ex.Message, "通信模块错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}