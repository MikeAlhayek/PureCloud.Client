using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsAttributeChangeMap
/// </summary>

public partial class WorkitemsAttributeChangeMap : IEquatable<WorkitemsAttributeChangeMap>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsAttributeChangeMap" /> class.
    /// </summary>
    /// <param name="NewValue">New property value.</param>
    /// <param name="OldValue">Old property value.</param>
    public WorkitemsAttributeChangeMap(Dictionary<string, object> NewValue = null, Dictionary<string, object> OldValue = null)
    {
        this.NewValue = NewValue;
        this.OldValue = OldValue;

    }



    /// <summary>
    /// New property value
    /// </summary>
    /// <value>New property value</value>
    [JsonPropertyName("newValue")]
    public Dictionary<string, object> NewValue { get; set; }



    /// <summary>
    /// Old property value
    /// </summary>
    /// <value>Old property value</value>
    [JsonPropertyName("oldValue")]
    public Dictionary<string, object> OldValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsAttributeChangeMap {\n");

        sb.Append("  NewValue: ").Append(NewValue).Append("\n");
        sb.Append("  OldValue: ").Append(OldValue).Append("\n");
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
        return Equals(obj as WorkitemsAttributeChangeMap);
    }

    /// <summary>
    /// Returns true if WorkitemsAttributeChangeMap instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsAttributeChangeMap to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsAttributeChangeMap other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                NewValue == other.NewValue ||
                NewValue != null &&
                NewValue.SequenceEqual(other.NewValue)
            ) &&
            (
                OldValue == other.OldValue ||
                OldValue != null &&
                OldValue.SequenceEqual(other.OldValue)
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
            if (NewValue != null)
            {
                hash = hash * 59 + NewValue.GetHashCode();
            }

            if (OldValue != null)
            {
                hash = hash * 59 + OldValue.GetHashCode();
            }

            return hash;
        }
    }
}
