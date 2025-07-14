using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InitialConfiguration
{
    /// <summary>
    /// Indicates the initial audio state for the communication.
    /// </summary>
    /// <value>Indicates the initial audio state for the communication.</value>
    public AudioState AudioState { get; set; }

    /// <summary>
    /// Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.</value>
    public bool? Alerting { get; set; }

    /// <summary>
    /// Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.
    /// </summary>
    /// <value>Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.</value>
    public bool? Inbound { get; set; }

    /// <summary>
    /// The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.
    /// </summary>
    /// <value>The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.</value>
    public string InvitedBy { get; set; }

    /// <summary>
    /// Indicates whether recording is active for this communication at creation.
    /// </summary>
    /// <value>Indicates whether recording is active for this communication at creation.</value>
    public bool? RecordingActive { get; set; }

    /// <summary>
    /// Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.
    /// </summary>
    /// <value>Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.</value>
    public Dictionary<string, string> AdditionalInfo { get; set; }
}
