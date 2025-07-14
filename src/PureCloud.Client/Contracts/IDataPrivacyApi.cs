using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;
public interface IDataPrivacyApi
{
    Task<bool> DeleteDataprivacyMaskingruleAsync(string ruleId, CancellationToken cancellationToken = default);

    Task<MaskingRule> GetDataprivacyMaskingruleAsync(string ruleId, CancellationToken cancellationToken = default);

    Task<MaskingRuleListing> GetDataprivacyMaskingrulesAsync(CancellationToken cancellationToken = default);

    Task<MaskingRule> UpdateDataprivacyMaskingruleAsync(string ruleId, MaskingRule body, CancellationToken cancellationToken = default);

    Task<MaskingRule> CreateDataprivacyMaskingruleAsync(MaskingRule body, CancellationToken cancellationToken = default);

    Task<MaskingRuleValidateResponse> ValidateDataprivacyMaskingrulesAsync(MaskingRuleValidateRequest body, CancellationToken cancellationToken = default);
}
