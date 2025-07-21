namespace PureCloud.Client.Models;

public sealed class VoicemailMailboxInfoClean
{
    public long? UsageSizeBytes { get; set; }
    public int? TotalCount { get; set; }
    public int? UnreadCount { get; set; }
    public int? DeletedCount { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? NewestUnreadDate { get; set; }
    public DateTime? OldestUnreadDate { get; set; }
    public DateTime? NewestReadDate { get; set; }
    public DateTime? OldestReadDate { get; set; }
}