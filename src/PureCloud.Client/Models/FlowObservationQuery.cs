using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowObservationQuery
/// </summary>

public partial class FlowObservationQuery : IEquatable<FlowObservationQuery>
{
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
        /// Enum Oflow for "oFlow"
        /// </summary>
        [EnumMember(Value = "oFlow")]
        Oflow
    }
    /// <summary>
    /// Gets or Sets DetailMetrics
    /// </summary>
    
    public enum DetailMetricsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Oflow for "oFlow"
        /// </summary>
        [EnumMember(Value = "oFlow")]
        Oflow
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowObservationQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowObservationQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowObservationQuery" /> class.
    /// </summary>
    /// <param name="Filter">Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters (required).</param>
    /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
    /// <param name="DetailMetrics">Metrics for which to include additional detailed observations.</param>
    public FlowObservationQuery(FlowObservationQueryFilter Filter = null, List<MetricsEnum> Metrics = null, List<DetailMetricsEnum> DetailMetrics = null)
    {
        this.Filter = Filter;
        this.Metrics = Metrics;
        this.DetailMetrics = DetailMetrics;

    }



    /// <summary>
    /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
    [JsonPropertyName("filter")]
    public FlowObservationQueryFilter Filter { get; set; }



    /// <summary>
    /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
    /// </summary>
    /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
    [JsonPropertyName("metrics")]
    public List<MetricsEnum> Metrics { get; set; }



    /// <summary>
    /// Metrics for which to include additional detailed observations
    /// </summary>
    /// <value>Metrics for which to include additional detailed observations</value>
    [JsonPropertyName("detailMetrics")]
    public List<DetailMetricsEnum> DetailMetrics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowObservationQuery {\n");

        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  DetailMetrics: ").Append(DetailMetrics).Append("\n");
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
        return Equals(obj as FlowObservationQuery);
    }

    /// <summary>
    /// Returns true if FlowObservationQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowObservationQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowObservationQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                DetailMetrics == other.DetailMetrics ||
                DetailMetrics != null &&
                DetailMetrics.SequenceEqual(other.DetailMetrics)
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
            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (DetailMetrics != null)
            {
                hash = hash * 59 + DetailMetrics.GetHashCode();
            }

            return hash;
        }
    }
}
