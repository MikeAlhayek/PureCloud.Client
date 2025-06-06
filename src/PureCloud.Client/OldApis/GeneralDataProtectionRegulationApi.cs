using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IGeneralDataProtectionRegulationApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get an existing GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>GDPRRequest</returns>

    GDPRRequest GetGdprRequest(string requestId);

    /// <summary>
    /// Get an existing GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>ApiResponse of GDPRRequest</returns>

    ApiResponse<GDPRRequest> GetGdprRequestWithHttpInfo(string requestId);

    /// <summary>
    /// Get all GDPR requests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>GDPRRequestEntityListing</returns>

    GDPRRequestEntityListing GetGdprRequests(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get all GDPR requests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of GDPRRequestEntityListing</returns>

    ApiResponse<GDPRRequestEntityListing> GetGdprRequestsWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get GDPR subjects
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>GDPRSubjectEntityListing</returns>

    GDPRSubjectEntityListing GetGdprSubjects(string searchType, string searchValue);

    /// <summary>
    /// Get GDPR subjects
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>ApiResponse of GDPRSubjectEntityListing</returns>

    ApiResponse<GDPRSubjectEntityListing> GetGdprSubjectsWithHttpInfo(string searchType, string searchValue);

    /// <summary>
    /// Submit a new GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>GDPRRequest</returns>

    GDPRRequest PostGdprRequests(GDPRRequest body, bool? deleteConfirmed = null);

    /// <summary>
    /// Submit a new GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>ApiResponse of GDPRRequest</returns>

    ApiResponse<GDPRRequest> PostGdprRequestsWithHttpInfo(GDPRRequest body, bool? deleteConfirmed = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get an existing GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>Task of GDPRRequest</returns>

    Task<GDPRRequest> GetGdprRequestAsync(string requestId);

    /// <summary>
    /// Get an existing GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>Task of ApiResponse (GDPRRequest)</returns>

    Task<ApiResponse<GDPRRequest>> GetGdprRequestAsyncWithHttpInfo(string requestId);

    /// <summary>
    /// Get all GDPR requests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of GDPRRequestEntityListing</returns>

    Task<GDPRRequestEntityListing> GetGdprRequestsAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get all GDPR requests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (GDPRRequestEntityListing)</returns>

    Task<ApiResponse<GDPRRequestEntityListing>> GetGdprRequestsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get GDPR subjects
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>Task of GDPRSubjectEntityListing</returns>

    Task<GDPRSubjectEntityListing> GetGdprSubjectsAsync(string searchType, string searchValue);

    /// <summary>
    /// Get GDPR subjects
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>Task of ApiResponse (GDPRSubjectEntityListing)</returns>

    Task<ApiResponse<GDPRSubjectEntityListing>> GetGdprSubjectsAsyncWithHttpInfo(string searchType, string searchValue);

    /// <summary>
    /// Submit a new GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>Task of GDPRRequest</returns>

    Task<GDPRRequest> PostGdprRequestsAsync(GDPRRequest body, bool? deleteConfirmed = null);

    /// <summary>
    /// Submit a new GDPR request
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>Task of ApiResponse (GDPRRequest)</returns>

    Task<ApiResponse<GDPRRequest>> PostGdprRequestsAsyncWithHttpInfo(GDPRRequest body, bool? deleteConfirmed = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class GeneralDataProtectionRegulationApi : IGeneralDataProtectionRegulationApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeneralDataProtectionRegulationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public GeneralDataProtectionRegulationApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeneralDataProtectionRegulationApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public GeneralDataProtectionRegulationApi(Configuration configuration = null)
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
    /// Get an existing GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>GDPRRequest</returns>

    public GDPRRequest GetGdprRequest(string requestId)
    {
        ApiResponse<GDPRRequest> localVarResponse = GetGdprRequestWithHttpInfo(requestId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get an existing GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>ApiResponse of GDPRRequest</returns>

    public ApiResponse<GDPRRequest> GetGdprRequestWithHttpInfo(string requestId)
    {
        // verify the required parameter 'requestId' is set
        if (requestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'requestId' when calling GeneralDataProtectionRegulationApi->GetGdprRequest");
        }

        var localVarPath = "/api/v2/gdpr/requests/{requestId}";
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
        if (requestId != null)
        {
            localVarPathParams.Add("requestId", Configuration.ApiClient.ParameterToString(requestId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRRequest>(localVarStatusCode,
            localVarHeaders,
            (GDPRRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get an existing GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>Task of GDPRRequest</returns>

    public async Task<GDPRRequest> GetGdprRequestAsync(string requestId)
    {
        ApiResponse<GDPRRequest> localVarResponse = await GetGdprRequestAsyncWithHttpInfo(requestId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get an existing GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="requestId">Request id</param>
    /// <returns>Task of ApiResponse (GDPRRequest)</returns>

    public async Task<ApiResponse<GDPRRequest>> GetGdprRequestAsyncWithHttpInfo(string requestId)
    {
        // verify the required parameter 'requestId' is set
        if (requestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'requestId' when calling GeneralDataProtectionRegulationApi->GetGdprRequest");
        }

        var localVarPath = "/api/v2/gdpr/requests/{requestId}";
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
        if (requestId != null)
        {
            localVarPathParams.Add("requestId", Configuration.ApiClient.ParameterToString(requestId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRRequest>(localVarStatusCode,
            localVarHeaders,
            (GDPRRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get all GDPR requests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>GDPRRequestEntityListing</returns>

    public GDPRRequestEntityListing GetGdprRequests(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<GDPRRequestEntityListing> localVarResponse = GetGdprRequestsWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get all GDPR requests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of GDPRRequestEntityListing</returns>

    public ApiResponse<GDPRRequestEntityListing> GetGdprRequestsWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/gdpr/requests";
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
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRRequestEntityListing>(localVarStatusCode,
            localVarHeaders,
            (GDPRRequestEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRRequestEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get all GDPR requests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of GDPRRequestEntityListing</returns>

    public async Task<GDPRRequestEntityListing> GetGdprRequestsAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<GDPRRequestEntityListing> localVarResponse = await GetGdprRequestsAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get all GDPR requests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (GDPRRequestEntityListing)</returns>

    public async Task<ApiResponse<GDPRRequestEntityListing>> GetGdprRequestsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/gdpr/requests";
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
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGdprRequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRRequestEntityListing>(localVarStatusCode,
            localVarHeaders,
            (GDPRRequestEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRRequestEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get GDPR subjects 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>GDPRSubjectEntityListing</returns>

    public GDPRSubjectEntityListing GetGdprSubjects(string searchType, string searchValue)
    {
        ApiResponse<GDPRSubjectEntityListing> localVarResponse = GetGdprSubjectsWithHttpInfo(searchType, searchValue);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get GDPR subjects 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>ApiResponse of GDPRSubjectEntityListing</returns>

    public ApiResponse<GDPRSubjectEntityListing> GetGdprSubjectsWithHttpInfo(string searchType, string searchValue)
    {
        // verify the required parameter 'searchType' is set
        if (searchType == null)
        {
            throw new ApiException(400, "Missing required parameter 'searchType' when calling GeneralDataProtectionRegulationApi->GetGdprSubjects");
        }
        // verify the required parameter 'searchValue' is set
        if (searchValue == null)
        {
            throw new ApiException(400, "Missing required parameter 'searchValue' when calling GeneralDataProtectionRegulationApi->GetGdprSubjects");
        }

        var localVarPath = "/api/v2/gdpr/subjects";
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
        if (searchType != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("searchType", Configuration.ApiClient.ParameterToString(searchType)));
        }

        if (searchValue != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("searchValue", Configuration.ApiClient.ParameterToString(searchValue)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetGdprSubjects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGdprSubjects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRSubjectEntityListing>(localVarStatusCode,
            localVarHeaders,
            (GDPRSubjectEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRSubjectEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get GDPR subjects 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>Task of GDPRSubjectEntityListing</returns>

    public async Task<GDPRSubjectEntityListing> GetGdprSubjectsAsync(string searchType, string searchValue)
    {
        ApiResponse<GDPRSubjectEntityListing> localVarResponse = await GetGdprSubjectsAsyncWithHttpInfo(searchType, searchValue);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get GDPR subjects 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="searchType">Search Type</param>
    /// <param name="searchValue">Search Value</param>
    /// <returns>Task of ApiResponse (GDPRSubjectEntityListing)</returns>

    public async Task<ApiResponse<GDPRSubjectEntityListing>> GetGdprSubjectsAsyncWithHttpInfo(string searchType, string searchValue)
    {
        // verify the required parameter 'searchType' is set
        if (searchType == null)
        {
            throw new ApiException(400, "Missing required parameter 'searchType' when calling GeneralDataProtectionRegulationApi->GetGdprSubjects");
        }

        // verify the required parameter 'searchValue' is set
        if (searchValue == null)
        {
            throw new ApiException(400, "Missing required parameter 'searchValue' when calling GeneralDataProtectionRegulationApi->GetGdprSubjects");
        }

        var localVarPath = "/api/v2/gdpr/subjects";
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
        if (searchType != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("searchType", Configuration.ApiClient.ParameterToString(searchType)));
        }

        if (searchValue != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("searchValue", Configuration.ApiClient.ParameterToString(searchValue)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetGdprSubjects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGdprSubjects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRSubjectEntityListing>(localVarStatusCode,
            localVarHeaders,
            (GDPRSubjectEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRSubjectEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Submit a new GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>GDPRRequest</returns>

    public GDPRRequest PostGdprRequests(GDPRRequest body, bool? deleteConfirmed = null)
    {
        ApiResponse<GDPRRequest> localVarResponse = PostGdprRequestsWithHttpInfo(body, deleteConfirmed);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Submit a new GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>ApiResponse of GDPRRequest</returns>

    public ApiResponse<GDPRRequest> PostGdprRequestsWithHttpInfo(GDPRRequest body, bool? deleteConfirmed = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling GeneralDataProtectionRegulationApi->PostGdprRequests");
        }

        var localVarPath = "/api/v2/gdpr/requests";
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
        if (deleteConfirmed != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("deleteConfirmed", Configuration.ApiClient.ParameterToString(deleteConfirmed)));
        }

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
            throw new ApiException(localVarStatusCode, "Error calling PostGdprRequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGdprRequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRRequest>(localVarStatusCode,
            localVarHeaders,
            (GDPRRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Submit a new GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>Task of GDPRRequest</returns>

    public async Task<GDPRRequest> PostGdprRequestsAsync(GDPRRequest body, bool? deleteConfirmed = null)
    {
        ApiResponse<GDPRRequest> localVarResponse = await PostGdprRequestsAsyncWithHttpInfo(body, deleteConfirmed);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Submit a new GDPR request 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">GDPR request</param>
    /// <param name="deleteConfirmed">Confirm delete (optional, default to false)</param>
    /// <returns>Task of ApiResponse (GDPRRequest)</returns>

    public async Task<ApiResponse<GDPRRequest>> PostGdprRequestsAsyncWithHttpInfo(GDPRRequest body, bool? deleteConfirmed = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling GeneralDataProtectionRegulationApi->PostGdprRequests");
        }

        var localVarPath = "/api/v2/gdpr/requests";
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
        if (deleteConfirmed != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("deleteConfirmed", Configuration.ApiClient.ParameterToString(deleteConfirmed)));
        }

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
            throw new ApiException(localVarStatusCode, "Error calling PostGdprRequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGdprRequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GDPRRequest>(localVarStatusCode,
            localVarHeaders,
            (GDPRRequest)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GDPRRequest)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
