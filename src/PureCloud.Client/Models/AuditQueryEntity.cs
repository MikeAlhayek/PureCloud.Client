using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryEntity
{
    /// <summary>
    /// Name of the Entity
    /// </summary>
    /// <value>Name of the Entity</value>
    public string Name { get; set; }

    /// <summary>
    /// List of Actions
    /// </summary>
    /// <value>List of Actions</value>
    public IEnumerable<string> Actions { get; set; }
}
