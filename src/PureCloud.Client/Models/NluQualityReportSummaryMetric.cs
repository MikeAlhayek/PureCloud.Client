using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluQualityReportSummaryMetric
/// </summary>

public partial class NluQualityReportSummaryMetric : IEquatable<NluQualityReportSummaryMetric>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluQualityReportSummaryMetric" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluQualityReportSummaryMetric() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluQualityReportSummaryMetric" /> class.
    /// </summary>
    /// <param name="Name">The name of the metric. e.g. recall, f1_score (required).</param>
    /// <param name="Value">The value of the metric (required).</param>
    public NluQualityReportSummaryMetric(string Name = null, float? Value = null)
    {
        this.Name = Name;
        this.Value = Value;

    }



    /// <summary>
    /// The name of the metric. e.g. recall, f1_score
    /// </summary>
    /// <value>The name of the metric. e.g. recall, f1_score</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The value of the metric
    /// </summary>
    /// <value>The value of the metric</value>
    [JsonPropertyName("value")]
    public float? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluQualityReportSummaryMetric {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as NluQualityReportSummaryMetric);
    }

    /// <summary>
    /// Returns true if NluQualityReportSummaryMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of NluQualityReportSummaryMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluQualityReportSummaryMetric other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
