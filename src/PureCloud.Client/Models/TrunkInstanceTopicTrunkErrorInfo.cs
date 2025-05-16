using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrunkInstanceTopicTrunkErrorInfo
{
    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    public TrunkInstanceTopicTrunkErrorInfoDetails Details { get; set; }
}
