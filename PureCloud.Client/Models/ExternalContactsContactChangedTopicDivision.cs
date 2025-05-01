using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactChangedTopicDivision
/// </summary>
[DataContract]
public partial class ExternalContactsContactChangedTopicDivision : IEquatable<ExternalContactsContactChangedTopicDivision>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicDivision" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    public ExternalContactsContactChangedTopicDivision(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsContactChangedTopicDivision {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as ExternalContactsContactChangedTopicDivision);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactChangedTopicDivision instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactChangedTopicDivision to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactChangedTopicDivision other)
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

            return hash;
        }
    }
}
