namespace PureCloud.Client.Models.Settings;

public sealed class PureCloudOptions
{
    public string ClientId { get; set; }

    public string ClientSecret { get; set; }

    public PureCloudRegionHosts Region { get; set; }

    public string AuthorizationCode { get; set; }

    public string RedirectUri { get; set; }

    public HashSet<string> Scopes { get; set; }
}
