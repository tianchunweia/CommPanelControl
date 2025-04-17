using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommPanelControl
{
    /// <summary>
    /// 通用配置管理器：读写 CommConfig 到文本文件，并支持保存布局信息
    /// </summary>
    public static class CommConfigManager
    {
        //private static readonly string ConfigDir =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs");

        //private static readonly string LayoutPath =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "layout.txt");

        private static readonly string ConfigDir = Path.Combine(Application.StartupPath, "Configs");
        private static readonly string LayoutPath = Path.Combine(Application.StartupPath, "layout.txt");

        private static string GetPath(string name)
        {
            if (!Directory.Exists(ConfigDir))
                Directory.CreateDirectory(ConfigDir);
            return Path.Combine(ConfigDir, name + ".cfg");
        }

        public static void Save(CommConfig cfg)
        {
            string path = GetPath(cfg.Name);
            using (var writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                writer.WriteLine("Type=" + cfg.Type);
                foreach (var kv in cfg.Settings)
                {
                    writer.WriteLine(kv.Key + "=" + kv.Value);
                }
            }
        }

        public static CommConfig Load(string name, string defaultType)
        {
            string path = GetPath(name);
            var cfg = new CommConfig { Name = name, Type = defaultType };
            if (!File.Exists(path)) return cfg;
            foreach (var line in File.ReadAllLines(path, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                int idx = line.IndexOf('=');
                if (idx <= 0) continue;
                string key = line.Substring(0, idx);
                string val = line.Substring(idx + 1);
                if (key.Equals("Type", StringComparison.OrdinalIgnoreCase))
                    cfg.Type = val;
                else
                    cfg.Settings[key] = val;
            }
            return cfg;
        }

        /// <summary>
        /// 保存模块布局信息（列表形式）
        /// </summary>
        public static void SaveLayout(List<CommConfig> layout)
        {
            using (var writer = new StreamWriter(LayoutPath, false, Encoding.UTF8))
            {
                foreach (var cfg in layout)
                {
                    writer.Write(cfg.Name);
                    writer.Write("|" + cfg.Type);
                    foreach (var kv in cfg.Settings)
                    {
                        writer.Write("|" + kv.Key + "=" + kv.Value);
                    }
                    writer.WriteLine();
                }
            }
        }

        /// <summary>
        /// 加载模块布局信息
        /// </summary>
        public static List<CommConfig> LoadLayout()
        {
            var list = new List<CommConfig>();
            if (!File.Exists(LayoutPath)) return list;
            foreach (var line in File.ReadAllLines(LayoutPath, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                if (parts.Length < 2) continue;
                var cfg = new CommConfig { Name = parts[0], Type = parts[1] };
                for (int i = 2; i < parts.Length; i++)
                {
                    var kv = parts[i].Split(new[] { '=' }, 2);
                    if (kv.Length == 2)
                        cfg.Settings[kv[0]] = kv[1];
                }
                list.Add(cfg);
            }
            return list;
        }
    }
}