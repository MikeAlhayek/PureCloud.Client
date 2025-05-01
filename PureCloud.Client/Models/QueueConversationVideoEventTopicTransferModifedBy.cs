using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Fields identifying the entity that updated the command.
/// </summary>
[DataContract]
public partial class QueueConversationVideoEventTopicTransferModifedBy : IEquatable<QueueConversationVideoEventTopicTransferModifedBy>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicTransferModifedBy" /> class.
    /// </summary>
    /// <param name="Id">The id of the user if the updater is an internal user..</param>
    /// <param name="SelfUri">The URI for the user if the updater is an internal user..</param>
    public QueueConversationVideoEventTopicTransferModifedBy(string Id = null, string SelfUri = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// The id of the user if the updater is an internal user.
    /// </summary>
    /// <value>The id of the user if the updater is an internal user.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The URI for the user if the updater is an internal user.
    /// </summary>
    /// <value>The URI for the user if the updater is an internal user.</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicTransferModifedBy {\n");

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
        return Equals(obj as QueueConversationVideoEventTopicTransferModifedBy);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicTransferModifedBy instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicTransferModifedBy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicTransferModifedBy other)
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
