using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SubjectDivisions
/// </summary>

public partial class SubjectDivisions : IEquatable<SubjectDivisions>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SubjectDivisions" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SubjectDivisions() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SubjectDivisions" /> class.
    /// </summary>
    /// <param name="SubjectIds">A collection of subject IDs to associate with the given divisions (required).</param>
    /// <param name="DivisionIds">A collection of division IDs to associate with the given subjects (required).</param>
    public SubjectDivisions(List<string> SubjectIds = null, List<string> DivisionIds = null)
    {
        this.SubjectIds = SubjectIds;
        this.DivisionIds = DivisionIds;

    }



    /// <summary>
    /// A collection of subject IDs to associate with the given divisions
    /// </summary>
    /// <value>A collection of subject IDs to associate with the given divisions</value>
    [JsonPropertyName("subjectIds")]
    public List<string> SubjectIds { get; set; }



    /// <summary>
    /// A collection of division IDs to associate with the given subjects
    /// </summary>
    /// <value>A collection of division IDs to associate with the given subjects</value>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SubjectDivisions {\n");

        sb.Append("  SubjectIds: ").Append(SubjectIds).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
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
        return Equals(obj as SubjectDivisions);
    }

    /// <summary>
    /// Returns true if SubjectDivisions instances are equal
    /// </summary>
    /// <param name="other">Instance of SubjectDivisions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SubjectDivisions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SubjectIds == other.SubjectIds ||
                SubjectIds != null &&
                SubjectIds.SequenceEqual(other.SubjectIds)
            ) &&
            (
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
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
            if (SubjectIds != null)
            {
                hash = hash * 59 + SubjectIds.GetHashCode();
            }

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            return hash;
        }
    }
}
