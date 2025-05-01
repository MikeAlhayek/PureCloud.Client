using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueUserEventTopicQueueMember
/// </summary>
[DataContract]
public partial class QueueUserEventTopicQueueMember : IEquatable<QueueUserEventTopicQueueMember>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueUserEventTopicQueueMember" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="User">User.</param>
    /// <param name="QueueId">QueueId.</param>
    /// <param name="Joined">Joined.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public QueueUserEventTopicQueueMember(string Id = null, QueueUserEventTopicUserReference User = null, string QueueId = null, bool? Joined = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Id = Id;
        this.User = User;
        this.QueueId = QueueId;
        this.Joined = Joined;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public QueueUserEventTopicUserReference User { get; set; }



    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Gets or Sets Joined
    /// </summary>
    [DataMember(Name = "joined", EmitDefaultValue = false)]
    public bool? Joined { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueUserEventTopicQueueMember {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  Joined: ").Append(Joined).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as QueueUserEventTopicQueueMember);
    }

    /// <summary>
    /// Returns true if QueueUserEventTopicQueueMember instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueUserEventTopicQueueMember to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueUserEventTopicQueueMember other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                Joined == other.Joined ||
                Joined != null &&
                Joined.Equals(other.Joined)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (Joined != null)
            {
                hash = hash * 59 + Joined.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
