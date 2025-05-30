using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAgentUIApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns></returns>

    void DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId);

    /// <summary>
    /// Delete agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId);

    /// <summary>
    /// Get agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>AutoAnswerSettings</returns>

    AutoAnswerSettings GetUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId);

    /// <summary>
    /// Get agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>ApiResponse of AutoAnswerSettings</returns>

    ApiResponse<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId);

    /// <summary>
    /// Update agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>AutoAnswerSettings</returns>

    AutoAnswerSettings PatchUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId, AutoAnswerSettings body);

    /// <summary>
    /// Update agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>ApiResponse of AutoAnswerSettings</returns>

    ApiResponse<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId, AutoAnswerSettings body);

    /// <summary>
    /// Set agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>AutoAnswerSettings</returns>

    AutoAnswerSettings PutUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId, AutoAnswerSettings body);

    /// <summary>
    /// Set agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>ApiResponse of AutoAnswerSettings</returns>

    ApiResponse<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId, AutoAnswerSettings body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of void</returns>

    Task DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId);

    /// <summary>
    /// Delete agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId);

    /// <summary>
    /// Get agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of AutoAnswerSettings</returns>

    Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId);

    /// <summary>
    /// Get agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>

    Task<ApiResponse<AutoAnswerSettings>> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId);

    /// <summary>
    /// Update agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of AutoAnswerSettings</returns>

    Task<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, AutoAnswerSettings body);

    /// <summary>
    /// Update agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>

    Task<ApiResponse<AutoAnswerSettings>> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId, AutoAnswerSettings body);

    /// <summary>
    /// Set agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of AutoAnswerSettings</returns>

    Task<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, AutoAnswerSettings body);

    /// <summary>
    /// Set agent auto answer settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>

    Task<ApiResponse<AutoAnswerSettings>> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId, AutoAnswerSettings body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class AgentUIApi : IAgentUIApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentUIApi"/> class.
    /// </summary>
    /// <returns></returns>
    public AgentUIApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentUIApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public AgentUIApi(Configuration configuration = null)
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
    /// Delete agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns></returns>

    public void DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId)
    {
        DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId);
    }

    /// <summary>
    /// Delete agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of void</returns>

    public async Task DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId)
    {
        await DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId);

    }

    /// <summary>
    /// Delete agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>AutoAnswerSettings</returns>

    public AutoAnswerSettings GetUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId)
    {
        ApiResponse<AutoAnswerSettings> localVarResponse = GetUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>ApiResponse of AutoAnswerSettings</returns>

    public ApiResponse<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->GetUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
            localVarHeaders,
            (AutoAnswerSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of AutoAnswerSettings</returns>

    public async Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId)
    {
        ApiResponse<AutoAnswerSettings> localVarResponse = await GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>

    public async Task<ApiResponse<AutoAnswerSettings>> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->GetUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
            localVarHeaders,
            (AutoAnswerSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>AutoAnswerSettings</returns>

    public AutoAnswerSettings PatchUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId, AutoAnswerSettings body)
    {
        ApiResponse<AutoAnswerSettings> localVarResponse = PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>ApiResponse of AutoAnswerSettings</returns>

    public ApiResponse<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId, AutoAnswerSettings body)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
            localVarHeaders,
            (AutoAnswerSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of AutoAnswerSettings</returns>

    public async Task<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, AutoAnswerSettings body)
    {
        ApiResponse<AutoAnswerSettings> localVarResponse = await PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>

    public async Task<ApiResponse<AutoAnswerSettings>> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId, AutoAnswerSettings body)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
            localVarHeaders,
            (AutoAnswerSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Set agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>AutoAnswerSettings</returns>

    public AutoAnswerSettings PutUsersAgentuiAgentsAutoanswerAgentIdSettings(string agentId, AutoAnswerSettings body)
    {
        ApiResponse<AutoAnswerSettings> localVarResponse = PutUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Set agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>ApiResponse of AutoAnswerSettings</returns>

    public ApiResponse<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(string agentId, AutoAnswerSettings body)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
            localVarHeaders,
            (AutoAnswerSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Set agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of AutoAnswerSettings</returns>

    public async Task<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, AutoAnswerSettings body)
    {
        ApiResponse<AutoAnswerSettings> localVarResponse = await PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Set agent auto answer settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>

    public async Task<ApiResponse<AutoAnswerSettings>> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(string agentId, AutoAnswerSettings body)
    {
        // verify the required parameter 'agentId' is set
        if (agentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
        }

        var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
        if (agentId != null)
        {
            localVarPathParams.Add("agentId", Configuration.ApiClient.ParameterToString(agentId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
            localVarHeaders,
            (AutoAnswerSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
