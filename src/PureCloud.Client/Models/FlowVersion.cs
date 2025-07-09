using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class FlowVersion
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public FlowVersionTypeEnum? Type { get; set; }

    /// <summary>
    /// The flow version identifier
    /// </summary>
    /// <value>The flow version identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CommitVersion
    /// </summary>
    public string CommitVersion { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationVersion
    /// </summary>
    public string ConfigurationVersion { get; set; }

    /// <summary>
    /// Gets or Sets Secure
    /// </summary>
    public bool? Secure { get; set; }

    /// <summary>
    /// Gets or Sets Debug
    /// </summary>
    public bool? Debug { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public User CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets CreatedByClient
    /// </summary>
    public DomainEntityRef CreatedByClient { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationUri
    /// </summary>
    public string ConfigurationUri { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public long? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateCheckedIn
    /// </summary>
    public long? DateCheckedIn { get; set; }

    /// <summary>
    /// Gets or Sets DateSaved
    /// </summary>
    public long? DateSaved { get; set; }

    /// <summary>
    /// Gets or Sets GenerationId
    /// </summary>
    public string GenerationId { get; set; }

    /// <summary>
    /// Gets or Sets PublishResultUri
    /// </summary>
    public string PublishResultUri { get; set; }

    /// <summary>
    /// Gets or Sets InputSchema
    /// </summary>
    public JsonSchemaDocument InputSchema { get; set; }

    /// <summary>
    /// Gets or Sets OutputSchema
    /// </summary>
    public JsonSchemaDocument OutputSchema { get; set; }

    /// <summary>
    /// Gets or Sets VirtualAgentEnabled
    /// </summary>
    public bool? VirtualAgentEnabled { get; set; }

    /// <summary>
    /// The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DatePublished { get; set; }

    /// <summary>
    /// The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DatePublishedEnd { get; set; }

    /// <summary>
    /// Information about the natural language understanding configuration for the flow version
    /// </summary>
    /// <value>Information about the natural language understanding configuration for the flow version</value>
    public NluInfo NluInfo { get; set; }

    /// <summary>
    /// List of supported languages for this version of the flow
    /// </summary>
    /// <value>List of supported languages for this version of the flow</value>
    public IEnumerable<SupportedLanguage> SupportedLanguages { get; set; }

    /// <summary>
    /// Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.
    /// </summary>
    /// <value>Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.</value>
    public IEnumerable<FlowVersionCompatibleFlowTypesEnum> CompatibleFlowTypes { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
