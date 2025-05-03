using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SessionMetaDataResult
/// </summary>

public partial class SessionMetaDataResult : IEquatable<SessionMetaDataResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionMetaDataResult" /> class.
    /// </summary>
    /// <param name="SessionInfo">Information about the continuous forecast session.</param>
    /// <param name="Snapshots">Captured snapshots.</param>
    /// <param name="DateForecastStart">Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateHistoricalStart">Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AggregateOfferedHistoricalAvailability">Total historical availability for offered metric across all planning groups.</param>
    /// <param name="AggregateAverageHandleTimeHistoricalAvailability">Total historical availability for average handle time metric across all planning groups.</param>
    public SessionMetaDataResult(SessionInfo SessionInfo = null, List<Snapshots> Snapshots = null, DateTime? DateForecastStart = null, DateTime? DateHistoricalStart = null, AggregateHistoricalAvailability AggregateOfferedHistoricalAvailability = null, AggregateHistoricalAvailability AggregateAverageHandleTimeHistoricalAvailability = null)
    {
        this.SessionInfo = SessionInfo;
        this.Snapshots = Snapshots;
        this.DateForecastStart = DateForecastStart;
        this.DateHistoricalStart = DateHistoricalStart;
        this.AggregateOfferedHistoricalAvailability = AggregateOfferedHistoricalAvailability;
        this.AggregateAverageHandleTimeHistoricalAvailability = AggregateAverageHandleTimeHistoricalAvailability;

    }



    /// <summary>
    /// Information about the continuous forecast session
    /// </summary>
    /// <value>Information about the continuous forecast session</value>
    [JsonPropertyName("sessionInfo")]
    public SessionInfo SessionInfo { get; set; }



    /// <summary>
    /// Captured snapshots
    /// </summary>
    /// <value>Captured snapshots</value>
    [JsonPropertyName("snapshots")]
    public List<Snapshots> Snapshots { get; set; }



    /// <summary>
    /// Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateForecastStart")]
    public DateTime? DateForecastStart { get; set; }



    /// <summary>
    /// Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateHistoricalStart")]
    public DateTime? DateHistoricalStart { get; set; }



    /// <summary>
    /// Total historical availability for offered metric across all planning groups
    /// </summary>
    /// <value>Total historical availability for offered metric across all planning groups</value>
    [JsonPropertyName("aggregateOfferedHistoricalAvailability")]
    public AggregateHistoricalAvailability AggregateOfferedHistoricalAvailability { get; set; }



    /// <summary>
    /// Total historical availability for average handle time metric across all planning groups
    /// </summary>
    /// <value>Total historical availability for average handle time metric across all planning groups</value>
    [JsonPropertyName("aggregateAverageHandleTimeHistoricalAvailability")]
    public AggregateHistoricalAvailability AggregateAverageHandleTimeHistoricalAvailability { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SessionMetaDataResult {\n");

        sb.Append("  SessionInfo: ").Append(SessionInfo).Append("\n");
        sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
        sb.Append("  DateForecastStart: ").Append(DateForecastStart).Append("\n");
        sb.Append("  DateHistoricalStart: ").Append(DateHistoricalStart).Append("\n");
        sb.Append("  AggregateOfferedHistoricalAvailability: ").Append(AggregateOfferedHistoricalAvailability).Append("\n");
        sb.Append("  AggregateAverageHandleTimeHistoricalAvailability: ").Append(AggregateAverageHandleTimeHistoricalAvailability).Append("\n");
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
        return Equals(obj as SessionMetaDataResult);
    }

    /// <summary>
    /// Returns true if SessionMetaDataResult instances are equal
    /// </summary>
    /// <param name="other">Instance of SessionMetaDataResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SessionMetaDataResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SessionInfo == other.SessionInfo ||
                SessionInfo != null &&
                SessionInfo.Equals(other.SessionInfo)
            ) &&
            (
                Snapshots == other.Snapshots ||
                Snapshots != null &&
                Snapshots.SequenceEqual(other.Snapshots)
            ) &&
            (
                DateForecastStart == other.DateForecastStart ||
                DateForecastStart != null &&
                DateForecastStart.Equals(other.DateForecastStart)
            ) &&
            (
                DateHistoricalStart == other.DateHistoricalStart ||
                DateHistoricalStart != null &&
                DateHistoricalStart.Equals(other.DateHistoricalStart)
            ) &&
            (
                AggregateOfferedHistoricalAvailability == other.AggregateOfferedHistoricalAvailability ||
                AggregateOfferedHistoricalAvailability != null &&
                AggregateOfferedHistoricalAvailability.Equals(other.AggregateOfferedHistoricalAvailability)
            ) &&
            (
                AggregateAverageHandleTimeHistoricalAvailability == other.AggregateAverageHandleTimeHistoricalAvailability ||
                AggregateAverageHandleTimeHistoricalAvailability != null &&
                AggregateAverageHandleTimeHistoricalAvailability.Equals(other.AggregateAverageHandleTimeHistoricalAvailability)
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
            if (SessionInfo != null)
            {
                hash = hash * 59 + SessionInfo.GetHashCode();
            }

            if (Snapshots != null)
            {
                hash = hash * 59 + Snapshots.GetHashCode();
            }

            if (DateForecastStart != null)
            {
                hash = hash * 59 + DateForecastStart.GetHashCode();
            }

            if (DateHistoricalStart != null)
            {
                hash = hash * 59 + DateHistoricalStart.GetHashCode();
            }

            if (AggregateOfferedHistoricalAvailability != null)
            {
                hash = hash * 59 + AggregateOfferedHistoricalAvailability.GetHashCode();
            }

            if (AggregateAverageHandleTimeHistoricalAvailability != null)
            {
                hash = hash * 59 + AggregateAverageHandleTimeHistoricalAvailability.GetHashCode();
            }

            return hash;
        }
    }
}
