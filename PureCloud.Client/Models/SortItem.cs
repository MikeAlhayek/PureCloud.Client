using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SortItem
/// </summary>
[DataContract]
public partial class SortItem : IEquatable<SortItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SortItem" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Ascending">Ascending.</param>
    public SortItem(string Name = null, bool? Ascending = null)
    {
        this.Name = Name;
        this.Ascending = Ascending;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Ascending
    /// </summary>
    [DataMember(Name = "ascending", EmitDefaultValue = false)]
    public bool? Ascending { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SortItem {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Ascending: ").Append(Ascending).Append("\n");
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
        return Equals(obj as SortItem);
    }

    /// <summary>
    /// Returns true if SortItem instances are equal
    /// </summary>
    /// <param name="other">Instance of SortItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SortItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Ascending == other.Ascending ||
                Ascending != null &&
                Ascending.Equals(other.Ascending)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Ascending != null)
            {
                hash = hash * 59 + Ascending.GetHashCode();
            }

            return hash;
        }
    }
}
