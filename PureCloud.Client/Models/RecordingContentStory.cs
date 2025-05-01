using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Story object.
/// </summary>
[DataContract]
public partial class RecordingContentStory : IEquatable<RecordingContentStory>
{
    /// <summary>
    /// Type of ephemeral story attachment.
    /// </summary>
    /// <value>Type of ephemeral story attachment.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Mention for "Mention"
        /// </summary>
        [EnumMember(Value = "Mention")]
        Mention,

        /// <summary>
        /// Enum Reply for "Reply"
        /// </summary>
        [EnumMember(Value = "Reply")]
        Reply
    }
    /// <summary>
    /// Type of ephemeral story attachment.
    /// </summary>
    /// <value>Type of ephemeral story attachment.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingContentStory" /> class.
    /// </summary>
    /// <param name="Type">Type of ephemeral story attachment..</param>
    /// <param name="Url">URL to the ephemeral story..</param>
    /// <param name="ReplyToId">ID of the ephemeral story being replied to..</param>
    public RecordingContentStory(TypeEnum? Type = null, string Url = null, string ReplyToId = null)
    {
        this.Type = Type;
        this.Url = Url;
        this.ReplyToId = ReplyToId;

    }





    /// <summary>
    /// URL to the ephemeral story.
    /// </summary>
    /// <value>URL to the ephemeral story.</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }



    /// <summary>
    /// ID of the ephemeral story being replied to.
    /// </summary>
    /// <value>ID of the ephemeral story being replied to.</value>
    [DataMember(Name = "replyToId", EmitDefaultValue = false)]
    public string ReplyToId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingContentStory {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
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
        return Equals(obj as RecordingContentStory);
    }

    /// <summary>
    /// Returns true if RecordingContentStory instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingContentStory to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingContentStory other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                ReplyToId == other.ReplyToId ||
                ReplyToId != null &&
                ReplyToId.Equals(other.ReplyToId)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (ReplyToId != null)
            {
                hash = hash * 59 + ReplyToId.GetHashCode();
            }

            return hash;
        }
    }
}
