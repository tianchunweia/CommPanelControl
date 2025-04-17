using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommPanelControl
{
    // 1. 定义通用接口
    public interface ICommModule
    {
        string Name { get; }
        CommConfig Config { get; }

        event EventHandler<bool> StatusChanged;

        event EventHandler<Tuple<object, byte[]>> DataReceived;

        event EventHandler<Exception> ErrorOccurred;

        void Start();

        void Stop();

        bool IsRunning { get; } // ← 这个属性
    }

    internal class CommModuleFactory
    {
        public static ICommModule Create(CommConfig cfg)
        {
            switch (cfg.Type)
            {
                case "TcpServer":
                    return new TcpServerManager(cfg);
                // TODO: case "TcpClient": return new TcpClientManager(cfg);
                // TODO: case "SerialPort": return new SerialPortManager(cfg);
                default:
                    throw new NotSupportedException($"Unknown module type: {cfg.Type}");
            }
        }
    }
}