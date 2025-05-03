namespace PureCloud.Client.Models;

public partial class DomainPermissionPolicy
{
    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    public string EntityName { get; set; }

    /// <summary>
    /// Gets or Sets PolicyName
    /// </summary>
    public string PolicyName { get; set; }

    /// <summary>
    /// Gets or Sets PolicyDescription
    /// </summary>
    public string PolicyDescription { get; set; }

    /// <summary>
    /// Gets or Sets ActionSet
    /// </summary>
    public IEnumerable<string> ActionSet { get; set; }

    /// <summary>
    /// Gets or Sets NamedResources
    /// </summary>
    public IEnumerable<string> NamedResources { get; set; }

    /// <summary>
    /// Gets or Sets AllowConditions
    /// </summary>
    public bool? AllowConditions { get; set; }

    /// <summary>
    /// Gets or Sets ResourceConditionNode
    /// </summary>
    public DomainResourceConditionNode ResourceConditionNode { get; set; }
}
