namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsFlow
{
    /// <summary>
    /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
    /// </summary>
    /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
    public AnalyticsFlowEntryType? EntryType { get; set; }

    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    public AnalyticsFlowType? FlowType { get; set; }

    /// <summary>
    /// Flow ending language, e.g. en-us
    /// </summary>
    /// <value>Flow ending language, e.g. en-us</value>
    public string EndingLanguage { get; set; }

    /// <summary>
    /// The particular entry reason for this flow, e.g. an address, userId, or flowId
    /// </summary>
    /// <value>The particular entry reason for this flow, e.g. an address, userId, or flowId</value>
    public string EntryReason { get; set; }

    /// <summary>
    /// The exit reason for this flow, e.g. DISCONNECT
    /// </summary>
    /// <value>The exit reason for this flow, e.g. DISCONNECT</value>
    public string ExitReason { get; set; }

    /// <summary>
    /// The unique identifier of this flow
    /// </summary>
    /// <value>The unique identifier of this flow</value>
    public string FlowId { get; set; }

    /// <summary>
    /// The name of this flow at the time of flow execution
    /// </summary>
    /// <value>The name of this flow at the time of flow execution</value>
    public string FlowName { get; set; }

    /// <summary>
    /// The version of this flow
    /// </summary>
    /// <value>The version of this flow</value>
    public string FlowVersion { get; set; }

    /// <summary>
    /// Flag indicating whether the flow issued a callback
    /// </summary>
    /// <value>Flag indicating whether the flow issued a callback</value>
    public bool? IssuedCallback { get; set; }

    /// <summary>
    /// The recognition failure reason causing to exit/disconnect
    /// </summary>
    /// <value>The recognition failure reason causing to exit/disconnect</value>
    public string RecognitionFailureReason { get; set; }

    /// <summary>
    /// Flow starting language, e.g. en-us
    /// </summary>
    /// <value>Flow starting language, e.g. en-us</value>
    public string StartingLanguage { get; set; }

    /// <summary>
    /// The address of a flow transfer target, e.g. a phone number, an email address, or a queueId
    /// </summary>
    /// <value>The address of a flow transfer target, e.g. a phone number, an email address, or a queueId</value>
    public string TransferTargetAddress { get; set; }

    /// <summary>
    /// The name of a flow transfer target
    /// </summary>
    /// <value>The name of a flow transfer target</value>
    public string TransferTargetName { get; set; }

    /// <summary>
    /// The type of transfer for flows that ended with a transfer
    /// </summary>
    /// <value>The type of transfer for flows that ended with a transfer</value>
    public string TransferType { get; set; }

    /// <summary>
    /// Flow outcomes
    /// </summary>
    /// <value>Flow outcomes</value>
    public IEnumerable<AnalyticsFlowOutcome> Outcomes { get; set; }
}
