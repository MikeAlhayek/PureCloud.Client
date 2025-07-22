using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatConfig
{
    /// <summary>
    /// css class to be applied to the web chat widget.
    /// </summary>
    /// <value>css class to be applied to the web chat widget.</value>
    public WebChatConfigWebChatSkinEnum? WebChatSkin { get; set; }
}
