using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuForecastStaffingRequirementsResultResponse
/// </summary>

public partial class BuForecastStaffingRequirementsResultResponse : IEquatable<BuForecastStaffingRequirementsResultResponse>
{
    /// <summary>
    /// The state of the staffing requirements generation
    /// </summary>
    /// <value>The state of the staffing requirements generation</value>
    
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
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The state of the staffing requirements generation
    /// </summary>
    /// <value>The state of the staffing requirements generation</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastStaffingRequirementsResultResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuForecastStaffingRequirementsResultResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastStaffingRequirementsResultResponse" /> class.
    /// </summary>
    /// <param name="BusinessUnitId">The ID of the business unit to which the forecast staffing requirements belongs (required).</param>
    /// <param name="Forecast">The forecast reference (required).</param>
    /// <param name="ReferenceStartDate">The reference start date for interval-based data for this forecast as an ISO-8601 string (required).</param>
    /// <param name="WeekCount">The number of weeks in this forecast (required).</param>
    /// <param name="IntervalLengthMinutes">The period/interval in minutes for which to aggregate the data (required).</param>
    /// <param name="State">The state of the staffing requirements generation (required).</param>
    /// <param name="Results">The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39;.</param>
    public BuForecastStaffingRequirementsResultResponse(string BusinessUnitId = null, BuShortTermForecastReference Forecast = null, DateTime? ReferenceStartDate = null, int? WeekCount = null, int? IntervalLengthMinutes = null, StateEnum? State = null, List<BuForecastStaffingRequirementsResult> Results = null)
    {
        this.BusinessUnitId = BusinessUnitId;
        this.Forecast = Forecast;
        this.ReferenceStartDate = ReferenceStartDate;
        this.WeekCount = WeekCount;
        this.IntervalLengthMinutes = IntervalLengthMinutes;
        this.State = State;
        this.Results = Results;

    }



    /// <summary>
    /// The ID of the business unit to which the forecast staffing requirements belongs
    /// </summary>
    /// <value>The ID of the business unit to which the forecast staffing requirements belongs</value>
    [JsonPropertyName("businessUnitId")]
    public string BusinessUnitId { get; set; }



    /// <summary>
    /// The forecast reference
    /// </summary>
    /// <value>The forecast reference</value>
    [JsonPropertyName("forecast")]
    public BuShortTermForecastReference Forecast { get; set; }



    /// <summary>
    /// The reference start date for interval-based data for this forecast as an ISO-8601 string
    /// </summary>
    /// <value>The reference start date for interval-based data for this forecast as an ISO-8601 string</value>
    [JsonPropertyName("referenceStartDate")]
    public DateTime? ReferenceStartDate { get; set; }



    /// <summary>
    /// The number of weeks in this forecast
    /// </summary>
    /// <value>The number of weeks in this forecast</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }



    /// <summary>
    /// The period/interval in minutes for which to aggregate the data
    /// </summary>
    /// <value>The period/interval in minutes for which to aggregate the data</value>
    [JsonPropertyName("intervalLengthMinutes")]
    public int? IntervalLengthMinutes { get; set; }





    /// <summary>
    /// The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39;
    /// </summary>
    /// <value>The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39;</value>
    [JsonPropertyName("results")]
    public List<BuForecastStaffingRequirementsResult> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuForecastStaffingRequirementsResultResponse {\n");

        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
        sb.Append("  Forecast: ").Append(Forecast).Append("\n");
        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as BuForecastStaffingRequirementsResultResponse);
    }

    /// <summary>
    /// Returns true if BuForecastStaffingRequirementsResultResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuForecastStaffingRequirementsResultResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuForecastStaffingRequirementsResultResponse other)
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
                Forecast == other.Forecast ||
                Forecast != null &&
                Forecast.Equals(other.Forecast)
            ) &&
            (
                ReferenceStartDate == other.ReferenceStartDate ||
                ReferenceStartDate != null &&
                ReferenceStartDate.Equals(other.ReferenceStartDate)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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

            if (Forecast != null)
            {
                hash = hash * 59 + Forecast.GetHashCode();
            }

            if (ReferenceStartDate != null)
            {
                hash = hash * 59 + ReferenceStartDate.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (IntervalLengthMinutes != null)
            {
                hash = hash * 59 + IntervalLengthMinutes.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
