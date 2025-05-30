using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INotificationsApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Remove all subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns></returns>

    void DeleteNotificationsChannelSubscriptions(string channelId);

    /// <summary>
    /// Remove all subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteNotificationsChannelSubscriptionsWithHttpInfo(string channelId);

    /// <summary>
    /// Get available notification topics.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>AvailableTopicEntityListing</returns>

    AvailableTopicEntityListing GetNotificationsAvailabletopics(List<string> expand = null, bool? includePreview = null);

    /// <summary>
    /// Get available notification topics.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>ApiResponse of AvailableTopicEntityListing</returns>

    ApiResponse<AvailableTopicEntityListing> GetNotificationsAvailabletopicsWithHttpInfo(List<string> expand = null, bool? includePreview = null);

    /// <summary>
    /// The list of all subscriptions for this channel
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ChannelTopicEntityListing</returns>

    ChannelTopicEntityListing GetNotificationsChannelSubscriptions(string channelId);

    /// <summary>
    /// The list of all subscriptions for this channel
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ApiResponse of ChannelTopicEntityListing</returns>

    ApiResponse<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsWithHttpInfo(string channelId);

    /// <summary>
    /// The list of existing channels
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>ChannelEntityListing</returns>

    ChannelEntityListing GetNotificationsChannels(string includechannels = null);

    /// <summary>
    /// The list of existing channels
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>ApiResponse of ChannelEntityListing</returns>

    ApiResponse<ChannelEntityListing> GetNotificationsChannelsWithHttpInfo(string includechannels = null);

    /// <summary>
    /// Verify a channel still exists and is valid
    /// </summary>
    /// <remarks>
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns></returns>

    void HeadNotificationsChannel(string channelId);

    /// <summary>
    /// Verify a channel still exists and is valid
    /// </summary>
    /// <remarks>
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> HeadNotificationsChannelWithHttpInfo(string channelId);

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ChannelTopicEntityListing</returns>

    ChannelTopicEntityListing PostNotificationsChannelSubscriptions(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ApiResponse of ChannelTopicEntityListing</returns>

    ApiResponse<ChannelTopicEntityListing> PostNotificationsChannelSubscriptionsWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    /// <summary>
    /// Create a new channel
    /// </summary>
    /// <remarks>
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Channel</returns>

    Channel PostNotificationsChannels();

    /// <summary>
    /// Create a new channel
    /// </summary>
    /// <remarks>
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Channel</returns>

    ApiResponse<Channel> PostNotificationsChannelsWithHttpInfo();

    /// <summary>
    /// Replace the current list of subscriptions with a new list.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ChannelTopicEntityListing</returns>

    ChannelTopicEntityListing PutNotificationsChannelSubscriptions(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    /// <summary>
    /// Replace the current list of subscriptions with a new list.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ApiResponse of ChannelTopicEntityListing</returns>

    ApiResponse<ChannelTopicEntityListing> PutNotificationsChannelSubscriptionsWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Remove all subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of void</returns>

    Task DeleteNotificationsChannelSubscriptionsAsync(string channelId);

    /// <summary>
    /// Remove all subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId);

    /// <summary>
    /// Get available notification topics.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>Task of AvailableTopicEntityListing</returns>

    Task<AvailableTopicEntityListing> GetNotificationsAvailabletopicsAsync(List<string> expand = null, bool? includePreview = null);

    /// <summary>
    /// Get available notification topics.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>Task of ApiResponse (AvailableTopicEntityListing)</returns>

    Task<ApiResponse<AvailableTopicEntityListing>> GetNotificationsAvailabletopicsAsyncWithHttpInfo(List<string> expand = null, bool? includePreview = null);

    /// <summary>
    /// The list of all subscriptions for this channel
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ChannelTopicEntityListing</returns>

    Task<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsAsync(string channelId);

    /// <summary>
    /// The list of all subscriptions for this channel
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>

    Task<ApiResponse<ChannelTopicEntityListing>> GetNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId);

    /// <summary>
    /// The list of existing channels
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>Task of ChannelEntityListing</returns>

    Task<ChannelEntityListing> GetNotificationsChannelsAsync(string includechannels = null);

    /// <summary>
    /// The list of existing channels
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>

    Task<ApiResponse<ChannelEntityListing>> GetNotificationsChannelsAsyncWithHttpInfo(string includechannels = null);

    /// <summary>
    /// Verify a channel still exists and is valid
    /// </summary>
    /// <remarks>
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of void</returns>

    Task HeadNotificationsChannelAsync(string channelId);

    /// <summary>
    /// Verify a channel still exists and is valid
    /// </summary>
    /// <remarks>
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> HeadNotificationsChannelAsyncWithHttpInfo(string channelId);

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ChannelTopicEntityListing</returns>

    Task<ChannelTopicEntityListing> PostNotificationsChannelSubscriptionsAsync(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>

    Task<ApiResponse<ChannelTopicEntityListing>> PostNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    /// <summary>
    /// Create a new channel
    /// </summary>
    /// <remarks>
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Channel</returns>

    Task<Channel> PostNotificationsChannelsAsync();

    /// <summary>
    /// Create a new channel
    /// </summary>
    /// <remarks>
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Channel)</returns>

    Task<ApiResponse<Channel>> PostNotificationsChannelsAsyncWithHttpInfo();

    /// <summary>
    /// Replace the current list of subscriptions with a new list.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ChannelTopicEntityListing</returns>

    Task<ChannelTopicEntityListing> PutNotificationsChannelSubscriptionsAsync(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    /// <summary>
    /// Replace the current list of subscriptions with a new list.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>

    Task<ApiResponse<ChannelTopicEntityListing>> PutNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class NotificationsApi : INotificationsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public NotificationsApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public NotificationsApi(Configuration configuration = null)
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
    /// Remove all subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns></returns>

    public void DeleteNotificationsChannelSubscriptions(string channelId)
    {
        DeleteNotificationsChannelSubscriptionsWithHttpInfo(channelId);
    }

    /// <summary>
    /// Remove all subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteNotificationsChannelSubscriptionsWithHttpInfo(string channelId)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->DeleteNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Remove all subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteNotificationsChannelSubscriptionsAsync(string channelId)
    {
        await DeleteNotificationsChannelSubscriptionsAsyncWithHttpInfo(channelId);

    }

    /// <summary>
    /// Remove all subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->DeleteNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get available notification topics. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>AvailableTopicEntityListing</returns>

    public AvailableTopicEntityListing GetNotificationsAvailabletopics(List<string> expand = null, bool? includePreview = null)
    {
        ApiResponse<AvailableTopicEntityListing> localVarResponse = GetNotificationsAvailabletopicsWithHttpInfo(expand, includePreview);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get available notification topics. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>ApiResponse of AvailableTopicEntityListing</returns>

    public ApiResponse<AvailableTopicEntityListing> GetNotificationsAvailabletopicsWithHttpInfo(List<string> expand = null, bool? includePreview = null)
    {

        var localVarPath = "/api/v2/notifications/availabletopics";
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
        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (includePreview != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("includePreview", Configuration.ApiClient.ParameterToString(includePreview)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsAvailabletopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsAvailabletopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AvailableTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (AvailableTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get available notification topics. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>Task of AvailableTopicEntityListing</returns>

    public async Task<AvailableTopicEntityListing> GetNotificationsAvailabletopicsAsync(List<string> expand = null, bool? includePreview = null)
    {
        ApiResponse<AvailableTopicEntityListing> localVarResponse = await GetNotificationsAvailabletopicsAsyncWithHttpInfo(expand, includePreview);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get available notification topics. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="includePreview">Whether or not to include Preview topics (optional, default to true)</param>
    /// <returns>Task of ApiResponse (AvailableTopicEntityListing)</returns>

    public async Task<ApiResponse<AvailableTopicEntityListing>> GetNotificationsAvailabletopicsAsyncWithHttpInfo(List<string> expand = null, bool? includePreview = null)
    {

        var localVarPath = "/api/v2/notifications/availabletopics";
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
        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (includePreview != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("includePreview", Configuration.ApiClient.ParameterToString(includePreview)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsAvailabletopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsAvailabletopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AvailableTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (AvailableTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of all subscriptions for this channel 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ChannelTopicEntityListing</returns>

    public ChannelTopicEntityListing GetNotificationsChannelSubscriptions(string channelId)
    {
        ApiResponse<ChannelTopicEntityListing> localVarResponse = GetNotificationsChannelSubscriptionsWithHttpInfo(channelId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of all subscriptions for this channel 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ApiResponse of ChannelTopicEntityListing</returns>

    public ApiResponse<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsWithHttpInfo(string channelId)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->GetNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of all subscriptions for this channel 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ChannelTopicEntityListing</returns>

    public async Task<ChannelTopicEntityListing> GetNotificationsChannelSubscriptionsAsync(string channelId)
    {
        ApiResponse<ChannelTopicEntityListing> localVarResponse = await GetNotificationsChannelSubscriptionsAsyncWithHttpInfo(channelId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of all subscriptions for this channel 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>

    public async Task<ApiResponse<ChannelTopicEntityListing>> GetNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->GetNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// The list of existing channels 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>ChannelEntityListing</returns>

    public ChannelEntityListing GetNotificationsChannels(string includechannels = null)
    {
        ApiResponse<ChannelEntityListing> localVarResponse = GetNotificationsChannelsWithHttpInfo(includechannels);
        return localVarResponse.Data;
    }

    /// <summary>
    /// The list of existing channels 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>ApiResponse of ChannelEntityListing</returns>

    public ApiResponse<ChannelEntityListing> GetNotificationsChannelsWithHttpInfo(string includechannels = null)
    {

        var localVarPath = "/api/v2/notifications/channels";
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
        if (includechannels != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("includechannels", Configuration.ApiClient.ParameterToString(includechannels)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannels: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// The list of existing channels 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>Task of ChannelEntityListing</returns>

    public async Task<ChannelEntityListing> GetNotificationsChannelsAsync(string includechannels = null)
    {
        ApiResponse<ChannelEntityListing> localVarResponse = await GetNotificationsChannelsAsyncWithHttpInfo(includechannels);
        return localVarResponse.Data;

    }

    /// <summary>
    /// The list of existing channels 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="includechannels">Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional, default to token)</param>
    /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>

    public async Task<ApiResponse<ChannelEntityListing>> GetNotificationsChannelsAsyncWithHttpInfo(string includechannels = null)
    {

        var localVarPath = "/api/v2/notifications/channels";
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
        if (includechannels != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("includechannels", Configuration.ApiClient.ParameterToString(includechannels)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannels: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetNotificationsChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Verify a channel still exists and is valid 
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns></returns>

    public void HeadNotificationsChannel(string channelId)
    {
        HeadNotificationsChannelWithHttpInfo(channelId);
    }

    /// <summary>
    /// Verify a channel still exists and is valid 
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> HeadNotificationsChannelWithHttpInfo(string channelId)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->HeadNotificationsChannel");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
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
            Method.Head, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling HeadNotificationsChannel: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling HeadNotificationsChannel: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Verify a channel still exists and is valid 
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of void</returns>

    public async Task HeadNotificationsChannelAsync(string channelId)
    {
        await HeadNotificationsChannelAsyncWithHttpInfo(channelId);

    }

    /// <summary>
    /// Verify a channel still exists and is valid 
    /// Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> HeadNotificationsChannelAsyncWithHttpInfo(string channelId)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->HeadNotificationsChannel");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
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
            Method.Head, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling HeadNotificationsChannel: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling HeadNotificationsChannel: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ChannelTopicEntityListing</returns>

    public ChannelTopicEntityListing PostNotificationsChannelSubscriptions(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        ApiResponse<ChannelTopicEntityListing> localVarResponse = PostNotificationsChannelSubscriptionsWithHttpInfo(channelId, body, ignoreErrors);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ApiResponse of ChannelTopicEntityListing</returns>

    public ApiResponse<ChannelTopicEntityListing> PostNotificationsChannelSubscriptionsWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PostNotificationsChannelSubscriptions");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling NotificationsApi->PostNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
        }

        // Query params
        if (ignoreErrors != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("ignoreErrors", Configuration.ApiClient.ParameterToString(ignoreErrors)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ChannelTopicEntityListing</returns>

    public async Task<ChannelTopicEntityListing> PostNotificationsChannelSubscriptionsAsync(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        ApiResponse<ChannelTopicEntityListing> localVarResponse = await PostNotificationsChannelSubscriptionsAsyncWithHttpInfo(channelId, body, ignoreErrors);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Add a list of subscriptions to the existing list of subscriptions 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>

    public async Task<ApiResponse<ChannelTopicEntityListing>> PostNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PostNotificationsChannelSubscriptions");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling NotificationsApi->PostNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
        }

        // Query params
        if (ignoreErrors != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("ignoreErrors", Configuration.ApiClient.ParameterToString(ignoreErrors)));
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
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a new channel 
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Channel</returns>

    public Channel PostNotificationsChannels()
    {
        ApiResponse<Channel> localVarResponse = PostNotificationsChannelsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a new channel 
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Channel</returns>

    public ApiResponse<Channel> PostNotificationsChannelsWithHttpInfo()
    {

        var localVarPath = "/api/v2/notifications/channels";
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
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannels: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Channel>(localVarStatusCode,
            localVarHeaders,
            (Channel)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a new channel 
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Channel</returns>

    public async Task<Channel> PostNotificationsChannelsAsync()
    {
        ApiResponse<Channel> localVarResponse = await PostNotificationsChannelsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a new channel 
    /// There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Channel)</returns>

    public async Task<ApiResponse<Channel>> PostNotificationsChannelsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/notifications/channels";
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
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannels: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostNotificationsChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Channel>(localVarStatusCode,
            localVarHeaders,
            (Channel)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Replace the current list of subscriptions with a new list. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ChannelTopicEntityListing</returns>

    public ChannelTopicEntityListing PutNotificationsChannelSubscriptions(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        ApiResponse<ChannelTopicEntityListing> localVarResponse = PutNotificationsChannelSubscriptionsWithHttpInfo(channelId, body, ignoreErrors);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Replace the current list of subscriptions with a new list. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>ApiResponse of ChannelTopicEntityListing</returns>

    public ApiResponse<ChannelTopicEntityListing> PutNotificationsChannelSubscriptionsWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PutNotificationsChannelSubscriptions");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling NotificationsApi->PutNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
        }

        // Query params
        if (ignoreErrors != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("ignoreErrors", Configuration.ApiClient.ParameterToString(ignoreErrors)));
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
            throw new ApiException(localVarStatusCode, "Error calling PutNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Replace the current list of subscriptions with a new list. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ChannelTopicEntityListing</returns>

    public async Task<ChannelTopicEntityListing> PutNotificationsChannelSubscriptionsAsync(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        ApiResponse<ChannelTopicEntityListing> localVarResponse = await PutNotificationsChannelSubscriptionsAsyncWithHttpInfo(channelId, body, ignoreErrors);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Replace the current list of subscriptions with a new list. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="channelId">Channel ID</param>
    /// <param name="body">Body</param>
    /// <param name="ignoreErrors">Optionally prevent throwing of errors for failed permissions checks. (optional, default to false)</param>
    /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>

    public async Task<ApiResponse<ChannelTopicEntityListing>> PutNotificationsChannelSubscriptionsAsyncWithHttpInfo(string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)
    {
        // verify the required parameter 'channelId' is set
        if (channelId == null)
        {
            throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PutNotificationsChannelSubscriptions");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling NotificationsApi->PutNotificationsChannelSubscriptions");
        }

        var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
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
        if (channelId != null)
        {
            localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId));
        }

        // Query params
        if (ignoreErrors != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("ignoreErrors", Configuration.ApiClient.ParameterToString(ignoreErrors)));
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
            throw new ApiException(localVarStatusCode, "Error calling PutNotificationsChannelSubscriptions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutNotificationsChannelSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChannelTopicEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
