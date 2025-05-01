using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TaskManagementAggregationQuery
/// </summary>
[DataContract]
public partial class TaskManagementAggregationQuery : IEquatable<TaskManagementAggregationQuery>
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
        /// Enum Assigneeid for "assigneeId"
        /// </summary>
        [EnumMember(Value = "assigneeId")]
        Assigneeid,

        /// <summary>
        /// Enum Divisionid for "divisionId"
        /// </summary>
        [EnumMember(Value = "divisionId")]
        Divisionid,

        /// <summary>
        /// Enum Externaltag for "externalTag"
        /// </summary>
        [EnumMember(Value = "externalTag")]
        Externaltag,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Reporterid for "reporterId"
        /// </summary>
        [EnumMember(Value = "reporterId")]
        Reporterid,

        /// <summary>
        /// Enum Requestedlanguageid for "requestedLanguageId"
        /// </summary>
        [EnumMember(Value = "requestedLanguageId")]
        Requestedlanguageid,

        /// <summary>
        /// Enum Requestedrouting for "requestedRouting"
        /// </summary>
        [EnumMember(Value = "requestedRouting")]
        Requestedrouting,

        /// <summary>
        /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
        /// </summary>
        [EnumMember(Value = "requestedRoutingSkillId")]
        Requestedroutingskillid,

        /// <summary>
        /// Enum Statuscategory for "statusCategory"
        /// </summary>
        [EnumMember(Value = "statusCategory")]
        Statuscategory,

        /// <summary>
        /// Enum Statusid for "statusId"
        /// </summary>
        [EnumMember(Value = "statusId")]
        Statusid,

        /// <summary>
        /// Enum Typeid for "typeId"
        /// </summary>
        [EnumMember(Value = "typeId")]
        Typeid,

        /// <summary>
        /// Enum Usedrouting for "usedRouting"
        /// </summary>
        [EnumMember(Value = "usedRouting")]
        Usedrouting,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid,

        /// <summary>
        /// Enum Workbinid for "workbinId"
        /// </summary>
        [EnumMember(Value = "workbinId")]
        Workbinid,

        /// <summary>
        /// Enum Workitemid for "workitemId"
        /// </summary>
        [EnumMember(Value = "workitemId")]
        Workitemid,

        /// <summary>
        /// Enum Wrapupcode for "wrapUpCode"
        /// </summary>
        [EnumMember(Value = "wrapUpCode")]
        Wrapupcode
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
        /// Enum Nworkitemsacdcancelled for "nWorkitemsAcdCancelled"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAcdCancelled")]
        Nworkitemsacdcancelled,

        /// <summary>
        /// Enum Nworkitemsacdexpired for "nWorkitemsAcdExpired"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAcdExpired")]
        Nworkitemsacdexpired,

        /// <summary>
        /// Enum Nworkitemsacdstarted for "nWorkitemsAcdStarted"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAcdStarted")]
        Nworkitemsacdstarted,

        /// <summary>
        /// Enum Nworkitemsagenttransferred for "nWorkitemsAgentTransferred"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAgentTransferred")]
        Nworkitemsagenttransferred,

        /// <summary>
        /// Enum Nworkitemscreated for "nWorkitemsCreated"
        /// </summary>
        [EnumMember(Value = "nWorkitemsCreated")]
        Nworkitemscreated,

        /// <summary>
        /// Enum Nworkitemsdeclined for "nWorkitemsDeclined"
        /// </summary>
        [EnumMember(Value = "nWorkitemsDeclined")]
        Nworkitemsdeclined,

        /// <summary>
        /// Enum Nworkitemsdeleted for "nWorkitemsDeleted"
        /// </summary>
        [EnumMember(Value = "nWorkitemsDeleted")]
        Nworkitemsdeleted,

        /// <summary>
        /// Enum Nworkitemsdisconnected for "nWorkitemsDisconnected"
        /// </summary>
        [EnumMember(Value = "nWorkitemsDisconnected")]
        Nworkitemsdisconnected,

        /// <summary>
        /// Enum Nworkitemsoffered for "nWorkitemsOffered"
        /// </summary>
        [EnumMember(Value = "nWorkitemsOffered")]
        Nworkitemsoffered,

        /// <summary>
        /// Enum Nworkitemsoversla for "nWorkitemsOverSla"
        /// </summary>
        [EnumMember(Value = "nWorkitemsOverSla")]
        Nworkitemsoversla,

        /// <summary>
        /// Enum Nworkitemspurged for "nWorkitemsPurged"
        /// </summary>
        [EnumMember(Value = "nWorkitemsPurged")]
        Nworkitemspurged,

        /// <summary>
        /// Enum Nworkitemsqueuetransferred for "nWorkitemsQueueTransferred"
        /// </summary>
        [EnumMember(Value = "nWorkitemsQueueTransferred")]
        Nworkitemsqueuetransferred,

        /// <summary>
        /// Enum Nworkitemsstatuschanged for "nWorkitemsStatusChanged"
        /// </summary>
        [EnumMember(Value = "nWorkitemsStatusChanged")]
        Nworkitemsstatuschanged,

        /// <summary>
        /// Enum Nworkitemsterminated for "nWorkitemsTerminated"
        /// </summary>
        [EnumMember(Value = "nWorkitemsTerminated")]
        Nworkitemsterminated,

        /// <summary>
        /// Enum Nworkitemstimedout for "nWorkitemsTimedout"
        /// </summary>
        [EnumMember(Value = "nWorkitemsTimedout")]
        Nworkitemstimedout,

        /// <summary>
        /// Enum Nworkitemstransferred for "nWorkitemsTransferred"
        /// </summary>
        [EnumMember(Value = "nWorkitemsTransferred")]
        Nworkitemstransferred,

        /// <summary>
        /// Enum Nworkitemswrapupadded for "nWorkitemsWrapupAdded"
        /// </summary>
        [EnumMember(Value = "nWorkitemsWrapupAdded")]
        Nworkitemswrapupadded,

        /// <summary>
        /// Enum Nworkitemswrapupremoved for "nWorkitemsWrapupRemoved"
        /// </summary>
        [EnumMember(Value = "nWorkitemsWrapupRemoved")]
        Nworkitemswrapupremoved,

        /// <summary>
        /// Enum Oworkitemsservicelevel for "oWorkitemsServiceLevel"
        /// </summary>
        [EnumMember(Value = "oWorkitemsServiceLevel")]
        Oworkitemsservicelevel,

        /// <summary>
        /// Enum Tworkitemsagentfocuscomplete for "tWorkitemsAgentFocusComplete"
        /// </summary>
        [EnumMember(Value = "tWorkitemsAgentFocusComplete")]
        Tworkitemsagentfocuscomplete,

        /// <summary>
        /// Enum Tworkitemsalert for "tWorkitemsAlert"
        /// </summary>
        [EnumMember(Value = "tWorkitemsAlert")]
        Tworkitemsalert,

        /// <summary>
        /// Enum Tworkitemsanswered for "tWorkitemsAnswered"
        /// </summary>
        [EnumMember(Value = "tWorkitemsAnswered")]
        Tworkitemsanswered,

        /// <summary>
        /// Enum Tworkitemsdirectanswered for "tWorkitemsDirectAnswered"
        /// </summary>
        [EnumMember(Value = "tWorkitemsDirectAnswered")]
        Tworkitemsdirectanswered,

        /// <summary>
        /// Enum Tworkitemsfocus for "tWorkitemsFocus"
        /// </summary>
        [EnumMember(Value = "tWorkitemsFocus")]
        Tworkitemsfocus,

        /// <summary>
        /// Enum Tworkitemsfocuscomplete for "tWorkitemsFocusComplete"
        /// </summary>
        [EnumMember(Value = "tWorkitemsFocusComplete")]
        Tworkitemsfocuscomplete,

        /// <summary>
        /// Enum Tworkitemshandled for "tWorkitemsHandled"
        /// </summary>
        [EnumMember(Value = "tWorkitemsHandled")]
        Tworkitemshandled,

        /// <summary>
        /// Enum Tworkitemsheld for "tWorkitemsHeld"
        /// </summary>
        [EnumMember(Value = "tWorkitemsHeld")]
        Tworkitemsheld,

        /// <summary>
        /// Enum Tworkitemsheldcomplete for "tWorkitemsHeldComplete"
        /// </summary>
        [EnumMember(Value = "tWorkitemsHeldComplete")]
        Tworkitemsheldcomplete,

        /// <summary>
        /// Enum Tworkitemsnotresponding for "tWorkitemsNotResponding"
        /// </summary>
        [EnumMember(Value = "tWorkitemsNotResponding")]
        Tworkitemsnotresponding,

        /// <summary>
        /// Enum Tworkitemsparked for "tWorkitemsParked"
        /// </summary>
        [EnumMember(Value = "tWorkitemsParked")]
        Tworkitemsparked,

        /// <summary>
        /// Enum Tworkitemsqueueanswered for "tWorkitemsQueueAnswered"
        /// </summary>
        [EnumMember(Value = "tWorkitemsQueueAnswered")]
        Tworkitemsqueueanswered,

        /// <summary>
        /// Enum Tworkitemsstatus for "tWorkitemsStatus"
        /// </summary>
        [EnumMember(Value = "tWorkitemsStatus")]
        Tworkitemsstatus
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
    /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
    /// </summary>
    /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
    [DataMember(Name = "alternateTimeDimension", EmitDefaultValue = false)]
    public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TaskManagementAggregationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TaskManagementAggregationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TaskManagementAggregationQuery" /> class.
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
    public TaskManagementAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, TaskManagementAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<TaskManagementAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null)
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
    public TaskManagementAggregateQueryFilter Filter { get; set; }



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
    public List<TaskManagementAggregationView> Views { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TaskManagementAggregationQuery {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
        sb.Append("  Views: ").Append(Views).Append("\n");
        sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
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
        return Equals(obj as TaskManagementAggregationQuery);
    }

    /// <summary>
    /// Returns true if TaskManagementAggregationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of TaskManagementAggregationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TaskManagementAggregationQuery other)
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

            return hash;
        }
    }
}
