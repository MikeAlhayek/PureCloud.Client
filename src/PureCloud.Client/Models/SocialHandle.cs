using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SocialHandle
{
    /// <summary>
    /// Social Handle Type
    /// </summary>
    /// <value>Social Handle Type</value>
    public SocialHandleTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
