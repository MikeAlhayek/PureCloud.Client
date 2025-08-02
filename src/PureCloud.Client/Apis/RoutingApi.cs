using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;

namespace PureCloud.Client.Apis;

public sealed class RoutingApi : IRoutingApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public RoutingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assessmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/assessments/{assessmentId}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assessmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/assessments/{assessmentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BenefitAssessment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/domains/{domainId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/routing/assessments", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BenefitAssessment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/routing/directroutingbackup/settings/me", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);

        ArgumentException.ThrowIfNullOrEmpty(routeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/email/outbound/domains/{Uri.EscapeDataString(domainId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(languageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/languages/{Uri.EscapeDataString(languageId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var parameters = new NameValueCollection();

        if (forceDelete.HasValue)
        {
            parameters.Add("forceDelete", UriHelper.ParameterToString(forceDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/skills/{Uri.EscapeDataString(skillId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);

        ArgumentException.ThrowIfNullOrEmpty(routeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/email/domains", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);

        ArgumentException.ThrowIfNullOrEmpty(routeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingQueueMemberAsync(string queueId, string memberId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        ArgumentException.ThrowIfNullOrEmpty(memberId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}/members/{Uri.EscapeDataString(memberId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingQueueUserAsync(string queueId, string memberId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        ArgumentException.ThrowIfNullOrEmpty(memberId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}/users/{Uri.EscapeDataString(memberId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingQueueWrapupcodeAsync(string queueId, string codeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        ArgumentException.ThrowIfNullOrEmpty(codeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}/wrapupcodes/{Uri.EscapeDataString(codeId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(predictorId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/predictors/{Uri.EscapeDataString(predictorId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/routing/settings", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/skillgroups/{Uri.EscapeDataString(skillGroupId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(addressId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/sms/addresses/{Uri.EscapeDataString(addressId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingSmsPhonenumberAsync(string phoneNumberId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneNumberId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/sms/phonenumbers/{Uri.EscapeDataString(phoneNumberId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/directroutingbackup/settings", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/utilization", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUtilizationAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/routing/utilization", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(labelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/utilization/labels/{Uri.EscapeDataString(labelId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tagId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/utilization/tags/{Uri.EscapeDataString(tagId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(codeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/wrapupcodes/{Uri.EscapeDataString(codeId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(languageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{Uri.EscapeDataString(userId)}/routinglanguages/{Uri.EscapeDataString(languageId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(skillId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{Uri.EscapeDataString(userId)}/routingskills/{Uri.EscapeDataString(skillId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<AssessmentListing> GetRoutingAssessmentsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(limit))
        {
            parameters.Add("limit", limit);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", pageSize);
        }

        if (queueIds != null)
        {
            foreach (var queueId in queueIds)
            {
                parameters.Add("queueId", queueId);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/routing/assessments", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssessmentListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BenefitAssessmentJob> GetRoutingAssessmentsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/assessments/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BenefitAssessmentJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(string divisionId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", divisionId);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/routing/assessments/jobs", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssessmentJobListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AvailableMediaTypeEntityListing> GetRoutingAvailablemediatypesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/availablemediatypes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AvailableMediaTypeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AgentDirectRoutingBackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/directroutingbackup/settings/me", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/email/domains", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRouteEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/routing/languages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LanguageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(languageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/languages/{Uri.EscapeDataString(languageId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Language>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, bool? active = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (active.HasValue)
        {
            parameters.Add("active", active.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", divisionId);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/routing/queues", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Queue>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Queue> CreateRoutingQueueAsync(QueueRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/queues", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Queue>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Queue>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/languages", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Language>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/skills", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingSkill>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCodeRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/wrapupcodes", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapupCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RoutingSkill> GetRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/skills/{Uri.EscapeDataString(skillId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingSkill>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WrapupCode> GetRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(codeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/wrapupcodes/{Uri.EscapeDataString(codeId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapupCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/utilization", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationLabel> GetRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(labelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/utilization/labels/{Uri.EscapeDataString(labelId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationLabel>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationTag> GetRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tagId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/utilization/tags/{Uri.EscapeDataString(tagId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationTag>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/directroutingbackup/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/utilization", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentMaxUtilizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRoute> GetRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);
        ArgumentException.ThrowIfNullOrEmpty(routeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}/identityresolution", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomain> GetRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/outbound/domains/{Uri.EscapeDataString(domainId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmailSetup> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/email/setup", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailSetup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmailOutboundDomainResult> GetRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/outbound/domains/{Uri.EscapeDataString(domainId)}/activation", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailOutboundDomainResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutboundDomain> GetRoutingEmailOutboundDomainSearchAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/outbound/domains/{Uri.EscapeDataString(domainId)}/search", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/routing/directroutingbackup/settings/me", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmailOutboundDomainResult> UpdateRoutingEmailOutboundDomainActivationAsync(string domainId, object body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/email/outbound/domains/{Uri.EscapeDataString(domainId)}/activation", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailOutboundDomainResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TestMessage> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainId)}/testconnection", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TestMessage>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomain> CreateRoutingEmailOutboundDomainAsync(InboundDomain body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/email/outbound/domains", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, string name = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(messengerType))
        {
            parameters.Add("messengerType", messengerType);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var uri = UriHelper.GetUri("api/v2/routing/message/recipients", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecipientListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Recipient> GetRoutingMessageRecipientAsync(string recipientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(recipientId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/message/recipients/{Uri.EscapeDataString(recipientId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Recipient>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, int? limit = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (limit.HasValue)
        {
            parameters.Add("limit", limit.Value.ToString());
        }

        if (queueIds != null)
        {
            foreach (var queueId in queueIds)
            {
                parameters.Add("queueId", queueId);
            }
        }

        var uri = UriHelper.GetUri("api/v2/routing/predictors", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PredictorListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Predictor> GetRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(predictorId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/predictors/{Uri.EscapeDataString(predictorId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Predictor>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PredictorModelListing> GetRoutingPredictorModelsAsync(string predictorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(predictorId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/predictors/{Uri.EscapeDataString(predictorId)}/models", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PredictorModelListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PredictorModelFeatureListing> GetRoutingPredictorModelFeaturesAsync(string predictorId, string modelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(predictorId);
        ArgumentException.ThrowIfNullOrEmpty(modelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/predictors/{Uri.EscapeDataString(predictorId)}/models/{Uri.EscapeDataString(modelId)}/features", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PredictorModelFeatureListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KeyPerformanceIndicatorListing> GetRoutingPredictorsKeyperformanceindicatorsAsync(IEnumerable<string> kpiIds = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (kpiIds != null)
        {
            foreach (var kpiId in kpiIds)
            {
                parameters.Add("kpiId", kpiId);
            }
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri("api/v2/routing/predictors/keyperformanceindicators", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KeyPerformanceIndicatorListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? hasMember = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", id);
            }
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", divisionId);
            }
        }

        if (hasMember.HasValue)
        {
            parameters.Add("hasMember", hasMember.Value.ToString().ToLower());
        }

        var uri = UriHelper.GetUri("api/v2/routing/queues", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (joined.HasValue)
        {
            parameters.Add("joined", joined.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (profileSkills != null)
        {
            foreach (var profileSkill in profileSkills)
            {
                parameters.Add("profileSkills", profileSkill);
            }
        }

        if (skills != null)
        {
            foreach (var skill in skills)
            {
                parameters.Add("skills", skill);
            }
        }

        if (languages != null)
        {
            foreach (var language in languages)
            {
                parameters.Add("languages", language);
            }
        }

        if (routingStatus != null)
        {
            foreach (var status in routingStatus)
            {
                parameters.Add("routingStatus", status);
            }
        }

        if (presence != null)
        {
            foreach (var presenceValue in presence)
            {
                parameters.Add("presence", presenceValue);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}/members", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueMemberEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueueMemberEntityListingV1> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (joined.HasValue)
        {
            parameters.Add("joined", joined.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (profileSkills != null)
        {
            foreach (var profileSkill in profileSkills)
            {
                parameters.Add("profileSkills", profileSkill);
            }
        }

        if (skills != null)
        {
            foreach (var skill in skills)
            {
                parameters.Add("skills", skill);
            }
        }

        if (languages != null)
        {
            foreach (var language in languages)
            {
                parameters.Add("languages", language);
            }
        }

        if (routingStatus != null)
        {
            foreach (var status in routingStatus)
            {
                parameters.Add("routingStatus", status);
            }
        }

        if (presence != null)
        {
            foreach (var presenceValue in presence)
            {
                parameters.Add("presence", presenceValue);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}/users", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueMemberEntityListingV1>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WrapupCodeEntityListing> GetRoutingQueueWrapupcodesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var uri = UriHelper.GetUri($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}/wrapupcodes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapupCodeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsAddressEntityListing> GetRoutingSmsAddressesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var uri = UriHelper.GetUri("api/v2/routing/sms/addresses", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsAddressEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(countryCode);
        ArgumentException.ThrowIfNullOrEmpty(phoneNumberType);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        parameters.Add("countryCode", countryCode);
        parameters.Add("phoneNumberType", phoneNumberType);

        if (!string.IsNullOrEmpty(region))
        {
            parameters.Add("region", region);
        }

        if (!string.IsNullOrEmpty(city))
        {
            parameters.Add("city", city);
        }

        if (!string.IsNullOrEmpty(areaCode))
        {
            parameters.Add("areaCode", areaCode);
        }

        if (!string.IsNullOrEmpty(pattern))
        {
            parameters.Add("pattern", pattern);
        }

        if (!string.IsNullOrEmpty(addressRequirement))
        {
            parameters.Add("addressRequirement", addressRequirement);
        }

        var uri = UriHelper.GetUri("api/v2/routing/sms/availablephonenumbers", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsAvailablePhoneNumberEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(phoneNumber))
        {
            parameters.Add("phoneNumber", phoneNumber);
        }

        if (!string.IsNullOrEmpty(phoneNumberType))
        {
            parameters.Add("phoneNumberType", phoneNumberType);
        }

        if (!string.IsNullOrEmpty(phoneNumberStatus))
        {
            parameters.Add("phoneNumberStatus", phoneNumberStatus);
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(language))
        {
            parameters.Add("language", language);
        }

        var uri = UriHelper.GetUri("api/v2/routing/sms/phonenumbers", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsPhoneNumberEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        var uri = UriHelper.GetUri("api/v2/routing/skillgroups", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillGroupEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, string after = null, string before = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/routing/skillgroups/{Uri.EscapeDataString(skillGroupId)}/members", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillGroupMemberEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/utilization", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ContactCenterSettings> GetRoutingSettingsContactcenterAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/settings/contactcenter", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactCenterSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TranscriptionSettings> GetRoutingSettingsTranscriptionAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/routing/settings/transcription", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TranscriptionSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillEntityListing> GetRoutingSkillsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", id);
            }
        }

        var uri = UriHelper.GetUri("api/v2/routing/skills", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", id);
            }
        }

        var uri = UriHelper.GetUri("api/v2/routing/languages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LanguageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(languageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/languages/{Uri.EscapeDataString(languageId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Language>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/languages", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Language>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/skills", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingSkill>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillGroup> CreateRoutingSkillgroupAsync(SkillGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/skillgroups", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCode body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/wrapupcodes", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapupCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Queue> CreateRoutingQueueAsync(QueueRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/queues", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Queue>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Queue>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/skillgroups/{Uri.EscapeDataString(skillGroupId)}", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(codeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/wrapupcodes/{Uri.EscapeDataString(codeId)}", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapupCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/routing/utilization", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserUtilization> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/utilization", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserUtilization>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserUtilization> UpdateRoutingUserUtilizationAsync(string userId, UserUtilization body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/utilization", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserUtilization>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/directroutingbackup/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/directroutingbackup/settings", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomain> ValidateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainId)}/validate", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (forceDelete.HasValue)
        {
            parameters.Add("forceDelete", forceDelete.Value.ToString().ToLower());
        }

        var uri = UriHelper.GetUri($"api/v2/routing/queues/{Uri.EscapeDataString(queueId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/routing/settings", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUtilizationAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/routing/utilization", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/users/{Uri.EscapeDataString(userId)}/utilization", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<InboundDomain> UpdateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainId)}", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);
        ArgumentException.ThrowIfNullOrEmpty(routeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);
        ArgumentException.ThrowIfNullOrEmpty(routeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRoute>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, int? pageSize = null, int? pageNumber = null, string pattern = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(pattern))
        {
            parameters.Add("pattern", pattern);
        }

        var uri = UriHelper.GetUri($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundRouteEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(int? pageSize = null, int? pageNumber = null, bool? excludeStatus = null, string filter = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (excludeStatus.HasValue)
        {
            parameters.Add("excludeStatus", excludeStatus.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", filter);
        }

        var uri = UriHelper.GetUri("api/v2/routing/email/domains", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/email/domains", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InboundDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainName);
        ArgumentException.ThrowIfNullOrEmpty(routeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/email/domains/{Uri.EscapeDataString(domainName)}/routes/{Uri.EscapeDataString(routeId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddressProvision body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/sms/addresses", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsAddress>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsPhoneNumber> CreateRoutingSmsPhoneNumberAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/routing/sms/phonenumbers", body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsPhoneNumber>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(int? pageSize = null, int? pageNumber = null, string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", filter);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/email/outbound/domains", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", id);
            }
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", divisionId);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/queues/divisionviews", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAllAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/queues/divisionviews/all", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (joined.HasValue)
        {
            parameters.Add("joined", joined.Value.ToString().ToLower());
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", divisionId);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/queues/me", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserQueueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillGroup> GetRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/skillgroups/{skillGroupId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SkillGroupMemberDivisions> GetRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(skillGroupId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri($"api/v2/routing/skillgroups/{skillGroupId}/members/divisions", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SkillGroupMemberDivisions>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsAddress> GetRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(addressId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/sms/addresses/{addressId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsAddress>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsPhoneNumber> GetRoutingSmsPhoneNumberAsync(string phoneNumberId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneNumberId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/routing/sms/phonenumbers/{phoneNumberId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsPhoneNumber>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, IEnumerable<string> phoneNumberTypes = null, IEnumerable<string> phoneNumberStatuses = null, IEnumerable<string> countryCodes = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(phoneNumber))
        {
            parameters.Add("phoneNumber", phoneNumber);
        }

        if (phoneNumberTypes != null)
        {
            foreach (var phoneNumberType in phoneNumberTypes)
            {
                parameters.Add("phoneNumberType", phoneNumberType);
            }
        }

        if (phoneNumberStatuses != null)
        {
            foreach (var phoneNumberStatus in phoneNumberStatuses)
            {
                parameters.Add("phoneNumberStatus", phoneNumberStatus);
            }
        }

        if (countryCodes != null)
        {
            foreach (var countryCode in countryCodes)
            {
                parameters.Add("countryCode", countryCode);
            }
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(language))
        {
            parameters.Add("language", language);
        }

        if (!string.IsNullOrEmpty(integrationId))
        {
            parameters.Add("integrationId", integrationId);
        }

        if (!string.IsNullOrEmpty(supportedContentId))
        {
            parameters.Add("supportedContentId", supportedContentId);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/sms/phonenumbers", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SmsPhoneNumberEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationLabelEntityListing> GetRoutingUtilizationLabelsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/utilization/labels", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationLabelEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UtilizationTagEntityListing> GetRoutingUtilizationTagsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/routing/utilization/tags", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UtilizationTagEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }
}
