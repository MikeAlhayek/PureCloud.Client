using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicDataSchema
/// </summary>
[DataContract]
public partial class ExternalContactsUnresolvedContactChangedTopicDataSchema : IEquatable<ExternalContactsUnresolvedContactChangedTopicDataSchema>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicDataSchema" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Version">Version.</param>
    public ExternalContactsUnresolvedContactChangedTopicDataSchema(string Id = null, long? Version = null)
    {
        this.Id = Id;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicDataSchema {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return this.Equals(obj as ExternalContactsUnresolvedContactChangedTopicDataSchema);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicDataSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicDataSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicDataSchema other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            return hash;
        }
    }
}
