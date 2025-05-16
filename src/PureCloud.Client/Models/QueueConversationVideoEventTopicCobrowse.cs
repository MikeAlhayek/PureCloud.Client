using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationVideoEventTopicCobrowse
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public QueueConversationVideoEventTopicCobrowseStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public QueueConversationVideoEventTopicCobrowseInitialStateEnum? InitialState { get; set; }

    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    public QueueConversationVideoEventTopicCobrowseDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    public string Id { get; set; }

    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    public QueueConversationVideoEventTopicAddress Self { get; set; }

    /// <summary>
    /// The room id for the chat.
    /// </summary>
    /// <value>The room id for the chat.</value>
    public string RoomId { get; set; }

    /// <summary>
    /// The co-browse session ID.
    /// </summary>
    /// <value>The co-browse session ID.</value>
    public string CobrowseSessionId { get; set; }

    /// <summary>
    /// This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).
    /// </summary>
    /// <value>This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).</value>
    public string CobrowseRole { get; set; }

    /// <summary>
    /// ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).
    /// </summary>
    /// <value>ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).</value>
    public IEnumerable<string> Controlling { get; set; }

    /// <summary>
    /// The URL that can be used to open co-browse session in web browser.
    /// </summary>
    /// <value>The URL that can be used to open co-browse session in web browser.</value>
    public string ViewerUrl { get; set; }

    /// <summary>
    /// The source provider of the co-browse communication.
    /// </summary>
    /// <value>The source provider of the co-browse communication.</value>
    public string Provider { get; set; }

    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    public string ScriptId { get; set; }

    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC).
    /// </summary>
    /// <value>The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC).</value>
    public DateTime? ProviderEventTime { get; set; }

    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock.</value>
    public DateTime? ConnectedTime { get; set; }

    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
    public DateTime? DisconnectedTime { get; set; }

    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    public QueueConversationVideoEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// A communication&#39;s after-call work data.
    /// </summary>
    /// <value>A communication&#39;s after-call work data.</value>
    public QueueConversationVideoEventTopicAfterCallWork AfterCallWork { get; set; }

    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    public bool? AfterCallWorkRequired { get; set; }

    /// <summary>
    /// Represents the queue setting for this media.
    /// </summary>
    /// <value>Represents the queue setting for this media.</value>
    public QueueConversationVideoEventTopicQueueMediaSettings QueueMediaSettings { get; set; }
}
