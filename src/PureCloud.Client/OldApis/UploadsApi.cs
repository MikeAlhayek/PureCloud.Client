using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IUploadsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get content upload from URL job status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>GetUploadSourceUrlJobStatusResponse</returns>

    GetUploadSourceUrlJobStatusResponse GetKnowledgeKnowledgebaseUploadsUrlsJob(string knowledgeBaseId, string jobId);

    /// <summary>
    /// Get content upload from URL job status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>ApiResponse of GetUploadSourceUrlJobStatusResponse</returns>

    ApiResponse<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobWithHttpInfo(string knowledgeBaseId, string jobId);

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostGamificationContestsUploadsPrizeimages(GamificationContestPrizeImageUploadUrlRequest body);

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostGamificationContestsUploadsPrizeimagesWithHttpInfo(GamificationContestPrizeImageUploadUrlRequest body);

    /// <summary>
    /// Create upload presigned URL for draft function package file.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>FunctionUploadResponse</returns>

    FunctionUploadResponse PostIntegrationsActionDraftFunctionUpload(string actionId, FunctionUploadRequest body);

    /// <summary>
    /// Create upload presigned URL for draft function package file.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>ApiResponse of FunctionUploadResponse</returns>

    ApiResponse<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadWithHttpInfo(string actionId, FunctionUploadRequest body);

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostKnowledgeDocumentuploads(UploadUrlRequest body);

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostKnowledgeDocumentuploadsWithHttpInfo(UploadUrlRequest body);

    /// <summary>
    /// Create content upload from URL job
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>CreateUploadSourceUrlJobResponse</returns>

    CreateUploadSourceUrlJobResponse PostKnowledgeKnowledgebaseUploadsUrlsJobs(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

    /// <summary>
    /// Create content upload from URL job
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>ApiResponse of CreateUploadSourceUrlJobResponse</returns>

    ApiResponse<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsWithHttpInfo(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostLanguageunderstandingMinerUploads(string minerId, object body);

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostLanguageunderstandingMinerUploadsWithHttpInfo(string minerId, object body);

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostUploadsLearningCoverart(LearningCoverArtUploadUrlRequest body);

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostUploadsLearningCoverartWithHttpInfo(LearningCoverArtUploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a public asset image
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostUploadsPublicassetsImages(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a public asset image
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostUploadsPublicassetsImagesWithHttpInfo(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a recording file
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostUploadsRecordings(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a recording file
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostUploadsRecordingsWithHttpInfo(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    UploadUrlResponse PostUploadsWorkforcemanagementHistoricaldataCsv(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    ApiResponse<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvWithHttpInfo(UploadUrlRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get content upload from URL job status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>Task of GetUploadSourceUrlJobStatusResponse</returns>

    Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobAsync(string knowledgeBaseId, string jobId);

    /// <summary>
    /// Get content upload from URL job status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>Task of ApiResponse (GetUploadSourceUrlJobStatusResponse)</returns>

    Task<ApiResponse<GetUploadSourceUrlJobStatusResponse>> GetKnowledgeKnowledgebaseUploadsUrlsJobAsyncWithHttpInfo(string knowledgeBaseId, string jobId);

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostGamificationContestsUploadsPrizeimagesAsync(GamificationContestPrizeImageUploadUrlRequest body);

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostGamificationContestsUploadsPrizeimagesAsyncWithHttpInfo(GamificationContestPrizeImageUploadUrlRequest body);

    /// <summary>
    /// Create upload presigned URL for draft function package file.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>Task of FunctionUploadResponse</returns>

    Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync(string actionId, FunctionUploadRequest body);

    /// <summary>
    /// Create upload presigned URL for draft function package file.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>Task of ApiResponse (FunctionUploadResponse)</returns>

    Task<ApiResponse<FunctionUploadResponse>> PostIntegrationsActionDraftFunctionUploadAsyncWithHttpInfo(string actionId, FunctionUploadRequest body);

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostKnowledgeDocumentuploadsAsync(UploadUrlRequest body);

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostKnowledgeDocumentuploadsAsyncWithHttpInfo(UploadUrlRequest body);

    /// <summary>
    /// Create content upload from URL job
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>Task of CreateUploadSourceUrlJobResponse</returns>

    Task<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

    /// <summary>
    /// Create content upload from URL job
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>Task of ApiResponse (CreateUploadSourceUrlJobResponse)</returns>

    Task<ApiResponse<CreateUploadSourceUrlJobResponse>> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsyncWithHttpInfo(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostLanguageunderstandingMinerUploadsAsync(string minerId, object body);

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostLanguageunderstandingMinerUploadsAsyncWithHttpInfo(string minerId, object body);

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostUploadsLearningCoverartAsync(LearningCoverArtUploadUrlRequest body);

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostUploadsLearningCoverartAsyncWithHttpInfo(LearningCoverArtUploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a public asset image
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostUploadsPublicassetsImagesAsync(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a public asset image
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostUploadsPublicassetsImagesAsyncWithHttpInfo(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a recording file
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostUploadsRecordingsAsync(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading a recording file
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostUploadsRecordingsAsyncWithHttpInfo(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    Task<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvAsync(UploadUrlRequest body);

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    Task<ApiResponse<UploadUrlResponse>> PostUploadsWorkforcemanagementHistoricaldataCsvAsyncWithHttpInfo(UploadUrlRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class UploadsApi : IUploadsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UploadsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public UploadsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UploadsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public UploadsApi(Configuration configuration = null)
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
    /// Get content upload from URL job status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>GetUploadSourceUrlJobStatusResponse</returns>

    public GetUploadSourceUrlJobStatusResponse GetKnowledgeKnowledgebaseUploadsUrlsJob(string knowledgeBaseId, string jobId)
    {
        ApiResponse<GetUploadSourceUrlJobStatusResponse> localVarResponse = GetKnowledgeKnowledgebaseUploadsUrlsJobWithHttpInfo(knowledgeBaseId, jobId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get content upload from URL job status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>ApiResponse of GetUploadSourceUrlJobStatusResponse</returns>

    public ApiResponse<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobWithHttpInfo(string knowledgeBaseId, string jobId)
    {
        // verify the required parameter 'knowledgeBaseId' is set
        if (knowledgeBaseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
        }
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
        }

        var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId}";
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
        if (knowledgeBaseId != null)
        {
            localVarPathParams.Add("knowledgeBaseId", Configuration.ApiClient.ParameterToString(knowledgeBaseId));
        }

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
            throw new ApiException(localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GetUploadSourceUrlJobStatusResponse>(localVarStatusCode,
            localVarHeaders,
            (GetUploadSourceUrlJobStatusResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetUploadSourceUrlJobStatusResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get content upload from URL job status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>Task of GetUploadSourceUrlJobStatusResponse</returns>

    public async Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobAsync(string knowledgeBaseId, string jobId)
    {
        ApiResponse<GetUploadSourceUrlJobStatusResponse> localVarResponse = await GetKnowledgeKnowledgebaseUploadsUrlsJobAsyncWithHttpInfo(knowledgeBaseId, jobId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get content upload from URL job status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="jobId">Upload job ID</param>
    /// <returns>Task of ApiResponse (GetUploadSourceUrlJobStatusResponse)</returns>

    public async Task<ApiResponse<GetUploadSourceUrlJobStatusResponse>> GetKnowledgeKnowledgebaseUploadsUrlsJobAsyncWithHttpInfo(string knowledgeBaseId, string jobId)
    {
        // verify the required parameter 'knowledgeBaseId' is set
        if (knowledgeBaseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
        }

        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
        }

        var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId}";
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
        if (knowledgeBaseId != null)
        {
            localVarPathParams.Add("knowledgeBaseId", Configuration.ApiClient.ParameterToString(knowledgeBaseId));
        }

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
            throw new ApiException(localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GetUploadSourceUrlJobStatusResponse>(localVarStatusCode,
            localVarHeaders,
            (GetUploadSourceUrlJobStatusResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetUploadSourceUrlJobStatusResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostGamificationContestsUploadsPrizeimages(GamificationContestPrizeImageUploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostGamificationContestsUploadsPrizeimagesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostGamificationContestsUploadsPrizeimagesWithHttpInfo(GamificationContestPrizeImageUploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostGamificationContestsUploadsPrizeimages");
        }

        var localVarPath = "/api/v2/gamification/contests/uploads/prizeimages";
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
            throw new ApiException(localVarStatusCode, "Error calling PostGamificationContestsUploadsPrizeimages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGamificationContestsUploadsPrizeimages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostGamificationContestsUploadsPrizeimagesAsync(GamificationContestPrizeImageUploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostGamificationContestsUploadsPrizeimagesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostGamificationContestsUploadsPrizeimagesAsyncWithHttpInfo(GamificationContestPrizeImageUploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostGamificationContestsUploadsPrizeimages");
        }

        var localVarPath = "/api/v2/gamification/contests/uploads/prizeimages";
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
            throw new ApiException(localVarStatusCode, "Error calling PostGamificationContestsUploadsPrizeimages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGamificationContestsUploadsPrizeimages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create upload presigned URL for draft function package file. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>FunctionUploadResponse</returns>

    public FunctionUploadResponse PostIntegrationsActionDraftFunctionUpload(string actionId, FunctionUploadRequest body)
    {
        ApiResponse<FunctionUploadResponse> localVarResponse = PostIntegrationsActionDraftFunctionUploadWithHttpInfo(actionId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create upload presigned URL for draft function package file. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>ApiResponse of FunctionUploadResponse</returns>

    public ApiResponse<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadWithHttpInfo(string actionId, FunctionUploadRequest body)
    {
        // verify the required parameter 'actionId' is set
        if (actionId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionId' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
        }

        var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/function/upload";
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
        if (actionId != null)
        {
            localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FunctionUploadResponse>(localVarStatusCode,
            localVarHeaders,
            (FunctionUploadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunctionUploadResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create upload presigned URL for draft function package file. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>Task of FunctionUploadResponse</returns>

    public async Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync(string actionId, FunctionUploadRequest body)
    {
        ApiResponse<FunctionUploadResponse> localVarResponse = await PostIntegrationsActionDraftFunctionUploadAsyncWithHttpInfo(actionId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create upload presigned URL for draft function package file. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="actionId">actionId</param>
    /// <param name="body">Input used to request URL upload.</param>
    /// <returns>Task of ApiResponse (FunctionUploadResponse)</returns>

    public async Task<ApiResponse<FunctionUploadResponse>> PostIntegrationsActionDraftFunctionUploadAsyncWithHttpInfo(string actionId, FunctionUploadRequest body)
    {
        // verify the required parameter 'actionId' is set
        if (actionId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionId' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
        }

        var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/function/upload";
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
        if (actionId != null)
        {
            localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<FunctionUploadResponse>(localVarStatusCode,
            localVarHeaders,
            (FunctionUploadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunctionUploadResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostKnowledgeDocumentuploads(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostKnowledgeDocumentuploadsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostKnowledgeDocumentuploadsWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeDocumentuploads");
        }

        var localVarPath = "/api/v2/knowledge/documentuploads";
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
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostKnowledgeDocumentuploadsAsync(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostKnowledgeDocumentuploadsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostKnowledgeDocumentuploadsAsyncWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeDocumentuploads");
        }

        var localVarPath = "/api/v2/knowledge/documentuploads";
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
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create content upload from URL job 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>CreateUploadSourceUrlJobResponse</returns>

    public CreateUploadSourceUrlJobResponse PostKnowledgeKnowledgebaseUploadsUrlsJobs(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
    {
        ApiResponse<CreateUploadSourceUrlJobResponse> localVarResponse = PostKnowledgeKnowledgebaseUploadsUrlsJobsWithHttpInfo(knowledgeBaseId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create content upload from URL job 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>ApiResponse of CreateUploadSourceUrlJobResponse</returns>

    public ApiResponse<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsWithHttpInfo(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
    {
        // verify the required parameter 'knowledgeBaseId' is set
        if (knowledgeBaseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
        }

        var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs";
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
        if (knowledgeBaseId != null)
        {
            localVarPathParams.Add("knowledgeBaseId", Configuration.ApiClient.ParameterToString(knowledgeBaseId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CreateUploadSourceUrlJobResponse>(localVarStatusCode,
            localVarHeaders,
            (CreateUploadSourceUrlJobResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateUploadSourceUrlJobResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create content upload from URL job 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>Task of CreateUploadSourceUrlJobResponse</returns>

    public async Task<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
    {
        ApiResponse<CreateUploadSourceUrlJobResponse> localVarResponse = await PostKnowledgeKnowledgebaseUploadsUrlsJobsAsyncWithHttpInfo(knowledgeBaseId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create content upload from URL job 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">uploadRequest</param>
    /// <returns>Task of ApiResponse (CreateUploadSourceUrlJobResponse)</returns>

    public async Task<ApiResponse<CreateUploadSourceUrlJobResponse>> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsyncWithHttpInfo(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
    {
        // verify the required parameter 'knowledgeBaseId' is set
        if (knowledgeBaseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
        }

        var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs";
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
        if (knowledgeBaseId != null)
        {
            localVarPathParams.Add("knowledgeBaseId", Configuration.ApiClient.ParameterToString(knowledgeBaseId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CreateUploadSourceUrlJobResponse>(localVarStatusCode,
            localVarHeaders,
            (CreateUploadSourceUrlJobResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateUploadSourceUrlJobResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostLanguageunderstandingMinerUploads(string minerId, object body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostLanguageunderstandingMinerUploadsWithHttpInfo(minerId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostLanguageunderstandingMinerUploadsWithHttpInfo(string minerId, object body)
    {
        // verify the required parameter 'minerId' is set
        if (minerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'minerId' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
        }

        var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/uploads";
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
        if (minerId != null)
        {
            localVarPathParams.Add("minerId", Configuration.ApiClient.ParameterToString(minerId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostLanguageunderstandingMinerUploadsAsync(string minerId, object body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostLanguageunderstandingMinerUploadsAsyncWithHttpInfo(minerId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostLanguageunderstandingMinerUploadsAsyncWithHttpInfo(string minerId, object body)
    {
        // verify the required parameter 'minerId' is set
        if (minerId == null)
        {
            throw new ApiException(400, "Missing required parameter 'minerId' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
        }

        var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/uploads";
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
        if (minerId != null)
        {
            localVarPathParams.Add("minerId", Configuration.ApiClient.ParameterToString(minerId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostUploadsLearningCoverart(LearningCoverArtUploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsLearningCoverartWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostUploadsLearningCoverartWithHttpInfo(LearningCoverArtUploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsLearningCoverart");
        }

        var localVarPath = "/api/v2/uploads/learning/coverart";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostUploadsLearningCoverartAsync(LearningCoverArtUploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsLearningCoverartAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostUploadsLearningCoverartAsyncWithHttpInfo(LearningCoverArtUploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsLearningCoverart");
        }

        var localVarPath = "/api/v2/uploads/learning/coverart";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates presigned url for uploading a public asset image 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostUploadsPublicassetsImages(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsPublicassetsImagesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates presigned url for uploading a public asset image 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostUploadsPublicassetsImagesWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsPublicassetsImages");
        }

        var localVarPath = "/api/v2/uploads/publicassets/images";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates presigned url for uploading a public asset image 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostUploadsPublicassetsImagesAsync(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsPublicassetsImagesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates presigned url for uploading a public asset image 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostUploadsPublicassetsImagesAsyncWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsPublicassetsImages");
        }

        var localVarPath = "/api/v2/uploads/publicassets/images";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates presigned url for uploading a recording file 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostUploadsRecordings(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsRecordingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates presigned url for uploading a recording file 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostUploadsRecordingsWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsRecordings");
        }

        var localVarPath = "/api/v2/uploads/recordings";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates presigned url for uploading a recording file 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostUploadsRecordingsAsync(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsRecordingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates presigned url for uploading a recording file 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostUploadsRecordingsAsyncWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsRecordings");
        }

        var localVarPath = "/api/v2/uploads/recordings";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>UploadUrlResponse</returns>

    public UploadUrlResponse PostUploadsWorkforcemanagementHistoricaldataCsv(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsWorkforcemanagementHistoricaldataCsvWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>ApiResponse of UploadUrlResponse</returns>

    public ApiResponse<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsWorkforcemanagementHistoricaldataCsv");
        }

        var localVarPath = "/api/v2/uploads/workforcemanagement/historicaldata/csv";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of UploadUrlResponse</returns>

    public async Task<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvAsync(UploadUrlRequest body)
    {
        ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsWorkforcemanagementHistoricaldataCsvAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">query</param>
    /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>

    public async Task<ApiResponse<UploadUrlResponse>> PostUploadsWorkforcemanagementHistoricaldataCsvAsyncWithHttpInfo(UploadUrlRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsWorkforcemanagementHistoricaldataCsv");
        }

        var localVarPath = "/api/v2/uploads/workforcemanagement/historicaldata/csv";
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
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
            localVarHeaders,
            (UploadUrlResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
