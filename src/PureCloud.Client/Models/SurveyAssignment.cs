using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyAssignment
/// </summary>

public partial class SurveyAssignment : IEquatable<SurveyAssignment>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyAssignment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SurveyAssignment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyAssignment" /> class.
    /// </summary>
    /// <param name="SurveyForm">The survey form used for this survey..</param>
    /// <param name="Flow">The URI reference to the flow associated with this survey..</param>
    /// <param name="InviteTimeInterval">An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days..</param>
    /// <param name="SendingUser">User together with sendingDomain used to send email, null to use no-reply.</param>
    /// <param name="SendingDomain">Validated email domain, required (required).</param>
    public SurveyAssignment(PublishedSurveyFormReference SurveyForm = null, DomainEntityRef Flow = null, string InviteTimeInterval = null, string SendingUser = null, string SendingDomain = null)
    {
        this.SurveyForm = SurveyForm;
        this.Flow = Flow;
        this.InviteTimeInterval = InviteTimeInterval;
        this.SendingUser = SendingUser;
        this.SendingDomain = SendingDomain;

    }



    /// <summary>
    /// The survey form used for this survey.
    /// </summary>
    /// <value>The survey form used for this survey.</value>
    [JsonPropertyName("surveyForm")]
    public PublishedSurveyFormReference SurveyForm { get; set; }



    /// <summary>
    /// The URI reference to the flow associated with this survey.
    /// </summary>
    /// <value>The URI reference to the flow associated with this survey.</value>
    [JsonPropertyName("flow")]
    public DomainEntityRef Flow { get; set; }



    /// <summary>
    /// An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days.
    /// </summary>
    /// <value>An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days.</value>
    [JsonPropertyName("inviteTimeInterval")]
    public string InviteTimeInterval { get; set; }



    /// <summary>
    /// User together with sendingDomain used to send email, null to use no-reply
    /// </summary>
    /// <value>User together with sendingDomain used to send email, null to use no-reply</value>
    [JsonPropertyName("sendingUser")]
    public string SendingUser { get; set; }



    /// <summary>
    /// Validated email domain, required
    /// </summary>
    /// <value>Validated email domain, required</value>
    [JsonPropertyName("sendingDomain")]
    public string SendingDomain { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyAssignment {\n");

        sb.Append("  SurveyForm: ").Append(SurveyForm).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  InviteTimeInterval: ").Append(InviteTimeInterval).Append("\n");
        sb.Append("  SendingUser: ").Append(SendingUser).Append("\n");
        sb.Append("  SendingDomain: ").Append(SendingDomain).Append("\n");
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
        return Equals(obj as SurveyAssignment);
    }

    /// <summary>
    /// Returns true if SurveyAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyAssignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SurveyForm == other.SurveyForm ||
                SurveyForm != null &&
                SurveyForm.Equals(other.SurveyForm)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                InviteTimeInterval == other.InviteTimeInterval ||
                InviteTimeInterval != null &&
                InviteTimeInterval.Equals(other.InviteTimeInterval)
            ) &&
            (
                SendingUser == other.SendingUser ||
                SendingUser != null &&
                SendingUser.Equals(other.SendingUser)
            ) &&
            (
                SendingDomain == other.SendingDomain ||
                SendingDomain != null &&
                SendingDomain.Equals(other.SendingDomain)
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
            if (SurveyForm != null)
            {
                hash = hash * 59 + SurveyForm.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (InviteTimeInterval != null)
            {
                hash = hash * 59 + InviteTimeInterval.GetHashCode();
            }

            if (SendingUser != null)
            {
                hash = hash * 59 + SendingUser.GetHashCode();
            }

            if (SendingDomain != null)
            {
                hash = hash * 59 + SendingDomain.GetHashCode();
            }

            return hash;
        }
    }
}
