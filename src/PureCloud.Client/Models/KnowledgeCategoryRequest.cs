using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeCategoryRequest
/// </summary>

public sealed class KnowledgeCategoryRequest
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Category name
    /// </summary>
    /// <value>Category name</value>
    public string Name { get; set; }

    /// <summary>
    /// Category description
    /// </summary>
    /// <value>Category description</value>
    public string Description { get; set; }

    /// <summary>
    /// Category parent
    /// </summary>
    /// <value>Category parent</value>
    public DocumentCategoryInput Parent { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
