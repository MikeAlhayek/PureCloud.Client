using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class StatisticalSummary
{
    /// <summary>
    /// Gets or Sets Max
    /// </summary>
    public double? Max { get; set; }

    /// <summary>
    /// Gets or Sets Min
    /// </summary>
    public double? Min { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public long? Count { get; set; }

    /// <summary>
    /// Gets or Sets CountNegative
    /// </summary>
    public long? CountNegative { get; set; }

    /// <summary>
    /// Gets or Sets CountPositive
    /// </summary>
    public long? CountPositive { get; set; }

    /// <summary>
    /// Gets or Sets Sum
    /// </summary>
    public double? Sum { get; set; }

    /// <summary>
    /// Gets or Sets Current
    /// </summary>
    public double? Current { get; set; }

    /// <summary>
    /// Gets or Sets Ratio
    /// </summary>
    public double? Ratio { get; set; }

    /// <summary>
    /// Gets or Sets Numerator
    /// </summary>
    public double? Numerator { get; set; }

    /// <summary>
    /// Gets or Sets Denominator
    /// </summary>
    public double? Denominator { get; set; }

    /// <summary>
    /// Gets or Sets Target
    /// </summary>
    public double? Target { get; set; }

    /// <summary>
    /// Gets or Sets P95
    /// </summary>
    public long? P95 { get; set; }

    /// <summary>
    /// Gets or Sets P99
    /// </summary>
    public long? P99 { get; set; }
}
