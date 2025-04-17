using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace CommPanelControl
{
    /// <summary>
    /// 封装 TCP 服务端逻辑
    /// </summary>
   // 3. TCP 服务端管理器，实现 ICommModule
    public class TcpServerManager : ICommModule
    {
        private bool _isRunning = false;

        public bool IsRunning => _isRunning;

        public string Name => Config.Name;
        public CommConfig Config { get; }

        public event EventHandler<bool> StatusChanged;

        public event EventHandler<Tuple<object, byte[]>> DataReceived;

        public event EventHandler<Exception> ErrorOccurred;

        private TcpListener _listener;
        private CancellationTokenSource _cts;

        public TcpServerManager(CommConfig cfg)
        {
            Config = cfg;
        }

        // 启动服务端
        public void Start()
        {
            if (_listener != null) return;
            // 读取配置的 IP 和 Port
            // 如果不指定或为 0.0.0.0/127.0.0.1，监听所有网卡
            string ip = Config.Settings.ContainsKey("IP") ? Config.Settings["IP"] : "127.0.0.1";
            int port = Config.Settings.ContainsKey("Port") && int.TryParse(Config.Settings["Port"], out var p) ? p : 4000;

            try
            {
                // 使用 IPAddress.Any 监听所有可用网卡
                IPAddress ipa = ip == "127.0.0.1" ? IPAddress.Any : IPAddress.Parse(ip);
                _listener = new TcpListener(ipa, port);
                // 设置地址重用，关闭独占模式
                _listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                _listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, false);
                _listener.Start();
                StatusChanged?.Invoke(this, true);
                _cts = new CancellationTokenSource();
                Task.Run(() => AcceptLoop(_cts.Token), _cts.Token);
            }
            catch (SocketException sockEx)
            {
                // 捕获端口被占用或权限不足，提示用户检查
                ErrorOccurred?.Invoke(this, new Exception($"启动失败：{sockEx.Message} (端口 {port})，请确保该端口未被占用且具有权限监听此端口。"));
                // 不自动 Stop，以便用户手动重试或更改配置
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke(this, ex);
            }
        }

        // 异步接收客户端连接
        private async Task AcceptLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    _ = HandleClientAsync(client);  // 不等待
                }
                catch (ObjectDisposedException) { break; }
                catch (Exception ex)
                {
                    ErrorOccurred?.Invoke(this, ex);
                    break;
                }
            }
        }

        // 处理客户端数据
        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                using (client)
                {
                    var stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int len = await stream.ReadAsync(buffer, 0, buffer.Length);
                    byte[] data = new byte[len];
                    Array.Copy(buffer, data, len);
                    DataReceived?.Invoke(this, Tuple.Create<object, byte[]>(client, data));
                    // 回显
                    await stream.WriteAsync(buffer, 0, len);
                }
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke(this, ex);
            }
        }

        // 停止服务端
        public void Stop()
        {
            try
            {
                if (_listener != null)
                {
                    _cts?.Cancel();
                    _listener.Stop();
                    _listener = null;
                    StatusChanged?.Invoke(this, false);
                }
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke(this, ex);
            }
        }
    }
}