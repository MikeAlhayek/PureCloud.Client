using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Cursors
/// </summary>
[DataContract]
public partial class Cursors : IEquatable<Cursors>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Cursors" /> class.
    /// </summary>
    /// <param name="Before">Before.</param>
    /// <param name="After">After.</param>
    public Cursors(string Before = null, string After = null)
    {
        this.Before = Before;
        this.After = After;

    }



    /// <summary>
    /// Gets or Sets Before
    /// </summary>
    [DataMember(Name = "before", EmitDefaultValue = false)]
    public string Before { get; set; }



    /// <summary>
    /// Gets or Sets After
    /// </summary>
    [DataMember(Name = "after", EmitDefaultValue = false)]
    public string After { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Cursors {\n");

        sb.Append("  Before: ").Append(Before).Append("\n");
        sb.Append("  After: ").Append(After).Append("\n");
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
        return Equals(obj as Cursors);
    }

    /// <summary>
    /// Returns true if Cursors instances are equal
    /// </summary>
    /// <param name="other">Instance of Cursors to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Cursors other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Before == other.Before ||
                Before != null &&
                Before.Equals(other.Before)
            ) &&
            (
                After == other.After ||
                After != null &&
                After.Equals(other.After)
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
            if (Before != null)
            {
                hash = hash * 59 + Before.GetHashCode();
            }

            if (After != null)
            {
                hash = hash * 59 + After.GetHashCode();
            }

            return hash;
        }
    }
}
