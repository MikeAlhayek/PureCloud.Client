using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Number
/// </summary>
[DataContract]
public partial class Number : IEquatable<Number>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Number" /> class.
    /// </summary>
    /// <param name="Start">Start.</param>
    /// <param name="End">End.</param>
    public Number(string Start = null, string End = null)
    {
        this.Start = Start;
        this.End = End;

    }



    /// <summary>
    /// Gets or Sets Start
    /// </summary>
    [DataMember(Name = "start", EmitDefaultValue = false)]
    public string Start { get; set; }



    /// <summary>
    /// Gets or Sets End
    /// </summary>
    [DataMember(Name = "end", EmitDefaultValue = false)]
    public string End { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Number {\n");

        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
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
        return Equals(obj as Number);
    }

    /// <summary>
    /// Returns true if Number instances are equal
    /// </summary>
    /// <param name="other">Instance of Number to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Number other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Start == other.Start ||
                Start != null &&
                Start.Equals(other.Start)
            ) &&
            (
                End == other.End ||
                End != null &&
                End.Equals(other.End)
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
            if (Start != null)
            {
                hash = hash * 59 + Start.GetHashCode();
            }

            if (End != null)
            {
                hash = hash * 59 + End.GetHashCode();
            }

            return hash;
        }
    }
}
