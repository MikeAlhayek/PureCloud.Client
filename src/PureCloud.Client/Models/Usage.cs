using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Usage
/// </summary>

public partial class Usage : IEquatable<Usage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Usage" /> class.
    /// </summary>
    /// <param name="Types">Types.</param>
    public Usage(List<UsageItem> Types = null)
    {
        this.Types = Types;

    }



    /// <summary>
    /// Gets or Sets Types
    /// </summary>
    [JsonPropertyName("types")]
    public List<UsageItem> Types { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Usage {\n");

        sb.Append("  Types: ").Append(Types).Append("\n");
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
        return Equals(obj as Usage);
    }

    /// <summary>
    /// Returns true if Usage instances are equal
    /// </summary>
    /// <param name="other">Instance of Usage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Usage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Types == other.Types ||
                Types != null &&
                Types.SequenceEqual(other.Types)
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
            if (Types != null)
            {
                hash = hash * 59 + Types.GetHashCode();
            }

            return hash;
        }
    }
}
