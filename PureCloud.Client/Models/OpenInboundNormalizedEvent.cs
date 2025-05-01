using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Open Event Messaging rich media message structure
/// </summary>
[DataContract]
public partial class OpenInboundNormalizedEvent : IEquatable<OpenInboundNormalizedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundNormalizedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenInboundNormalizedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenInboundNormalizedEvent" /> class.
    /// </summary>
    /// <param name="Channel">Channel-specific information that describes the message and the message channel/provider. (required).</param>
    /// <param name="Events">List of event elements. (required).</param>
    public OpenInboundNormalizedEvent(OpenInboundMessagingChannel Channel = null, List<OpenEvent> Events = null)
    {
        this.Channel = Channel;
        this.Events = Events;

    }



    /// <summary>
    /// Channel-specific information that describes the message and the message channel/provider.
    /// </summary>
    /// <value>Channel-specific information that describes the message and the message channel/provider.</value>
    [DataMember(Name = "channel", EmitDefaultValue = false)]
    public OpenInboundMessagingChannel Channel { get; set; }



    /// <summary>
    /// List of event elements.
    /// </summary>
    /// <value>List of event elements.</value>
    [DataMember(Name = "events", EmitDefaultValue = false)]
    public List<OpenEvent> Events { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenInboundNormalizedEvent {\n");

        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
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
        return Equals(obj as OpenInboundNormalizedEvent);
    }

    /// <summary>
    /// Returns true if OpenInboundNormalizedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenInboundNormalizedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenInboundNormalizedEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Channel == other.Channel ||
                Channel != null &&
                Channel.Equals(other.Channel)
            ) &&
            (
                Events == other.Events ||
                Events != null &&
                Events.SequenceEqual(other.Events)
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
            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Events != null)
            {
                hash = hash * 59 + Events.GetHashCode();
            }

            return hash;
        }
    }
}
