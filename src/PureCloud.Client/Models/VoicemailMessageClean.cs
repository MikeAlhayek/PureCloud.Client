namespace PureCloud.Client.Models;

public sealed class VoicemailMessageClean
{
    public string Id { get; set; }
    public bool? Read { get; set; }
    public int? AudioRecordingDurationSeconds { get; set; }
    public long? AudioRecordingSizeBytes { get; set; }
    public string Transcription { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public string CallerAddress { get; set; }
    public string CallerName { get; set; }
    public bool? Deleted { get; set; }
    public string Note { get; set; }
    public string SelfUri { get; set; }
}