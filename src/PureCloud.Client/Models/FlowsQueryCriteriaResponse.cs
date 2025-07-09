using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowsQueryCriteriaResponse
{
    /// <summary>
    /// The is a list of allowed criteria to query on.
    /// </summary>
    /// <value>The is a list of allowed criteria to query on.</value>
    public IEnumerable<QueryCriteria> Criteria { get; set; }

    /// <summary>
    /// The is a list of flow types the organization has access to.
    /// </summary>
    /// <value>The is a list of flow types the organization has access to.</value>
    public IEnumerable<FlowsQueryCriteriaResponseFlowTypesEnum> FlowTypes { get; set; }

    /// <summary>
    /// The is a list of action types the organization has access to.
    /// </summary>
    /// <value>The is a list of action types the organization has access to.</value>
    public IEnumerable<FlowsQueryCriteriaResponseActionTypesEnum> ActionTypes { get; set; }

    /// <summary>
    /// The is a list of potential error codes the organization may encounter.
    /// </summary>
    /// <value>The is a list of potential error codes the organization may encounter.</value>
    public IEnumerable<string> ErrorCodes { get; set; }

    /// <summary>
    /// The is a list of potential warning codes the organization may encounter.
    /// </summary>
    /// <value>The is a list of potential warning codes the organization may encounter.</value>
    public IEnumerable<string> WarningCodes { get; set; }
}
