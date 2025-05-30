using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAgentCopilotApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get copilot configuration of an assistant.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>Copilot</returns>

    Copilot GetAssistantCopilot(string assistantId);

    /// <summary>
    /// Get copilot configuration of an assistant.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>ApiResponse of Copilot</returns>

    ApiResponse<Copilot> GetAssistantCopilotWithHttpInfo(string assistantId);

    /// <summary>
    /// Update agent copilot configuration
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>Copilot</returns>

    Copilot PutAssistantCopilot(string assistantId, Copilot body);

    /// <summary>
    /// Update agent copilot configuration
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>ApiResponse of Copilot</returns>

    ApiResponse<Copilot> PutAssistantCopilotWithHttpInfo(string assistantId, Copilot body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get copilot configuration of an assistant.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>Task of Copilot</returns>

    Task<Copilot> GetAssistantCopilotAsync(string assistantId);

    /// <summary>
    /// Get copilot configuration of an assistant.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>Task of ApiResponse (Copilot)</returns>

    Task<ApiResponse<Copilot>> GetAssistantCopilotAsyncWithHttpInfo(string assistantId);

    /// <summary>
    /// Update agent copilot configuration
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>Task of Copilot</returns>

    Task<Copilot> PutAssistantCopilotAsync(string assistantId, Copilot body);

    /// <summary>
    /// Update agent copilot configuration
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (Copilot)</returns>

    Task<ApiResponse<Copilot>> PutAssistantCopilotAsyncWithHttpInfo(string assistantId, Copilot body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class AgentCopilotApi : IAgentCopilotApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotApi"/> class.
    /// </summary>
    /// <returns></returns>
    public AgentCopilotApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public AgentCopilotApi(Configuration configuration = null)
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
    /// Get copilot configuration of an assistant. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>Copilot</returns>

    public Copilot GetAssistantCopilot(string assistantId)
    {
        ApiResponse<Copilot> localVarResponse = GetAssistantCopilotWithHttpInfo(assistantId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get copilot configuration of an assistant. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>ApiResponse of Copilot</returns>

    public ApiResponse<Copilot> GetAssistantCopilotWithHttpInfo(string assistantId)
    {
        // verify the required parameter 'assistantId' is set
        if (assistantId == null)
        {
            throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->GetAssistantCopilot");
        }

        var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
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
        if (assistantId != null)
        {
            localVarPathParams.Add("assistantId", Configuration.ApiClient.ParameterToString(assistantId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Copilot>(localVarStatusCode,
            localVarHeaders,
            (Copilot)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get copilot configuration of an assistant. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>Task of Copilot</returns>

    public async Task<Copilot> GetAssistantCopilotAsync(string assistantId)
    {
        ApiResponse<Copilot> localVarResponse = await GetAssistantCopilotAsyncWithHttpInfo(assistantId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get copilot configuration of an assistant. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <returns>Task of ApiResponse (Copilot)</returns>

    public async Task<ApiResponse<Copilot>> GetAssistantCopilotAsyncWithHttpInfo(string assistantId)
    {
        // verify the required parameter 'assistantId' is set
        if (assistantId == null)
        {
            throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->GetAssistantCopilot");
        }

        var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
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
        if (assistantId != null)
        {
            localVarPathParams.Add("assistantId", Configuration.ApiClient.ParameterToString(assistantId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Copilot>(localVarStatusCode,
            localVarHeaders,
            (Copilot)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update agent copilot configuration 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>Copilot</returns>

    public Copilot PutAssistantCopilot(string assistantId, Copilot body)
    {
        ApiResponse<Copilot> localVarResponse = PutAssistantCopilotWithHttpInfo(assistantId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update agent copilot configuration 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>ApiResponse of Copilot</returns>

    public ApiResponse<Copilot> PutAssistantCopilotWithHttpInfo(string assistantId, Copilot body)
    {
        // verify the required parameter 'assistantId' is set
        if (assistantId == null)
        {
            throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->PutAssistantCopilot");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AgentCopilotApi->PutAssistantCopilot");
        }

        var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
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
        if (assistantId != null)
        {
            localVarPathParams.Add("assistantId", Configuration.ApiClient.ParameterToString(assistantId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Copilot>(localVarStatusCode,
            localVarHeaders,
            (Copilot)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update agent copilot configuration 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>Task of Copilot</returns>

    public async Task<Copilot> PutAssistantCopilotAsync(string assistantId, Copilot body)
    {
        ApiResponse<Copilot> localVarResponse = await PutAssistantCopilotAsyncWithHttpInfo(assistantId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update agent copilot configuration 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="assistantId">Assistant ID</param>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (Copilot)</returns>

    public async Task<ApiResponse<Copilot>> PutAssistantCopilotAsyncWithHttpInfo(string assistantId, Copilot body)
    {
        // verify the required parameter 'assistantId' is set
        if (assistantId == null)
        {
            throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->PutAssistantCopilot");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AgentCopilotApi->PutAssistantCopilot");
        }

        var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
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
        if (assistantId != null)
        {
            localVarPathParams.Add("assistantId", Configuration.ApiClient.ParameterToString(assistantId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Copilot>(localVarStatusCode,
            localVarHeaders,
            (Copilot)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
