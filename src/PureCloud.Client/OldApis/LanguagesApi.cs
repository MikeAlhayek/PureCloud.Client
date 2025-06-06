using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ILanguagesApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns></returns>
    [Obsolete]
    void DeleteLanguage(string languageId);

    /// <summary>
    /// Delete Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    ApiResponse<object> DeleteLanguageWithHttpInfo(string languageId);

    /// <summary>
    /// Get Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Language</returns>
    [Obsolete]
    Language GetLanguage(string languageId);

    /// <summary>
    /// Get Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>ApiResponse of Language</returns>
    [Obsolete]
    ApiResponse<Language> GetLanguageWithHttpInfo(string languageId);

    /// <summary>
    /// Get the list of supported languages. (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>LanguageEntityListing</returns>
    [Obsolete]
    LanguageEntityListing GetLanguages(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

    /// <summary>
    /// Get the list of supported languages. (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>ApiResponse of LanguageEntityListing</returns>
    [Obsolete]
    ApiResponse<LanguageEntityListing> GetLanguagesWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

    /// <summary>
    /// Get all available languages for translation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>AvailableTranslations</returns>

    AvailableTranslations GetLanguagesTranslations();

    /// <summary>
    /// Get all available languages for translation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of AvailableTranslations</returns>

    ApiResponse<AvailableTranslations> GetLanguagesTranslationsWithHttpInfo();

    /// <summary>
    /// Get the builtin translation for a language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    Dictionary<string, object> GetLanguagesTranslationsBuiltin(string language);

    /// <summary>
    /// Get the builtin translation for a language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    ApiResponse<Dictionary<string, object>> GetLanguagesTranslationsBuiltinWithHttpInfo(string language);

    /// <summary>
    /// Get effective translation for an organization by language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    Dictionary<string, object> GetLanguagesTranslationsOrganization(string language);

    /// <summary>
    /// Get effective translation for an organization by language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    ApiResponse<Dictionary<string, object>> GetLanguagesTranslationsOrganizationWithHttpInfo(string language);

    /// <summary>
    /// Get effective language translation for a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    Dictionary<string, object> GetLanguagesTranslationsUser(string userId);

    /// <summary>
    /// Get effective language translation for a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    ApiResponse<Dictionary<string, object>> GetLanguagesTranslationsUserWithHttpInfo(string userId);

    /// <summary>
    /// Create Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>Language</returns>
    [Obsolete]
    Language PostLanguages(Language body);

    /// <summary>
    /// Create Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>ApiResponse of Language</returns>
    [Obsolete]
    ApiResponse<Language> PostLanguagesWithHttpInfo(Language body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of void</returns>
    [Obsolete]
    Task DeleteLanguageAsync(string languageId);

    /// <summary>
    /// Delete Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    Task<ApiResponse<object>> DeleteLanguageAsyncWithHttpInfo(string languageId);

    /// <summary>
    /// Get Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of Language</returns>
    [Obsolete]
    Task<Language> GetLanguageAsync(string languageId);

    /// <summary>
    /// Get Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of ApiResponse (Language)</returns>
    [Obsolete]
    Task<ApiResponse<Language>> GetLanguageAsyncWithHttpInfo(string languageId);

    /// <summary>
    /// Get the list of supported languages. (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>Task of LanguageEntityListing</returns>
    [Obsolete]
    Task<LanguageEntityListing> GetLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

    /// <summary>
    /// Get the list of supported languages. (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>Task of ApiResponse (LanguageEntityListing)</returns>
    [Obsolete]
    Task<ApiResponse<LanguageEntityListing>> GetLanguagesAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

    /// <summary>
    /// Get all available languages for translation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of AvailableTranslations</returns>

    Task<AvailableTranslations> GetLanguagesTranslationsAsync();

    /// <summary>
    /// Get all available languages for translation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (AvailableTranslations)</returns>

    Task<ApiResponse<AvailableTranslations>> GetLanguagesTranslationsAsyncWithHttpInfo();

    /// <summary>
    /// Get the builtin translation for a language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language);

    /// <summary>
    /// Get the builtin translation for a language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    Task<ApiResponse<Dictionary<string, object>>> GetLanguagesTranslationsBuiltinAsyncWithHttpInfo(string language);

    /// <summary>
    /// Get effective translation for an organization by language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language);

    /// <summary>
    /// Get effective translation for an organization by language
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    Task<ApiResponse<Dictionary<string, object>>> GetLanguagesTranslationsOrganizationAsyncWithHttpInfo(string language);

    /// <summary>
    /// Get effective language translation for a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId);

    /// <summary>
    /// Get effective language translation for a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    Task<ApiResponse<Dictionary<string, object>>> GetLanguagesTranslationsUserAsyncWithHttpInfo(string userId);

    /// <summary>
    /// Create Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>Task of Language</returns>
    [Obsolete]
    Task<Language> PostLanguagesAsync(Language body);

    /// <summary>
    /// Create Language (Deprecated)
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>Task of ApiResponse (Language)</returns>
    [Obsolete]
    Task<ApiResponse<Language>> PostLanguagesAsyncWithHttpInfo(Language body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class LanguagesApi : ILanguagesApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LanguagesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public LanguagesApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LanguagesApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public LanguagesApi(Configuration configuration = null)
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
    /// Delete Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns></returns>
    [Obsolete]
    public void DeleteLanguage(string languageId)
    {
        DeleteLanguageWithHttpInfo(languageId);
    }

    /// <summary>
    /// Delete Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    public ApiResponse<object> DeleteLanguageWithHttpInfo(string languageId)
    {
        // verify the required parameter 'languageId' is set
        if (languageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->DeleteLanguage");
        }

        var localVarPath = "/api/v2/languages/{languageId}";
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
        if (languageId != null)
        {
            localVarPathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of void</returns>
    [Obsolete]
    public async Task DeleteLanguageAsync(string languageId)
    {
        await DeleteLanguageAsyncWithHttpInfo(languageId);

    }

    /// <summary>
    /// Delete Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    public async Task<ApiResponse<object>> DeleteLanguageAsyncWithHttpInfo(string languageId)
    {
        // verify the required parameter 'languageId' is set
        if (languageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->DeleteLanguage");
        }

        var localVarPath = "/api/v2/languages/{languageId}";
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
        if (languageId != null)
        {
            localVarPathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId));
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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Language</returns>
    [Obsolete]
    public Language GetLanguage(string languageId)
    {
        ApiResponse<Language> localVarResponse = GetLanguageWithHttpInfo(languageId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>ApiResponse of Language</returns>
    [Obsolete]
    public ApiResponse<Language> GetLanguageWithHttpInfo(string languageId)
    {
        // verify the required parameter 'languageId' is set
        if (languageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->GetLanguage");
        }

        var localVarPath = "/api/v2/languages/{languageId}";
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
        if (languageId != null)
        {
            localVarPathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Language>(localVarStatusCode,
            localVarHeaders,
            (Language)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of Language</returns>
    [Obsolete]
    public async Task<Language> GetLanguageAsync(string languageId)
    {
        ApiResponse<Language> localVarResponse = await GetLanguageAsyncWithHttpInfo(languageId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="languageId">Language ID</param>
    /// <returns>Task of ApiResponse (Language)</returns>
    [Obsolete]
    public async Task<ApiResponse<Language>> GetLanguageAsyncWithHttpInfo(string languageId)
    {
        // verify the required parameter 'languageId' is set
        if (languageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->GetLanguage");
        }

        var localVarPath = "/api/v2/languages/{languageId}";
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
        if (languageId != null)
        {
            localVarPathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Language>(localVarStatusCode,
            localVarHeaders,
            (Language)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the list of supported languages. (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>LanguageEntityListing</returns>
    [Obsolete]
    public LanguageEntityListing GetLanguages(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
    {
        ApiResponse<LanguageEntityListing> localVarResponse = GetLanguagesWithHttpInfo(pageSize, pageNumber, sortOrder, name);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the list of supported languages. (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>ApiResponse of LanguageEntityListing</returns>
    [Obsolete]
    public ApiResponse<LanguageEntityListing> GetLanguagesWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
    {

        var localVarPath = "/api/v2/languages";
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

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LanguageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LanguageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the list of supported languages. (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>Task of LanguageEntityListing</returns>
    [Obsolete]
    public async Task<LanguageEntityListing> GetLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
    {
        ApiResponse<LanguageEntityListing> localVarResponse = await GetLanguagesAsyncWithHttpInfo(pageSize, pageNumber, sortOrder, name);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the list of supported languages. (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
    /// <param name="name">Name (optional)</param>
    /// <returns>Task of ApiResponse (LanguageEntityListing)</returns>
    [Obsolete]
    public async Task<ApiResponse<LanguageEntityListing>> GetLanguagesAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
    {

        var localVarPath = "/api/v2/languages";
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

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LanguageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LanguageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get all available languages for translation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>AvailableTranslations</returns>

    public AvailableTranslations GetLanguagesTranslations()
    {
        ApiResponse<AvailableTranslations> localVarResponse = GetLanguagesTranslationsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get all available languages for translation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of AvailableTranslations</returns>

    public ApiResponse<AvailableTranslations> GetLanguagesTranslationsWithHttpInfo()
    {

        var localVarPath = "/api/v2/languages/translations";
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AvailableTranslations>(localVarStatusCode,
            localVarHeaders,
            (AvailableTranslations)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTranslations)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get all available languages for translation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of AvailableTranslations</returns>

    public async Task<AvailableTranslations> GetLanguagesTranslationsAsync()
    {
        ApiResponse<AvailableTranslations> localVarResponse = await GetLanguagesTranslationsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get all available languages for translation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (AvailableTranslations)</returns>

    public async Task<ApiResponse<AvailableTranslations>> GetLanguagesTranslationsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/languages/translations";
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AvailableTranslations>(localVarStatusCode,
            localVarHeaders,
            (AvailableTranslations)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTranslations)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the builtin translation for a language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    public Dictionary<string, object> GetLanguagesTranslationsBuiltin(string language)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = GetLanguagesTranslationsBuiltinWithHttpInfo(language);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the builtin translation for a language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    public ApiResponse<Dictionary<string, object>> GetLanguagesTranslationsBuiltinWithHttpInfo(string language)
    {
        // verify the required parameter 'language' is set
        if (language == null)
        {
            throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsBuiltin");
        }

        var localVarPath = "/api/v2/languages/translations/builtin";
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
        if (language != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("language", Configuration.ApiClient.ParameterToString(language)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the builtin translation for a language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    public async Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = await GetLanguagesTranslationsBuiltinAsyncWithHttpInfo(language);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the builtin translation for a language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the builtin translation to retrieve</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    public async Task<ApiResponse<Dictionary<string, object>>> GetLanguagesTranslationsBuiltinAsyncWithHttpInfo(string language)
    {
        // verify the required parameter 'language' is set
        if (language == null)
        {
            throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsBuiltin");
        }

        var localVarPath = "/api/v2/languages/translations/builtin";
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
        if (language != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("language", Configuration.ApiClient.ParameterToString(language)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get effective translation for an organization by language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    public Dictionary<string, object> GetLanguagesTranslationsOrganization(string language)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = GetLanguagesTranslationsOrganizationWithHttpInfo(language);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get effective translation for an organization by language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    public ApiResponse<Dictionary<string, object>> GetLanguagesTranslationsOrganizationWithHttpInfo(string language)
    {
        // verify the required parameter 'language' is set
        if (language == null)
        {
            throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsOrganization");
        }

        var localVarPath = "/api/v2/languages/translations/organization";
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
        if (language != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("language", Configuration.ApiClient.ParameterToString(language)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get effective translation for an organization by language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    public async Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = await GetLanguagesTranslationsOrganizationAsyncWithHttpInfo(language);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get effective translation for an organization by language 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="language">The language of the translation to retrieve for the organization</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    public async Task<ApiResponse<Dictionary<string, object>>> GetLanguagesTranslationsOrganizationAsyncWithHttpInfo(string language)
    {
        // verify the required parameter 'language' is set
        if (language == null)
        {
            throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsOrganization");
        }

        var localVarPath = "/api/v2/languages/translations/organization";
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
        if (language != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("language", Configuration.ApiClient.ParameterToString(language)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get effective language translation for a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>

    public Dictionary<string, object> GetLanguagesTranslationsUser(string userId)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = GetLanguagesTranslationsUserWithHttpInfo(userId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get effective language translation for a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>

    public ApiResponse<Dictionary<string, object>> GetLanguagesTranslationsUserWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling LanguagesApi->GetLanguagesTranslationsUser");
        }

        var localVarPath = "/api/v2/languages/translations/users/{userId}";
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get effective language translation for a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>

    public async Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId)
    {
        ApiResponse<Dictionary<string, object>> localVarResponse = await GetLanguagesTranslationsUserAsyncWithHttpInfo(userId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get effective language translation for a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The user id</param>
    /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>

    public async Task<ApiResponse<Dictionary<string, object>>> GetLanguagesTranslationsUserAsyncWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling LanguagesApi->GetLanguagesTranslationsUser");
        }

        var localVarPath = "/api/v2/languages/translations/users/{userId}";
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
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Dictionary<string, object>>(localVarStatusCode,
            localVarHeaders,
            (Dictionary<string, object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, object>)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>Language</returns>
    [Obsolete]
    public Language PostLanguages(Language body)
    {
        ApiResponse<Language> localVarResponse = PostLanguagesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>ApiResponse of Language</returns>
    [Obsolete]
    public ApiResponse<Language> PostLanguagesWithHttpInfo(Language body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LanguagesApi->PostLanguages");
        }

        var localVarPath = "/api/v2/languages";
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
            throw new ApiException(localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Language>(localVarStatusCode,
            localVarHeaders,
            (Language)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>Task of Language</returns>
    [Obsolete]
    public async Task<Language> PostLanguagesAsync(Language body)
    {
        ApiResponse<Language> localVarResponse = await PostLanguagesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create Language (Deprecated) 
    /// This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Language</param>
    /// <returns>Task of ApiResponse (Language)</returns>
    [Obsolete]
    public async Task<ApiResponse<Language>> PostLanguagesAsyncWithHttpInfo(Language body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LanguagesApi->PostLanguages");
        }

        var localVarPath = "/api/v2/languages";
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
            throw new ApiException(localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Language>(localVarStatusCode,
            localVarHeaders,
            (Language)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
