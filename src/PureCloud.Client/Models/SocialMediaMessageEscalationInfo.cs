using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaMessageEscalationInfo
/// </summary>

public partial class SocialMediaMessageEscalationInfo : IEquatable<SocialMediaMessageEscalationInfo>
{
    /// <summary>
    /// Gets or Sets EscalationStatus
    /// </summary>
    
    public enum EscalationStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Throttled for "Throttled"
        /// </summary>
        [EnumMember(Value = "Throttled")]
        Throttled,

        /// <summary>
        /// Enum Previouslyescalated for "PreviouslyEscalated"
        /// </summary>
        [EnumMember(Value = "PreviouslyEscalated")]
        Previouslyescalated,

        /// <summary>
        /// Enum Notescalated for "NotEscalated"
        /// </summary>
        [EnumMember(Value = "NotEscalated")]
        Notescalated,

        /// <summary>
        /// Enum Automatic for "Automatic"
        /// </summary>
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    /// <summary>
    /// Gets or Sets EscalationStatus
    /// </summary>
    [JsonPropertyName("escalationStatus")]
    public EscalationStatusEnum? EscalationStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialMediaMessageEscalationInfo" /> class.
    /// </summary>
    /// <param name="EscalationStatus">EscalationStatus.</param>
    public SocialMediaMessageEscalationInfo(EscalationStatusEnum? EscalationStatus = null)
    {
        this.EscalationStatus = EscalationStatus;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialMediaMessageEscalationInfo {\n");

        sb.Append("  EscalationStatus: ").Append(EscalationStatus).Append("\n");
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
        return Equals(obj as SocialMediaMessageEscalationInfo);
    }

    /// <summary>
    /// Returns true if SocialMediaMessageEscalationInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialMediaMessageEscalationInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialMediaMessageEscalationInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EscalationStatus == other.EscalationStatus ||
                EscalationStatus != null &&
                EscalationStatus.Equals(other.EscalationStatus)
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
            if (EscalationStatus != null)
            {
                hash = hash * 59 + EscalationStatus.GetHashCode();
            }

            return hash;
        }
    }
}
