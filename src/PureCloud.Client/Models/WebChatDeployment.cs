using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatDeployment
/// </summary>

public partial class WebChatDeployment : IEquatable<WebChatDeployment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatDeployment" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="AuthenticationRequired">AuthenticationRequired.</param>
    /// <param name="AuthenticationUrl">URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples.</param>
    /// <param name="Disabled">Disabled.</param>
    /// <param name="WebChatConfig">WebChatConfig.</param>
    /// <param name="AllowedDomains">AllowedDomains.</param>
    /// <param name="Flow">The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment..</param>
    public WebChatDeployment(string Name = null, string Description = null, bool? AuthenticationRequired = null, string AuthenticationUrl = null, bool? Disabled = null, WebChatConfig WebChatConfig = null, List<string> AllowedDomains = null, DomainEntityRef Flow = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.AuthenticationRequired = AuthenticationRequired;
        this.AuthenticationUrl = AuthenticationUrl;
        this.Disabled = Disabled;
        this.WebChatConfig = WebChatConfig;
        this.AllowedDomains = AllowedDomains;
        this.Flow = Flow;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets AuthenticationRequired
    /// </summary>
    [JsonPropertyName("authenticationRequired")]
    public bool? AuthenticationRequired { get; set; }



    /// <summary>
    /// URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples
    /// </summary>
    /// <value>URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples</value>
    [JsonPropertyName("authenticationUrl")]
    public string AuthenticationUrl { get; set; }



    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }



    /// <summary>
    /// Gets or Sets WebChatConfig
    /// </summary>
    [JsonPropertyName("webChatConfig")]
    public WebChatConfig WebChatConfig { get; set; }



    /// <summary>
    /// Gets or Sets AllowedDomains
    /// </summary>
    [JsonPropertyName("allowedDomains")]
    public List<string> AllowedDomains { get; set; }



    /// <summary>
    /// The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.
    /// </summary>
    /// <value>The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.</value>
    [JsonPropertyName("flow")]
    public DomainEntityRef Flow { get; set; }



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
        sb.Append("class WebChatDeployment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  AuthenticationRequired: ").Append(AuthenticationRequired).Append("\n");
        sb.Append("  AuthenticationUrl: ").Append(AuthenticationUrl).Append("\n");
        sb.Append("  Disabled: ").Append(Disabled).Append("\n");
        sb.Append("  WebChatConfig: ").Append(WebChatConfig).Append("\n");
        sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
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
        return Equals(obj as WebChatDeployment);
    }

    /// <summary>
    /// Returns true if WebChatDeployment instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatDeployment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatDeployment other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                AuthenticationRequired == other.AuthenticationRequired ||
                AuthenticationRequired != null &&
                AuthenticationRequired.Equals(other.AuthenticationRequired)
            ) &&
            (
                AuthenticationUrl == other.AuthenticationUrl ||
                AuthenticationUrl != null &&
                AuthenticationUrl.Equals(other.AuthenticationUrl)
            ) &&
            (
                Disabled == other.Disabled ||
                Disabled != null &&
                Disabled.Equals(other.Disabled)
            ) &&
            (
                WebChatConfig == other.WebChatConfig ||
                WebChatConfig != null &&
                WebChatConfig.Equals(other.WebChatConfig)
            ) &&
            (
                AllowedDomains == other.AllowedDomains ||
                AllowedDomains != null &&
                AllowedDomains.SequenceEqual(other.AllowedDomains)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (AuthenticationRequired != null)
            {
                hash = hash * 59 + AuthenticationRequired.GetHashCode();
            }

            if (AuthenticationUrl != null)
            {
                hash = hash * 59 + AuthenticationUrl.GetHashCode();
            }

            if (Disabled != null)
            {
                hash = hash * 59 + Disabled.GetHashCode();
            }

            if (WebChatConfig != null)
            {
                hash = hash * 59 + WebChatConfig.GetHashCode();
            }

            if (AllowedDomains != null)
            {
                hash = hash * 59 + AllowedDomains.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
