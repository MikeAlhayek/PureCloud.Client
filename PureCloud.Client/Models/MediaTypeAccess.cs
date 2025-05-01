using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Media type access definitions
/// </summary>
[DataContract]
public partial class MediaTypeAccess : IEquatable<MediaTypeAccess>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaTypeAccess" /> class.
    /// </summary>
    /// <param name="Inbound">List of media types allowed for inbound messages from customers. If inbound messages from a customer contain media that is not in this list, the media will be dropped from the outbound message..</param>
    /// <param name="Outbound">List of media types allowed for outbound messages to customers. If an outbound message is sent that contains media that is not in this list, the message will not be sent..</param>
    public MediaTypeAccess(List<MediaType> Inbound = null, List<MediaType> Outbound = null)
    {
        this.Inbound = Inbound;
        this.Outbound = Outbound;

    }



    /// <summary>
    /// List of media types allowed for inbound messages from customers. If inbound messages from a customer contain media that is not in this list, the media will be dropped from the outbound message.
    /// </summary>
    /// <value>List of media types allowed for inbound messages from customers. If inbound messages from a customer contain media that is not in this list, the media will be dropped from the outbound message.</value>
    [DataMember(Name = "inbound", EmitDefaultValue = false)]
    public List<MediaType> Inbound { get; set; }



    /// <summary>
    /// List of media types allowed for outbound messages to customers. If an outbound message is sent that contains media that is not in this list, the message will not be sent.
    /// </summary>
    /// <value>List of media types allowed for outbound messages to customers. If an outbound message is sent that contains media that is not in this list, the message will not be sent.</value>
    [DataMember(Name = "outbound", EmitDefaultValue = false)]
    public List<MediaType> Outbound { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaTypeAccess {\n");

        sb.Append("  Inbound: ").Append(Inbound).Append("\n");
        sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
        return Equals(obj as MediaTypeAccess);
    }

    /// <summary>
    /// Returns true if MediaTypeAccess instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaTypeAccess to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaTypeAccess other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Inbound == other.Inbound ||
                Inbound != null &&
                Inbound.SequenceEqual(other.Inbound)
            ) &&
            (
                Outbound == other.Outbound ||
                Outbound != null &&
                Outbound.SequenceEqual(other.Outbound)
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
            if (Inbound != null)
            {
                hash = hash * 59 + Inbound.GetHashCode();
            }

            if (Outbound != null)
            {
                hash = hash * 59 + Outbound.GetHashCode();
            }

            return hash;
        }
    }
}
