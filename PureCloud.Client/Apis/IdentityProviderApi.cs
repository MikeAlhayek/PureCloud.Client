using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IIdentityProviderApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns></returns>

    void DeleteIdentityprovider(string providerId);

    /// <summary>
    /// Delete Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<Object> DeleteIdentityproviderWithHttpInfo(string providerId);

    /// <summary>
    /// Delete ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersAdfs();

    /// <summary>
    /// Delete ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersAdfsWithHttpInfo();

    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersCic();

    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersCicWithHttpInfo();

    /// <summary>
    /// Delete Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersGeneric();

    /// <summary>
    /// Delete Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersGenericWithHttpInfo();

    /// <summary>
    /// Delete G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersGsuite();

    /// <summary>
    /// Delete G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersGsuiteWithHttpInfo();

    /// <summary>
    /// Delete IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersIdentitynow();

    /// <summary>
    /// Delete IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersIdentitynowWithHttpInfo();

    /// <summary>
    /// Delete Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersOkta();

    /// <summary>
    /// Delete Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersOktaWithHttpInfo();

    /// <summary>
    /// Delete OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersOnelogin();

    /// <summary>
    /// Delete OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersOneloginWithHttpInfo();

    /// <summary>
    /// Delete Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersPing();

    /// <summary>
    /// Delete Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersPingWithHttpInfo();

    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersPurecloud();

    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersPurecloudWithHttpInfo();

    /// <summary>
    /// Delete PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersPureengage();

    /// <summary>
    /// Delete PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersPureengageWithHttpInfo();

    /// <summary>
    /// Delete Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    Object DeleteIdentityProvidersSalesforce();

    /// <summary>
    /// Delete Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<Object> DeleteIdentityProvidersSalesforceWithHttpInfo();

    /// <summary>
    /// Get Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>CustomProvider</returns>

    CustomProvider GetIdentityprovider(string providerId);

    /// <summary>
    /// Get Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>ApiResponse of CustomProvider</returns>

    ApiResponse<CustomProvider> GetIdentityproviderWithHttpInfo(string providerId);

    /// <summary>
    /// The list of identity providers
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>IdentityProviderEntityListing</returns>

    IdentityProviderEntityListing GetIdentityProviders();

    /// <summary>
    /// The list of identity providers
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of IdentityProviderEntityListing</returns>

    ApiResponse<IdentityProviderEntityListing> GetIdentityProvidersWithHttpInfo();

    /// <summary>
    /// Get ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ADFS</returns>

    ADFS GetIdentityProvidersAdfs();

    /// <summary>
    /// Get ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ADFS</returns>

    ApiResponse<ADFS> GetIdentityProvidersAdfsWithHttpInfo();

    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>CustomerInteractionCenter</returns>

    CustomerInteractionCenter GetIdentityProvidersCic();

    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of CustomerInteractionCenter</returns>

    ApiResponse<CustomerInteractionCenter> GetIdentityProvidersCicWithHttpInfo();

    /// <summary>
    /// Get Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>GenericSAML</returns>

    GenericSAML GetIdentityProvidersGeneric();

    /// <summary>
    /// Get Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of GenericSAML</returns>

    ApiResponse<GenericSAML> GetIdentityProvidersGenericWithHttpInfo();

    /// <summary>
    /// Get G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>GSuite</returns>

    GSuite GetIdentityProvidersGsuite();

    /// <summary>
    /// Get G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of GSuite</returns>

    ApiResponse<GSuite> GetIdentityProvidersGsuiteWithHttpInfo();

    /// <summary>
    /// Get IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>IdentityNow</returns>

    IdentityNow GetIdentityProvidersIdentitynow();

    /// <summary>
    /// Get IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of IdentityNow</returns>

    ApiResponse<IdentityNow> GetIdentityProvidersIdentitynowWithHttpInfo();

    /// <summary>
    /// Get Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Okta</returns>

    Okta GetIdentityProvidersOkta();

    /// <summary>
    /// Get Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Okta</returns>

    ApiResponse<Okta> GetIdentityProvidersOktaWithHttpInfo();

    /// <summary>
    /// Get OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>OneLogin</returns>

    OneLogin GetIdentityProvidersOnelogin();

    /// <summary>
    /// Get OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of OneLogin</returns>

    ApiResponse<OneLogin> GetIdentityProvidersOneloginWithHttpInfo();

    /// <summary>
    /// Get Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>PingIdentity</returns>

    PingIdentity GetIdentityProvidersPing();

    /// <summary>
    /// Get Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of PingIdentity</returns>

    ApiResponse<PingIdentity> GetIdentityProvidersPingWithHttpInfo();

    /// <summary>
    /// Get PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>PureCloudEnvironment</returns>

    PureCloudEnvironment GetIdentityProvidersPurecloud();

    /// <summary>
    /// Get PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.PureCloud</returns>

    ApiResponse<PureCloudEnvironment> GetIdentityProvidersPurecloudWithHttpInfo();

    /// <summary>
    /// Get PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>PureEngage</returns>

    PureEngage GetIdentityProvidersPureengage();

    /// <summary>
    /// Get PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of PureEngage</returns>

    ApiResponse<PureEngage> GetIdentityProvidersPureengageWithHttpInfo();

    /// <summary>
    /// Get Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Salesforce</returns>

    Salesforce GetIdentityProvidersSalesforce();

    /// <summary>
    /// Get Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Salesforce</returns>

    ApiResponse<Salesforce> GetIdentityProvidersSalesforceWithHttpInfo();

    /// <summary>
    /// Create Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>CustomProvider</returns>

    CustomProvider PostIdentityProviders(CustomProvider body);

    /// <summary>
    /// Create Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of CustomProvider</returns>

    ApiResponse<CustomProvider> PostIdentityProvidersWithHttpInfo(CustomProvider body);

    /// <summary>
    /// Update Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>CustomProvider</returns>

    CustomProvider PutIdentityprovider(string providerId, CustomProvider body);

    /// <summary>
    /// Update Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of CustomProvider</returns>

    ApiResponse<CustomProvider> PutIdentityproviderWithHttpInfo(string providerId, CustomProvider body);

    /// <summary>
    /// Update/Create ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersAdfs(ADFS body);

    /// <summary>
    /// Update/Create ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersAdfsWithHttpInfo(ADFS body);

    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersCic(CustomerInteractionCenter body);

    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersCicWithHttpInfo(CustomerInteractionCenter body);

    /// <summary>
    /// Update/Create Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersGeneric(GenericSAML body);

    /// <summary>
    /// Update/Create Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersGenericWithHttpInfo(GenericSAML body);

    /// <summary>
    /// Update/Create G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersGsuite(GSuite body);

    /// <summary>
    /// Update/Create G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersGsuiteWithHttpInfo(GSuite body);

    /// <summary>
    /// Update/Create IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityNow</returns>

    IdentityNow PutIdentityProvidersIdentitynow(IdentityNow body);

    /// <summary>
    /// Update/Create IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityNow</returns>

    ApiResponse<IdentityNow> PutIdentityProvidersIdentitynowWithHttpInfo(IdentityNow body);

    /// <summary>
    /// Update/Create Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersOkta(Okta body);

    /// <summary>
    /// Update/Create Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersOktaWithHttpInfo(Okta body);

    /// <summary>
    /// Update/Create OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersOnelogin(OneLogin body);

    /// <summary>
    /// Update/Create OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersOneloginWithHttpInfo(OneLogin body);

    /// <summary>
    /// Update/Create Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersPing(PingIdentity body);

    /// <summary>
    /// Update/Create Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersPingWithHttpInfo(PingIdentity body);

    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersPurecloud(PureCloudEnvironment body);

    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersPurecloudWithHttpInfo(PureCloudEnvironment body);

    /// <summary>
    /// Update/Create PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersPureengage(PureEngage body);

    /// <summary>
    /// Update/Create PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersPureengageWithHttpInfo(PureEngage body);

    /// <summary>
    /// Update/Create Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    IdentityProvider PutIdentityProvidersSalesforce(Salesforce body);

    /// <summary>
    /// Update/Create Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    ApiResponse<IdentityProvider> PutIdentityProvidersSalesforceWithHttpInfo(Salesforce body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of void</returns>

    Task DeleteIdentityproviderAsync(string providerId);

    /// <summary>
    /// Delete Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<Object>> DeleteIdentityproviderAsyncWithHttpInfo(string providerId);

    /// <summary>
    /// Delete ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersAdfsAsync();

    /// <summary>
    /// Delete ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersAdfsAsyncWithHttpInfo();

    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersCicAsync();

    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersCicAsyncWithHttpInfo();

    /// <summary>
    /// Delete Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersGenericAsync();

    /// <summary>
    /// Delete Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersGenericAsyncWithHttpInfo();

    /// <summary>
    /// Delete G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersGsuiteAsync();

    /// <summary>
    /// Delete G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersGsuiteAsyncWithHttpInfo();

    /// <summary>
    /// Delete IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersIdentitynowAsync();

    /// <summary>
    /// Delete IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersIdentitynowAsyncWithHttpInfo();

    /// <summary>
    /// Delete Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersOktaAsync();

    /// <summary>
    /// Delete Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersOktaAsyncWithHttpInfo();

    /// <summary>
    /// Delete OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersOneloginAsync();

    /// <summary>
    /// Delete OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersOneloginAsyncWithHttpInfo();

    /// <summary>
    /// Delete Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersPingAsync();

    /// <summary>
    /// Delete Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersPingAsyncWithHttpInfo();

    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersPurecloudAsync();

    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersPurecloudAsyncWithHttpInfo();

    /// <summary>
    /// Delete PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersPureengageAsync();

    /// <summary>
    /// Delete PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersPureengageAsyncWithHttpInfo();

    /// <summary>
    /// Delete Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<Object> DeleteIdentityProvidersSalesforceAsync();

    /// <summary>
    /// Delete Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<Object>> DeleteIdentityProvidersSalesforceAsyncWithHttpInfo();

    /// <summary>
    /// Get Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of CustomProvider</returns>

    Task<CustomProvider> GetIdentityproviderAsync(string providerId);

    /// <summary>
    /// Get Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of ApiResponse (CustomProvider)</returns>

    Task<ApiResponse<CustomProvider>> GetIdentityproviderAsyncWithHttpInfo(string providerId);

    /// <summary>
    /// The list of identity providers
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of IdentityProviderEntityListing</returns>

    Task<IdentityProviderEntityListing> GetIdentityProvidersAsync();

    /// <summary>
    /// The list of identity providers
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (IdentityProviderEntityListing)</returns>

    Task<ApiResponse<IdentityProviderEntityListing>> GetIdentityProvidersAsyncWithHttpInfo();

    /// <summary>
    /// Get ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ADFS</returns>

    Task<ADFS> GetIdentityProvidersAdfsAsync();

    /// <summary>
    /// Get ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (ADFS)</returns>

    Task<ApiResponse<ADFS>> GetIdentityProvidersAdfsAsyncWithHttpInfo();

    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of CustomerInteractionCenter</returns>

    Task<CustomerInteractionCenter> GetIdentityProvidersCicAsync();

    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (CustomerInteractionCenter)</returns>

    Task<ApiResponse<CustomerInteractionCenter>> GetIdentityProvidersCicAsyncWithHttpInfo();

    /// <summary>
    /// Get Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of GenericSAML</returns>

    Task<GenericSAML> GetIdentityProvidersGenericAsync();

    /// <summary>
    /// Get Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (GenericSAML)</returns>

    Task<ApiResponse<GenericSAML>> GetIdentityProvidersGenericAsyncWithHttpInfo();

    /// <summary>
    /// Get G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of GSuite</returns>

    Task<GSuite> GetIdentityProvidersGsuiteAsync();

    /// <summary>
    /// Get G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (GSuite)</returns>

    Task<ApiResponse<GSuite>> GetIdentityProvidersGsuiteAsyncWithHttpInfo();

    /// <summary>
    /// Get IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of IdentityNow</returns>

    Task<IdentityNow> GetIdentityProvidersIdentitynowAsync();

    /// <summary>
    /// Get IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (IdentityNow)</returns>

    Task<ApiResponse<IdentityNow>> GetIdentityProvidersIdentitynowAsyncWithHttpInfo();

    /// <summary>
    /// Get Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Okta</returns>

    Task<Okta> GetIdentityProvidersOktaAsync();

    /// <summary>
    /// Get Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Okta)</returns>

    Task<ApiResponse<Okta>> GetIdentityProvidersOktaAsyncWithHttpInfo();

    /// <summary>
    /// Get OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of OneLogin</returns>

    Task<OneLogin> GetIdentityProvidersOneloginAsync();

    /// <summary>
    /// Get OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (OneLogin)</returns>

    Task<ApiResponse<OneLogin>> GetIdentityProvidersOneloginAsyncWithHttpInfo();

    /// <summary>
    /// Get Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of PingIdentity</returns>

    Task<PingIdentity> GetIdentityProvidersPingAsync();

    /// <summary>
    /// Get Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (PingIdentity)</returns>

    Task<ApiResponse<PingIdentity>> GetIdentityProvidersPingAsyncWithHttpInfo();

    /// <summary>
    /// Get PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of PureCloudPlatform.Client.V2.Model.PureCloud</returns>

    Task<PureCloudEnvironment> GetIdentityProvidersPurecloudAsync();

    /// <summary>
    /// Get PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.PureCloud)</returns>

    Task<ApiResponse<PureCloudEnvironment>> GetIdentityProvidersPurecloudAsyncWithHttpInfo();

    /// <summary>
    /// Get PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of PureEngage</returns>

    Task<PureEngage> GetIdentityProvidersPureengageAsync();

    /// <summary>
    /// Get PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (PureEngage)</returns>

    Task<ApiResponse<PureEngage>> GetIdentityProvidersPureengageAsyncWithHttpInfo();

    /// <summary>
    /// Get Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Salesforce</returns>

    Task<Salesforce> GetIdentityProvidersSalesforceAsync();

    /// <summary>
    /// Get Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Salesforce)</returns>

    Task<ApiResponse<Salesforce>> GetIdentityProvidersSalesforceAsyncWithHttpInfo();

    /// <summary>
    /// Create Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of CustomProvider</returns>

    Task<CustomProvider> PostIdentityProvidersAsync(CustomProvider body);

    /// <summary>
    /// Create Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (CustomProvider)</returns>

    Task<ApiResponse<CustomProvider>> PostIdentityProvidersAsyncWithHttpInfo(CustomProvider body);

    /// <summary>
    /// Update Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>Task of CustomProvider</returns>

    Task<CustomProvider> PutIdentityproviderAsync(string providerId, CustomProvider body);

    /// <summary>
    /// Update Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (CustomProvider)</returns>

    Task<ApiResponse<CustomProvider>> PutIdentityproviderAsyncWithHttpInfo(string providerId, CustomProvider body);

    /// <summary>
    /// Update/Create ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersAdfsAsync(ADFS body);

    /// <summary>
    /// Update/Create ADFS Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersAdfsAsyncWithHttpInfo(ADFS body);

    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersCicAsync(CustomerInteractionCenter body);

    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersCicAsyncWithHttpInfo(CustomerInteractionCenter body);

    /// <summary>
    /// Update/Create Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersGenericAsync(GenericSAML body);

    /// <summary>
    /// Update/Create Generic SAML Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersGenericAsyncWithHttpInfo(GenericSAML body);

    /// <summary>
    /// Update/Create G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersGsuiteAsync(GSuite body);

    /// <summary>
    /// Update/Create G Suite Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersGsuiteAsyncWithHttpInfo(GSuite body);

    /// <summary>
    /// Update/Create IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityNow</returns>

    Task<IdentityNow> PutIdentityProvidersIdentitynowAsync(IdentityNow body);

    /// <summary>
    /// Update/Create IdentityNow Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityNow)</returns>

    Task<ApiResponse<IdentityNow>> PutIdentityProvidersIdentitynowAsyncWithHttpInfo(IdentityNow body);

    /// <summary>
    /// Update/Create Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersOktaAsync(Okta body);

    /// <summary>
    /// Update/Create Okta Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersOktaAsyncWithHttpInfo(Okta body);

    /// <summary>
    /// Update/Create OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersOneloginAsync(OneLogin body);

    /// <summary>
    /// Update/Create OneLogin Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersOneloginAsyncWithHttpInfo(OneLogin body);

    /// <summary>
    /// Update/Create Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersPingAsync(PingIdentity body);

    /// <summary>
    /// Update/Create Ping Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersPingAsyncWithHttpInfo(PingIdentity body);

    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersPurecloudAsync(PureCloudEnvironment body);

    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersPurecloudAsyncWithHttpInfo(PureCloudEnvironment body);

    /// <summary>
    /// Update/Create PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersPureengageAsync(PureEngage body);

    /// <summary>
    /// Update/Create PureEngage Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersPureengageAsyncWithHttpInfo(PureEngage body);

    /// <summary>
    /// Update/Create Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    Task<IdentityProvider> PutIdentityProvidersSalesforceAsync(Salesforce body);

    /// <summary>
    /// Update/Create Salesforce Identity Provider
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    Task<ApiResponse<IdentityProvider>> PutIdentityProvidersSalesforceAsyncWithHttpInfo(Salesforce body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class IdentityProviderApi : IIdentityProviderApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class.
    /// </summary>
    /// <returns></returns>
    public IdentityProviderApi(String basePath)
    {
        this.Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (this.Configuration.ApiClient.Configuration == null)
        {
            this.Configuration.ApiClient.Configuration = this.Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public IdentityProviderApi(Configuration configuration = null)
    {
        if (configuration == null) // use the default one in Configuration
        {
            this.Configuration = Configuration.Default;
        }
        else
        {
            this.Configuration = configuration;
        }

        // ensure API client has configuration ready
        if (this.Configuration.ApiClient.Configuration == null)
        {
            this.Configuration.ApiClient.Configuration = this.Configuration;
        }
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath()
    {
        return this.Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
    public void SetBasePath(String basePath)
    {
        // do nothing
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public Configuration Configuration { get; set; }

    /// <summary>
    /// Gets the default header.
    /// </summary>
    /// <returns>Dictionary of HTTP header</returns>
    [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
    public Dictionary<String, String> DefaultHeader()
    {
        return this.Configuration.DefaultHeader;
    }

    /// <summary>
    /// Add default header.
    /// </summary>
    /// <param name="key">Header field name.</param>
    /// <param name="value">Header field value.</param>
    /// <returns></returns>
    [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
    public void AddDefaultHeader(string key, string value)
    {
        this.Configuration.AddDefaultHeader(key, value);
    }


    /// <summary>
    /// Delete Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns></returns>

    public void DeleteIdentityprovider(string providerId)
    {
        DeleteIdentityproviderWithHttpInfo(providerId);
    }

    /// <summary>
    /// Delete Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<Object> DeleteIdentityproviderWithHttpInfo(string providerId)
    {
        // verify the required parameter 'providerId' is set
        if (providerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'providerId' when calling IdentityProviderApi->DeleteIdentityprovider");
        }

        var localVarPath = "/api/v2/IdentityProviders/{providerId}";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (providerId != null)
        {
            localVarPathParams.Add("providerId", this.Configuration.ApiClient.ParameterToString(providerId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityprovider: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityprovider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteIdentityproviderAsync(string providerId)
    {
        await DeleteIdentityproviderAsyncWithHttpInfo(providerId);

    }

    /// <summary>
    /// Delete Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityproviderAsyncWithHttpInfo(string providerId)
    {
        // verify the required parameter 'providerId' is set
        if (providerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'providerId' when calling IdentityProviderApi->DeleteIdentityprovider");
        }

        var localVarPath = "/api/v2/IdentityProviders/{providerId}";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (providerId != null)
        {
            localVarPathParams.Add("providerId", this.Configuration.ApiClient.ParameterToString(providerId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityprovider: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityprovider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersAdfs()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersAdfsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersAdfsWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/adfs";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersAdfs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersAdfs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersAdfsAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersAdfsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersAdfsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/adfs";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersAdfs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersAdfs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersCic()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersCicWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersCicWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/cic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersCic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersCic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersCicAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersCicAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersCicAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/cic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersCic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersCic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersGeneric()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersGenericWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersGenericWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/generic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGeneric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGeneric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersGenericAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersGenericAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersGenericAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/generic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGeneric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGeneric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersGsuite()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersGsuiteWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersGsuiteWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/gsuite";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGsuite: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGsuite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersGsuiteAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersGsuiteAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersGsuiteAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/gsuite";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGsuite: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersGsuite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersIdentitynow()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersIdentitynowWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersIdentitynowWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/identitynow";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersIdentitynow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersIdentitynow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersIdentitynowAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersIdentitynowAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersIdentitynowAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/identitynow";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersIdentitynow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersIdentitynow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersOkta()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersOktaWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersOktaWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/okta";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOkta: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOkta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersOktaAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersOktaAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersOktaAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/okta";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOkta: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOkta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersOnelogin()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersOneloginWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersOneloginWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/onelogin";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOnelogin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOnelogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersOneloginAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersOneloginAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersOneloginAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/onelogin";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOnelogin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersOnelogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersPing()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersPingWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersPingWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/ping";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersPingAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersPingAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersPingAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/ping";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersPurecloud()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersPurecloudWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersPurecloudWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/purecloud";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersPurecloudAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersPurecloudAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersPurecloudAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/purecloud";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersPureengage()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersPureengageWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersPureengageWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/pureengage";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPureengage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPureengage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersPureengageAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersPureengageAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersPureengageAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/pureengage";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPureengage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersPureengage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public Object DeleteIdentityProvidersSalesforce()
    {
        ApiResponse<Object> localVarResponse = DeleteIdentityProvidersSalesforceWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<Object> DeleteIdentityProvidersSalesforceWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/salesforce";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersSalesforce: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersSalesforce: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<Object> DeleteIdentityProvidersSalesforceAsync()
    {
        ApiResponse<Object> localVarResponse = await DeleteIdentityProvidersSalesforceAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<Object>> DeleteIdentityProvidersSalesforceAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/salesforce";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersSalesforce: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteIdentityProvidersSalesforce: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Object>(localVarStatusCode,
            localVarHeaders,
            (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>CustomProvider</returns>

    public CustomProvider GetIdentityprovider(string providerId)
    {
        ApiResponse<CustomProvider> localVarResponse = GetIdentityproviderWithHttpInfo(providerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>ApiResponse of CustomProvider</returns>

    public ApiResponse<CustomProvider> GetIdentityproviderWithHttpInfo(string providerId)
    {
        // verify the required parameter 'providerId' is set
        if (providerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'providerId' when calling IdentityProviderApi->GetIdentityprovider");
        }

        var localVarPath = "/api/v2/IdentityProviders/{providerId}";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (providerId != null)
        {
            localVarPathParams.Add("providerId", this.Configuration.ApiClient.ParameterToString(providerId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityprovider: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityprovider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomProvider>(localVarStatusCode,
            localVarHeaders,
            (CustomProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of CustomProvider</returns>

    public async Task<CustomProvider> GetIdentityproviderAsync(string providerId)
    {
        ApiResponse<CustomProvider> localVarResponse = await GetIdentityproviderAsyncWithHttpInfo(providerId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <returns>Task of ApiResponse (CustomProvider)</returns>

    public async Task<ApiResponse<CustomProvider>> GetIdentityproviderAsyncWithHttpInfo(string providerId)
    {
        // verify the required parameter 'providerId' is set
        if (providerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'providerId' when calling IdentityProviderApi->GetIdentityprovider");
        }

        var localVarPath = "/api/v2/IdentityProviders/{providerId}";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (providerId != null)
        {
            localVarPathParams.Add("providerId", this.Configuration.ApiClient.ParameterToString(providerId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityprovider: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityprovider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomProvider>(localVarStatusCode,
            localVarHeaders,
            (CustomProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of identity providers 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>IdentityProviderEntityListing</returns>

    public IdentityProviderEntityListing GetIdentityProviders()
    {
        ApiResponse<IdentityProviderEntityListing> localVarResponse = GetIdentityProvidersWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of identity providers 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of IdentityProviderEntityListing</returns>

    public ApiResponse<IdentityProviderEntityListing> GetIdentityProvidersWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProviders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProviders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProviderEntityListing>(localVarStatusCode,
            localVarHeaders,
            (IdentityProviderEntityListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProviderEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of identity providers 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of IdentityProviderEntityListing</returns>

    public async Task<IdentityProviderEntityListing> GetIdentityProvidersAsync()
    {
        ApiResponse<IdentityProviderEntityListing> localVarResponse = await GetIdentityProvidersAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of identity providers 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (IdentityProviderEntityListing)</returns>

    public async Task<ApiResponse<IdentityProviderEntityListing>> GetIdentityProvidersAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProviders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProviders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProviderEntityListing>(localVarStatusCode,
            localVarHeaders,
            (IdentityProviderEntityListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProviderEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ADFS</returns>

    public ADFS GetIdentityProvidersAdfs()
    {
        ApiResponse<ADFS> localVarResponse = GetIdentityProvidersAdfsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ADFS</returns>

    public ApiResponse<ADFS> GetIdentityProvidersAdfsWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/adfs";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersAdfs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersAdfs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ADFS>(localVarStatusCode,
            localVarHeaders,
            (ADFS)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ADFS)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ADFS</returns>

    public async Task<ADFS> GetIdentityProvidersAdfsAsync()
    {
        ApiResponse<ADFS> localVarResponse = await GetIdentityProvidersAdfsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (ADFS)</returns>

    public async Task<ApiResponse<ADFS>> GetIdentityProvidersAdfsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/adfs";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersAdfs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersAdfs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ADFS>(localVarStatusCode,
            localVarHeaders,
            (ADFS)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ADFS)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>CustomerInteractionCenter</returns>

    public CustomerInteractionCenter GetIdentityProvidersCic()
    {
        ApiResponse<CustomerInteractionCenter> localVarResponse = GetIdentityProvidersCicWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of CustomerInteractionCenter</returns>

    public ApiResponse<CustomerInteractionCenter> GetIdentityProvidersCicWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/cic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersCic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersCic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomerInteractionCenter>(localVarStatusCode,
            localVarHeaders,
            (CustomerInteractionCenter)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInteractionCenter)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of CustomerInteractionCenter</returns>

    public async Task<CustomerInteractionCenter> GetIdentityProvidersCicAsync()
    {
        ApiResponse<CustomerInteractionCenter> localVarResponse = await GetIdentityProvidersCicAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (CustomerInteractionCenter)</returns>

    public async Task<ApiResponse<CustomerInteractionCenter>> GetIdentityProvidersCicAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/cic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersCic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersCic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomerInteractionCenter>(localVarStatusCode,
            localVarHeaders,
            (CustomerInteractionCenter)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInteractionCenter)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>GenericSAML</returns>

    public GenericSAML GetIdentityProvidersGeneric()
    {
        ApiResponse<GenericSAML> localVarResponse = GetIdentityProvidersGenericWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of GenericSAML</returns>

    public ApiResponse<GenericSAML> GetIdentityProvidersGenericWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/generic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGeneric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGeneric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GenericSAML>(localVarStatusCode,
            localVarHeaders,
            (GenericSAML)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenericSAML)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of GenericSAML</returns>

    public async Task<GenericSAML> GetIdentityProvidersGenericAsync()
    {
        ApiResponse<GenericSAML> localVarResponse = await GetIdentityProvidersGenericAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (GenericSAML)</returns>

    public async Task<ApiResponse<GenericSAML>> GetIdentityProvidersGenericAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/generic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGeneric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGeneric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GenericSAML>(localVarStatusCode,
            localVarHeaders,
            (GenericSAML)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenericSAML)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>GSuite</returns>

    public GSuite GetIdentityProvidersGsuite()
    {
        ApiResponse<GSuite> localVarResponse = GetIdentityProvidersGsuiteWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of GSuite</returns>

    public ApiResponse<GSuite> GetIdentityProvidersGsuiteWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/gsuite";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGsuite: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGsuite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GSuite>(localVarStatusCode,
            localVarHeaders,
            (GSuite)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GSuite)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of GSuite</returns>

    public async Task<GSuite> GetIdentityProvidersGsuiteAsync()
    {
        ApiResponse<GSuite> localVarResponse = await GetIdentityProvidersGsuiteAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (GSuite)</returns>

    public async Task<ApiResponse<GSuite>> GetIdentityProvidersGsuiteAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/gsuite";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGsuite: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersGsuite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GSuite>(localVarStatusCode,
            localVarHeaders,
            (GSuite)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GSuite)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>IdentityNow</returns>

    public IdentityNow GetIdentityProvidersIdentitynow()
    {
        ApiResponse<IdentityNow> localVarResponse = GetIdentityProvidersIdentitynowWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of IdentityNow</returns>

    public ApiResponse<IdentityNow> GetIdentityProvidersIdentitynowWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/identitynow";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersIdentitynow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersIdentitynow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityNow>(localVarStatusCode,
            localVarHeaders,
            (IdentityNow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityNow)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of IdentityNow</returns>

    public async Task<IdentityNow> GetIdentityProvidersIdentitynowAsync()
    {
        ApiResponse<IdentityNow> localVarResponse = await GetIdentityProvidersIdentitynowAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (IdentityNow)</returns>

    public async Task<ApiResponse<IdentityNow>> GetIdentityProvidersIdentitynowAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/identitynow";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersIdentitynow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersIdentitynow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityNow>(localVarStatusCode,
            localVarHeaders,
            (IdentityNow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityNow)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Okta</returns>

    public Okta GetIdentityProvidersOkta()
    {
        ApiResponse<Okta> localVarResponse = GetIdentityProvidersOktaWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Okta</returns>

    public ApiResponse<Okta> GetIdentityProvidersOktaWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/okta";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOkta: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOkta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Okta>(localVarStatusCode,
            localVarHeaders,
            (Okta)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Okta)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Okta</returns>

    public async Task<Okta> GetIdentityProvidersOktaAsync()
    {
        ApiResponse<Okta> localVarResponse = await GetIdentityProvidersOktaAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Okta)</returns>

    public async Task<ApiResponse<Okta>> GetIdentityProvidersOktaAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/okta";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOkta: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOkta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Okta>(localVarStatusCode,
            localVarHeaders,
            (Okta)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Okta)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>OneLogin</returns>

    public OneLogin GetIdentityProvidersOnelogin()
    {
        ApiResponse<OneLogin> localVarResponse = GetIdentityProvidersOneloginWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of OneLogin</returns>

    public ApiResponse<OneLogin> GetIdentityProvidersOneloginWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/onelogin";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOnelogin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOnelogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<OneLogin>(localVarStatusCode,
            localVarHeaders,
            (OneLogin)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneLogin)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of OneLogin</returns>

    public async Task<OneLogin> GetIdentityProvidersOneloginAsync()
    {
        ApiResponse<OneLogin> localVarResponse = await GetIdentityProvidersOneloginAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (OneLogin)</returns>

    public async Task<ApiResponse<OneLogin>> GetIdentityProvidersOneloginAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/onelogin";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOnelogin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersOnelogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<OneLogin>(localVarStatusCode,
            localVarHeaders,
            (OneLogin)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneLogin)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>PingIdentity</returns>

    public PingIdentity GetIdentityProvidersPing()
    {
        ApiResponse<PingIdentity> localVarResponse = GetIdentityProvidersPingWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of PingIdentity</returns>

    public ApiResponse<PingIdentity> GetIdentityProvidersPingWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/ping";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<PingIdentity>(localVarStatusCode,
            localVarHeaders,
            (PingIdentity)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PingIdentity)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of PingIdentity</returns>

    public async Task<PingIdentity> GetIdentityProvidersPingAsync()
    {
        ApiResponse<PingIdentity> localVarResponse = await GetIdentityProvidersPingAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (PingIdentity)</returns>

    public async Task<ApiResponse<PingIdentity>> GetIdentityProvidersPingAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/ping";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<PingIdentity>(localVarStatusCode,
            localVarHeaders,
            (PingIdentity)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PingIdentity)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>PureCloudPlatform.Client.V2.Model.PureCloud</returns>

    public PureCloudEnvironment GetIdentityProvidersPurecloud()
    {
        ApiResponse<PureCloudEnvironment> localVarResponse = GetIdentityProvidersPurecloudWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.PureCloud</returns>

    public ApiResponse<PureCloudEnvironment> GetIdentityProvidersPurecloudWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/purecloud";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<PureCloudEnvironment>(localVarStatusCode,
            localVarHeaders,
            (PureCloudEnvironment)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudEnvironment)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of PureCloudPlatform.Client.V2.Model.PureCloud</returns>

    public async Task<PureCloudEnvironment> GetIdentityProvidersPurecloudAsync()
    {
        ApiResponse<PureCloudEnvironment> localVarResponse = await GetIdentityProvidersPurecloudAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.PureCloud)</returns>

    public async Task<ApiResponse<PureCloudEnvironment>> GetIdentityProvidersPurecloudAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/purecloud";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<PureCloudEnvironment>(localVarStatusCode,
            localVarHeaders,
            (PureCloudEnvironment)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudEnvironment)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>PureEngage</returns>

    public PureEngage GetIdentityProvidersPureengage()
    {
        ApiResponse<PureEngage> localVarResponse = GetIdentityProvidersPureengageWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of PureEngage</returns>

    public ApiResponse<PureEngage> GetIdentityProvidersPureengageWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/pureengage";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPureengage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPureengage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<PureEngage>(localVarStatusCode,
            localVarHeaders,
            (PureEngage)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureEngage)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of PureEngage</returns>

    public async Task<PureEngage> GetIdentityProvidersPureengageAsync()
    {
        ApiResponse<PureEngage> localVarResponse = await GetIdentityProvidersPureengageAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (PureEngage)</returns>

    public async Task<ApiResponse<PureEngage>> GetIdentityProvidersPureengageAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/pureengage";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPureengage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersPureengage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<PureEngage>(localVarStatusCode,
            localVarHeaders,
            (PureEngage)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureEngage)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Salesforce</returns>

    public Salesforce GetIdentityProvidersSalesforce()
    {
        ApiResponse<Salesforce> localVarResponse = GetIdentityProvidersSalesforceWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Salesforce</returns>

    public ApiResponse<Salesforce> GetIdentityProvidersSalesforceWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/salesforce";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersSalesforce: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersSalesforce: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Salesforce>(localVarStatusCode,
            localVarHeaders,
            (Salesforce)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Salesforce)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Salesforce</returns>

    public async Task<Salesforce> GetIdentityProvidersSalesforceAsync()
    {
        ApiResponse<Salesforce> localVarResponse = await GetIdentityProvidersSalesforceAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Salesforce)</returns>

    public async Task<ApiResponse<Salesforce>> GetIdentityProvidersSalesforceAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/IdentityProviders/salesforce";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"
        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersSalesforce: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetIdentityProvidersSalesforce: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Salesforce>(localVarStatusCode,
            localVarHeaders,
            (Salesforce)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Salesforce)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>CustomProvider</returns>

    public CustomProvider PostIdentityProviders(CustomProvider body)
    {
        ApiResponse<CustomProvider> localVarResponse = PostIdentityProvidersWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of CustomProvider</returns>

    public ApiResponse<CustomProvider> PostIdentityProvidersWithHttpInfo(CustomProvider body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PostIdentityProviders");
        }

        var localVarPath = "/api/v2/IdentityProviders";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostIdentityProviders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostIdentityProviders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomProvider>(localVarStatusCode,
            localVarHeaders,
            (CustomProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of CustomProvider</returns>

    public async Task<CustomProvider> PostIdentityProvidersAsync(CustomProvider body)
    {
        ApiResponse<CustomProvider> localVarResponse = await PostIdentityProvidersAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (CustomProvider)</returns>

    public async Task<ApiResponse<CustomProvider>> PostIdentityProvidersAsyncWithHttpInfo(CustomProvider body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PostIdentityProviders");
        }

        var localVarPath = "/api/v2/IdentityProviders";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostIdentityProviders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostIdentityProviders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomProvider>(localVarStatusCode,
            localVarHeaders,
            (CustomProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>CustomProvider</returns>

    public CustomProvider PutIdentityprovider(string providerId, CustomProvider body)
    {
        ApiResponse<CustomProvider> localVarResponse = PutIdentityproviderWithHttpInfo(providerId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of CustomProvider</returns>

    public ApiResponse<CustomProvider> PutIdentityproviderWithHttpInfo(string providerId, CustomProvider body)
    {
        // verify the required parameter 'providerId' is set
        if (providerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'providerId' when calling IdentityProviderApi->PutIdentityprovider");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityprovider");
        }

        var localVarPath = "/api/v2/IdentityProviders/{providerId}";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (providerId != null)
        {
            localVarPathParams.Add("providerId", this.Configuration.ApiClient.ParameterToString(providerId));
        }

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityprovider: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityprovider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomProvider>(localVarStatusCode,
            localVarHeaders,
            (CustomProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>Task of CustomProvider</returns>

    public async Task<CustomProvider> PutIdentityproviderAsync(string providerId, CustomProvider body)
    {
        ApiResponse<CustomProvider> localVarResponse = await PutIdentityproviderAsyncWithHttpInfo(providerId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="providerId">Provider ID</param>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (CustomProvider)</returns>

    public async Task<ApiResponse<CustomProvider>> PutIdentityproviderAsyncWithHttpInfo(string providerId, CustomProvider body)
    {
        // verify the required parameter 'providerId' is set
        if (providerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'providerId' when calling IdentityProviderApi->PutIdentityprovider");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityprovider");
        }

        var localVarPath = "/api/v2/IdentityProviders/{providerId}";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (providerId != null)
        {
            localVarPathParams.Add("providerId", this.Configuration.ApiClient.ParameterToString(providerId));
        }

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityprovider: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityprovider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CustomProvider>(localVarStatusCode,
            localVarHeaders,
            (CustomProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersAdfs(ADFS body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersAdfsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersAdfsWithHttpInfo(ADFS body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersAdfs");
        }

        var localVarPath = "/api/v2/IdentityProviders/adfs";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersAdfs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersAdfs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersAdfsAsync(ADFS body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersAdfsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create ADFS Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersAdfsAsyncWithHttpInfo(ADFS body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersAdfs");
        }

        var localVarPath = "/api/v2/IdentityProviders/adfs";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersAdfs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersAdfs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersCic(CustomerInteractionCenter body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersCicWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersCicWithHttpInfo(CustomerInteractionCenter body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersCic");
        }

        var localVarPath = "/api/v2/IdentityProviders/cic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersCic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersCic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersCicAsync(CustomerInteractionCenter body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersCicAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create Customer Interaction Center (CIC) Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersCicAsyncWithHttpInfo(CustomerInteractionCenter body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersCic");
        }

        var localVarPath = "/api/v2/IdentityProviders/cic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersCic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersCic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersGeneric(GenericSAML body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersGenericWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersGenericWithHttpInfo(GenericSAML body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersGeneric");
        }

        var localVarPath = "/api/v2/IdentityProviders/generic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGeneric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGeneric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersGenericAsync(GenericSAML body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersGenericAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create Generic SAML Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersGenericAsyncWithHttpInfo(GenericSAML body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersGeneric");
        }

        var localVarPath = "/api/v2/IdentityProviders/generic";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGeneric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGeneric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersGsuite(GSuite body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersGsuiteWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersGsuiteWithHttpInfo(GSuite body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersGsuite");
        }

        var localVarPath = "/api/v2/IdentityProviders/gsuite";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGsuite: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGsuite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersGsuiteAsync(GSuite body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersGsuiteAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create G Suite Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersGsuiteAsyncWithHttpInfo(GSuite body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersGsuite");
        }

        var localVarPath = "/api/v2/IdentityProviders/gsuite";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGsuite: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersGsuite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityNow</returns>

    public IdentityNow PutIdentityProvidersIdentitynow(IdentityNow body)
    {
        ApiResponse<IdentityNow> localVarResponse = PutIdentityProvidersIdentitynowWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityNow</returns>

    public ApiResponse<IdentityNow> PutIdentityProvidersIdentitynowWithHttpInfo(IdentityNow body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersIdentitynow");
        }

        var localVarPath = "/api/v2/IdentityProviders/identitynow";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersIdentitynow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersIdentitynow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityNow>(localVarStatusCode,
            localVarHeaders,
            (IdentityNow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityNow)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityNow</returns>

    public async Task<IdentityNow> PutIdentityProvidersIdentitynowAsync(IdentityNow body)
    {
        ApiResponse<IdentityNow> localVarResponse = await PutIdentityProvidersIdentitynowAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create IdentityNow Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityNow)</returns>

    public async Task<ApiResponse<IdentityNow>> PutIdentityProvidersIdentitynowAsyncWithHttpInfo(IdentityNow body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersIdentitynow");
        }

        var localVarPath = "/api/v2/IdentityProviders/identitynow";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersIdentitynow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersIdentitynow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityNow>(localVarStatusCode,
            localVarHeaders,
            (IdentityNow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityNow)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersOkta(Okta body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersOktaWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersOktaWithHttpInfo(Okta body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersOkta");
        }

        var localVarPath = "/api/v2/IdentityProviders/okta";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOkta: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOkta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersOktaAsync(Okta body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersOktaAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create Okta Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersOktaAsyncWithHttpInfo(Okta body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersOkta");
        }

        var localVarPath = "/api/v2/IdentityProviders/okta";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOkta: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOkta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersOnelogin(OneLogin body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersOneloginWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersOneloginWithHttpInfo(OneLogin body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersOnelogin");
        }

        var localVarPath = "/api/v2/IdentityProviders/onelogin";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOnelogin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOnelogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersOneloginAsync(OneLogin body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersOneloginAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create OneLogin Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersOneloginAsyncWithHttpInfo(OneLogin body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersOnelogin");
        }

        var localVarPath = "/api/v2/IdentityProviders/onelogin";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOnelogin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersOnelogin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersPing(PingIdentity body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersPingWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersPingWithHttpInfo(PingIdentity body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersPing");
        }

        var localVarPath = "/api/v2/IdentityProviders/ping";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersPingAsync(PingIdentity body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersPingAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create Ping Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersPingAsyncWithHttpInfo(PingIdentity body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersPing");
        }

        var localVarPath = "/api/v2/IdentityProviders/ping";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersPurecloud(PureCloudEnvironment body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersPurecloudWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersPurecloudWithHttpInfo(PureCloudEnvironment body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersPurecloud");
        }

        var localVarPath = "/api/v2/IdentityProviders/purecloud";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersPurecloudAsync(PureCloudEnvironment body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersPurecloudAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create PureCloudEnvironment Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersPurecloudAsyncWithHttpInfo(PureCloudEnvironment body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersPurecloud");
        }

        var localVarPath = "/api/v2/IdentityProviders/purecloud";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersPureengage(PureEngage body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersPureengageWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersPureengageWithHttpInfo(PureEngage body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersPureengage");
        }

        var localVarPath = "/api/v2/IdentityProviders/pureengage";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPureengage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPureengage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersPureengageAsync(PureEngage body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersPureengageAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create PureEngage Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersPureengageAsyncWithHttpInfo(PureEngage body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersPureengage");
        }

        var localVarPath = "/api/v2/IdentityProviders/pureengage";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPureengage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersPureengage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/Create Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>IdentityProvider</returns>

    public IdentityProvider PutIdentityProvidersSalesforce(Salesforce body)
    {
        ApiResponse<IdentityProvider> localVarResponse = PutIdentityProvidersSalesforceWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/Create Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>

    public ApiResponse<IdentityProvider> PutIdentityProvidersSalesforceWithHttpInfo(Salesforce body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersSalesforce");
        }

        var localVarPath = "/api/v2/IdentityProviders/salesforce";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersSalesforce: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersSalesforce: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/Create Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of IdentityProvider</returns>

    public async Task<IdentityProvider> PutIdentityProvidersSalesforceAsync(Salesforce body)
    {
        ApiResponse<IdentityProvider> localVarResponse = await PutIdentityProvidersSalesforceAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/Create Salesforce Identity Provider 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Provider</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>

    public async Task<ApiResponse<IdentityProvider>> PutIdentityProvidersSalesforceAsyncWithHttpInfo(Salesforce body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling IdentityProviderApi->PutIdentityProvidersSalesforce");
        }

        var localVarPath = "/api/v2/IdentityProviders/salesforce";
        var localVarPathParams = new Dictionary<String, String>();
        var localVarQueryParams = new List<Tuple<String, String>>();
        var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<String, String>();
        var localVarFileParams = new Dictionary<String, FileParameter>();
        Object localVarPostBody = null;

        // to determine the Content-Type header
        String[] localVarHttpContentTypes = new String[] {
            "application/json"

        };
        String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        String[] localVarHttpHeaderAccepts = new String[] {

            "application/json"


        };
        String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!String.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersSalesforce: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutIdentityProvidersSalesforce: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<IdentityProvider>(localVarStatusCode,
            localVarHeaders,
            (IdentityProvider)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityProvider)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
