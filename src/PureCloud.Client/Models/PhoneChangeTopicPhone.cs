using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PhoneChangeTopicPhone
{
    /// <summary>
    /// Gets or Sets UserAgentInfo
    /// </summary>
    public PhoneChangeTopicUserAgentInfo UserAgentInfo { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public PhoneChangeTopicPhoneStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryStatus
    /// </summary>
    public PhoneChangeTopicPhoneStatus SecondaryStatus { get; set; }
}
