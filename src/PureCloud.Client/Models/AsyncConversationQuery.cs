using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AsyncConversationQuery
{
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    public AsyncConversationQueryOrderEnum? Order { get; set; }

    /// <summary>
    /// Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart
    /// </summary>
    /// <value>Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart</value>
    public AsyncConversationQueryOrderByEnum? OrderBy { get; set; }

    /// <summary>
    /// Filters that target conversation-level data
    /// </summary>
    /// <value>Filters that target conversation-level data</value>
    public IEnumerable<ConversationDetailQueryFilter> ConversationFilters { get; set; }

    /// <summary>
    /// Filters that target individual segments within a conversation
    /// </summary>
    /// <value>Filters that target individual segments within a conversation</value>
    public IEnumerable<SegmentDetailQueryFilter> SegmentFilters { get; set; }

    /// <summary>
    /// Filters that target evaluations
    /// </summary>
    /// <value>Filters that target evaluations</value>
    public IEnumerable<EvaluationDetailQueryFilter> EvaluationFilters { get; set; }

    /// <summary>
    /// Filters that target surveys
    /// </summary>
    /// <value>Filters that target surveys</value>
    public IEnumerable<SurveyDetailQueryFilter> SurveyFilters { get; set; }

    /// <summary>
    /// Filters that target resolutions
    /// </summary>
    /// <value>Filters that target resolutions</value>
    public IEnumerable<ResolutionDetailQueryFilter> ResolutionFilters { get; set; }

    /// <summary>
    /// Specifies the date and time range of data being queried. Results will include all conversations that had activity during the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the date and time range of data being queried. Results will include all conversations that had activity during the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// Specify number of results to be returned
    /// </summary>
    /// <value>Specify number of results to be returned</value>
    public int? Limit { get; set; }

    /// <summary>
    /// Add a filter to only include conversations that started after the beginning of the interval start date (UTC)
    /// </summary>
    /// <value>Add a filter to only include conversations that started after the beginning of the interval start date (UTC)</value>
    public bool? StartOfDayIntervalMatching { get; set; }
}
