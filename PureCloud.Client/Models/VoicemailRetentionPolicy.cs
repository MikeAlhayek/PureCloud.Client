using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Governs how the voicemail is retained
/// </summary>

public partial class VoicemailRetentionPolicy : IEquatable<VoicemailRetentionPolicy>
{
    /// <summary>
    /// The retention policy type
    /// </summary>
    /// <value>The retention policy type</value>
    
    public enum VoicemailRetentionPolicyTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum RetainIndefinitely for "RETAIN_INDEFINITELY"
        /// </summary>
        [EnumMember(Value = "RETAIN_INDEFINITELY")]
        RetainIndefinitely,

        /// <summary>
        /// Enum RetainWithTtl for "RETAIN_WITH_TTL"
        /// </summary>
        [EnumMember(Value = "RETAIN_WITH_TTL")]
        RetainWithTtl,

        /// <summary>
        /// Enum ImmediateDelete for "IMMEDIATE_DELETE"
        /// </summary>
        [EnumMember(Value = "IMMEDIATE_DELETE")]
        ImmediateDelete
    }
    /// <summary>
    /// The retention policy type
    /// </summary>
    /// <value>The retention policy type</value>
    [JsonPropertyName("voicemailRetentionPolicyType")]
    public VoicemailRetentionPolicyTypeEnum? VoicemailRetentionPolicyType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailRetentionPolicy" /> class.
    /// </summary>
    /// <param name="VoicemailRetentionPolicyType">The retention policy type.</param>
    /// <param name="NumberOfDays">If retentionPolicyType &#x3D;&#x3D; RETAIN_WITH_TTL, then this value represents the number of days for the TTL.</param>
    public VoicemailRetentionPolicy(VoicemailRetentionPolicyTypeEnum? VoicemailRetentionPolicyType = null, int? NumberOfDays = null)
    {
        this.VoicemailRetentionPolicyType = VoicemailRetentionPolicyType;
        this.NumberOfDays = NumberOfDays;

    }





    /// <summary>
    /// If retentionPolicyType &#x3D;&#x3D; RETAIN_WITH_TTL, then this value represents the number of days for the TTL
    /// </summary>
    /// <value>If retentionPolicyType &#x3D;&#x3D; RETAIN_WITH_TTL, then this value represents the number of days for the TTL</value>
    [JsonPropertyName("numberOfDays")]
    public int? NumberOfDays { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailRetentionPolicy {\n");

        sb.Append("  VoicemailRetentionPolicyType: ").Append(VoicemailRetentionPolicyType).Append("\n");
        sb.Append("  NumberOfDays: ").Append(NumberOfDays).Append("\n");
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
        return Equals(obj as VoicemailRetentionPolicy);
    }

    /// <summary>
    /// Returns true if VoicemailRetentionPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailRetentionPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailRetentionPolicy other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                VoicemailRetentionPolicyType == other.VoicemailRetentionPolicyType ||
                VoicemailRetentionPolicyType != null &&
                VoicemailRetentionPolicyType.Equals(other.VoicemailRetentionPolicyType)
            ) &&
            (
                NumberOfDays == other.NumberOfDays ||
                NumberOfDays != null &&
                NumberOfDays.Equals(other.NumberOfDays)
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
            if (VoicemailRetentionPolicyType != null)
            {
                hash = hash * 59 + VoicemailRetentionPolicyType.GetHashCode();
            }

            if (NumberOfDays != null)
            {
                hash = hash * 59 + NumberOfDays.GetHashCode();
            }

            return hash;
        }
    }
}
