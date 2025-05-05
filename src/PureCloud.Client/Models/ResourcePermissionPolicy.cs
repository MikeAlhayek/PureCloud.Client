namespace PureCloud.Client.Models;

public sealed class ResourcePermissionPolicy
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

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
    /// Gets or Sets ActionSetKey
    /// </summary>
    public string ActionSetKey { get; set; }

    /// <summary>
    /// Gets or Sets AllowConditions
    /// </summary>
    public bool? AllowConditions { get; set; }

    /// <summary>
    /// Gets or Sets ResourceConditionNode
    /// </summary>
    public ResourceConditionNode ResourceConditionNode { get; set; }

    /// <summary>
    /// Gets or Sets NamedResources
    /// </summary>
    public IEnumerable<string> NamedResources { get; set; }

    /// <summary>
    /// Gets or Sets ResourceCondition
    /// </summary>
    public string ResourceCondition { get; set; }

    /// <summary>
    /// Gets or Sets ActionSet
    /// </summary>
    public IEnumerable<string> ActionSet { get; set; }
}
