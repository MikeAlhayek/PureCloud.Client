namespace PureCloud.Client.Models;

public sealed class AutoAnswerSettings
{
    /// <summary>
    /// Map of conversation media type enabled status.
    /// </summary>
    /// <value>Map of conversation media type enabled status.</value>
    public Dictionary<string, AutoAnswerSetting> Settings { get; set; }
}
