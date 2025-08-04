using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class VoicemailApi : IVoicemailApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public VoicemailApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<VoicemailMessage> GetVoicemailMessageAsync(string messageId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/voicemail/messages/{Uri.EscapeDataString(messageId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessage>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteVoicemailMessageAsync(string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/voicemail/messages/{Uri.EscapeDataString(messageId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<VoicemailMailboxInfo> GetVoicemailMailboxAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/voicemail/mailbox", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMailboxInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailUserPolicy> PatchVoicemailMePolicyAsync(VoicemailUserPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/voicemail/me/policy", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailUserPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailsSearchResponse> SearchVoicemailsAsync(VoicemailSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/voicemail/search", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailsSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteVoicemailMessagesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/voicemail/messages", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<VoicemailMailboxInfo> GetVoicemailGroupMailboxAsync(string groupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/voicemail/groups/{Uri.EscapeDataString(groupId)}/mailbox");

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMailboxInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessageEntityListing> GetVoicemailGroupMessagesAsync(string groupId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

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

        var uri = UriHelper.GetUri($"api/v2/voicemail/groups/{Uri.EscapeDataString(groupId)}/messages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessageEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailGroupPolicy> GetVoicemailGroupPolicyAsync(string groupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/voicemail/groups/{Uri.EscapeDataString(groupId)}/policy");

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailGroupPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMailboxInfo> GetVoicemailMeMailboxAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/voicemail/me/mailbox", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMailboxInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessageEntityListing> GetVoicemailMeMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/voicemail/me/messages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessageEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailUserPolicy> GetVoicemailMePolicyAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/voicemail/me/policy", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailUserPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMediaInfo> GetVoicemailMessageMediaAsync(string messageId, string formatId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(formatId))
        {
            parameters.Add("formatId", UriHelper.ParameterToString(formatId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/voicemail/messages/{Uri.EscapeDataString(messageId)}/media", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMediaInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessageEntityListing> GetVoicemailMessagesAsync(string ids = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(ids))
        {
            parameters.Add("ids", UriHelper.ParameterToString(ids));
        }

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/voicemail/messages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessageEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailOrganizationPolicy> GetVoicemailPolicyAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/voicemail/policy", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailOrganizationPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessageEntityListing> GetVoicemailQueueMessagesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queueId);

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

        var uri = UriHelper.GetUri($"api/v2/voicemail/queues/{Uri.EscapeDataString(queueId)}/messages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessageEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailsSearchResponse> GetVoicemailSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection();
        parameters.Add("q64", UriHelper.ParameterToString(q64));

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/voicemail/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailsSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMailboxInfo> GetVoicemailUserMailboxAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/voicemail/users/{Uri.EscapeDataString(userId)}/mailbox");

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMailboxInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessageEntityListing> GetVoicemailUserMessagesAsync(string userId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

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

        var uri = UriHelper.GetUri($"api/v2/voicemail/users/{Uri.EscapeDataString(userId)}/messages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessageEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailUserPolicy> GetVoicemailUserPolicyAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/voicemail/users/{Uri.EscapeDataString(userId)}/policy");

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailUserPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailGroupPolicy> PatchVoicemailGroupPolicyAsync(string groupId, VoicemailGroupPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/voicemail/groups/{Uri.EscapeDataString(groupId)}/policy", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailGroupPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessage> PatchVoicemailMessageAsync(string messageId, VoicemailMessage body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/voicemail/messages/{Uri.EscapeDataString(messageId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessage>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailUserPolicy> PatchVoicemailUserPolicyAsync(string userId, VoicemailUserPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/voicemail/users/{Uri.EscapeDataString(userId)}/policy", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailUserPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessage> CreateVoicemailMessageAsync(CopyVoicemailMessage body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/voicemail/messages", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessage>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailMessage> UpdateVoicemailMessageAsync(string messageId, VoicemailMessage body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/voicemail/messages/{Uri.EscapeDataString(messageId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessage>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailOrganizationPolicy> UpdateVoicemailPolicyAsync(VoicemailOrganizationPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/voicemail/policy", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailOrganizationPolicy>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailUserPolicy> UpdateVoicemailUserPolicyAsync(string userId, VoicemailUserPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/voicemail/users/{Uri.EscapeDataString(userId)}/policy", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailUserPolicy>(_options, cancellationToken);
    }
}
