using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutingActivityQuery
/// </summary>

public partial class RoutingActivityQuery : IEquatable<RoutingActivityQuery>
{
    /// <summary>
    /// Gets or Sets GroupBy
    /// </summary>
    
    public enum GroupByEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid
    }
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    
    public enum OrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Asc for "asc"
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc,

        /// <summary>
        /// Enum Desc for "desc"
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc,

        /// <summary>
        /// Enum Unordered for "unordered"
        /// </summary>
        [EnumMember(Value = "unordered")]
        Unordered
    }
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    [JsonPropertyName("order")]
    public OrderEnum? Order { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingActivityQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RoutingActivityQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingActivityQuery" /> class.
    /// </summary>
    /// <param name="Metrics">List of requested metrics (required).</param>
    /// <param name="GroupBy">Dimension(s) to group by (required).</param>
    /// <param name="Filter">Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters.</param>
    /// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
    public RoutingActivityQuery(List<RoutingActivityQueryMetric> Metrics = null, List<GroupByEnum> GroupBy = null, RoutingActivityQueryFilter Filter = null, OrderEnum? Order = null)
    {
        this.Metrics = Metrics;
        this.GroupBy = GroupBy;
        this.Filter = Filter;
        this.Order = Order;

    }



    /// <summary>
    /// List of requested metrics
    /// </summary>
    /// <value>List of requested metrics</value>
    [JsonPropertyName("metrics")]
    public List<RoutingActivityQueryMetric> Metrics { get; set; }



    /// <summary>
    /// Dimension(s) to group by
    /// </summary>
    /// <value>Dimension(s) to group by</value>
    [JsonPropertyName("groupBy")]
    public List<GroupByEnum> GroupBy { get; set; }



    /// <summary>
    /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
    [JsonPropertyName("filter")]
    public RoutingActivityQueryFilter Filter { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutingActivityQuery {\n");

        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
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
        return Equals(obj as RoutingActivityQuery);
    }

    /// <summary>
    /// Returns true if RoutingActivityQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutingActivityQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutingActivityQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                GroupBy == other.GroupBy ||
                GroupBy != null &&
                GroupBy.SequenceEqual(other.GroupBy)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
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
            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (GroupBy != null)
            {
                hash = hash * 59 + GroupBy.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            return hash;
        }
    }
}
