using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditTopicPropertyChange
/// </summary>
[DataContract]
public partial class AuditTopicPropertyChange : IEquatable<AuditTopicPropertyChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditTopicPropertyChange" /> class.
    /// </summary>
    /// <param name="Property">Property.</param>
    /// <param name="OldValues">OldValues.</param>
    /// <param name="NewValues">NewValues.</param>
    public AuditTopicPropertyChange(string Property = null, List<string> OldValues = null, List<string> NewValues = null)
    {
        this.Property = Property;
        this.OldValues = OldValues;
        this.NewValues = NewValues;

    }



    /// <summary>
    /// Gets or Sets Property
    /// </summary>
    [DataMember(Name = "property", EmitDefaultValue = false)]
    public string Property { get; set; }



    /// <summary>
    /// Gets or Sets OldValues
    /// </summary>
    [DataMember(Name = "oldValues", EmitDefaultValue = false)]
    public List<string> OldValues { get; set; }



    /// <summary>
    /// Gets or Sets NewValues
    /// </summary>
    [DataMember(Name = "newValues", EmitDefaultValue = false)]
    public List<string> NewValues { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditTopicPropertyChange {\n");

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
        return Equals(obj as AuditTopicPropertyChange);
    }

    /// <summary>
    /// Returns true if AuditTopicPropertyChange instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditTopicPropertyChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditTopicPropertyChange other)
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
