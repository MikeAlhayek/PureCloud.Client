using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactsExportFilter
/// </summary>
[DataContract]
public partial class ContactsExportFilter : IEquatable<ContactsExportFilter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsExportFilter" /> class.
    /// </summary>
    /// <param name="Eq">Filtered field should have the same value.</param>
    /// <param name="In">Filtered field should match one of the listed values.</param>
    /// <param name="And">Boolean AND combination of filters.</param>
    /// <param name="Or">Boolean OR combination of filters.</param>
    /// <param name="Not">Boolean negation of filters.</param>
    public ContactsExportFilter(ContactsExportFieldFilter Eq = null, ContactsExportFieldListFilter In = null, List<ContactsExportFilter> And = null, List<ContactsExportFilter> Or = null, ContactsExportFilter Not = null)
    {
        this.Eq = Eq;
        this.In = In;
        this.And = And;
        this.Or = Or;
        this.Not = Not;

    }



    /// <summary>
    /// Filtered field should have the same value
    /// </summary>
    /// <value>Filtered field should have the same value</value>
    [DataMember(Name = "eq", EmitDefaultValue = false)]
    public ContactsExportFieldFilter Eq { get; set; }



    /// <summary>
    /// Filtered field should match one of the listed values
    /// </summary>
    /// <value>Filtered field should match one of the listed values</value>
    [DataMember(Name = "in", EmitDefaultValue = false)]
    public ContactsExportFieldListFilter In { get; set; }



    /// <summary>
    /// Boolean AND combination of filters
    /// </summary>
    /// <value>Boolean AND combination of filters</value>
    [DataMember(Name = "and", EmitDefaultValue = false)]
    public List<ContactsExportFilter> And { get; set; }



    /// <summary>
    /// Boolean OR combination of filters
    /// </summary>
    /// <value>Boolean OR combination of filters</value>
    [DataMember(Name = "or", EmitDefaultValue = false)]
    public List<ContactsExportFilter> Or { get; set; }



    /// <summary>
    /// Boolean negation of filters
    /// </summary>
    /// <value>Boolean negation of filters</value>
    [DataMember(Name = "not", EmitDefaultValue = false)]
    public ContactsExportFilter Not { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactsExportFilter {\n");

        sb.Append("  Eq: ").Append(Eq).Append("\n");
        sb.Append("  In: ").Append(In).Append("\n");
        sb.Append("  And: ").Append(And).Append("\n");
        sb.Append("  Or: ").Append(Or).Append("\n");
        sb.Append("  Not: ").Append(Not).Append("\n");
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
        return Equals(obj as ContactsExportFilter);
    }

    /// <summary>
    /// Returns true if ContactsExportFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactsExportFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactsExportFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Eq == other.Eq ||
                Eq != null &&
                Eq.Equals(other.Eq)
            ) &&
            (
                In == other.In ||
                In != null &&
                In.Equals(other.In)
            ) &&
            (
                And == other.And ||
                And != null &&
                And.SequenceEqual(other.And)
            ) &&
            (
                Or == other.Or ||
                Or != null &&
                Or.SequenceEqual(other.Or)
            ) &&
            (
                Not == other.Not ||
                Not != null &&
                Not.Equals(other.Not)
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
            if (Eq != null)
            {
                hash = hash * 59 + Eq.GetHashCode();
            }

            if (In != null)
            {
                hash = hash * 59 + In.GetHashCode();
            }

            if (And != null)
            {
                hash = hash * 59 + And.GetHashCode();
            }

            if (Or != null)
            {
                hash = hash * 59 + Or.GetHashCode();
            }

            if (Not != null)
            {
                hash = hash * 59 + Not.GetHashCode();
            }

            return hash;
        }
    }
}
