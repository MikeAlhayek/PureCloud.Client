using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IFaxApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns></returns>

    void DeleteFaxDocument(string documentId);

    /// <summary>
    /// Delete a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteFaxDocumentWithHttpInfo(string documentId);

    /// <summary>
    /// Get a document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>FaxDocument</returns>

    FaxDocument GetFaxDocument(string documentId);

    /// <summary>
    /// Get a document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>ApiResponse of FaxDocument</returns>

    ApiResponse<FaxDocument> GetFaxDocumentWithHttpInfo(string documentId);

    /// <summary>
    /// Download a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>DownloadResponse</returns>

    DownloadResponse GetFaxDocumentContent(string documentId);

    /// <summary>
    /// Download a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>ApiResponse of DownloadResponse</returns>

    ApiResponse<DownloadResponse> GetFaxDocumentContentWithHttpInfo(string documentId);

    /// <summary>
    /// Get a list of fax documents.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>FaxDocumentEntityListing</returns>

    FaxDocumentEntityListing GetFaxDocuments(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of fax documents.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of FaxDocumentEntityListing</returns>

    ApiResponse<FaxDocumentEntityListing> GetFaxDocumentsWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>FaxConfig</returns>

    FaxConfig GetFaxSettings();

    /// <summary>
    /// Get organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of FaxConfig</returns>

    ApiResponse<FaxConfig> GetFaxSettingsWithHttpInfo();

    /// <summary>
    /// Get fax summary
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>FaxSummary</returns>

    FaxSummary GetFaxSummary();

    /// <summary>
    /// Get fax summary
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of FaxSummary</returns>

    ApiResponse<FaxSummary> GetFaxSummaryWithHttpInfo();

    /// <summary>
    /// Update a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>FaxDocument</returns>

    FaxDocument PutFaxDocument(string documentId, FaxDocument body);

    /// <summary>
    /// Update a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>ApiResponse of FaxDocument</returns>

    ApiResponse<FaxDocument> PutFaxDocumentWithHttpInfo(string documentId, FaxDocument body);

    /// <summary>
    /// Update/write organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>FaxConfig</returns>

    FaxConfig PutFaxSettings(FaxConfig body = null);

    /// <summary>
    /// Update/write organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of FaxConfig</returns>

    ApiResponse<FaxConfig> PutFaxSettingsWithHttpInfo(FaxConfig body = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of void</returns>

    Task DeleteFaxDocumentAsync(string documentId);

    /// <summary>
    /// Delete a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteFaxDocumentAsyncWithHttpInfo(string documentId);

    /// <summary>
    /// Get a document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of FaxDocument</returns>

    Task<FaxDocument> GetFaxDocumentAsync(string documentId);

    /// <summary>
    /// Get a document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of ApiResponse (FaxDocument)</returns>

    Task<ApiResponse<FaxDocument>> GetFaxDocumentAsyncWithHttpInfo(string documentId);

    /// <summary>
    /// Download a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of DownloadResponse</returns>

    Task<DownloadResponse> GetFaxDocumentContentAsync(string documentId);

    /// <summary>
    /// Download a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of ApiResponse (DownloadResponse)</returns>

    Task<ApiResponse<DownloadResponse>> GetFaxDocumentContentAsyncWithHttpInfo(string documentId);

    /// <summary>
    /// Get a list of fax documents.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of FaxDocumentEntityListing</returns>

    Task<FaxDocumentEntityListing> GetFaxDocumentsAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of fax documents.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>

    Task<ApiResponse<FaxDocumentEntityListing>> GetFaxDocumentsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of FaxConfig</returns>

    Task<FaxConfig> GetFaxSettingsAsync();

    /// <summary>
    /// Get organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (FaxConfig)</returns>

    Task<ApiResponse<FaxConfig>> GetFaxSettingsAsyncWithHttpInfo();

    /// <summary>
    /// Get fax summary
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of FaxSummary</returns>

    Task<FaxSummary> GetFaxSummaryAsync();

    /// <summary>
    /// Get fax summary
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (FaxSummary)</returns>

    Task<ApiResponse<FaxSummary>> GetFaxSummaryAsyncWithHttpInfo();

    /// <summary>
    /// Update a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>Task of FaxDocument</returns>

    Task<FaxDocument> PutFaxDocumentAsync(string documentId, FaxDocument body);

    /// <summary>
    /// Update a fax document.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>Task of ApiResponse (FaxDocument)</returns>

    Task<ApiResponse<FaxDocument>> PutFaxDocumentAsyncWithHttpInfo(string documentId, FaxDocument body);

    /// <summary>
    /// Update/write organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of FaxConfig</returns>

    Task<FaxConfig> PutFaxSettingsAsync(FaxConfig body = null);

    /// <summary>
    /// Update/write organization config for given organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (FaxConfig)</returns>

    Task<ApiResponse<FaxConfig>> PutFaxSettingsAsyncWithHttpInfo(FaxConfig body = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class FaxApi : IFaxApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxApi"/> class.
    /// </summary>
    /// <returns></returns>
    public FaxApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FaxApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public FaxApi(Configuration configuration = null)
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
    /// Delete a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns></returns>

    public void DeleteFaxDocument(string documentId)
    {
        DeleteFaxDocumentWithHttpInfo(documentId);
    }

    /// <summary>
    /// Delete a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteFaxDocumentWithHttpInfo(string documentId)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->DeleteFaxDocument");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteFaxDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteFaxDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteFaxDocumentAsync(string documentId)
    {
        await DeleteFaxDocumentAsyncWithHttpInfo(documentId);

    }

    /// <summary>
    /// Delete a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteFaxDocumentAsyncWithHttpInfo(string documentId)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->DeleteFaxDocument");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteFaxDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteFaxDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>FaxDocument</returns>

    public FaxDocument GetFaxDocument(string documentId)
    {
        ApiResponse<FaxDocument> localVarResponse = GetFaxDocumentWithHttpInfo(documentId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>ApiResponse of FaxDocument</returns>

    public ApiResponse<FaxDocument> GetFaxDocumentWithHttpInfo(string documentId)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetFaxDocument");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxDocument>(localVarStatusCode,
            localVarHeaders,
            (FaxDocument)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of FaxDocument</returns>

    public async Task<FaxDocument> GetFaxDocumentAsync(string documentId)
    {
        ApiResponse<FaxDocument> localVarResponse = await GetFaxDocumentAsyncWithHttpInfo(documentId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of ApiResponse (FaxDocument)</returns>

    public async Task<ApiResponse<FaxDocument>> GetFaxDocumentAsyncWithHttpInfo(string documentId)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetFaxDocument");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxDocument>(localVarStatusCode,
            localVarHeaders,
            (FaxDocument)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Download a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>DownloadResponse</returns>

    public DownloadResponse GetFaxDocumentContent(string documentId)
    {
        ApiResponse<DownloadResponse> localVarResponse = GetFaxDocumentContentWithHttpInfo(documentId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Download a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>ApiResponse of DownloadResponse</returns>

    public ApiResponse<DownloadResponse> GetFaxDocumentContentWithHttpInfo(string documentId)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetFaxDocumentContent");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}/content";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocumentContent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocumentContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<DownloadResponse>(localVarStatusCode,
            localVarHeaders,
            (DownloadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Download a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of DownloadResponse</returns>

    public async Task<DownloadResponse> GetFaxDocumentContentAsync(string documentId)
    {
        ApiResponse<DownloadResponse> localVarResponse = await GetFaxDocumentContentAsyncWithHttpInfo(documentId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Download a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <returns>Task of ApiResponse (DownloadResponse)</returns>

    public async Task<ApiResponse<DownloadResponse>> GetFaxDocumentContentAsyncWithHttpInfo(string documentId)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetFaxDocumentContent");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}/content";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocumentContent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocumentContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<DownloadResponse>(localVarStatusCode,
            localVarHeaders,
            (DownloadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a list of fax documents. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>FaxDocumentEntityListing</returns>

    public FaxDocumentEntityListing GetFaxDocuments(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<FaxDocumentEntityListing> localVarResponse = GetFaxDocumentsWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of fax documents. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of FaxDocumentEntityListing</returns>

    public ApiResponse<FaxDocumentEntityListing> GetFaxDocumentsWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/fax/documents";
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxDocumentEntityListing>(localVarStatusCode,
            localVarHeaders,
            (FaxDocumentEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocumentEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a list of fax documents. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of FaxDocumentEntityListing</returns>

    public async Task<FaxDocumentEntityListing> GetFaxDocumentsAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<FaxDocumentEntityListing> localVarResponse = await GetFaxDocumentsAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a list of fax documents. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>

    public async Task<ApiResponse<FaxDocumentEntityListing>> GetFaxDocumentsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/fax/documents";
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxDocumentEntityListing>(localVarStatusCode,
            localVarHeaders,
            (FaxDocumentEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocumentEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>FaxConfig</returns>

    public FaxConfig GetFaxSettings()
    {
        ApiResponse<FaxConfig> localVarResponse = GetFaxSettingsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of FaxConfig</returns>

    public ApiResponse<FaxConfig> GetFaxSettingsWithHttpInfo()
    {

        var localVarPath = "/api/v2/fax/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxConfig>(localVarStatusCode,
            localVarHeaders,
            (FaxConfig)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxConfig)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of FaxConfig</returns>

    public async Task<FaxConfig> GetFaxSettingsAsync()
    {
        ApiResponse<FaxConfig> localVarResponse = await GetFaxSettingsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (FaxConfig)</returns>

    public async Task<ApiResponse<FaxConfig>> GetFaxSettingsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/fax/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxConfig>(localVarStatusCode,
            localVarHeaders,
            (FaxConfig)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxConfig)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get fax summary 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>FaxSummary</returns>

    public FaxSummary GetFaxSummary()
    {
        ApiResponse<FaxSummary> localVarResponse = GetFaxSummaryWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get fax summary 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of FaxSummary</returns>

    public ApiResponse<FaxSummary> GetFaxSummaryWithHttpInfo()
    {

        var localVarPath = "/api/v2/fax/summary";
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxSummary>(localVarStatusCode,
            localVarHeaders,
            (FaxSummary)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get fax summary 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of FaxSummary</returns>

    public async Task<FaxSummary> GetFaxSummaryAsync()
    {
        ApiResponse<FaxSummary> localVarResponse = await GetFaxSummaryAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get fax summary 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (FaxSummary)</returns>

    public async Task<ApiResponse<FaxSummary>> GetFaxSummaryAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/fax/summary";
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
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetFaxSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxSummary>(localVarStatusCode,
            localVarHeaders,
            (FaxSummary)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>FaxDocument</returns>

    public FaxDocument PutFaxDocument(string documentId, FaxDocument body)
    {
        ApiResponse<FaxDocument> localVarResponse = PutFaxDocumentWithHttpInfo(documentId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>ApiResponse of FaxDocument</returns>

    public ApiResponse<FaxDocument> PutFaxDocumentWithHttpInfo(string documentId, FaxDocument body)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->PutFaxDocument");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FaxApi->PutFaxDocument");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
        }

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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutFaxDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutFaxDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxDocument>(localVarStatusCode,
            localVarHeaders,
            (FaxDocument)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>Task of FaxDocument</returns>

    public async Task<FaxDocument> PutFaxDocumentAsync(string documentId, FaxDocument body)
    {
        ApiResponse<FaxDocument> localVarResponse = await PutFaxDocumentAsyncWithHttpInfo(documentId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a fax document. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Document</param>
    /// <returns>Task of ApiResponse (FaxDocument)</returns>

    public async Task<ApiResponse<FaxDocument>> PutFaxDocumentAsyncWithHttpInfo(string documentId, FaxDocument body)
    {
        // verify the required parameter 'documentId' is set
        if (documentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->PutFaxDocument");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FaxApi->PutFaxDocument");
        }

        var localVarPath = "/api/v2/fax/documents/{documentId}";
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
        if (documentId != null)
        {
            localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId));
        }

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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutFaxDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutFaxDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxDocument>(localVarStatusCode,
            localVarHeaders,
            (FaxDocument)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update/write organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>FaxConfig</returns>

    public FaxConfig PutFaxSettings(FaxConfig body = null)
    {
        ApiResponse<FaxConfig> localVarResponse = PutFaxSettingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update/write organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of FaxConfig</returns>

    public ApiResponse<FaxConfig> PutFaxSettingsWithHttpInfo(FaxConfig body = null)
    {

        var localVarPath = "/api/v2/fax/settings";
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutFaxSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutFaxSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxConfig>(localVarStatusCode,
            localVarHeaders,
            (FaxConfig)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxConfig)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update/write organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of FaxConfig</returns>

    public async Task<FaxConfig> PutFaxSettingsAsync(FaxConfig body = null)
    {
        ApiResponse<FaxConfig> localVarResponse = await PutFaxSettingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update/write organization config for given organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (FaxConfig)</returns>

    public async Task<ApiResponse<FaxConfig>> PutFaxSettingsAsyncWithHttpInfo(FaxConfig body = null)
    {

        var localVarPath = "/api/v2/fax/settings";
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutFaxSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutFaxSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FaxConfig>(localVarStatusCode,
            localVarHeaders,
            (FaxConfig)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxConfig)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
