using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDataPrivacyApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns></returns>

    void DeleteDataprivacyMaskingrule(string ruleId);

    /// <summary>
    /// Delete a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteDataprivacyMaskingruleWithHttpInfo(string ruleId);

    /// <summary>
    /// Fetch details about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>MaskingRule</returns>

    MaskingRule GetDataprivacyMaskingrule(string ruleId);

    /// <summary>
    /// Fetch details about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>ApiResponse of MaskingRule</returns>

    ApiResponse<MaskingRule> GetDataprivacyMaskingruleWithHttpInfo(string ruleId);

    /// <summary>
    /// Retrieve the list of masking rules.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>MaskingRuleListing</returns>

    MaskingRuleListing GetDataprivacyMaskingrules();

    /// <summary>
    /// Retrieve the list of masking rules.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of MaskingRuleListing</returns>

    ApiResponse<MaskingRuleListing> GetDataprivacyMaskingrulesWithHttpInfo();

    /// <summary>
    /// Update information about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>MaskingRule</returns>

    MaskingRule PatchDataprivacyMaskingrule(string ruleId, MaskingRule body = null);

    /// <summary>
    /// Update information about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of MaskingRule</returns>

    ApiResponse<MaskingRule> PatchDataprivacyMaskingruleWithHttpInfo(string ruleId, MaskingRule body = null);

    /// <summary>
    /// Create a new masking rule resource.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>MaskingRule</returns>

    MaskingRule PostDataprivacyMaskingrules(MaskingRule body);

    /// <summary>
    /// Create a new masking rule resource.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>ApiResponse of MaskingRule</returns>

    ApiResponse<MaskingRule> PostDataprivacyMaskingrulesWithHttpInfo(MaskingRule body);

    /// <summary>
    /// Validate masking before creating.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>MaskingRuleValidateResponse</returns>

    MaskingRuleValidateResponse PostDataprivacyMaskingrulesValidate(MaskingRuleValidateRequest body);

    /// <summary>
    /// Validate masking before creating.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>ApiResponse of MaskingRuleValidateResponse</returns>

    ApiResponse<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateWithHttpInfo(MaskingRuleValidateRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of void</returns>

    Task DeleteDataprivacyMaskingruleAsync(string ruleId);

    /// <summary>
    /// Delete a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId);

    /// <summary>
    /// Fetch details about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of MaskingRule</returns>

    Task<MaskingRule> GetDataprivacyMaskingruleAsync(string ruleId);

    /// <summary>
    /// Fetch details about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of ApiResponse (MaskingRule)</returns>

    Task<ApiResponse<MaskingRule>> GetDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId);

    /// <summary>
    /// Retrieve the list of masking rules.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of MaskingRuleListing</returns>

    Task<MaskingRuleListing> GetDataprivacyMaskingrulesAsync();

    /// <summary>
    /// Retrieve the list of masking rules.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (MaskingRuleListing)</returns>

    Task<ApiResponse<MaskingRuleListing>> GetDataprivacyMaskingrulesAsyncWithHttpInfo();

    /// <summary>
    /// Update information about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of MaskingRule</returns>

    Task<MaskingRule> PatchDataprivacyMaskingruleAsync(string ruleId, MaskingRule body = null);

    /// <summary>
    /// Update information about a masking rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (MaskingRule)</returns>

    Task<ApiResponse<MaskingRule>> PatchDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId, MaskingRule body = null);

    /// <summary>
    /// Create a new masking rule resource.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>Task of MaskingRule</returns>

    Task<MaskingRule> PostDataprivacyMaskingrulesAsync(MaskingRule body);

    /// <summary>
    /// Create a new masking rule resource.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>Task of ApiResponse (MaskingRule)</returns>

    Task<ApiResponse<MaskingRule>> PostDataprivacyMaskingrulesAsyncWithHttpInfo(MaskingRule body);

    /// <summary>
    /// Validate masking before creating.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>Task of MaskingRuleValidateResponse</returns>

    Task<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateAsync(MaskingRuleValidateRequest body);

    /// <summary>
    /// Validate masking before creating.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>Task of ApiResponse (MaskingRuleValidateResponse)</returns>

    Task<ApiResponse<MaskingRuleValidateResponse>> PostDataprivacyMaskingrulesValidateAsyncWithHttpInfo(MaskingRuleValidateRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class DataPrivacyApi : IDataPrivacyApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataPrivacyApi"/> class.
    /// </summary>
    /// <returns></returns>
    public DataPrivacyApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataPrivacyApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public DataPrivacyApi(Configuration configuration = null)
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
    /// Delete a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns></returns>

    public void DeleteDataprivacyMaskingrule(string ruleId)
    {
        DeleteDataprivacyMaskingruleWithHttpInfo(ruleId);
    }

    /// <summary>
    /// Delete a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteDataprivacyMaskingruleWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->DeleteDataprivacyMaskingrule");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/{ruleId}";
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
        if (ruleId != null)
        {
            localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteDataprivacyMaskingruleAsync(string ruleId)
    {
        await DeleteDataprivacyMaskingruleAsyncWithHttpInfo(ruleId);

    }

    /// <summary>
    /// Delete a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->DeleteDataprivacyMaskingrule");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/{ruleId}";
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
        if (ruleId != null)
        {
            localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Fetch details about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>MaskingRule</returns>

    public MaskingRule GetDataprivacyMaskingrule(string ruleId)
    {
        ApiResponse<MaskingRule> localVarResponse = GetDataprivacyMaskingruleWithHttpInfo(ruleId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Fetch details about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>ApiResponse of MaskingRule</returns>

    public ApiResponse<MaskingRule> GetDataprivacyMaskingruleWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->GetDataprivacyMaskingrule");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/{ruleId}";
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
        if (ruleId != null)
        {
            localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRule>(localVarStatusCode,
            localVarHeaders,
            (MaskingRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Fetch details about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of MaskingRule</returns>

    public async Task<MaskingRule> GetDataprivacyMaskingruleAsync(string ruleId)
    {
        ApiResponse<MaskingRule> localVarResponse = await GetDataprivacyMaskingruleAsyncWithHttpInfo(ruleId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Fetch details about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <returns>Task of ApiResponse (MaskingRule)</returns>

    public async Task<ApiResponse<MaskingRule>> GetDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->GetDataprivacyMaskingrule");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/{ruleId}";
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
        if (ruleId != null)
        {
            localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRule>(localVarStatusCode,
            localVarHeaders,
            (MaskingRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Retrieve the list of masking rules. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>MaskingRuleListing</returns>

    public MaskingRuleListing GetDataprivacyMaskingrules()
    {
        ApiResponse<MaskingRuleListing> localVarResponse = GetDataprivacyMaskingrulesWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve the list of masking rules. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of MaskingRuleListing</returns>

    public ApiResponse<MaskingRuleListing> GetDataprivacyMaskingrulesWithHttpInfo()
    {

        var localVarPath = "/api/v2/dataprivacy/maskingrules";
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
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRuleListing>(localVarStatusCode,
            localVarHeaders,
            (MaskingRuleListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Retrieve the list of masking rules. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of MaskingRuleListing</returns>

    public async Task<MaskingRuleListing> GetDataprivacyMaskingrulesAsync()
    {
        ApiResponse<MaskingRuleListing> localVarResponse = await GetDataprivacyMaskingrulesAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Retrieve the list of masking rules. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (MaskingRuleListing)</returns>

    public async Task<ApiResponse<MaskingRuleListing>> GetDataprivacyMaskingrulesAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/dataprivacy/maskingrules";
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
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRuleListing>(localVarStatusCode,
            localVarHeaders,
            (MaskingRuleListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update information about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>MaskingRule</returns>

    public MaskingRule PatchDataprivacyMaskingrule(string ruleId, MaskingRule body = null)
    {
        ApiResponse<MaskingRule> localVarResponse = PatchDataprivacyMaskingruleWithHttpInfo(ruleId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update information about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of MaskingRule</returns>

    public ApiResponse<MaskingRule> PatchDataprivacyMaskingruleWithHttpInfo(string ruleId, MaskingRule body = null)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->PatchDataprivacyMaskingrule");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/{ruleId}";
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
        if (ruleId != null)
        {
            localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRule>(localVarStatusCode,
            localVarHeaders,
            (MaskingRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update information about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of MaskingRule</returns>

    public async Task<MaskingRule> PatchDataprivacyMaskingruleAsync(string ruleId, MaskingRule body = null)
    {
        ApiResponse<MaskingRule> localVarResponse = await PatchDataprivacyMaskingruleAsyncWithHttpInfo(ruleId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update information about a masking rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">ruleId</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (MaskingRule)</returns>

    public async Task<ApiResponse<MaskingRule>> PatchDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId, MaskingRule body = null)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->PatchDataprivacyMaskingrule");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/{ruleId}";
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
        if (ruleId != null)
        {
            localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRule>(localVarStatusCode,
            localVarHeaders,
            (MaskingRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a new masking rule resource. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>MaskingRule</returns>

    public MaskingRule PostDataprivacyMaskingrules(MaskingRule body)
    {
        ApiResponse<MaskingRule> localVarResponse = PostDataprivacyMaskingrulesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a new masking rule resource. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>ApiResponse of MaskingRule</returns>

    public ApiResponse<MaskingRule> PostDataprivacyMaskingrulesWithHttpInfo(MaskingRule body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrules");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules";
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
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRule>(localVarStatusCode,
            localVarHeaders,
            (MaskingRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a new masking rule resource. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>Task of MaskingRule</returns>

    public async Task<MaskingRule> PostDataprivacyMaskingrulesAsync(MaskingRule body)
    {
        ApiResponse<MaskingRule> localVarResponse = await PostDataprivacyMaskingrulesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a new masking rule resource. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Details for creating masking rule resource</param>
    /// <returns>Task of ApiResponse (MaskingRule)</returns>

    public async Task<ApiResponse<MaskingRule>> PostDataprivacyMaskingrulesAsyncWithHttpInfo(MaskingRule body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrules");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules";
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
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRule>(localVarStatusCode,
            localVarHeaders,
            (MaskingRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Validate masking before creating. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>MaskingRuleValidateResponse</returns>

    public MaskingRuleValidateResponse PostDataprivacyMaskingrulesValidate(MaskingRuleValidateRequest body)
    {
        ApiResponse<MaskingRuleValidateResponse> localVarResponse = PostDataprivacyMaskingrulesValidateWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Validate masking before creating. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>ApiResponse of MaskingRuleValidateResponse</returns>

    public ApiResponse<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateWithHttpInfo(MaskingRuleValidateRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrulesValidate");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/validate";
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
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRuleValidateResponse>(localVarStatusCode,
            localVarHeaders,
            (MaskingRuleValidateResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleValidateResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Validate masking before creating. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>Task of MaskingRuleValidateResponse</returns>

    public async Task<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateAsync(MaskingRuleValidateRequest body)
    {
        ApiResponse<MaskingRuleValidateResponse> localVarResponse = await PostDataprivacyMaskingrulesValidateAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Validate masking before creating. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Text to be masked</param>
    /// <returns>Task of ApiResponse (MaskingRuleValidateResponse)</returns>

    public async Task<ApiResponse<MaskingRuleValidateResponse>> PostDataprivacyMaskingrulesValidateAsyncWithHttpInfo(MaskingRuleValidateRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrulesValidate");
        }

        var localVarPath = "/api/v2/dataprivacy/maskingrules/validate";
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
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MaskingRuleValidateResponse>(localVarStatusCode,
            localVarHeaders,
            (MaskingRuleValidateResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleValidateResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
