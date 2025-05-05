using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UCIcon
/// </summary>

public partial class UCIcon : IEquatable<UCIcon>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UCIcon" /> class.
    /// </summary>
    public UCIcon()
    {

    }



    /// <summary>
    /// vector
    /// </summary>
    /// <value>vector</value>
    [JsonPropertyName("vector")]
    public string Vector { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UCIcon {\n");

        sb.Append("  Vector: ").Append(Vector).Append("\n");
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
        return Equals(obj as UCIcon);
    }

    /// <summary>
    /// Returns true if UCIcon instances are equal
    /// </summary>
    /// <param name="other">Instance of UCIcon to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UCIcon other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Vector == other.Vector ||
                Vector != null &&
                Vector.Equals(other.Vector)
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
            if (Vector != null)
            {
                hash = hash * 59 + Vector.GetHashCode();
            }

            return hash;
        }
    }
}
