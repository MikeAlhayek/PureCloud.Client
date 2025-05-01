using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// KnowledgeAsyncAggregationQuery
/// </summary>
[DataContract]
public partial class KnowledgeAsyncAggregationQuery : IEquatable<KnowledgeAsyncAggregationQuery>
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
        /// Enum Appdeploymentid for "appDeploymentId"
        /// </summary>
        [EnumMember(Value = "appDeploymentId")]
        Appdeploymentid,

        /// <summary>
        /// Enum Apptype for "appType"
        /// </summary>
        [EnumMember(Value = "appType")]
        Apptype,

        /// <summary>
        /// Enum Botflowid for "botFlowId"
        /// </summary>
        [EnumMember(Value = "botFlowId")]
        Botflowid,

        /// <summary>
        /// Enum Conversationchanneltype for "conversationChannelType"
        /// </summary>
        [EnumMember(Value = "conversationChannelType")]
        Conversationchanneltype,

        /// <summary>
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Documentengagementtype for "documentEngagementType"
        /// </summary>
        [EnumMember(Value = "documentEngagementType")]
        Documentengagementtype,

        /// <summary>
        /// Enum Externalcontactid for "externalContactId"
        /// </summary>
        [EnumMember(Value = "externalContactId")]
        Externalcontactid,

        /// <summary>
        /// Enum Feedbackcategory for "feedbackCategory"
        /// </summary>
        [EnumMember(Value = "feedbackCategory")]
        Feedbackcategory,

        /// <summary>
        /// Enum Feedbackid for "feedbackId"
        /// </summary>
        [EnumMember(Value = "feedbackId")]
        Feedbackid,

        /// <summary>
        /// Enum Feedbackrating for "feedbackRating"
        /// </summary>
        [EnumMember(Value = "feedbackRating")]
        Feedbackrating,

        /// <summary>
        /// Enum Feedbackratingtype for "feedbackRatingType"
        /// </summary>
        [EnumMember(Value = "feedbackRatingType")]
        Feedbackratingtype,

        /// <summary>
        /// Enum Feedbackratingvalue for "feedbackRatingValue"
        /// </summary>
        [EnumMember(Value = "feedbackRatingValue")]
        Feedbackratingvalue,

        /// <summary>
        /// Enum Feedbackreason for "feedbackReason"
        /// </summary>
        [EnumMember(Value = "feedbackReason")]
        Feedbackreason,

        /// <summary>
        /// Enum Feedbacktype for "feedbackType"
        /// </summary>
        [EnumMember(Value = "feedbackType")]
        Feedbacktype,

        /// <summary>
        /// Enum Hascomment for "hasComment"
        /// </summary>
        [EnumMember(Value = "hasComment")]
        Hascomment,

        /// <summary>
        /// Enum Hassearch for "hasSearch"
        /// </summary>
        [EnumMember(Value = "hasSearch")]
        Hassearch,

        /// <summary>
        /// Enum Knowledgebasedocumentid for "knowledgeBaseDocumentId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentId")]
        Knowledgebasedocumentid,

        /// <summary>
        /// Enum Knowledgebasedocumentvariationid for "knowledgeBaseDocumentVariationId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentVariationId")]
        Knowledgebasedocumentvariationid,

        /// <summary>
        /// Enum Knowledgebasedocumentversionid for "knowledgeBaseDocumentVersionId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentVersionId")]
        Knowledgebasedocumentversionid,

        /// <summary>
        /// Enum Knowledgebaseid for "knowledgeBaseId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseId")]
        Knowledgebaseid,

        /// <summary>
        /// Enum Languagecode for "languageCode"
        /// </summary>
        [EnumMember(Value = "languageCode")]
        Languagecode,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Presenteddocumentscount for "presentedDocumentsCount"
        /// </summary>
        [EnumMember(Value = "presentedDocumentsCount")]
        Presenteddocumentscount,

        /// <summary>
        /// Enum Querytype for "queryType"
        /// </summary>
        [EnumMember(Value = "queryType")]
        Querytype,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Searchid for "searchId"
        /// </summary>
        [EnumMember(Value = "searchId")]
        Searchid,

        /// <summary>
        /// Enum Searchquery for "searchQuery"
        /// </summary>
        [EnumMember(Value = "searchQuery")]
        Searchquery,

        /// <summary>
        /// Enum Selfserved for "selfServed"
        /// </summary>
        [EnumMember(Value = "selfServed")]
        Selfserved,

        /// <summary>
        /// Enum Sessionid for "sessionId"
        /// </summary>
        [EnumMember(Value = "sessionId")]
        Sessionid,

        /// <summary>
        /// Enum Surfacingmethod for "surfacingMethod"
        /// </summary>
        [EnumMember(Value = "surfacingMethod")]
        Surfacingmethod,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid
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
        /// Enum Ndistinctknowledgesessions for "nDistinctKnowledgeSessions"
        /// </summary>
        [EnumMember(Value = "nDistinctKnowledgeSessions")]
        Ndistinctknowledgesessions,

        /// <summary>
        /// Enum Nknowledgedocumentcopied for "nKnowledgeDocumentCopied"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentCopied")]
        Nknowledgedocumentcopied,

        /// <summary>
        /// Enum Nknowledgedocumentfeedback for "nKnowledgeDocumentFeedback"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentFeedback")]
        Nknowledgedocumentfeedback,

        /// <summary>
        /// Enum Nknowledgedocumentpresented for "nKnowledgeDocumentPresented"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentPresented")]
        Nknowledgedocumentpresented,

        /// <summary>
        /// Enum Nknowledgedocumentsurfaced for "nKnowledgeDocumentSurfaced"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentSurfaced")]
        Nknowledgedocumentsurfaced,

        /// <summary>
        /// Enum Nknowledgedocumentviewed for "nKnowledgeDocumentViewed"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentViewed")]
        Nknowledgedocumentviewed,

        /// <summary>
        /// Enum Nknowledgesearch for "nKnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearch")]
        Nknowledgesearch,

        /// <summary>
        /// Enum Nknowledgesearchanswered for "nKnowledgeSearchAnswered"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchAnswered")]
        Nknowledgesearchanswered,

        /// <summary>
        /// Enum Nknowledgesearchfeedback for "nKnowledgeSearchFeedback"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchFeedback")]
        Nknowledgesearchfeedback,

        /// <summary>
        /// Enum Nknowledgesearchunanswered for "nKnowledgeSearchUnanswered"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchUnanswered")]
        Nknowledgesearchunanswered,

        /// <summary>
        /// Enum Nknowledgesessions for "nKnowledgeSessions"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSessions")]
        Nknowledgesessions,

        /// <summary>
        /// Enum Oknowledgedocumentquery for "oKnowledgeDocumentQuery"
        /// </summary>
        [EnumMember(Value = "oKnowledgeDocumentQuery")]
        Oknowledgedocumentquery,

        /// <summary>
        /// Enum Oknowledgedocumentqueryselfserved for "oKnowledgeDocumentQuerySelfServed"
        /// </summary>
        [EnumMember(Value = "oKnowledgeDocumentQuerySelfServed")]
        Oknowledgedocumentqueryselfserved,

        /// <summary>
        /// Enum Oknowledgesearch for "oKnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "oKnowledgeSearch")]
        Oknowledgesearch
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
    /// Initializes a new instance of the <see cref="KnowledgeAsyncAggregationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeAsyncAggregationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAsyncAggregationQuery" /> class.
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
    public KnowledgeAsyncAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, KnowledgeAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<KnowledgeAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, QueryTypeEnum? QueryType = null, int? Limit = null, int? PageSize = null)
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
    public KnowledgeAggregateQueryFilter Filter { get; set; }



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
    public List<KnowledgeAggregationView> Views { get; set; }







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
        sb.Append("class KnowledgeAsyncAggregationQuery {\n");

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
        return this.Equals(obj as KnowledgeAsyncAggregationQuery);
    }

    /// <summary>
    /// Returns true if KnowledgeAsyncAggregationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAsyncAggregationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAsyncAggregationQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Interval == other.Interval ||
                this.Interval != null &&
                this.Interval.Equals(other.Interval)
            ) &&
            (
                this.Granularity == other.Granularity ||
                this.Granularity != null &&
                this.Granularity.Equals(other.Granularity)
            ) &&
            (
                this.TimeZone == other.TimeZone ||
                this.TimeZone != null &&
                this.TimeZone.Equals(other.TimeZone)
            ) &&
            (
                this.GroupBy == other.GroupBy ||
                this.GroupBy != null &&
                this.GroupBy.SequenceEqual(other.GroupBy)
            ) &&
            (
                this.Filter == other.Filter ||
                this.Filter != null &&
                this.Filter.Equals(other.Filter)
            ) &&
            (
                this.Metrics == other.Metrics ||
                this.Metrics != null &&
                this.Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                this.FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                this.FlattenMultivaluedDimensions != null &&
                this.FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
            ) &&
            (
                this.Views == other.Views ||
                this.Views != null &&
                this.Views.SequenceEqual(other.Views)
            ) &&
            (
                this.AlternateTimeDimension == other.AlternateTimeDimension ||
                this.AlternateTimeDimension != null &&
                this.AlternateTimeDimension.Equals(other.AlternateTimeDimension)
            ) &&
            (
                this.QueryType == other.QueryType ||
                this.QueryType != null &&
                this.QueryType.Equals(other.QueryType)
            ) &&
            (
                this.Limit == other.Limit ||
                this.Limit != null &&
                this.Limit.Equals(other.Limit)
            ) &&
            (
                this.PageSize == other.PageSize ||
                this.PageSize != null &&
                this.PageSize.Equals(other.PageSize)
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
            if (this.Interval != null)
            {
                hash = hash * 59 + this.Interval.GetHashCode();
            }

            if (this.Granularity != null)
            {
                hash = hash * 59 + this.Granularity.GetHashCode();
            }

            if (this.TimeZone != null)
            {
                hash = hash * 59 + this.TimeZone.GetHashCode();
            }

            if (this.GroupBy != null)
            {
                hash = hash * 59 + this.GroupBy.GetHashCode();
            }

            if (this.Filter != null)
            {
                hash = hash * 59 + this.Filter.GetHashCode();
            }

            if (this.Metrics != null)
            {
                hash = hash * 59 + this.Metrics.GetHashCode();
            }

            if (this.FlattenMultivaluedDimensions != null)
            {
                hash = hash * 59 + this.FlattenMultivaluedDimensions.GetHashCode();
            }

            if (this.Views != null)
            {
                hash = hash * 59 + this.Views.GetHashCode();
            }

            if (this.AlternateTimeDimension != null)
            {
                hash = hash * 59 + this.AlternateTimeDimension.GetHashCode();
            }

            if (this.QueryType != null)
            {
                hash = hash * 59 + this.QueryType.GetHashCode();
            }

            if (this.Limit != null)
            {
                hash = hash * 59 + this.Limit.GetHashCode();
            }

            if (this.PageSize != null)
            {
                hash = hash * 59 + this.PageSize.GetHashCode();
            }

            return hash;
        }
    }
}
