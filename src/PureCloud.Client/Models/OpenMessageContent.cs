using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message content element.
/// </summary>

public partial class OpenMessageContent : IEquatable<OpenMessageContent>
{
    /// <summary>
    /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
    /// </summary>
    /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attachment for "Attachment"
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment
    }
    /// <summary>
    /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
    /// </summary>
    /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessageContent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenMessageContent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessageContent" /> class.
    /// </summary>
    /// <param name="ContentType">Type of this content element. If contentType &#x3D; \&quot;Attachment\&quot; only one item is allowed. (required).</param>
    /// <param name="Attachment">Attachment content..</param>
    public OpenMessageContent(ContentTypeEnum? ContentType = null, ConversationContentAttachment Attachment = null)
    {
        this.ContentType = ContentType;
        this.Attachment = Attachment;

    }





    /// <summary>
    /// Attachment content.
    /// </summary>
    /// <value>Attachment content.</value>
    [JsonPropertyName("attachment")]
    public ConversationContentAttachment Attachment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenMessageContent {\n");

        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Attachment: ").Append(Attachment).Append("\n");
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
        return Equals(obj as OpenMessageContent);
    }

    /// <summary>
    /// Returns true if OpenMessageContent instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenMessageContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenMessageContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Attachment == other.Attachment ||
                Attachment != null &&
                Attachment.Equals(other.Attachment)
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
            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Attachment != null)
            {
                hash = hash * 59 + Attachment.GetHashCode();
            }

            return hash;
        }
    }
}
