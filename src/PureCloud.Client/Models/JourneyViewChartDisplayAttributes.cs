using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Display attributes for the chart, such as type, labels and legends
/// </summary>

public partial class JourneyViewChartDisplayAttributes : IEquatable<JourneyViewChartDisplayAttributes>
{
    /// <summary>
    /// The type of chart to display
    /// </summary>
    /// <value>The type of chart to display</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Column for "Column"
        /// </summary>
        [EnumMember(Value = "Column")]
        Column,

        /// <summary>
        /// Enum Bar for "Bar"
        /// </summary>
        [EnumMember(Value = "Bar")]
        Bar,

        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line
    }
    /// <summary>
    /// The type of chart to display
    /// </summary>
    /// <value>The type of chart to display</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChartDisplayAttributes" /> class.
    /// </summary>
    /// <param name="Type">The type of chart to display.</param>
    /// <param name="GroupByTitle">A title for the grouped by attributes (aka the x axis).</param>
    /// <param name="MetricsTitle">A title for the metrics (aka the y axis).</param>
    /// <param name="ShowLegend">Whether to show a legend.</param>
    public JourneyViewChartDisplayAttributes(TypeEnum? Type = null, string GroupByTitle = null, string MetricsTitle = null, bool? ShowLegend = null)
    {
        this.Type = Type;
        this.GroupByTitle = GroupByTitle;
        this.MetricsTitle = MetricsTitle;
        this.ShowLegend = ShowLegend;

    }





    /// <summary>
    /// A title for the grouped by attributes (aka the x axis)
    /// </summary>
    /// <value>A title for the grouped by attributes (aka the x axis)</value>
    [JsonPropertyName("groupByTitle")]
    public string GroupByTitle { get; set; }



    /// <summary>
    /// A title for the metrics (aka the y axis)
    /// </summary>
    /// <value>A title for the metrics (aka the y axis)</value>
    [JsonPropertyName("metricsTitle")]
    public string MetricsTitle { get; set; }



    /// <summary>
    /// Whether to show a legend
    /// </summary>
    /// <value>Whether to show a legend</value>
    [JsonPropertyName("showLegend")]
    public bool? ShowLegend { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewChartDisplayAttributes {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  GroupByTitle: ").Append(GroupByTitle).Append("\n");
        sb.Append("  MetricsTitle: ").Append(MetricsTitle).Append("\n");
        sb.Append("  ShowLegend: ").Append(ShowLegend).Append("\n");
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
        return Equals(obj as JourneyViewChartDisplayAttributes);
    }

    /// <summary>
    /// Returns true if JourneyViewChartDisplayAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewChartDisplayAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewChartDisplayAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                GroupByTitle == other.GroupByTitle ||
                GroupByTitle != null &&
                GroupByTitle.Equals(other.GroupByTitle)
            ) &&
            (
                MetricsTitle == other.MetricsTitle ||
                MetricsTitle != null &&
                MetricsTitle.Equals(other.MetricsTitle)
            ) &&
            (
                ShowLegend == other.ShowLegend ||
                ShowLegend != null &&
                ShowLegend.Equals(other.ShowLegend)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (GroupByTitle != null)
            {
                hash = hash * 59 + GroupByTitle.GetHashCode();
            }

            if (MetricsTitle != null)
            {
                hash = hash * 59 + MetricsTitle.GetHashCode();
            }

            if (ShowLegend != null)
            {
                hash = hash * 59 + ShowLegend.GetHashCode();
            }

            return hash;
        }
    }
}
