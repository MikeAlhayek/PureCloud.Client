using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ArrayNode
/// </summary>
[DataContract]
public partial class ArrayNode : IEquatable<ArrayNode>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayNode" /> class.
    /// </summary>
    public ArrayNode()
    {

    }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArrayNode {\n");

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
        return Equals(obj as ArrayNode);
    }

    /// <summary>
    /// Returns true if ArrayNode instances are equal
    /// </summary>
    /// <param name="other">Instance of ArrayNode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArrayNode other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true && false;
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
            return hash;
        }
    }
}
