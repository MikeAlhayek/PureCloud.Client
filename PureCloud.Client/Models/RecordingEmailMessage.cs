using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingEmailMessage
/// </summary>
[DataContract]
public partial class RecordingEmailMessage : IEquatable<RecordingEmailMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingEmailMessage" /> class.
    /// </summary>
    /// <param name="HtmlBody">HtmlBody.</param>
    /// <param name="TextBody">TextBody.</param>
    /// <param name="Id">Id.</param>
    /// <param name="To">To.</param>
    /// <param name="Cc">Cc.</param>
    /// <param name="Bcc">Bcc.</param>
    /// <param name="From">From.</param>
    /// <param name="Subject">Subject.</param>
    /// <param name="Attachments">Attachments.</param>
    /// <param name="Time">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public RecordingEmailMessage(string HtmlBody = null, string TextBody = null, string Id = null, List<EmailAddress> To = null, List<EmailAddress> Cc = null, List<EmailAddress> Bcc = null, EmailAddress From = null, string Subject = null, List<EmailAttachment> Attachments = null, DateTime? Time = null)
    {
        this.HtmlBody = HtmlBody;
        this.TextBody = TextBody;
        this.Id = Id;
        this.To = To;
        this.Cc = Cc;
        this.Bcc = Bcc;
        this.From = From;
        this.Subject = Subject;
        this.Attachments = Attachments;
        this.Time = Time;

    }



    /// <summary>
    /// Gets or Sets HtmlBody
    /// </summary>
    [DataMember(Name = "htmlBody", EmitDefaultValue = false)]
    public string HtmlBody { get; set; }



    /// <summary>
    /// Gets or Sets TextBody
    /// </summary>
    [DataMember(Name = "textBody", EmitDefaultValue = false)]
    public string TextBody { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name = "to", EmitDefaultValue = false)]
    public List<EmailAddress> To { get; set; }



    /// <summary>
    /// Gets or Sets Cc
    /// </summary>
    [DataMember(Name = "cc", EmitDefaultValue = false)]
    public List<EmailAddress> Cc { get; set; }



    /// <summary>
    /// Gets or Sets Bcc
    /// </summary>
    [DataMember(Name = "bcc", EmitDefaultValue = false)]
    public List<EmailAddress> Bcc { get; set; }



    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name = "from", EmitDefaultValue = false)]
    public EmailAddress From { get; set; }



    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }



    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    [DataMember(Name = "attachments", EmitDefaultValue = false)]
    public List<EmailAttachment> Attachments { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "time", EmitDefaultValue = false)]
    public DateTime? Time { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingEmailMessage {\n");

        sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  Cc: ").Append(Cc).Append("\n");
        sb.Append("  Bcc: ").Append(Bcc).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  Attachments: ").Append(Attachments).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
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
        return Equals(obj as RecordingEmailMessage);
    }

    /// <summary>
    /// Returns true if RecordingEmailMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingEmailMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingEmailMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                HtmlBody == other.HtmlBody ||
                HtmlBody != null &&
                HtmlBody.Equals(other.HtmlBody)
            ) &&
            (
                TextBody == other.TextBody ||
                TextBody != null &&
                TextBody.Equals(other.TextBody)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                To == other.To ||
                To != null &&
                To.SequenceEqual(other.To)
            ) &&
            (
                Cc == other.Cc ||
                Cc != null &&
                Cc.SequenceEqual(other.Cc)
            ) &&
            (
                Bcc == other.Bcc ||
                Bcc != null &&
                Bcc.SequenceEqual(other.Bcc)
            ) &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                Attachments == other.Attachments ||
                Attachments != null &&
                Attachments.SequenceEqual(other.Attachments)
            ) &&
            (
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
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
            if (HtmlBody != null)
            {
                hash = hash * 59 + HtmlBody.GetHashCode();
            }

            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (Cc != null)
            {
                hash = hash * 59 + Cc.GetHashCode();
            }

            if (Bcc != null)
            {
                hash = hash * 59 + Bcc.GetHashCode();
            }

            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (Attachments != null)
            {
                hash = hash * 59 + Attachments.GetHashCode();
            }

            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            return hash;
        }
    }
}
