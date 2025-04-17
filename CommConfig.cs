using System.Collections.Generic;

namespace CommPanelControl
{
    /// <summary>
    /// 通用通讯配置模型
    /// </summary>
    public class CommConfig
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Dictionary<string, string> Settings { get; set; } = new Dictionary<string, string>();
    }
}