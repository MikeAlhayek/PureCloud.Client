using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GetAlertQuery
/// </summary>
[DataContract]
public partial class GetAlertQuery : IEquatable<GetAlertQuery>
{
    /// <summary>
    /// The rule type of the alerts the query will return
    /// </summary>
    /// <value>The rule type of the alerts the query will return</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The status of the alerts the query will return.
    /// </summary>
    /// <value>The status of the alerts the query will return.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AlertStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All
    }
    /// <summary>
    /// The view status of the alerts the query will return.
    /// </summary>
    /// <value>The view status of the alerts the query will return.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ViewedStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unread for "Unread"
        /// </summary>
        [EnumMember(Value = "Unread")]
        Unread,

        /// <summary>
        /// Enum Read for "Read"
        /// </summary>
        [EnumMember(Value = "Read")]
        Read,

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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Datestart for "DateStart"
        /// </summary>
        [EnumMember(Value = "DateStart")]
        Datestart
    }
    /// <summary>
    /// The order in which response will be sorted.  The accepted choices are Asc and Desc
    /// </summary>
    /// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The rule type of the alerts the query will return
    /// </summary>
    /// <value>The rule type of the alerts the query will return</value>
    [DataMember(Name = "ruleType", EmitDefaultValue = false)]
    public RuleTypeEnum? RuleType { get; set; }
    /// <summary>
    /// The type of query being performed.
    /// </summary>
    /// <value>The type of query being performed.</value>
    [DataMember(Name = "queryType", EmitDefaultValue = false)]
    public QueryTypeEnum? QueryType { get; set; }
    /// <summary>
    /// The status of the alerts the query will return.
    /// </summary>
    /// <value>The status of the alerts the query will return.</value>
    [DataMember(Name = "alertStatus", EmitDefaultValue = false)]
    public AlertStatusEnum? AlertStatus { get; set; }
    /// <summary>
    /// The view status of the alerts the query will return.
    /// </summary>
    /// <value>The view status of the alerts the query will return.</value>
    [DataMember(Name = "viewedStatus", EmitDefaultValue = false)]
    public ViewedStatusEnum? ViewedStatus { get; set; }
    /// <summary>
    /// The field to sort responses by.  The accepted choices are Name and DateStart
    /// </summary>
    /// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
    [DataMember(Name = "sortBy", EmitDefaultValue = false)]
    public SortByEnum? SortBy { get; set; }
    /// <summary>
    /// The order in which response will be sorted.  The accepted choices are Asc and Desc
    /// </summary>
    /// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
    [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
    public SortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetAlertQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GetAlertQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetAlertQuery" /> class.
    /// </summary>
    /// <param name="RuleType">The rule type of the alerts the query will return (required).</param>
    /// <param name="QueryType">The type of query being performed. (required).</param>
    /// <param name="AlertStatus">The status of the alerts the query will return..</param>
    /// <param name="ViewedStatus">The view status of the alerts the query will return..</param>
    /// <param name="PageNumber">The page number of the queried response.</param>
    /// <param name="PageSize">The number of entities to return of the queried response.  The max is 25.</param>
    /// <param name="SortBy">The field to sort responses by.  The accepted choices are Name and DateStart.</param>
    /// <param name="SortOrder">The order in which response will be sorted.  The accepted choices are Asc and Desc.</param>
    public GetAlertQuery(RuleTypeEnum? RuleType = null, QueryTypeEnum? QueryType = null, AlertStatusEnum? AlertStatus = null, ViewedStatusEnum? ViewedStatus = null, int? PageNumber = null, int? PageSize = null, SortByEnum? SortBy = null, SortOrderEnum? SortOrder = null)
    {
        this.RuleType = RuleType;
        this.QueryType = QueryType;
        this.AlertStatus = AlertStatus;
        this.ViewedStatus = ViewedStatus;
        this.PageNumber = PageNumber;
        this.PageSize = PageSize;
        this.SortBy = SortBy;
        this.SortOrder = SortOrder;

    }











    /// <summary>
    /// The page number of the queried response
    /// </summary>
    /// <value>The page number of the queried response</value>
    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }



    /// <summary>
    /// The number of entities to return of the queried response.  The max is 25
    /// </summary>
    /// <value>The number of entities to return of the queried response.  The max is 25</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetAlertQuery {\n");

        sb.Append("  RuleType: ").Append(RuleType).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  AlertStatus: ").Append(AlertStatus).Append("\n");
        sb.Append("  ViewedStatus: ").Append(ViewedStatus).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  SortBy: ").Append(SortBy).Append("\n");
        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
        return Equals(obj as GetAlertQuery);
    }

    /// <summary>
    /// Returns true if GetAlertQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of GetAlertQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GetAlertQuery other)
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
                AlertStatus == other.AlertStatus ||
                AlertStatus != null &&
                AlertStatus.Equals(other.AlertStatus)
            ) &&
            (
                ViewedStatus == other.ViewedStatus ||
                ViewedStatus != null &&
                ViewedStatus.Equals(other.ViewedStatus)
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

            if (AlertStatus != null)
            {
                hash = hash * 59 + AlertStatus.GetHashCode();
            }

            if (ViewedStatus != null)
            {
                hash = hash * 59 + ViewedStatus.GetHashCode();
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

            return hash;
        }
    }
}
