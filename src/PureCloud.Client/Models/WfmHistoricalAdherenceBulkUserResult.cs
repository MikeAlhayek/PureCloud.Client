using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceBulkUserResult
/// </summary>

public partial class WfmHistoricalAdherenceBulkUserResult : IEquatable<WfmHistoricalAdherenceBulkUserResult>
{
    /// <summary>
    /// The impact of the current adherence state for this user
    /// </summary>
    /// <value>The impact of the current adherence state for this user</value>
    
    public enum ImpactEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative,

        /// <summary>
        /// Enum Neutral for "Neutral"
        /// </summary>
        [EnumMember(Value = "Neutral")]
        Neutral,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The impact of the current adherence state for this user
    /// </summary>
    /// <value>The impact of the current adherence state for this user</value>
    [JsonPropertyName("impact")]
    public ImpactEnum? Impact { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkUserResult" /> class.
    /// </summary>
    /// <param name="UserId">The ID of the user for whom the adherence is queried.</param>
    /// <param name="AdherencePercentage">Adherence percentage for this user, in the scale of 0 - 100.</param>
    /// <param name="ConformancePercentage">Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period..</param>
    /// <param name="Impact">The impact of the current adherence state for this user.</param>
    /// <param name="ExceptionInfo">List of adherence exceptions for this user.</param>
    /// <param name="Actuals">List of adherence actuals for this user.</param>
    /// <param name="DayMetrics">Adherence and conformance metrics for days in query range.</param>
    public WfmHistoricalAdherenceBulkUserResult(string UserId = null, double? AdherencePercentage = null, double? ConformancePercentage = null, ImpactEnum? Impact = null, List<HistoricalAdherenceExceptionInfo> ExceptionInfo = null, List<HistoricalAdherenceActuals> Actuals = null, List<WfmHistoricalAdherenceBulkUserDayMetrics> DayMetrics = null)
    {
        this.UserId = UserId;
        this.AdherencePercentage = AdherencePercentage;
        this.ConformancePercentage = ConformancePercentage;
        this.Impact = Impact;
        this.ExceptionInfo = ExceptionInfo;
        this.Actuals = Actuals;
        this.DayMetrics = DayMetrics;

    }



    /// <summary>
    /// The ID of the user for whom the adherence is queried
    /// </summary>
    /// <value>The ID of the user for whom the adherence is queried</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// Adherence percentage for this user, in the scale of 0 - 100
    /// </summary>
    /// <value>Adherence percentage for this user, in the scale of 0 - 100</value>
    [JsonPropertyName("adherencePercentage")]
    public double? AdherencePercentage { get; set; }



    /// <summary>
    /// Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.
    /// </summary>
    /// <value>Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.</value>
    [JsonPropertyName("conformancePercentage")]
    public double? ConformancePercentage { get; set; }





    /// <summary>
    /// List of adherence exceptions for this user
    /// </summary>
    /// <value>List of adherence exceptions for this user</value>
    [JsonPropertyName("exceptionInfo")]
    public List<HistoricalAdherenceExceptionInfo> ExceptionInfo { get; set; }



    /// <summary>
    /// List of adherence actuals for this user
    /// </summary>
    /// <value>List of adherence actuals for this user</value>
    [JsonPropertyName("actuals")]
    public List<HistoricalAdherenceActuals> Actuals { get; set; }



    /// <summary>
    /// Adherence and conformance metrics for days in query range
    /// </summary>
    /// <value>Adherence and conformance metrics for days in query range</value>
    [JsonPropertyName("dayMetrics")]
    public List<WfmHistoricalAdherenceBulkUserDayMetrics> DayMetrics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceBulkUserResult {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  AdherencePercentage: ").Append(AdherencePercentage).Append("\n");
        sb.Append("  ConformancePercentage: ").Append(ConformancePercentage).Append("\n");
        sb.Append("  Impact: ").Append(Impact).Append("\n");
        sb.Append("  ExceptionInfo: ").Append(ExceptionInfo).Append("\n");
        sb.Append("  Actuals: ").Append(Actuals).Append("\n");
        sb.Append("  DayMetrics: ").Append(DayMetrics).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceBulkUserResult);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceBulkUserResult instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceBulkUserResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceBulkUserResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                AdherencePercentage == other.AdherencePercentage ||
                AdherencePercentage != null &&
                AdherencePercentage.Equals(other.AdherencePercentage)
            ) &&
            (
                ConformancePercentage == other.ConformancePercentage ||
                ConformancePercentage != null &&
                ConformancePercentage.Equals(other.ConformancePercentage)
            ) &&
            (
                Impact == other.Impact ||
                Impact != null &&
                Impact.Equals(other.Impact)
            ) &&
            (
                ExceptionInfo == other.ExceptionInfo ||
                ExceptionInfo != null &&
                ExceptionInfo.SequenceEqual(other.ExceptionInfo)
            ) &&
            (
                Actuals == other.Actuals ||
                Actuals != null &&
                Actuals.SequenceEqual(other.Actuals)
            ) &&
            (
                DayMetrics == other.DayMetrics ||
                DayMetrics != null &&
                DayMetrics.SequenceEqual(other.DayMetrics)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (AdherencePercentage != null)
            {
                hash = hash * 59 + AdherencePercentage.GetHashCode();
            }

            if (ConformancePercentage != null)
            {
                hash = hash * 59 + ConformancePercentage.GetHashCode();
            }

            if (Impact != null)
            {
                hash = hash * 59 + Impact.GetHashCode();
            }

            if (ExceptionInfo != null)
            {
                hash = hash * 59 + ExceptionInfo.GetHashCode();
            }

            if (Actuals != null)
            {
                hash = hash * 59 + Actuals.GetHashCode();
            }

            if (DayMetrics != null)
            {
                hash = hash * 59 + DayMetrics.GetHashCode();
            }

            return hash;
        }
    }
}
