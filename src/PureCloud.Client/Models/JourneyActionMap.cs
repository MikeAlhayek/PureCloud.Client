namespace PureCloud.Client.Models;

public sealed class JourneyActionMap
{
    /// <summary>
    /// The ID of the actionMap in the Journey System which triggered this action
    /// </summary>
    /// <value>The ID of the actionMap in the Journey System which triggered this action</value>
    public string Id { get; set; }

    /// <summary>
    /// The version number of the actionMap in the Journey System at the time this action was triggered
    /// </summary>
    /// <value>The version number of the actionMap in the Journey System at the time this action was triggered</value>
    public int? Version { get; set; }
}
