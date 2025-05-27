using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NumericRange
{
    /// <summary>
    /// Greater than
    /// </summary>
    /// <value>Greater than</value>
    public double? Gt { get; set; }

    /// <summary>
    /// Greater than or equal to
    /// </summary>
    /// <value>Greater than or equal to</value>
    public double? Gte { get; set; }

    /// <summary>
    /// Less than
    /// </summary>
    /// <value>Less than</value>
    public double? Lt { get; set; }

    /// <summary>
    /// Less than or equal to
    /// </summary>
    /// <value>Less than or equal to</value>
    public double? Lte { get; set; }
}
