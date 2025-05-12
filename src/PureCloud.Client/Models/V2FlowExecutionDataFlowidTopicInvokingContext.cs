using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicInvokingContext
{
    /// <summary>
    /// Gets or Sets Flow
    /// </summary>
    public V2FlowExecutionDataFlowidTopicFlow Flow { get; set; }

    /// <summary>
    /// Gets or Sets JourneyActionMap
    /// </summary>
    public V2FlowExecutionDataFlowidTopicJourneyActionMap JourneyActionMap { get; set; }

    /// <summary>
    /// Gets or Sets ProcessAutomation
    /// </summary>
    public V2FlowExecutionDataFlowidTopicProcessAutomation ProcessAutomation { get; set; }

    /// <summary>
    /// Gets or Sets Quality
    /// </summary>
    public V2FlowExecutionDataFlowidTopicQuality Quality { get; set; }

    /// <summary>
    /// Gets or Sets Workitem
    /// </summary>
    public V2FlowExecutionDataFlowidTopicWorkitem Workitem { get; set; }
}
