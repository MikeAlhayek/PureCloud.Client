using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PropertyChange
/// </summary>

public partial class PropertyChange : IEquatable<PropertyChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyChange" /> class.
    /// </summary>
    /// <param name="Property">The property that was changed.</param>
    /// <param name="OldValues">Previous values for the property..</param>
    /// <param name="NewValues">New values for the property..</param>
    public PropertyChange(string Property = null, List<string> OldValues = null, List<string> NewValues = null)
    {
        this.Property = Property;
        this.OldValues = OldValues;
        this.NewValues = NewValues;

    }



    /// <summary>
    /// The property that was changed
    /// </summary>
    /// <value>The property that was changed</value>
    [JsonPropertyName("property")]
    public string Property { get; set; }



    /// <summary>
    /// Previous values for the property.
    /// </summary>
    /// <value>Previous values for the property.</value>
    [JsonPropertyName("oldValues")]
    public List<string> OldValues { get; set; }



    /// <summary>
    /// New values for the property.
    /// </summary>
    /// <value>New values for the property.</value>
    [JsonPropertyName("newValues")]
    public List<string> NewValues { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PropertyChange {\n");

        sb.Append("  Property: ").Append(Property).Append("\n");
        sb.Append("  OldValues: ").Append(OldValues).Append("\n");
        sb.Append("  NewValues: ").Append(NewValues).Append("\n");
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
        return Equals(obj as PropertyChange);
    }

    /// <summary>
    /// Returns true if PropertyChange instances are equal
    /// </summary>
    /// <param name="other">Instance of PropertyChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PropertyChange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Property == other.Property ||
                Property != null &&
                Property.Equals(other.Property)
            ) &&
            (
                OldValues == other.OldValues ||
                OldValues != null &&
                OldValues.SequenceEqual(other.OldValues)
            ) &&
            (
                NewValues == other.NewValues ||
                NewValues != null &&
                NewValues.SequenceEqual(other.NewValues)
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
            if (Property != null)
            {
                hash = hash * 59 + Property.GetHashCode();
            }

            if (OldValues != null)
            {
                hash = hash * 59 + OldValues.GetHashCode();
            }

            if (NewValues != null)
            {
                hash = hash * 59 + NewValues.GetHashCode();
            }

            return hash;
        }
    }
}
