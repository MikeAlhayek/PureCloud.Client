using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EntityChange
{
    /// <summary>
    /// Id of the entity that was changed
    /// </summary>
    /// <value>Id of the entity that was changed</value>
    public string EntityId { get; set; }

    /// <summary>
    /// Name of the entity that was changed
    /// </summary>
    /// <value>Name of the entity that was changed</value>
    public string EntityName { get; set; }

    /// <summary>
    /// Type of the entity that was changed
    /// </summary>
    /// <value>Type of the entity that was changed</value>
    public string EntityType { get; set; }

    /// <summary>
    /// Previous values for the entity.
    /// </summary>
    /// <value>Previous values for the entity.</value>
    public IEnumerable<string> OldValues { get; set; }

    /// <summary>
    /// New values for the entity.
    /// </summary>
    /// <value>New values for the entity.</value>
    public IEnumerable<string> NewValues { get; set; }
}
