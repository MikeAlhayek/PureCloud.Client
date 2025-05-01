using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestDisqualifiedAgents
/// </summary>
[DataContract]
public partial class ContestDisqualifiedAgents : IEquatable<ContestDisqualifiedAgents>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestDisqualifiedAgents" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Note">The disqualification explanation.</param>
    public ContestDisqualifiedAgents(string Id = null, string Note = null)
    {
        this.Id = Id;
        this.Note = Note;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The disqualification explanation
    /// </summary>
    /// <value>The disqualification explanation</value>
    [DataMember(Name = "note", EmitDefaultValue = false)]
    public string Note { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestDisqualifiedAgents {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
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
        return Equals(obj as ContestDisqualifiedAgents);
    }

    /// <summary>
    /// Returns true if ContestDisqualifiedAgents instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestDisqualifiedAgents to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestDisqualifiedAgents other)
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
                Note == other.Note ||
                Note != null &&
                Note.Equals(other.Note)
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

            if (Note != null)
            {
                hash = hash * 59 + Note.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
