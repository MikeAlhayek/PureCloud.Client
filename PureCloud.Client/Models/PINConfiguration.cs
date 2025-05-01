using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PINConfiguration
/// </summary>
[DataContract]
public partial class PINConfiguration : IEquatable<PINConfiguration>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PINConfiguration" /> class.
    /// </summary>
    /// <param name="MinimumLength">MinimumLength.</param>
    /// <param name="MaximumLength">MaximumLength.</param>
    public PINConfiguration(int? MinimumLength = null, int? MaximumLength = null)
    {
        this.MinimumLength = MinimumLength;
        this.MaximumLength = MaximumLength;

    }



    /// <summary>
    /// Gets or Sets MinimumLength
    /// </summary>
    [DataMember(Name = "minimumLength", EmitDefaultValue = false)]
    public int? MinimumLength { get; set; }



    /// <summary>
    /// Gets or Sets MaximumLength
    /// </summary>
    [DataMember(Name = "maximumLength", EmitDefaultValue = false)]
    public int? MaximumLength { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PINConfiguration {\n");

        sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
        sb.Append("  MaximumLength: ").Append(MaximumLength).Append("\n");
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
        return Equals(obj as PINConfiguration);
    }

    /// <summary>
    /// Returns true if PINConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of PINConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PINConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MinimumLength == other.MinimumLength ||
                MinimumLength != null &&
                MinimumLength.Equals(other.MinimumLength)
            ) &&
            (
                MaximumLength == other.MaximumLength ||
                MaximumLength != null &&
                MaximumLength.Equals(other.MaximumLength)
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
            if (MinimumLength != null)
            {
                hash = hash * 59 + MinimumLength.GetHashCode();
            }

            if (MaximumLength != null)
            {
                hash = hash * 59 + MaximumLength.GetHashCode();
            }

            return hash;
        }
    }
}
