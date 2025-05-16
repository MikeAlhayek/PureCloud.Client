using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PhoneChangeTopicUserAgentInfo
{
    /// <summary>
    /// Gets or Sets FirmwareVersion
    /// </summary>
    public string FirmwareVersion { get; set; }

    /// <summary>
    /// Gets or Sets Manufacturer
    /// </summary>
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    public string Model { get; set; }
}
