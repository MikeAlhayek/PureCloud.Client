using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PhoneChangeTopicProvisionInfo
{
    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    public DateTime? Time { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public string ErrorInfo { get; set; }
}
