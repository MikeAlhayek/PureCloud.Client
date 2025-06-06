using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageStickerAttachment
/// </summary>

public partial class MessageStickerAttachment : IEquatable<MessageStickerAttachment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageStickerAttachment" /> class.
    /// </summary>
    /// <param name="Url">The location of the media, useful for retrieving it.</param>
    /// <param name="Id">A globally unique identifier for the media object..</param>
    public MessageStickerAttachment(string Url = null, string Id = null)
    {
        this.Url = Url;
        this.Id = Id;

    }



    /// <summary>
    /// The location of the media, useful for retrieving it
    /// </summary>
    /// <value>The location of the media, useful for retrieving it</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// A globally unique identifier for the media object.
    /// </summary>
    /// <value>A globally unique identifier for the media object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessageStickerAttachment {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as MessageStickerAttachment);
    }

    /// <summary>
    /// Returns true if MessageStickerAttachment instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageStickerAttachment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageStickerAttachment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
