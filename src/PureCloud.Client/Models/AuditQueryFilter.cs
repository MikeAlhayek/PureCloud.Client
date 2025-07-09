using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQueryFilter
{
    /// <summary>
    /// Name of the property to filter.
    /// </summary>
    /// <value>Name of the property to filter.</value>
    public AuditQueryFilterPropertyEnum? Property { get; set; }

    /// <summary>
    /// Value of the property to filter.
    /// </summary>
    /// <value>Value of the property to filter.</value>
    public string Value { get; set; }
}
