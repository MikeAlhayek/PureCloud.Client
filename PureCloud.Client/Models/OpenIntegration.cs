using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OpenIntegration
/// </summary>

public partial class OpenIntegration : IEquatable<OpenIntegration>
{
    /// <summary>
    /// Status of asynchronous create operation
    /// </summary>
    /// <value>Status of asynchronous create operation</value>
    
    public enum CreateStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Initiated for "Initiated"
        /// </summary>
        [EnumMember(Value = "Initiated")]
        Initiated,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Status of asynchronous create operation
    /// </summary>
    /// <value>Status of asynchronous create operation</value>
    [JsonPropertyName("createStatus")]
    public CreateStatusEnum? CreateStatus { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenIntegration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenIntegration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenIntegration" /> class.
    /// </summary>
    /// <param name="Name">The name of the Open messaging integration. (required).</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">MessagingSetting.</param>
    /// <param name="OutboundNotificationWebhookUrl">The outbound notification webhook URL for the Open messaging integration. (required).</param>
    /// <param name="OutboundNotificationWebhookSignatureSecretToken">The outbound notification webhook signature secret token. (required).</param>
    /// <param name="WebhookHeaders">The user specified headers for the Open messaging integration..</param>
    /// <param name="Status">The status of the Open Integration.</param>
    /// <param name="DateCreated">Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">User reference that created this Integration.</param>
    /// <param name="ModifiedBy">User reference that last modified this Integration.</param>
    public OpenIntegration(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingReference MessagingSetting = null, string OutboundNotificationWebhookUrl = null, string OutboundNotificationWebhookSignatureSecretToken = null, Dictionary<string, string> WebhookHeaders = null, string Status = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.OutboundNotificationWebhookUrl = OutboundNotificationWebhookUrl;
        this.OutboundNotificationWebhookSignatureSecretToken = OutboundNotificationWebhookSignatureSecretToken;
        this.WebhookHeaders = WebhookHeaders;
        this.Status = Status;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.ModifiedBy = ModifiedBy;

    }



    /// <summary>
    /// A unique Integration Id.
    /// </summary>
    /// <value>A unique Integration Id.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the Open messaging integration.
    /// </summary>
    /// <value>The name of the Open messaging integration.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Defines the SupportedContent profile configured for an integration
    /// </summary>
    /// <value>Defines the SupportedContent profile configured for an integration</value>
    [JsonPropertyName("supportedContent")]
    public SupportedContentReference SupportedContent { get; set; }



    /// <summary>
    /// Gets or Sets MessagingSetting
    /// </summary>
    [JsonPropertyName("messagingSetting")]
    public MessagingSettingReference MessagingSetting { get; set; }



    /// <summary>
    /// The outbound notification webhook URL for the Open messaging integration.
    /// </summary>
    /// <value>The outbound notification webhook URL for the Open messaging integration.</value>
    [JsonPropertyName("outboundNotificationWebhookUrl")]
    public string OutboundNotificationWebhookUrl { get; set; }



    /// <summary>
    /// The outbound notification webhook signature secret token.
    /// </summary>
    /// <value>The outbound notification webhook signature secret token.</value>
    [JsonPropertyName("outboundNotificationWebhookSignatureSecretToken")]
    public string OutboundNotificationWebhookSignatureSecretToken { get; set; }



    /// <summary>
    /// The user specified headers for the Open messaging integration.
    /// </summary>
    /// <value>The user specified headers for the Open messaging integration.</value>
    [JsonPropertyName("webhookHeaders")]
    public Dictionary<string, string> WebhookHeaders { get; set; }



    /// <summary>
    /// The status of the Open Integration
    /// </summary>
    /// <value>The status of the Open Integration</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }



    /// <summary>
    /// The recipient associated to the Open messaging Integration. This recipient is used to associate a flow to an integration
    /// </summary>
    /// <value>The recipient associated to the Open messaging Integration. This recipient is used to associate a flow to an integration</value>
    [JsonPropertyName("recipient")]
    public DomainEntityRef Recipient { get; private set; }



    /// <summary>
    /// Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// User reference that created this Integration
    /// </summary>
    /// <value>User reference that created this Integration</value>
    [JsonPropertyName("createdBy")]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// User reference that last modified this Integration
    /// </summary>
    /// <value>User reference that last modified this Integration</value>
    [JsonPropertyName("modifiedBy")]
    public DomainEntityRef ModifiedBy { get; set; }





    /// <summary>
    /// Error information returned, if createStatus is set to Error
    /// </summary>
    /// <value>Error information returned, if createStatus is set to Error</value>
    [JsonPropertyName("createError")]
    public ErrorBody CreateError { get; private set; }



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
        sb.Append("class OpenIntegration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  OutboundNotificationWebhookUrl: ").Append(OutboundNotificationWebhookUrl).Append("\n");
        sb.Append("  OutboundNotificationWebhookSignatureSecretToken: ").Append(OutboundNotificationWebhookSignatureSecretToken).Append("\n");
        sb.Append("  WebhookHeaders: ").Append(WebhookHeaders).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Recipient: ").Append(Recipient).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  CreateStatus: ").Append(CreateStatus).Append("\n");
        sb.Append("  CreateError: ").Append(CreateError).Append("\n");
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
        return Equals(obj as OpenIntegration);
    }

    /// <summary>
    /// Returns true if OpenIntegration instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenIntegration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenIntegration other)
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
                SupportedContent == other.SupportedContent ||
                SupportedContent != null &&
                SupportedContent.Equals(other.SupportedContent)
            ) &&
            (
                MessagingSetting == other.MessagingSetting ||
                MessagingSetting != null &&
                MessagingSetting.Equals(other.MessagingSetting)
            ) &&
            (
                OutboundNotificationWebhookUrl == other.OutboundNotificationWebhookUrl ||
                OutboundNotificationWebhookUrl != null &&
                OutboundNotificationWebhookUrl.Equals(other.OutboundNotificationWebhookUrl)
            ) &&
            (
                OutboundNotificationWebhookSignatureSecretToken == other.OutboundNotificationWebhookSignatureSecretToken ||
                OutboundNotificationWebhookSignatureSecretToken != null &&
                OutboundNotificationWebhookSignatureSecretToken.Equals(other.OutboundNotificationWebhookSignatureSecretToken)
            ) &&
            (
                WebhookHeaders == other.WebhookHeaders ||
                WebhookHeaders != null &&
                WebhookHeaders.SequenceEqual(other.WebhookHeaders)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Recipient == other.Recipient ||
                Recipient != null &&
                Recipient.Equals(other.Recipient)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                CreateStatus == other.CreateStatus ||
                CreateStatus != null &&
                CreateStatus.Equals(other.CreateStatus)
            ) &&
            (
                CreateError == other.CreateError ||
                CreateError != null &&
                CreateError.Equals(other.CreateError)
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

            if (SupportedContent != null)
            {
                hash = hash * 59 + SupportedContent.GetHashCode();
            }

            if (MessagingSetting != null)
            {
                hash = hash * 59 + MessagingSetting.GetHashCode();
            }

            if (OutboundNotificationWebhookUrl != null)
            {
                hash = hash * 59 + OutboundNotificationWebhookUrl.GetHashCode();
            }

            if (OutboundNotificationWebhookSignatureSecretToken != null)
            {
                hash = hash * 59 + OutboundNotificationWebhookSignatureSecretToken.GetHashCode();
            }

            if (WebhookHeaders != null)
            {
                hash = hash * 59 + WebhookHeaders.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Recipient != null)
            {
                hash = hash * 59 + Recipient.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (CreateStatus != null)
            {
                hash = hash * 59 + CreateStatus.GetHashCode();
            }

            if (CreateError != null)
            {
                hash = hash * 59 + CreateError.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
