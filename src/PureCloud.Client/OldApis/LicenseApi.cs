using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ILicenseApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get PureCloudEnvironment license definition.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>LicenseDefinition</returns>

    LicenseDefinition GetLicenseDefinition(string licenseId);

    /// <summary>
    /// Get PureCloudEnvironment license definition.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>ApiResponse of LicenseDefinition</returns>

    ApiResponse<LicenseDefinition> GetLicenseDefinitionWithHttpInfo(string licenseId);

    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;LicenseDefinition&gt;</returns>

    List<LicenseDefinition> GetLicenseDefinitions();

    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;LicenseDefinition&gt;</returns>

    ApiResponse<List<LicenseDefinition>> GetLicenseDefinitionsWithHttpInfo();

    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>LicenseOrgToggle</returns>

    LicenseOrgToggle GetLicenseToggle(string featureName);

    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>ApiResponse of LicenseOrgToggle</returns>

    ApiResponse<LicenseOrgToggle> GetLicenseToggleWithHttpInfo(string featureName);

    /// <summary>
    /// Get licenses for specified user.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>LicenseUser</returns>

    LicenseUser GetLicenseUser(string userId);

    /// <summary>
    /// Get licenses for specified user.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>ApiResponse of LicenseUser</returns>

    ApiResponse<LicenseUser> GetLicenseUserWithHttpInfo(string userId);

    /// <summary>
    /// Get a page of users and their licenses
    /// </summary>
    /// <remarks>
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>UserLicensesEntityListing</returns>

    UserLicensesEntityListing GetLicenseUsers(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a page of users and their licenses
    /// </summary>
    /// <remarks>
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of UserLicensesEntityListing</returns>

    ApiResponse<UserLicensesEntityListing> GetLicenseUsersWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>List&lt;string&gt;</returns>

    List<string> PostLicenseInfer(List<string> body = null);

    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>ApiResponse of List&lt;string&gt;</returns>

    ApiResponse<List<string>> PostLicenseInferWithHttpInfo(List<string> body = null);

    /// <summary>
    /// Update the organization&#39;s license assignments in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>List&lt;LicenseUpdateStatus&gt;</returns>

    List<LicenseUpdateStatus> PostLicenseOrganization(LicenseBatchAssignmentRequest body = null);

    /// <summary>
    /// Update the organization&#39;s license assignments in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>ApiResponse of List&lt;LicenseUpdateStatus&gt;</returns>

    ApiResponse<List<LicenseUpdateStatus>> PostLicenseOrganizationWithHttpInfo(LicenseBatchAssignmentRequest body = null);

    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>LicenseOrgToggle</returns>

    LicenseOrgToggle PostLicenseToggle(string featureName);

    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>ApiResponse of LicenseOrgToggle</returns>

    ApiResponse<LicenseOrgToggle> PostLicenseToggleWithHttpInfo(string featureName);

    /// <summary>
    /// Fetch user licenses in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    Dictionary<string, object> PostLicenseUsers(List<string> body = null);

    /// <summary>
    /// Fetch user licenses in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    ApiResponse<Dictionary<string, object>> PostLicenseUsersWithHttpInfo(List<string> body = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get PureCloudEnvironment license definition.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>Task of LicenseDefinition</returns>

    Task<LicenseDefinition> GetLicenseDefinitionAsync(string licenseId);

    /// <summary>
    /// Get PureCloudEnvironment license definition.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>Task of ApiResponse (LicenseDefinition)</returns>

    Task<ApiResponse<LicenseDefinition>> GetLicenseDefinitionAsyncWithHttpInfo(string licenseId);

    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of List&lt;LicenseDefinition&gt;</returns>

    Task<List<LicenseDefinition>> GetLicenseDefinitionsAsync();

    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (List&lt;LicenseDefinition&gt;)</returns>

    Task<ApiResponse<List<LicenseDefinition>>> GetLicenseDefinitionsAsyncWithHttpInfo();

    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of LicenseOrgToggle</returns>

    Task<LicenseOrgToggle> GetLicenseToggleAsync(string featureName);

    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of ApiResponse (LicenseOrgToggle)</returns>

    Task<ApiResponse<LicenseOrgToggle>> GetLicenseToggleAsyncWithHttpInfo(string featureName);

    /// <summary>
    /// Get licenses for specified user.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>Task of LicenseUser</returns>

    Task<LicenseUser> GetLicenseUserAsync(string userId);

    /// <summary>
    /// Get licenses for specified user.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>Task of ApiResponse (LicenseUser)</returns>

    Task<ApiResponse<LicenseUser>> GetLicenseUserAsyncWithHttpInfo(string userId);

    /// <summary>
    /// Get a page of users and their licenses
    /// </summary>
    /// <remarks>
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of UserLicensesEntityListing</returns>

    Task<UserLicensesEntityListing> GetLicenseUsersAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a page of users and their licenses
    /// </summary>
    /// <remarks>
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (UserLicensesEntityListing)</returns>

    Task<ApiResponse<UserLicensesEntityListing>> GetLicenseUsersAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>Task of List&lt;string&gt;</returns>

    Task<List<string>> PostLicenseInferAsync(List<string> body = null);

    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>

    Task<ApiResponse<List<string>>> PostLicenseInferAsyncWithHttpInfo(List<string> body = null);

    /// <summary>
    /// Update the organization&#39;s license assignments in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>Task of List&lt;LicenseUpdateStatus&gt;</returns>

    Task<List<LicenseUpdateStatus>> PostLicenseOrganizationAsync(LicenseBatchAssignmentRequest body = null);

    /// <summary>
    /// Update the organization&#39;s license assignments in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;LicenseUpdateStatus&gt;)</returns>

    Task<ApiResponse<List<LicenseUpdateStatus>>> PostLicenseOrganizationAsyncWithHttpInfo(LicenseBatchAssignmentRequest body = null);

    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of LicenseOrgToggle</returns>

    Task<LicenseOrgToggle> PostLicenseToggleAsync(string featureName);

    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of ApiResponse (LicenseOrgToggle)</returns>

    Task<ApiResponse<LicenseOrgToggle>> PostLicenseToggleAsyncWithHttpInfo(string featureName);

    /// <summary>
    /// Fetch user licenses in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    Task<Dictionary<string, object>> PostLicenseUsersAsync(List<string> body = null);

    /// <summary>
    /// Fetch user licenses in a batch.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    Task<ApiResponse<Dictionary<string, object>>> PostLicenseUsersAsyncWithHttpInfo(List<string> body = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class LicenseApi : ILicenseApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseApi"/> class.
    /// </summary>
    /// <returns></returns>
    public LicenseApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public LicenseApi(Configuration configuration = null)
    {
        if (configuration == null) // use the default one in Configuration
        {
            Configuration = Configuration.Default;
        }
        else
        {
            Configuration = configuration;
        }

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
    public void SetBasePath(string basePath)
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
    public Dictionary<string, string> DefaultHeader()
    {
        return Configuration.DefaultHeader;
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
        Configuration.AddDefaultHeader(key, value);
    }


    /// <summary>
    /// Get PureCloudEnvironment license definition. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>LicenseDefinition</returns>

    public LicenseDefinition GetLicenseDefinition(string licenseId)
    {
        ApiResponse<LicenseDefinition> localVarResponse = GetLicenseDefinitionWithHttpInfo(licenseId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get PureCloudEnvironment license definition. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>ApiResponse of LicenseDefinition</returns>

    public ApiResponse<LicenseDefinition> GetLicenseDefinitionWithHttpInfo(string licenseId)
    {
        // verify the required parameter 'licenseId' is set
        if (licenseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'licenseId' when calling LicenseApi->GetLicenseDefinition");
        }

        var localVarPath = "/api/v2/license/definitions/{licenseId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (licenseId != null)
        {
            localVarPathParams.Add("licenseId", Configuration.ApiClient.ParameterToString(licenseId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseDefinition>(localVarStatusCode,
            localVarHeaders,
            (LicenseDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get PureCloudEnvironment license definition. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>Task of LicenseDefinition</returns>

    public async Task<LicenseDefinition> GetLicenseDefinitionAsync(string licenseId)
    {
        ApiResponse<LicenseDefinition> localVarResponse = await GetLicenseDefinitionAsyncWithHttpInfo(licenseId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get PureCloudEnvironment license definition. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="licenseId">ID</param>
    /// <returns>Task of ApiResponse (LicenseDefinition)</returns>

    public async Task<ApiResponse<LicenseDefinition>> GetLicenseDefinitionAsyncWithHttpInfo(string licenseId)
    {
        // verify the required parameter 'licenseId' is set
        if (licenseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'licenseId' when calling LicenseApi->GetLicenseDefinition");
        }

        var localVarPath = "/api/v2/license/definitions/{licenseId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (licenseId != null)
        {
            localVarPathParams.Add("licenseId", Configuration.ApiClient.ParameterToString(licenseId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseDefinition>(localVarStatusCode,
            localVarHeaders,
            (LicenseDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;LicenseDefinition&gt;</returns>

    public List<LicenseDefinition> GetLicenseDefinitions()
    {
        ApiResponse<List<LicenseDefinition>> localVarResponse = GetLicenseDefinitionsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;LicenseDefinition&gt;</returns>

    public ApiResponse<List<LicenseDefinition>> GetLicenseDefinitionsWithHttpInfo()
    {

        var localVarPath = "/api/v2/license/definitions";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<LicenseDefinition>>(localVarStatusCode,
            localVarHeaders,
            (List<LicenseDefinition>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LicenseDefinition>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of List&lt;LicenseDefinition&gt;</returns>

    public async Task<List<LicenseDefinition>> GetLicenseDefinitionsAsync()
    {
        ApiResponse<List<LicenseDefinition>> localVarResponse = await GetLicenseDefinitionsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get all PureCloudEnvironment license definitions available for the organization. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (List&lt;LicenseDefinition&gt;)</returns>

    public async Task<ApiResponse<List<LicenseDefinition>>> GetLicenseDefinitionsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/license/definitions";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseDefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<LicenseDefinition>>(localVarStatusCode,
            localVarHeaders,
            (List<LicenseDefinition>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LicenseDefinition>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>LicenseOrgToggle</returns>

    public LicenseOrgToggle GetLicenseToggle(string featureName)
    {
        ApiResponse<LicenseOrgToggle> localVarResponse = GetLicenseToggleWithHttpInfo(featureName);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>ApiResponse of LicenseOrgToggle</returns>

    public ApiResponse<LicenseOrgToggle> GetLicenseToggleWithHttpInfo(string featureName)
    {
        // verify the required parameter 'featureName' is set
        if (featureName == null)
        {
            throw new ApiException(400, "Missing required parameter 'featureName' when calling LicenseApi->GetLicenseToggle");
        }

        var localVarPath = "/api/v2/license/toggles/{featureName}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (featureName != null)
        {
            localVarPathParams.Add("featureName", Configuration.ApiClient.ParameterToString(featureName));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseToggle: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseToggle: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseOrgToggle>(localVarStatusCode,
            localVarHeaders,
            (LicenseOrgToggle)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseOrgToggle)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of LicenseOrgToggle</returns>

    public async Task<LicenseOrgToggle> GetLicenseToggleAsync(string featureName)
    {
        ApiResponse<LicenseOrgToggle> localVarResponse = await GetLicenseToggleAsyncWithHttpInfo(featureName);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of ApiResponse (LicenseOrgToggle)</returns>

    public async Task<ApiResponse<LicenseOrgToggle>> GetLicenseToggleAsyncWithHttpInfo(string featureName)
    {
        // verify the required parameter 'featureName' is set
        if (featureName == null)
        {
            throw new ApiException(400, "Missing required parameter 'featureName' when calling LicenseApi->GetLicenseToggle");
        }

        var localVarPath = "/api/v2/license/toggles/{featureName}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (featureName != null)
        {
            localVarPathParams.Add("featureName", Configuration.ApiClient.ParameterToString(featureName));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseToggle: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseToggle: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseOrgToggle>(localVarStatusCode,
            localVarHeaders,
            (LicenseOrgToggle)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseOrgToggle)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get licenses for specified user. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>LicenseUser</returns>

    public LicenseUser GetLicenseUser(string userId)
    {
        ApiResponse<LicenseUser> localVarResponse = GetLicenseUserWithHttpInfo(userId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get licenses for specified user. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>ApiResponse of LicenseUser</returns>

    public ApiResponse<LicenseUser> GetLicenseUserWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling LicenseApi->GetLicenseUser");
        }

        var localVarPath = "/api/v2/license/users/{userId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseUser>(localVarStatusCode,
            localVarHeaders,
            (LicenseUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get licenses for specified user. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>Task of LicenseUser</returns>

    public async Task<LicenseUser> GetLicenseUserAsync(string userId)
    {
        ApiResponse<LicenseUser> localVarResponse = await GetLicenseUserAsyncWithHttpInfo(userId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get licenses for specified user. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">ID</param>
    /// <returns>Task of ApiResponse (LicenseUser)</returns>

    public async Task<ApiResponse<LicenseUser>> GetLicenseUserAsyncWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling LicenseApi->GetLicenseUser");
        }

        var localVarPath = "/api/v2/license/users/{userId}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseUser>(localVarStatusCode,
            localVarHeaders,
            (LicenseUser)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseUser)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a page of users and their licenses 
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>UserLicensesEntityListing</returns>

    public UserLicensesEntityListing GetLicenseUsers(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<UserLicensesEntityListing> localVarResponse = GetLicenseUsersWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a page of users and their licenses 
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of UserLicensesEntityListing</returns>

    public ApiResponse<UserLicensesEntityListing> GetLicenseUsersWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/license/users";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserLicensesEntityListing>(localVarStatusCode,
            localVarHeaders,
            (UserLicensesEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLicensesEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a page of users and their licenses 
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of UserLicensesEntityListing</returns>

    public async Task<UserLicensesEntityListing> GetLicenseUsersAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<UserLicensesEntityListing> localVarResponse = await GetLicenseUsersAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a page of users and their licenses 
    /// Retrieve a page of users in an organization along with the licenses they possess.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (UserLicensesEntityListing)</returns>

    public async Task<ApiResponse<UserLicensesEntityListing>> GetLicenseUsersAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/license/users";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
        }

        if (pageNumber != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLicenseUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UserLicensesEntityListing>(localVarStatusCode,
            localVarHeaders,
            (UserLicensesEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLicensesEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>List&lt;string&gt;</returns>

    public List<string> PostLicenseInfer(List<string> body = null)
    {
        ApiResponse<List<string>> localVarResponse = PostLicenseInferWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>ApiResponse of List&lt;string&gt;</returns>

    public ApiResponse<List<string>> PostLicenseInferWithHttpInfo(List<string> body = null)
    {

        var localVarPath = "/api/v2/license/infer";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseInfer: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseInfer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<string>>(localVarStatusCode,
            localVarHeaders,
            (List<string>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>Task of List&lt;string&gt;</returns>

    public async Task<List<string>> PostLicenseInferAsync(List<string> body = null)
    {
        ApiResponse<List<string>> localVarResponse = await PostLicenseInferAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a list of licenses inferred based on a list of roleIds 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The roleIds to use while inferring licenses (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>

    public async Task<ApiResponse<List<string>>> PostLicenseInferAsyncWithHttpInfo(List<string> body = null)
    {

        var localVarPath = "/api/v2/license/infer";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseInfer: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseInfer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<string>>(localVarStatusCode,
            localVarHeaders,
            (List<string>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update the organization&#39;s license assignments in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>List&lt;LicenseUpdateStatus&gt;</returns>

    public List<LicenseUpdateStatus> PostLicenseOrganization(LicenseBatchAssignmentRequest body = null)
    {
        ApiResponse<List<LicenseUpdateStatus>> localVarResponse = PostLicenseOrganizationWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update the organization&#39;s license assignments in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>ApiResponse of List&lt;LicenseUpdateStatus&gt;</returns>

    public ApiResponse<List<LicenseUpdateStatus>> PostLicenseOrganizationWithHttpInfo(LicenseBatchAssignmentRequest body = null)
    {

        var localVarPath = "/api/v2/license/organization";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<LicenseUpdateStatus>>(localVarStatusCode,
            localVarHeaders,
            (List<LicenseUpdateStatus>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LicenseUpdateStatus>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update the organization&#39;s license assignments in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>Task of List&lt;LicenseUpdateStatus&gt;</returns>

    public async Task<List<LicenseUpdateStatus>> PostLicenseOrganizationAsync(LicenseBatchAssignmentRequest body = null)
    {
        ApiResponse<List<LicenseUpdateStatus>> localVarResponse = await PostLicenseOrganizationAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update the organization&#39;s license assignments in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The license assignments to update. (optional)</param>
    /// <returns>Task of ApiResponse (List&lt;LicenseUpdateStatus&gt;)</returns>

    public async Task<ApiResponse<List<LicenseUpdateStatus>>> PostLicenseOrganizationAsyncWithHttpInfo(LicenseBatchAssignmentRequest body = null)
    {

        var localVarPath = "/api/v2/license/organization";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<List<LicenseUpdateStatus>>(localVarStatusCode,
            localVarHeaders,
            (List<LicenseUpdateStatus>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LicenseUpdateStatus>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>LicenseOrgToggle</returns>

    public LicenseOrgToggle PostLicenseToggle(string featureName)
    {
        ApiResponse<LicenseOrgToggle> localVarResponse = PostLicenseToggleWithHttpInfo(featureName);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>ApiResponse of LicenseOrgToggle</returns>

    public ApiResponse<LicenseOrgToggle> PostLicenseToggleWithHttpInfo(string featureName)
    {
        // verify the required parameter 'featureName' is set
        if (featureName == null)
        {
            throw new ApiException(400, "Missing required parameter 'featureName' when calling LicenseApi->PostLicenseToggle");
        }

        var localVarPath = "/api/v2/license/toggles/{featureName}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (featureName != null)
        {
            localVarPathParams.Add("featureName", Configuration.ApiClient.ParameterToString(featureName));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseToggle: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseToggle: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseOrgToggle>(localVarStatusCode,
            localVarHeaders,
            (LicenseOrgToggle)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseOrgToggle)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of LicenseOrgToggle</returns>

    public async Task<LicenseOrgToggle> PostLicenseToggleAsync(string featureName)
    {
        ApiResponse<LicenseOrgToggle> localVarResponse = await PostLicenseToggleAsyncWithHttpInfo(featureName);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Deprecated. No alternative required - this endpoint has no effect 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="featureName">featureName</param>
    /// <returns>Task of ApiResponse (LicenseOrgToggle)</returns>

    public async Task<ApiResponse<LicenseOrgToggle>> PostLicenseToggleAsyncWithHttpInfo(string featureName)
    {
        // verify the required parameter 'featureName' is set
        if (featureName == null)
        {
            throw new ApiException(400, "Missing required parameter 'featureName' when calling LicenseApi->PostLicenseToggle");
        }

        var localVarPath = "/api/v2/license/toggles/{featureName}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (featureName != null)
        {
            localVarPathParams.Add("featureName", Configuration.ApiClient.ParameterToString(featureName));
        }

        // Query params

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseToggle: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseToggle: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LicenseOrgToggle>(localVarStatusCode,
            localVarHeaders,
            (LicenseOrgToggle)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LicenseOrgToggle)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Fetch user licenses in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    public Dictionary<string, object> PostLicenseUsers(List<string> body = null)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = PostLicenseUsersWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Fetch user licenses in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    public ApiResponse<Dictionary<string, object>> PostLicenseUsersWithHttpInfo(List<string> body = null)
    {

        var localVarPath = "/api/v2/license/users";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Fetch user licenses in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    public async Task<Dictionary<string, object>> PostLicenseUsersAsync(List<string> body = null)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = await PostLicenseUsersAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Fetch user licenses in a batch. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">The user IDs to fetch. (optional)</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    public async Task<ApiResponse<Dictionary<string, object>>> PostLicenseUsersAsyncWithHttpInfo(List<string> body = null)
    {

        var localVarPath = "/api/v2/license/users";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLicenseUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
