using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class GamificationApi : IGamificationApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public GamificationApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<bool> DeleteEmployeeperformanceExternalmetricsDefinitionAsync(string metricId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/employeeperformance/externalmetrics/definitions/{metricId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteGamificationContestAsync(string contestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/gamification/contests/{contestId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<ExternalMetricDefinition> GetEmployeeperformanceExternalmetricsDefinitionAsync(string metricId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/employeeperformance/externalmetrics/definitions/{metricId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalMetricDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalMetricDefinitionListing> GetEmployeeperformanceExternalmetricsDefinitionsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/employeeperformance/externalmetrics/definitions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalMetricDefinitionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestsResponse> GetGamificationContestAsync(string contestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/contests/{contestId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestScoresAgentsPagedList> GetGamificationContestAgentsScoresAsync(string contestId, int? pageNumber = null, int? pageSize = null, string workday = null, string returnsView = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (!string.IsNullOrEmpty(returnsView))
        {
            parameters.Add("returnsView", UriHelper.ParameterToString(returnsView));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/contests/{contestId}/agents/scores", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestScoresAgentsPagedList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestScoresAgentsPagedList> GetGamificationContestAgentsScoresMeAsync(string contestId, int? pageNumber = null, int? pageSize = null, string workday = null, string returnsView = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (!string.IsNullOrEmpty(returnsView))
        {
            parameters.Add("returnsView", UriHelper.ParameterToString(returnsView));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/contests/{contestId}/agents/scores/me", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestScoresAgentsPagedList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestScoresGroupTrendList> GetGamificationContestAgentsScoresTrendsAsync(string contestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/contests/{contestId}/agents/scores/trends", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestScoresGroupTrendList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestScoresAgentTrendList> GetGamificationContestAgentsScoresTrendsMeAsync(string contestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/contests/{contestId}/agents/scores/trends/me", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestScoresAgentTrendList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PrizeImages> GetGamificationContestPrizeimageAsync(string contestId, string prizeImageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        ArgumentException.ThrowIfNullOrEmpty(prizeImageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/contests/{contestId}/prizeimages/{prizeImageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PrizeImages>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetContestsEssentialsListing> GetGamificationContestsAsync(int? pageNumber = null, int? pageSize = null, string dateStart = null, string dateEnd = null, IList<string> status = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(dateStart))
        {
            parameters.Add("dateStart", UriHelper.ParameterToString(dateStart));
        }

        if (!string.IsNullOrEmpty(dateEnd))
        {
            parameters.Add("dateEnd", UriHelper.ParameterToString(dateEnd));
        }

        if (status != null)
        {
            foreach (var s in status)
            {
                parameters.Add("status", UriHelper.ParameterToString(s));
            }
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/contests", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetContestsEssentialsListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetContestsEssentialsListing> GetGamificationContestsMeAsync(int? pageNumber = null, int? pageSize = null, string dateStart = null, string dateEnd = null, IList<string> status = null, string sortBy = null, string sortOrder = null, string view = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(dateStart))
        {
            parameters.Add("dateStart", UriHelper.ParameterToString(dateStart));
        }

        if (!string.IsNullOrEmpty(dateEnd))
        {
            parameters.Add("dateEnd", UriHelper.ParameterToString(dateEnd));
        }

        if (status != null)
        {
            foreach (var s in status)
            {
                parameters.Add("status", UriHelper.ParameterToString(s));
            }
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(view))
        {
            parameters.Add("view", UriHelper.ParameterToString(view));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/contests/me", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetContestsEssentialsListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<InsightsSummary> GetGamificationInsightsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, int? pageSize = null, int? pageNumber = null, string sortKey = null, string sortMetricId = null, string sortOrder = null, string userIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (!string.IsNullOrEmpty(sortKey))
        {
            parameters.Add("sortKey", UriHelper.ParameterToString(sortKey));
        }

        if (!string.IsNullOrEmpty(sortMetricId))
        {
            parameters.Add("sortMetricId", UriHelper.ParameterToString(sortMetricId));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(userIds))
        {
            parameters.Add("userIds", UriHelper.ParameterToString(userIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsSummary>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<InsightsDetails> GetGamificationInsightsDetailsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights/details", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsDetails>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<InsightsTrend> GetGamificationInsightsGroupsTrendsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodEndWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodEndWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("comparativePeriodEndWorkday", comparativePeriodEndWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
            ("primaryPeriodEndWorkday", primaryPeriodEndWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights/groups/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<InsightsTrend> GetGamificationInsightsGroupsTrendsAllAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodEndWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodEndWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("comparativePeriodEndWorkday", comparativePeriodEndWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
            ("primaryPeriodEndWorkday", primaryPeriodEndWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights/groups/trends/all", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<InsightsAgents> GetGamificationInsightsMembersAsync(string filterType, string filterId, string granularity, string startWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("startWorkday", startWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights/members", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsAgents>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<InsightsRankings> GetGamificationInsightsRankingsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, string sortKey, string sortMetricId = null, int? sectionSize = null, string userIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(sortKey);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
            ("sortKey", sortKey),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        if (!string.IsNullOrEmpty(sortMetricId))
        {
            parameters.Add("sortMetricId", UriHelper.ParameterToString(sortMetricId));
        }

        if (sectionSize.HasValue)
        {
            parameters.Add("sectionSize", UriHelper.ParameterToString(sectionSize.Value));
        }

        if (!string.IsNullOrEmpty(userIds))
        {
            parameters.Add("userIds", UriHelper.ParameterToString(userIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights/rankings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsRankings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserInsightsTrend> GetGamificationInsightsTrendsAsync(string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodEndWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodEndWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("comparativePeriodEndWorkday", comparativePeriodEndWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
            ("primaryPeriodEndWorkday", primaryPeriodEndWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/insights/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserInsightsTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<InsightsDetails> GetGamificationInsightsUserDetailsAsync(string userId, string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string primaryPeriodStartWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/insights/users/{userId}/details", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InsightsDetails>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserInsightsTrend> GetGamificationInsightsUserTrendsAsync(string userId, string filterType, string filterId, string granularity, string comparativePeriodStartWorkday, string comparativePeriodEndWorkday, string primaryPeriodStartWorkday, string primaryPeriodEndWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(granularity);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(comparativePeriodEndWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodStartWorkday);

        ArgumentException.ThrowIfNullOrEmpty(primaryPeriodEndWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("userId", userId),
            ("filterType", filterType),
            ("filterId", filterId),
            ("granularity", granularity),
            ("comparativePeriodStartWorkday", comparativePeriodStartWorkday),
            ("comparativePeriodEndWorkday", comparativePeriodEndWorkday),
            ("primaryPeriodStartWorkday", primaryPeriodStartWorkday),
            ("primaryPeriodEndWorkday", primaryPeriodEndWorkday)
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/insights/users/{userId}/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserInsightsTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Leaderboard> GetGamificationLeaderboardAsync(string startWorkday, string endWorkday, string metricId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("startWorkday", startWorkday),
            ("endWorkday", endWorkday)
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        if (!string.IsNullOrEmpty(metricId))
        {
            parameters.Add("metricId", UriHelper.ParameterToString(metricId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/leaderboard", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Leaderboard>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Leaderboard> GetGamificationLeaderboardAllAsync(string filterType, string filterId, string startWorkday, string endWorkday, string metricId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId),
            ("startWorkday", startWorkday),
            ("endWorkday", endWorkday)
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        if (!string.IsNullOrEmpty(metricId))
        {
            parameters.Add("metricId", UriHelper.ParameterToString(metricId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/leaderboard/all", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Leaderboard>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OverallBestPoints> GetGamificationLeaderboardAllBestpointsAsync(string filterType, string filterId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("filterType", filterType),
            ("filterId", filterId)
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/leaderboard/all/bestpoints", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OverallBestPoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OverallBestPoints> GetGamificationLeaderboardBestpointsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/gamification/leaderboard/bestpoints", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OverallBestPoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MetricDefinition> GetGamificationMetricdefinitionAsync(string metricDefinitionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(metricDefinitionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/metricdefinitions/{metricDefinitionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MetricDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetMetricDefinitionsResponse> GetGamificationMetricdefinitionsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/gamification/metricdefinitions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetMetricDefinitionsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> GetGamificationProfileAsync(string profileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/profiles/{profileId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MemberListing> GetGamificationProfileMembersAsync(string profileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/profiles/{profileId}/members", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MemberListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Metric> GetGamificationProfileMetricAsync(string profileId, string metricId, string workday = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentException.ThrowIfNullOrEmpty(metricId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/profiles/{profileId}/metrics/{metricId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Metric>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetMetricResponse> GetGamificationProfileMetricsAsync(string profileId, IList<string> expand = null, string workday = null, string metricIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (!string.IsNullOrEmpty(metricIds))
        {
            parameters.Add("metricIds", UriHelper.ParameterToString(metricIds));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/profiles/{profileId}/metrics", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetMetricResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetMetricsResponse> GetGamificationProfileMetricsObjectiveDetailsAsync(string profileId, string workday = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/profiles/{profileId}/metrics/objectivedetails", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetMetricsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetProfilesResponse> GetGamificationProfilesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/gamification/profiles", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetProfilesResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> GetGamificationProfilesUserAsync(string userId, string workday = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/profiles/users/{userId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> GetGamificationProfilesUsersMeAsync(string workday = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/profiles/users/me", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayMetricListing> GetGamificationScorecardsAsync(string workday, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayMetricListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AttendanceStatusListing> GetGamificationScorecardsAttendanceAsync(string startWorkday, string endWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        var required = new (string Name, string Value)[]
        {
            ("startWorkday", startWorkday),
            ("endWorkday", endWorkday)
        };

        foreach (var (Name, Value) in required)
        {
            parameters.Add(Name, UriHelper.ParameterToString(Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/attendance", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttendanceStatusListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserBestPoints> GetGamificationScorecardsBestpointsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/gamification/scorecards/bestpoints", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserBestPoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SingleWorkdayAveragePoints> GetGamificationScorecardsPointsAverageAsync(string workday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/points/average", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SingleWorkdayAveragePoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayPointsTrend> GetGamificationScorecardsPointsTrendsAsync(string startWorkday, string endWorkday, string dayOfWeek = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(dayOfWeek))
        {
            parameters.Add("dayOfWeek", UriHelper.ParameterToString(dayOfWeek));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/points/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayPointsTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUserValuesTrendsAsync(string profileId, string metricId, string userId, string startWorkday, string endWorkday, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentException.ThrowIfNullOrEmpty(metricId);

        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(referenceWorkday))
        {
            parameters.Add("referenceWorkday", UriHelper.ParameterToString(referenceWorkday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/{userId}/values/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MetricValueTrendAverage>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUsersValuesTrendsAsync(string profileId, string metricId, string filterType, string startWorkday, string endWorkday, string filterId = null, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentException.ThrowIfNullOrEmpty(metricId);

        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(filterId))
        {
            parameters.Add("filterId", UriHelper.ParameterToString(filterId));
        }

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(referenceWorkday))
        {
            parameters.Add("referenceWorkday", UriHelper.ParameterToString(referenceWorkday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/values/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MetricValueTrendAverage>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricValuesTrendsAsync(string profileId, string metricId, string startWorkday, string endWorkday, string filterType = null, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentException.ThrowIfNullOrEmpty(metricId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(referenceWorkday))
        {
            parameters.Add("referenceWorkday", UriHelper.ParameterToString(referenceWorkday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/values/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MetricValueTrendAverage>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayMetricListing> GetGamificationScorecardsUserAsync(string userId, string workday, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(workday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/users/{userId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayMetricListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AttendanceStatusListing> GetGamificationScorecardsUserAttendanceAsync(string userId, string startWorkday, string endWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/users/{userId}/attendance", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttendanceStatusListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserBestPoints> GetGamificationScorecardsUserBestpointsAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/scorecards/users/{userId}/bestpoints", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserBestPoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AllTimePoints> GetGamificationScorecardsUserPointsAlltimeAsync(string userId, string endWorkday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/users/{userId}/points/alltime", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AllTimePoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayPointsTrend> GetGamificationScorecardsUserPointsTrendsAsync(string userId, string startWorkday, string endWorkday, string dayOfWeek = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(dayOfWeek))
        {
            parameters.Add("dayOfWeek", UriHelper.ParameterToString(dayOfWeek));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/users/{userId}/points/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayPointsTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayValuesTrend> GetGamificationScorecardsUserValuesTrendsAsync(string userId, string startWorkday, string endWorkday, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/gamification/scorecards/users/{userId}/values/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayValuesTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SingleWorkdayAveragePoints> GetGamificationScorecardsUsersPointsAverageAsync(string filterType, string filterId, string workday, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(workday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(filterId))
        {
            parameters.Add("filterId", UriHelper.ParameterToString(filterId));
        }

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/users/points/average", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SingleWorkdayAveragePoints>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SingleWorkdayAverageValues> GetGamificationScorecardsUsersValuesAverageAsync(string filterType, string filterId, string workday, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(workday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(filterId))
        {
            parameters.Add("filterId", UriHelper.ParameterToString(filterId));
        }

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/users/values/average", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SingleWorkdayAverageValues>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayValuesTrend> GetGamificationScorecardsUsersValuesTrendsAsync(string filterType, string filterId, string startWorkday, string endWorkday, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filterType);

        ArgumentException.ThrowIfNullOrEmpty(filterId);

        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(filterId))
        {
            parameters.Add("filterId", UriHelper.ParameterToString(filterId));
        }

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/users/values/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayValuesTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SingleWorkdayAverageValues> GetGamificationScorecardsValuesAverageAsync(string workday, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(workday))
        {
            parameters.Add("workday", UriHelper.ParameterToString(workday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/values/average", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SingleWorkdayAverageValues>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkdayValuesTrend> GetGamificationScorecardsValuesTrendsAsync(string startWorkday, string endWorkday, string filterType = null, string referenceWorkday = null, string timeZone = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(startWorkday);

        ArgumentException.ThrowIfNullOrEmpty(endWorkday);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(startWorkday))
        {
            parameters.Add("startWorkday", UriHelper.ParameterToString(startWorkday));
        }

        if (!string.IsNullOrEmpty(endWorkday))
        {
            parameters.Add("endWorkday", UriHelper.ParameterToString(endWorkday));
        }

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(referenceWorkday))
        {
            parameters.Add("referenceWorkday", UriHelper.ParameterToString(referenceWorkday));
        }

        if (!string.IsNullOrEmpty(timeZone))
        {
            parameters.Add("timeZone", UriHelper.ParameterToString(timeZone));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/scorecards/values/trends", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkdayValuesTrend>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GamificationStatus> GetGamificationStatusAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/gamification/status", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GamificationStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ObjectiveTemplate> GetGamificationTemplateAsync(string templateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(templateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gamification/templates/{templateId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ObjectiveTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetTemplatesResponse> GetGamificationTemplatesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/gamification/templates", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetTemplatesResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalMetricDefinition> UpdateEmployeeperformanceExternalmetricsDefinitionAsync(string metricId, ExternalMetricDefinitionUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/employeeperformance/externalmetrics/definitions/{metricId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalMetricDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestsResponse> UpdateGamificationContestAsync(string contestId, ContestsFinalizeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/gamification/contests/{contestId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalMetricDataWriteResponse> CreateEmployeeperformanceExternalmetricsDataAsync(ExternalMetricDataWriteRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/employeeperformance/externalmetrics/data", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalMetricDataWriteResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalMetricDefinition> CreateEmployeeperformanceExternalmetricsDefinitionAsync(ExternalMetricDefinitionCreateRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/employeeperformance/externalmetrics/definitions", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalMetricDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestsResponse> CreateGamificationContestAsync(ContestsCreateRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/gamification/contests", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UploadUrlResponse> CreateGamificationContestPrizeImageUploadUrlAsync(GamificationContestPrizeImageUploadUrlRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/gamification/contests/uploads/prizeimages", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UploadUrlResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> ActivateGamificationProfileAsync(string profileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/gamification/profiles/{profileId}/activate", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> DeactivateGamificationProfileAsync(string profileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/gamification/profiles/{profileId}/deactivate", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Assignment> CreateGamificationProfileMembersAsync(string profileId, AssignUsers body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/gamification/profiles/{profileId}/members", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Assignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssignmentValidation> ValidateGamificationProfileMembersAsync(string profileId, ValidateAssignUsers body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/gamification/profiles/{profileId}/members/validate", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssignmentValidation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Metric> CreateGamificationProfileMetricLinkAsync(string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceProfileId);

        ArgumentException.ThrowIfNullOrEmpty(sourceMetricId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/gamification/profiles/{sourceProfileId}/metrics/{sourceMetricId}/link", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Metric>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Metric> CreateGamificationProfileMetricAsync(string profileId, CreateMetric body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/gamification/profiles/{profileId}/metrics", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Metric>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> CreateGamificationProfileAsync(CreatePerformanceProfile body, bool? copyMetrics = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (copyMetrics.HasValue)
        {
            parameters.Add("copyMetrics", UriHelper.ParameterToString(copyMetrics.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gamification/profiles", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserProfilesInDateRange> QueryGamificationProfilesForUserAsync(string userId, UserProfilesInDateRangeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/gamification/profiles/users/{userId}/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserProfilesInDateRange>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserProfilesInDateRange> QueryGamificationProfilesUsersMeAsync(UserProfilesInDateRangeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/gamification/profiles/users/me/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserProfilesInDateRange>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContestsResponse> UpdateGamificationContestAsync(string contestId, ContestsCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contestId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/gamification/contests/{contestId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContestsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PerformanceProfile> UpdateGamificationProfileAsync(string profileId, PerformanceProfile body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/gamification/profiles/{profileId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformanceProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Metric> UpdateGamificationProfileMetricAsync(string profileId, string metricId, CreateMetric body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(profileId);

        ArgumentException.ThrowIfNullOrEmpty(metricId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/gamification/profiles/{profileId}/metrics/{metricId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Metric>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GamificationStatus> UpdateGamificationStatusAsync(GamificationStatus status, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(status);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/gamification/status", status, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GamificationStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

}
