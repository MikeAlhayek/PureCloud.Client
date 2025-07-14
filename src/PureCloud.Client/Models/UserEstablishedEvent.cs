using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserEstablishedEvent
{
    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    public string EventId { get; set; }

    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventDateTime { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication</value>
    public string CommunicationId { get; set; }

    /// <summary>
    /// Identifies the phone number used to reach this user if it is different from the information that would be accessed by userId.
    /// </summary>
    /// <value>Identifies the phone number used to reach this user if it is different from the information that would be accessed by userId.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The userId (V4 UUID) for the user this communication belongs to.
    /// </summary>
    /// <value>The userId (V4 UUID) for the user this communication belongs to.</value>
    public string UserId { get; set; }

    /// <summary>
    /// A Station ID (V4 UUID) that identifies the station being used if the user is using a station and the stationId is known.
    /// </summary>
    /// <value>A Station ID (V4 UUID) that identifies the station being used if the user is using a station and the stationId is known.</value>
    public string StationId { get; set; }

    /// <summary>
    /// The automatic number identification if it is available for this conversation.
    /// </summary>
    /// <value>The automatic number identification if it is available for this conversation.</value>
    public string Ani { get; set; }

    /// <summary>
    /// The dialed number identification if it is available for this conversation.
    /// </summary>
    /// <value>The dialed number identification if it is available for this conversation.</value>
    public string Dnis { get; set; }

    /// <summary>
    /// Indicates whether or not this user will be required to complete after call work.
    /// </summary>
    /// <value>Indicates whether or not this user will be required to complete after call work.</value>
    public bool? AfterCallWorkRequired { get; set; }

    /// <summary>
    /// The id (V4 UUID) of the queue that the user is calling on behalf of. Applies to outbound calls only.
    /// </summary>
    /// <value>The id (V4 UUID) of the queue that the user is calling on behalf of. Applies to outbound calls only.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    public InitialConfiguration InitialConfiguration { get; set; }

    /// <summary>
    /// Metadata about the source of this communication&#39;s interaction.
    /// </summary>
    /// <value>Metadata about the source of this communication&#39;s interaction.</value>
    public SourceConfiguration SourceConfiguration { get; set; }
}
