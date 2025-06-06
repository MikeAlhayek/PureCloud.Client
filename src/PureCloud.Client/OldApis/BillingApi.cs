using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBillingApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Get a report of the billable license usages
    /// </summary>
    /// <remarks>
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>BillingUsageReport</returns>

    BillingUsageReport GetBillingReportsBillableusage(DateTime? startDate, DateTime? endDate);

    /// <summary>
    /// Get a report of the billable license usages
    /// </summary>
    /// <remarks>
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>ApiResponse of BillingUsageReport</returns>

    ApiResponse<BillingUsageReport> GetBillingReportsBillableusageWithHttpInfo(DateTime? startDate, DateTime? endDate);

    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner.
    /// </summary>
    /// <remarks>
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>TrusteeBillingOverview</returns>

    TrusteeBillingOverview GetBillingTrusteebillingoverviewTrustorOrgId(string trustorOrgId, int? billingPeriodIndex = null);

    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner.
    /// </summary>
    /// <remarks>
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>ApiResponse of TrusteeBillingOverview</returns>

    ApiResponse<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdWithHttpInfo(string trustorOrgId, int? billingPeriodIndex = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get a report of the billable license usages
    /// </summary>
    /// <remarks>
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>Task of BillingUsageReport</returns>

    Task<BillingUsageReport> GetBillingReportsBillableusageAsync(DateTime? startDate, DateTime? endDate);

    /// <summary>
    /// Get a report of the billable license usages
    /// </summary>
    /// <remarks>
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>Task of ApiResponse (BillingUsageReport)</returns>

    Task<ApiResponse<BillingUsageReport>> GetBillingReportsBillableusageAsyncWithHttpInfo(DateTime? startDate, DateTime? endDate);

    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner.
    /// </summary>
    /// <remarks>
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>Task of TrusteeBillingOverview</returns>

    Task<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdAsync(string trustorOrgId, int? billingPeriodIndex = null);

    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner.
    /// </summary>
    /// <remarks>
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>Task of ApiResponse (TrusteeBillingOverview)</returns>

    Task<ApiResponse<TrusteeBillingOverview>> GetBillingTrusteebillingoverviewTrustorOrgIdAsyncWithHttpInfo(string trustorOrgId, int? billingPeriodIndex = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class BillingApi : IBillingApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BillingApi"/> class.
    /// </summary>
    /// <returns></returns>
    public BillingApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BillingApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public BillingApi(Configuration configuration = null)
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
    /// Get a report of the billable license usages 
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>BillingUsageReport</returns>

    public BillingUsageReport GetBillingReportsBillableusage(DateTime? startDate, DateTime? endDate)
    {
        ApiResponse<BillingUsageReport> localVarResponse = GetBillingReportsBillableusageWithHttpInfo(startDate, endDate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a report of the billable license usages 
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>ApiResponse of BillingUsageReport</returns>

    public ApiResponse<BillingUsageReport> GetBillingReportsBillableusageWithHttpInfo(DateTime? startDate, DateTime? endDate)
    {
        // verify the required parameter 'startDate' is set
        if (startDate == null)
        {
            throw new ApiException(400, "Missing required parameter 'startDate' when calling BillingApi->GetBillingReportsBillableusage");
        }
        // verify the required parameter 'endDate' is set
        if (endDate == null)
        {
            throw new ApiException(400, "Missing required parameter 'endDate' when calling BillingApi->GetBillingReportsBillableusage");
        }

        var localVarPath = "/api/v2/billing/reports/billableusage";
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
        if (startDate != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("startDate", Configuration.ApiClient.ParameterToString(startDate)));
        }

        if (endDate != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("endDate", Configuration.ApiClient.ParameterToString(endDate)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BillingUsageReport>(localVarStatusCode,
            localVarHeaders,
            (BillingUsageReport)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingUsageReport)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a report of the billable license usages 
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>Task of BillingUsageReport</returns>

    public async Task<BillingUsageReport> GetBillingReportsBillableusageAsync(DateTime? startDate, DateTime? endDate)
    {
        ApiResponse<BillingUsageReport> localVarResponse = await GetBillingReportsBillableusageAsyncWithHttpInfo(startDate, endDate);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a report of the billable license usages 
    /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
    /// <returns>Task of ApiResponse (BillingUsageReport)</returns>

    public async Task<ApiResponse<BillingUsageReport>> GetBillingReportsBillableusageAsyncWithHttpInfo(DateTime? startDate, DateTime? endDate)
    {
        // verify the required parameter 'startDate' is set
        if (startDate == null)
        {
            throw new ApiException(400, "Missing required parameter 'startDate' when calling BillingApi->GetBillingReportsBillableusage");
        }

        // verify the required parameter 'endDate' is set
        if (endDate == null)
        {
            throw new ApiException(400, "Missing required parameter 'endDate' when calling BillingApi->GetBillingReportsBillableusage");
        }

        var localVarPath = "/api/v2/billing/reports/billableusage";
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
        if (startDate != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("startDate", Configuration.ApiClient.ParameterToString(startDate)));
        }

        if (endDate != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("endDate", Configuration.ApiClient.ParameterToString(endDate)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BillingUsageReport>(localVarStatusCode,
            localVarHeaders,
            (BillingUsageReport)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingUsageReport)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner. 
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>TrusteeBillingOverview</returns>

    public TrusteeBillingOverview GetBillingTrusteebillingoverviewTrustorOrgId(string trustorOrgId, int? billingPeriodIndex = null)
    {
        ApiResponse<TrusteeBillingOverview> localVarResponse = GetBillingTrusteebillingoverviewTrustorOrgIdWithHttpInfo(trustorOrgId, billingPeriodIndex);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner. 
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>ApiResponse of TrusteeBillingOverview</returns>

    public ApiResponse<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdWithHttpInfo(string trustorOrgId, int? billingPeriodIndex = null)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling BillingApi->GetBillingTrusteebillingoverviewTrustorOrgId");
        }

        var localVarPath = "/api/v2/billing/trusteebillingoverview/{trustorOrgId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        // Query params
        if (billingPeriodIndex != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("billingPeriodIndex", Configuration.ApiClient.ParameterToString(billingPeriodIndex)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrusteeBillingOverview>(localVarStatusCode,
            localVarHeaders,
            (TrusteeBillingOverview)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrusteeBillingOverview)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner. 
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>Task of TrusteeBillingOverview</returns>

    public async Task<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdAsync(string trustorOrgId, int? billingPeriodIndex = null)
    {
        ApiResponse<TrusteeBillingOverview> localVarResponse = await GetBillingTrusteebillingoverviewTrustorOrgIdAsyncWithHttpInfo(trustorOrgId, billingPeriodIndex);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the billing overview for an organization that is managed by a partner. 
    /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloudEnvironment API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
    /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
    /// <returns>Task of ApiResponse (TrusteeBillingOverview)</returns>

    public async Task<ApiResponse<TrusteeBillingOverview>> GetBillingTrusteebillingoverviewTrustorOrgIdAsyncWithHttpInfo(string trustorOrgId, int? billingPeriodIndex = null)
    {
        // verify the required parameter 'trustorOrgId' is set
        if (trustorOrgId == null)
        {
            throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling BillingApi->GetBillingTrusteebillingoverviewTrustorOrgId");
        }

        var localVarPath = "/api/v2/billing/trusteebillingoverview/{trustorOrgId}";
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
        if (trustorOrgId != null)
        {
            localVarPathParams.Add("trustorOrgId", Configuration.ApiClient.ParameterToString(trustorOrgId));
        }

        // Query params
        if (billingPeriodIndex != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("billingPeriodIndex", Configuration.ApiClient.ParameterToString(billingPeriodIndex)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TrusteeBillingOverview>(localVarStatusCode,
            localVarHeaders,
            (TrusteeBillingOverview)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrusteeBillingOverview)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
