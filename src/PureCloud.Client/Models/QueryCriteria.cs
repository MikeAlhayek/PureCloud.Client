using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryCriteria
{
    /// <summary>
    /// The is the name of the criteria that can be queried.
    /// </summary>
    /// <value>The is the name of the criteria that can be queried.</value>
    public QueryCriteriaCriteriaKeyEnum? CriteriaKey { get; set; }

    /// <summary>
    /// The type of data for the criteria (string, int, etc).
    /// </summary>
    /// <value>The type of data for the criteria (string, int, etc).</value>
    public QueryCriteriaDataTypeEnum? DataType { get; set; }

    /// <summary>
    /// The executionData type that this criteria item can be used on.
    /// </summary>
    /// <value>The executionData type that this criteria item can be used on.</value>
    public IEnumerable<QueryCriteriaCriteriaGroupsEnum> CriteriaGroups { get; set; }

    /// <summary>
    /// The is the description of the criteria.
    /// </summary>
    /// <value>The is the description of the criteria.</value>
    public string Description { get; set; }

    /// <summary>
    /// A list of operators that can be used on this criteria.
    /// </summary>
    /// <value>A list of operators that can be used on this criteria.</value>
    public IEnumerable<string> Operators { get; set; }

    /// <summary>
    /// A logical grouping and display order for this item.
    /// </summary>
    /// <value>A logical grouping and display order for this item.</value>
    public CriteriaCategoryInfo CategoryInfo { get; set; }
}
