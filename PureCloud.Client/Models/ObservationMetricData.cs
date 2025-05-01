using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ObservationMetricData
/// </summary>
[DataContract]
public partial class ObservationMetricData : IEquatable<ObservationMetricData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ObservationMetricData" /> class.
    /// </summary>
    /// <param name="Metric">Metric.</param>
    /// <param name="Qualifier">Qualifier.</param>
    /// <param name="Stats">Stats.</param>
    /// <param name="Truncated">Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations..</param>
    /// <param name="Observations">List of observations sorted by timestamp in ascending order. This list may be truncated..</param>
    public ObservationMetricData(string Metric = null, string Qualifier = null, StatisticalSummary Stats = null, bool? Truncated = null, List<ObservationValue> Observations = null)
    {
        this.Metric = Metric;
        this.Qualifier = Qualifier;
        this.Stats = Stats;
        this.Truncated = Truncated;
        this.Observations = Observations;

    }



    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public string Metric { get; set; }



    /// <summary>
    /// Gets or Sets Qualifier
    /// </summary>
    [DataMember(Name = "qualifier", EmitDefaultValue = false)]
    public string Qualifier { get; set; }



    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [DataMember(Name = "stats", EmitDefaultValue = false)]
    public StatisticalSummary Stats { get; set; }



    /// <summary>
    /// Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations.
    /// </summary>
    /// <value>Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations.</value>
    [DataMember(Name = "truncated", EmitDefaultValue = false)]
    public bool? Truncated { get; set; }



    /// <summary>
    /// List of observations sorted by timestamp in ascending order. This list may be truncated.
    /// </summary>
    /// <value>List of observations sorted by timestamp in ascending order. This list may be truncated.</value>
    [DataMember(Name = "observations", EmitDefaultValue = false)]
    public List<ObservationValue> Observations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ObservationMetricData {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
        sb.Append("  Stats: ").Append(Stats).Append("\n");
        sb.Append("  Truncated: ").Append(Truncated).Append("\n");
        sb.Append("  Observations: ").Append(Observations).Append("\n");
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
        return Equals(obj as ObservationMetricData);
    }

    /// <summary>
    /// Returns true if ObservationMetricData instances are equal
    /// </summary>
    /// <param name="other">Instance of ObservationMetricData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ObservationMetricData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                Qualifier == other.Qualifier ||
                Qualifier != null &&
                Qualifier.Equals(other.Qualifier)
            ) &&
            (
                Stats == other.Stats ||
                Stats != null &&
                Stats.Equals(other.Stats)
            ) &&
            (
                Truncated == other.Truncated ||
                Truncated != null &&
                Truncated.Equals(other.Truncated)
            ) &&
            (
                Observations == other.Observations ||
                Observations != null &&
                Observations.SequenceEqual(other.Observations)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (Qualifier != null)
            {
                hash = hash * 59 + Qualifier.GetHashCode();
            }

            if (Stats != null)
            {
                hash = hash * 59 + Stats.GetHashCode();
            }

            if (Truncated != null)
            {
                hash = hash * 59 + Truncated.GetHashCode();
            }

            if (Observations != null)
            {
                hash = hash * 59 + Observations.GetHashCode();
            }

            return hash;
        }
    }
}
