using Newtonsoft.Json;

namespace BootstrapTreeviewExtension.Models
{
    public class NodeState
    {
        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("expanded")]
        public bool Expanded { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }
    }
}
