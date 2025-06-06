using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IStationsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Unassigns the user assigned to this station
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns></returns>

    void DeleteStationAssociateduser(string stationId);

    /// <summary>
    /// Unassigns the user assigned to this station
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteStationAssociateduserWithHttpInfo(string stationId);

    /// <summary>
    /// Get station.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Station</returns>

    Station GetStation(string stationId);

    /// <summary>
    /// Get station.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>ApiResponse of Station</returns>

    ApiResponse<Station> GetStationWithHttpInfo(string stationId);

    /// <summary>
    /// Get the list of available stations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>StationEntityListing</returns>

    StationEntityListing GetStations(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);

    /// <summary>
    /// Get the list of available stations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>ApiResponse of StationEntityListing</returns>

    ApiResponse<StationEntityListing> GetStationsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Unassigns the user assigned to this station
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of void</returns>

    Task DeleteStationAssociateduserAsync(string stationId);

    /// <summary>
    /// Unassigns the user assigned to this station
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteStationAssociateduserAsyncWithHttpInfo(string stationId);

    /// <summary>
    /// Get station.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of Station</returns>

    Task<Station> GetStationAsync(string stationId);

    /// <summary>
    /// Get station.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of ApiResponse (Station)</returns>

    Task<ApiResponse<Station>> GetStationAsyncWithHttpInfo(string stationId);

    /// <summary>
    /// Get the list of available stations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>Task of StationEntityListing</returns>

    Task<StationEntityListing> GetStationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);

    /// <summary>
    /// Get the list of available stations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>Task of ApiResponse (StationEntityListing)</returns>

    Task<ApiResponse<StationEntityListing>> GetStationsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class StationsApi : IStationsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StationsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public StationsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StationsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public StationsApi(Configuration configuration = null)
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
    /// Unassigns the user assigned to this station 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns></returns>

    public void DeleteStationAssociateduser(string stationId)
    {
        DeleteStationAssociateduserWithHttpInfo(stationId);
    }

    /// <summary>
    /// Unassigns the user assigned to this station 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteStationAssociateduserWithHttpInfo(string stationId)
    {
        // verify the required parameter 'stationId' is set
        if (stationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->DeleteStationAssociateduser");
        }

        var localVarPath = "/api/v2/stations/{stationId}/associateduser";
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
        if (stationId != null)
        {
            localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Unassigns the user assigned to this station 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteStationAssociateduserAsync(string stationId)
    {
        await DeleteStationAssociateduserAsyncWithHttpInfo(stationId);

    }

    /// <summary>
    /// Unassigns the user assigned to this station 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteStationAssociateduserAsyncWithHttpInfo(string stationId)
    {
        // verify the required parameter 'stationId' is set
        if (stationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->DeleteStationAssociateduser");
        }

        var localVarPath = "/api/v2/stations/{stationId}/associateduser";
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
        if (stationId != null)
        {
            localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get station. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Station</returns>

    public Station GetStation(string stationId)
    {
        ApiResponse<Station> localVarResponse = GetStationWithHttpInfo(stationId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get station. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>ApiResponse of Station</returns>

    public ApiResponse<Station> GetStationWithHttpInfo(string stationId)
    {
        // verify the required parameter 'stationId' is set
        if (stationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->GetStation");
        }

        var localVarPath = "/api/v2/stations/{stationId}";
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
        if (stationId != null)
        {
            localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetStation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetStation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Station>(localVarStatusCode,
            localVarHeaders,
            (Station)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Station)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get station. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of Station</returns>

    public async Task<Station> GetStationAsync(string stationId)
    {
        ApiResponse<Station> localVarResponse = await GetStationAsyncWithHttpInfo(stationId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get station. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="stationId">Station ID</param>
    /// <returns>Task of ApiResponse (Station)</returns>

    public async Task<ApiResponse<Station>> GetStationAsyncWithHttpInfo(string stationId)
    {
        // verify the required parameter 'stationId' is set
        if (stationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->GetStation");
        }

        var localVarPath = "/api/v2/stations/{stationId}";
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
        if (stationId != null)
        {
            localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetStation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetStation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Station>(localVarStatusCode,
            localVarHeaders,
            (Station)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Station)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the list of available stations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>StationEntityListing</returns>

    public StationEntityListing GetStations(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
    {
        ApiResponse<StationEntityListing> localVarResponse = GetStationsWithHttpInfo(pageSize, pageNumber, sortBy, name, userSelectable, webRtcUserId, id, lineAppearanceId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the list of available stations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>ApiResponse of StationEntityListing</returns>

    public ApiResponse<StationEntityListing> GetStationsWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
    {

        var localVarPath = "/api/v2/stations";
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

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (userSelectable != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("userSelectable", Configuration.ApiClient.ParameterToString(userSelectable)));
        }

        if (webRtcUserId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("webRtcUserId", Configuration.ApiClient.ParameterToString(webRtcUserId)));
        }

        if (id != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
        }

        if (lineAppearanceId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("lineAppearanceId", Configuration.ApiClient.ParameterToString(lineAppearanceId)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetStations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetStations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<StationEntityListing>(localVarStatusCode,
            localVarHeaders,
            (StationEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(StationEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the list of available stations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>Task of StationEntityListing</returns>

    public async Task<StationEntityListing> GetStationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
    {
        ApiResponse<StationEntityListing> localVarResponse = await GetStationsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name, userSelectable, webRtcUserId, id, lineAppearanceId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the list of available stations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="sortBy">Sort by (optional, default to "name")</param>
    /// <param name="name">Name (optional)</param>
    /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
    /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
    /// <param name="id">Comma separated list of stationIds (optional)</param>
    /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
    /// <returns>Task of ApiResponse (StationEntityListing)</returns>

    public async Task<ApiResponse<StationEntityListing>> GetStationsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
    {

        var localVarPath = "/api/v2/stations";
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

        if (name != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
        }

        if (userSelectable != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("userSelectable", Configuration.ApiClient.ParameterToString(userSelectable)));
        }

        if (webRtcUserId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("webRtcUserId", Configuration.ApiClient.ParameterToString(webRtcUserId)));
        }

        if (id != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
        }

        if (lineAppearanceId != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("lineAppearanceId", Configuration.ApiClient.ParameterToString(lineAppearanceId)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetStations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetStations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<StationEntityListing>(localVarStatusCode,
            localVarHeaders,
            (StationEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(StationEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
