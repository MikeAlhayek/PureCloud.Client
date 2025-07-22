namespace PureCloud.Client.Models;

public sealed class VoicemailUserPolicy
{
    public bool? Enabled { get; set; }

    public int? AlertTimeoutSeconds { get; set; }

    public string Pin { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? SendEmailNotifications { get; set; }
}
