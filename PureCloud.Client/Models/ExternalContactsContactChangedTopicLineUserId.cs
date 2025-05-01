using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactChangedTopicLineUserId
/// </summary>
[DataContract]
public partial class ExternalContactsContactChangedTopicLineUserId : IEquatable<ExternalContactsContactChangedTopicLineUserId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicLineUserId" /> class.
    /// </summary>
    /// <param name="UserId">UserId.</param>
    public ExternalContactsContactChangedTopicLineUserId(string UserId = null)
    {
        this.UserId = UserId;

    }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsContactChangedTopicLineUserId {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return this.Equals(obj as ExternalContactsContactChangedTopicLineUserId);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactChangedTopicLineUserId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactChangedTopicLineUserId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactChangedTopicLineUserId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.UserId == other.UserId ||
                this.UserId != null &&
                this.UserId.Equals(other.UserId)
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
            if (this.UserId != null)
            {
                hash = hash * 59 + this.UserId.GetHashCode();
            }

            return hash;
        }
    }
}
