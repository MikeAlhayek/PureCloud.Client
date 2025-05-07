using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ComparisonPeriod
/// </summary>

public partial class ComparisonPeriod : IEquatable<ComparisonPeriod>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ComparisonPeriod" /> class.
    /// </summary>
    public ComparisonPeriod()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Key Performance Indicator optimised during the comparison period.
    /// </summary>
    /// <value>Key Performance Indicator optimised during the comparison period.</value>
    [JsonPropertyName("kpi")]
    public string Kpi { get; set; }



    /// <summary>
    /// Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }



    /// <summary>
    /// End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateEnded")]
    public DateTime? DateEnded { get; set; }



    /// <summary>
    /// The percentage benefit on this queue for the duration of the comparison period
    /// </summary>
    /// <value>The percentage benefit on this queue for the duration of the comparison period</value>
    [JsonPropertyName("percentageBenefit")]
    public double? PercentageBenefit { get; set; }



    /// <summary>
    /// KPI results for each metric
    /// </summary>
    /// <value>KPI results for each metric</value>
    [JsonPropertyName("kpiResults")]
    public List<KpiResult> KpiResults { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ComparisonPeriod {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Kpi: ").Append(Kpi).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
        sb.Append("  DateEnded: ").Append(DateEnded).Append("\n");
        sb.Append("  PercentageBenefit: ").Append(PercentageBenefit).Append("\n");
        sb.Append("  KpiResults: ").Append(KpiResults).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ComparisonPeriod);
    }

    /// <summary>
    /// Returns true if ComparisonPeriod instances are equal
    /// </summary>
    /// <param name="other">Instance of ComparisonPeriod to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ComparisonPeriod other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Kpi == other.Kpi ||
                Kpi != null &&
                Kpi.Equals(other.Kpi)
            ) &&
            (
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
            ) &&
            (
                DateEnded == other.DateEnded ||
                DateEnded != null &&
                DateEnded.Equals(other.DateEnded)
            ) &&
            (
                PercentageBenefit == other.PercentageBenefit ||
                PercentageBenefit != null &&
                PercentageBenefit.Equals(other.PercentageBenefit)
            ) &&
            (
                KpiResults == other.KpiResults ||
                KpiResults != null &&
                KpiResults.SequenceEqual(other.KpiResults)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Kpi != null)
            {
                hash = hash * 59 + Kpi.GetHashCode();
            }

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            if (DateEnded != null)
            {
                hash = hash * 59 + DateEnded.GetHashCode();
            }

            if (PercentageBenefit != null)
            {
                hash = hash * 59 + PercentageBenefit.GetHashCode();
            }

            if (KpiResults != null)
            {
                hash = hash * 59 + KpiResults.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
