using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for a Nuance bot credentials
/// </summary>

public partial class NuanceBotCredentials : IEquatable<NuanceBotCredentials>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBotCredentials" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceBotCredentials() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBotCredentials" /> class.
    /// </summary>
    /// <param name="AppId">The application ID (required).</param>
    /// <param name="ClientId">The credentials client ID (required).</param>
    /// <param name="ClientSecret">The credentials client secret.</param>
    /// <param name="ClientSecretProvided">True if the credentials secret is set (but not returned due to security reasons).</param>
    public NuanceBotCredentials(string AppId = null, string ClientId = null, string ClientSecret = null, bool? ClientSecretProvided = null)
    {
        this.AppId = AppId;
        this.ClientId = ClientId;
        this.ClientSecret = ClientSecret;
        this.ClientSecretProvided = ClientSecretProvided;

    }



    /// <summary>
    /// The application ID
    /// </summary>
    /// <value>The application ID</value>
    [JsonPropertyName("appId")]
    public string AppId { get; set; }



    /// <summary>
    /// The credentials client ID
    /// </summary>
    /// <value>The credentials client ID</value>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }



    /// <summary>
    /// The credentials client secret
    /// </summary>
    /// <value>The credentials client secret</value>
    [JsonPropertyName("clientSecret")]
    public string ClientSecret { get; set; }



    /// <summary>
    /// True if the credentials secret is set (but not returned due to security reasons)
    /// </summary>
    /// <value>True if the credentials secret is set (but not returned due to security reasons)</value>
    [JsonPropertyName("clientSecretProvided")]
    public bool? ClientSecretProvided { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceBotCredentials {\n");

        sb.Append("  AppId: ").Append(AppId).Append("\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
        sb.Append("  ClientSecretProvided: ").Append(ClientSecretProvided).Append("\n");
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
        return Equals(obj as NuanceBotCredentials);
    }

    /// <summary>
    /// Returns true if NuanceBotCredentials instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceBotCredentials to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceBotCredentials other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AppId == other.AppId ||
                AppId != null &&
                AppId.Equals(other.AppId)
            ) &&
            (
                ClientId == other.ClientId ||
                ClientId != null &&
                ClientId.Equals(other.ClientId)
            ) &&
            (
                ClientSecret == other.ClientSecret ||
                ClientSecret != null &&
                ClientSecret.Equals(other.ClientSecret)
            ) &&
            (
                ClientSecretProvided == other.ClientSecretProvided ||
                ClientSecretProvided != null &&
                ClientSecretProvided.Equals(other.ClientSecretProvided)
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
            if (AppId != null)
            {
                hash = hash * 59 + AppId.GetHashCode();
            }

            if (ClientId != null)
            {
                hash = hash * 59 + ClientId.GetHashCode();
            }

            if (ClientSecret != null)
            {
                hash = hash * 59 + ClientSecret.GetHashCode();
            }

            if (ClientSecretProvided != null)
            {
                hash = hash * 59 + ClientSecretProvided.GetHashCode();
            }

            return hash;
        }
    }
}
