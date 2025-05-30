using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingTemplateHeader
/// </summary>

public partial class RecordingTemplateHeader : IEquatable<RecordingTemplateHeader>
{
    /// <summary>
    /// Template header type.
    /// </summary>
    /// <value>Template header type.</value>
    
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
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// Enum Media for "Media"
        /// </summary>
        [EnumMember(Value = "Media")]
        Media
    }
    /// <summary>
    /// Template header type.
    /// </summary>
    /// <value>Template header type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingTemplateHeader" /> class.
    /// </summary>
    /// <param name="Type">Template header type..</param>
    /// <param name="Text">Header text..</param>
    /// <param name="Media">Media template header image..</param>
    public RecordingTemplateHeader(TypeEnum? Type = null, string Text = null, RecordingAttachment Media = null)
    {
        this.Type = Type;
        this.Text = Text;
        this.Media = Media;

    }





    /// <summary>
    /// Header text.
    /// </summary>
    /// <value>Header text.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Media template header image.
    /// </summary>
    /// <value>Media template header image.</value>
    [JsonPropertyName("media")]
    public RecordingAttachment Media { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingTemplateHeader {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Media: ").Append(Media).Append("\n");
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
        return Equals(obj as RecordingTemplateHeader);
    }

    /// <summary>
    /// Returns true if RecordingTemplateHeader instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingTemplateHeader to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingTemplateHeader other)
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
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Media == other.Media ||
                Media != null &&
                Media.Equals(other.Media)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Media != null)
            {
                hash = hash * 59 + Media.GetHashCode();
            }

            return hash;
        }
    }
}
