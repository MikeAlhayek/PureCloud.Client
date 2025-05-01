using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsQueryAggregation
/// </summary>
[DataContract]
public partial class AnalyticsQueryAggregation : IEquatable<AnalyticsQueryAggregation>
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsQueryAggregation" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Dimension">For use with termFrequency aggregations.</param>
    /// <param name="Metric">For use with numericRange aggregations.</param>
    /// <param name="Size">For use with termFrequency aggregations.</param>
    /// <param name="Ranges">For use with numericRange aggregations.</param>
    public AnalyticsQueryAggregation(TypeEnum? Type = null, string Dimension = null, string Metric = null, int? Size = null, List<AggregationRange> Ranges = null)
    {
        this.Type = Type;
        this.Dimension = Dimension;
        this.Metric = Metric;
        this.Size = Size;
        this.Ranges = Ranges;

    }





    /// <summary>
    /// For use with termFrequency aggregations
    /// </summary>
    /// <value>For use with termFrequency aggregations</value>
    [DataMember(Name = "dimension", EmitDefaultValue = false)]
    public string Dimension { get; set; }



    /// <summary>
    /// For use with numericRange aggregations
    /// </summary>
    /// <value>For use with numericRange aggregations</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public string Metric { get; set; }



    /// <summary>
    /// For use with termFrequency aggregations
    /// </summary>
    /// <value>For use with termFrequency aggregations</value>
    [DataMember(Name = "size", EmitDefaultValue = false)]
    public int? Size { get; set; }



    /// <summary>
    /// For use with numericRange aggregations
    /// </summary>
    /// <value>For use with numericRange aggregations</value>
    [DataMember(Name = "ranges", EmitDefaultValue = false)]
    public List<AggregationRange> Ranges { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsQueryAggregation {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  Ranges: ").Append(Ranges).Append("\n");
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
        return Equals(obj as AnalyticsQueryAggregation);
    }

    /// <summary>
    /// Returns true if AnalyticsQueryAggregation instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsQueryAggregation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsQueryAggregation other)
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
                Size == other.Size ||
                Size != null &&
                Size.Equals(other.Size)
            ) &&
            (
                Ranges == other.Ranges ||
                Ranges != null &&
                Ranges.SequenceEqual(other.Ranges)
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

            if (Size != null)
            {
                hash = hash * 59 + Size.GetHashCode();
            }

            if (Ranges != null)
            {
                hash = hash * 59 + Ranges.GetHashCode();
            }

            return hash;
        }
    }
}
