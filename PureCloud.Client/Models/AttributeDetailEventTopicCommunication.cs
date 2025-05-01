using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AttributeDetailEventTopicCommunication
/// </summary>
[DataContract]
public partial class AttributeDetailEventTopicCommunication : IEquatable<AttributeDetailEventTopicCommunication>
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Voice for "VOICE"
        /// </summary>
        [EnumMember(Value = "VOICE")]
        Voice,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Callback for "CALLBACK"
        /// </summary>
        [EnumMember(Value = "CALLBACK")]
        Callback,

        /// <summary>
        /// Enum Cobrowse for "COBROWSE"
        /// </summary>
        [EnumMember(Value = "COBROWSE")]
        Cobrowse,

        /// <summary>
        /// Enum Video for "VIDEO"
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        Video,

        /// <summary>
        /// Enum Screenshare for "SCREENSHARE"
        /// </summary>
        [EnumMember(Value = "SCREENSHARE")]
        Screenshare,

        /// <summary>
        /// Enum Message for "MESSAGE"
        /// </summary>
        [EnumMember(Value = "MESSAGE")]
        Message,

        /// <summary>
        /// Enum Internalmessage for "INTERNALMESSAGE"
        /// </summary>
        [EnumMember(Value = "INTERNALMESSAGE")]
        Internalmessage
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AttributeDetailEventTopicCommunication" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="MediaType">MediaType.</param>
    public AttributeDetailEventTopicCommunication(string Id = null, MediaTypeEnum? MediaType = null)
    {
        this.Id = Id;
        this.MediaType = MediaType;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AttributeDetailEventTopicCommunication {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
        return Equals(obj as AttributeDetailEventTopicCommunication);
    }

    /// <summary>
    /// Returns true if AttributeDetailEventTopicCommunication instances are equal
    /// </summary>
    /// <param name="other">Instance of AttributeDetailEventTopicCommunication to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AttributeDetailEventTopicCommunication other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            return hash;
        }
    }
}
