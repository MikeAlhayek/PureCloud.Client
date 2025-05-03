using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailMessage
/// </summary>

public partial class EmailMessage : IEquatable<EmailMessage>
{
    /// <summary>
    /// The state of the current draft.
    /// </summary>
    /// <value>The state of the current draft.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Ready for "Ready"
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready,

        /// <summary>
        /// Enum Edited for "Edited"
        /// </summary>
        [EnumMember(Value = "Edited")]
        Edited
    }
    /// <summary>
    /// The type of draft that need to be treated.
    /// </summary>
    /// <value>The type of draft that need to be treated.</value>
    
    public enum DraftTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Reply for "Reply"
        /// </summary>
        [EnumMember(Value = "Reply")]
        Reply,

        /// <summary>
        /// Enum Replyall for "ReplyAll"
        /// </summary>
        [EnumMember(Value = "ReplyAll")]
        Replyall,

        /// <summary>
        /// Enum Forward for "Forward"
        /// </summary>
        [EnumMember(Value = "Forward")]
        Forward
    }
    /// <summary>
    /// The state of the current draft.
    /// </summary>
    /// <value>The state of the current draft.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The type of draft that need to be treated.
    /// </summary>
    /// <value>The type of draft that need to be treated.</value>
    [JsonPropertyName("draftType")]
    public DraftTypeEnum? DraftType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmailMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailMessage" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
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
    /// <param name="State">The state of the current draft..</param>
    /// <param name="DraftType">The type of draft that need to be treated..</param>
    public EmailMessage(string Name = null, List<EmailAddress> To = null, List<EmailAddress> Cc = null, List<EmailAddress> Bcc = null, EmailAddress From = null, EmailAddress ReplyTo = null, string Subject = null, List<Attachment> Attachments = null, string TextBody = null, string HtmlBody = null, DateTime? Time = null, bool? HistoryIncluded = null, StateEnum? State = null, DraftTypeEnum? DraftType = null)
    {
        this.Name = Name;
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
        this.State = State;
        this.DraftType = DraftType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The recipients of the email message.
    /// </summary>
    /// <value>The recipients of the email message.</value>
    [JsonPropertyName("to")]
    public List<EmailAddress> To { get; set; }



    /// <summary>
    /// The recipients that were copied on the email message.
    /// </summary>
    /// <value>The recipients that were copied on the email message.</value>
    [JsonPropertyName("cc")]
    public List<EmailAddress> Cc { get; set; }



    /// <summary>
    /// The recipients that were blind copied on the email message.
    /// </summary>
    /// <value>The recipients that were blind copied on the email message.</value>
    [JsonPropertyName("bcc")]
    public List<EmailAddress> Bcc { get; set; }



    /// <summary>
    /// The sender of the email message.
    /// </summary>
    /// <value>The sender of the email message.</value>
    [JsonPropertyName("from")]
    public EmailAddress From { get; set; }



    /// <summary>
    /// The receiver of the reply email message.
    /// </summary>
    /// <value>The receiver of the reply email message.</value>
    [JsonPropertyName("replyTo")]
    public EmailAddress ReplyTo { get; set; }



    /// <summary>
    /// The subject of the email message.
    /// </summary>
    /// <value>The subject of the email message.</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }



    /// <summary>
    /// The attachments of the email message.
    /// </summary>
    /// <value>The attachments of the email message.</value>
    [JsonPropertyName("attachments")]
    public List<Attachment> Attachments { get; set; }



    /// <summary>
    /// The text body of the email message.
    /// </summary>
    /// <value>The text body of the email message.</value>
    [JsonPropertyName("textBody")]
    public string TextBody { get; set; }



    /// <summary>
    /// The html body of the email message.
    /// </summary>
    /// <value>The html body of the email message.</value>
    [JsonPropertyName("htmlBody")]
    public string HtmlBody { get; set; }



    /// <summary>
    /// The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Indicates whether the history of previous emails of the conversation is included within the email bodies of this message.
    /// </summary>
    /// <value>Indicates whether the history of previous emails of the conversation is included within the email bodies of this message.</value>
    [JsonPropertyName("historyIncluded")]
    public bool? HistoryIncluded { get; set; }







    /// <summary>
    /// Indicates an estimation of the size of the current email as a whole, in its final, ready to be sent form.
    /// </summary>
    /// <value>Indicates an estimation of the size of the current email as a whole, in its final, ready to be sent form.</value>
    [JsonPropertyName("emailSizeBytes")]
    public int? EmailSizeBytes { get; private set; }



    /// <summary>
    /// Indicates the maximum allowed size for an email to be send via SMTP server, based on the email domain configuration
    /// </summary>
    /// <value>Indicates the maximum allowed size for an email to be send via SMTP server, based on the email domain configuration</value>
    [JsonPropertyName("maxEmailSizeBytes")]
    public int? MaxEmailSizeBytes { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DraftType: ").Append(DraftType).Append("\n");
        sb.Append("  EmailSizeBytes: ").Append(EmailSizeBytes).Append("\n");
        sb.Append("  MaxEmailSizeBytes: ").Append(MaxEmailSizeBytes).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as EmailMessage);
    }

    /// <summary>
    /// Returns true if EmailMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
                ReplyTo == other.ReplyTo ||
                ReplyTo != null &&
                ReplyTo.Equals(other.ReplyTo)
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
                TextBody == other.TextBody ||
                TextBody != null &&
                TextBody.Equals(other.TextBody)
            ) &&
            (
                HtmlBody == other.HtmlBody ||
                HtmlBody != null &&
                HtmlBody.Equals(other.HtmlBody)
            ) &&
            (
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
            ) &&
            (
                HistoryIncluded == other.HistoryIncluded ||
                HistoryIncluded != null &&
                HistoryIncluded.Equals(other.HistoryIncluded)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DraftType == other.DraftType ||
                DraftType != null &&
                DraftType.Equals(other.DraftType)
            ) &&
            (
                EmailSizeBytes == other.EmailSizeBytes ||
                EmailSizeBytes != null &&
                EmailSizeBytes.Equals(other.EmailSizeBytes)
            ) &&
            (
                MaxEmailSizeBytes == other.MaxEmailSizeBytes ||
                MaxEmailSizeBytes != null &&
                MaxEmailSizeBytes.Equals(other.MaxEmailSizeBytes)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
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

            if (ReplyTo != null)
            {
                hash = hash * 59 + ReplyTo.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (Attachments != null)
            {
                hash = hash * 59 + Attachments.GetHashCode();
            }

            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (HtmlBody != null)
            {
                hash = hash * 59 + HtmlBody.GetHashCode();
            }

            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            if (HistoryIncluded != null)
            {
                hash = hash * 59 + HistoryIncluded.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DraftType != null)
            {
                hash = hash * 59 + DraftType.GetHashCode();
            }

            if (EmailSizeBytes != null)
            {
                hash = hash * 59 + EmailSizeBytes.GetHashCode();
            }

            if (MaxEmailSizeBytes != null)
            {
                hash = hash * 59 + MaxEmailSizeBytes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
