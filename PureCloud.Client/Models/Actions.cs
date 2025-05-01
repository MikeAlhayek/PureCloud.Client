using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Actions
/// </summary>
[DataContract]
public partial class Actions : IEquatable<Actions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Actions" /> class.
    /// </summary>
    /// <param name="SkillsToRemove">SkillsToRemove.</param>
    public Actions(List<SkillsToRemove> SkillsToRemove = null)
    {
        this.SkillsToRemove = SkillsToRemove;

    }



    /// <summary>
    /// Gets or Sets SkillsToRemove
    /// </summary>
    [DataMember(Name = "skillsToRemove", EmitDefaultValue = false)]
    public List<SkillsToRemove> SkillsToRemove { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Actions {\n");

        sb.Append("  SkillsToRemove: ").Append(SkillsToRemove).Append("\n");
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
        return Equals(obj as Actions);
    }

    /// <summary>
    /// Returns true if Actions instances are equal
    /// </summary>
    /// <param name="other">Instance of Actions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Actions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SkillsToRemove == other.SkillsToRemove ||
                SkillsToRemove != null &&
                SkillsToRemove.SequenceEqual(other.SkillsToRemove)
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
            if (SkillsToRemove != null)
            {
                hash = hash * 59 + SkillsToRemove.GetHashCode();
            }

            return hash;
        }
    }
}
