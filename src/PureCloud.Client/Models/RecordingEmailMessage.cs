using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class RecordingEmailMessage
{
    /// <summary>
    /// Gets or Sets HtmlBody
    /// </summary>
    public string HtmlBody { get; set; }

    /// <summary>
    /// Gets or Sets TextBody
    /// </summary>
    public string TextBody { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    public IEnumerable<EmailAddress> To { get; set; }

    /// <summary>
    /// Gets or Sets Cc
    /// </summary>
    public IEnumerable<EmailAddress> Cc { get; set; }

    /// <summary>
    /// Gets or Sets Bcc
    /// </summary>
    public IEnumerable<EmailAddress> Bcc { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    public EmailAddress From { get; set; }
    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    public IEnumerable<EmailAttachment> Attachments { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>

    public DateTime? Time { get; set; }
}
