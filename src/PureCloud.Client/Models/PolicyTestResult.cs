using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PolicyTestResult
{
    /// <summary>
    /// The ID of the policy being tested.
    /// </summary>
    /// <value>The ID of the policy being tested.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the policy being tested.
    /// </summary>
    /// <value>The name of the policy being tested.</value>
    public string Name { get; set; }

    /// <summary>
    /// The result of the evaluation against supplied test data.
    /// </summary>
    /// <value>The result of the evaluation against supplied test data.</value>
    public string Result { get; set; }

    /// <summary>
    /// The results of conditions, with their boolean result.
    /// </summary>
    /// <value>The results of conditions, with their boolean result.</value>
    public IEnumerable<PolicyConditionResult> PolicyConditionResults { get; set; }
}
