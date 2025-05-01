using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentCopilotAsyncAggregationQuery
/// </summary>
[DataContract]
public partial class AgentCopilotAsyncAggregationQuery : IEquatable<AgentCopilotAsyncAggregationQuery>
{
    /// <summary>
    /// Gets or Sets GroupBy
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Agentassistantid for "agentAssistantId"
        /// </summary>
        [EnumMember(Value = "agentAssistantId")]
        Agentassistantid,

        /// <summary>
        /// Enum Cannedresponseid for "cannedResponseId"
        /// </summary>
        [EnumMember(Value = "cannedResponseId")]
        Cannedresponseid,

        /// <summary>
        /// Enum Cannedresponselibraryid for "cannedResponseLibraryId"
        /// </summary>
        [EnumMember(Value = "cannedResponseLibraryId")]
        Cannedresponselibraryid,

        /// <summary>
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Engagementtype for "engagementType"
        /// </summary>
        [EnumMember(Value = "engagementType")]
        Engagementtype,

        /// <summary>
        /// Enum Externalcontactid for "externalContactId"
        /// </summary>
        [EnumMember(Value = "externalContactId")]
        Externalcontactid,

        /// <summary>
        /// Enum Feedbackrating for "feedbackRating"
        /// </summary>
        [EnumMember(Value = "feedbackRating")]
        Feedbackrating,

        /// <summary>
        /// Enum Hasanswerhighlight for "hasAnswerHighlight"
        /// </summary>
        [EnumMember(Value = "hasAnswerHighlight")]
        Hasanswerhighlight,

        /// <summary>
        /// Enum Knowledgebasedocumentid for "knowledgeBaseDocumentId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentId")]
        Knowledgebasedocumentid,

        /// <summary>
        /// Enum Knowledgebasedocumentversionid for "knowledgeBaseDocumentVersionId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentVersionId")]
        Knowledgebasedocumentversionid,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Messageid for "messageId"
        /// </summary>
        [EnumMember(Value = "messageId")]
        Messageid,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Scriptid for "scriptId"
        /// </summary>
        [EnumMember(Value = "scriptId")]
        Scriptid,

        /// <summary>
        /// Enum Scriptpageid for "scriptPageId"
        /// </summary>
        [EnumMember(Value = "scriptPageId")]
        Scriptpageid,

        /// <summary>
        /// Enum Searchid for "searchId"
        /// </summary>
        [EnumMember(Value = "searchId")]
        Searchid,

        /// <summary>
        /// Enum State for "state"
        /// </summary>
        [EnumMember(Value = "state")]
        State,

        /// <summary>
        /// Enum Suggestionid for "suggestionId"
        /// </summary>
        [EnumMember(Value = "suggestionId")]
        Suggestionid,

        /// <summary>
        /// Enum Suggestiontype for "suggestionType"
        /// </summary>
        [EnumMember(Value = "suggestionType")]
        Suggestiontype,

        /// <summary>
        /// Enum Triggertype for "triggerType"
        /// </summary>
        [EnumMember(Value = "triggerType")]
        Triggertype,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid,

