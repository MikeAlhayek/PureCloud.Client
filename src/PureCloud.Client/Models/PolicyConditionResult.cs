using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PolicyConditionResult
{
    /// <summary>
    /// The condition name
    /// </summary>
    /// <value>The condition name</value>
    public string Name { get; set; }

    /// <summary>
    /// The boolean result of the condition
    /// </summary>
    /// <value>The boolean result of the condition</value>
    public bool? Result { get; set; }
}
