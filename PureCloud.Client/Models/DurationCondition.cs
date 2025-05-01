using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DurationCondition
/// </summary>
[DataContract]
public partial class DurationCondition : IEquatable<DurationCondition>
{
    /// <summary>
    /// Gets or Sets DurationTarget
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DurationTargetEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Duration for "DURATION"
        /// </summary>
        [EnumMember(Value = "DURATION")]
        Duration,

        /// <summary>
        /// Enum DurationRange for "DURATION_RANGE"
        /// </summary>
        [EnumMember(Value = "DURATION_RANGE")]
        DurationRange
    }
    /// <summary>
    /// Gets or Sets DurationMode
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DurationModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Between for "Between"
        /// </summary>
        [EnumMember(Value = "Between")]
        Between,

        /// <summary>
        /// Enum Over for "Over"
        /// </summary>
        [EnumMember(Value = "Over")]
        Over,

        /// <summary>
        /// Enum Under for "Under"
        /// </summary>
        [EnumMember(Value = "Under")]
        Under
    }
    /// <summary>
    /// Gets or Sets DurationTarget
    /// </summary>
    [DataMember(Name = "durationTarget", EmitDefaultValue = false)]
    public DurationTargetEnum? DurationTarget { get; set; }
    /// <summary>
    /// Gets or Sets DurationMode
    /// </summary>
    [DataMember(Name = "durationMode", EmitDefaultValue = false)]
    public DurationModeEnum? DurationMode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DurationCondition" /> class.
    /// </summary>
    /// <param name="DurationTarget">DurationTarget.</param>
    /// <param name="DurationOperator">DurationOperator.</param>
    /// <param name="DurationRange">DurationRange.</param>
    /// <param name="DurationMode">DurationMode.</param>
    public DurationCondition(DurationTargetEnum? DurationTarget = null, string DurationOperator = null, string DurationRange = null, DurationModeEnum? DurationMode = null)
    {
        this.DurationTarget = DurationTarget;
        this.DurationOperator = DurationOperator;
        this.DurationRange = DurationRange;
        this.DurationMode = DurationMode;

    }





    /// <summary>
    /// Gets or Sets DurationOperator
    /// </summary>
    [DataMember(Name = "durationOperator", EmitDefaultValue = false)]
    public string DurationOperator { get; set; }



    /// <summary>
    /// Gets or Sets DurationRange
    /// </summary>
    [DataMember(Name = "durationRange", EmitDefaultValue = false)]
    public string DurationRange { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DurationCondition {\n");

        sb.Append("  DurationTarget: ").Append(DurationTarget).Append("\n");
        sb.Append("  DurationOperator: ").Append(DurationOperator).Append("\n");
        sb.Append("  DurationRange: ").Append(DurationRange).Append("\n");
        sb.Append("  DurationMode: ").Append(DurationMode).Append("\n");
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
        return Equals(obj as DurationCondition);
    }

    /// <summary>
    /// Returns true if DurationCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of DurationCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DurationCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DurationTarget == other.DurationTarget ||
                DurationTarget != null &&
                DurationTarget.Equals(other.DurationTarget)
            ) &&
            (
                DurationOperator == other.DurationOperator ||
                DurationOperator != null &&
                DurationOperator.Equals(other.DurationOperator)
            ) &&
            (
                DurationRange == other.DurationRange ||
                DurationRange != null &&
                DurationRange.Equals(other.DurationRange)
            ) &&
            (
                DurationMode == other.DurationMode ||
                DurationMode != null &&
                DurationMode.Equals(other.DurationMode)
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
            if (DurationTarget != null)
            {
                hash = hash * 59 + DurationTarget.GetHashCode();
            }

            if (DurationOperator != null)
            {
                hash = hash * 59 + DurationOperator.GetHashCode();
            }

            if (DurationRange != null)
            {
                hash = hash * 59 + DurationRange.GetHashCode();
            }

            if (DurationMode != null)
            {
                hash = hash * 59 + DurationMode.GetHashCode();
            }

            return hash;
        }
    }
}
