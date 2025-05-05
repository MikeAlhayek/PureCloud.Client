using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FacetStatistics
/// </summary>

public partial class FacetStatistics : IEquatable<FacetStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FacetStatistics" /> class.
    /// </summary>
    /// <param name="Count">Count.</param>
    /// <param name="Min">Min.</param>
    /// <param name="Max">Max.</param>
    /// <param name="Mean">Mean.</param>
    /// <param name="StdDeviation">StdDeviation.</param>
    /// <param name="DateMin">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateMax">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public FacetStatistics(long? Count = null, double? Min = null, double? Max = null, double? Mean = null, double? StdDeviation = null, DateTime? DateMin = null, DateTime? DateMax = null)
    {
        this.Count = Count;
        this.Min = Min;
        this.Max = Max;
        this.Mean = Mean;
        this.StdDeviation = StdDeviation;
        this.DateMin = DateMin;
        this.DateMax = DateMax;

    }



    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }



    /// <summary>
    /// Gets or Sets Min
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }



    /// <summary>
    /// Gets or Sets Max
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }



    /// <summary>
    /// Gets or Sets Mean
    /// </summary>
    [JsonPropertyName("mean")]
    public double? Mean { get; set; }



    /// <summary>
    /// Gets or Sets StdDeviation
    /// </summary>
    [JsonPropertyName("stdDeviation")]
    public double? StdDeviation { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateMin")]
    public DateTime? DateMin { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateMax")]
    public DateTime? DateMax { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FacetStatistics {\n");

        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Min: ").Append(Min).Append("\n");
        sb.Append("  Max: ").Append(Max).Append("\n");
        sb.Append("  Mean: ").Append(Mean).Append("\n");
        sb.Append("  StdDeviation: ").Append(StdDeviation).Append("\n");
        sb.Append("  DateMin: ").Append(DateMin).Append("\n");
        sb.Append("  DateMax: ").Append(DateMax).Append("\n");
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
        return Equals(obj as FacetStatistics);
    }

    /// <summary>
    /// Returns true if FacetStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of FacetStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FacetStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                Min == other.Min ||
                Min != null &&
                Min.Equals(other.Min)
            ) &&
            (
                Max == other.Max ||
                Max != null &&
                Max.Equals(other.Max)
            ) &&
            (
                Mean == other.Mean ||
                Mean != null &&
                Mean.Equals(other.Mean)
            ) &&
            (
                StdDeviation == other.StdDeviation ||
                StdDeviation != null &&
                StdDeviation.Equals(other.StdDeviation)
            ) &&
            (
                DateMin == other.DateMin ||
                DateMin != null &&
                DateMin.Equals(other.DateMin)
            ) &&
            (
                DateMax == other.DateMax ||
                DateMax != null &&
                DateMax.Equals(other.DateMax)
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
            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Min != null)
            {
                hash = hash * 59 + Min.GetHashCode();
            }

            if (Max != null)
            {
                hash = hash * 59 + Max.GetHashCode();
            }

            if (Mean != null)
            {
                hash = hash * 59 + Mean.GetHashCode();
            }

            if (StdDeviation != null)
            {
                hash = hash * 59 + StdDeviation.GetHashCode();
            }

            if (DateMin != null)
            {
                hash = hash * 59 + DateMin.GetHashCode();
            }

            if (DateMax != null)
            {
                hash = hash * 59 + DateMax.GetHashCode();
            }

            return hash;
        }
    }
}
