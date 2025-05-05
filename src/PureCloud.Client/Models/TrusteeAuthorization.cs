namespace PureCloud.Client.Models;

public sealed class TrusteeAuthorization
{
    /// <summary>
    /// Permissions that the trustee user has in the trustor organization
    /// </summary>
    /// <value>Permissions that the trustee user has in the trustor organization</value>
    public List<string> Permissions { get; set; }
}
