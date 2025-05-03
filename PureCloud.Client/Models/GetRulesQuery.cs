using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GetRulesQuery
/// </summary>

public partial class GetRulesQuery : IEquatable<GetRulesQuery>
{
    /// <summary>
    /// The rule type of the alerts the query will return
    /// </summary>
    /// <value>The rule type of the alerts the query will return</value>
    
    public enum RuleTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Conversation for "Conversation"
        /// </summary>
        [EnumMember(Value = "Conversation")]
        Conversation,

        /// <summary>
        /// Enum Presence for "Presence"
        /// </summary>
        [EnumMember(Value = "Presence")]
        Presence,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All
    }
    /// <summary>
    /// The type of query being performed.
    /// </summary>
    /// <value>The type of query being performed.</value>
    
    public enum QueryTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Info for "Info"
        /// </summary>
        [EnumMember(Value = "Info")]
        Info,

        /// <summary>
        /// Enum Count for "Count"
        /// </summary>
        [EnumMember(Value = "Count")]
        Count
    }
    /// <summary>
    /// The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All
    /// </summary>
    /// <value>The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All</value>
    
    public enum EnabledTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enabled for "Enabled"
        /// </summary>
        [EnumMember(Value = "Enabled")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All
    }
    /// <summary>
    /// The field to sort responses by.  The accepted choices are Name and DateStart
    /// </summary>
    /// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
    
    public enum SortByEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Name for "Name"
        /// </summary>
        [EnumMember(Value = "Name")]
        Name,

        /// <summary>
        /// Enum Datecreated for "DateCreated"
        /// </summary>
        [EnumMember(Value = "DateCreated")]
        Datecreated
    }
    /// <summary>
    /// The order in which response will be sorted.  The accepted choices are Asc and Desc
    /// </summary>
    /// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
    
    public enum SortOrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Asc for "Asc"
        /// </summary>
        [EnumMember(Value = "Asc")]
        Asc,

        /// <summary>
        /// Enum Desc for "Desc"
        /// </summary>
        [EnumMember(Value = "Desc")]
        Desc
    }
    /// <summary>
    /// Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.
    /// </summary>
    /// <value>Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.</value>
    
    public enum NameSearchTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Exact for "Exact"
        /// </summary>
        [EnumMember(Value = "Exact")]
        Exact,

        /// <summary>
        /// Enum Contains for "Contains"
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The rule type of the alerts the query will return
    /// </summary>
    /// <value>The rule type of the alerts the query will return</value>
    [JsonPropertyName("ruleType")]
    public RuleTypeEnum? RuleType { get; set; }
    /// <summary>
    /// The type of query being performed.
    /// </summary>
    /// <value>The type of query being performed.</value>
    [JsonPropertyName("queryType")]
    public QueryTypeEnum? QueryType { get; set; }
    /// <summary>
    /// The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All
    /// </summary>
    /// <value>The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All</value>
    [JsonPropertyName("enabledType")]
    public EnabledTypeEnum? EnabledType { get; set; }
    /// <summary>
    /// The field to sort responses by.  The accepted choices are Name and DateStart
    /// </summary>
    /// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
    [JsonPropertyName("sortBy")]
    public SortByEnum? SortBy { get; set; }
    /// <summary>
    /// The order in which response will be sorted.  The accepted choices are Asc and Desc
    /// </summary>
    /// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }
    /// <summary>
    /// Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.
    /// </summary>
    /// <value>Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.</value>
    [JsonPropertyName("nameSearchType")]
    public NameSearchTypeEnum? NameSearchType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetRulesQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GetRulesQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetRulesQuery" /> class.
    /// </summary>
    /// <param name="RuleType">The rule type of the alerts the query will return (required).</param>
    /// <param name="QueryType">The type of query being performed. (required).</param>
    /// <param name="EnabledType">The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All.</param>
    /// <param name="PageNumber">The page number of the queried response.</param>
    /// <param name="PageSize">The number of entities to return of the queried response.  The max is 25.</param>
    /// <param name="SortBy">The field to sort responses by.  The accepted choices are Name and DateStart.</param>
    /// <param name="SortOrder">The order in which response will be sorted.  The accepted choices are Asc and Desc.</param>
    /// <param name="RuleName">The name of the rule being queries..</param>
    /// <param name="NameSearchType">Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name..</param>
    public GetRulesQuery(RuleTypeEnum? RuleType = null, QueryTypeEnum? QueryType = null, EnabledTypeEnum? EnabledType = null, int? PageNumber = null, int? PageSize = null, SortByEnum? SortBy = null, SortOrderEnum? SortOrder = null, string RuleName = null, NameSearchTypeEnum? NameSearchType = null)
    {
        this.RuleType = RuleType;
        this.QueryType = QueryType;
        this.EnabledType = EnabledType;
        this.PageNumber = PageNumber;
        this.PageSize = PageSize;
        this.SortBy = SortBy;
        this.SortOrder = SortOrder;
        this.RuleName = RuleName;
        this.NameSearchType = NameSearchType;

    }









    /// <summary>
    /// The page number of the queried response
    /// </summary>
    /// <value>The page number of the queried response</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// The number of entities to return of the queried response.  The max is 25
    /// </summary>
    /// <value>The number of entities to return of the queried response.  The max is 25</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }







    /// <summary>
    /// The name of the rule being queries.
    /// </summary>
    /// <value>The name of the rule being queries.</value>
    [JsonPropertyName("ruleName")]
    public string RuleName { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetRulesQuery {\n");

        sb.Append("  RuleType: ").Append(RuleType).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  EnabledType: ").Append(EnabledType).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  SortBy: ").Append(SortBy).Append("\n");
        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
        sb.Append("  RuleName: ").Append(RuleName).Append("\n");
        sb.Append("  NameSearchType: ").Append(NameSearchType).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as GetRulesQuery);
    }

    /// <summary>
    /// Returns true if GetRulesQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of GetRulesQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GetRulesQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RuleType == other.RuleType ||
                RuleType != null &&
                RuleType.Equals(other.RuleType)
            ) &&
            (
                QueryType == other.QueryType ||
                QueryType != null &&
                QueryType.Equals(other.QueryType)
            ) &&
            (
                EnabledType == other.EnabledType ||
                EnabledType != null &&
                EnabledType.Equals(other.EnabledType)
            ) &&
            (
                PageNumber == other.PageNumber ||
                PageNumber != null &&
                PageNumber.Equals(other.PageNumber)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                SortBy == other.SortBy ||
                SortBy != null &&
                SortBy.Equals(other.SortBy)
            ) &&
            (
                SortOrder == other.SortOrder ||
                SortOrder != null &&
                SortOrder.Equals(other.SortOrder)
            ) &&
            (
                RuleName == other.RuleName ||
                RuleName != null &&
                RuleName.Equals(other.RuleName)
            ) &&
            (
                NameSearchType == other.NameSearchType ||
                NameSearchType != null &&
                NameSearchType.Equals(other.NameSearchType)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (RuleType != null)
            {
                hash = hash * 59 + RuleType.GetHashCode();
            }

            if (QueryType != null)
            {
                hash = hash * 59 + QueryType.GetHashCode();
            }

            if (EnabledType != null)
            {
                hash = hash * 59 + EnabledType.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (SortBy != null)
            {
                hash = hash * 59 + SortBy.GetHashCode();
            }

            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            if (RuleName != null)
            {
                hash = hash * 59 + RuleName.GetHashCode();
            }

            if (NameSearchType != null)
            {
                hash = hash * 59 + NameSearchType.GetHashCode();
            }

            return hash;
        }
    }
}
