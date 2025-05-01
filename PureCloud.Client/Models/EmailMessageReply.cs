using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// EmailMessageReply
/// </summary>
[DataContract]
public partial class EmailMessageReply : IEquatable<EmailMessageReply>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailMessageReply" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmailMessageReply() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailMessageReply" /> class.
    /// </summary>
    /// <param name="To">The recipients of the email message. (required).</param>
    /// <param name="Cc">The recipients that were copied on the email message..</param>
    /// <param name="Bcc">The recipients that were blind copied on the email message..</param>
    /// <param name="From">The sender of the email message. (required).</param>
    /// <param name="ReplyTo">The receiver of the reply email message..</param>
    /// <param name="Subject">The subject of the email message..</param>
    /// <param name="Attachments">The attachments of the email message..</param>
    /// <param name="TextBody">The text body of the email message. (required).</param>
    /// <param name="HtmlBody">The html body of the email message..</param>
    /// <param name="Time">The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="HistoryIncluded">Indicates whether the history of previous emails of the conversation is included within the email bodies of this message..</param>
    public EmailMessageReply(List<EmailAddress> To = null, List<EmailAddress> Cc = null, List<EmailAddress> Bcc = null, EmailAddress From = null, EmailAddress ReplyTo = null, string Subject = null, List<Attachment> Attachments = null, string TextBody = null, string HtmlBody = null, DateTime? Time = null, bool? HistoryIncluded = null)
    {
        this.To = To;
        this.Cc = Cc;
        this.Bcc = Bcc;
        this.From = From;
        this.ReplyTo = ReplyTo;
        this.Subject = Subject;
        this.Attachments = Attachments;
        this.TextBody = TextBody;
        this.HtmlBody = HtmlBody;
        this.Time = Time;
        this.HistoryIncluded = HistoryIncluded;

    }



    /// <summary>
    /// The recipients of the email message.
    /// </summary>
    /// <value>The recipients of the email message.</value>
    [DataMember(Name = "to", EmitDefaultValue = false)]
    public List<EmailAddress> To { get; set; }



    /// <summary>
    /// The recipients that were copied on the email message.
    /// </summary>
    /// <value>The recipients that were copied on the email message.</value>
    [DataMember(Name = "cc", EmitDefaultValue = false)]
    public List<EmailAddress> Cc { get; set; }



    /// <summary>
    /// The recipients that were blind copied on the email message.
    /// </summary>
    /// <value>The recipients that were blind copied on the email message.</value>
    [DataMember(Name = "bcc", EmitDefaultValue = false)]
    public List<EmailAddress> Bcc { get; set; }



    /// <summary>
    /// The sender of the email message.
    /// </summary>
    /// <value>The sender of the email message.</value>
    [DataMember(Name = "from", EmitDefaultValue = false)]
    public EmailAddress From { get; set; }



    /// <summary>
    /// The receiver of the reply email message.
    /// </summary>
    /// <value>The receiver of the reply email message.</value>
    [DataMember(Name = "replyTo", EmitDefaultValue = false)]
    public EmailAddress ReplyTo { get; set; }



    /// <summary>
    /// The subject of the email message.
    /// </summary>
    /// <value>The subject of the email message.</value>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }



    /// <summary>
    /// The attachments of the email message.
    /// </summary>
    /// <value>The attachments of the email message.</value>
    [DataMember(Name = "attachments", EmitDefaultValue = false)]
    public List<Attachment> Attachments { get; set; }



    /// <summary>
    /// The text body of the email message.
    /// </summary>
    /// <value>The text body of the email message.</value>
    [DataMember(Name = "textBody", EmitDefaultValue = false)]
    public string TextBody { get; set; }



    /// <summary>
    /// The html body of the email message.
    /// </summary>
    /// <value>The html body of the email message.</value>
    [DataMember(Name = "htmlBody", EmitDefaultValue = false)]
    public string HtmlBody { get; set; }



    /// <summary>
    /// The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "time", EmitDefaultValue = false)]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Indicates whether the history of previous emails of the conversation is included within the email bodies of this message.
    /// </summary>
    /// <value>Indicates whether the history of previous emails of the conversation is included within the email bodies of this message.</value>
    [DataMember(Name = "historyIncluded", EmitDefaultValue = false)]
    public bool? HistoryIncluded { get; set; }



    /// <summary>
    /// Indicates an estimation of the size of the current email as a whole, in its final, ready to be sent form.
    /// </summary>
    /// <value>Indicates an estimation of the size of the current email as a whole, in its final, ready to be sent form.</value>
    [DataMember(Name = "emailSizeBytes", EmitDefaultValue = false)]
    public int? EmailSizeBytes { get; private set; }



    /// <summary>
    /// Indicates the maximum allowed size for an email to be send via SMTP server, based on the email domain configuration
    /// </summary>
    /// <value>Indicates the maximum allowed size for an email to be send via SMTP server, based on the email domain configuration</value>
    [DataMember(Name = "maxEmailSizeBytes", EmitDefaultValue = false)]
    public int? MaxEmailSizeBytes { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailMessageReply {\n");

        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  Cc: ").Append(Cc).Append("\n");
        sb.Append("  Bcc: ").Append(Bcc).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  Attachments: ").Append(Attachments).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  HistoryIncluded: ").Append(HistoryIncluded).Append("\n");
        sb.Append("  EmailSizeBytes: ").Append(EmailSizeBytes).Append("\n");
        sb.Append("  MaxEmailSizeBytes: ").Append(MaxEmailSizeBytes).Append("\n");
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
        return this.Equals(obj as EmailMessageReply);
    }

    /// <summary>
    /// Returns true if EmailMessageReply instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailMessageReply to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailMessageReply other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.To == other.To ||
                this.To != null &&
                this.To.SequenceEqual(other.To)
            ) &&
            (
                this.Cc == other.Cc ||
                this.Cc != null &&
                this.Cc.SequenceEqual(other.Cc)
            ) &&
            (
                this.Bcc == other.Bcc ||
                this.Bcc != null &&
                this.Bcc.SequenceEqual(other.Bcc)
            ) &&
            (
                this.From == other.From ||
                this.From != null &&
                this.From.Equals(other.From)
            ) &&
            (
                this.ReplyTo == other.ReplyTo ||
                this.ReplyTo != null &&
                this.ReplyTo.Equals(other.ReplyTo)
            ) &&
            (
                this.Subject == other.Subject ||
                this.Subject != null &&
                this.Subject.Equals(other.Subject)
            ) &&
            (
                this.Attachments == other.Attachments ||
                this.Attachments != null &&
                this.Attachments.SequenceEqual(other.Attachments)
            ) &&
            (
                this.TextBody == other.TextBody ||
                this.TextBody != null &&
                this.TextBody.Equals(other.TextBody)
            ) &&
            (
                this.HtmlBody == other.HtmlBody ||
                this.HtmlBody != null &&
                this.HtmlBody.Equals(other.HtmlBody)
            ) &&
            (
                this.Time == other.Time ||
                this.Time != null &&
                this.Time.Equals(other.Time)
            ) &&
            (
                this.HistoryIncluded == other.HistoryIncluded ||
                this.HistoryIncluded != null &&
                this.HistoryIncluded.Equals(other.HistoryIncluded)
            ) &&
            (
                this.EmailSizeBytes == other.EmailSizeBytes ||
                this.EmailSizeBytes != null &&
                this.EmailSizeBytes.Equals(other.EmailSizeBytes)
            ) &&
            (
                this.MaxEmailSizeBytes == other.MaxEmailSizeBytes ||
                this.MaxEmailSizeBytes != null &&
                this.MaxEmailSizeBytes.Equals(other.MaxEmailSizeBytes)
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
            if (this.To != null)
            {
                hash = hash * 59 + this.To.GetHashCode();
            }

            if (this.Cc != null)
            {
                hash = hash * 59 + this.Cc.GetHashCode();
            }

            if (this.Bcc != null)
            {
                hash = hash * 59 + this.Bcc.GetHashCode();
            }

            if (this.From != null)
            {
                hash = hash * 59 + this.From.GetHashCode();
            }

            if (this.ReplyTo != null)
            {
                hash = hash * 59 + this.ReplyTo.GetHashCode();
            }

            if (this.Subject != null)
            {
                hash = hash * 59 + this.Subject.GetHashCode();
            }

            if (this.Attachments != null)
            {
                hash = hash * 59 + this.Attachments.GetHashCode();
            }

            if (this.TextBody != null)
            {
                hash = hash * 59 + this.TextBody.GetHashCode();
            }

            if (this.HtmlBody != null)
            {
                hash = hash * 59 + this.HtmlBody.GetHashCode();
            }

            if (this.Time != null)
            {
                hash = hash * 59 + this.Time.GetHashCode();
            }

            if (this.HistoryIncluded != null)
            {
                hash = hash * 59 + this.HistoryIncluded.GetHashCode();
            }

            if (this.EmailSizeBytes != null)
            {
                hash = hash * 59 + this.EmailSizeBytes.GetHashCode();
            }

            if (this.MaxEmailSizeBytes != null)
            {
                hash = hash * 59 + this.MaxEmailSizeBytes.GetHashCode();
            }

            return hash;
        }
    }
}
