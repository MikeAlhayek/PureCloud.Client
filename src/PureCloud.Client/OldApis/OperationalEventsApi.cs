using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOperationalEventsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get an operational event definition by its id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>EventDefinition</returns>

    EventDefinition GetUsageEventsDefinition(string eventDefinitionId);

    /// <summary>
    /// Get an operational event definition by its id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>ApiResponse of EventDefinition</returns>

    ApiResponse<EventDefinition> GetUsageEventsDefinitionWithHttpInfo(string eventDefinitionId);

    /// <summary>
    /// Get all operational event definitions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>EventDefinitionListing</returns>

    EventDefinitionListing GetUsageEventsDefinitions();

    /// <summary>
    /// Get all operational event definitions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of EventDefinitionListing</returns>

    ApiResponse<EventDefinitionListing> GetUsageEventsDefinitionsWithHttpInfo();

    /// <summary>
    /// Get aggregates for operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>EventAggregatesResponse</returns>

    EventAggregatesResponse PostUsageEventsAggregatesQuery(EventAggregatesQueryRequest body = null);

    /// <summary>
    /// Get aggregates for operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of EventAggregatesResponse</returns>

    ApiResponse<EventAggregatesResponse> PostUsageEventsAggregatesQueryWithHttpInfo(EventAggregatesQueryRequest body = null);

    /// <summary>
    /// Query operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>EventQueryResponse</returns>

    EventQueryResponse PostUsageEventsQuery(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null);

    /// <summary>
    /// Query operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of EventQueryResponse</returns>

    ApiResponse<EventQueryResponse> PostUsageEventsQueryWithHttpInfo(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get an operational event definition by its id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>Task of EventDefinition</returns>

    Task<EventDefinition> GetUsageEventsDefinitionAsync(string eventDefinitionId);

    /// <summary>
    /// Get an operational event definition by its id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>Task of ApiResponse (EventDefinition)</returns>

    Task<ApiResponse<EventDefinition>> GetUsageEventsDefinitionAsyncWithHttpInfo(string eventDefinitionId);

    /// <summary>
    /// Get all operational event definitions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of EventDefinitionListing</returns>

    Task<EventDefinitionListing> GetUsageEventsDefinitionsAsync();

    /// <summary>
    /// Get all operational event definitions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (EventDefinitionListing)</returns>

    Task<ApiResponse<EventDefinitionListing>> GetUsageEventsDefinitionsAsyncWithHttpInfo();

    /// <summary>
    /// Get aggregates for operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of EventAggregatesResponse</returns>

    Task<EventAggregatesResponse> PostUsageEventsAggregatesQueryAsync(EventAggregatesQueryRequest body = null);

    /// <summary>
    /// Get aggregates for operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (EventAggregatesResponse)</returns>

    Task<ApiResponse<EventAggregatesResponse>> PostUsageEventsAggregatesQueryAsyncWithHttpInfo(EventAggregatesQueryRequest body = null);

    /// <summary>
    /// Query operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of EventQueryResponse</returns>

    Task<EventQueryResponse> PostUsageEventsQueryAsync(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null);

    /// <summary>
    /// Query operational events in a timeframe.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (EventQueryResponse)</returns>

    Task<ApiResponse<EventQueryResponse>> PostUsageEventsQueryAsyncWithHttpInfo(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class OperationalEventsApi : IOperationalEventsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OperationalEventsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OperationalEventsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OperationalEventsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public OperationalEventsApi(Configuration configuration = null)
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
    /// Get an operational event definition by its id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>EventDefinition</returns>

    public EventDefinition GetUsageEventsDefinition(string eventDefinitionId)
    {
        ApiResponse<EventDefinition> localVarResponse = GetUsageEventsDefinitionWithHttpInfo(eventDefinitionId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get an operational event definition by its id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>ApiResponse of EventDefinition</returns>

    public ApiResponse<EventDefinition> GetUsageEventsDefinitionWithHttpInfo(string eventDefinitionId)
    {
        // verify the required parameter 'eventDefinitionId' is set
        if (eventDefinitionId == null)
        {
            throw new ApiException(400, "Missing required parameter 'eventDefinitionId' when calling OperationalEventsApi->GetUsageEventsDefinition");
        }

        var localVarPath = "/api/v2/usage/events/definitions/{eventDefinitionId}";
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
        if (eventDefinitionId != null)
        {
            localVarPathParams.Add("eventDefinitionId", Configuration.ApiClient.ParameterToString(eventDefinitionId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventDefinition>(localVarStatusCode,
            localVarHeaders,
            (EventDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get an operational event definition by its id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>Task of EventDefinition</returns>

    public async Task<EventDefinition> GetUsageEventsDefinitionAsync(string eventDefinitionId)
    {
        ApiResponse<EventDefinition> localVarResponse = await GetUsageEventsDefinitionAsyncWithHttpInfo(eventDefinitionId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get an operational event definition by its id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <returns>Task of ApiResponse (EventDefinition)</returns>

    public async Task<ApiResponse<EventDefinition>> GetUsageEventsDefinitionAsyncWithHttpInfo(string eventDefinitionId)
    {
        // verify the required parameter 'eventDefinitionId' is set
        if (eventDefinitionId == null)
        {
            throw new ApiException(400, "Missing required parameter 'eventDefinitionId' when calling OperationalEventsApi->GetUsageEventsDefinition");
        }

        var localVarPath = "/api/v2/usage/events/definitions/{eventDefinitionId}";
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
        if (eventDefinitionId != null)
        {
            localVarPathParams.Add("eventDefinitionId", Configuration.ApiClient.ParameterToString(eventDefinitionId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventDefinition>(localVarStatusCode,
            localVarHeaders,
            (EventDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get all operational event definitions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>EventDefinitionListing</returns>

    public EventDefinitionListing GetUsageEventsDefinitions()
    {
        ApiResponse<EventDefinitionListing> localVarResponse = GetUsageEventsDefinitionsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get all operational event definitions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of EventDefinitionListing</returns>

    public ApiResponse<EventDefinitionListing> GetUsageEventsDefinitionsWithHttpInfo()
    {

        var localVarPath = "/api/v2/usage/events/definitions";
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
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventDefinitionListing>(localVarStatusCode,
            localVarHeaders,
            (EventDefinitionListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventDefinitionListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get all operational event definitions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of EventDefinitionListing</returns>

    public async Task<EventDefinitionListing> GetUsageEventsDefinitionsAsync()
    {
        ApiResponse<EventDefinitionListing> localVarResponse = await GetUsageEventsDefinitionsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get all operational event definitions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (EventDefinitionListing)</returns>

    public async Task<ApiResponse<EventDefinitionListing>> GetUsageEventsDefinitionsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/usage/events/definitions";
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
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsageEventsDefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventDefinitionListing>(localVarStatusCode,
            localVarHeaders,
            (EventDefinitionListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventDefinitionListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get aggregates for operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>EventAggregatesResponse</returns>

    public EventAggregatesResponse PostUsageEventsAggregatesQuery(EventAggregatesQueryRequest body = null)
    {
        ApiResponse<EventAggregatesResponse> localVarResponse = PostUsageEventsAggregatesQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get aggregates for operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of EventAggregatesResponse</returns>

    public ApiResponse<EventAggregatesResponse> PostUsageEventsAggregatesQueryWithHttpInfo(EventAggregatesQueryRequest body = null)
    {

        var localVarPath = "/api/v2/usage/events/aggregates/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventAggregatesResponse>(localVarStatusCode,
            localVarHeaders,
            (EventAggregatesResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventAggregatesResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get aggregates for operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of EventAggregatesResponse</returns>

    public async Task<EventAggregatesResponse> PostUsageEventsAggregatesQueryAsync(EventAggregatesQueryRequest body = null)
    {
        ApiResponse<EventAggregatesResponse> localVarResponse = await PostUsageEventsAggregatesQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get aggregates for operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (EventAggregatesResponse)</returns>

    public async Task<ApiResponse<EventAggregatesResponse>> PostUsageEventsAggregatesQueryAsyncWithHttpInfo(EventAggregatesQueryRequest body = null)
    {

        var localVarPath = "/api/v2/usage/events/aggregates/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventAggregatesResponse>(localVarStatusCode,
            localVarHeaders,
            (EventAggregatesResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventAggregatesResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Query operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>EventQueryResponse</returns>

    public EventQueryResponse PostUsageEventsQuery(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null)
    {
        ApiResponse<EventQueryResponse> localVarResponse = PostUsageEventsQueryWithHttpInfo(before, after, pageSize, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Query operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of EventQueryResponse</returns>

    public ApiResponse<EventQueryResponse> PostUsageEventsQueryWithHttpInfo(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null)
    {

        var localVarPath = "/api/v2/usage/events/query";
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
        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
        }

        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (EventQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Query operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of EventQueryResponse</returns>

    public async Task<EventQueryResponse> PostUsageEventsQueryAsync(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null)
    {
        ApiResponse<EventQueryResponse> localVarResponse = await PostUsageEventsQueryAsyncWithHttpInfo(before, after, pageSize, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Query operational events in a timeframe. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (EventQueryResponse)</returns>

    public async Task<ApiResponse<EventQueryResponse>> PostUsageEventsQueryAsyncWithHttpInfo(string before = null, string after = null, string pageSize = null, EventQueryRequest body = null)
    {

        var localVarPath = "/api/v2/usage/events/query";
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
        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
        }

        if (pageSize != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsageEventsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<EventQueryResponse>(localVarStatusCode,
            localVarHeaders,
            (EventQueryResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventQueryResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
