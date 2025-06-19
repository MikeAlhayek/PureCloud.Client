using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GetRulesQuery
{
    /// <summary>
    /// The rule type of the alerts the query will return
    /// </summary>
    /// <value>The rule type of the alerts the query will return</value>
    public GetRulesQueryRuleTypeEnum? RuleType { get; set; }

    /// <summary>
    /// The type of query being performed.
    /// </summary>
    /// <value>The type of query being performed.</value>
    public GetRulesQueryQueryTypeEnum? QueryType { get; set; }

    /// <summary>
    /// The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All
    /// </summary>
    /// <value>The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All</value>
    public GetRulesQueryEnabledTypeEnum? EnabledType { get; set; }

    /// <summary>
    /// The field to sort responses by.  The accepted choices are Name and DateStart
    /// </summary>
    /// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
    public GetRulesQuerySortByEnum? SortBy { get; set; }

    /// <summary>
    /// The order in which response will be sorted.  The accepted choices are Asc and Desc
    /// </summary>
    /// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
    public GetRulesQuerySortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.
    /// </summary>
    /// <value>Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.</value>
    public GetRulesQueryNameSearchTypeEnum? NameSearchType { get; set; }

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

    /// <summary>
    /// The name of the rule being queries.
    /// </summary>
    /// <value>The name of the rule being queries.</value>
    public string RuleName { get; set; }
}
