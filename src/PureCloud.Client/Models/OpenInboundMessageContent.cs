using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message content element.
/// </summary>

public partial class OpenInboundMessageContent : IEquatable<OpenInboundMessageContent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundMessageContent" /> class.
    /// </summary>
    /// <param name="Attachment">Attachment content..</param>
    public OpenInboundMessageContent(OpenContentAttachment Attachment = null)
    {
        this.Attachment = Attachment;

    }



    /// <summary>
    /// Attachment content.
    /// </summary>
    /// <value>Attachment content.</value>
    [JsonPropertyName("attachment")]
    public OpenContentAttachment Attachment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenInboundMessageContent {\n");

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
        return Equals(obj as OpenInboundMessageContent);
    }

    /// <summary>
    /// Returns true if OpenInboundMessageContent instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenInboundMessageContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenInboundMessageContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Attachment != null)
            {
                hash = hash * 59 + Attachment.GetHashCode();
            }

            return hash;
        }
    }
}
