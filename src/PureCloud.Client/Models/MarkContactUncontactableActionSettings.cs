using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MarkContactUncontactableActionSettings
/// </summary>

public partial class MarkContactUncontactableActionSettings : IEquatable<MarkContactUncontactableActionSettings>
{
    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    
    public enum MediaTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms,

        /// <summary>
        /// Enum Whatsapp for "WhatsApp"
        /// </summary>
        [EnumMember(Value = "WhatsApp")]
        Whatsapp
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkContactUncontactableActionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MarkContactUncontactableActionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MarkContactUncontactableActionSettings" /> class.
    /// </summary>
    /// <param name="MediaTypes">A list of media types to evaluate. (required).</param>
    public MarkContactUncontactableActionSettings(List<MediaTypesEnum> MediaTypes = null)
    {
        this.MediaTypes = MediaTypes;

    }



    /// <summary>
    /// A list of media types to evaluate.
    /// </summary>
    /// <value>A list of media types to evaluate.</value>
    [JsonPropertyName("mediaTypes")]
    public List<MediaTypesEnum> MediaTypes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MarkContactUncontactableActionSettings {\n");

        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
        return Equals(obj as MarkContactUncontactableActionSettings);
    }

    /// <summary>
    /// Returns true if MarkContactUncontactableActionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of MarkContactUncontactableActionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MarkContactUncontactableActionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
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
            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            return hash;
        }
    }
}
