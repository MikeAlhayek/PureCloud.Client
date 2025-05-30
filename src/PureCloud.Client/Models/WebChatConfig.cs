using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatConfig
/// </summary>

public partial class WebChatConfig : IEquatable<WebChatConfig>
{
    /// <summary>
    /// css class to be applied to the web chat widget.
    /// </summary>
    /// <value>css class to be applied to the web chat widget.</value>
    
    public enum WebChatSkinEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Basic for "basic"
        /// </summary>
        [EnumMember(Value = "basic")]
        Basic,

        /// <summary>
        /// Enum Moderncaretskin for "modern-caret-skin"
        /// </summary>
        [EnumMember(Value = "modern-caret-skin")]
        Moderncaretskin
    }
    /// <summary>
    /// css class to be applied to the web chat widget.
    /// </summary>
    /// <value>css class to be applied to the web chat widget.</value>
    [JsonPropertyName("webChatSkin")]
    public WebChatSkinEnum? WebChatSkin { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatConfig" /> class.
    /// </summary>
    /// <param name="WebChatSkin">css class to be applied to the web chat widget..</param>
    public WebChatConfig(WebChatSkinEnum? WebChatSkin = null)
    {
        this.WebChatSkin = WebChatSkin;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatConfig {\n");

        sb.Append("  WebChatSkin: ").Append(WebChatSkin).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as WebChatConfig);
    }

    /// <summary>
    /// Returns true if WebChatConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WebChatSkin == other.WebChatSkin ||
                WebChatSkin != null &&
                WebChatSkin.Equals(other.WebChatSkin)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (WebChatSkin != null)
            {
                hash = hash * 59 + WebChatSkin.GetHashCode();
            }

            return hash;
        }
    }
}
