using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserDetailsQuery
/// </summary>

public partial class UserDetailsQuery : IEquatable<UserDetailsQuery>
{
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
    /// Initializes a new instance of the <see cref="UserDetailsQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserDetailsQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserDetailsQuery" /> class.
    /// </summary>
    /// <param name="Interval">Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="UserFilters">Filters that target the users to retrieve data for.</param>
    /// <param name="PresenceFilters">Filters that target system and organization presence-level data.</param>
    /// <param name="RoutingStatusFilters">Filters that target agent routing status-level data.</param>
    /// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
    /// <param name="PresenceAggregations">Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters.</param>
    /// <param name="RoutingStatusAggregations">Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters.</param>
    /// <param name="Paging">Page size and number to control iterating through large result sets. Default page size is 25.</param>
    public UserDetailsQuery(string Interval = null, List<UserDetailQueryFilter> UserFilters = null, List<PresenceDetailQueryFilter> PresenceFilters = null, List<RoutingStatusDetailQueryFilter> RoutingStatusFilters = null, OrderEnum? Order = null, List<AnalyticsQueryAggregation> PresenceAggregations = null, List<AnalyticsQueryAggregation> RoutingStatusAggregations = null, PagingSpec Paging = null)
    {
        this.Interval = Interval;
        this.UserFilters = UserFilters;
        this.PresenceFilters = PresenceFilters;
        this.RoutingStatusFilters = RoutingStatusFilters;
        this.Order = Order;
        this.PresenceAggregations = PresenceAggregations;
        this.RoutingStatusAggregations = RoutingStatusAggregations;
        this.Paging = Paging;

    }



    /// <summary>
    /// Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Filters that target the users to retrieve data for
    /// </summary>
    /// <value>Filters that target the users to retrieve data for</value>
    [JsonPropertyName("userFilters")]
    public List<UserDetailQueryFilter> UserFilters { get; set; }



    /// <summary>
    /// Filters that target system and organization presence-level data
    /// </summary>
    /// <value>Filters that target system and organization presence-level data</value>
    [JsonPropertyName("presenceFilters")]
    public List<PresenceDetailQueryFilter> PresenceFilters { get; set; }



    /// <summary>
    /// Filters that target agent routing status-level data
    /// </summary>
    /// <value>Filters that target agent routing status-level data</value>
    [JsonPropertyName("routingStatusFilters")]
    public List<RoutingStatusDetailQueryFilter> RoutingStatusFilters { get; set; }





    /// <summary>
    /// Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters
    /// </summary>
    /// <value>Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters</value>
    [JsonPropertyName("presenceAggregations")]
    public List<AnalyticsQueryAggregation> PresenceAggregations { get; set; }



    /// <summary>
    /// Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters
    /// </summary>
    /// <value>Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters</value>
    [JsonPropertyName("routingStatusAggregations")]
    public List<AnalyticsQueryAggregation> RoutingStatusAggregations { get; set; }



    /// <summary>
    /// Page size and number to control iterating through large result sets. Default page size is 25
    /// </summary>
    /// <value>Page size and number to control iterating through large result sets. Default page size is 25</value>
    [JsonPropertyName("paging")]
    public PagingSpec Paging { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserDetailsQuery {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  UserFilters: ").Append(UserFilters).Append("\n");
        sb.Append("  PresenceFilters: ").Append(PresenceFilters).Append("\n");
        sb.Append("  RoutingStatusFilters: ").Append(RoutingStatusFilters).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  PresenceAggregations: ").Append(PresenceAggregations).Append("\n");
        sb.Append("  RoutingStatusAggregations: ").Append(RoutingStatusAggregations).Append("\n");
        sb.Append("  Paging: ").Append(Paging).Append("\n");
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
        return Equals(obj as UserDetailsQuery);
    }

    /// <summary>
    /// Returns true if UserDetailsQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of UserDetailsQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserDetailsQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                UserFilters == other.UserFilters ||
                UserFilters != null &&
                UserFilters.SequenceEqual(other.UserFilters)
            ) &&
            (
                PresenceFilters == other.PresenceFilters ||
                PresenceFilters != null &&
                PresenceFilters.SequenceEqual(other.PresenceFilters)
            ) &&
            (
                RoutingStatusFilters == other.RoutingStatusFilters ||
                RoutingStatusFilters != null &&
                RoutingStatusFilters.SequenceEqual(other.RoutingStatusFilters)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
            ) &&
            (
                PresenceAggregations == other.PresenceAggregations ||
                PresenceAggregations != null &&
                PresenceAggregations.SequenceEqual(other.PresenceAggregations)
            ) &&
            (
                RoutingStatusAggregations == other.RoutingStatusAggregations ||
                RoutingStatusAggregations != null &&
                RoutingStatusAggregations.SequenceEqual(other.RoutingStatusAggregations)
            ) &&
            (
                Paging == other.Paging ||
                Paging != null &&
                Paging.Equals(other.Paging)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (UserFilters != null)
            {
                hash = hash * 59 + UserFilters.GetHashCode();
            }

            if (PresenceFilters != null)
            {
                hash = hash * 59 + PresenceFilters.GetHashCode();
            }

            if (RoutingStatusFilters != null)
            {
                hash = hash * 59 + RoutingStatusFilters.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            if (PresenceAggregations != null)
            {
                hash = hash * 59 + PresenceAggregations.GetHashCode();
            }

            if (RoutingStatusAggregations != null)
            {
                hash = hash * 59 + RoutingStatusAggregations.GetHashCode();
            }

            if (Paging != null)
            {
                hash = hash * 59 + Paging.GetHashCode();
            }

            return hash;
        }
    }
}
