using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for authenticated webdeployments.
/// </summary>
[DataContract]
public partial class AuthenticationSettings : IEquatable<AuthenticationSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuthenticationSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Indicate if these auth is required for this deployment. If, for example, this flag is set to true then webmessaging sessions can not send messages unless the end-user is authenticated. (required).</param>
    /// <param name="IntegrationId">The integration identifier which contains the auth settings required on the deployment. (required).</param>
    /// <param name="AllowSessionUpgrade">Allow end-users to upgrade an anonymous session to authenticated conversation..</param>
    public AuthenticationSettings(bool? Enabled = null, string IntegrationId = null, bool? AllowSessionUpgrade = null)
    {
        this.Enabled = Enabled;
        this.IntegrationId = IntegrationId;
        this.AllowSessionUpgrade = AllowSessionUpgrade;

    }



    /// <summary>
    /// Indicate if these auth is required for this deployment. If, for example, this flag is set to true then webmessaging sessions can not send messages unless the end-user is authenticated.
    /// </summary>
    /// <value>Indicate if these auth is required for this deployment. If, for example, this flag is set to true then webmessaging sessions can not send messages unless the end-user is authenticated.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The integration identifier which contains the auth settings required on the deployment.
    /// </summary>
    /// <value>The integration identifier which contains the auth settings required on the deployment.</value>
    [DataMember(Name = "integrationId", EmitDefaultValue = false)]
    public string IntegrationId { get; set; }



    /// <summary>
    /// Allow end-users to upgrade an anonymous session to authenticated conversation.
    /// </summary>
    /// <value>Allow end-users to upgrade an anonymous session to authenticated conversation.</value>
    [DataMember(Name = "allowSessionUpgrade", EmitDefaultValue = false)]
    public bool? AllowSessionUpgrade { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuthenticationSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  AllowSessionUpgrade: ").Append(AllowSessionUpgrade).Append("\n");
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
        return Equals(obj as AuthenticationSettings);
    }

    /// <summary>
    /// Returns true if AuthenticationSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthenticationSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthenticationSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                AllowSessionUpgrade == other.AllowSessionUpgrade ||
                AllowSessionUpgrade != null &&
                AllowSessionUpgrade.Equals(other.AllowSessionUpgrade)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (AllowSessionUpgrade != null)
            {
                hash = hash * 59 + AllowSessionUpgrade.GetHashCode();
            }

            return hash;
        }
    }
}
