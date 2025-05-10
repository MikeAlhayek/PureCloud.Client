namespace PureCloud.Client.Models;

public sealed class MessageSticker
{
    /// <summary>
    /// The location of the sticker, useful for retrieving it
    /// </summary>
    /// <value>The location of the sticker, useful for retrieving it</value>
    public string Url { get; set; }

    /// <summary>
    /// The unique id of the the sticker object.
    /// </summary>
    /// <value>The unique id of the the sticker object.</value>
    public string Id { get; set; }
}
