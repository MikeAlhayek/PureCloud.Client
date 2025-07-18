using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IIdentityProviderApi
{
    Task DeleteIdentityproviderAsync(string providerId, CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersAdfsAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersCicAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersGenericAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersGsuiteAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersIdentitynowAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersOktaAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersOneloginAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersPingAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersPurecloudAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersPureengageAsync(CancellationToken cancellationToken = default);

    Task DeleteIdentityProvidersSalesforceAsync(CancellationToken cancellationToken = default);

    Task<CustomProvider> GetIdentityproviderAsync(string providerId, CancellationToken cancellationToken = default);

    Task<IdentityProviderEntityListing> GetIdentityProvidersAsync(CancellationToken cancellationToken = default);

    Task<ADFS> GetIdentityProvidersAdfsAsync(CancellationToken cancellationToken = default);

    Task<CustomerInteractionCenter> GetIdentityProvidersCicAsync(CancellationToken cancellationToken = default);

    Task<GenericSAML> GetIdentityProvidersGenericAsync(CancellationToken cancellationToken = default);

    Task<GSuite> GetIdentityProvidersGsuiteAsync(CancellationToken cancellationToken = default);

    Task<IdentityNow> GetIdentityProvidersIdentitynowAsync(CancellationToken cancellationToken = default);

    Task<Okta> GetIdentityProvidersOktaAsync(CancellationToken cancellationToken = default);

    Task<OneLogin> GetIdentityProvidersOneloginAsync(CancellationToken cancellationToken = default);

    Task<PingIdentity> GetIdentityProvidersPingAsync(CancellationToken cancellationToken = default);

    Task<PureCloudEnvironment> GetIdentityProvidersPurecloudAsync(CancellationToken cancellationToken = default);

    Task<PureEngage> GetIdentityProvidersPureengageAsync(CancellationToken cancellationToken = default);

    Task<Salesforce> GetIdentityProvidersSalesforceAsync(CancellationToken cancellationToken = default);

    Task<CustomProvider> CreateIdentityProvidersAsync(CustomProvider body, CancellationToken cancellationToken = default);

    Task<CustomProvider> UpdateIdentityproviderAsync(string providerId, CustomProvider body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersAdfsAsync(ADFS body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersCicAsync(CustomerInteractionCenter body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersGenericAsync(GenericSAML body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersGsuiteAsync(GSuite body, CancellationToken cancellationToken = default);

    Task<IdentityNow> UpdateIdentityProvidersIdentitynowAsync(IdentityNow body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersOktaAsync(Okta body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersOneloginAsync(OneLogin body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersPingAsync(PingIdentity body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersPurecloudAsync(PureCloudEnvironment body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersPureengageAsync(PureEngage body, CancellationToken cancellationToken = default);

    Task<IdentityProvider> UpdateIdentityProvidersSalesforceAsync(Salesforce body, CancellationToken cancellationToken = default);
}
