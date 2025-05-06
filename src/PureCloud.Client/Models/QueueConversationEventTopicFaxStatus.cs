using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationEventTopicFaxStatus
{
    /// <summary>
    /// The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;.
    /// </summary>
    /// <value>The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;.</value>
    public string Direction { get; set; }

    /// <summary>
    /// Total number of expected pages, if known.
    /// </summary>
    /// <value>Total number of expected pages, if known.</value>
    public long? ExpectedPages { get; set; }

    /// <summary>
    /// Active page of the transmission.
    /// </summary>
    /// <value>Active page of the transmission.</value>
    public long? ActivePage { get; set; }

    /// <summary>
    /// Number of lines that have completed transmission.
    /// </summary>
    /// <value>Number of lines that have completed transmission.</value>
    public long? LinesTransmitted { get; set; }

    /// <summary>
    /// Number of bytes that have competed transmission.
    /// </summary>
    /// <value>Number of bytes that have competed transmission.</value>
    public long? BytesTransmitted { get; set; }

    /// <summary>
    /// Current signaling rate of transmission, baud rate.
    /// </summary>
    /// <value>Current signaling rate of transmission, baud rate.</value>
    public long? BaudRate { get; set; }

    /// <summary>
    /// Number of page errors.
    /// </summary>
    /// <value>Number of page errors.</value>
    public long? PageErrors { get; set; }

    /// <summary>
    /// Number of line errors.
    /// </summary>
    /// <value>Number of line errors.</value>
    public long? LineErrors { get; set; }
}
