using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBusinessUnitReference
{
    /// <summary>
    /// The ID of the business unit
    /// </summary>
    /// <value>The ID of the business unit</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
