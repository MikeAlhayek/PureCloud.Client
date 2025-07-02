using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Warning
{
    /// <summary>
    /// The range type for the warning configuration.
    /// </summary>
    /// <value>The range type for the warning configuration.</value>
    public WarningRangeTypeEnum? RangeType { get; set; }

    /// <summary>
    /// The value for the warning configuration.
    /// </summary>
    public int? Value { get; set; }

    /// <summary>
    /// The color for the warning configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).
    /// </summary>
    /// <value>The color for the warning configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).</value>
    public string Color { get; set; }
}
