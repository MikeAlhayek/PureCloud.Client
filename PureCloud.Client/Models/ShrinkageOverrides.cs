using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ShrinkageOverrides
/// </summary>
[DataContract]
public partial class ShrinkageOverrides : IEquatable<ShrinkageOverrides>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShrinkageOverrides" /> class.
    /// </summary>
    /// <param name="Clear">Set true to clear the shrinkage interval overrides.</param>
    /// <param name="Values">List of interval shrinkage overrides.</param>
    public ShrinkageOverrides(bool? Clear = null, List<ShrinkageOverride> Values = null)
    {
        this.Clear = Clear;
        this.Values = Values;

    }



    /// <summary>
    /// Set true to clear the shrinkage interval overrides
    /// </summary>
    /// <value>Set true to clear the shrinkage interval overrides</value>
    [DataMember(Name = "clear", EmitDefaultValue = false)]
    public bool? Clear { get; set; }



    /// <summary>
    /// List of interval shrinkage overrides
    /// </summary>
    /// <value>List of interval shrinkage overrides</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<ShrinkageOverride> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShrinkageOverrides {\n");

        sb.Append("  Clear: ").Append(Clear).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as ShrinkageOverrides);
    }

    /// <summary>
    /// Returns true if ShrinkageOverrides instances are equal
    /// </summary>
    /// <param name="other">Instance of ShrinkageOverrides to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShrinkageOverrides other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Clear == other.Clear ||
                Clear != null &&
                Clear.Equals(other.Clear)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (Clear != null)
            {
                hash = hash * 59 + Clear.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
