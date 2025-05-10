namespace PureCloud.Client.Models;

/// <summary>
/// QuestionSettings
/// </summary>

public sealed class QuestionSettings
{
    /// <summary>
    /// The context id of the question in the group
    /// </summary>
    /// <value>The context id of the question in the group</value>
    public string QuestionContextId { get; set; }

    /// <summary>
    /// Gets or Sets Settings
    /// </summary>
    public AiScoringSetting Settings { get; set; }
}
