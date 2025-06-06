using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Flow Outcome data related to a bot flow which is exiting gracefully.
/// </summary>

public partial class TextBotFlowOutcome : IEquatable<TextBotFlowOutcome>
{
    /// <summary>
    /// The value of the FlowOutcome.
    /// </summary>
    /// <value>The value of the FlowOutcome.</value>
    
    public enum OutcomeValueEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Success for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// Enum Failure for "FAILURE"
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure
    }
    /// <summary>
    /// The value of the FlowOutcome.
    /// </summary>
    /// <value>The value of the FlowOutcome.</value>
    [JsonPropertyName("outcomeValue")]
    public OutcomeValueEnum? OutcomeValue { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowOutcome" /> class.
    /// </summary>
    /// <param name="OutcomeId">The Flow Outcome ID..</param>
    /// <param name="OutcomeValue">The value of the FlowOutcome..</param>
    /// <param name="DateStart">The timestamp for when the Flow Outcome began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateEnd">The timestamp for when the Flow Outcome finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Milestones">The Flow Milestones for the Flow Outcome..</param>
    public TextBotFlowOutcome(string OutcomeId = null, OutcomeValueEnum? OutcomeValue = null, DateTime? DateStart = null, DateTime? DateEnd = null, List<TextBotFlowMilestone> Milestones = null)
    {
        this.OutcomeId = OutcomeId;
        this.OutcomeValue = OutcomeValue;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.Milestones = Milestones;

    }



    /// <summary>
    /// The Flow Outcome ID.
    /// </summary>
    /// <value>The Flow Outcome ID.</value>
    [JsonPropertyName("outcomeId")]
    public string OutcomeId { get; set; }





    /// <summary>
    /// The timestamp for when the Flow Outcome began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp for when the Flow Outcome began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// The timestamp for when the Flow Outcome finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp for when the Flow Outcome finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateEnd")]
    public DateTime? DateEnd { get; set; }



    /// <summary>
    /// The Flow Milestones for the Flow Outcome.
    /// </summary>
    /// <value>The Flow Milestones for the Flow Outcome.</value>
    [JsonPropertyName("milestones")]
    public List<TextBotFlowMilestone> Milestones { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotFlowOutcome {\n");

        sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
        sb.Append("  OutcomeValue: ").Append(OutcomeValue).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Milestones: ").Append(Milestones).Append("\n");
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
        return Equals(obj as TextBotFlowOutcome);
    }

    /// <summary>
    /// Returns true if TextBotFlowOutcome instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotFlowOutcome to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotFlowOutcome other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OutcomeId == other.OutcomeId ||
                OutcomeId != null &&
                OutcomeId.Equals(other.OutcomeId)
            ) &&
            (
                OutcomeValue == other.OutcomeValue ||
                OutcomeValue != null &&
                OutcomeValue.Equals(other.OutcomeValue)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Milestones == other.Milestones ||
                Milestones != null &&
                Milestones.SequenceEqual(other.Milestones)
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
            if (OutcomeId != null)
            {
                hash = hash * 59 + OutcomeId.GetHashCode();
            }

            if (OutcomeValue != null)
            {
                hash = hash * 59 + OutcomeValue.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Milestones != null)
            {
                hash = hash * 59 + Milestones.GetHashCode();
            }

            return hash;
        }
    }
}
