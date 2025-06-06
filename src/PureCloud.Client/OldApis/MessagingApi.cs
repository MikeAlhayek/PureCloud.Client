using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IMessagingApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns></returns>
    [Obsolete]
    void DeleteMessagingSetting(string messageSettingId);

    /// <summary>
    /// Delete a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    ApiResponse<object> DeleteMessagingSettingWithHttpInfo(string messageSettingId);

    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns></returns>
    [Obsolete]
    void DeleteMessagingSettingsDefault();

    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    ApiResponse<object> DeleteMessagingSettingsDefaultWithHttpInfo();

    /// <summary>
    /// Delete a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns></returns>
    [Obsolete]
    void DeleteMessagingSupportedcontentSupportedContentId(string supportedContentId);

    /// <summary>
    /// Delete a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    ApiResponse<object> DeleteMessagingSupportedcontentSupportedContentIdWithHttpInfo(string supportedContentId);

    /// <summary>
    /// Get a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    MessagingSetting GetMessagingSetting(string messageSettingId);

    /// <summary>
    /// Get a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    ApiResponse<MessagingSetting> GetMessagingSettingWithHttpInfo(string messageSettingId);

    /// <summary>
    /// Get a list of messaging settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>MessagingConfigListing</returns>
    [Obsolete]
    MessagingConfigListing GetMessagingSettings(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of messaging settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of MessagingConfigListing</returns>
    [Obsolete]
    ApiResponse<MessagingConfigListing> GetMessagingSettingsWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    MessagingSetting GetMessagingSettingsDefault();

    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    ApiResponse<MessagingSetting> GetMessagingSettingsDefaultWithHttpInfo();

    /// <summary>
    /// Get a list of Supported Content profiles
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>SupportedContentListing</returns>
    [Obsolete]
    SupportedContentListing GetMessagingSupportedcontent(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of Supported Content profiles
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of SupportedContentListing</returns>
    [Obsolete]
    ApiResponse<SupportedContentListing> GetMessagingSupportedcontentWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>SupportedContent</returns>
    [Obsolete]
    SupportedContent GetMessagingSupportedcontentSupportedContentId(string supportedContentId);

    /// <summary>
    /// Get a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>ApiResponse of SupportedContent</returns>
    [Obsolete]
    ApiResponse<SupportedContent> GetMessagingSupportedcontentSupportedContentIdWithHttpInfo(string supportedContentId);

    /// <summary>
    /// Update a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    MessagingSetting PatchMessagingSetting(string messageSettingId, MessagingSettingRequest body);

    /// <summary>
    /// Update a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    ApiResponse<MessagingSetting> PatchMessagingSettingWithHttpInfo(string messageSettingId, MessagingSettingRequest body);

    /// <summary>
    /// Update a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>SupportedContent</returns>
    [Obsolete]
    SupportedContent PatchMessagingSupportedcontentSupportedContentId(string supportedContentId, SupportedContent body);

    /// <summary>
    /// Update a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>ApiResponse of SupportedContent</returns>
    [Obsolete]
    ApiResponse<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdWithHttpInfo(string supportedContentId, SupportedContent body);

    /// <summary>
    /// Create a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    MessagingSetting PostMessagingSettings(MessagingSettingRequest body);

    /// <summary>
    /// Create a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    ApiResponse<MessagingSetting> PostMessagingSettingsWithHttpInfo(MessagingSettingRequest body);

    /// <summary>
    /// Create a Supported Content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>SupportedContent</returns>
    [Obsolete]
    SupportedContent PostMessagingSupportedcontent(SupportedContent body);

    /// <summary>
    /// Create a Supported Content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>ApiResponse of SupportedContent</returns>
    [Obsolete]
    ApiResponse<SupportedContent> PostMessagingSupportedcontentWithHttpInfo(SupportedContent body);

    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    MessagingSetting PutMessagingSettingsDefault(MessagingSettingDefaultRequest body);

    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    ApiResponse<MessagingSetting> PutMessagingSettingsDefaultWithHttpInfo(MessagingSettingDefaultRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of void</returns>
    [Obsolete]
    Task DeleteMessagingSettingAsync(string messageSettingId);

    /// <summary>
    /// Delete a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    Task<ApiResponse<object>> DeleteMessagingSettingAsyncWithHttpInfo(string messageSettingId);

    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of void</returns>
    [Obsolete]
    Task DeleteMessagingSettingsDefaultAsync();

    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    Task<ApiResponse<object>> DeleteMessagingSettingsDefaultAsyncWithHttpInfo();

    /// <summary>
    /// Delete a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of void</returns>
    [Obsolete]
    Task DeleteMessagingSupportedcontentSupportedContentIdAsync(string supportedContentId);

    /// <summary>
    /// Delete a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    Task<ApiResponse<object>> DeleteMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(string supportedContentId);

    /// <summary>
    /// Get a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    Task<MessagingSetting> GetMessagingSettingAsync(string messageSettingId);

    /// <summary>
    /// Get a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    Task<ApiResponse<MessagingSetting>> GetMessagingSettingAsyncWithHttpInfo(string messageSettingId);

    /// <summary>
    /// Get a list of messaging settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of MessagingConfigListing</returns>
    [Obsolete]
    Task<MessagingConfigListing> GetMessagingSettingsAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of messaging settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (MessagingConfigListing)</returns>
    [Obsolete]
    Task<ApiResponse<MessagingConfigListing>> GetMessagingSettingsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    Task<MessagingSetting> GetMessagingSettingsDefaultAsync();

    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    Task<ApiResponse<MessagingSetting>> GetMessagingSettingsDefaultAsyncWithHttpInfo();

    /// <summary>
    /// Get a list of Supported Content profiles
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of SupportedContentListing</returns>
    [Obsolete]
    Task<SupportedContentListing> GetMessagingSupportedcontentAsync(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a list of Supported Content profiles
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (SupportedContentListing)</returns>
    [Obsolete]
    Task<ApiResponse<SupportedContentListing>> GetMessagingSupportedcontentAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null);

    /// <summary>
    /// Get a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of SupportedContent</returns>
    [Obsolete]
    Task<SupportedContent> GetMessagingSupportedcontentSupportedContentIdAsync(string supportedContentId);

    /// <summary>
    /// Get a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of ApiResponse (SupportedContent)</returns>
    [Obsolete]
    Task<ApiResponse<SupportedContent>> GetMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(string supportedContentId);

    /// <summary>
    /// Update a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    Task<MessagingSetting> PatchMessagingSettingAsync(string messageSettingId, MessagingSettingRequest body);

    /// <summary>
    /// Update a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    Task<ApiResponse<MessagingSetting>> PatchMessagingSettingAsyncWithHttpInfo(string messageSettingId, MessagingSettingRequest body);

    /// <summary>
    /// Update a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of SupportedContent</returns>
    [Obsolete]
    Task<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdAsync(string supportedContentId, SupportedContent body);

    /// <summary>
    /// Update a supported content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of ApiResponse (SupportedContent)</returns>
    [Obsolete]
    Task<ApiResponse<SupportedContent>> PatchMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(string supportedContentId, SupportedContent body);

    /// <summary>
    /// Create a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    Task<MessagingSetting> PostMessagingSettingsAsync(MessagingSettingRequest body);

    /// <summary>
    /// Create a messaging setting
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    Task<ApiResponse<MessagingSetting>> PostMessagingSettingsAsyncWithHttpInfo(MessagingSettingRequest body);

    /// <summary>
    /// Create a Supported Content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of SupportedContent</returns>
    [Obsolete]
    Task<SupportedContent> PostMessagingSupportedcontentAsync(SupportedContent body);

    /// <summary>
    /// Create a Supported Content profile
    /// </summary>
    /// <remarks>
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of ApiResponse (SupportedContent)</returns>
    [Obsolete]
    Task<ApiResponse<SupportedContent>> PostMessagingSupportedcontentAsyncWithHttpInfo(SupportedContent body);

    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    Task<MessagingSetting> PutMessagingSettingsDefaultAsync(MessagingSettingDefaultRequest body);

    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created.
    /// </summary>
    /// <remarks>
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    Task<ApiResponse<MessagingSetting>> PutMessagingSettingsDefaultAsyncWithHttpInfo(MessagingSettingDefaultRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class MessagingApi : IMessagingApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingApi"/> class.
    /// </summary>
    /// <returns></returns>
    public MessagingApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public MessagingApi(Configuration configuration = null)
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
    /// Delete a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns></returns>
    [Obsolete]
    public void DeleteMessagingSetting(string messageSettingId)
    {
        DeleteMessagingSettingWithHttpInfo(messageSettingId);
    }

    /// <summary>
    /// Delete a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    public ApiResponse<object> DeleteMessagingSettingWithHttpInfo(string messageSettingId)
    {
        // verify the required parameter 'messageSettingId' is set
        if (messageSettingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->DeleteMessagingSetting");
        }

        var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
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
        if (messageSettingId != null)
        {
            localVarPathParams.Add("messageSettingId", Configuration.ApiClient.ParameterToString(messageSettingId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of void</returns>
    [Obsolete]
    public async Task DeleteMessagingSettingAsync(string messageSettingId)
    {
        await DeleteMessagingSettingAsyncWithHttpInfo(messageSettingId);

    }

    /// <summary>
    /// Delete a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    public async Task<ApiResponse<object>> DeleteMessagingSettingAsyncWithHttpInfo(string messageSettingId)
    {
        // verify the required parameter 'messageSettingId' is set
        if (messageSettingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->DeleteMessagingSetting");
        }

        var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
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
        if (messageSettingId != null)
        {
            localVarPathParams.Add("messageSettingId", Configuration.ApiClient.ParameterToString(messageSettingId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns></returns>
    [Obsolete]
    public void DeleteMessagingSettingsDefault()
    {
        DeleteMessagingSettingsDefaultWithHttpInfo();
    }

    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    public ApiResponse<object> DeleteMessagingSettingsDefaultWithHttpInfo()
    {

        var localVarPath = "/api/v2/messaging/settings/default";
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of void</returns>
    [Obsolete]
    public async Task DeleteMessagingSettingsDefaultAsync()
    {
        await DeleteMessagingSettingsDefaultAsyncWithHttpInfo();

    }

    /// <summary>
    /// Delete the organization&#39;s default setting, a global default will be applied to integrations without settings 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    public async Task<ApiResponse<object>> DeleteMessagingSettingsDefaultAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/messaging/settings/default";
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete a supported content profile 
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns></returns>
    [Obsolete]
    public void DeleteMessagingSupportedcontentSupportedContentId(string supportedContentId)
    {
        DeleteMessagingSupportedcontentSupportedContentIdWithHttpInfo(supportedContentId);
    }

    /// <summary>
    /// Delete a supported content profile 
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    [Obsolete]
    public ApiResponse<object> DeleteMessagingSupportedcontentSupportedContentIdWithHttpInfo(string supportedContentId)
    {
        // verify the required parameter 'supportedContentId' is set
        if (supportedContentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->DeleteMessagingSupportedcontentSupportedContentId");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
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
        if (supportedContentId != null)
        {
            localVarPathParams.Add("supportedContentId", Configuration.ApiClient.ParameterToString(supportedContentId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a supported content profile 
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of void</returns>
    [Obsolete]
    public async Task DeleteMessagingSupportedcontentSupportedContentIdAsync(string supportedContentId)
    {
        await DeleteMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(supportedContentId);

    }

    /// <summary>
    /// Delete a supported content profile 
    /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of ApiResponse</returns>
    [Obsolete]
    public async Task<ApiResponse<object>> DeleteMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(string supportedContentId)
    {
        // verify the required parameter 'supportedContentId' is set
        if (supportedContentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->DeleteMessagingSupportedcontentSupportedContentId");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
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
        if (supportedContentId != null)
        {
            localVarPathParams.Add("supportedContentId", Configuration.ApiClient.ParameterToString(supportedContentId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    public MessagingSetting GetMessagingSetting(string messageSettingId)
    {
        ApiResponse<MessagingSetting> localVarResponse = GetMessagingSettingWithHttpInfo(messageSettingId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    public ApiResponse<MessagingSetting> GetMessagingSettingWithHttpInfo(string messageSettingId)
    {
        // verify the required parameter 'messageSettingId' is set
        if (messageSettingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->GetMessagingSetting");
        }

        var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
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
        if (messageSettingId != null)
        {
            localVarPathParams.Add("messageSettingId", Configuration.ApiClient.ParameterToString(messageSettingId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    public async Task<MessagingSetting> GetMessagingSettingAsync(string messageSettingId)
    {
        ApiResponse<MessagingSetting> localVarResponse = await GetMessagingSettingAsyncWithHttpInfo(messageSettingId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    public async Task<ApiResponse<MessagingSetting>> GetMessagingSettingAsyncWithHttpInfo(string messageSettingId)
    {
        // verify the required parameter 'messageSettingId' is set
        if (messageSettingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->GetMessagingSetting");
        }

        var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
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
        if (messageSettingId != null)
        {
            localVarPathParams.Add("messageSettingId", Configuration.ApiClient.ParameterToString(messageSettingId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a list of messaging settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>MessagingConfigListing</returns>
    [Obsolete]
    public MessagingConfigListing GetMessagingSettings(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<MessagingConfigListing> localVarResponse = GetMessagingSettingsWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of messaging settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of MessagingConfigListing</returns>
    [Obsolete]
    public ApiResponse<MessagingConfigListing> GetMessagingSettingsWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/messaging/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingConfigListing>(localVarStatusCode,
            localVarHeaders,
            (MessagingConfigListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingConfigListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a list of messaging settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of MessagingConfigListing</returns>
    [Obsolete]
    public async Task<MessagingConfigListing> GetMessagingSettingsAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<MessagingConfigListing> localVarResponse = await GetMessagingSettingsAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a list of messaging settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (MessagingConfigListing)</returns>
    [Obsolete]
    public async Task<ApiResponse<MessagingConfigListing>> GetMessagingSettingsAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/messaging/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingConfigListing>(localVarStatusCode,
            localVarHeaders,
            (MessagingConfigListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingConfigListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    public MessagingSetting GetMessagingSettingsDefault()
    {
        ApiResponse<MessagingSetting> localVarResponse = GetMessagingSettingsDefaultWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    public ApiResponse<MessagingSetting> GetMessagingSettingsDefaultWithHttpInfo()
    {

        var localVarPath = "/api/v2/messaging/settings/default";
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    public async Task<MessagingSetting> GetMessagingSettingsDefaultAsync()
    {
        ApiResponse<MessagingSetting> localVarResponse = await GetMessagingSettingsDefaultAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get the organization&#39;s default settings that will be used as the default when creating an integration. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    public async Task<ApiResponse<MessagingSetting>> GetMessagingSettingsDefaultAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/messaging/settings/default";
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a list of Supported Content profiles 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>SupportedContentListing</returns>
    [Obsolete]
    public SupportedContentListing GetMessagingSupportedcontent(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<SupportedContentListing> localVarResponse = GetMessagingSupportedcontentWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of Supported Content profiles 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>ApiResponse of SupportedContentListing</returns>
    [Obsolete]
    public ApiResponse<SupportedContentListing> GetMessagingSupportedcontentWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/messaging/supportedcontent";
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContentListing>(localVarStatusCode,
            localVarHeaders,
            (SupportedContentListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContentListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a list of Supported Content profiles 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of SupportedContentListing</returns>
    [Obsolete]
    public async Task<SupportedContentListing> GetMessagingSupportedcontentAsync(int? pageSize = null, int? pageNumber = null)
    {
        ApiResponse<SupportedContentListing> localVarResponse = await GetMessagingSupportedcontentAsyncWithHttpInfo(pageSize, pageNumber);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a list of Supported Content profiles 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <returns>Task of ApiResponse (SupportedContentListing)</returns>
    [Obsolete]
    public async Task<ApiResponse<SupportedContentListing>> GetMessagingSupportedcontentAsyncWithHttpInfo(int? pageSize = null, int? pageNumber = null)
    {

        var localVarPath = "/api/v2/messaging/supportedcontent";
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContentListing>(localVarStatusCode,
            localVarHeaders,
            (SupportedContentListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContentListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a supported content profile 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>SupportedContent</returns>
    [Obsolete]
    public SupportedContent GetMessagingSupportedcontentSupportedContentId(string supportedContentId)
    {
        ApiResponse<SupportedContent> localVarResponse = GetMessagingSupportedcontentSupportedContentIdWithHttpInfo(supportedContentId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a supported content profile 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>ApiResponse of SupportedContent</returns>
    [Obsolete]
    public ApiResponse<SupportedContent> GetMessagingSupportedcontentSupportedContentIdWithHttpInfo(string supportedContentId)
    {
        // verify the required parameter 'supportedContentId' is set
        if (supportedContentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->GetMessagingSupportedcontentSupportedContentId");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
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
        if (supportedContentId != null)
        {
            localVarPathParams.Add("supportedContentId", Configuration.ApiClient.ParameterToString(supportedContentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContent>(localVarStatusCode,
            localVarHeaders,
            (SupportedContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a supported content profile 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of SupportedContent</returns>
    [Obsolete]
    public async Task<SupportedContent> GetMessagingSupportedcontentSupportedContentIdAsync(string supportedContentId)
    {
        ApiResponse<SupportedContent> localVarResponse = await GetMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(supportedContentId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a supported content profile 
    /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <returns>Task of ApiResponse (SupportedContent)</returns>
    [Obsolete]
    public async Task<ApiResponse<SupportedContent>> GetMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(string supportedContentId)
    {
        // verify the required parameter 'supportedContentId' is set
        if (supportedContentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->GetMessagingSupportedcontentSupportedContentId");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
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
        if (supportedContentId != null)
        {
            localVarPathParams.Add("supportedContentId", Configuration.ApiClient.ParameterToString(supportedContentId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContent>(localVarStatusCode,
            localVarHeaders,
            (SupportedContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    public MessagingSetting PatchMessagingSetting(string messageSettingId, MessagingSettingRequest body)
    {
        ApiResponse<MessagingSetting> localVarResponse = PatchMessagingSettingWithHttpInfo(messageSettingId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    public ApiResponse<MessagingSetting> PatchMessagingSettingWithHttpInfo(string messageSettingId, MessagingSettingRequest body)
    {
        // verify the required parameter 'messageSettingId' is set
        if (messageSettingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->PatchMessagingSetting");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSetting");
        }

        var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
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
        if (messageSettingId != null)
        {
            localVarPathParams.Add("messageSettingId", Configuration.ApiClient.ParameterToString(messageSettingId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    public async Task<MessagingSetting> PatchMessagingSettingAsync(string messageSettingId, MessagingSettingRequest body)
    {
        ApiResponse<MessagingSetting> localVarResponse = await PatchMessagingSettingAsyncWithHttpInfo(messageSettingId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageSettingId">Message Settings ID</param>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    public async Task<ApiResponse<MessagingSetting>> PatchMessagingSettingAsyncWithHttpInfo(string messageSettingId, MessagingSettingRequest body)
    {
        // verify the required parameter 'messageSettingId' is set
        if (messageSettingId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->PatchMessagingSetting");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSetting");
        }

        var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
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
        if (messageSettingId != null)
        {
            localVarPathParams.Add("messageSettingId", Configuration.ApiClient.ParameterToString(messageSettingId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a supported content profile 
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>SupportedContent</returns>
    [Obsolete]
    public SupportedContent PatchMessagingSupportedcontentSupportedContentId(string supportedContentId, SupportedContent body)
    {
        ApiResponse<SupportedContent> localVarResponse = PatchMessagingSupportedcontentSupportedContentIdWithHttpInfo(supportedContentId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a supported content profile 
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>ApiResponse of SupportedContent</returns>
    [Obsolete]
    public ApiResponse<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdWithHttpInfo(string supportedContentId, SupportedContent body)
    {
        // verify the required parameter 'supportedContentId' is set
        if (supportedContentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
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
        if (supportedContentId != null)
        {
            localVarPathParams.Add("supportedContentId", Configuration.ApiClient.ParameterToString(supportedContentId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContent>(localVarStatusCode,
            localVarHeaders,
            (SupportedContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a supported content profile 
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of SupportedContent</returns>
    [Obsolete]
    public async Task<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdAsync(string supportedContentId, SupportedContent body)
    {
        ApiResponse<SupportedContent> localVarResponse = await PatchMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(supportedContentId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a supported content profile 
    /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="supportedContentId">Supported Content ID</param>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of ApiResponse (SupportedContent)</returns>
    [Obsolete]
    public async Task<ApiResponse<SupportedContent>> PatchMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(string supportedContentId, SupportedContent body)
    {
        // verify the required parameter 'supportedContentId' is set
        if (supportedContentId == null)
        {
            throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
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
        if (supportedContentId != null)
        {
            localVarPathParams.Add("supportedContentId", Configuration.ApiClient.ParameterToString(supportedContentId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContent>(localVarStatusCode,
            localVarHeaders,
            (SupportedContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    public MessagingSetting PostMessagingSettings(MessagingSettingRequest body)
    {
        ApiResponse<MessagingSetting> localVarResponse = PostMessagingSettingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    public ApiResponse<MessagingSetting> PostMessagingSettingsWithHttpInfo(MessagingSettingRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSettings");
        }

        var localVarPath = "/api/v2/messaging/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    public async Task<MessagingSetting> PostMessagingSettingsAsync(MessagingSettingRequest body)
    {
        ApiResponse<MessagingSetting> localVarResponse = await PostMessagingSettingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a messaging setting 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">MessagingSetting</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    public async Task<ApiResponse<MessagingSetting>> PostMessagingSettingsAsyncWithHttpInfo(MessagingSettingRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSettings");
        }

        var localVarPath = "/api/v2/messaging/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a Supported Content profile 
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>SupportedContent</returns>
    [Obsolete]
    public SupportedContent PostMessagingSupportedcontent(SupportedContent body)
    {
        ApiResponse<SupportedContent> localVarResponse = PostMessagingSupportedcontentWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Supported Content profile 
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>ApiResponse of SupportedContent</returns>
    [Obsolete]
    public ApiResponse<SupportedContent> PostMessagingSupportedcontentWithHttpInfo(SupportedContent body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSupportedcontent");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent";
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
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContent>(localVarStatusCode,
            localVarHeaders,
            (SupportedContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a Supported Content profile 
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of SupportedContent</returns>
    [Obsolete]
    public async Task<SupportedContent> PostMessagingSupportedcontentAsync(SupportedContent body)
    {
        ApiResponse<SupportedContent> localVarResponse = await PostMessagingSupportedcontentAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a Supported Content profile 
    /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">SupportedContent</param>
    /// <returns>Task of ApiResponse (SupportedContent)</returns>
    [Obsolete]
    public async Task<ApiResponse<SupportedContent>> PostMessagingSupportedcontentAsyncWithHttpInfo(SupportedContent body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSupportedcontent");
        }

        var localVarPath = "/api/v2/messaging/supportedcontent";
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
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SupportedContent>(localVarStatusCode,
            localVarHeaders,
            (SupportedContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>MessagingSetting</returns>
    [Obsolete]
    public MessagingSetting PutMessagingSettingsDefault(MessagingSettingDefaultRequest body)
    {
        ApiResponse<MessagingSetting> localVarResponse = PutMessagingSettingsDefaultWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>ApiResponse of MessagingSetting</returns>
    [Obsolete]
    public ApiResponse<MessagingSetting> PutMessagingSettingsDefaultWithHttpInfo(MessagingSettingDefaultRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PutMessagingSettingsDefault");
        }

        var localVarPath = "/api/v2/messaging/settings/default";
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
            throw new ApiException(localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>Task of MessagingSetting</returns>
    [Obsolete]
    public async Task<MessagingSetting> PutMessagingSettingsDefaultAsync(MessagingSettingDefaultRequest body)
    {
        ApiResponse<MessagingSetting> localVarResponse = await PutMessagingSettingsDefaultAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Set the organization&#39;s default settings that may be applied to an integration when it is created. 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Messaging Setting ID</param>
    /// <returns>Task of ApiResponse (MessagingSetting)</returns>
    [Obsolete]
    public async Task<ApiResponse<MessagingSetting>> PutMessagingSettingsDefaultAsyncWithHttpInfo(MessagingSettingDefaultRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PutMessagingSettingsDefault");
        }

        var localVarPath = "/api/v2/messaging/settings/default";
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
            throw new ApiException(localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<MessagingSetting>(localVarStatusCode,
            localVarHeaders,
            (MessagingSetting)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
