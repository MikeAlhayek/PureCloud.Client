using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OrphanUpdateRequest
/// </summary>
[DataContract]
public partial class OrphanUpdateRequest : IEquatable<OrphanUpdateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrphanUpdateRequest" /> class.
    /// </summary>
    /// <param name="ArchiveDate">The orphan recording&#39;s archive date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DeleteDate">The orphan recording&#39;s delete date. Must be greater than archiveDate and exportDate if set, otherwise one day from now. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportDate">The orphan recording&#39;s export date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="IntegrationId">IntegrationId to access AWS S3 bucket for export. This field is required if exportDate is set..</param>
    /// <param name="ConversationId">A conversation Id that this orphan&#39;s recording is to be attached to. If not present, the conversationId will be deduced from the recording media..</param>
    public OrphanUpdateRequest(DateTime? ArchiveDate = null, DateTime? DeleteDate = null, DateTime? ExportDate = null, string IntegrationId = null, string ConversationId = null)
    {
        this.ArchiveDate = ArchiveDate;
        this.DeleteDate = DeleteDate;
        this.ExportDate = ExportDate;
        this.IntegrationId = IntegrationId;
        this.ConversationId = ConversationId;

    }



    /// <summary>
    /// The orphan recording&#39;s archive date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The orphan recording&#39;s archive date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "archiveDate", EmitDefaultValue = false)]
    public DateTime? ArchiveDate { get; set; }



    /// <summary>
    /// The orphan recording&#39;s delete date. Must be greater than archiveDate and exportDate if set, otherwise one day from now. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The orphan recording&#39;s delete date. Must be greater than archiveDate and exportDate if set, otherwise one day from now. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "deleteDate", EmitDefaultValue = false)]
    public DateTime? DeleteDate { get; set; }



    /// <summary>
    /// The orphan recording&#39;s export date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The orphan recording&#39;s export date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "exportDate", EmitDefaultValue = false)]
    public DateTime? ExportDate { get; set; }



    /// <summary>
    /// IntegrationId to access AWS S3 bucket for export. This field is required if exportDate is set.
    /// </summary>
    /// <value>IntegrationId to access AWS S3 bucket for export. This field is required if exportDate is set.</value>
    [DataMember(Name = "integrationId", EmitDefaultValue = false)]
    public string IntegrationId { get; set; }



    /// <summary>
    /// A conversation Id that this orphan&#39;s recording is to be attached to. If not present, the conversationId will be deduced from the recording media.
    /// </summary>
    /// <value>A conversation Id that this orphan&#39;s recording is to be attached to. If not present, the conversationId will be deduced from the recording media.</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OrphanUpdateRequest {\n");

        sb.Append("  ArchiveDate: ").Append(ArchiveDate).Append("\n");
        sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
        sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
        return Equals(obj as OrphanUpdateRequest);
    }

    /// <summary>
    /// Returns true if OrphanUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of OrphanUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrphanUpdateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ArchiveDate == other.ArchiveDate ||
                ArchiveDate != null &&
                ArchiveDate.Equals(other.ArchiveDate)
            ) &&
            (
                DeleteDate == other.DeleteDate ||
                DeleteDate != null &&
                DeleteDate.Equals(other.DeleteDate)
            ) &&
            (
                ExportDate == other.ExportDate ||
                ExportDate != null &&
                ExportDate.Equals(other.ExportDate)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
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
            if (ArchiveDate != null)
            {
                hash = hash * 59 + ArchiveDate.GetHashCode();
            }

            if (DeleteDate != null)
            {
                hash = hash * 59 + DeleteDate.GetHashCode();
            }

            if (ExportDate != null)
            {
                hash = hash * 59 + ExportDate.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            return hash;
        }
    }
}