        /// <summary>
        /// Enum Utteranceid for "utteranceId"
        /// </summary>
        [EnumMember(Value = "utteranceId")]
        Utteranceid
    }
    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MetricsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ncannedresponsesuggestions for "nCannedResponseSuggestions"
        /// </summary>
        [EnumMember(Value = "nCannedResponseSuggestions")]
        Ncannedresponsesuggestions,

        /// <summary>
        /// Enum Ndistinctsuggestions for "nDistinctSuggestions"
        /// </summary>
        [EnumMember(Value = "nDistinctSuggestions")]
        Ndistinctsuggestions,

        /// <summary>
        /// Enum Nknowledgearticlesuggestions for "nKnowledgeArticleSuggestions"
        /// </summary>
        [EnumMember(Value = "nKnowledgeArticleSuggestions")]
        Nknowledgearticlesuggestions,

        /// <summary>
        /// Enum Nknowledgesearchsuggestions for "nKnowledgeSearchSuggestions"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchSuggestions")]
        Nknowledgesearchsuggestions,

        /// <summary>
        /// Enum Nscriptsuggestions for "nScriptSuggestions"
        /// </summary>
        [EnumMember(Value = "nScriptSuggestions")]
        Nscriptsuggestions
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AlternateTimeDimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Eventtime for "eventTime"
        /// </summary>
        [EnumMember(Value = "eventTime")]
        Eventtime
    }
    /// <summary>
    /// Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)
    /// </summary>
    /// <value>Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)</value>
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
        /// Enum Groupby for "groupBy"
        /// </summary>
        [EnumMember(Value = "groupBy")]
        Groupby,

        /// <summary>
        /// Enum Topn for "topN"
        /// </summary>
        [EnumMember(Value = "topN")]
        Topn
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    [DataMember(Name = "alternateTimeDimension", EmitDefaultValue = false)]
    public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }
    /// <summary>
    /// Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)
    /// </summary>
    /// <value>Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)</value>
    [DataMember(Name = "queryType", EmitDefaultValue = false)]
    public QueryTypeEnum? QueryType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotAsyncAggregationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentCopilotAsyncAggregationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotAsyncAggregationQuery" /> class.
    /// </summary>
    /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Granularity">Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
    /// <param name="TimeZone">Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
    /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
    /// <param name="Filter">Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters.</param>
    /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
    /// <param name="FlattenMultivaluedDimensions">Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;).</param>
    /// <param name="Views">Custom derived metric views.</param>
    /// <param name="AlternateTimeDimension">Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \&quot;eventTime\&quot; uses the actual time of the data event..</param>
    /// <param name="QueryType">Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension).</param>
    /// <param name="Limit">How many results you want in the topN list. Only applicable for topN query type..</param>
    /// <param name="PageSize">The number of results per page.</param>
    public AgentCopilotAsyncAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, AgentCopilotAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<AgentCopilotAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, QueryTypeEnum? QueryType = null, int? Limit = null, int? PageSize = null)
    {
        this.Interval = Interval;
        this.Granularity = Granularity;
        this.TimeZone = TimeZone;
        this.GroupBy = GroupBy;
        this.Filter = Filter;
        this.Metrics = Metrics;
        this.FlattenMultivaluedDimensions = FlattenMultivaluedDimensions;
        this.Views = Views;
        this.AlternateTimeDimension = AlternateTimeDimension;
        this.QueryType = QueryType;
        this.Limit = Limit;
        this.PageSize = PageSize;

    }



    /// <summary>
    /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public string Interval { get; set; }



    /// <summary>
    /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [DataMember(Name = "granularity", EmitDefaultValue = false)]
    public string Granularity { get; set; }



    /// <summary>
    /// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
    /// </summary>
    /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
    [DataMember(Name = "groupBy", EmitDefaultValue = false)]
    public List<GroupByEnum> GroupBy { get; set; }



    /// <summary>
    /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
    [DataMember(Name = "filter", EmitDefaultValue = false)]
    public AgentCopilotAggregateQueryFilter Filter { get; set; }



    /// <summary>
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    [DataMember(Name = "metrics", EmitDefaultValue = false)]
    public List<MetricsEnum> Metrics { get; set; }



    /// <summary>
    /// Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)
    /// </summary>
    /// <value>Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)</value>
    [DataMember(Name = "flattenMultivaluedDimensions", EmitDefaultValue = false)]
    public bool? FlattenMultivaluedDimensions { get; set; }



    /// <summary>
    /// Custom derived metric views
    /// </summary>
    /// <value>Custom derived metric views</value>
    [DataMember(Name = "views", EmitDefaultValue = false)]
    public List<AgentCopilotAggregationView> Views { get; set; }







    /// <summary>
    /// How many results you want in the topN list. Only applicable for topN query type.
    /// </summary>
    /// <value>How many results you want in the topN list. Only applicable for topN query type.</value>
    [DataMember(Name = "limit", EmitDefaultValue = false)]
    public int? Limit { get; set; }



    /// <summary>
    /// The number of results per page
    /// </summary>
    /// <value>The number of results per page</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentCopilotAsyncAggregationQuery {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
        sb.Append("  Views: ").Append(Views).Append("\n");
        sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  Limit: ").Append(Limit).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
        return Equals(obj as AgentCopilotAsyncAggregationQuery);
    }

    /// <summary>
    /// Returns true if AgentCopilotAsyncAggregationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentCopilotAsyncAggregationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentCopilotAsyncAggregationQuery other)
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
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
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
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                FlattenMultivaluedDimensions != null &&
                FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
            ) &&
            (
                Views == other.Views ||
                Views != null &&
                Views.SequenceEqual(other.Views)
            ) &&
            (
                AlternateTimeDimension == other.AlternateTimeDimension ||
                AlternateTimeDimension != null &&
                AlternateTimeDimension.Equals(other.AlternateTimeDimension)
            ) &&
            (
                QueryType == other.QueryType ||
                QueryType != null &&
                QueryType.Equals(other.QueryType)
            ) &&
            (
                Limit == other.Limit ||
                Limit != null &&
                Limit.Equals(other.Limit)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
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

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (GroupBy != null)
            {
                hash = hash * 59 + GroupBy.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (FlattenMultivaluedDimensions != null)
            {
                hash = hash * 59 + FlattenMultivaluedDimensions.GetHashCode();
            }

            if (Views != null)
            {
                hash = hash * 59 + Views.GetHashCode();
            }

            if (AlternateTimeDimension != null)
            {
                hash = hash * 59 + AlternateTimeDimension.GetHashCode();
            }

            if (QueryType != null)
            {
                hash = hash * 59 + QueryType.GetHashCode();
            }

            if (Limit != null)
            {
                hash = hash * 59 + Limit.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            return hash;
        }
    }
}
