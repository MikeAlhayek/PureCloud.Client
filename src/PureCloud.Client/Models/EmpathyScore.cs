namespace PureCloud.Client.Models;

/// <summary>
/// EmpathyScore
/// </summary>
public sealed class EmpathyScore
{
    /// <summary>
    /// Empathy score of the agent involved in the conversation
    /// </summary>
    /// <value>Empathy score of the agent involved in the conversation</value>
    public double? Score { get; set; }

    /// <summary>
    /// UserId of the agent involved in the conversation
    /// </summary>
    /// <value>UserId of the agent involved in the conversation</value>
    public string UserId { get; set; }
}