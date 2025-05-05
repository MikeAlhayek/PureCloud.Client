using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Template header object.
/// </summary>

public partial class NotificationTemplateHeader : IEquatable<NotificationTemplateHeader>
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
    /// Initializes a new instance of the <see cref="NotificationTemplateHeader" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NotificationTemplateHeader() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationTemplateHeader" /> class.
    /// </summary>
    /// <param name="Type">Template header type. (required).</param>
    /// <param name="Text">Header text. For WhatsApp, ignored..</param>
    /// <param name="Media">Media template header image..</param>
    /// <param name="Parameters">Template parameters for placeholders in template..</param>
    public NotificationTemplateHeader(TypeEnum? Type = null, string Text = null, ContentAttachment Media = null, List<NotificationTemplateParameter> Parameters = null)
    {
        this.Type = Type;
        this.Text = Text;
        this.Media = Media;
        this.Parameters = Parameters;

    }





    /// <summary>
    /// Header text. For WhatsApp, ignored.
    /// </summary>
    /// <value>Header text. For WhatsApp, ignored.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Media template header image.
    /// </summary>
    /// <value>Media template header image.</value>
    [JsonPropertyName("media")]
    public ContentAttachment Media { get; set; }



    /// <summary>
    /// Template parameters for placeholders in template.
    /// </summary>
    /// <value>Template parameters for placeholders in template.</value>
    [JsonPropertyName("parameters")]
    public List<NotificationTemplateParameter> Parameters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NotificationTemplateHeader {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Media: ").Append(Media).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
        return Equals(obj as NotificationTemplateHeader);
    }

    /// <summary>
    /// Returns true if NotificationTemplateHeader instances are equal
    /// </summary>
    /// <param name="other">Instance of NotificationTemplateHeader to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NotificationTemplateHeader other)
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
            ) &&
            (
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.SequenceEqual(other.Parameters)
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

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            return hash;
        }
    }
}
