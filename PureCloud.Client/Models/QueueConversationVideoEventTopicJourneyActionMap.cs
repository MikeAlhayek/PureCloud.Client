using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about the action map from the Journey System which triggered this action
/// </summary>
[DataContract]
public partial class QueueConversationVideoEventTopicJourneyActionMap : IEquatable<QueueConversationVideoEventTopicJourneyActionMap>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicJourneyActionMap" /> class.
    /// </summary>
    /// <param name="Id">The ID of the actionMap in the Journey System which triggered this action.</param>
    /// <param name="Version">The version number of the actionMap in the Journey System at the time this action was triggered.</param>
    public QueueConversationVideoEventTopicJourneyActionMap(string Id = null, long? Version = null)
    {
        this.Id = Id;
        this.Version = Version;

    }



    /// <summary>
    /// The ID of the actionMap in the Journey System which triggered this action
    /// </summary>
    /// <value>The ID of the actionMap in the Journey System which triggered this action</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The version number of the actionMap in the Journey System at the time this action was triggered
    /// </summary>
    /// <value>The version number of the actionMap in the Journey System at the time this action was triggered</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicJourneyActionMap {\n");

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
        return Equals(obj as QueueConversationVideoEventTopicJourneyActionMap);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicJourneyActionMap instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicJourneyActionMap to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicJourneyActionMap other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
