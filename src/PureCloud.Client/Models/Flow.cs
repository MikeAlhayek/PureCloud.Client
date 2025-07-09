using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Flow
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public FlowTypeEnum? Type { get; set; }

    /// <summary>
    /// The flow identifier
    /// </summary>
    /// <value>The flow identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow name
    /// </summary>
    /// <value>The flow name</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// User that has the flow locked.
    /// </summary>
    /// <value>User that has the flow locked.</value>
    public User LockedUser { get; set; }

    /// <summary>
    /// OAuth client that has the flow locked.
    /// </summary>
    /// <value>OAuth client that has the flow locked.</value>
    public DomainEntityRef LockedClient { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    public bool? System { get; set; }

    /// <summary>
    /// Gets or Sets Deleted
    /// </summary>
    public bool? Deleted { get; set; }

    /// <summary>
    /// Gets or Sets PublishedVersion
    /// </summary>
    public FlowVersion PublishedVersion { get; set; }

    /// <summary>
    /// Gets or Sets SavedVersion
    /// </summary>
    public FlowVersion SavedVersion { get; set; }

    /// <summary>
    /// json schema describing the inputs for the flow
    /// </summary>
    /// <value>json schema describing the inputs for the flow</value>
    public object InputSchema { get; set; }

    /// <summary>
    /// json schema describing the outputs for the flow
    /// </summary>
    /// <value>json schema describing the outputs for the flow</value>
    public object OutputSchema { get; set; }

    /// <summary>
    /// Gets or Sets CheckedInVersion
    /// </summary>
    public FlowVersion CheckedInVersion { get; set; }

    /// <summary>
    /// Gets or Sets DebugVersion
    /// </summary>
    public FlowVersion DebugVersion { get; set; }

    /// <summary>
    /// Gets or Sets PublishedBy
    /// </summary>
    public User PublishedBy { get; set; }

    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    public Operation CurrentOperation { get; set; }

    /// <summary>
    /// Information about the natural language understanding configuration for the published version of the flow
    /// </summary>
    /// <value>Information about the natural language understanding configuration for the published version of the flow</value>
    public NluInfo NluInfo { get; set; }

    /// <summary>
    /// List of supported languages for the published version of the flow.
    /// </summary>
    /// <value>List of supported languages for the published version of the flow.</value>
    public IEnumerable<SupportedLanguage> SupportedLanguages { get; set; }

    /// <summary>
    /// Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.
    /// </summary>
    /// <value>Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.</value>
    public IEnumerable<FlowCompatibleFlowTypesEnum> CompatibleFlowTypes { get; set; }

    /// <summary>
    /// Gets or Sets WorktypeId
    /// </summary>
    public string WorktypeId { get; set; }

    /// <summary>
    /// Gets or Sets VirtualAgentEnabled
    /// </summary>
    public bool? VirtualAgentEnabled { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
