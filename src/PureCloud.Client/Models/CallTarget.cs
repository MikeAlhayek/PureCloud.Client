using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CallTarget
{
    /// <summary>
    /// The type of call
    /// </summary>
    /// <value>The type of call</value>
    public CallTargetTypeEnum? Type { get; set; }

    /// <summary>
    /// The id of the station or an E.164 formatted phone number
    /// </summary>
    /// <value>The id of the station or an E.164 formatted phone number</value>
    public string Value { get; set; }
}
