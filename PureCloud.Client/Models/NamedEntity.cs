namespace PureCloud.Client.Models;

public sealed class NamedEntity
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    public string Name { get; set; }
}
