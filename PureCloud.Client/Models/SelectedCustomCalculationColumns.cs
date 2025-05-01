using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SelectedCustomCalculationColumns
/// </summary>
[DataContract]
public partial class SelectedCustomCalculationColumns : IEquatable<SelectedCustomCalculationColumns>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectedCustomCalculationColumns" /> class.
    /// </summary>
    /// <param name="CustomCalculation">Custom calculation added as a column.</param>
    /// <param name="Restricted">Indicates if selected custom calculation column is deleted or access revoked for the user.</param>
    /// <param name="SoftDeleted">Is selected custom calculation column soft deleted.</param>
    public SelectedCustomCalculationColumns(AddressableEntityRef CustomCalculation = null, bool? Restricted = null, bool? SoftDeleted = null)
    {
        this.CustomCalculation = CustomCalculation;
        this.Restricted = Restricted;
        this.SoftDeleted = SoftDeleted;

    }



    /// <summary>
    /// Custom calculation added as a column
    /// </summary>
    /// <value>Custom calculation added as a column</value>
    [DataMember(Name = "customCalculation", EmitDefaultValue = false)]
    public AddressableEntityRef CustomCalculation { get; set; }



    /// <summary>
    /// Indicates if selected custom calculation column is deleted or access revoked for the user
    /// </summary>
    /// <value>Indicates if selected custom calculation column is deleted or access revoked for the user</value>
    [DataMember(Name = "restricted", EmitDefaultValue = false)]
    public bool? Restricted { get; set; }



    /// <summary>
    /// Is selected custom calculation column soft deleted
    /// </summary>
    /// <value>Is selected custom calculation column soft deleted</value>
    [DataMember(Name = "softDeleted", EmitDefaultValue = false)]
    public bool? SoftDeleted { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SelectedCustomCalculationColumns {\n");

        sb.Append("  CustomCalculation: ").Append(CustomCalculation).Append("\n");
        sb.Append("  Restricted: ").Append(Restricted).Append("\n");
        sb.Append("  SoftDeleted: ").Append(SoftDeleted).Append("\n");
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
        return Equals(obj as SelectedCustomCalculationColumns);
    }

    /// <summary>
    /// Returns true if SelectedCustomCalculationColumns instances are equal
    /// </summary>
    /// <param name="other">Instance of SelectedCustomCalculationColumns to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SelectedCustomCalculationColumns other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CustomCalculation == other.CustomCalculation ||
                CustomCalculation != null &&
                CustomCalculation.Equals(other.CustomCalculation)
            ) &&
            (
                Restricted == other.Restricted ||
                Restricted != null &&
                Restricted.Equals(other.Restricted)
            ) &&
            (
                SoftDeleted == other.SoftDeleted ||
                SoftDeleted != null &&
                SoftDeleted.Equals(other.SoftDeleted)
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
            if (CustomCalculation != null)
            {
                hash = hash * 59 + CustomCalculation.GetHashCode();
            }

            if (Restricted != null)
            {
                hash = hash * 59 + Restricted.GetHashCode();
            }

            if (SoftDeleted != null)
            {
                hash = hash * 59 + SoftDeleted.GetHashCode();
            }

            return hash;
        }
    }
}
