using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification
/// </summary>
[DataContract]
public partial class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification : IEquatable<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification" /> class.
    /// </summary>
    /// <param name="BusinessUnitId">BusinessUnitId.</param>
    /// <param name="State">State.</param>
    /// <param name="Forecast">Forecast.</param>
    /// <param name="WeekCount">WeekCount.</param>
    /// <param name="IntervalLengthMinutes">IntervalLengthMinutes.</param>
    /// <param name="ReferenceStartDate">ReferenceStartDate.</param>
    /// <param name="Results">Results.</param>
    public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification(string BusinessUnitId = null, StateEnum? State = null, WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference Forecast = null, long? WeekCount = null, long? IntervalLengthMinutes = null, DateTime? ReferenceStartDate = null, List<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults> Results = null)
    {
        this.BusinessUnitId = BusinessUnitId;
        this.State = State;
        this.Forecast = Forecast;
        this.WeekCount = WeekCount;
        this.IntervalLengthMinutes = IntervalLengthMinutes;
        this.ReferenceStartDate = ReferenceStartDate;
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets BusinessUnitId
    /// </summary>
    [DataMember(Name = "businessUnitId", EmitDefaultValue = false)]
    public string BusinessUnitId { get; set; }





    /// <summary>
    /// Gets or Sets Forecast
    /// </summary>
    [DataMember(Name = "forecast", EmitDefaultValue = false)]
    public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference Forecast { get; set; }



    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    [DataMember(Name = "weekCount", EmitDefaultValue = false)]
    public long? WeekCount { get; set; }



    /// <summary>
    /// Gets or Sets IntervalLengthMinutes
    /// </summary>
    [DataMember(Name = "intervalLengthMinutes", EmitDefaultValue = false)]
    public long? IntervalLengthMinutes { get; set; }



    /// <summary>
    /// Gets or Sets ReferenceStartDate
    /// </summary>
    [DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
    public DateTime? ReferenceStartDate { get; set; }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification {\n");

        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Forecast: ").Append(Forecast).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BusinessUnitId == other.BusinessUnitId ||
                BusinessUnitId != null &&
                BusinessUnitId.Equals(other.BusinessUnitId)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Forecast == other.Forecast ||
                Forecast != null &&
                Forecast.Equals(other.Forecast)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                IntervalLengthMinutes == other.IntervalLengthMinutes ||
                IntervalLengthMinutes != null &&
                IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
            ) &&
            (
                ReferenceStartDate == other.ReferenceStartDate ||
                ReferenceStartDate != null &&
                ReferenceStartDate.Equals(other.ReferenceStartDate)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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
            if (BusinessUnitId != null)
            {
                hash = hash * 59 + BusinessUnitId.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Forecast != null)
            {
                hash = hash * 59 + Forecast.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (IntervalLengthMinutes != null)
            {
                hash = hash * 59 + IntervalLengthMinutes.GetHashCode();
            }

            if (ReferenceStartDate != null)
            {
                hash = hash * 59 + ReferenceStartDate.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
