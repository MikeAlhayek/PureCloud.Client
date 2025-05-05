using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaStatisticalSummary
/// </summary>

public partial class SocialMediaStatisticalSummary : IEquatable<SocialMediaStatisticalSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialMediaStatisticalSummary" /> class.
    /// </summary>
    /// <param name="Max">Max.</param>
    /// <param name="Min">Min.</param>
    /// <param name="Count">Count.</param>
    /// <param name="CountNegative">CountNegative.</param>
    /// <param name="CountPositive">CountPositive.</param>
    /// <param name="CountNeutral">CountNeutral.</param>
    /// <param name="CountUnknown">CountUnknown.</param>
    /// <param name="Sum">Sum.</param>
    /// <param name="Current">Current.</param>
    /// <param name="Ratio">Ratio.</param>
    /// <param name="Numerator">Numerator.</param>
    /// <param name="Denominator">Denominator.</param>
    /// <param name="Target">Target.</param>
    /// <param name="P95">P95.</param>
    /// <param name="P99">P99.</param>
    public SocialMediaStatisticalSummary(double? Max = null, double? Min = null, long? Count = null, long? CountNegative = null, long? CountPositive = null, long? CountNeutral = null, long? CountUnknown = null, double? Sum = null, double? Current = null, double? Ratio = null, double? Numerator = null, double? Denominator = null, double? Target = null, long? P95 = null, long? P99 = null)
    {
        this.Max = Max;
        this.Min = Min;
        this.Count = Count;
        this.CountNegative = CountNegative;
        this.CountPositive = CountPositive;
        this.CountNeutral = CountNeutral;
        this.CountUnknown = CountUnknown;
        this.Sum = Sum;
        this.Current = Current;
        this.Ratio = Ratio;
        this.Numerator = Numerator;
        this.Denominator = Denominator;
        this.Target = Target;
        this.P95 = P95;
        this.P99 = P99;

    }



    /// <summary>
    /// Gets or Sets Max
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }



    /// <summary>
    /// Gets or Sets Min
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }



    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }



    /// <summary>
    /// Gets or Sets CountNegative
    /// </summary>
    [JsonPropertyName("countNegative")]
    public long? CountNegative { get; set; }



    /// <summary>
    /// Gets or Sets CountPositive
    /// </summary>
    [JsonPropertyName("countPositive")]
    public long? CountPositive { get; set; }



    /// <summary>
    /// Gets or Sets CountNeutral
    /// </summary>
    [JsonPropertyName("countNeutral")]
    public long? CountNeutral { get; set; }



    /// <summary>
    /// Gets or Sets CountUnknown
    /// </summary>
    [JsonPropertyName("countUnknown")]
    public long? CountUnknown { get; set; }



    /// <summary>
    /// Gets or Sets Sum
    /// </summary>
    [JsonPropertyName("sum")]
    public double? Sum { get; set; }



    /// <summary>
    /// Gets or Sets Current
    /// </summary>
    [JsonPropertyName("current")]
    public double? Current { get; set; }



    /// <summary>
    /// Gets or Sets Ratio
    /// </summary>
    [JsonPropertyName("ratio")]
    public double? Ratio { get; set; }



    /// <summary>
    /// Gets or Sets Numerator
    /// </summary>
    [JsonPropertyName("numerator")]
    public double? Numerator { get; set; }



    /// <summary>
    /// Gets or Sets Denominator
    /// </summary>
    [JsonPropertyName("denominator")]
    public double? Denominator { get; set; }



    /// <summary>
    /// Gets or Sets Target
    /// </summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }



    /// <summary>
    /// Gets or Sets P95
    /// </summary>
    [JsonPropertyName("p95")]
    public long? P95 { get; set; }



    /// <summary>
    /// Gets or Sets P99
    /// </summary>
    [JsonPropertyName("p99")]
    public long? P99 { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialMediaStatisticalSummary {\n");

        sb.Append("  Max: ").Append(Max).Append("\n");
        sb.Append("  Min: ").Append(Min).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  CountNegative: ").Append(CountNegative).Append("\n");
        sb.Append("  CountPositive: ").Append(CountPositive).Append("\n");
        sb.Append("  CountNeutral: ").Append(CountNeutral).Append("\n");
        sb.Append("  CountUnknown: ").Append(CountUnknown).Append("\n");
        sb.Append("  Sum: ").Append(Sum).Append("\n");
        sb.Append("  Current: ").Append(Current).Append("\n");
        sb.Append("  Ratio: ").Append(Ratio).Append("\n");
        sb.Append("  Numerator: ").Append(Numerator).Append("\n");
        sb.Append("  Denominator: ").Append(Denominator).Append("\n");
        sb.Append("  Target: ").Append(Target).Append("\n");
        sb.Append("  P95: ").Append(P95).Append("\n");
        sb.Append("  P99: ").Append(P99).Append("\n");
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
        return Equals(obj as SocialMediaStatisticalSummary);
    }

    /// <summary>
    /// Returns true if SocialMediaStatisticalSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialMediaStatisticalSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialMediaStatisticalSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Max == other.Max ||
                Max != null &&
                Max.Equals(other.Max)
            ) &&
            (
                Min == other.Min ||
                Min != null &&
                Min.Equals(other.Min)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                CountNegative == other.CountNegative ||
                CountNegative != null &&
                CountNegative.Equals(other.CountNegative)
            ) &&
            (
                CountPositive == other.CountPositive ||
                CountPositive != null &&
                CountPositive.Equals(other.CountPositive)
            ) &&
            (
                CountNeutral == other.CountNeutral ||
                CountNeutral != null &&
                CountNeutral.Equals(other.CountNeutral)
            ) &&
            (
                CountUnknown == other.CountUnknown ||
                CountUnknown != null &&
                CountUnknown.Equals(other.CountUnknown)
            ) &&
            (
                Sum == other.Sum ||
                Sum != null &&
                Sum.Equals(other.Sum)
            ) &&
            (
                Current == other.Current ||
                Current != null &&
                Current.Equals(other.Current)
            ) &&
            (
                Ratio == other.Ratio ||
                Ratio != null &&
                Ratio.Equals(other.Ratio)
            ) &&
            (
                Numerator == other.Numerator ||
                Numerator != null &&
                Numerator.Equals(other.Numerator)
            ) &&
            (
                Denominator == other.Denominator ||
                Denominator != null &&
                Denominator.Equals(other.Denominator)
            ) &&
            (
                Target == other.Target ||
                Target != null &&
                Target.Equals(other.Target)
            ) &&
            (
                P95 == other.P95 ||
                P95 != null &&
                P95.Equals(other.P95)
            ) &&
            (
                P99 == other.P99 ||
                P99 != null &&
                P99.Equals(other.P99)
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
            if (Max != null)
            {
                hash = hash * 59 + Max.GetHashCode();
            }

            if (Min != null)
            {
                hash = hash * 59 + Min.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (CountNegative != null)
            {
                hash = hash * 59 + CountNegative.GetHashCode();
            }

            if (CountPositive != null)
            {
                hash = hash * 59 + CountPositive.GetHashCode();
            }

            if (CountNeutral != null)
            {
                hash = hash * 59 + CountNeutral.GetHashCode();
            }

            if (CountUnknown != null)
            {
                hash = hash * 59 + CountUnknown.GetHashCode();
            }

            if (Sum != null)
            {
                hash = hash * 59 + Sum.GetHashCode();
            }

            if (Current != null)
            {
                hash = hash * 59 + Current.GetHashCode();
            }

            if (Ratio != null)
            {
                hash = hash * 59 + Ratio.GetHashCode();
            }

            if (Numerator != null)
            {
                hash = hash * 59 + Numerator.GetHashCode();
            }

            if (Denominator != null)
            {
                hash = hash * 59 + Denominator.GetHashCode();
            }

            if (Target != null)
            {
                hash = hash * 59 + Target.GetHashCode();
            }

            if (P95 != null)
            {
                hash = hash * 59 + P95.GetHashCode();
            }

            if (P99 != null)
            {
                hash = hash * 59 + P99.GetHashCode();
            }

            return hash;
        }
    }
}
