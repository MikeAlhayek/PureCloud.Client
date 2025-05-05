namespace PureCloud.Client.Models;

public sealed class AcwSettings
{
    /// <summary>
    /// This field controls how the UI prompts the agent for a wrapup.
    /// </summary>
    /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
    public WrapupPromptEnum? WrapupPrompt { get; set; }

    /// <summary>
    /// The amount of time the agent can stay in ACW (Min: 1 sec, Max: 60 min).  Can only be used when ACW is AGENT_REQUESTED, MANDATORY_TIMEOUT or MANDATORY_FORCED_TIMEOUT.
    /// </summary>
    /// <value>The amount of time the agent can stay in ACW (Min: 1 sec, Max: 60 min).  Can only be used when ACW is AGENT_REQUESTED, MANDATORY_TIMEOUT or MANDATORY_FORCED_TIMEOUT.</value>
    public int? TimeoutMs { get; set; }
}
