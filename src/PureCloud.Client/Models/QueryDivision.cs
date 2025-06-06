using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryDivision
/// </summary>

public partial class QueryDivision : IEquatable<QueryDivision>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryDivision" /> class.
    /// </summary>
    public QueryDivision()
    {

    }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryDivision {\n");

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
        return Equals(obj as QueryDivision);
    }

    /// <summary>
    /// Returns true if QueryDivision instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryDivision to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryDivision other)
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
