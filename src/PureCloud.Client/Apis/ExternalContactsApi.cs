using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class ExternalContactsApi : IExternalContactsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ExternalContactsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<bool> DeleteExternalcontactsContactAsync(string contactId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/contacts/{contactId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsContactNoteAsync(string contactId, string noteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        ArgumentException.ThrowIfNullOrEmpty(noteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsContactsSchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/contacts/schemas/{schemaId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsExternalsourceAsync(string externalSourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalSourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/externalsources/{externalSourceId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsImportCsvSettingAsync(string settingsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(settingsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/import/csv/settings/{settingsId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsImportSettingAsync(string settingsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(settingsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/import/settings/{settingsId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsOrganizationAsync(string externalOrganizationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsOrganizationNoteAsync(string externalOrganizationId, string noteId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        ArgumentException.ThrowIfNullOrEmpty(noteId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }


    public async Task<bool> DeleteExternalcontactsOrganizationTrustorAsync(string externalOrganizationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteExternalcontactsRelationshipAsync(string relationshipId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(relationshipId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/externalcontacts/relationships/{relationshipId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<ExternalContact> GetExternalcontactsContactAsync(string contactId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/{contactId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactIdentifierListing> GetExternalcontactsContactIdentifiersAsync(string contactId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/contacts/{contactId}/identifiers", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactIdentifierListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync(string contactId, string pageSize = null, string after = null, bool? includeMerged = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var parameters = new NameValueCollection();

        if (pageSize != null)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (after != null)
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (includeMerged.HasValue)
        {
            parameters.Add("includeMerged", UriHelper.ParameterToString(includeMerged.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/{contactId}/journey/sessions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SessionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Note> GetExternalcontactsContactNoteAsync(string contactId, string noteId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        ArgumentException.ThrowIfNullOrEmpty(noteId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Note>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<NoteListing> GetExternalcontactsContactNotesAsync(string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/{contactId}/notes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NoteListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> GetExternalcontactsContactUnresolvedAsync(string contactId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/{contactId}/unresolved", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListing> GetExternalcontactsContactsAsync(int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, IList<string> expand = null, IList<string> divisionIds = null, CancellationToken cancellationToken = default)
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

        if (q != null)
        {
            parameters.Add("q", UriHelper.ParameterToString(q));
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (divisionIds != null)
        {
            foreach (var item in divisionIds)
            {
                parameters.Add("divisionIds", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/contacts", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsExport> GetExternalcontactsContactsExportAsync(string exportId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(exportId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/contacts/exports/{exportId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsExport>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExportListing> GetExternalcontactsContactsExportsAsync(List<string> divisionIds = null, string after = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (divisionIds != null)
        {
            foreach (var id in divisionIds)
            {
                parameters.Add("divisionIds", UriHelper.ParameterToString(id));
            }
        }

        if (after != null)
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/contacts/exports", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExportListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> GetExternalcontactsContactsSchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/contacts/schemas/{schemaId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> GetExternalcontactsContactsSchemaVersionAsync(string schemaId, string versionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/contacts/schemas/{schemaId}/versions/{versionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> GetExternalcontactsContactsSchemaVersionsAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/contacts/schemas/{schemaId}/versions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchemaListing> GetExternalcontactsContactsSchemasAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/externalcontacts/contacts/schemas", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchemaListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Coretype> GetExternalcontactsContactsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(coreTypeName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/contacts/schemas/coretypes/{coreTypeName}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Coretype>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Coretype> GetExternalcontactsContactsSchemasCoretypesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/externalcontacts/contacts/schemas/coretypes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Coretype>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SchemaQuantityLimits> GetExternalcontactsContactsSchemasLimitsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/externalcontacts/contacts/schemas/limits", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SchemaQuantityLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalSource> GetExternalcontactsExternalsourceAsync(string externalSourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalSourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/externalsources/{externalSourceId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalSource>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorExternalSourceListing> GetExternalcontactsExternalsourcesAsync(string cursor = null, int? limit = null, string name = null, bool? active = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (limit.HasValue)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit.Value));
        }

        if (name != null)
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (active.HasValue)
        {
            parameters.Add("active", UriHelper.ParameterToString(active.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/externalsources", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorExternalSourceListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvSettings> GetExternalcontactsImportCsvSettingAsync(string settingsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(settingsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/import/csv/settings/{settingsId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Listing> GetExternalcontactsImportCsvSettingsAsync(string after = null, string pageSize = null, string externalSettingsId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (after != null)
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize != null)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (externalSettingsId != null)
        {
            parameters.Add("externalSettingsId", UriHelper.ParameterToString(externalSettingsId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/import/csv/settings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Listing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvUploadDetailsResponse> GetExternalcontactsImportCsvUploadDetailsAsync(string uploadId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(uploadId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/import/csv/uploads/{uploadId}/details", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvUploadDetailsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvUploadPreviewResponse> GetExternalcontactsImportCsvUploadPreviewAsync(string uploadId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(uploadId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/import/csv/uploads/{uploadId}/preview", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvUploadPreviewResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportJobResponse> GetExternalcontactsImportJobAsync(string jobId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/import/jobs/{jobId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportJobEntityListing> GetExternalcontactsImportJobsAsync(IList<string> expand = null, string after = null, string pageSize = null, string sortOrder = null, string jobStatus = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (after != null)
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize != null)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (jobStatus != null)
        {
            parameters.Add("jobStatus", UriHelper.ParameterToString(jobStatus));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/import/jobs", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportJobEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportSettings> GetExternalcontactsImportSettingAsync(string settingsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(settingsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/import/settings/{settingsId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportSettingsEntityListing> GetExternalcontactsImportSettingsAsync(string after = null, string pageSize = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (after != null)
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (pageSize != null)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (name != null)
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/import/settings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportSettingsEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganization> GetExternalcontactsOrganizationAsync(string externalOrganizationId, IList<string> expand = null, bool? includeTrustors = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (includeTrustors.HasValue)
        {
            parameters.Add("includeTrustors", UriHelper.ParameterToString(includeTrustors.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/organizations/{externalOrganizationId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListing> GetExternalcontactsOrganizationContactsAsync(string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (q != null)
        {
            parameters.Add("q", UriHelper.ParameterToString(q));
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganizationIdentifierListing> GetExternalcontactsOrganizationIdentifiersAsync(string externalOrganizationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}/identifiers", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganizationIdentifierListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Note> GetExternalcontactsOrganizationNoteAsync(string externalOrganizationId, string noteId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        ArgumentException.ThrowIfNullOrEmpty(noteId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Note>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<NoteListing> GetExternalcontactsOrganizationNotesAsync(string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/organizations/{externalOrganizationId}/notes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NoteListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RelationshipListing> GetExternalcontactsOrganizationRelationshipsAsync(string externalOrganizationId, int? pageSize = null, int? pageNumber = null, IList<string> expand = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RelationshipListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganizationListing> GetExternalcontactsOrganizationsAsync(int? pageSize = null, int? pageNumber = null, string q = null, IList<string> trustorId = null, string sortOrder = null, IList<string> expand = null, bool? includeTrustors = null, IList<string> divisionIds = null, CancellationToken cancellationToken = default)
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

        if (q != null)
        {
            parameters.Add("q", UriHelper.ParameterToString(q));
        }

        if (trustorId != null)
        {
            foreach (var id in trustorId)
            {
                parameters.Add("trustorId", UriHelper.ParameterToString(id));
            }
        }

        if (sortOrder != null)
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (includeTrustors.HasValue)
        {
            parameters.Add("includeTrustors", UriHelper.ParameterToString(includeTrustors.Value));
        }

        if (divisionIds != null)
        {
            foreach (var id in divisionIds)
            {
                parameters.Add("divisionIds", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/externalcontacts/organizations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganizationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> GetExternalcontactsOrganizationsSchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/organizations/schemas/{schemaId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionAsync(string schemaId, string versionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/organizations/schemas/{schemaId}/versions/{versionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionsAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/organizations/schemas/{schemaId}/versions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchemaListing> GetExternalcontactsOrganizationsSchemasAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/organizations/schemas", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchemaListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Coretype> GetExternalcontactsOrganizationsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(coreTypeName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/externalcontacts/organizations/schemas/coretypes/{Uri.EscapeDataString(coreTypeName)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Coretype>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Coretype> GetExternalContactsOrganizationsSchemasCoretypesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/externalcontacts/organizations/schemas/coretypes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Coretype>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SchemaQuantityLimits> GetExternalContactsOrganizationsSchemasLimitsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/externalcontacts/organizations/schemas/limits", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SchemaQuantityLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Relationship> GetExternalContactsRelationshipAsync(string relationshipId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(relationshipId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new NameValueCollection();

        if (expand != null)
        {
            queryParams.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/relationships/{relationshipId}", queryParams);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Relationship>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ReverseWhitepagesLookupResult> GetExternalContactsReverseWhitePagesLookupAsync(string lookupVal, IList<string> expand = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(lookupVal);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection
        {
            { "lookupVal", UriHelper.ParameterToString(lookupVal) }
        };

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/reversewhitepageslookup", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReverseWhitepagesLookupResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorContactListing> GetExternalContactsScanContactsAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit != null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit.Value));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/scan/contacts", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorContactListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorContactListing> GetExternalContactsScanContactsDivisionViewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/contacts/divisionviews/all", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorContactListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorNoteListing> GetExternalcontactsScanNotesAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/notes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorNoteListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorNoteListing> GetExternalcontactsScanNotesDivisionviewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/notes/divisionviews/all", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorNoteListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorOrganizationListing> GetExternalcontactsScanOrganizationsAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/organizations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorOrganizationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorOrganizationListing> GetExternalcontactsScanOrganizationsDivisionviewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/organizations/divisionviews/all", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorOrganizationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorRelationshipListing> GetExternalcontactsScanRelationshipsAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/relationships", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorRelationshipListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CursorRelationshipListing> GetExternalcontactsScanRelationshipsDivisionviewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (limit is not null)
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/scan/relationships/divisionviews/all", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CursorRelationshipListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactIdentifier> UpdateExternalcontactsContactIdentifiersAsync(string contactId, IdentifierClaimRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/externalcontacts/contacts/{contactId}/identifiers";

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactIdentifier>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchContactsResponse> CreateExternalcontactsBulkContactsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/contacts", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchContactsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkContactsResponse> CreateExternalcontactsBulkContactsAddAsync(BulkContactsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/bulk/contacts/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkContactsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchContactsResponse> CreateExternalcontactsBulkContactsDivisionviewsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/bulk/contacts/divisionviews", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchContactsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkContactsEnrichResponse> CreateExternalcontactsBulkContactsEnrichAsync(BulkContactsEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (dryRun.HasValue)
        {
            parameters.Add("dryRun", dryRun.Value.ToString().ToLowerInvariant());
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/bulk/contacts/enrich", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkContactsEnrichResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkDeleteResponse> CreateExternalcontactsBulkContactsRemoveAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/contacts/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkDeleteResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchContactsResponse> CreateExternalcontactsBulkContactsUnresolvedAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/contacts/unresolved", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchContactsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkContactsResponse> CreateExternalcontactsBulkContactsUpdateAsync(BulkContactsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/contacts/update", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkContactsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchNotesResponse> CreateExternalcontactsBulkNotesAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/notes", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchNotesResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkNotesResponse> CreateExternalcontactsBulkNotesAddAsync(BulkNotesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/notes/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkNotesResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkDeleteResponse> RemoveExternalcontactsBulkNotesAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/notes/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkDeleteResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkNotesResponse> UpdateExternalcontactsBulkNotesAsync(BulkNotesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/notes/update", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkNotesResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchOrganizationsResponse> CreateExternalcontactsBulkOrganizationsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/organizations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchOrganizationsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkOrganizationsResponse> CreateExternalcontactsBulkOrganizationsAddAsync(BulkOrganizationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/organizations/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkOrganizationsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchOrganizationsResponse> CreateExternalcontactsBulkOrganizationsDivisionviewsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/organizations/divisionviews", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchOrganizationsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkOrganizationsEnrichResponse> CreateExternalcontactsBulkOrganizationsEnrichAsync(BulkOrganizationsEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (dryRun.HasValue)
        {
            parameters.Add("dryRun", UriHelper.ParameterToString(dryRun.Value));
        }

        var uri = UriHelper.GetUri("api/v2/externalcontacts/bulk/organizations/enrich", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkOrganizationsEnrichResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkDeleteResponse> CreateExternalcontactsBulkOrganizationsRemoveAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/bulk/organizations/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkDeleteResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkOrganizationsResponse> UpdateExternalcontactsBulkOrganizationsAsync(BulkOrganizationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/organizations/update", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkOrganizationsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkFetchRelationshipsResponse> CreateExternalcontactsBulkRelationshipsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/bulk/relationships", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkFetchRelationshipsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkRelationshipsResponse> CreateExternalcontactsBulkRelationshipsAddAsync(BulkRelationshipsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/bulk/relationships/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkRelationshipsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkDeleteResponse> DeleteExternalcontactsBulkRelationshipsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/bulk/relationships/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkDeleteResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkRelationshipsResponse> UpdateExternalcontactsBulkRelationshipsAsync(BulkRelationshipsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/bulk/relationships/update", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkRelationshipsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Note> CreateExternalcontactsContactNoteAsync(string contactId, Note body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/contacts/{contactId}/notes", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Note>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalcontactsContactPromotionAsync(string contactId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/externalcontacts/contacts/{contactId}/promotion", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalcontactsContactsAsync(ExternalContact body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/contacts", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalcontactsContactsEnrichAsync(ContactEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (dryRun.HasValue)
        {
            parameters.Add("dryRun", UriHelper.ParameterToString(dryRun.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/enrich", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsExport> CreateExternalcontactsContactsExportsAsync(ContactsExport body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/contacts/exports", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsExport>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalcontactsContactsMergeAsync(MergeContactsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/contacts/merge", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> CreateExternalcontactsContactsSchemasAsync(DataSchema body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/contacts/schemas", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalSource> CreateExternalContactsExternalSourcesAsync(ExternalSource body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/externalsources", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalSource>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalContactsIdentifierLookupAsync(ContactIdentifier identifier, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(identifier);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var url = UriHelper.GetUri($"api/v2/externalcontacts/identifierlookup", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(url, identifier, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalContactsIdentifierLookupContactsAsync(ContactIdentifier identifier, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(identifier);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var url = UriHelper.GetUri($"api/v2/externalcontacts/identifierlookup/contacts", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(url, identifier, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganization> CreateExternalContactsIdentifierLookupOrganizationsAsync(ExternalOrganizationIdentifier identifier, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(identifier);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var url = UriHelper.GetUri($"api/v2/externalcontacts/identifierlookup/organizations", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(url, identifier, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvJobResponse> CreateExternalContactsImportCsvJobsAsync(CsvJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/import/csv/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvSettings> CreateExternalContactsImportCsvSettingsAsync(CsvSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/import/csv/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvUploadResponse> CreateExternalContactsImportCsvUploadsAsync(CsvUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/import/csv/uploads", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvUploadResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportJobResponse> CreateExternalContactsImportJobsAsync(ContactImportJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/import/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportSettings> CreateExternalContactsImportSettingsAsync(ContactImportSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/externalcontacts/import/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> CreateExternalContactsMergeContactsAsync(MergeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/merge/contacts", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Note> CreateExternalContactsOrganizationNotesAsync(string externalOrganizationId, Note body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        ArgumentNullException.ThrowIfNull(body);

        var url = UriHelper.GetUri($"api/v2/externalcontacts/organizations/{externalOrganizationId}/notes", null);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Note>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganization> CreateExternalContactsOrganizationsAsync(ExternalOrganization body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/organizations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganization> CreateExternalContactsOrganizationsEnrichAsync(ExternalOrganizationEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (dryRun != null)

        {
            parameters.Add("dryRun", UriHelper.ParameterToString(dryRun));
        }

        var url = UriHelper.GetUri($"api/v2/externalcontacts/organizations/enrich", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> CreateExternalContactsOrganizationsSchemasAsync(DataSchema body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/organizations/schemas", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Relationship> CreateExternalContactsRelationshipsAsync(Relationship body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/externalcontacts/relationships", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Relationship>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalContact> UpdateExternalContactsContactAsync(string contactId, ExternalContact body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/contacts/{contactId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Note> UpdateExternalContactsContactNoteAsync(string contactId, string noteId, Note body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        ArgumentException.ThrowIfNullOrEmpty(noteId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Note>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> UpdateExternalContactsContactsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/contacts/schemas/{schemaId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> UpdateExternalContactsConversationAsync(string conversationId, ConversationAssociation body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/conversations/{conversationId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalSource> UpdateExternalContactsExternalSourceAsync(string externalSourceId, ExternalSource body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalSourceId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/externalsources/{externalSourceId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalSource>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CsvSettings> UpdateExternalContactsImportCsvSettingAsync(string settingsId, CsvSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(settingsId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/import/csv/settings/{settingsId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CsvSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportJobStatusUpdateResponse> UpdateExternalContactsImportJobAsync(string jobId, ContactImportJobStatusUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/import/jobs/{jobId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportJobStatusUpdateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactImportSettings> UpdateExternalContactsImportSettingAsync(string settingsId, ContactImportSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(settingsId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/import/settings/{settingsId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactImportSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganization> UpdateExternalContactsOrganizationAsync(string externalOrganizationId, ExternalOrganization body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganization>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Note> UpdateExternalContactsOrganizationNoteAsync(string externalOrganizationId, string noteId, Note body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        ArgumentException.ThrowIfNullOrEmpty(noteId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Note>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExternalOrganizationTrustorLink> UpdateExternalContactsOrganizationTrustorAsync(string externalOrganizationId, string trustorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(externalOrganizationId);

        ArgumentException.ThrowIfNullOrEmpty(trustorId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor/{trustorId}", new ByteArrayContent(Array.Empty<byte>()), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExternalOrganizationTrustorLink>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataSchema> UpdateExternalContactsOrganizationsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/organizations/schemas/{schemaId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSchema>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Relationship> UpdateExternalContactsRelationshipAsync(string relationshipId, Relationship body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(relationshipId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/externalcontacts/relationships/{relationshipId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Relationship>(_options.JsonSerializerOptions, cancellationToken);
    }

}
