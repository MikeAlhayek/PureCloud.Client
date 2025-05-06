using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationCallEventTopicCallConversation
{
    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    public RecordingStateEnum? RecordingState { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    public IEnumerable<QueueConversationCallEventTopicCallMediaParticipant> Participants { get; set; }

    /// <summary>
    /// Gets or Sets OtherMediaUris
    /// </summary>
    public IEnumerable<string> OtherMediaUris { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    public string UtilizationLabelId { get; set; }

    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    public IEnumerable<QueueConversationCallEventTopicConversationDivisionMembership> Divisions { get; set; }

    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    public bool? SecurePause { get; set; }

    /// <summary>
    /// Gets or Sets MaxParticipants
    /// </summary>
    public long? MaxParticipants { get; set; }
}
