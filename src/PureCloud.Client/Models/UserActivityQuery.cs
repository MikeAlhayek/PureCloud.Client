using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserActivityQuery
{
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    public UserActivityQueryOrderEnum? Order { get; set; }

    /// <summary>
    /// List of requested metrics
    /// </summary>
    /// <value>List of requested metrics</value>
    public IEnumerable<UserActivityQueryMetric> Metrics { get; set; }

    /// <summary>
    /// Dimension(s) to group by
    /// </summary>
    /// <value>Dimension(s) to group by</value>
    public IEnumerable<UserActivityQueryGroupByEnum> GroupBy { get; set; }

    /// <summary>
    /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
    public UserActivityQueryFilter Filter { get; set; }
}
