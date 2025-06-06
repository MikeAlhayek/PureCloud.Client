using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDownloadsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download
    /// </summary>
    /// <remarks>
    /// this method will issue a redirect to the url to the content
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>UrlResponse</returns>

    UrlResponse GetDownload(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null);

    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download
    /// </summary>
    /// <remarks>
    /// this method will issue a redirect to the url to the content
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>ApiResponse of UrlResponse</returns>

    ApiResponse<UrlResponse> GetDownloadWithHttpInfo(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download
    /// </summary>
    /// <remarks>
    /// this method will issue a redirect to the url to the content
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>Task of UrlResponse</returns>

    Task<UrlResponse> GetDownloadAsync(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null);

    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download
    /// </summary>
    /// <remarks>
    /// this method will issue a redirect to the url to the content
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>Task of ApiResponse (UrlResponse)</returns>

    Task<ApiResponse<UrlResponse>> GetDownloadAsyncWithHttpInfo(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class DownloadsApi : IDownloadsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DownloadsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public DownloadsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DownloadsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public DownloadsApi(Configuration configuration = null)
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
    /// Issues a redirect to a signed secure download URL for specified download 
    /// this method will issue a redirect to the url to the content
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>UrlResponse</returns>

    public UrlResponse GetDownload(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null)
    {
        ApiResponse<UrlResponse> localVarResponse = GetDownloadWithHttpInfo(downloadId, contentDisposition, issueRedirect, redirectToAuth);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download 
    /// this method will issue a redirect to the url to the content
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>ApiResponse of UrlResponse</returns>

    public ApiResponse<UrlResponse> GetDownloadWithHttpInfo(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null)
    {
        // verify the required parameter 'downloadId' is set
        if (downloadId == null)
        {
            throw new ApiException(400, "Missing required parameter 'downloadId' when calling DownloadsApi->GetDownload");
        }

        var localVarPath = "/api/v2/downloads/{downloadId}";
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
        if (downloadId != null)
        {
            localVarPathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId));
        }

        // Query params
        if (contentDisposition != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("contentDisposition", Configuration.ApiClient.ParameterToString(contentDisposition)));
        }

        if (issueRedirect != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("issueRedirect", Configuration.ApiClient.ParameterToString(issueRedirect)));
        }

        if (redirectToAuth != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("redirectToAuth", Configuration.ApiClient.ParameterToString(redirectToAuth)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDownload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download 
    /// this method will issue a redirect to the url to the content
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>Task of UrlResponse</returns>

    public async Task<UrlResponse> GetDownloadAsync(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null)
    {
        ApiResponse<UrlResponse> localVarResponse = await GetDownloadAsyncWithHttpInfo(downloadId, contentDisposition, issueRedirect, redirectToAuth);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Issues a redirect to a signed secure download URL for specified download 
    /// this method will issue a redirect to the url to the content
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="downloadId">Download ID</param>
    /// <param name="contentDisposition"> (optional)</param>
    /// <param name="issueRedirect"> (optional, default to true)</param>
    /// <param name="redirectToAuth"> (optional, default to true)</param>
    /// <returns>Task of ApiResponse (UrlResponse)</returns>

    public async Task<ApiResponse<UrlResponse>> GetDownloadAsyncWithHttpInfo(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null)
    {
        // verify the required parameter 'downloadId' is set
        if (downloadId == null)
        {
            throw new ApiException(400, "Missing required parameter 'downloadId' when calling DownloadsApi->GetDownload");
        }

        var localVarPath = "/api/v2/downloads/{downloadId}";
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
        if (downloadId != null)
        {
            localVarPathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId));
        }

        // Query params
        if (contentDisposition != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("contentDisposition", Configuration.ApiClient.ParameterToString(contentDisposition)));
        }

        if (issueRedirect != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("issueRedirect", Configuration.ApiClient.ParameterToString(issueRedirect)));
        }

        if (redirectToAuth != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("redirectToAuth", Configuration.ApiClient.ParameterToString(redirectToAuth)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDownload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
