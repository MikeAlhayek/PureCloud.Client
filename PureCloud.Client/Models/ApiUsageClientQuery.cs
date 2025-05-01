using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ApiUsageClientQuery
/// </summary>
[DataContract]
public partial class ApiUsageClientQuery : IEquatable<ApiUsageClientQuery>
{
    /// <summary>
    /// Date granularity of the results
    /// </summary>
    /// <value>Date granularity of the results</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GranularityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Day for "Day"
        /// </summary>
        [EnumMember(Value = "Day")]
        Day,

        /// <summary>
        /// Enum Week for "Week"
        /// </summary>
        [EnumMember(Value = "Week")]
        Week,

        /// <summary>
        /// Enum Month for "Month"
        /// </summary>
        [EnumMember(Value = "Month")]
        Month
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
        /// Enum Status200 for "Status200"
        /// </summary>
        [EnumMember(Value = "Status200")]
        Status200,

        /// <summary>
        /// Enum Status300 for "Status300"
        /// </summary>
        [EnumMember(Value = "Status300")]
        Status300,

        /// <summary>
        /// Enum Status400 for "Status400"
        /// </summary>
        [EnumMember(Value = "Status400")]
        Status400,

        /// <summary>
        /// Enum Status500 for "Status500"
        /// </summary>
        [EnumMember(Value = "Status500")]
        Status500,

        /// <summary>
        /// Enum Status429 for "Status429"
        /// </summary>
        [EnumMember(Value = "Status429")]
        Status429,

        /// <summary>
        /// Enum Requests for "Requests"
        /// </summary>
        [EnumMember(Value = "Requests")]
        Requests
    }
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
        /// Enum Oauthclientid for "OAuthClientId"
        /// </summary>
        [EnumMember(Value = "OAuthClientId")]
        Oauthclientid,

        /// <summary>
        /// Enum Organizationid for "OrganizationId"
        /// </summary>
        [EnumMember(Value = "OrganizationId")]
        Organizationid,

        /// <summary>
        /// Enum Templateuri for "TemplateUri"
        /// </summary>
        [EnumMember(Value = "TemplateUri")]
        Templateuri,

        /// <summary>
        /// Enum Httpmethod for "HttpMethod"
        /// </summary>
        [EnumMember(Value = "HttpMethod")]
        Httpmethod
    }
    /// <summary>
    /// Date granularity of the results
    /// </summary>
    /// <value>Date granularity of the results</value>
    [DataMember(Name = "granularity", EmitDefaultValue = false)]
    public GranularityEnum? Granularity { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiUsageClientQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ApiUsageClientQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiUsageClientQuery" /> class.
    /// </summary>
    /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Granularity">Date granularity of the results.</param>
    /// <param name="Metrics">Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *)..</param>
    /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
    public ApiUsageClientQuery(string Interval = null, GranularityEnum? Granularity = null, List<MetricsEnum> Metrics = null, List<GroupByEnum> GroupBy = null)
    {
        this.Interval = Interval;
        this.Granularity = Granularity;
        this.Metrics = Metrics;
        this.GroupBy = GroupBy;

    }



    /// <summary>
    /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public string Interval { get; set; }





    /// <summary>
    /// Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).</value>
    [DataMember(Name = "metrics", EmitDefaultValue = false)]
    public List<MetricsEnum> Metrics { get; set; }



    /// <summary>
    /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
    /// </summary>
    /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
    [DataMember(Name = "groupBy", EmitDefaultValue = false)]
    public List<GroupByEnum> GroupBy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ApiUsageClientQuery {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
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
        return Equals(obj as ApiUsageClientQuery);
    }

    /// <summary>
    /// Returns true if ApiUsageClientQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of ApiUsageClientQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ApiUsageClientQuery other)
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
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                GroupBy == other.GroupBy ||
                GroupBy != null &&
                GroupBy.SequenceEqual(other.GroupBy)
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

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (GroupBy != null)
            {
                hash = hash * 59 + GroupBy.GetHashCode();
            }

            return hash;
        }
    }
}
