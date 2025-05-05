using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A journey element attribute to group by within the chart
/// </summary>

public partial class JourneyViewChartGroupByAttribute : IEquatable<JourneyViewChartGroupByAttribute>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChartGroupByAttribute" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewChartGroupByAttribute() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewChartGroupByAttribute" /> class.
    /// </summary>
    /// <param name="ElementId">The element in the list of elements which is being grouped by (required).</param>
    /// <param name="Attribute">The attribute of the element being grouped by (required).</param>
    public JourneyViewChartGroupByAttribute(string ElementId = null, string Attribute = null)
    {
        this.ElementId = ElementId;
        this.Attribute = Attribute;

    }



    /// <summary>
    /// The element in the list of elements which is being grouped by
    /// </summary>
    /// <value>The element in the list of elements which is being grouped by</value>
    [JsonPropertyName("elementId")]
    public string ElementId { get; set; }



    /// <summary>
    /// The attribute of the element being grouped by
    /// </summary>
    /// <value>The attribute of the element being grouped by</value>
    [JsonPropertyName("attribute")]
    public string Attribute { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewChartGroupByAttribute {\n");

        sb.Append("  ElementId: ").Append(ElementId).Append("\n");
        sb.Append("  Attribute: ").Append(Attribute).Append("\n");
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
        return Equals(obj as JourneyViewChartGroupByAttribute);
    }

    /// <summary>
    /// Returns true if JourneyViewChartGroupByAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewChartGroupByAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewChartGroupByAttribute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ElementId == other.ElementId ||
                ElementId != null &&
                ElementId.Equals(other.ElementId)
            ) &&
            (
                Attribute == other.Attribute ||
                Attribute != null &&
                Attribute.Equals(other.Attribute)
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
            if (ElementId != null)
            {
                hash = hash * 59 + ElementId.GetHashCode();
            }

            if (Attribute != null)
            {
                hash = hash * 59 + Attribute.GetHashCode();
            }

            return hash;
        }
    }
}
