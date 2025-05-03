using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateEmailRequest
/// </summary>

public partial class CreateEmailRequest : IEquatable<CreateEmailRequest>
{
    /// <summary>
    /// Specify OUTBOUND to send an email on behalf of a queue, or INBOUND to create an external conversation. An external conversation is one where the provider is not PureCloudEnvironment based.
    /// </summary>
    /// <value>Specify OUTBOUND to send an email on behalf of a queue, or INBOUND to create an external conversation. An external conversation is one where the provider is not PureCloudEnvironment based.</value>
    
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Outbound for "OUTBOUND"
        /// </summary>
        [EnumMember(Value = "OUTBOUND")]
        Outbound,

        /// <summary>
        /// Enum Inbound for "INBOUND"
        /// </summary>
        [EnumMember(Value = "INBOUND")]
        Inbound
    }
    /// <summary>
    /// Specify OUTBOUND to send an email on behalf of a queue, or INBOUND to create an external conversation. An external conversation is one where the provider is not PureCloudEnvironment based.
    /// </summary>
    /// <value>Specify OUTBOUND to send an email on behalf of a queue, or INBOUND to create an external conversation. An external conversation is one where the provider is not PureCloudEnvironment based.</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateEmailRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateEmailRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateEmailRequest" /> class.
    /// </summary>
    /// <param name="QueueId">The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId.</param>
    /// <param name="FlowId">The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId.</param>
    /// <param name="Provider">The name of the provider that is sourcing the emails. The Provider \&quot;PureCloudEnvironment Email\&quot; is reserved for native emails. (required).</param>
    /// <param name="SkillIds">The list of skill ID&#39;s to use for routing..</param>
    /// <param name="LanguageId">The ID of the language to use for routing..</param>
    /// <param name="Priority">The priority to assign to the conversation for routing..</param>
    /// <param name="Attributes">The list of attributes to associate with the customer participant..</param>
    /// <param name="ToAddress">The email address of the recipient of the email..</param>
    /// <param name="ToName">The name of the recipient of the email..</param>
    /// <param name="FromAddress">The email address of the sender of the email..</param>
    /// <param name="FromName">The name of the sender of the email..</param>
    /// <param name="Subject">The subject of the email.</param>
    /// <param name="Direction">Specify OUTBOUND to send an email on behalf of a queue, or INBOUND to create an external conversation. An external conversation is one where the provider is not PureCloudEnvironment based..</param>
    /// <param name="HtmlBody">An HTML body content of the email..</param>
    /// <param name="TextBody">A text body content of the email..</param>
    /// <param name="ExternalContactId">The external contact with which the email should be associated. This field is only valid for OUTBOUND email..</param>
    /// <param name="UtilizationLabel">Optional. The ID of the label to controls the number of agent interactions for INBOUND communications.</param>
    public CreateEmailRequest(string QueueId = null, string FlowId = null, string Provider = null, List<string> SkillIds = null, string LanguageId = null, long? Priority = null, Dictionary<string, string> Attributes = null, string ToAddress = null, string ToName = null, string FromAddress = null, string FromName = null, string Subject = null, DirectionEnum? Direction = null, string HtmlBody = null, string TextBody = null, string ExternalContactId = null, string UtilizationLabel = null)
    {
        this.QueueId = QueueId;
        this.FlowId = FlowId;
        this.Provider = Provider;
        this.SkillIds = SkillIds;
        this.LanguageId = LanguageId;
        this.Priority = Priority;
        this.Attributes = Attributes;
        this.ToAddress = ToAddress;
        this.ToName = ToName;
        this.FromAddress = FromAddress;
        this.FromName = FromName;
        this.Subject = Subject;
        this.Direction = Direction;
        this.HtmlBody = HtmlBody;
        this.TextBody = TextBody;
        this.ExternalContactId = ExternalContactId;
        this.UtilizationLabel = UtilizationLabel;

    }



    /// <summary>
    /// The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId
    /// </summary>
    /// <value>The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId
    /// </summary>
    /// <value>The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId</value>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }



    /// <summary>
    /// The name of the provider that is sourcing the emails. The Provider \&quot;PureCloudEnvironment Email\&quot; is reserved for native emails.
    /// </summary>
    /// <value>The name of the provider that is sourcing the emails. The Provider \&quot;PureCloudEnvironment Email\&quot; is reserved for native emails.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// The list of skill ID&#39;s to use for routing.
    /// </summary>
    /// <value>The list of skill ID&#39;s to use for routing.</value>
    [JsonPropertyName("skillIds")]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// The ID of the language to use for routing.
    /// </summary>
    /// <value>The ID of the language to use for routing.</value>
    [JsonPropertyName("languageId")]
    public string LanguageId { get; set; }



    /// <summary>
    /// The priority to assign to the conversation for routing.
    /// </summary>
    /// <value>The priority to assign to the conversation for routing.</value>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }



    /// <summary>
    /// The list of attributes to associate with the customer participant.
    /// </summary>
    /// <value>The list of attributes to associate with the customer participant.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// The email address of the recipient of the email.
    /// </summary>
    /// <value>The email address of the recipient of the email.</value>
    [JsonPropertyName("toAddress")]
    public string ToAddress { get; set; }



    /// <summary>
    /// The name of the recipient of the email.
    /// </summary>
    /// <value>The name of the recipient of the email.</value>
    [JsonPropertyName("toName")]
    public string ToName { get; set; }



    /// <summary>
    /// The email address of the sender of the email.
    /// </summary>
    /// <value>The email address of the sender of the email.</value>
    [JsonPropertyName("fromAddress")]
    public string FromAddress { get; set; }



    /// <summary>
    /// The name of the sender of the email.
    /// </summary>
    /// <value>The name of the sender of the email.</value>
    [JsonPropertyName("fromName")]
    public string FromName { get; set; }



    /// <summary>
    /// The subject of the email
    /// </summary>
    /// <value>The subject of the email</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }





    /// <summary>
    /// An HTML body content of the email.
    /// </summary>
    /// <value>An HTML body content of the email.</value>
    [JsonPropertyName("htmlBody")]
    public string HtmlBody { get; set; }



    /// <summary>
    /// A text body content of the email.
    /// </summary>
    /// <value>A text body content of the email.</value>
    [JsonPropertyName("textBody")]
    public string TextBody { get; set; }



    /// <summary>
    /// The external contact with which the email should be associated. This field is only valid for OUTBOUND email.
    /// </summary>
    /// <value>The external contact with which the email should be associated. This field is only valid for OUTBOUND email.</value>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// Optional. The ID of the label to controls the number of agent interactions for INBOUND communications
    /// </summary>
    /// <value>Optional. The ID of the label to controls the number of agent interactions for INBOUND communications</value>
    [JsonPropertyName("utilizationLabel")]
    public string UtilizationLabel { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateEmailRequest {\n");

        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  ToName: ").Append(ToName).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  FromName: ").Append(FromName).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  UtilizationLabel: ").Append(UtilizationLabel).Append("\n");
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
        return Equals(obj as CreateEmailRequest);
    }

    /// <summary>
    /// Returns true if CreateEmailRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateEmailRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateEmailRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.SequenceEqual(other.SkillIds)
            ) &&
            (
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                ToAddress == other.ToAddress ||
                ToAddress != null &&
                ToAddress.Equals(other.ToAddress)
            ) &&
            (
                ToName == other.ToName ||
                ToName != null &&
                ToName.Equals(other.ToName)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                FromName == other.FromName ||
                FromName != null &&
                FromName.Equals(other.FromName)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
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
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                UtilizationLabel == other.UtilizationLabel ||
                UtilizationLabel != null &&
                UtilizationLabel.Equals(other.UtilizationLabel)
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
            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (ToName != null)
            {
                hash = hash * 59 + ToName.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (FromName != null)
            {
                hash = hash * 59 + FromName.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (HtmlBody != null)
            {
                hash = hash * 59 + HtmlBody.GetHashCode();
            }

            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (UtilizationLabel != null)
            {
                hash = hash * 59 + UtilizationLabel.GetHashCode();
            }

            return hash;
        }
    }
}
