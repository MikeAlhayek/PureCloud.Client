using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityTypeBinding
{
    /// <summary>
    /// The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType.
    /// </summary>
    /// <value>The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType.</value>
    public string EntityType { get; set; }

    /// <summary>
    /// The name that this named entity type is bound to.
    /// </summary>
    /// <value>The name that this named entity type is bound to.</value>
    public string EntityName { get; set; }
}
