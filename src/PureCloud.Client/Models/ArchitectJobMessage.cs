using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectJobMessage
/// </summary>

public partial class ArchitectJobMessage : IEquatable<ArchitectJobMessage>
{
    /// <summary>
    /// The message type.
    /// </summary>
    /// <value>The message type.</value>
    
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
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Warning for "Warning"
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning
    }
    /// <summary>
    /// The message type.
    /// </summary>
    /// <value>The message type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectJobMessage" /> class.
    /// </summary>
    /// <param name="DateTime">The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Type">The message type..</param>
    /// <param name="Text">The text of the message..</param>
    public ArchitectJobMessage(DateTime? DateTime = null, TypeEnum? Type = null, string Text = null)
    {
        this.DateTime = DateTime;
        this.Type = Type;
        this.Text = Text;

    }



    /// <summary>
    /// The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateTime")]
    public DateTime? DateTime { get; set; }





    /// <summary>
    /// The text of the message.
    /// </summary>
    /// <value>The text of the message.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectJobMessage {\n");

        sb.Append("  DateTime: ").Append(DateTime).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
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
        return Equals(obj as ArchitectJobMessage);
    }

    /// <summary>
    /// Returns true if ArchitectJobMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectJobMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectJobMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateTime == other.DateTime ||
                DateTime != null &&
                DateTime.Equals(other.DateTime)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
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
            if (DateTime != null)
            {
                hash = hash * 59 + DateTime.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            return hash;
        }
    }
}
