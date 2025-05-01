using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallEventTopicFaxStatus
/// </summary>
[DataContract]
public partial class QueueConversationCallEventTopicFaxStatus : IEquatable<QueueConversationCallEventTopicFaxStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallEventTopicFaxStatus" /> class.
    /// </summary>
    /// <param name="Direction">Direction.</param>
    /// <param name="ExpectedPages">ExpectedPages.</param>
    /// <param name="ActivePage">ActivePage.</param>
    /// <param name="LinesTransmitted">LinesTransmitted.</param>
    /// <param name="BytesTransmitted">BytesTransmitted.</param>
    /// <param name="DataRate">DataRate.</param>
    /// <param name="PageErrors">PageErrors.</param>
    /// <param name="LineErrors">LineErrors.</param>
    public QueueConversationCallEventTopicFaxStatus(string Direction = null, long? ExpectedPages = null, long? ActivePage = null, long? LinesTransmitted = null, long? BytesTransmitted = null, long? DataRate = null, long? PageErrors = null, long? LineErrors = null)
    {
        this.Direction = Direction;
        this.ExpectedPages = ExpectedPages;
        this.ActivePage = ActivePage;
        this.LinesTransmitted = LinesTransmitted;
        this.BytesTransmitted = BytesTransmitted;
        this.DataRate = DataRate;
        this.PageErrors = PageErrors;
        this.LineErrors = LineErrors;

    }



    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public string Direction { get; set; }



    /// <summary>
    /// Gets or Sets ExpectedPages
    /// </summary>
    [DataMember(Name = "expectedPages", EmitDefaultValue = false)]
    public long? ExpectedPages { get; set; }



    /// <summary>
    /// Gets or Sets ActivePage
    /// </summary>
    [DataMember(Name = "activePage", EmitDefaultValue = false)]
    public long? ActivePage { get; set; }



    /// <summary>
    /// Gets or Sets LinesTransmitted
    /// </summary>
    [DataMember(Name = "linesTransmitted", EmitDefaultValue = false)]
    public long? LinesTransmitted { get; set; }



    /// <summary>
    /// Gets or Sets BytesTransmitted
    /// </summary>
    [DataMember(Name = "bytesTransmitted", EmitDefaultValue = false)]
    public long? BytesTransmitted { get; set; }



    /// <summary>
    /// Gets or Sets DataRate
    /// </summary>
    [DataMember(Name = "dataRate", EmitDefaultValue = false)]
    public long? DataRate { get; set; }



    /// <summary>
    /// Gets or Sets PageErrors
    /// </summary>
    [DataMember(Name = "pageErrors", EmitDefaultValue = false)]
    public long? PageErrors { get; set; }



    /// <summary>
    /// Gets or Sets LineErrors
    /// </summary>
    [DataMember(Name = "lineErrors", EmitDefaultValue = false)]
    public long? LineErrors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallEventTopicFaxStatus {\n");

        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  ExpectedPages: ").Append(ExpectedPages).Append("\n");
        sb.Append("  ActivePage: ").Append(ActivePage).Append("\n");
        sb.Append("  LinesTransmitted: ").Append(LinesTransmitted).Append("\n");
        sb.Append("  BytesTransmitted: ").Append(BytesTransmitted).Append("\n");
        sb.Append("  DataRate: ").Append(DataRate).Append("\n");
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
        return Equals(obj as QueueConversationCallEventTopicFaxStatus);
    }

    /// <summary>
    /// Returns true if QueueConversationCallEventTopicFaxStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallEventTopicFaxStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallEventTopicFaxStatus other)
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
                DataRate == other.DataRate ||
                DataRate != null &&
                DataRate.Equals(other.DataRate)
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

            if (DataRate != null)
            {
                hash = hash * 59 + DataRate.GetHashCode();
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
