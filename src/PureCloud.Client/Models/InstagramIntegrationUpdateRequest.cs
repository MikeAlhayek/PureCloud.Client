using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InstagramIntegrationUpdateRequest
/// </summary>

public partial class InstagramIntegrationUpdateRequest : IEquatable<InstagramIntegrationUpdateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InstagramIntegrationUpdateRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the Instagram Integration.</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
    /// <param name="PageAccessToken">The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided..</param>
    /// <param name="UserAccessToken">The short-lived User Access Token of the Instagram user logged into the Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided..</param>
    public InstagramIntegrationUpdateRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string PageAccessToken = null, string UserAccessToken = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.PageAccessToken = PageAccessToken;
        this.UserAccessToken = UserAccessToken;

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
    /// The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.
    /// </summary>
    /// <value>The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.</value>
    [JsonPropertyName("pageAccessToken")]
    public string PageAccessToken { get; set; }



    /// <summary>
    /// The short-lived User Access Token of the Instagram user logged into the Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.
    /// </summary>
    /// <value>The short-lived User Access Token of the Instagram user logged into the Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.</value>
    [JsonPropertyName("userAccessToken")]
    public string UserAccessToken { get; set; }



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
        sb.Append("class InstagramIntegrationUpdateRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  PageAccessToken: ").Append(PageAccessToken).Append("\n");
        sb.Append("  UserAccessToken: ").Append(UserAccessToken).Append("\n");
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
        return Equals(obj as InstagramIntegrationUpdateRequest);
    }

    /// <summary>
    /// Returns true if InstagramIntegrationUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of InstagramIntegrationUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InstagramIntegrationUpdateRequest other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
