using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IBillingApi
{
    Task<BillingUsageReport> GetBillingReportsBillableusageAsync(DateTime? startDate, DateTime? endDate, CancellationToken cancellationToken = default);

    Task<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdAsync(string trustorOrgId, int? billingPeriodIndex = null, CancellationToken cancellationToken = default);
}
