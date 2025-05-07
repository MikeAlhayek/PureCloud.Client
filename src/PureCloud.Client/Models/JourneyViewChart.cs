using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A chart within the context of the elements of the the journey view
/// </summary>

public partial class JourneyViewChart : IEquatable<JourneyViewChart>
{
    /// <summary>
    /// A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.
    /// </summary>
    /// <value>A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.</value>
    
    public enum GroupByTimeEnum
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
        Month,

        /// <summary>
        /// Enum Year for "Year"
        /// </summary>
        [EnumMember(Value = "Year")]
        Year
    }
    /// <summary>
    /// A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.
    /// </summary>
    /// <value>A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.</value>
    [JsonPropertyName("groupByTime")]
    public GroupByTimeEnum? GroupByTime { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChart" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewChart() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChart" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="GroupByTime">A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified..</param>
    /// <param name="GroupByAttributes">A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified..</param>
    /// <param name="Metrics">A list of metrics to calculate within the chart by (aka the y axis) (required).</param>
    /// <param name="DisplayAttributes">Optional display attributes for rendering the chart.</param>
    /// <param name="GroupByMax">A maximum on the number of values being grouped by.</param>
    public JourneyViewChart(string Name = null, GroupByTimeEnum? GroupByTime = null, List<JourneyViewChartGroupByAttribute> GroupByAttributes = null, List<JourneyViewChartMetric> Metrics = null, JourneyViewChartDisplayAttributes DisplayAttributes = null, int? GroupByMax = null)
    {
        this.Name = Name;
        this.GroupByTime = GroupByTime;
        this.GroupByAttributes = GroupByAttributes;
        this.Metrics = Metrics;
        this.DisplayAttributes = DisplayAttributes;
        this.GroupByMax = GroupByMax;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The version of the journey view chart
    /// </summary>
    /// <value>The version of the journey view chart</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }





    /// <summary>
    /// A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified.
    /// </summary>
    /// <value>A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified.</value>
    [JsonPropertyName("groupByAttributes")]
    public List<JourneyViewChartGroupByAttribute> GroupByAttributes { get; set; }



    /// <summary>
    /// A list of metrics to calculate within the chart by (aka the y axis)
    /// </summary>
    /// <value>A list of metrics to calculate within the chart by (aka the y axis)</value>
    [JsonPropertyName("metrics")]
    public List<JourneyViewChartMetric> Metrics { get; set; }



    /// <summary>
    /// Optional display attributes for rendering the chart
    /// </summary>
    /// <value>Optional display attributes for rendering the chart</value>
    [JsonPropertyName("displayAttributes")]
    public JourneyViewChartDisplayAttributes DisplayAttributes { get; set; }



    /// <summary>
    /// A maximum on the number of values being grouped by
    /// </summary>
    /// <value>A maximum on the number of values being grouped by</value>
    [JsonPropertyName("groupByMax")]
    public int? GroupByMax { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewChart {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  GroupByTime: ").Append(GroupByTime).Append("\n");
        sb.Append("  GroupByAttributes: ").Append(GroupByAttributes).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  DisplayAttributes: ").Append(DisplayAttributes).Append("\n");
        sb.Append("  GroupByMax: ").Append(GroupByMax).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as JourneyViewChart);
    }

    /// <summary>
    /// Returns true if JourneyViewChart instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewChart to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewChart other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                GroupByTime == other.GroupByTime ||
                GroupByTime != null &&
                GroupByTime.Equals(other.GroupByTime)
            ) &&
            (
                GroupByAttributes == other.GroupByAttributes ||
                GroupByAttributes != null &&
                GroupByAttributes.SequenceEqual(other.GroupByAttributes)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                DisplayAttributes == other.DisplayAttributes ||
                DisplayAttributes != null &&
                DisplayAttributes.Equals(other.DisplayAttributes)
            ) &&
            (
                GroupByMax == other.GroupByMax ||
                GroupByMax != null &&
                GroupByMax.Equals(other.GroupByMax)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (GroupByTime != null)
            {
                hash = hash * 59 + GroupByTime.GetHashCode();
            }

            if (GroupByAttributes != null)
            {
                hash = hash * 59 + GroupByAttributes.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (DisplayAttributes != null)
            {
                hash = hash * 59 + DisplayAttributes.GetHashCode();
            }

            if (GroupByMax != null)
            {
                hash = hash * 59 + GroupByMax.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
