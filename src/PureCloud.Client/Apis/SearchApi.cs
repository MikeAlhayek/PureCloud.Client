using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Locations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Apis;

public sealed class SearchApi : ISearchApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public SearchApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<JsonNodeSearchResponse> GetSearchAsync(string q64, IEnumerable<string> expands = null, bool? profile = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (profile.HasValue)
        {
            parameters.Add("profile", UriHelper.ParameterToString(profile.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonNodeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonNodeSearchResponse> GetSearchSuggestAsync(string q64, IEnumerable<string> expands = null, bool? profile = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (profile.HasValue)
        {
            parameters.Add("profile", UriHelper.ParameterToString(profile.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/search/suggest", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonNodeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentationSearchResponse> CreateDocumentationSearchAsync(DocumentationSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/documentation/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentationSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GKNDocumentationSearchResponse> CreateDocumentationGknSearchAsync(GKNDocumentationSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/documentation/gkn/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GKNDocumentationSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsersSearchResponse> CreateUsersSearchAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GroupsSearchResponse> CreateGroupsSearchAsync(GroupSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/groups/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GroupsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationsSearchResponse> CreateLocationsSearchAsync(LocationSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/locations/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonNodeSearchResponse> CreateSearchAsync(SearchRequest body, bool? profile = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (profile.HasValue)
        {
            parameters.Add("profile", UriHelper.ParameterToString(profile.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/search", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonNodeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonNodeSearchResponse> CreateSearchSuggestAsync(SuggestSearchRequest body, bool? profile = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (profile.HasValue)
        {
            parameters.Add("profile", UriHelper.ParameterToString(profile.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/search/suggest", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonNodeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SitesSearchResponse> CreateTelephonyProvidersEdgesSitesSearchAsync(SiteSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/telephony/providers/edges/sites/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SitesSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GKNDocumentationSearchResponse> GetDocumentationGknSearchAsync(string q64, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/documentation/gkn/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GKNDocumentationSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentationSearchResponse> GetDocumentationSearchAsync(string q64, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/documentation/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentationSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GroupsSearchResponse> GetGroupsSearchAsync(string q64, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/groups/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GroupsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/locations/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LocationsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SitesSearchResponse> GetTelephonyProvidersEdgesSitesSearchAsync(string q64, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/telephony/providers/edges/sites/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SitesSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsersSearchResponse> GetUsersSearchAsync(string q64, IEnumerable<string> expands = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            parameters.Add("integrationPresenceSource", integrationPresenceSource);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/users/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailsSearchResponse> GetVoicemailSearchAsync(string q64, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(q64);

        var parameters = new NameValueCollection { { "q64", q64 } };

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/voicemail/search", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AnalyticsConversationWithoutAttributesMultiGetResponse> CreateAnalyticsConversationsTranscriptsQueryAsync(TranscriptConversationDetailSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/conversations/transcripts/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationWithoutAttributesMultiGetResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonCursorSearchResponse> CreateConversationsParticipantsAttributesSearchAsync(ConversationParticipantSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/conversations/participants/attributes/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonCursorSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonNodeSearchResponse> CreateDocumentationAllSearchAsync(DocumentationV2SearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/documentation/all/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonNodeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonSearchResponse> CreateSpeechandtextanalyticsTranscriptsSearchAsync(TranscriptSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/transcripts/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TeamsSearchResponse> CreateTeamsSearchAsync(TeamSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/teams/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TeamsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsersSearchResponse> CreateUsersSearchConversationTargetAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users/search/conversation/target", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsersSearchResponse> CreateUsersSearchQueuemembersManageAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users/search/queuemembers/manage", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UsersSearchResponse> CreateUsersSearchTeamsAssignAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users/search/teams/assign", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailsSearchResponse> CreateVoicemailSearchAsync(VoicemailSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/voicemail/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }
}
