using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PresenceDefinition
/// </summary>
[DataContract]
public partial class PresenceDefinition : IEquatable<PresenceDefinition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PresenceDefinition" /> class.
    /// </summary>
    /// <param name="Id">description.</param>
    /// <param name="SystemPresence">SystemPresence.</param>
    public PresenceDefinition(string Id = null, string SystemPresence = null)
    {
        this.Id = Id;
        this.SystemPresence = SystemPresence;

    }



    /// <summary>
    /// description
    /// </summary>
    /// <value>description</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    [DataMember(Name = "systemPresence", EmitDefaultValue = false)]
    public string SystemPresence { get; set; }



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
        sb.Append("class PresenceDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
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
        return Equals(obj as PresenceDefinition);
    }

    /// <summary>
    /// Returns true if PresenceDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of PresenceDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PresenceDefinition other)
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
                SystemPresence == other.SystemPresence ||
                SystemPresence != null &&
                SystemPresence.Equals(other.SystemPresence)
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

            if (SystemPresence != null)
            {
                hash = hash * 59 + SystemPresence.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
