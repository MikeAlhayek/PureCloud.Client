using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class IdentityProviderApi : IIdentityProviderApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public IdentityProviderApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task DeleteIdentityproviderAsync(string providerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/identityproviders/{providerId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersAdfsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/adfs", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersCicAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/cic", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersGenericAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/generic", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersGsuiteAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/gsuite", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersIdentitynowAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/identitynow", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersOktaAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/okta", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersOneloginAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/onelogin", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersPingAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/ping", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersPurecloudAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/purecloud", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersPureengageAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/pureengage", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteIdentityProvidersSalesforceAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/identityproviders/salesforce", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<CustomProvider> GetIdentityproviderAsync(string providerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/identityproviders/{providerId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CustomProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProviderEntityListing> GetIdentityProvidersAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProviderEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ADFS> GetIdentityProvidersAdfsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/adfs", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ADFS>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CustomerInteractionCenter> GetIdentityProvidersCicAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/cic", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CustomerInteractionCenter>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GenericSAML> GetIdentityProvidersGenericAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/generic", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GenericSAML>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GSuite> GetIdentityProvidersGsuiteAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/gsuite", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GSuite>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityNow> GetIdentityProvidersIdentitynowAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/identitynow", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityNow>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Okta> GetIdentityProvidersOktaAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/okta", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Okta>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OneLogin> GetIdentityProvidersOneloginAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/onelogin", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OneLogin>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PingIdentity> GetIdentityProvidersPingAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/ping", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PingIdentity>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PureCloudEnvironment> GetIdentityProvidersPurecloudAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/purecloud", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PureCloudEnvironment>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PureEngage> GetIdentityProvidersPureengageAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/pureengage", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PureEngage>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Salesforce> GetIdentityProvidersSalesforceAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/identityproviders/salesforce", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Salesforce>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CustomProvider> CreateIdentityProvidersAsync(CustomProvider body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/identityproviders", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CustomProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CustomProvider> UpdateIdentityproviderAsync(string providerId, CustomProvider body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/identityproviders/{providerId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CustomProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersAdfsAsync(ADFS body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/adfs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersCicAsync(CustomerInteractionCenter body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/cic", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersGenericAsync(GenericSAML body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/generic", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersGsuiteAsync(GSuite body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/gsuite", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityNow> UpdateIdentityProvidersIdentitynowAsync(IdentityNow body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/identitynow", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityNow>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersOktaAsync(Okta body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/okta", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersOneloginAsync(OneLogin body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/onelogin", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersPingAsync(PingIdentity body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/ping", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersPurecloudAsync(PureCloudEnvironment body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/purecloud", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersPureengageAsync(PureEngage body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/pureengage", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IdentityProvider> UpdateIdentityProvidersSalesforceAsync(Salesforce body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/identityproviders/salesforce", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityProvider>(_options.JsonSerializerOptions, cancellationToken);
    }

}
