using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditQuerySort
{
    /// <summary>
    /// Name of the property to sort.
    /// </summary>
    /// <value>Name of the property to sort.</value>
    public AuditQuerySortNameEnum? Name { get; set; }

    /// <summary>
    /// Sort Order
    /// </summary>
    /// <value>Sort Order</value>
    public AuditQuerySortSortOrderEnum? SortOrder { get; set; }
}
