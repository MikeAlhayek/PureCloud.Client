using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TestMessage
/// </summary>
[DataContract]
public partial class TestMessage : IEquatable<TestMessage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TestMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TestMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TestMessage" /> class.
    /// </summary>
    /// <param name="To">The recipients of the email message. (required).</param>
    /// <param name="From">The sender of the email message. (required).</param>
    /// <param name="Subject">The subject of the email message..</param>
    /// <param name="TextBody">The text body of the email message. (required).</param>
    /// <param name="HtmlBody">The html body of the email message.</param>
    /// <param name="Time">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public TestMessage(List<EmailAddress> To = null, EmailAddress From = null, string Subject = null, string TextBody = null, string HtmlBody = null, DateTime? Time = null)
    {
        this.To = To;
        this.From = From;
        this.Subject = Subject;
        this.TextBody = TextBody;
        this.HtmlBody = HtmlBody;
        this.Time = Time;

    }



    /// <summary>
    /// After the message has been sent, this is the value of the Message-ID email header.
    /// </summary>
    /// <value>After the message has been sent, this is the value of the Message-ID email header.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The recipients of the email message.
    /// </summary>
    /// <value>The recipients of the email message.</value>
    [DataMember(Name = "to", EmitDefaultValue = false)]
    public List<EmailAddress> To { get; set; }



    /// <summary>
    /// The sender of the email message.
    /// </summary>
    /// <value>The sender of the email message.</value>
    [DataMember(Name = "from", EmitDefaultValue = false)]
    public EmailAddress From { get; set; }



    /// <summary>
    /// The subject of the email message.
    /// </summary>
    /// <value>The subject of the email message.</value>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }



    /// <summary>
    /// The text body of the email message.
    /// </summary>
    /// <value>The text body of the email message.</value>
    [DataMember(Name = "textBody", EmitDefaultValue = false)]
    public string TextBody { get; set; }



    /// <summary>
    /// The html body of the email message
    /// </summary>
    /// <value>The html body of the email message</value>
    [DataMember(Name = "htmlBody", EmitDefaultValue = false)]
    public string HtmlBody { get; set; }



    /// <summary>
    /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "time", EmitDefaultValue = false)]
    public DateTime? Time { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TestMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
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
        return Equals(obj as TestMessage);
    }

    /// <summary>
    /// Returns true if TestMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of TestMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TestMessage other)
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
                To == other.To ||
                To != null &&
                To.SequenceEqual(other.To)
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

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
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

            return hash;
        }
    }
}
