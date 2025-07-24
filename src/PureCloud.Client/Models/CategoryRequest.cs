namespace PureCloud.Client.Models;

/// <summary>
/// CategoryRequest
/// </summary>
public sealed class CategoryRequest
{
    /// <summary>
    /// The name of the category
    /// </summary>
    /// <value>The name of the category</value>
    public string Name { get; set; }

    /// <summary>
    /// The description of the category
    /// </summary>
    /// <value>The description of the category</value>
    public string Description { get; set; }

    /// <summary>
    /// The type of interaction the category will apply to
    /// </summary>
    /// <value>The type of interaction the category will apply to</value>
    public CategoryRequestInteractionType? InteractionType { get; set; }

    /// <summary>
    /// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
    /// </summary>
    /// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
    public Operand Criteria { get; set; }
}