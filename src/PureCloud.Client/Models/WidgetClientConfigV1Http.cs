using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WidgetClientConfigV1Http
/// </summary>

public partial class WidgetClientConfigV1Http : IEquatable<WidgetClientConfigV1Http>
{
    /// <summary>
    /// Gets or Sets WebChatSkin
    /// </summary>
    
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
    /// Gets or Sets WebChatSkin
    /// </summary>
    [JsonPropertyName("webChatSkin")]
    public WebChatSkinEnum? WebChatSkin { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WidgetClientConfigV1Http" /> class.
    /// </summary>
    /// <param name="WebChatSkin">WebChatSkin.</param>
    /// <param name="AuthenticationUrl">AuthenticationUrl.</param>
    public WidgetClientConfigV1Http(WebChatSkinEnum? WebChatSkin = null, string AuthenticationUrl = null)
    {
        this.WebChatSkin = WebChatSkin;
        this.AuthenticationUrl = AuthenticationUrl;

    }





    /// <summary>
    /// Gets or Sets AuthenticationUrl
    /// </summary>
    [JsonPropertyName("authenticationUrl")]
    public string AuthenticationUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WidgetClientConfigV1Http {\n");

        sb.Append("  WebChatSkin: ").Append(WebChatSkin).Append("\n");
        sb.Append("  AuthenticationUrl: ").Append(AuthenticationUrl).Append("\n");
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
        return Equals(obj as WidgetClientConfigV1Http);
    }

    /// <summary>
    /// Returns true if WidgetClientConfigV1Http instances are equal
    /// </summary>
    /// <param name="other">Instance of WidgetClientConfigV1Http to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WidgetClientConfigV1Http other)
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
            ) &&
            (
                AuthenticationUrl == other.AuthenticationUrl ||
                AuthenticationUrl != null &&
                AuthenticationUrl.Equals(other.AuthenticationUrl)
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

            if (AuthenticationUrl != null)
            {
                hash = hash * 59 + AuthenticationUrl.GetHashCode();
            }

            return hash;
        }
    }
}
