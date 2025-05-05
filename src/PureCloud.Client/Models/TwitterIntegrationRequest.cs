using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TwitterIntegrationRequest
/// </summary>

public partial class TwitterIntegrationRequest : IEquatable<TwitterIntegrationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterIntegrationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TwitterIntegrationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterIntegrationRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the Twitter Integration (required).</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
    /// <param name="SignupCode">The authorization code returned from the signup flow to request access tokens later on (required).</param>
    /// <param name="AppId">The appId of the Twitter app to register the integration on (required).</param>
    /// <param name="CodeChallenge">The codeChallenge used during the signup flow (required).</param>
    /// <param name="RedirectUri">The redirectUri used during the signup flow (required).</param>
    public TwitterIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string SignupCode = null, string AppId = null, string CodeChallenge = null, string RedirectUri = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.SignupCode = SignupCode;
        this.AppId = AppId;
        this.CodeChallenge = CodeChallenge;
        this.RedirectUri = RedirectUri;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the Twitter Integration
    /// </summary>
    /// <value>The name of the Twitter Integration</value>
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
    /// The authorization code returned from the signup flow to request access tokens later on
    /// </summary>
    /// <value>The authorization code returned from the signup flow to request access tokens later on</value>
    [JsonPropertyName("signupCode")]
    public string SignupCode { get; set; }



    /// <summary>
    /// The appId of the Twitter app to register the integration on
    /// </summary>
    /// <value>The appId of the Twitter app to register the integration on</value>
    [JsonPropertyName("appId")]
    public string AppId { get; set; }



    /// <summary>
    /// The codeChallenge used during the signup flow
    /// </summary>
    /// <value>The codeChallenge used during the signup flow</value>
    [JsonPropertyName("codeChallenge")]
    public string CodeChallenge { get; set; }



    /// <summary>
    /// The redirectUri used during the signup flow
    /// </summary>
    /// <value>The redirectUri used during the signup flow</value>
    [JsonPropertyName("redirectUri")]
    public string RedirectUri { get; set; }



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
        sb.Append("class TwitterIntegrationRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  SignupCode: ").Append(SignupCode).Append("\n");
        sb.Append("  AppId: ").Append(AppId).Append("\n");
        sb.Append("  CodeChallenge: ").Append(CodeChallenge).Append("\n");
        sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
        return Equals(obj as TwitterIntegrationRequest);
    }

    /// <summary>
    /// Returns true if TwitterIntegrationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TwitterIntegrationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitterIntegrationRequest other)
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
                SignupCode == other.SignupCode ||
                SignupCode != null &&
                SignupCode.Equals(other.SignupCode)
            ) &&
            (
                AppId == other.AppId ||
                AppId != null &&
                AppId.Equals(other.AppId)
            ) &&
            (
                CodeChallenge == other.CodeChallenge ||
                CodeChallenge != null &&
                CodeChallenge.Equals(other.CodeChallenge)
            ) &&
            (
                RedirectUri == other.RedirectUri ||
                RedirectUri != null &&
                RedirectUri.Equals(other.RedirectUri)
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

            if (SignupCode != null)
            {
                hash = hash * 59 + SignupCode.GetHashCode();
            }

            if (AppId != null)
            {
                hash = hash * 59 + AppId.GetHashCode();
            }

            if (CodeChallenge != null)
            {
                hash = hash * 59 + CodeChallenge.GetHashCode();
            }

            if (RedirectUri != null)
            {
                hash = hash * 59 + RedirectUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
