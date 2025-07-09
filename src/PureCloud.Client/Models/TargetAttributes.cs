using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TargetAttributes
{
    /// <summary>
    /// A set of base attributes which may be used in policies for any target.
    /// </summary>
    /// <value>A set of base attributes which may be used in policies for any target.</value>
    public IEnumerable<PolicyAttribute> BaseAttributes { get; set; }

    /// <summary>
    /// A map of policy targets to any additional attributes which are valid for that target.
    /// </summary>
    /// <value>A map of policy targets to any additional attributes which are valid for that target.</value>
    public Dictionary<string, TargetAttributeValue> _TargetAttributes { get; set; }
}
