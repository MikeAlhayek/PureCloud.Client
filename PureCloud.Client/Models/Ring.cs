using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Ring
/// </summary>
[DataContract]
public partial class Ring : IEquatable<Ring>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Ring" /> class.
    /// </summary>
    /// <param name="ExpansionCriteria">The conditions that will trigger conversations to move to the next bullseye ring..</param>
    /// <param name="Actions">The actions that will be performed just before moving conversations to the next bullseye ring..</param>
    /// <param name="MemberGroups">The groups of agents associated with the ring, if any.  Ring membership will update to match group membership changes..</param>
    public Ring(List<ExpansionCriterium> ExpansionCriteria = null, Actions Actions = null, List<MemberGroup> MemberGroups = null)
    {
        this.ExpansionCriteria = ExpansionCriteria;
        this.Actions = Actions;
        this.MemberGroups = MemberGroups;

    }



    /// <summary>
    /// The conditions that will trigger conversations to move to the next bullseye ring.
    /// </summary>
    /// <value>The conditions that will trigger conversations to move to the next bullseye ring.</value>
    [DataMember(Name = "expansionCriteria", EmitDefaultValue = false)]
    public List<ExpansionCriterium> ExpansionCriteria { get; set; }



    /// <summary>
    /// The actions that will be performed just before moving conversations to the next bullseye ring.
    /// </summary>
    /// <value>The actions that will be performed just before moving conversations to the next bullseye ring.</value>
    [DataMember(Name = "actions", EmitDefaultValue = false)]
    public Actions Actions { get; set; }



    /// <summary>
    /// The groups of agents associated with the ring, if any.  Ring membership will update to match group membership changes.
    /// </summary>
    /// <value>The groups of agents associated with the ring, if any.  Ring membership will update to match group membership changes.</value>
    [DataMember(Name = "memberGroups", EmitDefaultValue = false)]
    public List<MemberGroup> MemberGroups { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Ring {\n");

        sb.Append("  ExpansionCriteria: ").Append(ExpansionCriteria).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
        sb.Append("  MemberGroups: ").Append(MemberGroups).Append("\n");
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
        return Equals(obj as Ring);
    }

    /// <summary>
    /// Returns true if Ring instances are equal
    /// </summary>
    /// <param name="other">Instance of Ring to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Ring other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExpansionCriteria == other.ExpansionCriteria ||
                ExpansionCriteria != null &&
                ExpansionCriteria.SequenceEqual(other.ExpansionCriteria)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.Equals(other.Actions)
            ) &&
            (
                MemberGroups == other.MemberGroups ||
                MemberGroups != null &&
                MemberGroups.SequenceEqual(other.MemberGroups)
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
            if (ExpansionCriteria != null)
            {
                hash = hash * 59 + ExpansionCriteria.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            if (MemberGroups != null)
            {
                hash = hash * 59 + MemberGroups.GetHashCode();
            }

            return hash;
        }
    }
}
