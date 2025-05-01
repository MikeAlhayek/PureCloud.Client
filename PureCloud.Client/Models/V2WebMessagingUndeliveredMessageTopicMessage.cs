using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WebMessagingUndeliveredMessageTopicMessage
/// </summary>
[DataContract]
public partial class V2WebMessagingUndeliveredMessageTopicMessage : IEquatable<V2WebMessagingUndeliveredMessageTopicMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WebMessagingUndeliveredMessageTopicMessage" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="EventTimeMs">EventTimeMs.</param>
    public V2WebMessagingUndeliveredMessageTopicMessage(string Id = null, long? EventTimeMs = null)
    {
        this.Id = Id;
        this.EventTimeMs = EventTimeMs;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets EventTimeMs
    /// </summary>
    [DataMember(Name = "eventTimeMs", EmitDefaultValue = false)]
    public long? EventTimeMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WebMessagingUndeliveredMessageTopicMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  EventTimeMs: ").Append(EventTimeMs).Append("\n");
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
        return Equals(obj as V2WebMessagingUndeliveredMessageTopicMessage);
    }

    /// <summary>
    /// Returns true if V2WebMessagingUndeliveredMessageTopicMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WebMessagingUndeliveredMessageTopicMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WebMessagingUndeliveredMessageTopicMessage other)
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
                EventTimeMs == other.EventTimeMs ||
                EventTimeMs != null &&
                EventTimeMs.Equals(other.EventTimeMs)
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

            if (EventTimeMs != null)
            {
                hash = hash * 59 + EventTimeMs.GetHashCode();
            }

            return hash;
        }
    }
}
