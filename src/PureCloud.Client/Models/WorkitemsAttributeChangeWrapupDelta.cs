using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsAttributeChangeWrapupDelta
/// </summary>

public partial class WorkitemsAttributeChangeWrapupDelta : IEquatable<WorkitemsAttributeChangeWrapupDelta>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsAttributeChangeWrapupDelta" /> class.
    /// </summary>
    /// <param name="NewValue">New property value.</param>
    /// <param name="OldValue">Old property value.</param>
    public WorkitemsAttributeChangeWrapupDelta(WrapupDelta NewValue = null, WrapupDelta OldValue = null)
    {
        this.NewValue = NewValue;
        this.OldValue = OldValue;

    }



    /// <summary>
    /// New property value
    /// </summary>
    /// <value>New property value</value>
    [JsonPropertyName("newValue")]
    public WrapupDelta NewValue { get; set; }



    /// <summary>
    /// Old property value
    /// </summary>
    /// <value>Old property value</value>
    [JsonPropertyName("oldValue")]
    public WrapupDelta OldValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsAttributeChangeWrapupDelta {\n");

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
        return Equals(obj as WorkitemsAttributeChangeWrapupDelta);
    }

    /// <summary>
    /// Returns true if WorkitemsAttributeChangeWrapupDelta instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsAttributeChangeWrapupDelta to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsAttributeChangeWrapupDelta other)
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
                NewValue.Equals(other.NewValue)
            ) &&
            (
                OldValue == other.OldValue ||
                OldValue != null &&
                OldValue.Equals(other.OldValue)
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
