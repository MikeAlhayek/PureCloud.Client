using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyAsyncAggregationQuery
/// </summary>

public partial class SurveyAsyncAggregationQuery : IEquatable<SurveyAsyncAggregationQuery>
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
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Divisionid for "divisionId"
        /// </summary>
        [EnumMember(Value = "divisionId")]
        Divisionid,

        /// <summary>
        /// Enum Externalcontactid for "externalContactId"
        /// </summary>
        [EnumMember(Value = "externalContactId")]
        Externalcontactid,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Requestedlanguageid for "requestedLanguageId"
        /// </summary>
        [EnumMember(Value = "requestedLanguageId")]
        Requestedlanguageid,

        /// <summary>
        /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
        /// </summary>
        [EnumMember(Value = "requestedRoutingSkillId")]
        Requestedroutingskillid,

        /// <summary>
        /// Enum Surveyanswerid for "surveyAnswerId"
        /// </summary>
        [EnumMember(Value = "surveyAnswerId")]
        Surveyanswerid,

        /// <summary>
        /// Enum Surveyerrorreason for "surveyErrorReason"
        /// </summary>
        [EnumMember(Value = "surveyErrorReason")]
        Surveyerrorreason,

        /// <summary>
        /// Enum Surveyformcontextid for "surveyFormContextId"
        /// </summary>
        [EnumMember(Value = "surveyFormContextId")]
        Surveyformcontextid,

        /// <summary>
        /// Enum Surveyformid for "surveyFormId"
        /// </summary>
        [EnumMember(Value = "surveyFormId")]
        Surveyformid,

        /// <summary>
        /// Enum Surveyformname for "surveyFormName"
        /// </summary>
        [EnumMember(Value = "surveyFormName")]
        Surveyformname,

        /// <summary>
        /// Enum Surveyid for "surveyId"
        /// </summary>
        [EnumMember(Value = "surveyId")]
        Surveyid,

        /// <summary>
        /// Enum Surveypartialresponse for "surveyPartialResponse"
        /// </summary>
        [EnumMember(Value = "surveyPartialResponse")]
        Surveypartialresponse,

        /// <summary>
        /// Enum Surveypreviousstatus for "surveyPreviousStatus"
        /// </summary>
        [EnumMember(Value = "surveyPreviousStatus")]
        Surveypreviousstatus,

        /// <summary>
        /// Enum Surveypromoterscore for "surveyPromoterScore"
        /// </summary>
        [EnumMember(Value = "surveyPromoterScore")]
        Surveypromoterscore,

        /// <summary>
        /// Enum Surveyquestiongroupid for "surveyQuestionGroupId"
        /// </summary>
        [EnumMember(Value = "surveyQuestionGroupId")]
        Surveyquestiongroupid,

        /// <summary>
        /// Enum Surveyquestionid for "surveyQuestionId"
        /// </summary>
        [EnumMember(Value = "surveyQuestionId")]
        Surveyquestionid,

        /// <summary>
        /// Enum Surveystatus for "surveyStatus"
        /// </summary>
        [EnumMember(Value = "surveyStatus")]
        Surveystatus,

        /// <summary>
        /// Enum Surveytype for "surveyType"
        /// </summary>
        [EnumMember(Value = "surveyType")]
        Surveytype,

        /// <summary>
        /// Enum Teamid for "teamId"
        /// </summary>
        [EnumMember(Value = "teamId")]
        Teamid,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid,

        /// <summary>
        /// Enum Wrapupcode for "wrapUpCode"
        /// </summary>
        [EnumMember(Value = "wrapUpCode")]
        Wrapupcode
    }
    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    
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
        /// Enum Nsurveyerrors for "nSurveyErrors"
        /// </summary>
        [EnumMember(Value = "nSurveyErrors")]
        Nsurveyerrors,

        /// <summary>
        /// Enum Nsurveyfullresponses for "nSurveyFullResponses"
        /// </summary>
        [EnumMember(Value = "nSurveyFullResponses")]
        Nsurveyfullresponses,

        /// <summary>
        /// Enum Nsurveynpsdetractors for "nSurveyNpsDetractors"
        /// </summary>
        [EnumMember(Value = "nSurveyNpsDetractors")]
        Nsurveynpsdetractors,

        /// <summary>
        /// Enum Nsurveynpspromoters for "nSurveyNpsPromoters"
        /// </summary>
        [EnumMember(Value = "nSurveyNpsPromoters")]
        Nsurveynpspromoters,

        /// <summary>
        /// Enum Nsurveynpsresponses for "nSurveyNpsResponses"
        /// </summary>
        [EnumMember(Value = "nSurveyNpsResponses")]
        Nsurveynpsresponses,

        /// <summary>
        /// Enum Nsurveypartialresponses for "nSurveyPartialResponses"
        /// </summary>
        [EnumMember(Value = "nSurveyPartialResponses")]
        Nsurveypartialresponses,

        /// <summary>
        /// Enum Nsurveyquestiongroupresponses for "nSurveyQuestionGroupResponses"
        /// </summary>
        [EnumMember(Value = "nSurveyQuestionGroupResponses")]
        Nsurveyquestiongroupresponses,

        /// <summary>
        /// Enum Nsurveyquestionresponses for "nSurveyQuestionResponses"
        /// </summary>
        [EnumMember(Value = "nSurveyQuestionResponses")]
        Nsurveyquestionresponses,

        /// <summary>
        /// Enum Nsurveyresponses for "nSurveyResponses"
        /// </summary>
        [EnumMember(Value = "nSurveyResponses")]
        Nsurveyresponses,

        /// <summary>
        /// Enum Nsurveysabandoned for "nSurveysAbandoned"
        /// </summary>
        [EnumMember(Value = "nSurveysAbandoned")]
        Nsurveysabandoned,

        /// <summary>
        /// Enum Nsurveysdeleted for "nSurveysDeleted"
        /// </summary>
        [EnumMember(Value = "nSurveysDeleted")]
        Nsurveysdeleted,

        /// <summary>
        /// Enum Nsurveysexpired for "nSurveysExpired"
        /// </summary>
        [EnumMember(Value = "nSurveysExpired")]
        Nsurveysexpired,

        /// <summary>
        /// Enum Nsurveyssent for "nSurveysSent"
        /// </summary>
        [EnumMember(Value = "nSurveysSent")]
        Nsurveyssent,

        /// <summary>
        /// Enum Nsurveysstarted for "nSurveysStarted"
        /// </summary>
        [EnumMember(Value = "nSurveysStarted")]
        Nsurveysstarted,

        /// <summary>
        /// Enum Nvoicesurveys for "nVoiceSurveys"
        /// </summary>
        [EnumMember(Value = "nVoiceSurveys")]
        Nvoicesurveys,

        /// <summary>
        /// Enum Nwebsurveys for "nWebSurveys"
        /// </summary>
        [EnumMember(Value = "nWebSurveys")]
        Nwebsurveys,

        /// <summary>
        /// Enum Osurveyquestiongroupscore for "oSurveyQuestionGroupScore"
        /// </summary>
        [EnumMember(Value = "oSurveyQuestionGroupScore")]
        Osurveyquestiongroupscore,

        /// <summary>
        /// Enum Osurveyquestionscore for "oSurveyQuestionScore"
        /// </summary>
        [EnumMember(Value = "oSurveyQuestionScore")]
        Osurveyquestionscore,

        /// <summary>
        /// Enum Osurveytotalscore for "oSurveyTotalScore"
        /// </summary>
        [EnumMember(Value = "oSurveyTotalScore")]
        Osurveytotalscore
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    
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
        Eventtime,

        /// <summary>
        /// Enum Surveycreateddate for "surveyCreatedDate"
        /// </summary>
        [EnumMember(Value = "surveyCreatedDate")]
        Surveycreateddate
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    [JsonPropertyName("alternateTimeDimension")]
    public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyAsyncAggregationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SurveyAsyncAggregationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyAsyncAggregationQuery" /> class.
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
    /// <param name="PageSize">The number of results per page.</param>
    public SurveyAsyncAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, SurveyAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<SurveyAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, int? PageSize = null)
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
        this.PageSize = PageSize;

    }



    /// <summary>
    /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("granularity")]
    public string Granularity { get; set; }



    /// <summary>
    /// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }



    /// <summary>
    /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
    /// </summary>
    /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
    [JsonPropertyName("groupBy")]
    public List<GroupByEnum> GroupBy { get; set; }



    /// <summary>
    /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
    [JsonPropertyName("filter")]
    public SurveyAggregateQueryFilter Filter { get; set; }



    /// <summary>
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    [JsonPropertyName("metrics")]
    public List<MetricsEnum> Metrics { get; set; }



    /// <summary>
    /// Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)
    /// </summary>
    /// <value>Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)</value>
    [JsonPropertyName("flattenMultivaluedDimensions")]
    public bool? FlattenMultivaluedDimensions { get; set; }



    /// <summary>
    /// Custom derived metric views
    /// </summary>
    /// <value>Custom derived metric views</value>
    [JsonPropertyName("views")]
    public List<SurveyAggregationView> Views { get; set; }





    /// <summary>
    /// The number of results per page
    /// </summary>
    /// <value>The number of results per page</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyAsyncAggregationQuery {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
        sb.Append("  Views: ").Append(Views).Append("\n");
        sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
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
        return Equals(obj as SurveyAsyncAggregationQuery);
    }

    /// <summary>
    /// Returns true if SurveyAsyncAggregationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyAsyncAggregationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyAsyncAggregationQuery other)
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

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            return hash;
        }
    }
}
