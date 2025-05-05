using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailInitialConfiguration
/// </summary>

public partial class EmailInitialConfiguration : IEquatable<EmailInitialConfiguration>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailInitialConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmailInitialConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailInitialConfiguration" /> class.
    /// </summary>
    /// <param name="To">An email address that this email is to. (required).</param>
    /// <param name="From">An email address that this email is from. (required).</param>
    /// <param name="Cc">An email addresses that this email is carbon copied to..</param>
    /// <param name="Bcc">An email addresses that this email is blind carbon copied to..</param>
    /// <param name="Subject">The subject for this email..</param>
    /// <param name="PreviousEmailId">UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant..</param>
    /// <param name="Held">Indicates that this communication&#39;s initial state is held..</param>
    /// <param name="Alerting">Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state..</param>
    /// <param name="Inbound">Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND..</param>
    /// <param name="InvitedBy">The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred..</param>
    /// <param name="AdditionalInfo">Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields..</param>
    public EmailInitialConfiguration(string To = null, string From = null, List<string> Cc = null, List<string> Bcc = null, string Subject = null, string PreviousEmailId = null, bool? Held = null, bool? Alerting = null, bool? Inbound = null, string InvitedBy = null, Dictionary<string, string> AdditionalInfo = null)
    {
        this.To = To;
        this.From = From;
        this.Cc = Cc;
        this.Bcc = Bcc;
        this.Subject = Subject;
        this.PreviousEmailId = PreviousEmailId;
        this.Held = Held;
        this.Alerting = Alerting;
        this.Inbound = Inbound;
        this.InvitedBy = InvitedBy;
        this.AdditionalInfo = AdditionalInfo;

    }



    /// <summary>
    /// An email address that this email is to.
    /// </summary>
    /// <value>An email address that this email is to.</value>
    [JsonPropertyName("to")]
    public string To { get; set; }



    /// <summary>
    /// An email address that this email is from.
    /// </summary>
    /// <value>An email address that this email is from.</value>
    [JsonPropertyName("from")]
    public string From { get; set; }



    /// <summary>
    /// An email addresses that this email is carbon copied to.
    /// </summary>
    /// <value>An email addresses that this email is carbon copied to.</value>
    [JsonPropertyName("cc")]
    public List<string> Cc { get; set; }



    /// <summary>
    /// An email addresses that this email is blind carbon copied to.
    /// </summary>
    /// <value>An email addresses that this email is blind carbon copied to.</value>
    [JsonPropertyName("bcc")]
    public List<string> Bcc { get; set; }



    /// <summary>
    /// The subject for this email.
    /// </summary>
    /// <value>The subject for this email.</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }



    /// <summary>
    /// UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant.
    /// </summary>
    /// <value>UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant.</value>
    [JsonPropertyName("previousEmailId")]
    public string PreviousEmailId { get; set; }



    /// <summary>
    /// Indicates that this communication&#39;s initial state is held.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is held.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.</value>
    [JsonPropertyName("alerting")]
    public bool? Alerting { get; set; }



    /// <summary>
    /// Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.
    /// </summary>
    /// <value>Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.</value>
    [JsonPropertyName("inbound")]
    public bool? Inbound { get; set; }



    /// <summary>
    /// The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.
    /// </summary>
    /// <value>The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.</value>
    [JsonPropertyName("invitedBy")]
    public string InvitedBy { get; set; }



    /// <summary>
    /// Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.
    /// </summary>
    /// <value>Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.</value>
    [JsonPropertyName("additionalInfo")]
    public Dictionary<string, string> AdditionalInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailInitialConfiguration {\n");

        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Cc: ").Append(Cc).Append("\n");
        sb.Append("  Bcc: ").Append(Bcc).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  PreviousEmailId: ").Append(PreviousEmailId).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  Alerting: ").Append(Alerting).Append("\n");
        sb.Append("  Inbound: ").Append(Inbound).Append("\n");
        sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
        sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
        return Equals(obj as EmailInitialConfiguration);
    }

    /// <summary>
    /// Returns true if EmailInitialConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailInitialConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailInitialConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                To == other.To ||
                To != null &&
                To.Equals(other.To)
            ) &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
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
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                PreviousEmailId == other.PreviousEmailId ||
                PreviousEmailId != null &&
                PreviousEmailId.Equals(other.PreviousEmailId)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                Alerting == other.Alerting ||
                Alerting != null &&
                Alerting.Equals(other.Alerting)
            ) &&
            (
                Inbound == other.Inbound ||
                Inbound != null &&
                Inbound.Equals(other.Inbound)
            ) &&
            (
                InvitedBy == other.InvitedBy ||
                InvitedBy != null &&
                InvitedBy.Equals(other.InvitedBy)
            ) &&
            (
                AdditionalInfo == other.AdditionalInfo ||
                AdditionalInfo != null &&
                AdditionalInfo.SequenceEqual(other.AdditionalInfo)
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
            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (Cc != null)
            {
                hash = hash * 59 + Cc.GetHashCode();
            }

            if (Bcc != null)
            {
                hash = hash * 59 + Bcc.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (PreviousEmailId != null)
            {
                hash = hash * 59 + PreviousEmailId.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (Alerting != null)
            {
                hash = hash * 59 + Alerting.GetHashCode();
            }

            if (Inbound != null)
            {
                hash = hash * 59 + Inbound.GetHashCode();
            }

            if (InvitedBy != null)
            {
                hash = hash * 59 + InvitedBy.GetHashCode();
            }

            if (AdditionalInfo != null)
            {
                hash = hash * 59 + AdditionalInfo.GetHashCode();
            }

            return hash;
        }
    }
}
