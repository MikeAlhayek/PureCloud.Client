using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A metric to measure within the chart
/// </summary>

public partial class JourneyViewChartMetric : IEquatable<JourneyViewChartMetric>
{
    /// <summary>
    /// How to aggregate the given element, defaults to CustomerCount
    /// </summary>
    /// <value>How to aggregate the given element, defaults to CustomerCount</value>
    
    public enum AggregateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Eventcount for "EventCount"
        /// </summary>
        [EnumMember(Value = "EventCount")]
        Eventcount,

        /// <summary>
        /// Enum Customercount for "CustomerCount"
        /// </summary>
        [EnumMember(Value = "CustomerCount")]
        Customercount
    }
    /// <summary>
    /// How to aggregate the given element, defaults to CustomerCount
    /// </summary>
    /// <value>How to aggregate the given element, defaults to CustomerCount</value>
    [JsonPropertyName("aggregate")]
    public AggregateEnum? Aggregate { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChartMetric" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewChartMetric() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChartMetric" /> class.
    /// </summary>
    /// <param name="Id">The unique identifier of the metric within the chart (required).</param>
    /// <param name="ElementId">The element in the list of elements which the metric is measuring (required).</param>
    /// <param name="Aggregate">How to aggregate the given element, defaults to CustomerCount.</param>
    /// <param name="DisplayLabel">A display label for the metric.</param>
    public JourneyViewChartMetric(string Id = null, string ElementId = null, AggregateEnum? Aggregate = null, string DisplayLabel = null)
    {
        this.Id = Id;
        this.ElementId = ElementId;
        this.Aggregate = Aggregate;
        this.DisplayLabel = DisplayLabel;

    }



    /// <summary>
    /// The unique identifier of the metric within the chart
    /// </summary>
    /// <value>The unique identifier of the metric within the chart</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The element in the list of elements which the metric is measuring
    /// </summary>
    /// <value>The element in the list of elements which the metric is measuring</value>
    [JsonPropertyName("elementId")]
    public string ElementId { get; set; }





    /// <summary>
    /// A display label for the metric
    /// </summary>
    /// <value>A display label for the metric</value>
    [JsonPropertyName("displayLabel")]
    public string DisplayLabel { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewChartMetric {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ElementId: ").Append(ElementId).Append("\n");
        sb.Append("  Aggregate: ").Append(Aggregate).Append("\n");
        sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
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
        return Equals(obj as JourneyViewChartMetric);
    }

    /// <summary>
    /// Returns true if JourneyViewChartMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewChartMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewChartMetric other)
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
                ElementId == other.ElementId ||
                ElementId != null &&
                ElementId.Equals(other.ElementId)
            ) &&
            (
                Aggregate == other.Aggregate ||
                Aggregate != null &&
                Aggregate.Equals(other.Aggregate)
            ) &&
            (
                DisplayLabel == other.DisplayLabel ||
                DisplayLabel != null &&
                DisplayLabel.Equals(other.DisplayLabel)
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

            if (ElementId != null)
            {
                hash = hash * 59 + ElementId.GetHashCode();
            }

            if (Aggregate != null)
            {
                hash = hash * 59 + Aggregate.GetHashCode();
            }

            if (DisplayLabel != null)
            {
                hash = hash * 59 + DisplayLabel.GetHashCode();
            }

            return hash;
        }
    }
}
