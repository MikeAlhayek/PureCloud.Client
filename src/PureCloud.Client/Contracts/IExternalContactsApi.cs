using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IExternalContactsApi
{
    Task<bool> DeleteExternalcontactsContactAsync(string contactId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsContactNoteAsync(string contactId, string noteId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsContactsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsExternalsourceAsync(string externalSourceId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsImportCsvSettingAsync(string settingsId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsImportSettingAsync(string settingsId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsOrganizationAsync(string externalOrganizationId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsOrganizationNoteAsync(string externalOrganizationId, string noteId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsOrganizationTrustorAsync(string externalOrganizationId, CancellationToken cancellationToken = default);

    Task<bool> DeleteExternalcontactsRelationshipAsync(string relationshipId, CancellationToken cancellationToken = default);

    Task<ExternalContact> GetExternalcontactsContactAsync(string contactId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<ContactIdentifierListing> GetExternalcontactsContactIdentifiersAsync(string contactId, CancellationToken cancellationToken = default);

    Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync(string contactId, string pageSize = null, string after = null, bool? includeMerged = null, CancellationToken cancellationToken = default);

    Task<Note> GetExternalcontactsContactNoteAsync(string contactId, string noteId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<NoteListing> GetExternalcontactsContactNotesAsync(string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<ExternalContact> GetExternalcontactsContactUnresolvedAsync(string contactId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<ContactListing> GetExternalcontactsContactsAsync(int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, IList<string> expand = null, IList<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<ContactsExport> GetExternalcontactsContactsExportAsync(string exportId, CancellationToken cancellationToken = default);

    Task<ExportListing> GetExternalcontactsContactsExportsAsync(List<string> divisionIds = null, string after = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DataSchema> GetExternalcontactsContactsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    Task<DataSchema> GetExternalcontactsContactsSchemaVersionAsync(string schemaId, string versionId, CancellationToken cancellationToken = default);

    Task<DataSchema> GetExternalcontactsContactsSchemaVersionsAsync(string schemaId, CancellationToken cancellationToken = default);

    Task<DataSchemaListing> GetExternalcontactsContactsSchemasAsync(CancellationToken cancellationToken = default);

    Task<Coretype> GetExternalcontactsContactsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default);

    Task<Coretype> GetExternalcontactsContactsSchemasCoretypesAsync(CancellationToken cancellationToken = default);

    Task<SchemaQuantityLimits> GetExternalcontactsContactsSchemasLimitsAsync(CancellationToken cancellationToken = default);

    Task<ExternalSource> GetExternalcontactsExternalsourceAsync(string externalSourceId, CancellationToken cancellationToken = default);

    Task<CursorExternalSourceListing> GetExternalcontactsExternalsourcesAsync(string cursor = null, int? limit = null, string name = null, bool? active = null, CancellationToken cancellationToken = default);

    Task<CsvSettings> GetExternalcontactsImportCsvSettingAsync(string settingsId, CancellationToken cancellationToken = default);

    Task<Listing> GetExternalcontactsImportCsvSettingsAsync(string after = null, string pageSize = null, string externalSettingsId = null, CancellationToken cancellationToken = default);

    Task<CsvUploadDetailsResponse> GetExternalcontactsImportCsvUploadDetailsAsync(string uploadId, CancellationToken cancellationToken = default);

    Task<CsvUploadPreviewResponse> GetExternalcontactsImportCsvUploadPreviewAsync(string uploadId, CancellationToken cancellationToken = default);

    Task<ContactImportJobResponse> GetExternalcontactsImportJobAsync(string jobId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<ContactImportJobEntityListing> GetExternalcontactsImportJobsAsync(IList<string> expand = null, string after = null, string pageSize = null, string sortOrder = null, string jobStatus = null, CancellationToken cancellationToken = default);

    Task<ContactImportSettings> GetExternalcontactsImportSettingAsync(string settingsId, CancellationToken cancellationToken = default);

    Task<ContactImportSettingsEntityListing> GetExternalcontactsImportSettingsAsync(string after = null, string pageSize = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    Task<ExternalOrganization> GetExternalcontactsOrganizationAsync(string externalOrganizationId, IList<string> expand = null, bool? includeTrustors = null, CancellationToken cancellationToken = default);

    Task<ContactListing> GetExternalcontactsOrganizationContactsAsync(string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<ExternalOrganizationIdentifierListing> GetExternalcontactsOrganizationIdentifiersAsync(string externalOrganizationId, CancellationToken cancellationToken = default);

    Task<Note> GetExternalcontactsOrganizationNoteAsync(string externalOrganizationId, string noteId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<NoteListing> GetExternalcontactsOrganizationNotesAsync(string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<RelationshipListing> GetExternalcontactsOrganizationRelationshipsAsync(string externalOrganizationId, int? pageSize = null, int? pageNumber = null, IList<string> expand = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<ExternalOrganizationListing> GetExternalcontactsOrganizationsAsync(int? pageSize = null, int? pageNumber = null, string q = null, IList<string> trustorId = null, string sortOrder = null, IList<string> expand = null, bool? includeTrustors = null, IList<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<DataSchema> GetExternalcontactsOrganizationsSchemaAsync(string schemaId, CancellationToken cancellationToken = default);

    Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionAsync(string schemaId, string versionId, CancellationToken cancellationToken = default);

    Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionsAsync(string schemaId, CancellationToken cancellationToken = default);

    Task<DataSchemaListing> GetExternalcontactsOrganizationsSchemasAsync(CancellationToken cancellationToken = default);

    Task<Coretype> GetExternalcontactsOrganizationsSchemasCoretypeAsync(string coreTypeName, CancellationToken cancellationToken = default);

    Task<Coretype> GetExternalContactsOrganizationsSchemasCoretypesAsync(CancellationToken cancellationToken = default);

    Task<SchemaQuantityLimits> GetExternalContactsOrganizationsSchemasLimitsAsync(CancellationToken cancellationToken = default);

    Task<Relationship> GetExternalContactsRelationshipAsync(string relationshipId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<ReverseWhitepagesLookupResult> GetExternalContactsReverseWhitePagesLookupAsync(string lookupVal, IList<string> expand = null, string divisionId = null, CancellationToken cancellationToken = default);

    Task<CursorContactListing> GetExternalContactsScanContactsAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default);

    Task<CursorContactListing> GetExternalContactsScanContactsDivisionViewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default);

    Task<CursorNoteListing> GetExternalcontactsScanNotesAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default);

    Task<CursorNoteListing> GetExternalcontactsScanNotesDivisionviewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default);

    Task<CursorOrganizationListing> GetExternalcontactsScanOrganizationsAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default);

    Task<CursorOrganizationListing> GetExternalcontactsScanOrganizationsDivisionviewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default);

    Task<CursorRelationshipListing> GetExternalcontactsScanRelationshipsAsync(int? limit = null, string cursor = null, string divisionId = null, CancellationToken cancellationToken = default);

    Task<CursorRelationshipListing> GetExternalcontactsScanRelationshipsDivisionviewsAllAsync(int? limit = null, string cursor = null, CancellationToken cancellationToken = default);

    Task<ContactIdentifier> UpdateExternalcontactsContactIdentifiersAsync(string contactId, IdentifierClaimRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchContactsResponse> CreateExternalcontactsBulkContactsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkContactsResponse> CreateExternalcontactsBulkContactsAddAsync(BulkContactsRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchContactsResponse> CreateExternalcontactsBulkContactsDivisionviewsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkContactsEnrichResponse> CreateExternalcontactsBulkContactsEnrichAsync(BulkContactsEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default);

    Task<BulkDeleteResponse> CreateExternalcontactsBulkContactsRemoveAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchContactsResponse> CreateExternalcontactsBulkContactsUnresolvedAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkContactsResponse> CreateExternalcontactsBulkContactsUpdateAsync(BulkContactsRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchNotesResponse> CreateExternalcontactsBulkNotesAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkNotesResponse> CreateExternalcontactsBulkNotesAddAsync(BulkNotesRequest body, CancellationToken cancellationToken = default);

    Task<BulkDeleteResponse> RemoveExternalcontactsBulkNotesAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkNotesResponse> UpdateExternalcontactsBulkNotesAsync(BulkNotesRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchOrganizationsResponse> CreateExternalcontactsBulkOrganizationsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkOrganizationsResponse> CreateExternalcontactsBulkOrganizationsAddAsync(BulkOrganizationsRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchOrganizationsResponse> CreateExternalcontactsBulkOrganizationsDivisionviewsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkOrganizationsEnrichResponse> CreateExternalcontactsBulkOrganizationsEnrichAsync(BulkOrganizationsEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default);

    Task<BulkDeleteResponse> CreateExternalcontactsBulkOrganizationsRemoveAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkOrganizationsResponse> UpdateExternalcontactsBulkOrganizationsAsync(BulkOrganizationsRequest body, CancellationToken cancellationToken = default);

    Task<BulkFetchRelationshipsResponse> CreateExternalcontactsBulkRelationshipsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkRelationshipsResponse> CreateExternalcontactsBulkRelationshipsAddAsync(BulkRelationshipsRequest body, CancellationToken cancellationToken = default);

    Task<BulkDeleteResponse> DeleteExternalcontactsBulkRelationshipsAsync(BulkIdsRequest body, CancellationToken cancellationToken = default);

    Task<BulkRelationshipsResponse> UpdateExternalcontactsBulkRelationshipsAsync(BulkRelationshipsRequest body, CancellationToken cancellationToken = default);

    Task<Note> CreateExternalcontactsContactNoteAsync(string contactId, Note body, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalcontactsContactPromotionAsync(string contactId, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalcontactsContactsAsync(ExternalContact body, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalcontactsContactsEnrichAsync(ContactEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default);

    Task<ContactsExport> CreateExternalcontactsContactsExportsAsync(ContactsExport body, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalcontactsContactsMergeAsync(MergeContactsRequest body, CancellationToken cancellationToken = default);

    Task<DataSchema> CreateExternalcontactsContactsSchemasAsync(DataSchema body, CancellationToken cancellationToken = default);

    Task<ExternalSource> CreateExternalContactsExternalSourcesAsync(ExternalSource body, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalContactsIdentifierLookupAsync(ContactIdentifier identifier, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalContactsIdentifierLookupContactsAsync(ContactIdentifier identifier, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<ExternalOrganization> CreateExternalContactsIdentifierLookupOrganizationsAsync(ExternalOrganizationIdentifier identifier, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<CsvJobResponse> CreateExternalContactsImportCsvJobsAsync(CsvJobRequest body, CancellationToken cancellationToken = default);

    Task<CsvSettings> CreateExternalContactsImportCsvSettingsAsync(CsvSettings body, CancellationToken cancellationToken = default);

    Task<CsvUploadResponse> CreateExternalContactsImportCsvUploadsAsync(CsvUploadRequest body, CancellationToken cancellationToken = default);

    Task<ContactImportJobResponse> CreateExternalContactsImportJobsAsync(ContactImportJobRequest body, CancellationToken cancellationToken = default);

    Task<ContactImportSettings> CreateExternalContactsImportSettingsAsync(ContactImportSettings body, CancellationToken cancellationToken = default);

    Task<ExternalContact> CreateExternalContactsMergeContactsAsync(MergeRequest body, CancellationToken cancellationToken = default);

    Task<Note> CreateExternalContactsOrganizationNotesAsync(string externalOrganizationId, Note body, CancellationToken cancellationToken = default);

    Task<ExternalOrganization> CreateExternalContactsOrganizationsAsync(ExternalOrganization body, CancellationToken cancellationToken = default);

    Task<ExternalOrganization> CreateExternalContactsOrganizationsEnrichAsync(ExternalOrganizationEnrichRequest body, bool? dryRun = null, CancellationToken cancellationToken = default);

    Task<DataSchema> CreateExternalContactsOrganizationsSchemasAsync(DataSchema body, CancellationToken cancellationToken = default);

    Task<Relationship> CreateExternalContactsRelationshipsAsync(Relationship body, CancellationToken cancellationToken = default);

    Task<ExternalContact> UpdateExternalContactsContactAsync(string contactId, ExternalContact body, CancellationToken cancellationToken = default);

    Task<Note> UpdateExternalContactsContactNoteAsync(string contactId, string noteId, Note body, CancellationToken cancellationToken = default);

    Task<DataSchema> UpdateExternalContactsContactsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default);

    Task<object> UpdateExternalContactsConversationAsync(string conversationId, ConversationAssociation body, CancellationToken cancellationToken = default);

    Task<ExternalSource> UpdateExternalContactsExternalSourceAsync(string externalSourceId, ExternalSource body, CancellationToken cancellationToken = default);

    Task<CsvSettings> UpdateExternalContactsImportCsvSettingAsync(string settingsId, CsvSettings body, CancellationToken cancellationToken = default);

    Task<ContactImportJobStatusUpdateResponse> UpdateExternalContactsImportJobAsync(string jobId, ContactImportJobStatusUpdateRequest body, CancellationToken cancellationToken = default);

    Task<ContactImportSettings> UpdateExternalContactsImportSettingAsync(string settingsId, ContactImportSettings body, CancellationToken cancellationToken = default);

    Task<ExternalOrganization> UpdateExternalContactsOrganizationAsync(string externalOrganizationId, ExternalOrganization body, CancellationToken cancellationToken = default);

    Task<Note> UpdateExternalContactsOrganizationNoteAsync(string externalOrganizationId, string noteId, Note body, CancellationToken cancellationToken = default);

    Task<ExternalOrganizationTrustorLink> UpdateExternalContactsOrganizationTrustorAsync(string externalOrganizationId, string trustorId, CancellationToken cancellationToken = default);

    Task<DataSchema> UpdateExternalContactsOrganizationsSchemaAsync(string schemaId, DataSchema body, CancellationToken cancellationToken = default);

    Task<Relationship> UpdateExternalContactsRelationshipAsync(string relationshipId, Relationship body, CancellationToken cancellationToken = default);

}
