using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DashboardConfigurationQueryRequest
{
    /// <summary>
    /// The order in which response will be sorted
    /// </summary>
    /// <value>The order in which response will be sorted</value>
    public DashboardConfigurationQueryRequestSortByEnum? SortBy { get; set; }

    /// <summary>
    /// The user supplied dashboard configuration ids
    /// </summary>
    /// <value>The user supplied dashboard configuration ids</value>
    public IEnumerable<string> DashboardConfigurationIds { get; set; }

    /// <summary>
    /// The page number of the queried response
    /// </summary>
    /// <value>The page number of the queried response</value>
    public int? PageNumber { get; set; }

    /// <summary>
    /// The number of entities to return of the queried response. The max is 25
    /// </summary>
    /// <value>The number of entities to return of the queried response. The max is 25</value>
    public int? PageSize { get; set; }
}
