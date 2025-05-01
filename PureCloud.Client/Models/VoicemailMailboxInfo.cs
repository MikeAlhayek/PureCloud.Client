using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailMailboxInfo
/// </summary>
[DataContract]
public partial class VoicemailMailboxInfo : IEquatable<VoicemailMailboxInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailMailboxInfo" /> class.
    /// </summary>
    public VoicemailMailboxInfo()
    {

    }



    /// <summary>
    /// The total number of bytes for all voicemail message audio recordings
    /// </summary>
    /// <value>The total number of bytes for all voicemail message audio recordings</value>
    [DataMember(Name = "usageSizeBytes", EmitDefaultValue = false)]
    public long? UsageSizeBytes { get; private set; }



    /// <summary>
    /// The total number of voicemail messages
    /// </summary>
    /// <value>The total number of voicemail messages</value>
    [DataMember(Name = "totalCount", EmitDefaultValue = false)]
    public int? TotalCount { get; private set; }



    /// <summary>
    /// The total number of voicemail messages marked as unread
    /// </summary>
    /// <value>The total number of voicemail messages marked as unread</value>
    [DataMember(Name = "unreadCount", EmitDefaultValue = false)]
    public int? UnreadCount { get; private set; }



    /// <summary>
    /// The total number of voicemail messages marked as deleted
    /// </summary>
    /// <value>The total number of voicemail messages marked as deleted</value>
    [DataMember(Name = "deletedCount", EmitDefaultValue = false)]
    public int? DeletedCount { get; private set; }



    /// <summary>
    /// The date of the oldest voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the oldest voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; private set; }



    /// <summary>
    /// The date of the most recent voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the most recent voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; private set; }



    /// <summary>
    /// The date of the most recent unread voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the most recent unread voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "newestUnreadDate", EmitDefaultValue = false)]
    public DateTime? NewestUnreadDate { get; private set; }



    /// <summary>
    /// The date of the most oldest unread voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the most oldest unread voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "oldestUnreadDate", EmitDefaultValue = false)]
    public DateTime? OldestUnreadDate { get; private set; }



    /// <summary>
    /// The date of the most recent read voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the most recent read voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "newestReadDate", EmitDefaultValue = false)]
    public DateTime? NewestReadDate { get; private set; }



    /// <summary>
    /// The date of the most oldest read voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the most oldest read voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "oldestReadDate", EmitDefaultValue = false)]
    public DateTime? OldestReadDate { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailMailboxInfo {\n");

        sb.Append("  UsageSizeBytes: ").Append(UsageSizeBytes).Append("\n");
        sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
        sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
        sb.Append("  DeletedCount: ").Append(DeletedCount).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  NewestUnreadDate: ").Append(NewestUnreadDate).Append("\n");
        sb.Append("  OldestUnreadDate: ").Append(OldestUnreadDate).Append("\n");
        sb.Append("  NewestReadDate: ").Append(NewestReadDate).Append("\n");
        sb.Append("  OldestReadDate: ").Append(OldestReadDate).Append("\n");
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
        return this.Equals(obj as VoicemailMailboxInfo);
    }

    /// <summary>
    /// Returns true if VoicemailMailboxInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailMailboxInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailMailboxInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.UsageSizeBytes == other.UsageSizeBytes ||
                this.UsageSizeBytes != null &&
                this.UsageSizeBytes.Equals(other.UsageSizeBytes)
            ) &&
            (
                this.TotalCount == other.TotalCount ||
                this.TotalCount != null &&
                this.TotalCount.Equals(other.TotalCount)
            ) &&
            (
                this.UnreadCount == other.UnreadCount ||
                this.UnreadCount != null &&
                this.UnreadCount.Equals(other.UnreadCount)
            ) &&
            (
                this.DeletedCount == other.DeletedCount ||
                this.DeletedCount != null &&
                this.DeletedCount.Equals(other.DeletedCount)
            ) &&
            (
                this.CreatedDate == other.CreatedDate ||
                this.CreatedDate != null &&
                this.CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                this.ModifiedDate == other.ModifiedDate ||
                this.ModifiedDate != null &&
                this.ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                this.NewestUnreadDate == other.NewestUnreadDate ||
                this.NewestUnreadDate != null &&
                this.NewestUnreadDate.Equals(other.NewestUnreadDate)
            ) &&
            (
                this.OldestUnreadDate == other.OldestUnreadDate ||
                this.OldestUnreadDate != null &&
                this.OldestUnreadDate.Equals(other.OldestUnreadDate)
            ) &&
            (
                this.NewestReadDate == other.NewestReadDate ||
                this.NewestReadDate != null &&
                this.NewestReadDate.Equals(other.NewestReadDate)
            ) &&
            (
                this.OldestReadDate == other.OldestReadDate ||
                this.OldestReadDate != null &&
                this.OldestReadDate.Equals(other.OldestReadDate)
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
            if (this.UsageSizeBytes != null)
            {
                hash = hash * 59 + this.UsageSizeBytes.GetHashCode();
            }

            if (this.TotalCount != null)
            {
                hash = hash * 59 + this.TotalCount.GetHashCode();
            }

            if (this.UnreadCount != null)
            {
                hash = hash * 59 + this.UnreadCount.GetHashCode();
            }

            if (this.DeletedCount != null)
            {
                hash = hash * 59 + this.DeletedCount.GetHashCode();
            }

            if (this.CreatedDate != null)
            {
                hash = hash * 59 + this.CreatedDate.GetHashCode();
            }

            if (this.ModifiedDate != null)
            {
                hash = hash * 59 + this.ModifiedDate.GetHashCode();
            }

            if (this.NewestUnreadDate != null)
            {
                hash = hash * 59 + this.NewestUnreadDate.GetHashCode();
            }

            if (this.OldestUnreadDate != null)
            {
                hash = hash * 59 + this.OldestUnreadDate.GetHashCode();
            }

            if (this.NewestReadDate != null)
            {
                hash = hash * 59 + this.NewestReadDate.GetHashCode();
            }

            if (this.OldestReadDate != null)
            {
                hash = hash * 59 + this.OldestReadDate.GetHashCode();
            }

            return hash;
        }
    }
}
