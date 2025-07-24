namespace PureCloud.Client.Models;

/// <summary>
/// ParticipantMetrics
/// </summary>
public sealed class ParticipantMetrics
{
    /// <summary>
    /// Percentage of Agent duration in the conversation
    /// </summary>
    /// <value>Percentage of Agent duration in the conversation</value>
    public double? AgentDurationPercentage { get; set; }

    /// <summary>
    /// Percentage of Customer duration in the conversation
    /// </summary>
    /// <value>Percentage of Customer duration in the conversation</value>
    public double? CustomerDurationPercentage { get; set; }

    /// <summary>
    /// Percentage of Silence duration in the conversation
    /// </summary>
    /// <value>Percentage of Silence duration in the conversation</value>
    public double? SilenceDurationPercentage { get; set; }

    /// <summary>
    /// Percentage of IVR duration in the conversation
    /// </summary>
    /// <value>Percentage of IVR duration in the conversation</value>
    public double? IvrDurationPercentage { get; set; }

    /// <summary>
    /// Percentage of ACD duration in the conversation
    /// </summary>
    /// <value>Percentage of ACD duration in the conversation</value>
    public double? AcdDurationPercentage { get; set; }

    /// <summary>
    /// Percentage of Overtalk duration in the conversation
    /// </summary>
    /// <value>Percentage of Overtalk duration in the conversation</value>
    public double? OvertalkDurationPercentage { get; set; }

    /// <summary>
    /// Percentage of Other events duration in the conversation
    /// </summary>
    /// <value>Percentage of Other events duration in the conversation</value>
    public double? OtherDurationPercentage { get; set; }

    /// <summary>
    /// Number of Overtalks in the conversation
    /// </summary>
    /// <value>Number of Overtalks in the conversation</value>
    public int? OvertalkCount { get; set; }
}