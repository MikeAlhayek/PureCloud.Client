using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using Function = PureCloud.Client.Models.Function;
using ActionModel = PureCloud.Client.Models.Action;

namespace PureCloud.Client.Apis;

public sealed class IntegrationsApi : IIntegrationsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public IntegrationsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<Integration> DeleteIntegrationAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/{Uri.EscapeDataString(integrationId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Integration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteIntegrationsActionAsync(string actionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/integrations/credentials/{Uri.EscapeDataString(credentialId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<Integration> GetIntegrationAsync(string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/{Uri.EscapeDataString(integrationId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Integration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IntegrationConfiguration> GetIntegrationConfigCurrentAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/{Uri.EscapeDataString(integrationId)}/config/current", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IntegrationConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IntegrationEntityListing> GetIntegrationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IntegrationEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Actions> GetIntegrationsActionAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        if (includeConfig.HasValue)
        {
            parameters.Add("includeConfig", UriHelper.ParameterToString(includeConfig.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Actions>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Actions> GetIntegrationsActionDraftAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        if (includeConfig.HasValue)
        {
            parameters.Add("includeConfig", UriHelper.ParameterToString(includeConfig.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Actions>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FunctionConfig> GetIntegrationsActionDraftFunctionAsync(string actionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/function", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FunctionConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<JsonSchemaDocument> GetIntegrationsActionDraftSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentException.ThrowIfNullOrEmpty(fileName);

        var parameters = new NameValueCollection();

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/schemas/{Uri.EscapeDataString(fileName)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonSchemaDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<string> GetIntegrationsActionDraftTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentException.ThrowIfNullOrEmpty(fileName);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/templates/{Uri.EscapeDataString(fileName)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<DraftValidationResult> GetIntegrationsActionDraftValidationAsync(string actionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/validation", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DraftValidationResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FunctionConfig> GetIntegrationsActionFunctionAsync(string actionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/function", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FunctionConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<JsonSchemaDocument> GetIntegrationsActionSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentException.ThrowIfNullOrEmpty(fileName);

        var parameters = new NameValueCollection();

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/schemas/{Uri.EscapeDataString(fileName)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonSchemaDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<string> GetIntegrationsActionTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentException.ThrowIfNullOrEmpty(fileName);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/templates/{Uri.EscapeDataString(fileName)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<ActionEntityListing> GetIntegrationsActionsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(category))
        {
            parameters.Add("category", UriHelper.ParameterToString(category));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(ids))
        {
            parameters.Add("ids", UriHelper.ParameterToString(ids));
        }

        if (!string.IsNullOrEmpty(secure))
        {
            parameters.Add("secure", UriHelper.ParameterToString(secure));
        }

        if (!string.IsNullOrEmpty(includeAuthActions))
        {
            parameters.Add("includeAuthActions", UriHelper.ParameterToString(includeAuthActions));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/actions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(secure))
        {
            parameters.Add("secure", UriHelper.ParameterToString(secure));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/actions/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionCertificateListing> GetIntegrationsActionsCertificatesAsync(string status = null, string type = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(status))
        {
            parameters.Add("status", UriHelper.ParameterToString(status));
        }

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", UriHelper.ParameterToString(type));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/actions/certificates", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionCertificateListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TrustedCertificates> GetIntegrationsActionsCertificatesTruststoreAsync(CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/actions/certificates/truststore", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustedCertificates>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(category))
        {
            parameters.Add("category", UriHelper.ParameterToString(category));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(ids))
        {
            parameters.Add("ids", UriHelper.ParameterToString(ids));
        }

        if (!string.IsNullOrEmpty(secure))
        {
            parameters.Add("secure", UriHelper.ParameterToString(secure));
        }

        if (!string.IsNullOrEmpty(includeAuthActions))
        {
            parameters.Add("includeAuthActions", UriHelper.ParameterToString(includeAuthActions));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/actions/drafts", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IList<FunctionRuntime>> GetIntegrationsActionsFunctionsRuntimesAsync(CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/actions/functions/runtimes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<FunctionRuntime>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotAsync(string integrationId, string botId, string version = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        ArgumentException.ThrowIfNullOrEmpty(botId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(version))
        {
            parameters.Add("version", UriHelper.ParameterToString(version));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/botconnector/{Uri.EscapeDataString(integrationId)}/bots/{Uri.EscapeDataString(botId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotConnectorBot>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsync(string integrationId, string botId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        ArgumentException.ThrowIfNullOrEmpty(botId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/botconnector/{Uri.EscapeDataString(integrationId)}/bots/{Uri.EscapeDataString(botId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotConnectorBotVersionSummaryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BotList> GetIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/botconnector/{Uri.EscapeDataString(integrationId)}/bots", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsync(string integrationId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/botconnector/{Uri.EscapeDataString(integrationId)}/bots/summaries", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotConnectorBotSummaryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ClientAppEntityListing> GetIntegrationsClientAppsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/clientapps", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ClientAppEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UCIntegrationListing> GetIntegrationsClientAppsUnifiedCommunicationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/clientapps/unifiedcommunications", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UCIntegrationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Credential> GetIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/credentials/{Uri.EscapeDataString(credentialId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Credential>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CredentialInfoListing> GetIntegrationsCredentialsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/credentials", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CredentialInfoListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CredentialTypeListing> GetIntegrationsCredentialsTypesAsync(CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/credentials/types", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CredentialTypeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AudioConnectorIntegrationEntityListing> GetIntegrationsSpeechAudioconnectorAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/audioconnector", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AudioConnectorIntegrationEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AudioConnectorIntegration> GetIntegrationsSpeechAudioconnectorIntegrationIdAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/audioconnector/{Uri.EscapeDataString(integrationId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AudioConnectorIntegration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/dialogflow/agents/{Uri.EscapeDataString(agentId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialogflowAgent>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/dialogflow/agents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialogflowAgentSummaryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialogflowCXAgent> GetIntegrationsSpeechDialogflowCxAgentAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/dialogflowcx/agents/{Uri.EscapeDataString(agentId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialogflowCXAgent>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialogflowCXAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowCxAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/dialogflowcx/agents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialogflowCXAgentSummaryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LexBotAlias> GetIntegrationsSpeechLexBotAliasAsync(string aliasId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(aliasId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/lex/bot/alias/{Uri.EscapeDataString(aliasId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LexBotAlias>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(botId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(status))
        {
            parameters.Add("status", UriHelper.ParameterToString(status));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/lex/bot/{Uri.EscapeDataString(botId)}/aliases", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LexBotAliasEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LexBotEntityListing> GetIntegrationsSpeechLexBotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/lex/bots", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LexBotEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LexV2BotAlias> GetIntegrationsSpeechLexV2BotAliasAsync(string aliasId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(aliasId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/lexv2/bot/alias/{Uri.EscapeDataString(aliasId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LexV2BotAlias>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LexV2BotAliasEntityListing> GetIntegrationsSpeechLexV2BotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(botId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(status))
        {
            parameters.Add("status", UriHelper.ParameterToString(status));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var uri = UriHelper.GetUri($"api/v2/integrations/speech/lexv2/bot/{Uri.EscapeDataString(botId)}/aliases", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LexV2BotAliasEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LexV2BotEntityListing> GetIntegrationsSpeechLexV2BotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/lexv2/bots", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LexV2BotEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotAsync(string nuanceIntegrationId, string botId, IList<string> expand = null, string targetChannel = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentException.ThrowIfNullOrEmpty(botId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(targetChannel))
        {
            parameters.Add("targetChannel", UriHelper.ParameterToString(targetChannel));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/{Uri.EscapeDataString(botId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NuanceBot>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotJobAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentException.ThrowIfNullOrEmpty(botId);

        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/{Uri.EscapeDataString(botId)}/jobs/{Uri.EscapeDataString(jobId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotJobResultsAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentException.ThrowIfNullOrEmpty(botId);

        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/{Uri.EscapeDataString(botId)}/jobs/{Uri.EscapeDataString(jobId)}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NuanceBot>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (onlyRegisteredBots.HasValue)
        {
            parameters.Add("onlyRegisteredBots", UriHelper.ParameterToString(onlyRegisteredBots.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NuanceBotEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotsJobAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/jobs/{Uri.EscapeDataString(jobId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsJobResultsAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/jobs/{Uri.EscapeDataString(jobId)}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NuanceBotEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SttEngineEntity> GetIntegrationsSpeechSttEngineAsync(string engineId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(engineId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/stt/engines/{Uri.EscapeDataString(engineId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SttEngineEntity>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SttEngineEntityListing> GetIntegrationsSpeechSttEnginesAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/stt/engines", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SttEngineEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TtsEngineEntity> GetIntegrationsSpeechTtsEngineAsync(string engineId, bool? includeVoices = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(engineId);

        var parameters = new NameValueCollection();

        if (includeVoices.HasValue)
        {
            parameters.Add("includeVoices", UriHelper.ParameterToString(includeVoices.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/tts/engines/{Uri.EscapeDataString(engineId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TtsEngineEntity>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceAsync(string engineId, string voiceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(engineId);

        ArgumentException.ThrowIfNullOrEmpty(voiceId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/tts/engines/{Uri.EscapeDataString(engineId)}/voices/{Uri.EscapeDataString(voiceId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TtsVoiceEntity>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesAsync(string engineId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(engineId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/tts/engines/{Uri.EscapeDataString(engineId)}/voices", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TtsVoiceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesAsync(int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null, CancellationToken cancellationToken = default)
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

        if (includeVoices.HasValue)
        {
            parameters.Add("includeVoices", UriHelper.ParameterToString(includeVoices.Value));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(language))
        {
            parameters.Add("language", UriHelper.ParameterToString(language));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/tts/engines", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TtsEngineEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TtsSettings> GetIntegrationsSpeechTtsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/speech/tts/settings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TtsSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IntegrationType> GetIntegrationsTypeAsync(string typeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(typeId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/types/{Uri.EscapeDataString(typeId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IntegrationType>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<JsonSchemaDocument> GetIntegrationsTypeConfigSchemaAsync(string typeId, string configType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(typeId);

        ArgumentException.ThrowIfNullOrEmpty(configType);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/types/{Uri.EscapeDataString(typeId)}/configschemas/{Uri.EscapeDataString(configType)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonSchemaDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IntegrationTypeEntityListing> GetIntegrationsTypesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/types", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IntegrationTypeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UnifiedCommunicationsIntegration> GetIntegrationsUnifiedcommunicationsClientappAsync(string ucIntegrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ucIntegrationId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/unifiedcommunications/clientapps/{Uri.EscapeDataString(ucIntegrationId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnifiedCommunicationsIntegration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UnifiedCommunicationsIntegrationListing> GetIntegrationsUnifiedcommunicationsClientappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/unifiedcommunications/clientapps", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnifiedCommunicationsIntegrationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAppEntityListing> GetIntegrationsUserappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(appHost))
        {
            parameters.Add("appHost", UriHelper.ParameterToString(appHost));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/integrations/userapps", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAppEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Integration> UpdateIntegrationAsync(string integrationId, Integration body, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/{Uri.EscapeDataString(integrationId)}", parameters);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Integration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionModel> PatchIntegrationsActionAsync(string actionId, UpdateActionInput body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}", parameters);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionModel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionModel> PatchIntegrationsActionDraftAsync(string actionId, UpdateDraftInput body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft", parameters);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionModel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Integration> CreateIntegrationAsync(CreateIntegrationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/integrations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Integration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionModel> PostIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft", parameters);

        var response = await client.PostAsync(uri, null, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionModel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync(string actionId, FunctionUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/function/upload", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FunctionUploadResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionModel> PostIntegrationsActionDraftPublishAsync(string actionId, PublishDraftInput body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/publish", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionModel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TestExecutionResult> PostIntegrationsActionDraftTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/test", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TestExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> PostIntegrationsActionExecuteAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri(
            $"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/execute",
            parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TestExecutionResult> PostIntegrationsActionTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (flatten.HasValue)
        {
            parameters.Add("flatten", UriHelper.ParameterToString(flatten.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/test", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TestExecutionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionModel> CreateIntegrationsActionAsync(PostActionInput body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/integrations/actions", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionModel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionModel> CreateIntegrationsActionsDraftsAsync(PostActionInput body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/integrations/actions/drafts", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionModel>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CredentialInfo> CreateIntegrationsCredentialsAsync(Credential body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/integrations/credentials", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CredentialInfo>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncJob> CreateIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsync(string nuanceIntegrationId, string botId, IList<string> expand = null, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentException.ThrowIfNullOrEmpty(botId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/{Uri.EscapeDataString(botId)}/jobs", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncJob> CreateIntegrationsSpeechNuanceIntegrationIdBotsJobsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (onlyRegisteredBots.HasValue)
        {
            parameters.Add("onlyRegisteredBots", UriHelper.ParameterToString(onlyRegisteredBots.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/jobs", parameters);

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> CreateIntegrationsSpeechNuanceIntegrationIdBotsLaunchValidateAsync(string nuanceIntegrationId, BotExecutionConfiguration settings, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentNullException.ThrowIfNull(settings);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/launch/validate", parameters);

        var response = await client.PostAsJsonAsync(uri, settings, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WebhookInvocationResponse> CreateIntegrationsWebhookEventsAsync(string tokenId, object body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tokenId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/webhooks/{Uri.EscapeDataString(tokenId)}/events", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebhookInvocationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IntegrationConfiguration> UpdateIntegrationConfigCurrentAsync(string integrationId, IntegrationConfiguration body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/{Uri.EscapeDataString(integrationId)}/config/current", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IntegrationConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FunctionConfig> UpdateIntegrationsActionDraftFunctionAsync(string actionId, Function body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/actions/{Uri.EscapeDataString(actionId)}/draft/function", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FunctionConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> PutIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, BotList botList, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        ArgumentNullException.ThrowIfNull(botList);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/botconnector/{Uri.EscapeDataString(integrationId)}/bots", parameters);

        var response = await client.PutAsJsonAsync(uri, botList, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CredentialInfo> UpdateIntegrationsCredentialAsync(string credentialId, Credential body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/credentials/{Uri.EscapeDataString(credentialId)}", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CredentialInfo>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> UpdateIntegrationsSpeechNuanceIntegrationBotsLaunchSettingsAsync(string nuanceIntegrationId, NuanceBotLaunchSettings settings, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nuanceIntegrationId);

        ArgumentNullException.ThrowIfNull(settings);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/speech/nuance/{Uri.EscapeDataString(nuanceIntegrationId)}/bots/launch/settings", parameters);

        var response = await client.PutAsJsonAsync(uri, settings, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TtsSettings> UpdateIntegrationsSpeechTtsSettingsAsync(TtsSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/integrations/speech/tts/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TtsSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<string> UpdateIntegrationsUnifiedcommunicationsThirdPartyPresencesAsync(string ucIntegrationId, IEnumerable<UCThirdPartyPresence> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ucIntegrationId);

        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/integrations/unifiedcommunications/{Uri.EscapeDataString(ucIntegrationId)}/thirdpartypresences", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<string>(_options.JsonSerializerOptions, cancellationToken);
    }

}
