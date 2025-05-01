using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailMessage
/// </summary>
[DataContract]
public partial class EmailMessage : IEquatable<EmailMessage>
{
    /// <summary>
    /// The state of the current draft.
    /// </summary>
    /// <value>The state of the current draft.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The type of draft that need to be treated.
    /// </summary>
    /// <value>The type of draft that need to be treated.</value>
    [DataMember(Name = "draftType", EmitDefaultValue = false)]
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



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
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
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
        return this.Equals(obj as EmailMessage);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
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
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.DraftType == other.DraftType ||
                this.DraftType != null &&
                this.DraftType.Equals(other.DraftType)
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
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

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

            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.DraftType != null)
            {
                hash = hash * 59 + this.DraftType.GetHashCode();
            }

            if (this.EmailSizeBytes != null)
            {
                hash = hash * 59 + this.EmailSizeBytes.GetHashCode();
            }

            if (this.MaxEmailSizeBytes != null)
            {
                hash = hash * 59 + this.MaxEmailSizeBytes.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
