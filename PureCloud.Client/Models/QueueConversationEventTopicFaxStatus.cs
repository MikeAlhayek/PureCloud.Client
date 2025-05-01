using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Extra information on fax transmission.
/// </summary>
[DataContract]
public partial class QueueConversationEventTopicFaxStatus : IEquatable<QueueConversationEventTopicFaxStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicFaxStatus" /> class.
    /// </summary>
    /// <param name="Direction">The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;..</param>
    /// <param name="ExpectedPages">Total number of expected pages, if known..</param>
    /// <param name="ActivePage">Active page of the transmission..</param>
    /// <param name="LinesTransmitted">Number of lines that have completed transmission..</param>
    /// <param name="BytesTransmitted">Number of bytes that have competed transmission..</param>
    /// <param name="BaudRate">Current signaling rate of transmission, baud rate..</param>
    /// <param name="PageErrors">Number of page errors..</param>
    /// <param name="LineErrors">Number of line errors..</param>
    public QueueConversationEventTopicFaxStatus(string Direction = null, long? ExpectedPages = null, long? ActivePage = null, long? LinesTransmitted = null, long? BytesTransmitted = null, long? BaudRate = null, long? PageErrors = null, long? LineErrors = null)
    {
        this.Direction = Direction;
        this.ExpectedPages = ExpectedPages;
        this.ActivePage = ActivePage;
        this.LinesTransmitted = LinesTransmitted;
        this.BytesTransmitted = BytesTransmitted;
        this.BaudRate = BaudRate;
        this.PageErrors = PageErrors;
        this.LineErrors = LineErrors;

    }



    /// <summary>
    /// The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;.
    /// </summary>
    /// <value>The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;.</value>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public string Direction { get; set; }



    /// <summary>
    /// Total number of expected pages, if known.
    /// </summary>
    /// <value>Total number of expected pages, if known.</value>
    [DataMember(Name = "expectedPages", EmitDefaultValue = false)]
    public long? ExpectedPages { get; set; }



    /// <summary>
    /// Active page of the transmission.
    /// </summary>
    /// <value>Active page of the transmission.</value>
    [DataMember(Name = "activePage", EmitDefaultValue = false)]
    public long? ActivePage { get; set; }



    /// <summary>
    /// Number of lines that have completed transmission.
    /// </summary>
    /// <value>Number of lines that have completed transmission.</value>
    [DataMember(Name = "linesTransmitted", EmitDefaultValue = false)]
    public long? LinesTransmitted { get; set; }



    /// <summary>
    /// Number of bytes that have competed transmission.
    /// </summary>
    /// <value>Number of bytes that have competed transmission.</value>
    [DataMember(Name = "bytesTransmitted", EmitDefaultValue = false)]
    public long? BytesTransmitted { get; set; }



    /// <summary>
    /// Current signaling rate of transmission, baud rate.
    /// </summary>
    /// <value>Current signaling rate of transmission, baud rate.</value>
    [DataMember(Name = "baudRate", EmitDefaultValue = false)]
    public long? BaudRate { get; set; }



    /// <summary>
    /// Number of page errors.
    /// </summary>
    /// <value>Number of page errors.</value>
    [DataMember(Name = "pageErrors", EmitDefaultValue = false)]
    public long? PageErrors { get; set; }



    /// <summary>
    /// Number of line errors.
    /// </summary>
    /// <value>Number of line errors.</value>
    [DataMember(Name = "lineErrors", EmitDefaultValue = false)]
    public long? LineErrors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicFaxStatus {\n");

        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  ExpectedPages: ").Append(ExpectedPages).Append("\n");
        sb.Append("  ActivePage: ").Append(ActivePage).Append("\n");
        sb.Append("  LinesTransmitted: ").Append(LinesTransmitted).Append("\n");
        sb.Append("  BytesTransmitted: ").Append(BytesTransmitted).Append("\n");
        sb.Append("  BaudRate: ").Append(BaudRate).Append("\n");
        sb.Append("  PageErrors: ").Append(PageErrors).Append("\n");
        sb.Append("  LineErrors: ").Append(LineErrors).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as QueueConversationEventTopicFaxStatus);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicFaxStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicFaxStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicFaxStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                ExpectedPages == other.ExpectedPages ||
                ExpectedPages != null &&
                ExpectedPages.Equals(other.ExpectedPages)
            ) &&
            (
                ActivePage == other.ActivePage ||
                ActivePage != null &&
                ActivePage.Equals(other.ActivePage)
            ) &&
            (
                LinesTransmitted == other.LinesTransmitted ||
                LinesTransmitted != null &&
                LinesTransmitted.Equals(other.LinesTransmitted)
            ) &&
            (
                BytesTransmitted == other.BytesTransmitted ||
                BytesTransmitted != null &&
                BytesTransmitted.Equals(other.BytesTransmitted)
            ) &&
            (
                BaudRate == other.BaudRate ||
                BaudRate != null &&
                BaudRate.Equals(other.BaudRate)
            ) &&
            (
                PageErrors == other.PageErrors ||
                PageErrors != null &&
                PageErrors.Equals(other.PageErrors)
            ) &&
            (
                LineErrors == other.LineErrors ||
                LineErrors != null &&
                LineErrors.Equals(other.LineErrors)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (ExpectedPages != null)
            {
                hash = hash * 59 + ExpectedPages.GetHashCode();
            }

            if (ActivePage != null)
            {
                hash = hash * 59 + ActivePage.GetHashCode();
            }

            if (LinesTransmitted != null)
            {
                hash = hash * 59 + LinesTransmitted.GetHashCode();
            }

            if (BytesTransmitted != null)
            {
                hash = hash * 59 + BytesTransmitted.GetHashCode();
            }

            if (BaudRate != null)
            {
                hash = hash * 59 + BaudRate.GetHashCode();
            }

            if (PageErrors != null)
            {
                hash = hash * 59 + PageErrors.GetHashCode();
            }

            if (LineErrors != null)
            {
                hash = hash * 59 + LineErrors.GetHashCode();
            }

            return hash;
        }
    }
}
