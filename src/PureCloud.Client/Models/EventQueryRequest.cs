using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventQueryRequest
/// </summary>

public partial class EventQueryRequest : IEquatable<EventQueryRequest>
{
    /// <summary>
    /// Order of results. Default order is DESC.
    /// </summary>
    /// <value>Order of results. Default order is DESC.</value>
    
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
        /// Enum Asc for "ASC"
        /// </summary>
        [EnumMember(Value = "ASC")]
        Asc,

        /// <summary>
        /// Enum Desc for "DESC"
        /// </summary>
        [EnumMember(Value = "DESC")]
        Desc
    }
    /// <summary>
    /// Order of results. Default order is DESC.
    /// </summary>
    /// <value>Order of results. Default order is DESC.</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventQueryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EventQueryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventQueryRequest" /> class.
    /// </summary>
    /// <param name="Interval">Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="EventDefinitionIds">Filter events by a list of event definition ids.</param>
    /// <param name="SearchTerm">Only return events that contain the search term.</param>
    /// <param name="SortOrder">Order of results. Default order is DESC..</param>
    public EventQueryRequest(string Interval = null, List<string> EventDefinitionIds = null, string SearchTerm = null, SortOrderEnum? SortOrder = null)
    {
        this.Interval = Interval;
        this.EventDefinitionIds = EventDefinitionIds;
        this.SearchTerm = SearchTerm;
        this.SortOrder = SortOrder;

    }



    /// <summary>
    /// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Filter events by a list of event definition ids
    /// </summary>
    /// <value>Filter events by a list of event definition ids</value>
    [JsonPropertyName("eventDefinitionIds")]
    public List<string> EventDefinitionIds { get; set; }



    /// <summary>
    /// Only return events that contain the search term
    /// </summary>
    /// <value>Only return events that contain the search term</value>
    [JsonPropertyName("searchTerm")]
    public string SearchTerm { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventQueryRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  EventDefinitionIds: ").Append(EventDefinitionIds).Append("\n");
        sb.Append("  SearchTerm: ").Append(SearchTerm).Append("\n");
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
        return Equals(obj as EventQueryRequest);
    }

    /// <summary>
    /// Returns true if EventQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EventQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventQueryRequest other)
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
                EventDefinitionIds == other.EventDefinitionIds ||
                EventDefinitionIds != null &&
                EventDefinitionIds.SequenceEqual(other.EventDefinitionIds)
            ) &&
            (
                SearchTerm == other.SearchTerm ||
                SearchTerm != null &&
                SearchTerm.Equals(other.SearchTerm)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (EventDefinitionIds != null)
            {
                hash = hash * 59 + EventDefinitionIds.GetHashCode();
            }

            if (SearchTerm != null)
            {
                hash = hash * 59 + SearchTerm.GetHashCode();
            }

            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            return hash;
        }
    }
}
