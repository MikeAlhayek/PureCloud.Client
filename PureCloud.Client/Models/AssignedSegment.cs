using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssignedSegment
/// </summary>

public partial class AssignedSegment : IEquatable<AssignedSegment>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AssignedSegment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssignedSegment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssignedSegment" /> class.
    /// </summary>
    /// <param name="Id">The ID of the segment assigned. (required).</param>
    public AssignedSegment(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The ID of the segment assigned.
    /// </summary>
    /// <value>The ID of the segment assigned.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssignedSegment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as AssignedSegment);
    }

    /// <summary>
    /// Returns true if AssignedSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of AssignedSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssignedSegment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
