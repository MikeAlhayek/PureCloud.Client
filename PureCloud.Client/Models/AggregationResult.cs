using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AggregationResult
/// </summary>

public partial class AggregationResult : IEquatable<AggregationResult>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Termfrequency for "termFrequency"
        /// </summary>
        [EnumMember(Value = "termFrequency")]
        Termfrequency,

        /// <summary>
        /// Enum Numericrange for "numericRange"
        /// </summary>
        [EnumMember(Value = "numericRange")]
        Numericrange
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AggregationResult" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="Dimension">For termFrequency aggregations.</param>
    /// <param name="Metric">For numericRange aggregations.</param>
    /// <param name="Count">Count.</param>
    /// <param name="Results">Results.</param>
    public AggregationResult(TypeEnum? Type = null, string Dimension = null, string Metric = null, long? Count = null, List<AggregationResultEntry> Results = null)
    {
        this.Type = Type;
        this.Dimension = Dimension;
        this.Metric = Metric;
        this.Count = Count;
        this.Results = Results;

    }





    /// <summary>
    /// For termFrequency aggregations
    /// </summary>
    /// <value>For termFrequency aggregations</value>
    [JsonPropertyName("dimension")]
    public string Dimension { get; set; }



    /// <summary>
    /// For numericRange aggregations
    /// </summary>
    /// <value>For numericRange aggregations</value>
    [JsonPropertyName("metric")]
    public string Metric { get; set; }



    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [JsonPropertyName("results")]
    public List<AggregationResultEntry> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AggregationResult {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as AggregationResult);
    }

    /// <summary>
    /// Returns true if AggregationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of AggregationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AggregationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Dimension == other.Dimension ||
                Dimension != null &&
                Dimension.Equals(other.Dimension)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Dimension != null)
            {
                hash = hash * 59 + Dimension.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
