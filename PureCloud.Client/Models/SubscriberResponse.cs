using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SubscriberResponse
/// </summary>
[DataContract]
public partial class SubscriberResponse : IEquatable<SubscriberResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriberResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SubscriberResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriberResponse" /> class.
    /// </summary>
    /// <param name="MessageReturned">Suggested valid addresses.</param>
    /// <param name="Status">http status (required).</param>
    public SubscriberResponse(List<string> MessageReturned = null, string Status = null)
    {
        this.MessageReturned = MessageReturned;
        this.Status = Status;

    }



    /// <summary>
    /// Suggested valid addresses
    /// </summary>
    /// <value>Suggested valid addresses</value>
    [DataMember(Name = "messageReturned", EmitDefaultValue = false)]
    public List<string> MessageReturned { get; set; }



    /// <summary>
    /// http status
    /// </summary>
    /// <value>http status</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public string Status { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SubscriberResponse {\n");

        sb.Append("  MessageReturned: ").Append(MessageReturned).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as SubscriberResponse);
    }

    /// <summary>
    /// Returns true if SubscriberResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SubscriberResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SubscriberResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessageReturned == other.MessageReturned ||
                MessageReturned != null &&
                MessageReturned.SequenceEqual(other.MessageReturned)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (MessageReturned != null)
            {
                hash = hash * 59 + MessageReturned.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
