using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Items
/// </summary>
[DataContract]
public partial class Items : IEquatable<Items>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Items" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="Pattern">Pattern.</param>
    public Items(string Type = null, string Pattern = null)
    {
        this.Type = Type;
        this.Pattern = Pattern;

    }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    [DataMember(Name = "pattern", EmitDefaultValue = false)]
    public string Pattern { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Items {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
        return Equals(obj as Items);
    }

    /// <summary>
    /// Returns true if Items instances are equal
    /// </summary>
    /// <param name="other">Instance of Items to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Items other)
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
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
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

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            return hash;
        }
    }
}
