using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationAggregationQueryMe
/// </summary>

public partial class EvaluationAggregationQueryMe : IEquatable<EvaluationAggregationQueryMe>
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
        /// Enum Assigneeapplicable for "assigneeApplicable"
        /// </summary>
        [EnumMember(Value = "assigneeApplicable")]
        Assigneeapplicable,

        /// <summary>
        /// Enum Assigneeid for "assigneeId"
        /// </summary>
        [EnumMember(Value = "assigneeId")]
        Assigneeid,

        /// <summary>
        /// Enum Calibrationid for "calibrationId"
        /// </summary>
        [EnumMember(Value = "calibrationId")]
        Calibrationid,

        /// <summary>
        /// Enum Contextid for "contextId"
        /// </summary>
        [EnumMember(Value = "contextId")]
        Contextid,

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
        /// Enum Evaluationcontextid for "evaluationContextId"
        /// </summary>
        [EnumMember(Value = "evaluationContextId")]
        Evaluationcontextid,

        /// <summary>
        /// Enum Evaluationid for "evaluationId"
        /// </summary>
        [EnumMember(Value = "evaluationId")]
        Evaluationid,

        /// <summary>
        /// Enum Evaluatorid for "evaluatorId"
        /// </summary>
        [EnumMember(Value = "evaluatorId")]
        Evaluatorid,

        /// <summary>
        /// Enum Formid for "formId"
        /// </summary>
        [EnumMember(Value = "formId")]
        Formid,

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
        /// Enum Released for "released"
        /// </summary>
        [EnumMember(Value = "released")]
        Released,

        /// <summary>
        /// Enum Rescored for "rescored"
        /// </summary>
        [EnumMember(Value = "rescored")]
        Rescored,

        /// <summary>
        /// Enum Teamid for "teamId"
        /// </summary>
        [EnumMember(Value = "teamId")]
        Teamid,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid
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
        /// Enum Nevaluations for "nEvaluations"
        /// </summary>
        [EnumMember(Value = "nEvaluations")]
        Nevaluations,

        /// <summary>
        /// Enum Nevaluationsdeleted for "nEvaluationsDeleted"
        /// </summary>
        [EnumMember(Value = "nEvaluationsDeleted")]
        Nevaluationsdeleted,

        /// <summary>
        /// Enum Nevaluationsrescored for "nEvaluationsRescored"
        /// </summary>
        [EnumMember(Value = "nEvaluationsRescored")]
        Nevaluationsrescored,

        /// <summary>
        /// Enum Ototalcriticalscore for "oTotalCriticalScore"
        /// </summary>
        [EnumMember(Value = "oTotalCriticalScore")]
        Ototalcriticalscore,

        /// <summary>
        /// Enum Ototalscore for "oTotalScore"
        /// </summary>
        [EnumMember(Value = "oTotalScore")]
        Ototalscore
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
        /// Enum Conversationstart for "conversationStart"
        /// </summary>
        [EnumMember(Value = "conversationStart")]
        Conversationstart,

        /// <summary>
        /// Enum Evaluationcreateddate for "evaluationCreatedDate"
        /// </summary>
        [EnumMember(Value = "evaluationCreatedDate")]
        Evaluationcreateddate,

        /// <summary>
        /// Enum Evaluationreleasedate for "evaluationReleaseDate"
        /// </summary>
        [EnumMember(Value = "evaluationReleaseDate")]
        Evaluationreleasedate,

        /// <summary>
        /// Enum Eventtime for "eventTime"
        /// </summary>
        [EnumMember(Value = "eventTime")]
        Eventtime
    }
    /// <summary>
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    [JsonPropertyName("alternateTimeDimension")]
    public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationAggregationQueryMe" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EvaluationAggregationQueryMe() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationAggregationQueryMe" /> class.
    /// </summary>
    /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="TimeZone">Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
    /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
    /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
    /// <param name="AlternateTimeDimension">Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \&quot;eventTime\&quot; uses the actual time of the data event..</param>
    /// <param name="ContextId">Evaluation context Id.</param>
    public EvaluationAggregationQueryMe(string Interval = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, List<MetricsEnum> Metrics = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, string ContextId = null)
    {
        this.Interval = Interval;
        this.TimeZone = TimeZone;
        this.GroupBy = GroupBy;
        this.Metrics = Metrics;
        this.AlternateTimeDimension = AlternateTimeDimension;
        this.ContextId = ContextId;

    }



    /// <summary>
    /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



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
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    [JsonPropertyName("metrics")]
    public List<MetricsEnum> Metrics { get; set; }





    /// <summary>
    /// Evaluation context Id
    /// </summary>
    /// <value>Evaluation context Id</value>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationAggregationQueryMe {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
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
        return Equals(obj as EvaluationAggregationQueryMe);
    }

    /// <summary>
    /// Returns true if EvaluationAggregationQueryMe instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationAggregationQueryMe to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationAggregationQueryMe other)
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
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                AlternateTimeDimension == other.AlternateTimeDimension ||
                AlternateTimeDimension != null &&
                AlternateTimeDimension.Equals(other.AlternateTimeDimension)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
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

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (GroupBy != null)
            {
                hash = hash * 59 + GroupBy.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (AlternateTimeDimension != null)
            {
                hash = hash * 59 + AlternateTimeDimension.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            return hash;
        }
    }
}
