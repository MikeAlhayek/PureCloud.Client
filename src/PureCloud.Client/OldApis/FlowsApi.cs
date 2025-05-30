using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IFlowsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get status for async query for Flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>AsyncQueryStatus</returns>

    AsyncQueryStatus GetAnalyticsFlowsAggregatesJob(string jobId);

    /// <summary>
    /// Get status for async query for Flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>ApiResponse of AsyncQueryStatus</returns>

    ApiResponse<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobWithHttpInfo(string jobId);

    /// <summary>
    /// Fetch a page of results for an async aggregates query
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>FlowAsyncAggregateQueryResponse</returns>

    FlowAsyncAggregateQueryResponse GetAnalyticsFlowsAggregatesJobResults(string jobId, string cursor = null);

    /// <summary>
    /// Fetch a page of results for an async aggregates query
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>ApiResponse of FlowAsyncAggregateQueryResponse</returns>

    ApiResponse<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsWithHttpInfo(string jobId, string cursor = null);

    /// <summary>
    /// Query for flow activity observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>FlowActivityResponse</returns>

    FlowActivityResponse PostAnalyticsFlowsActivityQuery(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Query for flow activity observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>ApiResponse of FlowActivityResponse</returns>

    ApiResponse<FlowActivityResponse> PostAnalyticsFlowsActivityQueryWithHttpInfo(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Query for flow aggregates asynchronously
    /// </summary>
    /// <remarks>
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>AsyncQueryResponse</returns>

    AsyncQueryResponse PostAnalyticsFlowsAggregatesJobs(FlowAsyncAggregationQuery body);

    /// <summary>
    /// Query for flow aggregates asynchronously
    /// </summary>
    /// <remarks>
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of AsyncQueryResponse</returns>

    ApiResponse<AsyncQueryResponse> PostAnalyticsFlowsAggregatesJobsWithHttpInfo(FlowAsyncAggregationQuery body);

    /// <summary>
    /// Query for flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>FlowAggregateQueryResponse</returns>

    FlowAggregateQueryResponse PostAnalyticsFlowsAggregatesQuery(FlowAggregationQuery body);

    /// <summary>
    /// Query for flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of FlowAggregateQueryResponse</returns>

    ApiResponse<FlowAggregateQueryResponse> PostAnalyticsFlowsAggregatesQueryWithHttpInfo(FlowAggregationQuery body);

    /// <summary>
    /// Query for flow observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>FlowObservationQueryResponse</returns>

    FlowObservationQueryResponse PostAnalyticsFlowsObservationsQuery(FlowObservationQuery body);

    /// <summary>
    /// Query for flow observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of FlowObservationQueryResponse</returns>

    ApiResponse<FlowObservationQueryResponse> PostAnalyticsFlowsObservationsQueryWithHttpInfo(FlowObservationQuery body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get status for async query for Flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>Task of AsyncQueryStatus</returns>

    Task<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobAsync(string jobId);

    /// <summary>
    /// Get status for async query for Flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>

    Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsFlowsAggregatesJobAsyncWithHttpInfo(string jobId);

    /// <summary>
    /// Fetch a page of results for an async aggregates query
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>Task of FlowAsyncAggregateQueryResponse</returns>

    Task<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsAsync(string jobId, string cursor = null);

    /// <summary>
    /// Fetch a page of results for an async aggregates query
    /// </summary>
    /// <remarks>
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>Task of ApiResponse (FlowAsyncAggregateQueryResponse)</returns>

    Task<ApiResponse<FlowAsyncAggregateQueryResponse>> GetAnalyticsFlowsAggregatesJobResultsAsyncWithHttpInfo(string jobId, string cursor = null);

    /// <summary>
    /// Query for flow activity observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>Task of FlowActivityResponse</returns>

    Task<FlowActivityResponse> PostAnalyticsFlowsActivityQueryAsync(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Query for flow activity observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>Task of ApiResponse (FlowActivityResponse)</returns>

    Task<ApiResponse<FlowActivityResponse>> PostAnalyticsFlowsActivityQueryAsyncWithHttpInfo(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Query for flow aggregates asynchronously
    /// </summary>
    /// <remarks>
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of AsyncQueryResponse</returns>

    Task<AsyncQueryResponse> PostAnalyticsFlowsAggregatesJobsAsync(FlowAsyncAggregationQuery body);

    /// <summary>
    /// Query for flow aggregates asynchronously
    /// </summary>
    /// <remarks>
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>

    Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsFlowsAggregatesJobsAsyncWithHttpInfo(FlowAsyncAggregationQuery body);

    /// <summary>
    /// Query for flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of FlowAggregateQueryResponse</returns>

    Task<FlowAggregateQueryResponse> PostAnalyticsFlowsAggregatesQueryAsync(FlowAggregationQuery body);

    /// <summary>
    /// Query for flow aggregates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (FlowAggregateQueryResponse)</returns>

    Task<ApiResponse<FlowAggregateQueryResponse>> PostAnalyticsFlowsAggregatesQueryAsyncWithHttpInfo(FlowAggregationQuery body);

    /// <summary>
    /// Query for flow observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of FlowObservationQueryResponse</returns>

    Task<FlowObservationQueryResponse> PostAnalyticsFlowsObservationsQueryAsync(FlowObservationQuery body);

    /// <summary>
    /// Query for flow observations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (FlowObservationQueryResponse)</returns>

    Task<ApiResponse<FlowObservationQueryResponse>> PostAnalyticsFlowsObservationsQueryAsyncWithHttpInfo(FlowObservationQuery body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class FlowsApi : IFlowsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public FlowsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public FlowsApi(Configuration configuration = null)
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
    /// Get status for async query for Flow aggregates 
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>AsyncQueryStatus</returns>

    public AsyncQueryStatus GetAnalyticsFlowsAggregatesJob(string jobId)
    {
        ApiResponse<AsyncQueryStatus> localVarResponse = GetAnalyticsFlowsAggregatesJobWithHttpInfo(jobId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get status for async query for Flow aggregates 
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>ApiResponse of AsyncQueryStatus</returns>

    public ApiResponse<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobWithHttpInfo(string jobId)
    {
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling FlowsApi->GetAnalyticsFlowsAggregatesJob");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/jobs/{jobId}";
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
        if (jobId != null)
        {
            localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
            localVarHeaders,
            (AsyncQueryStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get status for async query for Flow aggregates 
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>Task of AsyncQueryStatus</returns>

    public async Task<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobAsync(string jobId)
    {
        ApiResponse<AsyncQueryStatus> localVarResponse = await GetAnalyticsFlowsAggregatesJobAsyncWithHttpInfo(jobId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get status for async query for Flow aggregates 
    /// 
    /// GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>

    public async Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsFlowsAggregatesJobAsyncWithHttpInfo(string jobId)
    {
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling FlowsApi->GetAnalyticsFlowsAggregatesJob");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/jobs/{jobId}";
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
        if (jobId != null)
        {
            localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
            localVarHeaders,
            (AsyncQueryStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Fetch a page of results for an async aggregates query 
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>FlowAsyncAggregateQueryResponse</returns>

    public FlowAsyncAggregateQueryResponse GetAnalyticsFlowsAggregatesJobResults(string jobId, string cursor = null)
    {
        ApiResponse<FlowAsyncAggregateQueryResponse> localVarResponse = GetAnalyticsFlowsAggregatesJobResultsWithHttpInfo(jobId, cursor);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Fetch a page of results for an async aggregates query 
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>ApiResponse of FlowAsyncAggregateQueryResponse</returns>

    public ApiResponse<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsWithHttpInfo(string jobId, string cursor = null)
    {
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling FlowsApi->GetAnalyticsFlowsAggregatesJobResults");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/jobs/{jobId}/results";
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
        if (jobId != null)
        {
            localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId));
        }

        // Query params
        if (cursor != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("cursor", Configuration.ApiClient.ParameterToString(cursor)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowAsyncAggregateQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowAsyncAggregateQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowAsyncAggregateQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Fetch a page of results for an async aggregates query 
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>Task of FlowAsyncAggregateQueryResponse</returns>

    public async Task<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsAsync(string jobId, string cursor = null)
    {
        ApiResponse<FlowAsyncAggregateQueryResponse> localVarResponse = await GetAnalyticsFlowsAggregatesJobResultsAsyncWithHttpInfo(jobId, cursor);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Fetch a page of results for an async aggregates query 
    /// 
    /// GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">jobId</param>
    /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
    /// <returns>Task of ApiResponse (FlowAsyncAggregateQueryResponse)</returns>

    public async Task<ApiResponse<FlowAsyncAggregateQueryResponse>> GetAnalyticsFlowsAggregatesJobResultsAsyncWithHttpInfo(string jobId, string cursor = null)
    {
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling FlowsApi->GetAnalyticsFlowsAggregatesJobResults");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/jobs/{jobId}/results";
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
        if (jobId != null)
        {
            localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId));
        }

        // Query params
        if (cursor != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("cursor", Configuration.ApiClient.ParameterToString(cursor)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAnalyticsFlowsAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowAsyncAggregateQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowAsyncAggregateQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowAsyncAggregateQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Query for flow activity observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>FlowActivityResponse</returns>

    public FlowActivityResponse PostAnalyticsFlowsActivityQuery(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<FlowActivityResponse> localVarResponse = PostAnalyticsFlowsActivityQueryWithHttpInfo(body, pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Query for flow activity observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>ApiResponse of FlowActivityResponse</returns>

    public ApiResponse<FlowActivityResponse> PostAnalyticsFlowsActivityQueryWithHttpInfo(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsActivityQuery");
        }

        var localVarPath = "/api/v2/analytics/flows/activity/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsActivityQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsActivityQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowActivityResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowActivityResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowActivityResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Query for flow activity observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>Task of FlowActivityResponse</returns>

    public async Task<FlowActivityResponse> PostAnalyticsFlowsActivityQueryAsync(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<FlowActivityResponse> localVarResponse = await PostAnalyticsFlowsActivityQueryAsyncWithHttpInfo(body, pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Query for flow activity observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <param name="pageSize">The desired page size (optional)</param>
    /// <param name="pageNumber">The desired page number (optional)</param>
    /// <returns>Task of ApiResponse (FlowActivityResponse)</returns>

    public async Task<ApiResponse<FlowActivityResponse>> PostAnalyticsFlowsActivityQueryAsyncWithHttpInfo(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsActivityQuery");
        }

        var localVarPath = "/api/v2/analytics/flows/activity/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsActivityQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsActivityQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowActivityResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowActivityResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowActivityResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Query for flow aggregates asynchronously 
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>AsyncQueryResponse</returns>

    public AsyncQueryResponse PostAnalyticsFlowsAggregatesJobs(FlowAsyncAggregationQuery body)
    {
        ApiResponse<AsyncQueryResponse> localVarResponse = PostAnalyticsFlowsAggregatesJobsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Query for flow aggregates asynchronously 
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of AsyncQueryResponse</returns>

    public ApiResponse<AsyncQueryResponse> PostAnalyticsFlowsAggregatesJobsWithHttpInfo(FlowAsyncAggregationQuery body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsAggregatesJobs");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/jobs";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (AsyncQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Query for flow aggregates asynchronously 
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of AsyncQueryResponse</returns>

    public async Task<AsyncQueryResponse> PostAnalyticsFlowsAggregatesJobsAsync(FlowAsyncAggregationQuery body)
    {
        ApiResponse<AsyncQueryResponse> localVarResponse = await PostAnalyticsFlowsAggregatesJobsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Query for flow aggregates asynchronously 
    /// 
    /// PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>

    public async Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsFlowsAggregatesJobsAsyncWithHttpInfo(FlowAsyncAggregationQuery body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsAggregatesJobs");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/jobs";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (AsyncQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Query for flow aggregates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>FlowAggregateQueryResponse</returns>

    public FlowAggregateQueryResponse PostAnalyticsFlowsAggregatesQuery(FlowAggregationQuery body)
    {
        ApiResponse<FlowAggregateQueryResponse> localVarResponse = PostAnalyticsFlowsAggregatesQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Query for flow aggregates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of FlowAggregateQueryResponse</returns>

    public ApiResponse<FlowAggregateQueryResponse> PostAnalyticsFlowsAggregatesQueryWithHttpInfo(FlowAggregationQuery body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsAggregatesQuery");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowAggregateQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowAggregateQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowAggregateQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Query for flow aggregates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of FlowAggregateQueryResponse</returns>

    public async Task<FlowAggregateQueryResponse> PostAnalyticsFlowsAggregatesQueryAsync(FlowAggregationQuery body)
    {
        ApiResponse<FlowAggregateQueryResponse> localVarResponse = await PostAnalyticsFlowsAggregatesQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Query for flow aggregates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (FlowAggregateQueryResponse)</returns>

    public async Task<ApiResponse<FlowAggregateQueryResponse>> PostAnalyticsFlowsAggregatesQueryAsyncWithHttpInfo(FlowAggregationQuery body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsAggregatesQuery");
        }

        var localVarPath = "/api/v2/analytics/flows/aggregates/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowAggregateQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowAggregateQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowAggregateQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Query for flow observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>FlowObservationQueryResponse</returns>

    public FlowObservationQueryResponse PostAnalyticsFlowsObservationsQuery(FlowObservationQuery body)
    {
        ApiResponse<FlowObservationQueryResponse> localVarResponse = PostAnalyticsFlowsObservationsQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Query for flow observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of FlowObservationQueryResponse</returns>

    public ApiResponse<FlowObservationQueryResponse> PostAnalyticsFlowsObservationsQueryWithHttpInfo(FlowObservationQuery body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsObservationsQuery");
        }

        var localVarPath = "/api/v2/analytics/flows/observations/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsObservationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowObservationQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowObservationQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowObservationQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Query for flow observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of FlowObservationQueryResponse</returns>

    public async Task<FlowObservationQueryResponse> PostAnalyticsFlowsObservationsQueryAsync(FlowObservationQuery body)
    {
        ApiResponse<FlowObservationQueryResponse> localVarResponse = await PostAnalyticsFlowsObservationsQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Query for flow observations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (FlowObservationQueryResponse)</returns>

    public async Task<ApiResponse<FlowObservationQueryResponse>> PostAnalyticsFlowsObservationsQueryAsyncWithHttpInfo(FlowObservationQuery body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling FlowsApi->PostAnalyticsFlowsObservationsQuery");
        }

        var localVarPath = "/api/v2/analytics/flows/observations/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsObservationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsFlowsObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FlowObservationQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (FlowObservationQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowObservationQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
