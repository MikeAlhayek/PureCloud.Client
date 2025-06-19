using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IAlertingApi
{
    Task<CommonRule> GetAlertingRuleAsync(string ruleId, CancellationToken cancellationToken = default);

    Task<CommonAlert> GetAlertingAlertAsync(string alertId, CancellationToken cancellationToken = default);

    Task<CommonAlert> PatchAlertingAlertAsync(string alertId, AlertRequest body = null, CancellationToken cancellationToken = default);

    Task<bool> PatchAlertingAlertsAllAsync(CommonAllAlertUpdateRequest body = null, CancellationToken cancellationToken = default);

    Task<BulkResponse> PatchAlertingAlertsBulkAsync(CommonAlertBulkUpdateRequest body, CancellationToken cancellationToken = default);

    Task<BulkResponse> PatchAlertingRulesBulkAsync(CommonRuleBulkUpdateNotificationsRequest body, CancellationToken cancellationToken = default);

    Task<AlertingUnreadStatus> PutAlertingAlertAsync(string alertId, AlertingUnreadStatus body = null, CancellationToken cancellationToken = default);

    Task<CommonRule> PutAlertingRuleAsync(string ruleId, ModifiableRuleProperties body, CancellationToken cancellationToken = default);

    Task<AlertListing> PostAlertingAlertsQueryAsync(GetAlertQuery body = null, CancellationToken cancellationToken = default);

    Task<CommonRule> PostAlertingRulesAsync(CommonRule body, CancellationToken cancellationToken = default);

    Task<BulkResponse> PostAlertingRulesBulkRemoveAsync(CommonRuleBulkDeleteRequest body, CancellationToken cancellationToken = default);

    Task<CommonRuleContainer> PostAlertingRulesQueryAsync(GetRulesQuery body = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteAlertingAlertAsync(string alertId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAlertingAlertsAllAsync(CancellationToken cancellationToken = default);

    Task<bool> DeleteAlertingRuleAsync(string ruleId, CancellationToken cancellationToken = default);
}
