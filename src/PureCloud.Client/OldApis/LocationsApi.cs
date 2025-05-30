using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ILocationsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns></returns>

    void DeleteLocation(string locationId);

    /// <summary>
    /// Delete a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteLocationWithHttpInfo(string locationId);

    /// <summary>
    /// Get Location by ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>LocationDefinition</returns>

    LocationDefinition GetLocation(string locationId, List<string> expand = null);

    /// <summary>
    /// Get Location by ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>ApiResponse of LocationDefinition</returns>

    ApiResponse<LocationDefinition> GetLocationWithHttpInfo(string locationId, List<string> expand = null);

    /// <summary>
    /// Get sublocations for location ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>LocationEntityListing</returns>

    LocationEntityListing GetLocationSublocations(string locationId);

    /// <summary>
    /// Get sublocations for location ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>ApiResponse of LocationEntityListing</returns>

    ApiResponse<LocationEntityListing> GetLocationSublocationsWithHttpInfo(string locationId);

    /// <summary>
    /// Get a list of all locations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>LocationEntityListing</returns>

    LocationEntityListing GetLocations(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null);

    /// <summary>
    /// Get a list of all locations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>ApiResponse of LocationEntityListing</returns>

    ApiResponse<LocationEntityListing> GetLocationsWithHttpInfo(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>LocationsSearchResponse</returns>

    LocationsSearchResponse GetLocationsSearch(string q64, List<string> expand = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    ApiResponse<LocationsSearchResponse> GetLocationsSearchWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Update a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>LocationDefinition</returns>

    LocationDefinition PatchLocation(string locationId, LocationUpdateDefinition body);

    /// <summary>
    /// Update a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>ApiResponse of LocationDefinition</returns>

    ApiResponse<LocationDefinition> PatchLocationWithHttpInfo(string locationId, LocationUpdateDefinition body);

    /// <summary>
    /// Create a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>LocationDefinition</returns>

    LocationDefinition PostLocations(LocationCreateDefinition body);

    /// <summary>
    /// Create a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>ApiResponse of LocationDefinition</returns>

    ApiResponse<LocationDefinition> PostLocationsWithHttpInfo(LocationCreateDefinition body);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>LocationsSearchResponse</returns>

    LocationsSearchResponse PostLocationsSearch(LocationSearchRequest body);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    ApiResponse<LocationsSearchResponse> PostLocationsSearchWithHttpInfo(LocationSearchRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of void</returns>

    Task DeleteLocationAsync(string locationId);

    /// <summary>
    /// Delete a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteLocationAsyncWithHttpInfo(string locationId);

    /// <summary>
    /// Get Location by ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of LocationDefinition</returns>

    Task<LocationDefinition> GetLocationAsync(string locationId, List<string> expand = null);

    /// <summary>
    /// Get Location by ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of ApiResponse (LocationDefinition)</returns>

    Task<ApiResponse<LocationDefinition>> GetLocationAsyncWithHttpInfo(string locationId, List<string> expand = null);

    /// <summary>
    /// Get sublocations for location ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of LocationEntityListing</returns>

    Task<LocationEntityListing> GetLocationSublocationsAsync(string locationId);

    /// <summary>
    /// Get sublocations for location ID.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of ApiResponse (LocationEntityListing)</returns>

    Task<ApiResponse<LocationEntityListing>> GetLocationSublocationsAsyncWithHttpInfo(string locationId);

    /// <summary>
    /// Get a list of all locations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>Task of LocationEntityListing</returns>

    Task<LocationEntityListing> GetLocationsAsync(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null);

    /// <summary>
    /// Get a list of all locations.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>Task of ApiResponse (LocationEntityListing)</returns>

    Task<ApiResponse<LocationEntityListing>> GetLocationsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, List<string> expand = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    Task<ApiResponse<LocationsSearchResponse>> GetLocationsSearchAsyncWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Update a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>Task of LocationDefinition</returns>

    Task<LocationDefinition> PatchLocationAsync(string locationId, LocationUpdateDefinition body);

    /// <summary>
    /// Update a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>Task of ApiResponse (LocationDefinition)</returns>

    Task<ApiResponse<LocationDefinition>> PatchLocationAsyncWithHttpInfo(string locationId, LocationUpdateDefinition body);

    /// <summary>
    /// Create a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>Task of LocationDefinition</returns>

    Task<LocationDefinition> PostLocationsAsync(LocationCreateDefinition body);

    /// <summary>
    /// Create a location
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>Task of ApiResponse (LocationDefinition)</returns>

    Task<ApiResponse<LocationDefinition>> PostLocationsAsyncWithHttpInfo(LocationCreateDefinition body);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    Task<LocationsSearchResponse> PostLocationsSearchAsync(LocationSearchRequest body);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    Task<ApiResponse<LocationsSearchResponse>> PostLocationsSearchAsyncWithHttpInfo(LocationSearchRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class LocationsApi : ILocationsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public LocationsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LocationsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public LocationsApi(Configuration configuration = null)
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
    /// Delete a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns></returns>

    public void DeleteLocation(string locationId)
    {
        DeleteLocationWithHttpInfo(locationId);
    }

    /// <summary>
    /// Delete a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteLocationWithHttpInfo(string locationId)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->DeleteLocation");
        }

        var localVarPath = "/api/v2/locations/{locationId}";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteLocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteLocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteLocationAsync(string locationId)
    {
        await DeleteLocationAsyncWithHttpInfo(locationId);

    }

    /// <summary>
    /// Delete a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteLocationAsyncWithHttpInfo(string locationId)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->DeleteLocation");
        }

        var localVarPath = "/api/v2/locations/{locationId}";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteLocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteLocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Location by ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>LocationDefinition</returns>

    public LocationDefinition GetLocation(string locationId, List<string> expand = null)
    {
        ApiResponse<LocationDefinition> localVarResponse = GetLocationWithHttpInfo(locationId, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Location by ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>ApiResponse of LocationDefinition</returns>

    public ApiResponse<LocationDefinition> GetLocationWithHttpInfo(string locationId, List<string> expand = null)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->GetLocation");
        }

        var localVarPath = "/api/v2/locations/{locationId}";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
        }

        // Query params
        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationDefinition>(localVarStatusCode,
            localVarHeaders,
            (LocationDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Location by ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of LocationDefinition</returns>

    public async Task<LocationDefinition> GetLocationAsync(string locationId, List<string> expand = null)
    {
        ApiResponse<LocationDefinition> localVarResponse = await GetLocationAsyncWithHttpInfo(locationId, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Location by ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <returns>Task of ApiResponse (LocationDefinition)</returns>

    public async Task<ApiResponse<LocationDefinition>> GetLocationAsyncWithHttpInfo(string locationId, List<string> expand = null)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->GetLocation");
        }

        var localVarPath = "/api/v2/locations/{locationId}";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
        }

        // Query params
        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationDefinition>(localVarStatusCode,
            localVarHeaders,
            (LocationDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get sublocations for location ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>LocationEntityListing</returns>

    public LocationEntityListing GetLocationSublocations(string locationId)
    {
        ApiResponse<LocationEntityListing> localVarResponse = GetLocationSublocationsWithHttpInfo(locationId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get sublocations for location ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>ApiResponse of LocationEntityListing</returns>

    public ApiResponse<LocationEntityListing> GetLocationSublocationsWithHttpInfo(string locationId)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->GetLocationSublocations");
        }

        var localVarPath = "/api/v2/locations/{locationId}/sublocations";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocationSublocations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationSublocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LocationEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get sublocations for location ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of LocationEntityListing</returns>

    public async Task<LocationEntityListing> GetLocationSublocationsAsync(string locationId)
    {
        ApiResponse<LocationEntityListing> localVarResponse = await GetLocationSublocationsAsyncWithHttpInfo(locationId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get sublocations for location ID. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <returns>Task of ApiResponse (LocationEntityListing)</returns>

    public async Task<ApiResponse<LocationEntityListing>> GetLocationSublocationsAsyncWithHttpInfo(string locationId)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->GetLocationSublocations");
        }

        var localVarPath = "/api/v2/locations/{locationId}/sublocations";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocationSublocations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationSublocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LocationEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a list of all locations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>LocationEntityListing</returns>

    public LocationEntityListing GetLocations(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)
    {
        ApiResponse<LocationEntityListing> localVarResponse = GetLocationsWithHttpInfo(pageSize, pageNumber, id, sortOrder);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of all locations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>ApiResponse of LocationEntityListing</returns>

    public ApiResponse<LocationEntityListing> GetLocationsWithHttpInfo(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)
    {

        var localVarPath = "/api/v2/locations";
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

        if (id != null)
        {
            id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LocationEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a list of all locations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>Task of LocationEntityListing</returns>

    public async Task<LocationEntityListing> GetLocationsAsync(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)
    {
        ApiResponse<LocationEntityListing> localVarResponse = await GetLocationsAsyncWithHttpInfo(pageSize, pageNumber, id, sortOrder);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a list of all locations. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="id">id (optional)</param>
    /// <param name="sortOrder">Sort order (optional)</param>
    /// <returns>Task of ApiResponse (LocationEntityListing)</returns>

    public async Task<ApiResponse<LocationEntityListing>> GetLocationsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)
    {

        var localVarPath = "/api/v2/locations";
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

        if (id != null)
        {
            id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (sortOrder != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationEntityListing>(localVarStatusCode,
            localVarHeaders,
            (LocationEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>LocationsSearchResponse</returns>

    public LocationsSearchResponse GetLocationsSearch(string q64, List<string> expand = null)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = GetLocationsSearchWithHttpInfo(q64, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    public ApiResponse<LocationsSearchResponse> GetLocationsSearchWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling LocationsApi->GetLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
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
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    public async Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, List<string> expand = null)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = await GetLocationsSearchAsyncWithHttpInfo(q64, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    public async Task<ApiResponse<LocationsSearchResponse>> GetLocationsSearchAsyncWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling LocationsApi->GetLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
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
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
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
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>LocationDefinition</returns>

    public LocationDefinition PatchLocation(string locationId, LocationUpdateDefinition body)
    {
        ApiResponse<LocationDefinition> localVarResponse = PatchLocationWithHttpInfo(locationId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>ApiResponse of LocationDefinition</returns>

    public ApiResponse<LocationDefinition> PatchLocationWithHttpInfo(string locationId, LocationUpdateDefinition body)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->PatchLocation");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->PatchLocation");
        }

        var localVarPath = "/api/v2/locations/{locationId}";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchLocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchLocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationDefinition>(localVarStatusCode,
            localVarHeaders,
            (LocationDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>Task of LocationDefinition</returns>

    public async Task<LocationDefinition> PatchLocationAsync(string locationId, LocationUpdateDefinition body)
    {
        ApiResponse<LocationDefinition> localVarResponse = await PatchLocationAsyncWithHttpInfo(locationId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <returns>Task of ApiResponse (LocationDefinition)</returns>

    public async Task<ApiResponse<LocationDefinition>> PatchLocationAsyncWithHttpInfo(string locationId, LocationUpdateDefinition body)
    {
        // verify the required parameter 'locationId' is set
        if (locationId == null)
        {
            throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->PatchLocation");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->PatchLocation");
        }

        var localVarPath = "/api/v2/locations/{locationId}";
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
        if (locationId != null)
        {
            localVarPathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchLocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchLocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationDefinition>(localVarStatusCode,
            localVarHeaders,
            (LocationDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>LocationDefinition</returns>

    public LocationDefinition PostLocations(LocationCreateDefinition body)
    {
        ApiResponse<LocationDefinition> localVarResponse = PostLocationsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>ApiResponse of LocationDefinition</returns>

    public ApiResponse<LocationDefinition> PostLocationsWithHttpInfo(LocationCreateDefinition body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->PostLocations");
        }

        var localVarPath = "/api/v2/locations";
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
            throw new ApiException(localVarStatusCode, "Error calling PostLocations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationDefinition>(localVarStatusCode,
            localVarHeaders,
            (LocationDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>Task of LocationDefinition</returns>

    public async Task<LocationDefinition> PostLocationsAsync(LocationCreateDefinition body)
    {
        ApiResponse<LocationDefinition> localVarResponse = await PostLocationsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a location 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Location</param>
    /// <returns>Task of ApiResponse (LocationDefinition)</returns>

    public async Task<ApiResponse<LocationDefinition>> PostLocationsAsyncWithHttpInfo(LocationCreateDefinition body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->PostLocations");
        }

        var localVarPath = "/api/v2/locations";
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
            throw new ApiException(localVarStatusCode, "Error calling PostLocations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationDefinition>(localVarStatusCode,
            localVarHeaders,
            (LocationDefinition)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationDefinition)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>LocationsSearchResponse</returns>

    public LocationsSearchResponse PostLocationsSearch(LocationSearchRequest body)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = PostLocationsSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    public ApiResponse<LocationsSearchResponse> PostLocationsSearchWithHttpInfo(LocationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->PostLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
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
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    public async Task<LocationsSearchResponse> PostLocationsSearchAsync(LocationSearchRequest body)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = await PostLocationsSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    public async Task<ApiResponse<LocationsSearchResponse>> PostLocationsSearchAsyncWithHttpInfo(LocationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling LocationsApi->PostLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
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
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
