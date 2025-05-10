namespace PureCloud.Client.Models;

public sealed class JourneyAction
{
    /// <summary>
    /// The ID of an action from the Journey System (an action is spawned from an actionMap)
    /// </summary>
    /// <value>The ID of an action from the Journey System (an action is spawned from an actionMap)</value>
    public string Id { get; set; }

    /// <summary>
    /// Details about the action map from the Journey System which triggered this action
    /// </summary>
    /// <value>Details about the action map from the Journey System which triggered this action</value>
    public JourneyActionMap ActionMap { get; set; }
}
