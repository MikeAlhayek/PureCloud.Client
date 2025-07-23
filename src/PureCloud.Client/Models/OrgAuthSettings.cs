namespace PureCloud.Client.Models;

public sealed class OrgAuthSettings
{
    public bool? MultifactorAuthenticationRequired { get; set; }
    public bool? DomainAllowlistEnabled { get; set; }
    public IEnumerable<string> DomainAllowlist { get; set; }
    public IEnumerable<string> IpAddressAllowlist { get; set; }
    public PasswordRequirements PasswordRequirements { get; set; }
    public IEnumerable<string> InactivityTimeoutExclusions { get; set; }
}
