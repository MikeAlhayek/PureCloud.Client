using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContentPositionProperties
/// </summary>

public partial class ContentPositionProperties : IEquatable<ContentPositionProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentPositionProperties" /> class.
    /// </summary>
    /// <param name="Top">Top positioning offset..</param>
    /// <param name="Bottom">Bottom positioning offset..</param>
    /// <param name="Left">Left positioning offset..</param>
    /// <param name="Right">Right positioning offset..</param>
    public ContentPositionProperties(string Top = null, string Bottom = null, string Left = null, string Right = null)
    {
        this.Top = Top;
        this.Bottom = Bottom;
        this.Left = Left;
        this.Right = Right;

    }



    /// <summary>
    /// Top positioning offset.
    /// </summary>
    /// <value>Top positioning offset.</value>
    [JsonPropertyName("top")]
    public string Top { get; set; }



    /// <summary>
    /// Bottom positioning offset.
    /// </summary>
    /// <value>Bottom positioning offset.</value>
    [JsonPropertyName("bottom")]
    public string Bottom { get; set; }



    /// <summary>
    /// Left positioning offset.
    /// </summary>
    /// <value>Left positioning offset.</value>
    [JsonPropertyName("left")]
    public string Left { get; set; }



    /// <summary>
    /// Right positioning offset.
    /// </summary>
    /// <value>Right positioning offset.</value>
    [JsonPropertyName("right")]
    public string Right { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentPositionProperties {\n");

        sb.Append("  Top: ").Append(Top).Append("\n");
        sb.Append("  Bottom: ").Append(Bottom).Append("\n");
        sb.Append("  Left: ").Append(Left).Append("\n");
        sb.Append("  Right: ").Append(Right).Append("\n");
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
        return Equals(obj as ContentPositionProperties);
    }

    /// <summary>
    /// Returns true if ContentPositionProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentPositionProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentPositionProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Top == other.Top ||
                Top != null &&
                Top.Equals(other.Top)
            ) &&
            (
                Bottom == other.Bottom ||
                Bottom != null &&
                Bottom.Equals(other.Bottom)
            ) &&
            (
                Left == other.Left ||
                Left != null &&
                Left.Equals(other.Left)
            ) &&
            (
                Right == other.Right ||
                Right != null &&
                Right.Equals(other.Right)
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
            if (Top != null)
            {
                hash = hash * 59 + Top.GetHashCode();
            }

            if (Bottom != null)
            {
                hash = hash * 59 + Bottom.GetHashCode();
            }

            if (Left != null)
            {
                hash = hash * 59 + Left.GetHashCode();
            }

            if (Right != null)
            {
                hash = hash * 59 + Right.GetHashCode();
            }

            return hash;
        }
    }
}
