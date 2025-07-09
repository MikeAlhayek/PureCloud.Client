using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PolicyTestPayload
{
    /// <summary>
    /// A map of attribute names to attribute type and string representation of value. All attributes returned by api/v2/authorization/policies/{policyId}/attributes are required
    /// </summary>
    /// <value>A map of attribute names to attribute type and string representation of value. All attributes returned by api/v2/authorization/policies/{policyId}/attributes are required</value>
    public Dictionary<string, TypedAttribute> AttributeData { get; set; }
}
