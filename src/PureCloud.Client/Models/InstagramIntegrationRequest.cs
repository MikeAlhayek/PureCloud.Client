using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InstagramIntegrationRequest
/// </summary>

public partial class InstagramIntegrationRequest : IEquatable<InstagramIntegrationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="InstagramIntegrationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InstagramIntegrationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InstagramIntegrationRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the Instagram Integration (required).</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
    /// <param name="PageAccessToken">The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required..</param>
    /// <param name="UserAccessToken">The short-lived User Access Token of Instagram user logged into Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required..</param>
    /// <param name="PageId">The page ID of Instagram page. The pageId is required when userAccessToken is provided..</param>
    /// <param name="AppId">The app ID of Facebook app. The appId is required when a customer wants to use their own approved Facebook app..</param>
    /// <param name="AppSecret">The app Secret of Facebook app. The appSecret is required when appId is provided..</param>
    public InstagramIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string PageAccessToken = null, string UserAccessToken = null, string PageId = null, string AppId = null, string AppSecret = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.PageAccessToken = PageAccessToken;
        this.UserAccessToken = UserAccessToken;
        this.PageId = PageId;
        this.AppId = AppId;
        this.AppSecret = AppSecret;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the Instagram Integration
    /// </summary>
    /// <value>The name of the Instagram Integration</value>
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
    /// The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required.
    /// </summary>
    /// <value>The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required.</value>
    [JsonPropertyName("pageAccessToken")]
    public string PageAccessToken { get; set; }



    /// <summary>
    /// The short-lived User Access Token of Instagram user logged into Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required.
    /// </summary>
    /// <value>The short-lived User Access Token of Instagram user logged into Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required.</value>
    [JsonPropertyName("userAccessToken")]
    public string UserAccessToken { get; set; }



    /// <summary>
    /// The page ID of Instagram page. The pageId is required when userAccessToken is provided.
    /// </summary>
    /// <value>The page ID of Instagram page. The pageId is required when userAccessToken is provided.</value>
    [JsonPropertyName("pageId")]
    public string PageId { get; set; }



    /// <summary>
    /// The app ID of Facebook app. The appId is required when a customer wants to use their own approved Facebook app.
    /// </summary>
    /// <value>The app ID of Facebook app. The appId is required when a customer wants to use their own approved Facebook app.</value>
    [JsonPropertyName("appId")]
    public string AppId { get; set; }



    /// <summary>
    /// The app Secret of Facebook app. The appSecret is required when appId is provided.
    /// </summary>
    /// <value>The app Secret of Facebook app. The appSecret is required when appId is provided.</value>
    [JsonPropertyName("appSecret")]
    public string AppSecret { get; set; }



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
        sb.Append("class InstagramIntegrationRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  PageAccessToken: ").Append(PageAccessToken).Append("\n");
        sb.Append("  UserAccessToken: ").Append(UserAccessToken).Append("\n");
        sb.Append("  PageId: ").Append(PageId).Append("\n");
        sb.Append("  AppId: ").Append(AppId).Append("\n");
        sb.Append("  AppSecret: ").Append(AppSecret).Append("\n");
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
        return Equals(obj as InstagramIntegrationRequest);
    }

    /// <summary>
    /// Returns true if InstagramIntegrationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of InstagramIntegrationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InstagramIntegrationRequest other)
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
                PageAccessToken == other.PageAccessToken ||
                PageAccessToken != null &&
                PageAccessToken.Equals(other.PageAccessToken)
            ) &&
            (
                UserAccessToken == other.UserAccessToken ||
                UserAccessToken != null &&
                UserAccessToken.Equals(other.UserAccessToken)
            ) &&
            (
                PageId == other.PageId ||
                PageId != null &&
                PageId.Equals(other.PageId)
            ) &&
            (
                AppId == other.AppId ||
                AppId != null &&
                AppId.Equals(other.AppId)
            ) &&
            (
                AppSecret == other.AppSecret ||
                AppSecret != null &&
                AppSecret.Equals(other.AppSecret)
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

            if (PageAccessToken != null)
            {
                hash = hash * 59 + PageAccessToken.GetHashCode();
            }

            if (UserAccessToken != null)
            {
                hash = hash * 59 + UserAccessToken.GetHashCode();
            }

            if (PageId != null)
            {
                hash = hash * 59 + PageId.GetHashCode();
            }

            if (AppId != null)
            {
                hash = hash * 59 + AppId.GetHashCode();
            }

            if (AppSecret != null)
            {
                hash = hash * 59 + AppSecret.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
