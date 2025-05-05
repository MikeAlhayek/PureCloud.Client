using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OpenIntegrationUpdateRequest
/// </summary>

public partial class OpenIntegrationUpdateRequest : IEquatable<OpenIntegrationUpdateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenIntegrationUpdateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenIntegrationUpdateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenIntegrationUpdateRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the Open messaging integration. (required).</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
    /// <param name="OutboundNotificationWebhookUrl">The outbound notification webhook URL for the Open messaging integration..</param>
    /// <param name="OutboundNotificationWebhookSignatureSecretToken">The outbound notification webhook signature secret token..</param>
    /// <param name="WebhookHeaders">The user specified headers for the Open messaging integration..</param>
    public OpenIntegrationUpdateRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string OutboundNotificationWebhookUrl = null, string OutboundNotificationWebhookSignatureSecretToken = null, Dictionary<string, string> WebhookHeaders = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.OutboundNotificationWebhookUrl = OutboundNotificationWebhookUrl;
        this.OutboundNotificationWebhookSignatureSecretToken = OutboundNotificationWebhookSignatureSecretToken;
        this.WebhookHeaders = WebhookHeaders;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
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
    /// Defines the message settings to be applied for this integration
    /// </summary>
    /// <value>Defines the message settings to be applied for this integration</value>
    [JsonPropertyName("messagingSetting")]
    public MessagingSettingRequestReference MessagingSetting { get; set; }



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
        sb.Append("class OpenIntegrationUpdateRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  OutboundNotificationWebhookUrl: ").Append(OutboundNotificationWebhookUrl).Append("\n");
        sb.Append("  OutboundNotificationWebhookSignatureSecretToken: ").Append(OutboundNotificationWebhookSignatureSecretToken).Append("\n");
        sb.Append("  WebhookHeaders: ").Append(WebhookHeaders).Append("\n");
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
        return Equals(obj as OpenIntegrationUpdateRequest);
    }

    /// <summary>
    /// Returns true if OpenIntegrationUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenIntegrationUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenIntegrationUpdateRequest other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
