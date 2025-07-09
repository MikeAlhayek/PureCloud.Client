using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Apis;

public class AuthorizationApi : IAuthorizationApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public AuthorizationApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<bool> DeleteAuthorizationDivisionAsync(string divisionId, bool? force = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (force.HasValue)
        {
            parameters.Add("force", force.Value.ToString().ToLowerInvariant());
        }

        var url = UriHelper.GetUri($"api/v2/authorization/divisions/{divisionId}", parameters);

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAuthorizationPoliciesTargetSubjectAsync(string targetName, string subjectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(targetName);

        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/targets/{targetName}/subject/{subjectId}", null);

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAuthorizationRoleAsync(string roleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}", null);

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentException.ThrowIfNullOrEmpty(roleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}", null);

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, bool? objectCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (objectCount.HasValue)
        {
            parameters.Add("objectCount", objectCount.Value.ToString().ToLowerInvariant());
        }

        var url = UriHelper.GetUri($"api/v2/authorization/divisions/{divisionId}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<AuthzDivisionGrantEntityListing> GetAuthorizationDivisionGrantsAsync(string divisionId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var paramDict = new Dictionary<string, string>
        {
            ["pageNumber"] = pageNumber?.ToString(),
            ["pageSize"] = pageSize?.ToString()
        };

        foreach (var kvp in paramDict)
        {
            if (kvp.Value != null)
            {
                parameters.Add(kvp.Key, kvp.Value);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/divisions/{divisionId}/grants", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivisionGrantEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["pageSize"] = pageSize?.ToString(),
            ["pageNumber"] = pageNumber?.ToString(),
            ["sortBy"] = sortBy,
            ["nextPage"] = nextPage,
            ["previousPage"] = previousPage,
            ["objectCount"] = objectCount.HasValue ? objectCount.Value.ToString().ToLowerInvariant() : null,
            ["name"] = name
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        if (id != null)
        {
            foreach (var item in id)
            {
                parameters.Add("id", item);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/divisions", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivisionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["pageNumber"] = pageNumber?.ToString(),
            ["pageSize"] = pageSize?.ToString()
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }

        }

        var url = UriHelper.GetUri("api/v2/authorization/divisions/deleted", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivisionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/divisions/home", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<int?> GetAuthorizationDivisionsLimitAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/divisions/limit", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<int?>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryAsync(string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["before"] = before,
            ["after"] = after,
            ["pageSize"] = pageSize,
            ["name"] = name
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        if (id != null)
        {
            foreach (var item in id)
            {
                parameters.Add("id", item);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/divisions/query", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivisionCursorListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IList<AuthzDivision>> GetAuthorizationDivisionsPermittedMeAsync(string permission, string name = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(permission);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["permission"] = permission,
            ["name"] = name
        };
        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/divisionspermitted/me", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<AuthzDivision>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DivsPermittedEntityListing> GetAuthorizationDivisionsPermittedPagedSubjectAsync(string subjectId, string permission, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentException.ThrowIfNullOrEmpty(permission);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["permission"] = permission,
            ["pageNumber"] = pageNumber?.ToString(),
            ["pageSize"] = pageSize?.ToString()
        };
        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/divisionspermitted/paged/{subjectId}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DivsPermittedEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PermissionCollectionEntityListing> GetAuthorizationPermissionsAsync(int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["pageSize"] = pageSize?.ToString(),
            ["pageNumber"] = pageNumber?.ToString(),
            ["queryType"] = queryType,
            ["query"] = query
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/permissions", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PermissionCollectionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesAsync(string after = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["after"] = after,
            ["pageSize"] = pageSize?.ToString()
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/policies", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicyEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesSubjectAsync(string subjectId, string after = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["after"] = after,
            ["pageSize"] = pageSize?.ToString()
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/policies/subject/{subjectId}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicyEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesTargetAsync(string targetName, string after = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(targetName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["after"] = after,
            ["pageSize"] = pageSize?.ToString()
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/policies/targets/{targetName}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicyEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicy> GetAuthorizationPolicyTargetSubjectAsync(string targetName, string subjectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(targetName);

        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/targets/{targetName}/subject/{subjectId}", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TargetAttributes> GetAuthorizationPoliciesTargetsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/policies/targets", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TargetAttributes>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(string policyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/{policyId}", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PolicyAttributeSet> GetAuthorizationPolicyAttributesAsync(string policyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/{policyId}/attributes", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PolicyAttributeSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OrganizationProductEntityListing> GetAuthorizationProductsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/products", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationProductEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainOrganizationRole> GetAuthorizationRoleAsync(string roleId, bool? userCount = null, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["userCount"] = userCount.HasValue ? userCount.Value.ToString().ToLowerInvariant() : null
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainOrganizationRole>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainOrgRoleDifference> GetAuthorizationRoleCompareDefaultAsync(string leftRoleId, string rightRoleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(leftRoleId);

        ArgumentException.ThrowIfNullOrEmpty(rightRoleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainOrgRoleDifference>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SubjectDivisionGrantsEntityListing> GetAuthorizationRoleSubjectGrantsAsync(string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["pageSize"] = pageSize?.ToString(),
            ["pageNumber"] = pageNumber?.ToString(),
            ["sortBy"] = sortBy,
            ["nextPage"] = nextPage,
            ["previousPage"] = previousPage
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}/subjectgrants", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SubjectDivisionGrantsEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserReferenceEntityListing> GetAuthorizationRoleUsersAsync(string roleId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["pageSize"] = pageSize?.ToString(),
            ["pageNumber"] = pageNumber?.ToString()
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}/users", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserReferenceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OrganizationRoleEntityListing> GetAuthorizationRolesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, string name = null, IList<string> permission = null, IList<string> defaultRoleId = null, bool? userCount = null, IList<string> id = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["pageSize"] = pageSize?.ToString(),
            ["pageNumber"] = pageNumber?.ToString(),
            ["sortBy"] = sortBy,
            ["nextPage"] = nextPage,
            ["previousPage"] = previousPage,
            ["name"] = name,
            ["userCount"] = userCount.HasValue ? userCount.Value.ToString().ToLowerInvariant() : null
        };

        foreach (var item in parametersDictionary)
        {
            if (item.Value != null)
            {
                parameters.Add(item.Key, item.Value);
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        if (permission != null)
        {
            foreach (var item in permission)
            {
                parameters.Add("permission", item);
            }
        }

        if (defaultRoleId != null)
        {
            foreach (var item in defaultRoleId)
            {
                parameters.Add("defaultRoleId", item);
            }
        }

        if (id != null)
        {
            foreach (var item in id)
            {
                parameters.Add("id", item);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/roles", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationRoleEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoleSettings> GetAuthorizationRolesSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/roles/settings", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoleSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationSettings> GetAuthorizationSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/settings", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzSubject> GetAuthorizationSubjectAsync(string subjectId, bool? includeDuplicates = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (includeDuplicates.HasValue)
        {
            parameters.Add("includeDuplicates", includeDuplicates.Value.ToString().ToLowerInvariant());
        }

        var url = UriHelper.GetUri($"api/v2/authorization/subjects/{subjectId}", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzSubject>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzSubject> GetAuthorizationSubjectsMeAsync(bool? includeDuplicates = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (includeDuplicates.HasValue)
        {
            parameters.Add("includeDuplicates", includeDuplicates.Value.ToString().ToLowerInvariant());
        }

        var url = UriHelper.GetUri("api/v2/authorization/subjects/me", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzSubject>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Dictionary<string, object>> GetAuthorizationSubjectsRoleCountsAsync(IList<string> id = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (id != null)
        {
            foreach (var item in id)
            {
                parameters.Add("id", item);
            }
        }

        var url = UriHelper.GetUri("api/v2/authorization/subjects/rolecounts", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAuthorization> GetUserRolesAsync(string subjectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/users/{subjectId}/roles", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainOrganizationRole> PatchAuthorizationRoleAsync(string roleId, DomainOrganizationRole body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}", null);

        var response = await client.PatchAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainOrganizationRole>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationSettings> UpdateAuthorizationSettingsAsync(AuthorizationSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/settings", null);

        var response = await client.PatchAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> CreateAuthorizationDivisionObjectAsync(string divisionId, string objectType, List<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentException.ThrowIfNullOrEmpty(objectType);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/divisions/{divisionId}/objects/{objectType}", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/divisions/{divisionId}/restore", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthzDivision> CreateAuthorizationDivisionsAsync(AuthzDivision body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/divisions", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicy> CreateAuthorizationPoliciesTargetAsync(string targetName, AuthorizationPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(targetName);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/targets/{targetName}", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ValidationErrorListing> ValidateAuthorizationPoliciesTargetAsync(string targetName, AuthorizationPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(targetName);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/targets/{targetName}/validate", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ValidationErrorListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PolicyTestResult> CreateSimulateAuthorizationPolicyAsync(string policyId, PolicyTestPayload body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/{policyId}/simulate", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PolicyTestResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> CreateAuthorizationRoleAsync(string roleId, SubjectDivisions body, string subjectType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (subjectType != null)
        {
            parameters.Add("subjectType", subjectType);
        }

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}", parameters);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<DomainOrgRoleDifference> CreateCompareDefaultAuthorizationRoleAsync(string leftRoleId, string rightRoleId, DomainOrganizationRole body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(leftRoleId);

        ArgumentException.ThrowIfNullOrEmpty(rightRoleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainOrgRoleDifference>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainOrganizationRole> CreateAuthorizationRolesAsync(DomainOrganizationRoleCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/roles", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainOrganizationRole>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OrganizationRoleEntityListing> CreateAuthorizationRolesDefaultAsync(bool? force = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var parameters = new NameValueCollection();
        if (force.HasValue)
        {
            parameters.Add("force", force.Value.ToString().ToLowerInvariant());
        }
        var url = UriHelper.GetUri("api/v2/authorization/roles/default", parameters);
        var response = await client.PostAsync(url, null, cancellationToken);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<OrganizationRoleEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> CreateAuthorizationSubjectBulkAddAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (subjectType != null)
        {
            parameters.Add("subjectType", subjectType);
        }

        var url = UriHelper.GetUri($"api/v2/authorization/subjects/{subjectId}/bulkadd", parameters);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> CreateAuthorizationSubjectBulkRemoveAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (subjectType != null)
        {
            parameters.Add("subjectType", subjectType);
        }

        var url = UriHelper.GetUri($"api/v2/authorization/subjects/{subjectId}/bulkremove", null);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> CreateAuthorizationSubjectBulkReplaceAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (subjectType != null)
        {
            parameters.Add("subjectType", subjectType);
        }

        var url = UriHelper.GetUri($"api/v2/authorization/subjects/{subjectId}/bulkreplace", parameters);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> CreateAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, string subjectType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentException.ThrowIfNullOrEmpty(roleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (subjectType != null)
        {
            parameters.Add("subjectType", subjectType);
        }

        var url = UriHelper.GetUri($"api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}", parameters);

        var response = await client.PostAsync(url, null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<AuthzDivision> UpdateAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/divisions/{divisionId}", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicy> UpdateAuthorizationPoliciesTargetAsync(string targetName, AuthorizationPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(targetName);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/targets/{targetName}", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuthorizationPolicy> UpdateAuthorizationPolicyAsync(string policyId, AuthorizationPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/policies/{policyId}", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthorizationPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainOrganizationRole> UpdateAuthorizationRoleAsync(string roleId, DomainOrganizationRoleUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainOrganizationRole>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IList<string>> CreateAuthorizationRoleUsersAsync(string roleId, IList<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}/users/add", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IList<string>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IList<string>> UpdateAuthorizationRoleUsersRemoveAsync(string roleId, IList<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri($"api/v2/authorization/roles/{roleId}/users/remove", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IList<string>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OrganizationRoleEntityListing> UpdateAuthorizationRolesDefaultAsync(IList<DomainOrganizationRole> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/roles/default", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationRoleEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoleSettings> UpdateAuthorizationRolesSettingsAsync(RoleSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/authorization/roles/settings", null);

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoleSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAuthorization> UpdateUserRolesAsync(string subjectId, IList<string> roles, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subjectId);

        ArgumentNullException.ThrowIfNull(roles);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var requestUri = UriHelper.GetUri($"api/v2/users/{subjectId}/roles", null);

        var response = await client.PutAsJsonAsync(requestUri, roles, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options.JsonSerializerOptions, cancellationToken);
    }

}
