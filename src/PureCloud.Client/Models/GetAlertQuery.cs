using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GetAlertQuery
{
    /// <summary>
    /// The rule type of the alerts the query will return
    /// </summary>
    /// <value>The rule type of the alerts the query will return</value>
    public GetAlertQueryRuleTypeEnum? RuleType { get; set; }

    /// <summary>
    /// The type of query being performed.
    /// </summary>
    /// <value>The type of query being performed.</value>
    public GetAlertQueryQueryTypeEnum? QueryType { get; set; }

    /// <summary>
    /// The status of the alerts the query will return.
    /// </summary>
    /// <value>The status of the alerts the query will return.</value>
    public GetAlertQueryAlertStatusEnum? AlertStatus { get; set; }

    /// <summary>
    /// The view status of the alerts the query will return.
    /// </summary>
    /// <value>The view status of the alerts the query will return.</value>
    public GetAlertQueryViewedStatusEnum? ViewedStatus { get; set; }

    /// <summary>
    /// The field to sort responses by.  The accepted choices are Name and DateStart
    /// </summary>
    /// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
    public GetAlertQuerySortByEnum? SortBy { get; set; }

    /// <summary>
    /// The order in which response will be sorted.  The accepted choices are Asc and Desc
    /// </summary>
    /// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
    public GetAlertQuerySortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// The page number of the queried response
    /// </summary>
    /// <value>The page number of the queried response</value>
    public int? PageNumber { get; set; }

    /// <summary>
    /// The number of entities to return of the queried response.  The max is 25
    /// </summary>
    /// <value>The number of entities to return of the queried response.  The max is 25</value>
    public int? PageSize { get; set; }
}
