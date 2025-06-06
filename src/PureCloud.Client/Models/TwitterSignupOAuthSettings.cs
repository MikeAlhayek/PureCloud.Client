using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TwitterSignupOAuthSettings
/// </summary>

public partial class TwitterSignupOAuthSettings : IEquatable<TwitterSignupOAuthSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterSignupOAuthSettings" /> class.
    /// </summary>
    /// <param name="ClientId">The client id of the twitter app the requesting org will use to signup.</param>
    /// <param name="Scopes">The scopes/permissions requested during the signup process during the signup process to allow their future integrations to direct message.</param>
    /// <param name="AppId">The app id of the twitter app the requesting org will use to signup.</param>
    public TwitterSignupOAuthSettings(string ClientId = null, List<string> Scopes = null, string AppId = null)
    {
        this.ClientId = ClientId;
        this.Scopes = Scopes;
        this.AppId = AppId;

    }



    /// <summary>
    /// The client id of the twitter app the requesting org will use to signup
    /// </summary>
    /// <value>The client id of the twitter app the requesting org will use to signup</value>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }



    /// <summary>
    /// The scopes/permissions requested during the signup process during the signup process to allow their future integrations to direct message
    /// </summary>
    /// <value>The scopes/permissions requested during the signup process during the signup process to allow their future integrations to direct message</value>
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }



    /// <summary>
    /// The app id of the twitter app the requesting org will use to signup
    /// </summary>
    /// <value>The app id of the twitter app the requesting org will use to signup</value>
    [JsonPropertyName("appId")]
    public string AppId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TwitterSignupOAuthSettings {\n");

        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  Scopes: ").Append(Scopes).Append("\n");
        sb.Append("  AppId: ").Append(AppId).Append("\n");
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
        return Equals(obj as TwitterSignupOAuthSettings);
    }

    /// <summary>
    /// Returns true if TwitterSignupOAuthSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of TwitterSignupOAuthSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitterSignupOAuthSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ClientId == other.ClientId ||
                ClientId != null &&
                ClientId.Equals(other.ClientId)
            ) &&
            (
                Scopes == other.Scopes ||
                Scopes != null &&
                Scopes.SequenceEqual(other.Scopes)
            ) &&
            (
                AppId == other.AppId ||
                AppId != null &&
                AppId.Equals(other.AppId)
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
            if (ClientId != null)
            {
                hash = hash * 59 + ClientId.GetHashCode();
            }

            if (Scopes != null)
            {
                hash = hash * 59 + Scopes.GetHashCode();
            }

            if (AppId != null)
            {
                hash = hash * 59 + AppId.GetHashCode();
            }

            return hash;
        }
    }
}
