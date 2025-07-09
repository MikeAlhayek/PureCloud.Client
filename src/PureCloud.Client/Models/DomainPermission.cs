using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DomainPermission
{
    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public string EntityType { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Gets or Sets AllowsConditions
    /// </summary>
    public bool? AllowsConditions { get; set; }

    /// <summary>
    /// Gets or Sets DivisionAware
    /// </summary>
    public bool? DivisionAware { get; set; }
}
