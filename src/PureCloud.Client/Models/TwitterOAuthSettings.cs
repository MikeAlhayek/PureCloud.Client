using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TwitterOAuthSettings
/// </summary>

public partial class TwitterOAuthSettings : IEquatable<TwitterOAuthSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterOAuthSettings" /> class.
    /// </summary>
    /// <param name="ClientId">The client id of the twitter app the requesting org will use to signup.</param>
    /// <param name="Scopes">The scopes/permissions requested during the signup process during the signup process to allow their future integrations to direct message.</param>
    public TwitterOAuthSettings(string ClientId = null, List<string> Scopes = null)
    {
        this.ClientId = ClientId;
        this.Scopes = Scopes;

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TwitterOAuthSettings {\n");

        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
        return Equals(obj as TwitterOAuthSettings);
    }

    /// <summary>
    /// Returns true if TwitterOAuthSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of TwitterOAuthSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitterOAuthSettings other)
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

            return hash;
        }
    }
}
