using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WhatsAppEmbeddedSignupIntegrationRequest
/// </summary>

public partial class WhatsAppEmbeddedSignupIntegrationRequest : IEquatable<WhatsAppEmbeddedSignupIntegrationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppEmbeddedSignupIntegrationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WhatsAppEmbeddedSignupIntegrationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppEmbeddedSignupIntegrationRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the WhatsApp Integration (required).</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
    /// <param name="EmbeddedSignupAccessToken">The access token returned from the embedded signup flow (required).</param>
    public WhatsAppEmbeddedSignupIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string EmbeddedSignupAccessToken = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.EmbeddedSignupAccessToken = EmbeddedSignupAccessToken;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the WhatsApp Integration
    /// </summary>
    /// <value>The name of the WhatsApp Integration</value>
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
    /// The access token returned from the embedded signup flow
    /// </summary>
    /// <value>The access token returned from the embedded signup flow</value>
    [JsonPropertyName("embeddedSignupAccessToken")]
    public string EmbeddedSignupAccessToken { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppEmbeddedSignupIntegrationRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  EmbeddedSignupAccessToken: ").Append(EmbeddedSignupAccessToken).Append("\n");
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
        return Equals(obj as WhatsAppEmbeddedSignupIntegrationRequest);
    }

    /// <summary>
    /// Returns true if WhatsAppEmbeddedSignupIntegrationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppEmbeddedSignupIntegrationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppEmbeddedSignupIntegrationRequest other)
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
                EmbeddedSignupAccessToken == other.EmbeddedSignupAccessToken ||
                EmbeddedSignupAccessToken != null &&
                EmbeddedSignupAccessToken.Equals(other.EmbeddedSignupAccessToken)
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

            if (EmbeddedSignupAccessToken != null)
            {
                hash = hash * 59 + EmbeddedSignupAccessToken.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
