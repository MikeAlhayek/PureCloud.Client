using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IProcessAutomationApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns></returns>

    void DeleteProcessautomationTrigger(string triggerId);

    /// <summary>
    /// Delete a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteProcessautomationTriggerWithHttpInfo(string triggerId);

    /// <summary>
    /// Retrieve a single Trigger matching id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Trigger</returns>

    Trigger GetProcessautomationTrigger(string triggerId);

    /// <summary>
    /// Retrieve a single Trigger matching id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>ApiResponse of Trigger</returns>

    ApiResponse<Trigger> GetProcessautomationTriggerWithHttpInfo(string triggerId);

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>TriggerEntityListing</returns>

    TriggerEntityListing GetProcessautomationTriggers(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null);

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>ApiResponse of TriggerEntityListing</returns>

    ApiResponse<TriggerEntityListing> GetProcessautomationTriggersWithHttpInfo(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null);

    /// <summary>
    /// Get topics available for organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>TopicCursorEntityListing</returns>

    TopicCursorEntityListing GetProcessautomationTriggersTopics(string before = null, string after = null, string pageSize = null);

    /// <summary>
    /// Get topics available for organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>ApiResponse of TopicCursorEntityListing</returns>

    ApiResponse<TopicCursorEntityListing> GetProcessautomationTriggersTopicsWithHttpInfo(string before = null, string after = null, string pageSize = null);

    /// <summary>
    /// Test the matching of a Trigger based on provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>TestModeResults</returns>

    TestModeResults PostProcessautomationTriggerTest(string triggerId, string body = null);

    /// <summary>
    /// Test the matching of a Trigger based on provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>ApiResponse of TestModeResults</returns>

    ApiResponse<TestModeResults> PostProcessautomationTriggerTestWithHttpInfo(string triggerId, string body = null);

    /// <summary>
    /// Create a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>Trigger</returns>

    Trigger PostProcessautomationTriggers(CreateTriggerRequest body);

    /// <summary>
    /// Create a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>ApiResponse of Trigger</returns>

    ApiResponse<Trigger> PostProcessautomationTriggersWithHttpInfo(CreateTriggerRequest body);

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>TestModeEventResults</returns>

    TestModeEventResults PostProcessautomationTriggersTopicTest(string topicName, string body = null);

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>ApiResponse of TestModeEventResults</returns>

    ApiResponse<TestModeEventResults> PostProcessautomationTriggersTopicTestWithHttpInfo(string topicName, string body = null);

    /// <summary>
    /// Update a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>Trigger</returns>

    Trigger PutProcessautomationTrigger(string triggerId, UpdateTriggerRequest body);

    /// <summary>
    /// Update a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>ApiResponse of Trigger</returns>

    ApiResponse<Trigger> PutProcessautomationTriggerWithHttpInfo(string triggerId, UpdateTriggerRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of void</returns>

    Task DeleteProcessautomationTriggerAsync(string triggerId);

    /// <summary>
    /// Delete a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteProcessautomationTriggerAsyncWithHttpInfo(string triggerId);

    /// <summary>
    /// Retrieve a single Trigger matching id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of Trigger</returns>

    Task<Trigger> GetProcessautomationTriggerAsync(string triggerId);

    /// <summary>
    /// Retrieve a single Trigger matching id
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of ApiResponse (Trigger)</returns>

    Task<ApiResponse<Trigger>> GetProcessautomationTriggerAsyncWithHttpInfo(string triggerId);

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>Task of TriggerEntityListing</returns>

    Task<TriggerEntityListing> GetProcessautomationTriggersAsync(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null);

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>Task of ApiResponse (TriggerEntityListing)</returns>

    Task<ApiResponse<TriggerEntityListing>> GetProcessautomationTriggersAsyncWithHttpInfo(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null);

    /// <summary>
    /// Get topics available for organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>Task of TopicCursorEntityListing</returns>

    Task<TopicCursorEntityListing> GetProcessautomationTriggersTopicsAsync(string before = null, string after = null, string pageSize = null);

    /// <summary>
    /// Get topics available for organization
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>Task of ApiResponse (TopicCursorEntityListing)</returns>

    Task<ApiResponse<TopicCursorEntityListing>> GetProcessautomationTriggersTopicsAsyncWithHttpInfo(string before = null, string after = null, string pageSize = null);

    /// <summary>
    /// Test the matching of a Trigger based on provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of TestModeResults</returns>

    Task<TestModeResults> PostProcessautomationTriggerTestAsync(string triggerId, string body = null);

    /// <summary>
    /// Test the matching of a Trigger based on provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of ApiResponse (TestModeResults)</returns>

    Task<ApiResponse<TestModeResults>> PostProcessautomationTriggerTestAsyncWithHttpInfo(string triggerId, string body = null);

    /// <summary>
    /// Create a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>Task of Trigger</returns>

    Task<Trigger> PostProcessautomationTriggersAsync(CreateTriggerRequest body);

    /// <summary>
    /// Create a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>Task of ApiResponse (Trigger)</returns>

    Task<ApiResponse<Trigger>> PostProcessautomationTriggersAsyncWithHttpInfo(CreateTriggerRequest body);

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of TestModeEventResults</returns>

    Task<TestModeEventResults> PostProcessautomationTriggersTopicTestAsync(string topicName, string body = null);

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of ApiResponse (TestModeEventResults)</returns>

    Task<ApiResponse<TestModeEventResults>> PostProcessautomationTriggersTopicTestAsyncWithHttpInfo(string topicName, string body = null);

    /// <summary>
    /// Update a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>Task of Trigger</returns>

    Task<Trigger> PutProcessautomationTriggerAsync(string triggerId, UpdateTriggerRequest body);

    /// <summary>
    /// Update a Trigger
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>Task of ApiResponse (Trigger)</returns>

    Task<ApiResponse<Trigger>> PutProcessautomationTriggerAsyncWithHttpInfo(string triggerId, UpdateTriggerRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ProcessAutomationApi : IProcessAutomationApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessAutomationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ProcessAutomationApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessAutomationApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public ProcessAutomationApi(Configuration configuration = null)
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
    /// Delete a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns></returns>

    public void DeleteProcessautomationTrigger(string triggerId)
    {
        DeleteProcessautomationTriggerWithHttpInfo(triggerId);
    }

    /// <summary>
    /// Delete a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteProcessautomationTriggerWithHttpInfo(string triggerId)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->DeleteProcessautomationTrigger");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteProcessautomationTrigger: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteProcessautomationTrigger: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteProcessautomationTriggerAsync(string triggerId)
    {
        await DeleteProcessautomationTriggerAsyncWithHttpInfo(triggerId);

    }

    /// <summary>
    /// Delete a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteProcessautomationTriggerAsyncWithHttpInfo(string triggerId)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->DeleteProcessautomationTrigger");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteProcessautomationTrigger: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteProcessautomationTrigger: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Retrieve a single Trigger matching id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Trigger</returns>

    public Trigger GetProcessautomationTrigger(string triggerId)
    {
        ApiResponse<Trigger> localVarResponse = GetProcessautomationTriggerWithHttpInfo(triggerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a single Trigger matching id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>ApiResponse of Trigger</returns>

    public ApiResponse<Trigger> GetProcessautomationTriggerWithHttpInfo(string triggerId)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->GetProcessautomationTrigger");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTrigger: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTrigger: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trigger>(localVarStatusCode,
            localVarHeaders,
            (Trigger)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trigger)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Retrieve a single Trigger matching id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of Trigger</returns>

    public async Task<Trigger> GetProcessautomationTriggerAsync(string triggerId)
    {
        ApiResponse<Trigger> localVarResponse = await GetProcessautomationTriggerAsyncWithHttpInfo(triggerId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Retrieve a single Trigger matching id 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <returns>Task of ApiResponse (Trigger)</returns>

    public async Task<ApiResponse<Trigger>> GetProcessautomationTriggerAsyncWithHttpInfo(string triggerId)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->GetProcessautomationTrigger");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTrigger: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTrigger: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trigger>(localVarStatusCode,
            localVarHeaders,
            (Trigger)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trigger)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>TriggerEntityListing</returns>

    public TriggerEntityListing GetProcessautomationTriggers(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null)
    {
        ApiResponse<TriggerEntityListing> localVarResponse = GetProcessautomationTriggersWithHttpInfo(before, after, pageSize, topicName, enabled, hasDelayBy);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>ApiResponse of TriggerEntityListing</returns>

    public ApiResponse<TriggerEntityListing> GetProcessautomationTriggersWithHttpInfo(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null)
    {

        var localVarPath = "/api/v2/processautomation/triggers";
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

        if (topicName != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("topicName", Configuration.ApiClient.ParameterToString(topicName)));
        }

        if (enabled != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("enabled", Configuration.ApiClient.ParameterToString(enabled)));
        }

        if (hasDelayBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("hasDelayBy", Configuration.ApiClient.ParameterToString(hasDelayBy)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TriggerEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TriggerEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TriggerEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>Task of TriggerEntityListing</returns>

    public async Task<TriggerEntityListing> GetProcessautomationTriggersAsync(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null)
    {
        ApiResponse<TriggerEntityListing> localVarResponse = await GetProcessautomationTriggersAsyncWithHttpInfo(before, after, pageSize, topicName, enabled, hasDelayBy);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <returns>Task of ApiResponse (TriggerEntityListing)</returns>

    public async Task<ApiResponse<TriggerEntityListing>> GetProcessautomationTriggersAsyncWithHttpInfo(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null)
    {

        var localVarPath = "/api/v2/processautomation/triggers";
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

        if (topicName != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("topicName", Configuration.ApiClient.ParameterToString(topicName)));
        }

        if (enabled != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("enabled", Configuration.ApiClient.ParameterToString(enabled)));
        }

        if (hasDelayBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("hasDelayBy", Configuration.ApiClient.ParameterToString(hasDelayBy)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TriggerEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TriggerEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TriggerEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get topics available for organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>TopicCursorEntityListing</returns>

    public TopicCursorEntityListing GetProcessautomationTriggersTopics(string before = null, string after = null, string pageSize = null)
    {
        ApiResponse<TopicCursorEntityListing> localVarResponse = GetProcessautomationTriggersTopicsWithHttpInfo(before, after, pageSize);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get topics available for organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>ApiResponse of TopicCursorEntityListing</returns>

    public ApiResponse<TopicCursorEntityListing> GetProcessautomationTriggersTopicsWithHttpInfo(string before = null, string after = null, string pageSize = null)
    {

        var localVarPath = "/api/v2/processautomation/triggers/topics";
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
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggersTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggersTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TopicCursorEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TopicCursorEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicCursorEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get topics available for organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>Task of TopicCursorEntityListing</returns>

    public async Task<TopicCursorEntityListing> GetProcessautomationTriggersTopicsAsync(string before = null, string after = null, string pageSize = null)
    {
        ApiResponse<TopicCursorEntityListing> localVarResponse = await GetProcessautomationTriggersTopicsAsyncWithHttpInfo(before, after, pageSize);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get topics available for organization 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <returns>Task of ApiResponse (TopicCursorEntityListing)</returns>

    public async Task<ApiResponse<TopicCursorEntityListing>> GetProcessautomationTriggersTopicsAsyncWithHttpInfo(string before = null, string after = null, string pageSize = null)
    {

        var localVarPath = "/api/v2/processautomation/triggers/topics";
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
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggersTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetProcessautomationTriggersTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TopicCursorEntityListing>(localVarStatusCode,
            localVarHeaders,
            (TopicCursorEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicCursorEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Test the matching of a Trigger based on provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>TestModeResults</returns>

    public TestModeResults PostProcessautomationTriggerTest(string triggerId, string body = null)
    {
        ApiResponse<TestModeResults> localVarResponse = PostProcessautomationTriggerTestWithHttpInfo(triggerId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Test the matching of a Trigger based on provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>ApiResponse of TestModeResults</returns>

    public ApiResponse<TestModeResults> PostProcessautomationTriggerTestWithHttpInfo(string triggerId, string body = null)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->PostProcessautomationTriggerTest");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}/test";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggerTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggerTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TestModeResults>(localVarStatusCode,
            localVarHeaders,
            (TestModeResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestModeResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Test the matching of a Trigger based on provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of TestModeResults</returns>

    public async Task<TestModeResults> PostProcessautomationTriggerTestAsync(string triggerId, string body = null)
    {
        ApiResponse<TestModeResults> localVarResponse = await PostProcessautomationTriggerTestAsyncWithHttpInfo(triggerId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Test the matching of a Trigger based on provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of ApiResponse (TestModeResults)</returns>

    public async Task<ApiResponse<TestModeResults>> PostProcessautomationTriggerTestAsyncWithHttpInfo(string triggerId, string body = null)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->PostProcessautomationTriggerTest");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}/test";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggerTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggerTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TestModeResults>(localVarStatusCode,
            localVarHeaders,
            (TestModeResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestModeResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>Trigger</returns>

    public Trigger PostProcessautomationTriggers(CreateTriggerRequest body)
    {
        ApiResponse<Trigger> localVarResponse = PostProcessautomationTriggersWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>ApiResponse of Trigger</returns>

    public ApiResponse<Trigger> PostProcessautomationTriggersWithHttpInfo(CreateTriggerRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ProcessAutomationApi->PostProcessautomationTriggers");
        }

        var localVarPath = "/api/v2/processautomation/triggers";
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
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trigger>(localVarStatusCode,
            localVarHeaders,
            (Trigger)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trigger)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>Task of Trigger</returns>

    public async Task<Trigger> PostProcessautomationTriggersAsync(CreateTriggerRequest body)
    {
        ApiResponse<Trigger> localVarResponse = await PostProcessautomationTriggersAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <returns>Task of ApiResponse (Trigger)</returns>

    public async Task<ApiResponse<Trigger>> PostProcessautomationTriggersAsyncWithHttpInfo(CreateTriggerRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ProcessAutomationApi->PostProcessautomationTriggers");
        }

        var localVarPath = "/api/v2/processautomation/triggers";
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
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trigger>(localVarStatusCode,
            localVarHeaders,
            (Trigger)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trigger)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>TestModeEventResults</returns>

    public TestModeEventResults PostProcessautomationTriggersTopicTest(string topicName, string body = null)
    {
        ApiResponse<TestModeEventResults> localVarResponse = PostProcessautomationTriggersTopicTestWithHttpInfo(topicName, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>ApiResponse of TestModeEventResults</returns>

    public ApiResponse<TestModeEventResults> PostProcessautomationTriggersTopicTestWithHttpInfo(string topicName, string body = null)
    {
        // verify the required parameter 'topicName' is set
        if (topicName == null)
        {
            throw new ApiException(400, "Missing required parameter 'topicName' when calling ProcessAutomationApi->PostProcessautomationTriggersTopicTest");
        }

        var localVarPath = "/api/v2/processautomation/triggers/topics/{topicName}/test";
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
        if (topicName != null)
        {
            localVarPathParams.Add("topicName", Configuration.ApiClient.ParameterToString(topicName));
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
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggersTopicTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggersTopicTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TestModeEventResults>(localVarStatusCode,
            localVarHeaders,
            (TestModeEventResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestModeEventResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of TestModeEventResults</returns>

    public async Task<TestModeEventResults> PostProcessautomationTriggersTopicTestAsync(string topicName, string body = null)
    {
        ApiResponse<TestModeEventResults> localVarResponse = await PostProcessautomationTriggersTopicTestAsyncWithHttpInfo(topicName, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <returns>Task of ApiResponse (TestModeEventResults)</returns>

    public async Task<ApiResponse<TestModeEventResults>> PostProcessautomationTriggersTopicTestAsyncWithHttpInfo(string topicName, string body = null)
    {
        // verify the required parameter 'topicName' is set
        if (topicName == null)
        {
            throw new ApiException(400, "Missing required parameter 'topicName' when calling ProcessAutomationApi->PostProcessautomationTriggersTopicTest");
        }

        var localVarPath = "/api/v2/processautomation/triggers/topics/{topicName}/test";
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
        if (topicName != null)
        {
            localVarPathParams.Add("topicName", Configuration.ApiClient.ParameterToString(topicName));
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
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggersTopicTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostProcessautomationTriggersTopicTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TestModeEventResults>(localVarStatusCode,
            localVarHeaders,
            (TestModeEventResults)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestModeEventResults)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>Trigger</returns>

    public Trigger PutProcessautomationTrigger(string triggerId, UpdateTriggerRequest body)
    {
        ApiResponse<Trigger> localVarResponse = PutProcessautomationTriggerWithHttpInfo(triggerId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>ApiResponse of Trigger</returns>

    public ApiResponse<Trigger> PutProcessautomationTriggerWithHttpInfo(string triggerId, UpdateTriggerRequest body)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->PutProcessautomationTrigger");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ProcessAutomationApi->PutProcessautomationTrigger");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutProcessautomationTrigger: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutProcessautomationTrigger: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trigger>(localVarStatusCode,
            localVarHeaders,
            (Trigger)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trigger)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>Task of Trigger</returns>

    public async Task<Trigger> PutProcessautomationTriggerAsync(string triggerId, UpdateTriggerRequest body)
    {
        ApiResponse<Trigger> localVarResponse = await PutProcessautomationTriggerAsyncWithHttpInfo(triggerId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a Trigger 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <returns>Task of ApiResponse (Trigger)</returns>

    public async Task<ApiResponse<Trigger>> PutProcessautomationTriggerAsyncWithHttpInfo(string triggerId, UpdateTriggerRequest body)
    {
        // verify the required parameter 'triggerId' is set
        if (triggerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'triggerId' when calling ProcessAutomationApi->PutProcessautomationTrigger");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ProcessAutomationApi->PutProcessautomationTrigger");
        }

        var localVarPath = "/api/v2/processautomation/triggers/{triggerId}";
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
        if (triggerId != null)
        {
            localVarPathParams.Add("triggerId", Configuration.ApiClient.ParameterToString(triggerId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutProcessautomationTrigger: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutProcessautomationTrigger: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Trigger>(localVarStatusCode,
            localVarHeaders,
            (Trigger)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trigger)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
