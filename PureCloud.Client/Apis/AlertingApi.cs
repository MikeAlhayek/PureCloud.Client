using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAlertingApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns></returns>

    void DeleteAlertingAlert(string alertId);

    /// <summary>
    /// Delete an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteAlertingAlertWithHttpInfo(string alertId);

    /// <summary>
    /// Delete all alerts for the user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    object DeleteAlertingAlertsAll();

    /// <summary>
    /// Delete all alerts for the user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<object> DeleteAlertingAlertsAllWithHttpInfo();

    /// <summary>
    /// Delete a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns></returns>

    void DeleteAlertingRule(string ruleId);

    /// <summary>
    /// Delete a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteAlertingRuleWithHttpInfo(string ruleId);

    /// <summary>
    /// Get an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>CommonAlert</returns>

    CommonAlert GetAlertingAlert(string alertId);

    /// <summary>
    /// Get an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>ApiResponse of CommonAlert</returns>

    ApiResponse<CommonAlert> GetAlertingAlertWithHttpInfo(string alertId);

    /// <summary>
    /// Get a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>CommonRule</returns>

    CommonRule GetAlertingRule(string ruleId);

    /// <summary>
    /// Get a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>ApiResponse of CommonRule</returns>

    ApiResponse<CommonRule> GetAlertingRuleWithHttpInfo(string ruleId);

    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert.
    /// </summary>
    /// <remarks>
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>CommonAlert</returns>

    CommonAlert PatchAlertingAlert(string alertId, AlertRequest body = null);

    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert.
    /// </summary>
    /// <remarks>
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of CommonAlert</returns>

    ApiResponse<CommonAlert> PatchAlertingAlertWithHttpInfo(string alertId, AlertRequest body = null);

    /// <summary>
    /// Updates all alerts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Object</returns>

    object PatchAlertingAlertsAll(CommonAllAlertUpdateRequest body = null);

    /// <summary>
    /// Updates all alerts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of Object</returns>

    ApiResponse<object> PatchAlertingAlertsAllWithHttpInfo(CommonAllAlertUpdateRequest body = null);

    /// <summary>
    /// Bulk alert updates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>BulkResponse</returns>

    BulkResponse PatchAlertingAlertsBulk(CommonAlertBulkUpdateRequest body);

    /// <summary>
    /// Bulk alert updates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of BulkResponse</returns>

    ApiResponse<BulkResponse> PatchAlertingAlertsBulkWithHttpInfo(CommonAlertBulkUpdateRequest body);

    /// <summary>
    /// Bulk update of notification lists
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>BulkResponse</returns>

    BulkResponse PatchAlertingRulesBulk(CommonRuleBulkUpdateNotificationsRequest body);

    /// <summary>
    /// Bulk update of notification lists
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of BulkResponse</returns>

    ApiResponse<BulkResponse> PatchAlertingRulesBulkWithHttpInfo(CommonRuleBulkUpdateNotificationsRequest body);

    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>AlertListing</returns>

    AlertListing PostAlertingAlertsQuery(GetAlertQuery body = null);

    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of AlertListing</returns>

    ApiResponse<AlertListing> PostAlertingAlertsQueryWithHttpInfo(GetAlertQuery body = null);

    /// <summary>
    /// Create a Rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>CommonRule</returns>

    CommonRule PostAlertingRules(CommonRule body);

    /// <summary>
    /// Create a Rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>ApiResponse of CommonRule</returns>

    ApiResponse<CommonRule> PostAlertingRulesWithHttpInfo(CommonRule body);

    /// <summary>
    /// Bulk remove rules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>BulkResponse</returns>

    BulkResponse PostAlertingRulesBulkRemove(CommonRuleBulkDeleteRequest body);

    /// <summary>
    /// Bulk remove rules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of BulkResponse</returns>

    ApiResponse<BulkResponse> PostAlertingRulesBulkRemoveWithHttpInfo(CommonRuleBulkDeleteRequest body);

    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>CommonRuleContainer</returns>

    CommonRuleContainer PostAlertingRulesQuery(GetRulesQuery body = null);

    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of CommonRuleContainer</returns>

    ApiResponse<CommonRuleContainer> PostAlertingRulesQueryWithHttpInfo(GetRulesQuery body = null);

    /// <summary>
    /// Update an alert read status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>AlertingUnreadStatus</returns>

    AlertingUnreadStatus PutAlertingAlert(string alertId, AlertingUnreadStatus body = null);

    /// <summary>
    /// Update an alert read status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of AlertingUnreadStatus</returns>

    ApiResponse<AlertingUnreadStatus> PutAlertingAlertWithHttpInfo(string alertId, AlertingUnreadStatus body = null);

    /// <summary>
    /// Update a rule
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>CommonRule</returns>

    CommonRule PutAlertingRule(string ruleId, ModifiableRuleProperties body);

    /// <summary>
    /// Update a rule
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>ApiResponse of CommonRule</returns>

    ApiResponse<CommonRule> PutAlertingRuleWithHttpInfo(string ruleId, ModifiableRuleProperties body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of void</returns>

    Task DeleteAlertingAlertAsync(string alertId);

    /// <summary>
    /// Delete an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteAlertingAlertAsyncWithHttpInfo(string alertId);

    /// <summary>
    /// Delete all alerts for the user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    Task<object> DeleteAlertingAlertsAllAsync();

    /// <summary>
    /// Delete all alerts for the user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<object>> DeleteAlertingAlertsAllAsyncWithHttpInfo();

    /// <summary>
    /// Delete a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of void</returns>

    Task DeleteAlertingRuleAsync(string ruleId);

    /// <summary>
    /// Delete a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteAlertingRuleAsyncWithHttpInfo(string ruleId);

    /// <summary>
    /// Get an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of CommonAlert</returns>

    Task<CommonAlert> GetAlertingAlertAsync(string alertId);

    /// <summary>
    /// Get an alert
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of ApiResponse (CommonAlert)</returns>

    Task<ApiResponse<CommonAlert>> GetAlertingAlertAsyncWithHttpInfo(string alertId);

    /// <summary>
    /// Get a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of CommonRule</returns>

    Task<CommonRule> GetAlertingRuleAsync(string ruleId);

    /// <summary>
    /// Get a rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of ApiResponse (CommonRule)</returns>

    Task<ApiResponse<CommonRule>> GetAlertingRuleAsyncWithHttpInfo(string ruleId);

    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert.
    /// </summary>
    /// <remarks>
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of CommonAlert</returns>

    Task<CommonAlert> PatchAlertingAlertAsync(string alertId, AlertRequest body = null);

    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert.
    /// </summary>
    /// <remarks>
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (CommonAlert)</returns>

    Task<ApiResponse<CommonAlert>> PatchAlertingAlertAsyncWithHttpInfo(string alertId, AlertRequest body = null);

    /// <summary>
    /// Updates all alerts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of Object</returns>

    Task<object> PatchAlertingAlertsAllAsync(CommonAllAlertUpdateRequest body = null);

    /// <summary>
    /// Updates all alerts
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    Task<ApiResponse<object>> PatchAlertingAlertsAllAsyncWithHttpInfo(CommonAllAlertUpdateRequest body = null);

    /// <summary>
    /// Bulk alert updates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of BulkResponse</returns>

    Task<BulkResponse> PatchAlertingAlertsBulkAsync(CommonAlertBulkUpdateRequest body);

    /// <summary>
    /// Bulk alert updates
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (BulkResponse)</returns>

    Task<ApiResponse<BulkResponse>> PatchAlertingAlertsBulkAsyncWithHttpInfo(CommonAlertBulkUpdateRequest body);

    /// <summary>
    /// Bulk update of notification lists
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of BulkResponse</returns>

    Task<BulkResponse> PatchAlertingRulesBulkAsync(CommonRuleBulkUpdateNotificationsRequest body);

    /// <summary>
    /// Bulk update of notification lists
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (BulkResponse)</returns>

    Task<ApiResponse<BulkResponse>> PatchAlertingRulesBulkAsyncWithHttpInfo(CommonRuleBulkUpdateNotificationsRequest body);

    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of AlertListing</returns>

    Task<AlertListing> PostAlertingAlertsQueryAsync(GetAlertQuery body = null);

    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (AlertListing)</returns>

    Task<ApiResponse<AlertListing>> PostAlertingAlertsQueryAsyncWithHttpInfo(GetAlertQuery body = null);

    /// <summary>
    /// Create a Rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>Task of CommonRule</returns>

    Task<CommonRule> PostAlertingRulesAsync(CommonRule body);

    /// <summary>
    /// Create a Rule.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>Task of ApiResponse (CommonRule)</returns>

    Task<ApiResponse<CommonRule>> PostAlertingRulesAsyncWithHttpInfo(CommonRule body);

    /// <summary>
    /// Bulk remove rules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of BulkResponse</returns>

    Task<BulkResponse> PostAlertingRulesBulkRemoveAsync(CommonRuleBulkDeleteRequest body);

    /// <summary>
    /// Bulk remove rules
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (BulkResponse)</returns>

    Task<ApiResponse<BulkResponse>> PostAlertingRulesBulkRemoveAsyncWithHttpInfo(CommonRuleBulkDeleteRequest body);

    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of CommonRuleContainer</returns>

    Task<CommonRuleContainer> PostAlertingRulesQueryAsync(GetRulesQuery body = null);

    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (CommonRuleContainer)</returns>

    Task<ApiResponse<CommonRuleContainer>> PostAlertingRulesQueryAsyncWithHttpInfo(GetRulesQuery body = null);

    /// <summary>
    /// Update an alert read status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of AlertingUnreadStatus</returns>

    Task<AlertingUnreadStatus> PutAlertingAlertAsync(string alertId, AlertingUnreadStatus body = null);

    /// <summary>
    /// Update an alert read status
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (AlertingUnreadStatus)</returns>

    Task<ApiResponse<AlertingUnreadStatus>> PutAlertingAlertAsyncWithHttpInfo(string alertId, AlertingUnreadStatus body = null);

    /// <summary>
    /// Update a rule
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>Task of CommonRule</returns>

    Task<CommonRule> PutAlertingRuleAsync(string ruleId, ModifiableRuleProperties body);

    /// <summary>
    /// Update a rule
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>Task of ApiResponse (CommonRule)</returns>

    Task<ApiResponse<CommonRule>> PutAlertingRuleAsyncWithHttpInfo(string ruleId, ModifiableRuleProperties body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class AlertingApi : IAlertingApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AlertingApi"/> class.
    /// </summary>
    /// <returns></returns>
    public AlertingApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AlertingApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public AlertingApi(Configuration configuration = null)
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
    /// Delete an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns></returns>

    public void DeleteAlertingAlert(string alertId)
    {
        DeleteAlertingAlertWithHttpInfo(alertId);
    }

    /// <summary>
    /// Delete an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteAlertingAlertWithHttpInfo(string alertId)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->DeleteAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of void</returns>

    public async Task DeleteAlertingAlertAsync(string alertId)
    {
        await DeleteAlertingAlertAsyncWithHttpInfo(alertId);

    }

    /// <summary>
    /// Delete an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteAlertingAlertAsyncWithHttpInfo(string alertId)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->DeleteAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete all alerts for the user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>

    public object DeleteAlertingAlertsAll()
    {
        ApiResponse<object> localVarResponse = DeleteAlertingAlertsAllWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete all alerts for the user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<object> DeleteAlertingAlertsAllWithHttpInfo()
    {

        var localVarPath = "/api/v2/alerting/alerts/all";
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlertsAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlertsAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete all alerts for the user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of Object</returns>

    public async Task<object> DeleteAlertingAlertsAllAsync()
    {
        ApiResponse<object> localVarResponse = await DeleteAlertingAlertsAllAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Delete all alerts for the user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<object>> DeleteAlertingAlertsAllAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/alerting/alerts/all";
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlertsAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingAlertsAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns></returns>

    public void DeleteAlertingRule(string ruleId)
    {
        DeleteAlertingRuleWithHttpInfo(ruleId);
    }

    /// <summary>
    /// Delete a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteAlertingRuleWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->DeleteAlertingRule");
        }

        var localVarPath = "/api/v2/alerting/rules/{ruleId}";
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of void</returns>

    public async Task DeleteAlertingRuleAsync(string ruleId)
    {
        await DeleteAlertingRuleAsyncWithHttpInfo(ruleId);

    }

    /// <summary>
    /// Delete a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteAlertingRuleAsyncWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->DeleteAlertingRule");
        }

        var localVarPath = "/api/v2/alerting/rules/{ruleId}";
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteAlertingRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>CommonAlert</returns>

    public CommonAlert GetAlertingAlert(string alertId)
    {
        ApiResponse<CommonAlert> localVarResponse = GetAlertingAlertWithHttpInfo(alertId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>ApiResponse of CommonAlert</returns>

    public ApiResponse<CommonAlert> GetAlertingAlertWithHttpInfo(string alertId)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->GetAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonAlert>(localVarStatusCode,
            localVarHeaders,
            (CommonAlert)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonAlert)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of CommonAlert</returns>

    public async Task<CommonAlert> GetAlertingAlertAsync(string alertId)
    {
        ApiResponse<CommonAlert> localVarResponse = await GetAlertingAlertAsyncWithHttpInfo(alertId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get an alert 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <returns>Task of ApiResponse (CommonAlert)</returns>

    public async Task<ApiResponse<CommonAlert>> GetAlertingAlertAsyncWithHttpInfo(string alertId)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->GetAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonAlert>(localVarStatusCode,
            localVarHeaders,
            (CommonAlert)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonAlert)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>CommonRule</returns>

    public CommonRule GetAlertingRule(string ruleId)
    {
        ApiResponse<CommonRule> localVarResponse = GetAlertingRuleWithHttpInfo(ruleId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>ApiResponse of CommonRule</returns>

    public ApiResponse<CommonRule> GetAlertingRuleWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->GetAlertingRule");
        }

        var localVarPath = "/api/v2/alerting/rules/{ruleId}";
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
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRule>(localVarStatusCode,
            localVarHeaders,
            (CommonRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of CommonRule</returns>

    public async Task<CommonRule> GetAlertingRuleAsync(string ruleId)
    {
        ApiResponse<CommonRule> localVarResponse = await GetAlertingRuleAsyncWithHttpInfo(ruleId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <returns>Task of ApiResponse (CommonRule)</returns>

    public async Task<ApiResponse<CommonRule>> GetAlertingRuleAsyncWithHttpInfo(string ruleId)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->GetAlertingRule");
        }

        var localVarPath = "/api/v2/alerting/rules/{ruleId}";
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
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetAlertingRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRule>(localVarStatusCode,
            localVarHeaders,
            (CommonRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert. 
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>CommonAlert</returns>

    public CommonAlert PatchAlertingAlert(string alertId, AlertRequest body = null)
    {
        ApiResponse<CommonAlert> localVarResponse = PatchAlertingAlertWithHttpInfo(alertId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert. 
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of CommonAlert</returns>

    public ApiResponse<CommonAlert> PatchAlertingAlertWithHttpInfo(string alertId, AlertRequest body = null)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PatchAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonAlert>(localVarStatusCode,
            localVarHeaders,
            (CommonAlert)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonAlert)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert. 
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of CommonAlert</returns>

    public async Task<CommonAlert> PatchAlertingAlertAsync(string alertId, AlertRequest body = null)
    {
        ApiResponse<CommonAlert> localVarResponse = await PatchAlertingAlertAsyncWithHttpInfo(alertId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Allows an entity to mute/snooze an alert or update the unread status of the alert. 
    /// Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (CommonAlert)</returns>

    public async Task<ApiResponse<CommonAlert>> PatchAlertingAlertAsyncWithHttpInfo(string alertId, AlertRequest body = null)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PatchAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonAlert>(localVarStatusCode,
            localVarHeaders,
            (CommonAlert)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonAlert)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Updates all alerts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Object</returns>

    public object PatchAlertingAlertsAll(CommonAllAlertUpdateRequest body = null)
    {
        ApiResponse<object> localVarResponse = PatchAlertingAlertsAllWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Updates all alerts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of Object</returns>

    public ApiResponse<object> PatchAlertingAlertsAllWithHttpInfo(CommonAllAlertUpdateRequest body = null)
    {

        var localVarPath = "/api/v2/alerting/alerts/all";
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Updates all alerts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of Object</returns>

    public async Task<object> PatchAlertingAlertsAllAsync(CommonAllAlertUpdateRequest body = null)
    {
        ApiResponse<object> localVarResponse = await PatchAlertingAlertsAllAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Updates all alerts 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (Object)</returns>

    public async Task<ApiResponse<object>> PatchAlertingAlertsAllAsyncWithHttpInfo(CommonAllAlertUpdateRequest body = null)
    {

        var localVarPath = "/api/v2/alerting/alerts/all";
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            (object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Bulk alert updates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>BulkResponse</returns>

    public BulkResponse PatchAlertingAlertsBulk(CommonAlertBulkUpdateRequest body)
    {
        ApiResponse<BulkResponse> localVarResponse = PatchAlertingAlertsBulkWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Bulk alert updates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of BulkResponse</returns>

    public ApiResponse<BulkResponse> PatchAlertingAlertsBulkWithHttpInfo(CommonAlertBulkUpdateRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PatchAlertingAlertsBulk");
        }

        var localVarPath = "/api/v2/alerting/alerts/bulk";
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BulkResponse>(localVarStatusCode,
            localVarHeaders,
            (BulkResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Bulk alert updates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of BulkResponse</returns>

    public async Task<BulkResponse> PatchAlertingAlertsBulkAsync(CommonAlertBulkUpdateRequest body)
    {
        ApiResponse<BulkResponse> localVarResponse = await PatchAlertingAlertsBulkAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Bulk alert updates 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (BulkResponse)</returns>

    public async Task<ApiResponse<BulkResponse>> PatchAlertingAlertsBulkAsyncWithHttpInfo(CommonAlertBulkUpdateRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PatchAlertingAlertsBulk");
        }

        var localVarPath = "/api/v2/alerting/alerts/bulk";
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingAlertsBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BulkResponse>(localVarStatusCode,
            localVarHeaders,
            (BulkResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Bulk update of notification lists 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>BulkResponse</returns>

    public BulkResponse PatchAlertingRulesBulk(CommonRuleBulkUpdateNotificationsRequest body)
    {
        ApiResponse<BulkResponse> localVarResponse = PatchAlertingRulesBulkWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Bulk update of notification lists 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of BulkResponse</returns>

    public ApiResponse<BulkResponse> PatchAlertingRulesBulkWithHttpInfo(CommonRuleBulkUpdateNotificationsRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PatchAlertingRulesBulk");
        }

        var localVarPath = "/api/v2/alerting/rules/bulk";
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingRulesBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingRulesBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BulkResponse>(localVarStatusCode,
            localVarHeaders,
            (BulkResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Bulk update of notification lists 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of BulkResponse</returns>

    public async Task<BulkResponse> PatchAlertingRulesBulkAsync(CommonRuleBulkUpdateNotificationsRequest body)
    {
        ApiResponse<BulkResponse> localVarResponse = await PatchAlertingRulesBulkAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Bulk update of notification lists 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (BulkResponse)</returns>

    public async Task<ApiResponse<BulkResponse>> PatchAlertingRulesBulkAsyncWithHttpInfo(CommonRuleBulkUpdateNotificationsRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PatchAlertingRulesBulk");
        }

        var localVarPath = "/api/v2/alerting/rules/bulk";
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
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingRulesBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchAlertingRulesBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BulkResponse>(localVarStatusCode,
            localVarHeaders,
            (BulkResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>AlertListing</returns>

    public AlertListing PostAlertingAlertsQuery(GetAlertQuery body = null)
    {
        ApiResponse<AlertListing> localVarResponse = PostAlertingAlertsQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of AlertListing</returns>

    public ApiResponse<AlertListing> PostAlertingAlertsQueryWithHttpInfo(GetAlertQuery body = null)
    {

        var localVarPath = "/api/v2/alerting/alerts/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingAlertsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingAlertsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AlertListing>(localVarStatusCode,
            localVarHeaders,
            (AlertListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of AlertListing</returns>

    public async Task<AlertListing> PostAlertingAlertsQueryAsync(GetAlertQuery body = null)
    {
        ApiResponse<AlertListing> localVarResponse = await PostAlertingAlertsQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Gets a paged list of alerts. The max page size is 50 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (AlertListing)</returns>

    public async Task<ApiResponse<AlertListing>> PostAlertingAlertsQueryAsyncWithHttpInfo(GetAlertQuery body = null)
    {

        var localVarPath = "/api/v2/alerting/alerts/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingAlertsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingAlertsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AlertListing>(localVarStatusCode,
            localVarHeaders,
            (AlertListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create a Rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>CommonRule</returns>

    public CommonRule PostAlertingRules(CommonRule body)
    {
        ApiResponse<CommonRule> localVarResponse = PostAlertingRulesWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>ApiResponse of CommonRule</returns>

    public ApiResponse<CommonRule> PostAlertingRulesWithHttpInfo(CommonRule body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PostAlertingRules");
        }

        var localVarPath = "/api/v2/alerting/rules";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRule>(localVarStatusCode,
            localVarHeaders,
            (CommonRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create a Rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>Task of CommonRule</returns>

    public async Task<CommonRule> PostAlertingRulesAsync(CommonRule body)
    {
        ApiResponse<CommonRule> localVarResponse = await PostAlertingRulesAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create a Rule. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">rule to be created</param>
    /// <returns>Task of ApiResponse (CommonRule)</returns>

    public async Task<ApiResponse<CommonRule>> PostAlertingRulesAsyncWithHttpInfo(CommonRule body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PostAlertingRules");
        }

        var localVarPath = "/api/v2/alerting/rules";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRule>(localVarStatusCode,
            localVarHeaders,
            (CommonRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Bulk remove rules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>BulkResponse</returns>

    public BulkResponse PostAlertingRulesBulkRemove(CommonRuleBulkDeleteRequest body)
    {
        ApiResponse<BulkResponse> localVarResponse = PostAlertingRulesBulkRemoveWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Bulk remove rules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of BulkResponse</returns>

    public ApiResponse<BulkResponse> PostAlertingRulesBulkRemoveWithHttpInfo(CommonRuleBulkDeleteRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PostAlertingRulesBulkRemove");
        }

        var localVarPath = "/api/v2/alerting/rules/bulk/remove";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesBulkRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesBulkRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BulkResponse>(localVarStatusCode,
            localVarHeaders,
            (BulkResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Bulk remove rules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of BulkResponse</returns>

    public async Task<BulkResponse> PostAlertingRulesBulkRemoveAsync(CommonRuleBulkDeleteRequest body)
    {
        ApiResponse<BulkResponse> localVarResponse = await PostAlertingRulesBulkRemoveAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Bulk remove rules 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (BulkResponse)</returns>

    public async Task<ApiResponse<BulkResponse>> PostAlertingRulesBulkRemoveAsyncWithHttpInfo(CommonRuleBulkDeleteRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PostAlertingRulesBulkRemove");
        }

        var localVarPath = "/api/v2/alerting/rules/bulk/remove";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesBulkRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesBulkRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<BulkResponse>(localVarStatusCode,
            localVarHeaders,
            (BulkResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>CommonRuleContainer</returns>

    public CommonRuleContainer PostAlertingRulesQuery(GetRulesQuery body = null)
    {
        ApiResponse<CommonRuleContainer> localVarResponse = PostAlertingRulesQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of CommonRuleContainer</returns>

    public ApiResponse<CommonRuleContainer> PostAlertingRulesQueryWithHttpInfo(GetRulesQuery body = null)
    {

        var localVarPath = "/api/v2/alerting/rules/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRuleContainer>(localVarStatusCode,
            localVarHeaders,
            (CommonRuleContainer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRuleContainer)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of CommonRuleContainer</returns>

    public async Task<CommonRuleContainer> PostAlertingRulesQueryAsync(GetRulesQuery body = null)
    {
        ApiResponse<CommonRuleContainer> localVarResponse = await PostAlertingRulesQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a paged list of rules.  The max size of the page is 50 items. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (CommonRuleContainer)</returns>

    public async Task<ApiResponse<CommonRuleContainer>> PostAlertingRulesQueryAsyncWithHttpInfo(GetRulesQuery body = null)
    {

        var localVarPath = "/api/v2/alerting/rules/query";
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
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAlertingRulesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRuleContainer>(localVarStatusCode,
            localVarHeaders,
            (CommonRuleContainer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRuleContainer)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update an alert read status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>AlertingUnreadStatus</returns>

    public AlertingUnreadStatus PutAlertingAlert(string alertId, AlertingUnreadStatus body = null)
    {
        ApiResponse<AlertingUnreadStatus> localVarResponse = PutAlertingAlertWithHttpInfo(alertId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an alert read status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of AlertingUnreadStatus</returns>

    public ApiResponse<AlertingUnreadStatus> PutAlertingAlertWithHttpInfo(string alertId, AlertingUnreadStatus body = null)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PutAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AlertingUnreadStatus>(localVarStatusCode,
            localVarHeaders,
            (AlertingUnreadStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertingUnreadStatus)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update an alert read status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of AlertingUnreadStatus</returns>

    public async Task<AlertingUnreadStatus> PutAlertingAlertAsync(string alertId, AlertingUnreadStatus body = null)
    {
        ApiResponse<AlertingUnreadStatus> localVarResponse = await PutAlertingAlertAsyncWithHttpInfo(alertId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update an alert read status 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="alertId">Alert ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (AlertingUnreadStatus)</returns>

    public async Task<ApiResponse<AlertingUnreadStatus>> PutAlertingAlertAsyncWithHttpInfo(string alertId, AlertingUnreadStatus body = null)
    {
        // verify the required parameter 'alertId' is set
        if (alertId == null)
        {
            throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PutAlertingAlert");
        }

        var localVarPath = "/api/v2/alerting/alerts/{alertId}";
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
        if (alertId != null)
        {
            localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId));
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
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AlertingUnreadStatus>(localVarStatusCode,
            localVarHeaders,
            (AlertingUnreadStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertingUnreadStatus)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a rule 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>CommonRule</returns>

    public CommonRule PutAlertingRule(string ruleId, ModifiableRuleProperties body)
    {
        ApiResponse<CommonRule> localVarResponse = PutAlertingRuleWithHttpInfo(ruleId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a rule 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>ApiResponse of CommonRule</returns>

    public ApiResponse<CommonRule> PutAlertingRuleWithHttpInfo(string ruleId, ModifiableRuleProperties body)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->PutAlertingRule");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PutAlertingRule");
        }

        var localVarPath = "/api/v2/alerting/rules/{ruleId}";
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
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRule>(localVarStatusCode,
            localVarHeaders,
            (CommonRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a rule 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>Task of CommonRule</returns>

    public async Task<CommonRule> PutAlertingRuleAsync(string ruleId, ModifiableRuleProperties body)
    {
        ApiResponse<CommonRule> localVarResponse = await PutAlertingRuleAsyncWithHttpInfo(ruleId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a rule 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ruleId">Rule Id</param>
    /// <param name="body">rule to be updated</param>
    /// <returns>Task of ApiResponse (CommonRule)</returns>

    public async Task<ApiResponse<CommonRule>> PutAlertingRuleAsyncWithHttpInfo(string ruleId, ModifiableRuleProperties body)
    {
        // verify the required parameter 'ruleId' is set
        if (ruleId == null)
        {
            throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->PutAlertingRule");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PutAlertingRule");
        }

        var localVarPath = "/api/v2/alerting/rules/{ruleId}";
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
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutAlertingRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CommonRule>(localVarStatusCode,
            localVarHeaders,
            (CommonRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonRule)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
