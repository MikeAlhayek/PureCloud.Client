using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AddConversationResponse
/// </summary>
[DataContract]
public partial class AddConversationResponse : IEquatable<AddConversationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddConversationResponse" /> class.
    /// </summary>
    public AddConversationResponse()
    {

    }



    /// <summary>
    /// The conversation reference
    /// </summary>
    /// <value>The conversation reference</value>
    [DataMember(Name = "conversation", EmitDefaultValue = false)]
    public ConversationReference Conversation { get; private set; }



    /// <summary>
    /// The appointment reference
    /// </summary>
    /// <value>The appointment reference</value>
    [DataMember(Name = "appointment", EmitDefaultValue = false)]
    public CoachingAppointmentReference Appointment { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddConversationResponse {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Appointment: ").Append(Appointment).Append("\n");
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
        return Equals(obj as AddConversationResponse);
    }

    /// <summary>
    /// Returns true if AddConversationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AddConversationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AddConversationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Appointment == other.Appointment ||
                Appointment != null &&
                Appointment.Equals(other.Appointment)
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
            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Appointment != null)
            {
                hash = hash * 59 + Appointment.GetHashCode();
            }

            return hash;
        }
    }
}
