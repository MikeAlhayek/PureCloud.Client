namespace PureCloud.Client.Models;

public sealed class RecordersState
{
    /// <summary>
    /// Indicates the state of the adhoc recorder.
    /// </summary>
    /// <value>Indicates the state of the adhoc recorder.</value>
    public RecordersStateAdhocState? AdhocState { get; set; }

    /// <summary>
    /// Indicates the state of the customer experience recorder.
    /// </summary>
    /// <value>Indicates the state of the customer experience recorder.</value>
    public RecordersStateCustomerExperienceState? CustomerExperienceState { get; set; }

    /// <summary>
    /// Indicates the state of the agent experience recorder.
    /// </summary>
    /// <value>Indicates the state of the agent experience recorder.</value>
    public RecordersStateAgentExperienceState? AgentExperienceState { get; set; }
}
