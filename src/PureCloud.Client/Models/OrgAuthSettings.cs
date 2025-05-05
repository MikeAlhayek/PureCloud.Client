using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OrgAuthSettings
/// </summary>

public partial class OrgAuthSettings : IEquatable<OrgAuthSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrgAuthSettings" /> class.
    /// </summary>
    /// <param name="MultifactorAuthenticationRequired">Indicates whether multi-factor authentication is required..</param>
    /// <param name="DomainAllowlistEnabled">Indicates whether the domain allowlist is enabled..</param>
    /// <param name="DomainAllowlist">The list of domains that will be allowed to embed Genesys Cloud applications..</param>
    /// <param name="IpAddressAllowlist">The list of IP addresses that will be allowed to authenticate with Genesys Cloud..</param>
    /// <param name="PasswordRequirements">The password requirements for the organization..</param>
    /// <param name="InactivityTimeoutExclusions">The list of exempt apis from inactivity timeout..</param>
    public OrgAuthSettings(bool? MultifactorAuthenticationRequired = null, bool? DomainAllowlistEnabled = null, List<string> DomainAllowlist = null, List<string> IpAddressAllowlist = null, PasswordRequirements PasswordRequirements = null, List<string> InactivityTimeoutExclusions = null)
    {
        this.MultifactorAuthenticationRequired = MultifactorAuthenticationRequired;
        this.DomainAllowlistEnabled = DomainAllowlistEnabled;
        this.DomainAllowlist = DomainAllowlist;
        this.IpAddressAllowlist = IpAddressAllowlist;
        this.PasswordRequirements = PasswordRequirements;
        this.InactivityTimeoutExclusions = InactivityTimeoutExclusions;

    }



    /// <summary>
    /// Indicates whether multi-factor authentication is required.
    /// </summary>
    /// <value>Indicates whether multi-factor authentication is required.</value>
    [JsonPropertyName("multifactorAuthenticationRequired")]
    public bool? MultifactorAuthenticationRequired { get; set; }



    /// <summary>
    /// Indicates whether the domain allowlist is enabled.
    /// </summary>
    /// <value>Indicates whether the domain allowlist is enabled.</value>
    [JsonPropertyName("domainAllowlistEnabled")]
    public bool? DomainAllowlistEnabled { get; set; }



    /// <summary>
    /// The list of domains that will be allowed to embed Genesys Cloud applications.
    /// </summary>
    /// <value>The list of domains that will be allowed to embed Genesys Cloud applications.</value>
    [JsonPropertyName("domainAllowlist")]
    public List<string> DomainAllowlist { get; set; }



    /// <summary>
    /// The list of IP addresses that will be allowed to authenticate with Genesys Cloud.
    /// </summary>
    /// <value>The list of IP addresses that will be allowed to authenticate with Genesys Cloud.</value>
    [JsonPropertyName("ipAddressAllowlist")]
    public List<string> IpAddressAllowlist { get; set; }



    /// <summary>
    /// The password requirements for the organization.
    /// </summary>
    /// <value>The password requirements for the organization.</value>
    [JsonPropertyName("passwordRequirements")]
    public PasswordRequirements PasswordRequirements { get; set; }



    /// <summary>
    /// The list of exempt apis from inactivity timeout.
    /// </summary>
    /// <value>The list of exempt apis from inactivity timeout.</value>
    [JsonPropertyName("inactivityTimeoutExclusions")]
    public List<string> InactivityTimeoutExclusions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OrgAuthSettings {\n");

        sb.Append("  MultifactorAuthenticationRequired: ").Append(MultifactorAuthenticationRequired).Append("\n");
        sb.Append("  DomainAllowlistEnabled: ").Append(DomainAllowlistEnabled).Append("\n");
        sb.Append("  DomainAllowlist: ").Append(DomainAllowlist).Append("\n");
        sb.Append("  IpAddressAllowlist: ").Append(IpAddressAllowlist).Append("\n");
        sb.Append("  PasswordRequirements: ").Append(PasswordRequirements).Append("\n");
        sb.Append("  InactivityTimeoutExclusions: ").Append(InactivityTimeoutExclusions).Append("\n");
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
        return Equals(obj as OrgAuthSettings);
    }

    /// <summary>
    /// Returns true if OrgAuthSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of OrgAuthSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrgAuthSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MultifactorAuthenticationRequired == other.MultifactorAuthenticationRequired ||
                MultifactorAuthenticationRequired != null &&
                MultifactorAuthenticationRequired.Equals(other.MultifactorAuthenticationRequired)
            ) &&
            (
                DomainAllowlistEnabled == other.DomainAllowlistEnabled ||
                DomainAllowlistEnabled != null &&
                DomainAllowlistEnabled.Equals(other.DomainAllowlistEnabled)
            ) &&
            (
                DomainAllowlist == other.DomainAllowlist ||
                DomainAllowlist != null &&
                DomainAllowlist.SequenceEqual(other.DomainAllowlist)
            ) &&
            (
                IpAddressAllowlist == other.IpAddressAllowlist ||
                IpAddressAllowlist != null &&
                IpAddressAllowlist.SequenceEqual(other.IpAddressAllowlist)
            ) &&
            (
                PasswordRequirements == other.PasswordRequirements ||
                PasswordRequirements != null &&
                PasswordRequirements.Equals(other.PasswordRequirements)
            ) &&
            (
                InactivityTimeoutExclusions == other.InactivityTimeoutExclusions ||
                InactivityTimeoutExclusions != null &&
                InactivityTimeoutExclusions.SequenceEqual(other.InactivityTimeoutExclusions)
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
            if (MultifactorAuthenticationRequired != null)
            {
                hash = hash * 59 + MultifactorAuthenticationRequired.GetHashCode();
            }

            if (DomainAllowlistEnabled != null)
            {
                hash = hash * 59 + DomainAllowlistEnabled.GetHashCode();
            }

            if (DomainAllowlist != null)
            {
                hash = hash * 59 + DomainAllowlist.GetHashCode();
            }

            if (IpAddressAllowlist != null)
            {
                hash = hash * 59 + IpAddressAllowlist.GetHashCode();
            }

            if (PasswordRequirements != null)
            {
                hash = hash * 59 + PasswordRequirements.GetHashCode();
            }

            if (InactivityTimeoutExclusions != null)
            {
                hash = hash * 59 + InactivityTimeoutExclusions.GetHashCode();
            }

            return hash;
        }
    }
}
