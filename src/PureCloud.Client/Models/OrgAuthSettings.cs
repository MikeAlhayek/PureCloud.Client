namespace PureCloud.Client.Models;

/// <summary>
/// OrgAuthSettings
/// </summary>
public sealed class OrgAuthSettings
{
    /// <summary>
    /// Indicates whether multi-factor authentication is required.
    /// </summary>
    public bool? MultifactorAuthenticationRequired { get; set; }

    /// <summary>
    /// Indicates whether the domain allowlist is enabled.
    /// </summary>
    public bool? DomainAllowlistEnabled { get; set; }

    /// <summary>
    /// The list of domains that will be allowed to embed Genesys Cloud applications.
    /// </summary>
    public List<string> DomainAllowlist { get; set; }

    /// <summary>
    /// The list of IP addresses that will be allowed to authenticate with Genesys Cloud.
    /// </summary>
    public List<string> IpAddressAllowlist { get; set; }

    /// <summary>
    /// The password requirements for the organization.
    /// </summary>
    public PasswordRequirements PasswordRequirements { get; set; }

    /// <summary>
    /// The list of exempt apis from inactivity timeout.
    /// </summary>
    public List<string> InactivityTimeoutExclusions { get; set; }
}
