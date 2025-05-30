using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictorSchedule
/// </summary>

public partial class PredictorSchedule : IEquatable<PredictorSchedule>
{
    /// <summary>
    /// The predictor schedule type.
    /// </summary>
    /// <value>The predictor schedule type.</value>
    
    public enum ScheduleTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Houronhouroff for "HourOnHourOff"
        /// </summary>
        [EnumMember(Value = "HourOnHourOff")]
        Houronhouroff,

        /// <summary>
        /// Enum Ongoingvaluemonitoring for "OngoingValueMonitoring"
        /// </summary>
        [EnumMember(Value = "OngoingValueMonitoring")]
        Ongoingvaluemonitoring
    }
    /// <summary>
    /// The predictor schedule type.
    /// </summary>
    /// <value>The predictor schedule type.</value>
    [JsonPropertyName("scheduleType")]
    public ScheduleTypeEnum? ScheduleType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorSchedule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PredictorSchedule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorSchedule" /> class.
    /// </summary>
    /// <param name="ScheduleType">The predictor schedule type. (required).</param>
    public PredictorSchedule(ScheduleTypeEnum? ScheduleType = null)
    {
        this.ScheduleType = ScheduleType;

    }





    /// <summary>
    /// DateTime indicating when the predictor schedule was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the predictor schedule was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorSchedule {\n");

        sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
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
        return Equals(obj as PredictorSchedule);
    }

    /// <summary>
    /// Returns true if PredictorSchedule instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorSchedule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorSchedule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ScheduleType == other.ScheduleType ||
                ScheduleType != null &&
                ScheduleType.Equals(other.ScheduleType)
            ) &&
            (
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
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
            if (ScheduleType != null)
            {
                hash = hash * 59 + ScheduleType.GetHashCode();
            }

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            return hash;
        }
    }
}
