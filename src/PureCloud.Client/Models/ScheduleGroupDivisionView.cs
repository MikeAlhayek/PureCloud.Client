using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ScheduleGroupDivisionView
{
    /// <summary>
    /// The schedule group identifier
    /// </summary>
    /// <value>The schedule group identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// The schedule group name
    /// </summary>
    /// <value>The schedule group name</value>
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
