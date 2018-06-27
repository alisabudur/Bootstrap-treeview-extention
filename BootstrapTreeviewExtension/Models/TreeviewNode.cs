using System.Collections.Generic;
using Newtonsoft.Json;

namespace BootstrapTreeviewExtension.Models
{
    public class TreeviewNode
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("selectedIcon")]
        public string SelectedIcon { get; set; }

        [JsonProperty("state")]
        public NodeState State { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("params")]
        public object Params { get; set; }

        [JsonProperty("nodes")]
        public IEnumerable<TreeviewNode> Nodes { get; set;  }
    }
}
