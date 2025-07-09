using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowMilestone
{
    /// <summary>
    /// The flow milestone identifier
    /// </summary>
    /// <value>The flow milestone identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow milestone name.
    /// </summary>
    /// <value>The flow milestone name.</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// The flow milestone description.
    /// </summary>
    /// <value>The flow milestone description.</value>
    public string Description { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
