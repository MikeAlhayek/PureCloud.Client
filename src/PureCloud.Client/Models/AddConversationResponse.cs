using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AddConversationResponse
{
    /// <summary>
    /// The conversation reference
    /// </summary>
    /// <value>The conversation reference</value>
    public ConversationReference Conversation { get; set; }

    /// <summary>
    /// The appointment reference
    /// </summary>
    /// <value>The appointment reference</value>
    public CoachingAppointmentReference Appointment { get; set; }
}
