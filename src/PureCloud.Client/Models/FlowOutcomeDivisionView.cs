using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowOutcomeDivisionView
{
    /// <summary>
    /// The flow outcome identifier
    /// </summary>
    /// <value>The flow outcome identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow outcome name
    /// </summary>
    /// <value>The flow outcome name</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
