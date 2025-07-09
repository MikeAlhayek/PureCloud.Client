using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowDivisionView
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public FlowDivisionViewTypeEnum? Type { get; set; }

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
    /// the flow description
    /// </summary>
    /// <value>the flow description</value>
    public string Description { get; set; }

    /// <summary>
    /// json schema describing the inputs for the flow
    /// </summary>
    /// <value>json schema describing the inputs for the flow</value>
    public JsonSchemaDocument InputSchema { get; set; }

    /// <summary>
    /// json schema describing the outputs for the flow
    /// </summary>
    /// <value>json schema describing the outputs for the flow</value>
    public JsonSchemaDocument OutputSchema { get; set; }

    /// <summary>
    /// List of supported languages for the published version of the flow.
    /// </summary>
    /// <value>List of supported languages for the published version of the flow.</value>
    public IEnumerable<SupportedLanguage> SupportedLanguages { get; set; }

    /// <summary>
    /// published version information if there is a published version
    /// </summary>
    /// <value>published version information if there is a published version</value>
    public FlowVersion PublishedVersion { get; set; }

    /// <summary>
    /// debug version information if there is a debug version
    /// </summary>
    /// <value>debug version information if there is a debug version</value>
    public FlowVersion DebugVersion { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
