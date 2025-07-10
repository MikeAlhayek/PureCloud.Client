using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class BillingApi : IBillingApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public BillingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<BillingUsageReport> GetBillingReportsBillableusageAsync(DateTime? startDate, DateTime? endDate, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(startDate, nameof(startDate));

        ArgumentNullException.ThrowIfNull(endDate, nameof(endDate));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection
        {
            { "startDate", startDate.Value.ToString("o") },
            { "endDate",   endDate.Value.ToString("o")   }
        };

        var url = UriHelper.GetUri("/api/v2/billing/reports/billableusage", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BillingUsageReport>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdAsync(string trustorOrgId, int? billingPeriodIndex = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(trustorOrgId, nameof(trustorOrgId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (billingPeriodIndex.HasValue)
        {
            parameters.Add("billingPeriodIndex", billingPeriodIndex.Value.ToString());
        }

        var url = UriHelper.GetUri($"/api/v2/billing/trusteebillingoverview/{trustorOrgId}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrusteeBillingOverview>(_options.JsonSerializerOptions, cancellationToken);
    }

}
