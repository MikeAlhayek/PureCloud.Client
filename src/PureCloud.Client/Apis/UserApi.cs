using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Apis;

public class UserApi : IUserApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public UserApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    // get methods
    public async Task<User> GetUserAsync(string userId, UserSearchContext context = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/users/{userId}";

        if (context is not null)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();

            if (context.Expands is not null && context.Expands.Count > 0)
            {
                foreach (var expand in context.Expands)
                {
                    queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
                }

                if (!string.IsNullOrEmpty(context.IntegrationPresenceSource))
                {
                    queryParameters.Add(new KeyValuePair<string, string>("integrationPresenceSource", UriHelper.ParameterToString(context.IntegrationPresenceSource)));
                }

                if (!string.IsNullOrEmpty(context.State))
                {
                    queryParameters.Add(new KeyValuePair<string, string>("state", UriHelper.ParameterToString(context.State)));
                }

                uri = QueryHelpers.AddQueryString(uri, queryParameters);
            }
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> GetCurrentUserAsync(IEnumerable<string> expands = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (expands is not null)
        {
            foreach (var expand in expands)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            queryParameters.Add(new KeyValuePair<string, string>("integrationPresenceSource", UriHelper.ParameterToString(integrationPresenceSource)));
        }

        var uri = QueryHelpers.AddQueryString("api/v2/users/me", queryParameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsUsersAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/analytics/users/aggregates/jobs/{jobId}";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAsyncAggregateQueryResponse> GetAnalyticsUsersAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/analytics/users/aggregates/jobs/{jobId}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            var queryParameters = new List<KeyValuePair<string, string>>
            {
            new("cursor", cursor)
            };

            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsUserDetailsAsyncQueryResponse> GetAnalyticsUsersDetailsJobResultsAsync(string jobId, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/analytics/users/details/jobs/{jobId}/results";

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (!string.IsNullOrEmpty(cursor))
        {
            queryParameters.Add(new("cursor", cursor));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (queryParameters.Count > 0)
        {
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsUserDetailsAsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataAvailabilityResponse> GetAnalyticsUsersDetailsJobsAvailabilityAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/analytics/users/details/jobs/availability";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataAvailabilityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<List<AuthzDivision>> GetAuthorizationDivisionspermittedMeAsync(string permission, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/authorization/divisionspermitted/me";

        var queryParameters = new List<KeyValuePair<string, string>> {

        new("permission", permission)

        };

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new("name", name));
        }

        uri = QueryHelpers.AddQueryString(uri, queryParameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<AuthzDivision>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedMeAsync(string permission, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/authorization/divisionspermitted/paged/me";

        var queryParameters = new List<KeyValuePair<string, string>>
        { new("permission", permission) };

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", pageSize.Value.ToString()));
        }

        uri = QueryHelpers.AddQueryString(uri, queryParameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DivsPermittedEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedSubjectIdAsync(string subjectId, string permission, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }
        if (string.IsNullOrEmpty(permission))
        {
            throw new ArgumentException("permission is required", nameof(permission));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/authorization/divisionspermitted/paged/{subjectId}";

        var queryParameters = new List<KeyValuePair<string, string>>
    {
        new("permission", permission)
    };

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", pageNumber.Value.ToString()));
        }
        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (queryParameters.Count > 0)
        {
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DivsPermittedEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzSubject> GetAuthorizationSubjectAsync(string subjectId, bool? includeDuplicates = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/authorization/subjects/{subjectId}";

        var queryParameters = new List<KeyValuePair<string, string>>();
        if (includeDuplicates.HasValue)
        {
            queryParameters.Add(new("includeDuplicates", includeDuplicates.Value.ToString().ToLowerInvariant()));
        }

        if (queryParameters.Count > 0)
        {
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzSubject>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzSubject> GetAuthorizationSubjectsMeAsync(bool? includeDuplicates = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/authorization/subjects/me";

        var queryParameters = new List<KeyValuePair<string, string>>();
        if (includeDuplicates.HasValue)
        {
            queryParameters.Add(new("includeDuplicates", includeDuplicates.Value.ToString().ToLowerInvariant()));
        }

        if (queryParameters.Count > 0)
        {
            uri = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzSubject>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FieldConfig> GetFieldconfigAsync(string type, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(type))
        {
            throw new ArgumentException("type is required", nameof(type));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/fieldconfig";

        var queryParameters = new List<KeyValuePair<string, string>>
        {
        new("type", type)
        };

        uri = QueryHelpers.AddQueryString(uri, queryParameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FieldConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserProfileEntityListing> GetProfilesUsersAsync(
        int? pageSize = null,
        int? pageNumber = null,
        List<string> id = null,
        List<string> jid = null,
        string sortOrder = null,
        List<string> expand = null,
        string integrationPresenceSource = null,
        CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/profiles/users";
        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", pageSize.Value.ToString()));
        }
        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", pageNumber.Value.ToString()));
        }
        if (id is not null)
        {
            foreach (var value in id)
            {
                queryParameters.Add(new("id", value));
            }
        }
        if (jid is not null)
        {
            foreach (var value in jid)
            {
                queryParameters.Add(new("jid", value));
            }
        }
        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", sortOrder));
        }
        if (expand is not null)
        {
            foreach (var value in expand)
            {
                queryParameters.Add(new("expand", value));
            }
        }
        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            queryParameters.Add(new("integrationPresenceSource", integrationPresenceSource));
        }

        if (queryParameters.Count > 0)
        {
            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserProfileEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentDirectRoutingBackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/routing/directroutingbackup/settings/me";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/routing/users/{userId}/directroutingbackup/settings";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/routing/users/{userId}/utilization";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentMaxUtilizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> GetUserAsync(string userId, List<string> expand = null, string integrationPresenceSource = null,
        string state = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }
        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            query.Add(new("integrationPresenceSource", integrationPresenceSource));
        }
        if (!string.IsNullOrEmpty(state))
        {
            query.Add(new("state", state));
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Adjacents> GetUserAdjacentsAsync(string userId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/adjacents", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Adjacents>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallForwarding> GetUserCallforwardingAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/callforwarding";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallForwarding>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<List<User>> GetUserDirectreportsAsync(string userId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/directreports", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<User>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<List<UserExternalIdentifier>> GetUserExternalidAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/externalid";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<UserExternalIdentifier>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserExternalIdentifier> GetUserExternalidAuthorityNameAsync(string userId, string authorityName, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(authorityName))
        {
            throw new ArgumentException("authorityName is required", nameof(authorityName));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/externalid/{authorityName}";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserExternalIdentifier>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserEntityListing> GetUserFavoritesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            query.Add(new("sortOrder", sortOrder));
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/favorites", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Geolocation> GetUserGeolocationAsync(string userId, string clientId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(clientId))
        {
            throw new ArgumentException("clientId is required", nameof(clientId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/geolocations/{clientId}";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Geolocation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OutOfOffice> GetUserOutofofficeAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/outofoffice";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutOfOffice>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserProfile> GetUserProfileAsync(string userId, List<string> expand = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();

        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            query.Add(new("integrationPresenceSource", integrationPresenceSource));
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/profile", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<List<string>> GetUserProfileskillsAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/profileskills";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<string>>(_options.JsonSerializerOptions, cancellationToken);
    }

    //public async Task<UserQueueEntityListing> GetUserQueuesAsync(string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, List<string> divisionId = null, CancellationToken cancellationToken = default)
    //{
    //    if (string.IsNullOrWhiteSpace(userId))
    //    {
    //        throw new ArgumentException("userId is required", nameof(userId));
    //    }

    //    var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

    //    var query = new List<KeyValuePair<string, string>>();
    //    if (pageSize.HasValue)
    //    {
    //        query.Add(new("pageSize", pageSize.Value.ToString()));
    //    }

    //    if (pageNumber.HasValue)
    //    {
    //        query.Add(new("pageNumber", pageNumber.Value.ToString()));
    //    }

    //    if (joined.HasValue)
    //    {
    //        query.Add(new("joined", joined.Value.ToString().ToLowerInvariant()));
    //    }

    //    if (divisionId != null)
    //    {
    //        foreach (var id in divisionId)
    //        {
    //            query.Add(new("divisionId", id));
    //        }
    //    }

    //    var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/queues", query);

    //    var response = await client.GetAsync(uri, cancellationToken);

    //    response.EnsureSuccessStatusCode();

    //    return await response.Content.ReadFromJsonAsync<UserQueueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    //}

    public async Task<UserAuthorization> GetUserRolesAsync(string subjectId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{subjectId}/roles";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();

        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            query.Add(new("sortOrder", sortOrder));
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/routinglanguages", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserLanguageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            query.Add(new("sortOrder", sortOrder));
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/routingskills", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserSkillEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoutingStatus> GetUserRoutingstatusAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/routingstatus";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (!string.IsNullOrEmpty(after))
        {
            query.Add(new("after", after));
        }

        if (!string.IsNullOrEmpty(before))
        {
            query.Add(new("before", before));
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/skillgroups", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserSkillGroupEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserState> GetUserStateAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/state";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserState>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserStations> GetUserStationAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/station";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserStations>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<List<User>> GetUserSuperiorsAsync(string userId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (expand != null)
        {
            foreach (var UserId in expand)
            {
                query.Add(new("expand", UserId));
            }
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/superiors", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<User>>(_options.JsonSerializerOptions, cancellationToken);
    }
    public async Task<TrustorEntityListing> GetUserTrustorsAsync(string userId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/{userId}/trustors", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustorEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<VerifierEntityListing> GetUserVerifiersAsync(string userId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/verifiers";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VerifierEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserEntityListing> GetUsersAsync(
    int? pageSize = null,
    int? pageNumber = null,
    List<string> id = null,
    List<string> jabberId = null,
    string sortOrder = null,
    List<string> expand = null,
    string integrationPresenceSource = null,
    string state = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();

        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        if (id != null)
        {
            foreach (var i in id)
            {
                query.Add(new("id", i));
            }
        }

        if (jabberId != null)
        {
            foreach (var j in jabberId)
            {
                query.Add(new("jabberId", j));
            }
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            query.Add(new("sortOrder", sortOrder));
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            query.Add(new("integrationPresenceSource", integrationPresenceSource));
        }

        if (!string.IsNullOrEmpty(state))
        {
            query.Add(new("state", state));
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/users", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatItemCursorListing> GetUsersChatsMeAsync(bool? excludeClosed = null, bool? includePresence = null, string after = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (excludeClosed.HasValue)
        {
            query.Add(new("excludeClosed", excludeClosed.Value.ToString().ToLowerInvariant()));
        }

        if (includePresence.HasValue)
        {
            query.Add(new("includePresence", includePresence.Value.ToString().ToLowerInvariant()));
        }

        if (!string.IsNullOrEmpty(after))
        {
            query.Add(new("after", after));
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/users/chats/me", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatItemCursorListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesAsync(
    List<string> userId = null,
    string moduleId = null,
    string interval = null,
    string completionInterval = null,
    string overdue = null,
    string pass = null,
    int? pageSize = null,
    int? pageNumber = null,
    string sortOrder = null,
    List<string> types = null,
    List<string> statuses = null,
    List<string> relationship = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (userId != null)
        {
            foreach (var u in userId)
            {
                query.Add(new("userId", u));
            }
        }

        if (!string.IsNullOrEmpty(moduleId))
        {
            query.Add(new("moduleId", moduleId));
        }

        if (!string.IsNullOrEmpty(interval))
        {
            query.Add(new("interval", interval));
        }

        if (!string.IsNullOrEmpty(completionInterval))
        {
            query.Add(new("completionInterval", completionInterval));
        }

        if (!string.IsNullOrEmpty(overdue))
        {
            query.Add(new("overdue", overdue));
        }

        if (!string.IsNullOrEmpty(pass))
        {
            query.Add(new("pass", pass));
        }

        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            query.Add(new("sortOrder", sortOrder));
        }

        if (types != null)
        {
            foreach (var t in types)
            {
                query.Add(new("types", t));
            }
        }

        if (statuses != null)
        {
            foreach (var s in statuses)
            {
                query.Add(new("statuses", s));
            }
        }

        if (relationship != null)
        {
            foreach (var r in relationship)
            {
                query.Add(new("relationship", r));
            }
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/users/development/activities", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DevelopmentActivityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesMeAsync(
    string moduleId = null,
    string interval = null,
    string completionInterval = null,
    string overdue = null,
    string pass = null,
    int? pageSize = null,
    int? pageNumber = null,
    string sortOrder = null,
    List<string> types = null,
    List<string> statuses = null,
    List<string> relationship = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (!string.IsNullOrEmpty(moduleId))
        {
            query.Add(new("moduleId", moduleId));
        }
        if (!string.IsNullOrEmpty(interval))
        {
            query.Add(new("interval", interval));
        }
        if (!string.IsNullOrEmpty(completionInterval))
        {
            query.Add(new("completionInterval", completionInterval));
        }
        if (!string.IsNullOrEmpty(overdue))
        {
            query.Add(new("overdue", overdue));
        }
        if (!string.IsNullOrEmpty(pass))
        {
            query.Add(new("pass", pass));
        }
        if (pageSize.HasValue)
        {
            query.Add(new("pageSize", pageSize.Value.ToString()));
        }
        if (pageNumber.HasValue)
        {
            query.Add(new("pageNumber", pageNumber.Value.ToString()));
        }
        if (!string.IsNullOrEmpty(sortOrder))
        {
            query.Add(new("sortOrder", sortOrder));
        }
        if (types != null)
        {
            foreach (var t in types)
            {
                query.Add(new("types", t));
            }
        }
        if (statuses != null)
        {
            foreach (var s in statuses)
            {
                query.Add(new("statuses", s));
            }
        }
        if (relationship != null)
        {
            foreach (var r in relationship)
            {
                query.Add(new("relationship", r));
            }
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/users/development/activities/me", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DevelopmentActivityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DevelopmentActivity> GetUsersDevelopmentActivityAsync(string activityId, string type, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(activityId))
        {
            throw new ArgumentException("activityId is required", nameof(activityId));
        }

        if (string.IsNullOrWhiteSpace(type))
        {
            throw new ArgumentException("type is required", nameof(type));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>
        {
        new("type", type)
        };

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/development/activities/{activityId}", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DevelopmentActivity>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> GetUsersExternalidAuthorityNameExternalKeyAsync(string authorityName, string externalKey, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(authorityName))
        {
            throw new ArgumentException("authorityName is required", nameof(authorityName));
        }

        if (string.IsNullOrWhiteSpace(externalKey))
        {
            throw new ArgumentException("externalKey is required", nameof(externalKey));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();

        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        var uri = QueryHelpers.AddQueryString($"/api/v2/users/externalid/{authorityName}/{externalKey}", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserMe> GetUsersMeAsync(List<string> expand = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>();
        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            query.Add(new("integrationPresenceSource", integrationPresenceSource));
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/users/me", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserMe>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UsersSearchResponse> GetUsersSearchAsync(string q64, List<string> expand = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(q64))
        {
            throw new ArgumentException("q64 is required", nameof(q64));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<KeyValuePair<string, string>>
        {
        new("q64", q64)
        };

        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add(new("expand", e));
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            query.Add(new("integrationPresenceSource", integrationPresenceSource));
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/users/search", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> PatchUserAsync(string userId, UpdateUser body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}";

        var request = new HttpRequestMessage(HttpMethod.Patch, uri)
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallForwarding> UpdateUserCallforwardingAsync(string userId, CallForwarding body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/callforwarding";

        var request = new HttpRequestMessage(HttpMethod.Patch, uri)
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallForwarding>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Geolocation> UpdateUserGeolocationAsync(string userId, string clientId, Geolocation body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(clientId))
        {
            throw new ArgumentException("clientId is required", nameof(clientId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/geolocations/{clientId}";

        var request = new HttpRequestMessage(HttpMethod.Patch, uri)
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Geolocation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserQueue> UpdateUserQueueAsync(string queueId, string userId, UserQueue body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(queueId))
        {
            throw new ArgumentException("queueId is required", nameof(queueId));
        }

        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/queues/{queueId}";

        var request = new HttpRequestMessage(HttpMethod.Patch, uri)
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserQueue>(_options.JsonSerializerOptions, cancellationToken);
    }

    // get methods

    // update methods
    public async Task<User> UpdateUpdateAsync(string userId, UpdateUser user, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/users/{userId}", user, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserRoutingLanguage> PatchUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(languageId))
        {
            throw new ArgumentException("languageId is required", nameof(languageId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/routinglanguages/{languageId}";

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRoutingLanguage>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserLanguageEntityListing> UpdateUserRoutinglanguagesBulkAsync(string userId, List<UserRoutingLanguagePost> body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/routinglanguages/bulk";

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserLanguageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserSkillEntityListing> PatchUserRoutingskillsBulkAsync(string userId, List<UserRoutingSkillPost> body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{userId}/routingskills/bulk";

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserSkillEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserEntityListing> UpdateUsersBulkAsync(List<PatchUser> body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/bulk";

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // Update methods

    // post methods
    public async Task<User> CreateUserAsync(CreateUser user, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users", user, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SearchResult<User>> SearchUsersAsync(UserSearchRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users/search", request, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SearchResult<User>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserActivityResponse> CreateAnalyticsUsersActivityQueryAsync(UserActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageSize.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", pageSize.Value.ToString()));
        }

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageNumber", pageNumber.Value.ToString()));
        }

        var uri = QueryHelpers.AddQueryString("/api/v2/analytics/users/activity/query", queryParameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserActivityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsUsersAggregatesJobsAsync(UserAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/analytics/users/aggregates/jobs";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAggregateQueryResponse> CreateAnalyticsUsersAggregatesQueryAsync(UserAggregationQuery body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/analytics/users/aggregates/query";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsUsersDetailsJobsAsync(AsyncUserDetailsQuery body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/analytics/users/details/jobs";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsUserDetailsQueryResponse> CreateAnalyticsUsersDetailsQueryAsync(UserDetailsQuery body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/analytics/users/details/query";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsUserDetailsQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserObservationQueryResponse> CreateAnalyticsUsersObservationsQueryAsync(UserObservationQuery body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/analytics/users/observations/query";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserObservationQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task CreateAuthorizationSubjectBulkaddAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/authorization/subjects/{Uri.EscapeDataString(subjectId)}/bulkadd";

        if (!string.IsNullOrEmpty(subjectType))
        {
            var queryParameters = new Dictionary<string, string>
        {
            { "subjectType", subjectType }
        };

            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task CreateAuthorizationSubjectBulkremoveAsync(string subjectId, RoleDivisionGrants body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/authorization/subjects/{Uri.EscapeDataString(subjectId)}/bulkremove";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task CreateAuthorizationSubjectBulkreplaceAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/authorization/subjects/{Uri.EscapeDataString(subjectId)}/bulkreplace";

        if (!string.IsNullOrEmpty(subjectType))
        {
            var queryParameters = new Dictionary<string, string>
        {
            { "subjectType", subjectType }
        };

            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task CreateAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, string subjectType = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(subjectId))
        {
            throw new ArgumentException("subjectId is required", nameof(subjectId));
        }

        if (string.IsNullOrWhiteSpace(divisionId))
        {
            throw new ArgumentException("divisionId is required", nameof(divisionId));
        }

        if (string.IsNullOrWhiteSpace(roleId))
        {
            throw new ArgumentException("roleId is required", nameof(roleId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/authorization/subjects/{Uri.EscapeDataString(subjectId)}/divisions/{Uri.EscapeDataString(divisionId)}/roles/{Uri.EscapeDataString(roleId)}";

        if (!string.IsNullOrEmpty(subjectType))
        {
            var queryParameters = new Dictionary<string, string>
        {
            { "subjectType", subjectType }
        };

            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<UserExternalIdentifier>> PostUserExternalidAsync(string userId, UserExternalIdentifier body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/externalid";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<UserExternalIdentifier>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task CreateUserInviteAsync(string userId, bool? force = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/invite";

        if (force.HasValue)
        {
            var queryParameters = new Dictionary<string, string>
        {
            { "force", force.Value.ToString().ToLowerInvariant() }
        };

            uri = QueryHelpers.AddQueryString(uri, queryParameters);
        }

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task CreateUserPasswordAsync(string userId, ChangePasswordRequest body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/password";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<UserRoutingLanguage> CreateUserRoutinglanguagesAsync(string userId, UserRoutingLanguagePost body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/routinglanguages";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRoutingLanguage>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserRoutingSkill> CreateUserRoutingskillsAsync(string userId, UserRoutingSkillPost body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/routingskills";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRoutingSkill>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> PostUsersAsync(CreateUser body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DevelopmentActivityAggregateResponse> CreateUsersDevelopmentActivitiesAggregatesQueryAsync(DevelopmentActivityAggregateParam body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/development/activities/aggregates/query";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DevelopmentActivityAggregateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task CreateUsersMePasswordAsync(ChangeMyPasswordRequest body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/me/password";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<UsersSearchResponse> CreateUsersSearchAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/search";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UsersSearchResponse> CreateUsersSearchConversationTargetAsync(
    UserSearchRequest body,
    CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/search/conversation/target";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UsersSearchResponse> CreateUsersSearchQueuemembersManageAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/search/queuemembers/manage";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UsersSearchResponse> CreateUsersSearchTeamsAssignAsync(UserSearchRequest body, CancellationToken cancellationToken = default)
    {
        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "/api/v2/users/search/teams/assign";

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UsersSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    // post methods

    // Put methods
    public async Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings settings, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(settings);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/routing/directroutingbackup/settings/me", settings, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/routing/users/{Uri.EscapeDataString(userId)}/directroutingbackup/settings";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentDirectRoutingBackupSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentMaxUtilizationResponse> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/routing/users/{Uri.EscapeDataString(userId)}/utilization";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentMaxUtilizationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallForwarding> PutUserCallforwardingAsync(string userId, CallForwarding body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/callforwarding";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallForwarding>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OutOfOffice> UpdateUserOutofofficeAsync(string userId, OutOfOffice body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/outofoffice";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutOfOffice>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<string[]> UpdateUserProfileskillsAsync(string userId, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/profileskills";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<string[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAuthorization> PutUserRolesAsync(string subjectId, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(subjectId)}/roles";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserRoutingSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(skillId))
        {
            throw new ArgumentException("skillId is required", nameof(skillId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/routingskills/{Uri.EscapeDataString(skillId)}";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserRoutingSkill>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserSkillEntityListing> UpdateUserRoutingskillsBulkAsync(string userId, List<UserRoutingSkillPost> body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/routingskills/bulk";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserSkillEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoutingStatus> UpdateUserRoutingstatusAsync(string userId, RoutingStatus body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/routingstatus";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserState> UpdateUserStateAsync(string userId, UserState body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/state";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserState>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task CreateUserStationAssociatedstationAsync(string userId, string stationId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(stationId))
        {
            throw new ArgumentException("stationId is required", nameof(stationId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/station/associatedstation/{Uri.EscapeDataString(stationId)}";

        var response = await client.PutAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task CreateUserStationDefaultstationAsync(string userId, string stationId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(stationId))
        {
            throw new ArgumentException("stationId is required", nameof(stationId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/station/defaultstation/{Uri.EscapeDataString(stationId)}";

        var response = await client.PutAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<Verifier> UpdateUserVerifierAsync(string userId, string verifierId, UpdateVerifierRequest body, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("userId is required", nameof(userId));
        }

        if (string.IsNullOrWhiteSpace(verifierId))
        {
            throw new ArgumentException("verifierId is required", nameof(verifierId));
        }

        if (body == null)
        {
            throw new ArgumentException("body is required", nameof(body));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/users/{Uri.EscapeDataString(userId)}/verifiers/{Uri.EscapeDataString(verifierId)}";

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Verifier>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<bool> DeleteAnalyticsUsersDetailsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/analytics/users/details/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<User> DeleteUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/users/{userId}/directroutingbackup/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/routing/users/{userId}/utilization", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserExternalidAuthorityNameExternalKeyAsync(string userId, string authorityName, string externalKey, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}/externalid/{authorityName}/{externalKey}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}/routinglanguages/{languageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}/routingskills/{skillId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserStationAssociatedstationAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}/station/associatedstation", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserStationDefaultstationAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}/station/defaultstation", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserVerifierAsync(string userId, string verifierId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}/verifiers/{verifierId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }



    // above are the delete methods
}
