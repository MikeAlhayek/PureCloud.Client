namespace PureCloud.Client.Models;

public sealed class TopicOffset
{
    /// <summary>
    /// Count of words before the topic 
    /// </summary>
    /// <value>Count of words before the topic </value>
    public long? WordCount { get; set; }

    /// <summary>
    /// Count of characters before the topic 
    /// </summary>
    /// <value>Count of characters before the topic </value>
    public long? CharacterCount { get; set; }
}
