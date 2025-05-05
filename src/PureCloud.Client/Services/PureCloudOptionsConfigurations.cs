using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PureCloud.Client.Models.Settings;

namespace PureCloud.Client.Services;

public sealed class PureCloudOptionsConfigurations : IConfigureOptions<PureCloudOptions>
{
    private readonly IConfiguration _configuration;

    public PureCloudOptionsConfigurations(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(PureCloudOptions options)
    {
        var values = _configuration.GetSection("PureClient")?.Get<PureCloudOptions>();

        if (values is null)
        {
            return;
        }

        options.ClientId = values.ClientId;
        options.ClientSecret = values.ClientSecret;
        options.Region = values.Region;
        options.Scopes = values.Scopes;
        options.RedirectUri = values.RedirectUri;
        options.AuthorizationCode = values.AuthorizationCode;
    }
}
