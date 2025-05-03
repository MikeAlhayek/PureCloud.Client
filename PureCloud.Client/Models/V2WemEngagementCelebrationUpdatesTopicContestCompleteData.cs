using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WemEngagementCelebrationUpdatesTopicContestCompleteData
/// </summary>

public partial class V2WemEngagementCelebrationUpdatesTopicContestCompleteData : IEquatable<V2WemEngagementCelebrationUpdatesTopicContestCompleteData>
{
    /// <summary>
    /// Gets or Sets Anonymization
    /// </summary>
    
    public enum AnonymizationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum NoAnonymization for "NO_ANONYMIZATION"
        /// </summary>
        [EnumMember(Value = "NO_ANONYMIZATION")]
        NoAnonymization,

        /// <summary>
        /// Enum All for "ALL"
        /// </summary>
        [EnumMember(Value = "ALL")]
        All,

        /// <summary>
        /// Enum AllExceptTop for "ALL_EXCEPT_TOP"
        /// </summary>
        [EnumMember(Value = "ALL_EXCEPT_TOP")]
        AllExceptTop
    }
    /// <summary>
    /// Gets or Sets Anonymization
    /// </summary>
    [JsonPropertyName("anonymization")]
    public AnonymizationEnum? Anonymization { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestCompleteData" /> class.
    /// </summary>
    /// <param name="DateEnd">DateEnd.</param>
    /// <param name="Anonymization">Anonymization.</param>
    /// <param name="Metrics">Metrics.</param>
    /// <param name="Prizes">Prizes.</param>
    /// <param name="Winners">Winners.</param>
    public V2WemEngagementCelebrationUpdatesTopicContestCompleteData(string DateEnd = null, AnonymizationEnum? Anonymization = null, List<V2WemEngagementCelebrationUpdatesTopicContestMetrics> Metrics = null, List<V2WemEngagementCelebrationUpdatesTopicContestPrizes> Prizes = null, List<V2WemEngagementCelebrationUpdatesTopicContestWinners> Winners = null)
    {
        this.DateEnd = DateEnd;
        this.Anonymization = Anonymization;
        this.Metrics = Metrics;
        this.Prizes = Prizes;
        this.Winners = Winners;

    }



    /// <summary>
    /// Gets or Sets DateEnd
    /// </summary>
    [JsonPropertyName("dateEnd")]
    public string DateEnd { get; set; }





    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [JsonPropertyName("metrics")]
    public List<V2WemEngagementCelebrationUpdatesTopicContestMetrics> Metrics { get; set; }



    /// <summary>
    /// Gets or Sets Prizes
    /// </summary>
    [JsonPropertyName("prizes")]
    public List<V2WemEngagementCelebrationUpdatesTopicContestPrizes> Prizes { get; set; }



    /// <summary>
    /// Gets or Sets Winners
    /// </summary>
    [JsonPropertyName("winners")]
    public List<V2WemEngagementCelebrationUpdatesTopicContestWinners> Winners { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestCompleteData {\n");

        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Anonymization: ").Append(Anonymization).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  Prizes: ").Append(Prizes).Append("\n");
        sb.Append("  Winners: ").Append(Winners).Append("\n");
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
        return Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestCompleteData);
    }

    /// <summary>
    /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestCompleteData instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestCompleteData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestCompleteData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Anonymization == other.Anonymization ||
                Anonymization != null &&
                Anonymization.Equals(other.Anonymization)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                Prizes == other.Prizes ||
                Prizes != null &&
                Prizes.SequenceEqual(other.Prizes)
            ) &&
            (
                Winners == other.Winners ||
                Winners != null &&
                Winners.SequenceEqual(other.Winners)
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
            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Anonymization != null)
            {
                hash = hash * 59 + Anonymization.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (Prizes != null)
            {
                hash = hash * 59 + Prizes.GetHashCode();
            }

            if (Winners != null)
            {
                hash = hash * 59 + Winners.GetHashCode();
            }

            return hash;
        }
    }
}
