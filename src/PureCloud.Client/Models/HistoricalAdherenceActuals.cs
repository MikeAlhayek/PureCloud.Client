using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalAdherenceActuals
/// </summary>

public partial class HistoricalAdherenceActuals : IEquatable<HistoricalAdherenceActuals>
{
    /// <summary>
    /// Activity in which the user is actually engaged
    /// </summary>
    /// <value>Activity in which the user is actually engaged</value>
    
    public enum ActualActivityCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }
    /// <summary>
    /// Activity in which the user is actually engaged
    /// </summary>
    /// <value>Activity in which the user is actually engaged</value>
    [JsonPropertyName("actualActivityCategory")]
    public ActualActivityCategoryEnum? ActualActivityCategory { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalAdherenceActuals" /> class.
    /// </summary>
    /// <param name="ActualActivityCategory">Activity in which the user is actually engaged.</param>
    /// <param name="ActualSecondaryPresenceLookupId">The lookup ID used to retrieve the actual secondary status from map of lookup ID to corresponding secondary presence ID.</param>
    /// <param name="StartOffsetSeconds">Actual start offset in seconds relative to query start time.</param>
    /// <param name="EndOffsetSeconds">Actual end offset in seconds relative to query start time.</param>
    public HistoricalAdherenceActuals(ActualActivityCategoryEnum? ActualActivityCategory = null, string ActualSecondaryPresenceLookupId = null, int? StartOffsetSeconds = null, int? EndOffsetSeconds = null)
    {
        this.ActualActivityCategory = ActualActivityCategory;
        this.ActualSecondaryPresenceLookupId = ActualSecondaryPresenceLookupId;
        this.StartOffsetSeconds = StartOffsetSeconds;
        this.EndOffsetSeconds = EndOffsetSeconds;

    }





    /// <summary>
    /// The lookup ID used to retrieve the actual secondary status from map of lookup ID to corresponding secondary presence ID
    /// </summary>
    /// <value>The lookup ID used to retrieve the actual secondary status from map of lookup ID to corresponding secondary presence ID</value>
    [JsonPropertyName("actualSecondaryPresenceLookupId")]
    public string ActualSecondaryPresenceLookupId { get; set; }



    /// <summary>
    /// Actual start offset in seconds relative to query start time
    /// </summary>
    /// <value>Actual start offset in seconds relative to query start time</value>
    [JsonPropertyName("startOffsetSeconds")]
    public int? StartOffsetSeconds { get; set; }



    /// <summary>
    /// Actual end offset in seconds relative to query start time
    /// </summary>
    /// <value>Actual end offset in seconds relative to query start time</value>
    [JsonPropertyName("endOffsetSeconds")]
    public int? EndOffsetSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalAdherenceActuals {\n");

        sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
        sb.Append("  ActualSecondaryPresenceLookupId: ").Append(ActualSecondaryPresenceLookupId).Append("\n");
        sb.Append("  StartOffsetSeconds: ").Append(StartOffsetSeconds).Append("\n");
        sb.Append("  EndOffsetSeconds: ").Append(EndOffsetSeconds).Append("\n");
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
        return Equals(obj as HistoricalAdherenceActuals);
    }

    /// <summary>
    /// Returns true if HistoricalAdherenceActuals instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalAdherenceActuals to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalAdherenceActuals other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActualActivityCategory == other.ActualActivityCategory ||
                ActualActivityCategory != null &&
                ActualActivityCategory.Equals(other.ActualActivityCategory)
            ) &&
            (
                ActualSecondaryPresenceLookupId == other.ActualSecondaryPresenceLookupId ||
                ActualSecondaryPresenceLookupId != null &&
                ActualSecondaryPresenceLookupId.Equals(other.ActualSecondaryPresenceLookupId)
            ) &&
            (
                StartOffsetSeconds == other.StartOffsetSeconds ||
                StartOffsetSeconds != null &&
                StartOffsetSeconds.Equals(other.StartOffsetSeconds)
            ) &&
            (
                EndOffsetSeconds == other.EndOffsetSeconds ||
                EndOffsetSeconds != null &&
                EndOffsetSeconds.Equals(other.EndOffsetSeconds)
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
            if (ActualActivityCategory != null)
            {
                hash = hash * 59 + ActualActivityCategory.GetHashCode();
            }

            if (ActualSecondaryPresenceLookupId != null)
            {
                hash = hash * 59 + ActualSecondaryPresenceLookupId.GetHashCode();
            }

            if (StartOffsetSeconds != null)
            {
                hash = hash * 59 + StartOffsetSeconds.GetHashCode();
            }

            if (EndOffsetSeconds != null)
            {
                hash = hash * 59 + EndOffsetSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
