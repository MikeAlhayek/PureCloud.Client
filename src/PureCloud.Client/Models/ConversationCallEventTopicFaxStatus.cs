namespace PureCloud.Client.Models;

public sealed class ConversationCallEventTopicFaxStatus
{
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public string Direction { get; set; }


    /// <summary>
    /// Gets or Sets ExpectedPages
    /// </summary>
    public long? ExpectedPages { get; set; }


    /// <summary>
    /// Gets or Sets ActivePage
    /// </summary>
    public long? ActivePage { get; set; }


    /// <summary>
    /// Gets or Sets LinesTransmitted
    /// </summary>
    public long? LinesTransmitted { get; set; }


    /// <summary>
    /// Gets or Sets BytesTransmitted
    /// </summary>
    public long? BytesTransmitted { get; set; }


    /// <summary>
    /// Gets or Sets DataRate
    /// </summary>
    public long? DataRate { get; set; }


    /// <summary>
    /// Gets or Sets PageErrors
    /// </summary>
    public long? PageErrors { get; set; }


    /// <summary>
    /// Gets or Sets LineErrors
    /// </summary>
    public long? LineErrors { get; set; }
}
