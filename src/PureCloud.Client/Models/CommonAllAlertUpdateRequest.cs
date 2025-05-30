using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonAllAlertUpdateRequest
/// </summary>

public partial class CommonAllAlertUpdateRequest : IEquatable<CommonAllAlertUpdateRequest>
{
    /// <summary>
    /// The action to take
    /// </summary>
    /// <value>The action to take</value>
    
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
        /// Enum Mute for "Mute"
        /// </summary>
        [EnumMember(Value = "Mute")]
        Mute,

        /// <summary>
        /// Enum Snooze for "Snooze"
        /// </summary>
        [EnumMember(Value = "Snooze")]
        Snooze,

        /// <summary>
        /// Enum Unread for "Unread"
        /// </summary>
        [EnumMember(Value = "Unread")]
        Unread
    }
    /// <summary>
    /// The action to take
    /// </summary>
    /// <value>The action to take</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonAllAlertUpdateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonAllAlertUpdateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonAllAlertUpdateRequest" /> class.
    /// </summary>
    /// <param name="Type">The action to take (required).</param>
    /// <param name="Unread">The fields need for an unread update requests.</param>
    public CommonAllAlertUpdateRequest(TypeEnum? Type = null, UnreadFields Unread = null)
    {
        this.Type = Type;
        this.Unread = Unread;

    }





    /// <summary>
    /// The fields need for an unread update requests
    /// </summary>
    /// <value>The fields need for an unread update requests</value>
    [JsonPropertyName("unread")]
    public UnreadFields Unread { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonAllAlertUpdateRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Unread: ").Append(Unread).Append("\n");
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
        return Equals(obj as CommonAllAlertUpdateRequest);
    }

    /// <summary>
    /// Returns true if CommonAllAlertUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonAllAlertUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonAllAlertUpdateRequest other)
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
                Unread == other.Unread ||
                Unread != null &&
                Unread.Equals(other.Unread)
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

            if (Unread != null)
            {
                hash = hash * 59 + Unread.GetHashCode();
            }

            return hash;
        }
    }
}
