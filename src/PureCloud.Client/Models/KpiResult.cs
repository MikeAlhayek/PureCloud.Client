using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KpiResult
/// </summary>

public partial class KpiResult : IEquatable<KpiResult>
{
    /// <summary>
    /// Media type used for the KPI
    /// </summary>
    /// <value>Media type used for the KPI</value>
    
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
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message
    }
    /// <summary>
    /// Media type used for the KPI
    /// </summary>
    /// <value>Media type used for the KPI</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KpiResult" /> class.
    /// </summary>
    public KpiResult()
    {

    }



    /// <summary>
    /// Absolute metric (in which the KPI is based) total for the interactions handled by predictive routing (GPR was on)
    /// </summary>
    /// <value>Absolute metric (in which the KPI is based) total for the interactions handled by predictive routing (GPR was on)</value>
    [JsonPropertyName("kpiTotalOn")]
    public long? KpiTotalOn { get; private set; }



    /// <summary>
    /// Absolute metric (in which the KPI is based) total for the interactions not routed by predictive routing (GPR was off)
    /// </summary>
    /// <value>Absolute metric (in which the KPI is based) total for the interactions not routed by predictive routing (GPR was off)</value>
    [JsonPropertyName("kpiTotalOff")]
    public long? KpiTotalOff { get; private set; }



    /// <summary>
    /// Total interactions handled by predictive routing (GPR was on)
    /// </summary>
    /// <value>Total interactions handled by predictive routing (GPR was on)</value>
    [JsonPropertyName("interactionCountOn")]
    public long? InteractionCountOn { get; private set; }



    /// <summary>
    /// Total interactions not routed by predictive routing (GPR was off)
    /// </summary>
    /// <value>Total interactions not routed by predictive routing (GPR was off)</value>
    [JsonPropertyName("interactionCountOff")]
    public long? InteractionCountOff { get; private set; }





    /// <summary>
    /// The percentage benefit for this media type for the duration of the comparison period
    /// </summary>
    /// <value>The percentage benefit for this media type for the duration of the comparison period</value>
    [JsonPropertyName("percentageBenefit")]
    public double? PercentageBenefit { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KpiResult {\n");

        sb.Append("  KpiTotalOn: ").Append(KpiTotalOn).Append("\n");
        sb.Append("  KpiTotalOff: ").Append(KpiTotalOff).Append("\n");
        sb.Append("  InteractionCountOn: ").Append(InteractionCountOn).Append("\n");
        sb.Append("  InteractionCountOff: ").Append(InteractionCountOff).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  PercentageBenefit: ").Append(PercentageBenefit).Append("\n");
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
        return Equals(obj as KpiResult);
    }

    /// <summary>
    /// Returns true if KpiResult instances are equal
    /// </summary>
    /// <param name="other">Instance of KpiResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KpiResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                KpiTotalOn == other.KpiTotalOn ||
                KpiTotalOn != null &&
                KpiTotalOn.Equals(other.KpiTotalOn)
            ) &&
            (
                KpiTotalOff == other.KpiTotalOff ||
                KpiTotalOff != null &&
                KpiTotalOff.Equals(other.KpiTotalOff)
            ) &&
            (
                InteractionCountOn == other.InteractionCountOn ||
                InteractionCountOn != null &&
                InteractionCountOn.Equals(other.InteractionCountOn)
            ) &&
            (
                InteractionCountOff == other.InteractionCountOff ||
                InteractionCountOff != null &&
                InteractionCountOff.Equals(other.InteractionCountOff)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                PercentageBenefit == other.PercentageBenefit ||
                PercentageBenefit != null &&
                PercentageBenefit.Equals(other.PercentageBenefit)
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
            if (KpiTotalOn != null)
            {
                hash = hash * 59 + KpiTotalOn.GetHashCode();
            }

            if (KpiTotalOff != null)
            {
                hash = hash * 59 + KpiTotalOff.GetHashCode();
            }

            if (InteractionCountOn != null)
            {
                hash = hash * 59 + InteractionCountOn.GetHashCode();
            }

            if (InteractionCountOff != null)
            {
                hash = hash * 59 + InteractionCountOff.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (PercentageBenefit != null)
            {
                hash = hash * 59 + PercentageBenefit.GetHashCode();
            }

            return hash;
        }
    }
}
