using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AsyncConversationQuery
/// </summary>
[DataContract]
public partial class AsyncConversationQuery : IEquatable<AsyncConversationQuery>
{
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart
    /// </summary>
    /// <value>Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderByEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Conversationstart for "conversationStart"
        /// </summary>
        [EnumMember(Value = "conversationStart")]
        Conversationstart,

        /// <summary>
        /// Enum Conversationend for "conversationEnd"
        /// </summary>
        [EnumMember(Value = "conversationEnd")]
        Conversationend,

        /// <summary>
        /// Enum Segmentstart for "segmentStart"
        /// </summary>
        [EnumMember(Value = "segmentStart")]
        Segmentstart,

        /// <summary>
        /// Enum Segmentend for "segmentEnd"
        /// </summary>
        [EnumMember(Value = "segmentEnd")]
        Segmentend
    }
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    [DataMember(Name = "order", EmitDefaultValue = false)]
    public OrderEnum? Order { get; set; }
    /// <summary>
    /// Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart
    /// </summary>
    /// <value>Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart</value>
    [DataMember(Name = "orderBy", EmitDefaultValue = false)]
    public OrderByEnum? OrderBy { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AsyncConversationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AsyncConversationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AsyncConversationQuery" /> class.
    /// </summary>
    /// <param name="ConversationFilters">Filters that target conversation-level data.</param>
    /// <param name="SegmentFilters">Filters that target individual segments within a conversation.</param>
    /// <param name="EvaluationFilters">Filters that target evaluations.</param>
    /// <param name="SurveyFilters">Filters that target surveys.</param>
    /// <param name="ResolutionFilters">Filters that target resolutions.</param>
    /// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
    /// <param name="OrderBy">Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart.</param>
    /// <param name="Interval">Specifies the date and time range of data being queried. Results will include all conversations that had activity during the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Limit">Specify number of results to be returned.</param>
    /// <param name="StartOfDayIntervalMatching">Add a filter to only include conversations that started after the beginning of the interval start date (UTC).</param>
    public AsyncConversationQuery(List<ConversationDetailQueryFilter> ConversationFilters = null, List<SegmentDetailQueryFilter> SegmentFilters = null, List<EvaluationDetailQueryFilter> EvaluationFilters = null, List<SurveyDetailQueryFilter> SurveyFilters = null, List<ResolutionDetailQueryFilter> ResolutionFilters = null, OrderEnum? Order = null, OrderByEnum? OrderBy = null, string Interval = null, int? Limit = null, bool? StartOfDayIntervalMatching = null)
    {
        this.ConversationFilters = ConversationFilters;
        this.SegmentFilters = SegmentFilters;
        this.EvaluationFilters = EvaluationFilters;
        this.SurveyFilters = SurveyFilters;
        this.ResolutionFilters = ResolutionFilters;
        this.Order = Order;
        this.OrderBy = OrderBy;
        this.Interval = Interval;
        this.Limit = Limit;
        this.StartOfDayIntervalMatching = StartOfDayIntervalMatching;

    }



    /// <summary>
    /// Filters that target conversation-level data
    /// </summary>
    /// <value>Filters that target conversation-level data</value>
    [DataMember(Name = "conversationFilters", EmitDefaultValue = false)]
    public List<ConversationDetailQueryFilter> ConversationFilters { get; set; }



    /// <summary>
    /// Filters that target individual segments within a conversation
    /// </summary>
    /// <value>Filters that target individual segments within a conversation</value>
    [DataMember(Name = "segmentFilters", EmitDefaultValue = false)]
    public List<SegmentDetailQueryFilter> SegmentFilters { get; set; }



    /// <summary>
    /// Filters that target evaluations
    /// </summary>
    /// <value>Filters that target evaluations</value>
    [DataMember(Name = "evaluationFilters", EmitDefaultValue = false)]
    public List<EvaluationDetailQueryFilter> EvaluationFilters { get; set; }



    /// <summary>
    /// Filters that target surveys
    /// </summary>
    /// <value>Filters that target surveys</value>
    [DataMember(Name = "surveyFilters", EmitDefaultValue = false)]
    public List<SurveyDetailQueryFilter> SurveyFilters { get; set; }



    /// <summary>
    /// Filters that target resolutions
    /// </summary>
    /// <value>Filters that target resolutions</value>
    [DataMember(Name = "resolutionFilters", EmitDefaultValue = false)]
    public List<ResolutionDetailQueryFilter> ResolutionFilters { get; set; }







    /// <summary>
    /// Specifies the date and time range of data being queried. Results will include all conversations that had activity during the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the date and time range of data being queried. Results will include all conversations that had activity during the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public string Interval { get; set; }



    /// <summary>
    /// Specify number of results to be returned
    /// </summary>
    /// <value>Specify number of results to be returned</value>
    [DataMember(Name = "limit", EmitDefaultValue = false)]
    public int? Limit { get; set; }



    /// <summary>
    /// Add a filter to only include conversations that started after the beginning of the interval start date (UTC)
    /// </summary>
    /// <value>Add a filter to only include conversations that started after the beginning of the interval start date (UTC)</value>
    [DataMember(Name = "startOfDayIntervalMatching", EmitDefaultValue = false)]
    public bool? StartOfDayIntervalMatching { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AsyncConversationQuery {\n");

        sb.Append("  ConversationFilters: ").Append(ConversationFilters).Append("\n");
        sb.Append("  SegmentFilters: ").Append(SegmentFilters).Append("\n");
        sb.Append("  EvaluationFilters: ").Append(EvaluationFilters).Append("\n");
        sb.Append("  SurveyFilters: ").Append(SurveyFilters).Append("\n");
        sb.Append("  ResolutionFilters: ").Append(ResolutionFilters).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Limit: ").Append(Limit).Append("\n");
        sb.Append("  StartOfDayIntervalMatching: ").Append(StartOfDayIntervalMatching).Append("\n");
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
        return Equals(obj as AsyncConversationQuery);
    }

    /// <summary>
    /// Returns true if AsyncConversationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of AsyncConversationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AsyncConversationQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationFilters == other.ConversationFilters ||
                ConversationFilters != null &&
                ConversationFilters.SequenceEqual(other.ConversationFilters)
            ) &&
            (
                SegmentFilters == other.SegmentFilters ||
                SegmentFilters != null &&
                SegmentFilters.SequenceEqual(other.SegmentFilters)
            ) &&
            (
                EvaluationFilters == other.EvaluationFilters ||
                EvaluationFilters != null &&
                EvaluationFilters.SequenceEqual(other.EvaluationFilters)
            ) &&
            (
                SurveyFilters == other.SurveyFilters ||
                SurveyFilters != null &&
                SurveyFilters.SequenceEqual(other.SurveyFilters)
            ) &&
            (
                ResolutionFilters == other.ResolutionFilters ||
                ResolutionFilters != null &&
                ResolutionFilters.SequenceEqual(other.ResolutionFilters)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
            ) &&
            (
                OrderBy == other.OrderBy ||
                OrderBy != null &&
                OrderBy.Equals(other.OrderBy)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Limit == other.Limit ||
                Limit != null &&
                Limit.Equals(other.Limit)
            ) &&
            (
                StartOfDayIntervalMatching == other.StartOfDayIntervalMatching ||
                StartOfDayIntervalMatching != null &&
                StartOfDayIntervalMatching.Equals(other.StartOfDayIntervalMatching)
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
            if (ConversationFilters != null)
            {
                hash = hash * 59 + ConversationFilters.GetHashCode();
            }

            if (SegmentFilters != null)
            {
                hash = hash * 59 + SegmentFilters.GetHashCode();
            }

            if (EvaluationFilters != null)
            {
                hash = hash * 59 + EvaluationFilters.GetHashCode();
            }

            if (SurveyFilters != null)
            {
                hash = hash * 59 + SurveyFilters.GetHashCode();
            }

            if (ResolutionFilters != null)
            {
                hash = hash * 59 + ResolutionFilters.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            if (OrderBy != null)
            {
                hash = hash * 59 + OrderBy.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Limit != null)
            {
                hash = hash * 59 + Limit.GetHashCode();
            }

            if (StartOfDayIntervalMatching != null)
            {
                hash = hash * 59 + StartOfDayIntervalMatching.GetHashCode();
            }

            return hash;
        }
    }
}
