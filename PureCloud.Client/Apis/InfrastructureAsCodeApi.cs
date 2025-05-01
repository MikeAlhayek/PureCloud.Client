using PureCloud.Client;
using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IInfrastructureAsCodeApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get information about an accelerator
    /// </summary>
    /// <remarks>
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>AcceleratorSpecification</returns>

    AcceleratorSpecification GetInfrastructureascodeAccelerator(string acceleratorId, string preferredLanguage = null);

    /// <summary>
    /// Get information about an accelerator
    /// </summary>
    /// <remarks>
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>ApiResponse of AcceleratorSpecification</returns>

    ApiResponse<AcceleratorSpecification> GetInfrastructureascodeAcceleratorWithHttpInfo(string acceleratorId, string preferredLanguage = null);

    /// <summary>
    /// Get a list of available accelerators
    /// </summary>
    /// <remarks>
    /// Search for accelerators that can be run.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>AcceleratorList</returns>

    AcceleratorList GetInfrastructureascodeAccelerators(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null);

    /// <summary>
    /// Get a list of available accelerators
    /// </summary>
    /// <remarks>
    /// Search for accelerators that can be run.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>ApiResponse of AcceleratorList</returns>

    ApiResponse<AcceleratorList> GetInfrastructureascodeAcceleratorsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null);

    /// <summary>
    /// Get job status and results
    /// </summary>
    /// <remarks>
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>InfrastructureascodeJob</returns>

    InfrastructureascodeJob GetInfrastructureascodeJob(string jobId, bool? details = null);

    /// <summary>
    /// Get job status and results
    /// </summary>
    /// <remarks>
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>ApiResponse of InfrastructureascodeJob</returns>

    ApiResponse<InfrastructureascodeJob> GetInfrastructureascodeJobWithHttpInfo(string jobId, bool? details = null);

    /// <summary>
    /// Get job history
    /// </summary>
    /// <remarks>
    /// Get a history of submitted jobs, optionally including error messages.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>InfrastructureascodeJob</returns>

    InfrastructureascodeJob GetInfrastructureascodeJobs(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null);

    /// <summary>
    /// Get job history
    /// </summary>
    /// <remarks>
    /// Get a history of submitted jobs, optionally including error messages.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>ApiResponse of InfrastructureascodeJob</returns>

    ApiResponse<InfrastructureascodeJob> GetInfrastructureascodeJobsWithHttpInfo(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null);

    /// <summary>
    /// Create a Job
    /// </summary>
    /// <remarks>
    /// Create and submit a job for remote execution or see job planning results.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>InfrastructureascodeJob</returns>

    InfrastructureascodeJob PostInfrastructureascodeJobs(AcceleratorInput body);

    /// <summary>
    /// Create a Job
    /// </summary>
    /// <remarks>
    /// Create and submit a job for remote execution or see job planning results.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of InfrastructureascodeJob</returns>

    ApiResponse<InfrastructureascodeJob> PostInfrastructureascodeJobsWithHttpInfo(AcceleratorInput body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get information about an accelerator
    /// </summary>
    /// <remarks>
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>Task of AcceleratorSpecification</returns>

    Task<AcceleratorSpecification> GetInfrastructureascodeAcceleratorAsync(string acceleratorId, string preferredLanguage = null);

    /// <summary>
    /// Get information about an accelerator
    /// </summary>
    /// <remarks>
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>Task of ApiResponse (AcceleratorSpecification)</returns>

    Task<ApiResponse<AcceleratorSpecification>> GetInfrastructureascodeAcceleratorAsyncWithHttpInfo(string acceleratorId, string preferredLanguage = null);

    /// <summary>
    /// Get a list of available accelerators
    /// </summary>
    /// <remarks>
    /// Search for accelerators that can be run.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>Task of AcceleratorList</returns>

    Task<AcceleratorList> GetInfrastructureascodeAcceleratorsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null);

    /// <summary>
    /// Get a list of available accelerators
    /// </summary>
    /// <remarks>
    /// Search for accelerators that can be run.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>Task of ApiResponse (AcceleratorList)</returns>

    Task<ApiResponse<AcceleratorList>> GetInfrastructureascodeAcceleratorsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null);

    /// <summary>
    /// Get job status and results
    /// </summary>
    /// <remarks>
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>Task of InfrastructureascodeJob</returns>

    Task<InfrastructureascodeJob> GetInfrastructureascodeJobAsync(string jobId, bool? details = null);

    /// <summary>
    /// Get job status and results
    /// </summary>
    /// <remarks>
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>

    Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobAsyncWithHttpInfo(string jobId, bool? details = null);

    /// <summary>
    /// Get job history
    /// </summary>
    /// <remarks>
    /// Get a history of submitted jobs, optionally including error messages.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>Task of InfrastructureascodeJob</returns>

    Task<InfrastructureascodeJob> GetInfrastructureascodeJobsAsync(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null);

    /// <summary>
    /// Get job history
    /// </summary>
    /// <remarks>
    /// Get a history of submitted jobs, optionally including error messages.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>

    Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobsAsyncWithHttpInfo(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null);

    /// <summary>
    /// Create a Job
    /// </summary>
    /// <remarks>
    /// Create and submit a job for remote execution or see job planning results.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of InfrastructureascodeJob</returns>

    Task<InfrastructureascodeJob> PostInfrastructureascodeJobsAsync(AcceleratorInput body);

    /// <summary>
    /// Create a Job
    /// </summary>
    /// <remarks>
    /// Create and submit a job for remote execution or see job planning results.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>

    Task<ApiResponse<InfrastructureascodeJob>> PostInfrastructureascodeJobsAsyncWithHttpInfo(AcceleratorInput body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class InfrastructureAsCodeApi : IInfrastructureAsCodeApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InfrastructureAsCodeApi"/> class.
    /// </summary>
    /// <returns></returns>
    public InfrastructureAsCodeApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InfrastructureAsCodeApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public InfrastructureAsCodeApi(Configuration configuration = null)
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
    /// Get information about an accelerator 
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>AcceleratorSpecification</returns>

    public AcceleratorSpecification GetInfrastructureascodeAccelerator(string acceleratorId, string preferredLanguage = null)
    {
        ApiResponse<AcceleratorSpecification> localVarResponse = GetInfrastructureascodeAcceleratorWithHttpInfo(acceleratorId, preferredLanguage);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get information about an accelerator 
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>ApiResponse of AcceleratorSpecification</returns>

    public ApiResponse<AcceleratorSpecification> GetInfrastructureascodeAcceleratorWithHttpInfo(string acceleratorId, string preferredLanguage = null)
    {
        // verify the required parameter 'acceleratorId' is set
        if (acceleratorId == null)
        {
            throw new ApiException(400, "Missing required parameter 'acceleratorId' when calling InfrastructureAsCodeApi->GetInfrastructureascodeAccelerator");
        }

        var localVarPath = "/api/v2/infrastructureascode/accelerators/{acceleratorId}";
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
        if (acceleratorId != null)
        {
            localVarPathParams.Add("acceleratorId", Configuration.ApiClient.ParameterToString(acceleratorId));
        }

        // Query params
        if (preferredLanguage != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("preferredLanguage", Configuration.ApiClient.ParameterToString(preferredLanguage)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerator: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerator: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AcceleratorSpecification>(localVarStatusCode,
            localVarHeaders,
            (AcceleratorSpecification)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceleratorSpecification)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get information about an accelerator 
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>Task of AcceleratorSpecification</returns>

    public async Task<AcceleratorSpecification> GetInfrastructureascodeAcceleratorAsync(string acceleratorId, string preferredLanguage = null)
    {
        ApiResponse<AcceleratorSpecification> localVarResponse = await GetInfrastructureascodeAcceleratorAsyncWithHttpInfo(acceleratorId, preferredLanguage);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get information about an accelerator 
    /// Get the complete metadata specification for an accelerator, including requirements and parameters.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="acceleratorId">Accelerator ID</param>
    /// <param name="preferredLanguage">Preferred Language (optional, default to en-US)</param>
    /// <returns>Task of ApiResponse (AcceleratorSpecification)</returns>

    public async Task<ApiResponse<AcceleratorSpecification>> GetInfrastructureascodeAcceleratorAsyncWithHttpInfo(string acceleratorId, string preferredLanguage = null)
    {
        // verify the required parameter 'acceleratorId' is set
        if (acceleratorId == null)
        {
            throw new ApiException(400, "Missing required parameter 'acceleratorId' when calling InfrastructureAsCodeApi->GetInfrastructureascodeAccelerator");
        }

        var localVarPath = "/api/v2/infrastructureascode/accelerators/{acceleratorId}";
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
        if (acceleratorId != null)
        {
            localVarPathParams.Add("acceleratorId", Configuration.ApiClient.ParameterToString(acceleratorId));
        }

        // Query params
        if (preferredLanguage != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("preferredLanguage", Configuration.ApiClient.ParameterToString(preferredLanguage)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerator: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerator: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AcceleratorSpecification>(localVarStatusCode,
            localVarHeaders,
            (AcceleratorSpecification)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceleratorSpecification)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a list of available accelerators 
    /// Search for accelerators that can be run.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>AcceleratorList</returns>

    public AcceleratorList GetInfrastructureascodeAccelerators(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null)
    {
        ApiResponse<AcceleratorList> localVarResponse = GetInfrastructureascodeAcceleratorsWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, description, origin, type, classification, tags);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of available accelerators 
    /// Search for accelerators that can be run.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>ApiResponse of AcceleratorList</returns>

    public ApiResponse<AcceleratorList> GetInfrastructureascodeAcceleratorsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null)
    {

        var localVarPath = "/api/v2/infrastructureascode/accelerators";
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

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (description != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
        }

        if (origin != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("origin", Configuration.ApiClient.ParameterToString(origin)));
        }

        if (type != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("type", Configuration.ApiClient.ParameterToString(type)));
        }

        if (classification != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("classification", Configuration.ApiClient.ParameterToString(classification)));
        }

        if (tags != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("tags", Configuration.ApiClient.ParameterToString(tags)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerators: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerators: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AcceleratorList>(localVarStatusCode,
            localVarHeaders,
            (AcceleratorList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceleratorList)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a list of available accelerators 
    /// Search for accelerators that can be run.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>Task of AcceleratorList</returns>

    public async Task<AcceleratorList> GetInfrastructureascodeAcceleratorsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null)
    {
        ApiResponse<AcceleratorList> localVarResponse = await GetInfrastructureascodeAcceleratorsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, description, origin, type, classification, tags);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a list of available accelerators 
    /// Search for accelerators that can be run.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
    /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
    /// <param name="sortBy">variable name requested to sort by (optional)</param>
    /// <param name="sortOrder">Sort order (optional, default to asc)</param>
    /// <param name="name">Filter by name (optional)</param>
    /// <param name="description">Filter by description (optional)</param>
    /// <param name="origin">Filter by origin (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="classification">Filter by classification (optional)</param>
    /// <param name="tags">Filter by tags (optional)</param>
    /// <returns>Task of ApiResponse (AcceleratorList)</returns>

    public async Task<ApiResponse<AcceleratorList>> GetInfrastructureascodeAcceleratorsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null)
    {

        var localVarPath = "/api/v2/infrastructureascode/accelerators";
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

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (description != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
        }

        if (origin != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("origin", Configuration.ApiClient.ParameterToString(origin)));
        }

        if (type != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("type", Configuration.ApiClient.ParameterToString(type)));
        }

        if (classification != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("classification", Configuration.ApiClient.ParameterToString(classification)));
        }

        if (tags != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("tags", Configuration.ApiClient.ParameterToString(tags)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerators: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeAccelerators: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AcceleratorList>(localVarStatusCode,
            localVarHeaders,
            (AcceleratorList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceleratorList)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get job status and results 
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>InfrastructureascodeJob</returns>

    public InfrastructureascodeJob GetInfrastructureascodeJob(string jobId, bool? details = null)
    {
        ApiResponse<InfrastructureascodeJob> localVarResponse = GetInfrastructureascodeJobWithHttpInfo(jobId, details);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get job status and results 
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>ApiResponse of InfrastructureascodeJob</returns>

    public ApiResponse<InfrastructureascodeJob> GetInfrastructureascodeJobWithHttpInfo(string jobId, bool? details = null)
    {
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling InfrastructureAsCodeApi->GetInfrastructureascodeJob");
        }

        var localVarPath = "/api/v2/infrastructureascode/jobs/{jobId}";
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
        if (details != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("details", Configuration.ApiClient.ParameterToString(details)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
            localVarHeaders,
            (InfrastructureascodeJob)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get job status and results 
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>Task of InfrastructureascodeJob</returns>

    public async Task<InfrastructureascodeJob> GetInfrastructureascodeJobAsync(string jobId, bool? details = null)
    {
        ApiResponse<InfrastructureascodeJob> localVarResponse = await GetInfrastructureascodeJobAsyncWithHttpInfo(jobId, details);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get job status and results 
    /// Get the execution status of a submitted job, optionally including results and error details.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="jobId">Job ID</param>
    /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
    /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>

    public async Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobAsyncWithHttpInfo(string jobId, bool? details = null)
    {
        // verify the required parameter 'jobId' is set
        if (jobId == null)
        {
            throw new ApiException(400, "Missing required parameter 'jobId' when calling InfrastructureAsCodeApi->GetInfrastructureascodeJob");
        }

        var localVarPath = "/api/v2/infrastructureascode/jobs/{jobId}";
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
        if (details != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("details", Configuration.ApiClient.ParameterToString(details)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
            localVarHeaders,
            (InfrastructureascodeJob)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get job history 
    /// Get a history of submitted jobs, optionally including error messages.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>InfrastructureascodeJob</returns>

    public InfrastructureascodeJob GetInfrastructureascodeJobs(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null)
    {
        ApiResponse<InfrastructureascodeJob> localVarResponse = GetInfrastructureascodeJobsWithHttpInfo(maxResults, includeErrors, sortBy, sortOrder, acceleratorId, submittedBy, status);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get job history 
    /// Get a history of submitted jobs, optionally including error messages.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>ApiResponse of InfrastructureascodeJob</returns>

    public ApiResponse<InfrastructureascodeJob> GetInfrastructureascodeJobsWithHttpInfo(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null)
    {

        var localVarPath = "/api/v2/infrastructureascode/jobs";
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
        if (maxResults != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("maxResults", Configuration.ApiClient.ParameterToString(maxResults)));
        }

        if (includeErrors != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("includeErrors", Configuration.ApiClient.ParameterToString(includeErrors)));
        }

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (acceleratorId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("acceleratorId", Configuration.ApiClient.ParameterToString(acceleratorId)));
        }

        if (submittedBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("submittedBy", Configuration.ApiClient.ParameterToString(submittedBy)));
        }

        if (status != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("status", Configuration.ApiClient.ParameterToString(status)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
            localVarHeaders,
            (InfrastructureascodeJob)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get job history 
    /// Get a history of submitted jobs, optionally including error messages.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>Task of InfrastructureascodeJob</returns>

    public async Task<InfrastructureascodeJob> GetInfrastructureascodeJobsAsync(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null)
    {
        ApiResponse<InfrastructureascodeJob> localVarResponse = await GetInfrastructureascodeJobsAsyncWithHttpInfo(maxResults, includeErrors, sortBy, sortOrder, acceleratorId, submittedBy, status);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get job history 
    /// Get a history of submitted jobs, optionally including error messages.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
    /// <param name="includeErrors">Include error messages (optional, default to false)</param>
    /// <param name="sortBy">Sort by (optional, default to dateSubmitted)</param>
    /// <param name="sortOrder">Sort order (optional, default to desc)</param>
    /// <param name="acceleratorId">Find only jobs associated with this accelerator (optional)</param>
    /// <param name="submittedBy">Find only jobs submitted by this user (optional)</param>
    /// <param name="status">Find only jobs in this state (optional)</param>
    /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>

    public async Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobsAsyncWithHttpInfo(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null)
    {

        var localVarPath = "/api/v2/infrastructureascode/jobs";
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
        if (maxResults != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("maxResults", Configuration.ApiClient.ParameterToString(maxResults)));
        }

        if (includeErrors != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("includeErrors", Configuration.ApiClient.ParameterToString(includeErrors)));
        }

        if (sortBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
        }

        if (acceleratorId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("acceleratorId", Configuration.ApiClient.ParameterToString(acceleratorId)));
        }

        if (submittedBy != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("submittedBy", Configuration.ApiClient.ParameterToString(submittedBy)));
        }

        if (status != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("status", Configuration.ApiClient.ParameterToString(status)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
            localVarHeaders,
            (InfrastructureascodeJob)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a Job 
    /// Create and submit a job for remote execution or see job planning results.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>InfrastructureascodeJob</returns>

    public InfrastructureascodeJob PostInfrastructureascodeJobs(AcceleratorInput body)
    {
        ApiResponse<InfrastructureascodeJob> localVarResponse = PostInfrastructureascodeJobsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Job 
    /// Create and submit a job for remote execution or see job planning results.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of InfrastructureascodeJob</returns>

    public ApiResponse<InfrastructureascodeJob> PostInfrastructureascodeJobsWithHttpInfo(AcceleratorInput body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling InfrastructureAsCodeApi->PostInfrastructureascodeJobs");
        }

        var localVarPath = "/api/v2/infrastructureascode/jobs";
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
            throw new ApiException(localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
            localVarHeaders,
            (InfrastructureascodeJob)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a Job 
    /// Create and submit a job for remote execution or see job planning results.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of InfrastructureascodeJob</returns>

    public async Task<InfrastructureascodeJob> PostInfrastructureascodeJobsAsync(AcceleratorInput body)
    {
        ApiResponse<InfrastructureascodeJob> localVarResponse = await PostInfrastructureascodeJobsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a Job 
    /// Create and submit a job for remote execution or see job planning results.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>

    public async Task<ApiResponse<InfrastructureascodeJob>> PostInfrastructureascodeJobsAsyncWithHttpInfo(AcceleratorInput body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling InfrastructureAsCodeApi->PostInfrastructureascodeJobs");
        }

        var localVarPath = "/api/v2/infrastructureascode/jobs";
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
            throw new ApiException(localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
            localVarHeaders,
            (InfrastructureascodeJob)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
