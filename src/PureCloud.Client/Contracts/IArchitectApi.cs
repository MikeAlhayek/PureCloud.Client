using System.Data;
using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IArchitectApi
{
    Task<bool> DeleteArchitectEmergencygroupAsync(string emergencyGroupId, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectGrammarAsync(string grammarId, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectGrammarLanguageAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectGrammarLanguageFilesDtmfAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectGrammarLanguageFilesVoiceAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectIvrAsync(string ivrId, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectPromptAsync(string promptId, bool? allResources = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectPromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectPromptResourceAudioAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<Operation> DeleteArchitectPromptsAsync(List<string> id, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectScheduleAsync(string scheduleId, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectSchedulegroupAsync(string scheduleGroupId, CancellationToken cancellationToken = default);

    Task<bool> DeleteArchitectSystempromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<bool> DeleteFlowAsync(string flowId, CancellationToken cancellationToken = default);

    Task<bool> DeleteFlowInstancesSettingsLoglevelsAsync(string flowId, CancellationToken cancellationToken = default);

    Task<Operation> DeleteFlowsAsync(List<string> ids, CancellationToken cancellationToken = default);

    Task<bool> DeleteFlowsDatatableAsync(string datatableId, bool? force = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteFlowsDatatableRowAsync(string datatableId, string rowId, CancellationToken cancellationToken = default);

    Task<bool> DeleteFlowsInstancesSettingsLoglevelsDefaultAsync(CancellationToken cancellationToken = default);

    Task<bool> DeleteFlowsMilestoneAsync(string milestoneId, CancellationToken cancellationToken = default);

    Task<DependencyObjectEntityListing> GetArchitectDependencyTrackingAsync(string name, int? pageNumber = null, int? pageSize = null, IEnumerable<string> objectTypes = null, bool? consumedResources = null, bool? consumingResources = null, IEnumerable<string> consumedResourceTypes = null, IEnumerable<string> consumingResourceTypes = null, CancellationToken cancellationToken = default);

    Task<DependencyStatus> GetArchitectDependencyTrackingBuildAsync(CancellationToken cancellationToken = default);

    Task<ConsumedResourcesEntityListing> GetArchitectDependencyTrackingConsumedResourcesAsync(string id, string version, string objectType, IEnumerable<string> resourceTypes = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<ConsumingResourcesEntityListing> GetArchitectDependencyTrackingConsumingResourcesAsync(string id, string objectType, IEnumerable<string> resourceTypes = null, string version = null, int? pageNumber = null, int? pageSize = null, string flowFilter = null, CancellationToken cancellationToken = default);

    Task<DependencyObjectEntityListing> GetArchitectDependencyTrackingDeletedResourceConsumersAsync(string name = null, IEnumerable<string> objectTypes = null, string flowFilter = null, bool? consumedResources = null, IEnumerable<string> consumedResourceTypes = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DependencyObject> GetArchitectDependencyTrackingObjectAsync(string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, IEnumerable<string> consumedResourceTypes = null, IEnumerable<string> consumingResourceTypes = null, bool? consumedResourceRequest = null, CancellationToken cancellationToken = default);

    Task<DependencyType> GetArchitectDependencyTrackingTypeAsync(string typeId, CancellationToken cancellationToken = default);

    Task<DependencyTypeEntityListing> GetArchitectDependencyTrackingTypesAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DependencyObjectEntityListing> GetArchitectDependencyTrackingUpdatedResourceConsumersAsync(string name = null, IEnumerable<string> objectTypes = null, bool? consumedResources = null, IEnumerable<string> consumedResourceTypes = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<EmergencyGroup> GetArchitectEmergencyGroupAsync(string emergencyGroupId, CancellationToken cancellationToken = default);

    Task<EmergencyGroupListing> GetArchitectEmergencyGroupsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    Task<EmergencyGroupDivisionViewEntityListing> GetArchitectEmergencyGroupDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> groupIds = null, string groupName = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<Grammar> GetArchitectGrammarAsync(string grammarId, bool includeFileUrls = false, CancellationToken cancellationToken = default);

    Task<GrammarLanguage> GetArchitectGrammarLanguageAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default);

    Task<GrammarListing> GetArchitectGrammarsAsync(IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, bool? includeFileUrls = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<IVR> GetIvrAsync(string ivrId, CancellationToken cancellationToken = default);

    Task<IdentityResolutionConfig> GetIvrIdentityResolutionAsync(string ivrId, CancellationToken cancellationToken = default);

    Task<IVREntityListing> GetIvrsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string dnis = null, string scheduleGroup = null, CancellationToken cancellationToken = default);

    Task<IVRDivisionViewEntityListing> GetIvrsDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ivrDivisionViewIds = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<Prompt> GetPromptAsync(string promptId, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default);

    Task<HistoryListing> GetPromptHistoryAsync(string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, IEnumerable<string> actions = null, CancellationToken cancellationToken = default);

    Task<PromptAsset> GetPromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<PromptAssetEntityListing> GetPromptResourcesAsync(string promptId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<PromptEntityListing> GetPromptsAsync(int? pageNumber = null, int? pageSize = null, IEnumerable<string> promptNames = null, string description = null, string nameOrDescription = null, string sortBy = null, string sortOrder = null, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default);

    Task<Schedule> GetScheduleAsync(string scheduleId, CancellationToken cancellationToken = default);

    Task<ScheduleGroup> GetScheduleGroupAsync(string scheduleGroupId, CancellationToken cancellationToken = default);

    Task<ScheduleGroupEntityListing> GetScheduleGroupsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string scheduleIds = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<ScheduleGroupDivisionViewEntityListing> GetScheduleGroupDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> scheduleGroupIds = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<ScheduleEntityListing> GetSchedulesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<ScheduleDivisionViewEntityListing> GetSchedulesDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> scheduleIds = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<SystemPrompt> GetSystemPromptAsync(string promptId, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default);

    Task<HistoryListing> GetSystemPromptHistoryAsync(string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, IEnumerable<string> actions = null, CancellationToken cancellationToken = default);

    Task<SystemPromptAsset> GetSystemPromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<SystemPromptAssetEntityListing> GetSystemPromptResourcesAsync(string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<SystemPromptEntityListing> GetSystemPromptsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default);

    Task<Flow> GetFlowAsync(string flowId, bool? deleted = null, CancellationToken cancellationToken = default);

    Task<HistoryListing> GetFlowHistoryAsync(string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, IEnumerable<string> actions = null, CancellationToken cancellationToken = default);

    Task<FlowSettingsResponse> GetFlowInstancesSettingsLogLevelsAsync(string flowId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<object> GetFlowLatestConfigurationAsync(string flowId, bool? deleted = null, CancellationToken cancellationToken = default);

    Task<FlowVersion> GetFlowVersionAsync(string flowId, string versionId, bool? deleted = null, CancellationToken cancellationToken = default);

    Task<object> GetFlowVersionConfigurationAsync(string flowId, string versionId, bool? deleted = null, CancellationToken cancellationToken = default);

    Task<FlowHealth> GetFlowVersionHealthAsync(string flowId, string versionId, string language = null, CancellationToken cancellationToken = default);

    Task<FlowHealthIntent> GetFlowVersionIntentHealthAsync(string flowId, string versionId, string intentId, string language, CancellationToken cancellationToken = default);

    Task<FlowHealthUtterance> GetFlowVersionIntentUtteranceHealthAsync(string flowId, string versionId, string intentId, string utteranceId, string language, CancellationToken cancellationToken = default);

    Task<FlowVersionEntityListing> GetFlowVersionsAsync(string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null, CancellationToken cancellationToken = default);

    Task<FlowEntityListing> GetFlowsAsync(IEnumerable<string> types = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string lockedByClientId = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<DataTable> GetFlowsDatatableAsync(string datatableId, string expand = null, CancellationToken cancellationToken = default);

    Task<DataTableExportJob> GetFlowsDatatableExportJobAsync(string dataTableId, string exportJobId, CancellationToken cancellationToken = default);

    Task<DataTableImportJob> GetFlowsDatatableImportJobAsync(string dataTableId, string importJobId, CancellationToken cancellationToken = default);

    Task<DataTableImportEntityListing> GetFlowsDatatableImportJobsAsync(string dataTableId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetFlowsDatatableRowAsync(string dataTableId, string rowId, bool? showBrief = null, CancellationToken cancellationToken = default);

    Task<DataTableRowEntityListing> GetFlowsDatatableRowsAsync(string dataTableId, int? pageNumber = null, int? pageSize = null, bool? showBrief = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<DataTablesDomainEntityListing> GetFlowsDatatablesAsync(string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> divisionIds = null, string name = null, CancellationToken cancellationToken = default);

    Task<DataTable> GetFlowsDatatablesDivisionViewAsync(string datatableId, string expand = null, CancellationToken cancellationToken = default);

    Task<DataTablesDomainEntityListing> GetFlowsDatatablesDivisionViewsAsync(string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> divisionIds = null, string name = null, CancellationToken cancellationToken = default);

    Task<FlowDivisionViewEntityListing> GetFlowsDivisionViewsAsync(IEnumerable<string> types = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string publishVersionId = null, string publishedAfter = null, string publishedBefore = null, IEnumerable<string> divisionIds = null, bool? includeSchemas = null, CancellationToken cancellationToken = default);

    Task<FlowRuntimeExecution> GetFlowsExecutionAsync(string flowExecutionId, CancellationToken cancellationToken = default);

    Task<ArchitectExportJobStateResponse> GetFlowsExportJobAsync(string jobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<GetFlowExecutionDataJobResult> GetFlowsInstanceAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default);

    Task<GetFlowExecutionDataJobResult> GetFlowsInstancesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<FlowsQueryCriteriaResponse> GetFlowsInstancesQueryCapabilitiesAsync(string expand = null, CancellationToken cancellationToken = default);

    Task<ExecutionDataFlowSettingsResponse> GetFlowsInstancesSettingsExecutionDataAsync(CancellationToken cancellationToken = default);

    Task<FlowSettingsResponseEntityListing> GetFlowsInstancesSettingsLoglevelsAsync(IEnumerable<string> expand = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<FlowLogLevelCharacteristicsDefinitions> GetFlowsInstancesSettingsLoglevelsCharacteristicsAsync(CancellationToken cancellationToken = default);

    Task<FlowSettingsResponse> GetFlowsInstancesSettingsLoglevelsDefaultAsync(IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<ArchitectJobStateResponse> GetFlowsJobAsync(string jobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<FlowMilestone> GetFlowsMilestoneAsync(string milestoneId, CancellationToken cancellationToken = default);

    Task<FlowMilestoneListing> GetFlowsMilestonesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<FlowMilestoneDivisionViewEntityListing> GetFlowsMilestonesDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<FlowOutcome> GetFlowsOutcomeAsync(string flowOutcomeId, CancellationToken cancellationToken = default);

    Task<FlowOutcomeListing> GetFlowsOutcomesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<FlowOutcomeDivisionViewEntityListing> GetFlowsOutcomesDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    Task<Grammar> PatchArchitectGrammarAsync(string grammarId, Grammar body, CancellationToken cancellationToken = default);

    Task<GrammarLanguage> PatchArchitectGrammarLanguageAsync(string grammarId, string languageCode, GrammarLanguageUpdate body, CancellationToken cancellationToken = default);

    Task<ExecutionDataFlowSettingsResponse> PatchFlowsInstancesSettingsExecutiondataAsync(ExecutionDataSettingsRequest body, CancellationToken cancellationToken = default);

    Task<object> CreateArchitectDependencytrackingBuildAsync(CancellationToken cancellationToken = default);

    Task<EmergencyGroup> CreateArchitectEmergencyGroupsAsync(EmergencyGroup body, CancellationToken cancellationToken = default);

    Task<UploadUrlResponse> CreateArchitectGrammarLanguageFilesDtmfAsync(string grammarId, string languageCode, GrammarFileUploadRequest body, CancellationToken cancellationToken = default);

    Task<UploadUrlResponse> CreateArchitectGrammarLanguageFilesVoiceAsync(string grammarId, string languageCode, GrammarFileUploadRequest body, CancellationToken cancellationToken = default);

    Task<GrammarLanguage> CreateArchitectGrammarLanguagesAsync(string grammarId, GrammarLanguage body, CancellationToken cancellationToken = default);

    Task<Grammar> CreateArchitectGrammarsAsync(Grammar body, CancellationToken cancellationToken = default);

    Task<IVR> CreateArchitectIvrsAsync(IVR body, CancellationToken cancellationToken = default);

    Task<Operation> CreateArchitectPromptHistoryAsync(string promptId, CancellationToken cancellationToken = default);

    Task<PromptAssetUpload> CreateArchitectPromptResourceUploadsAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<PromptAsset> CreateArchitectPromptResourcesAsync(string promptId, PromptAssetCreate body, CancellationToken cancellationToken = default);

    Task<Prompt> CreateArchitectPromptsAsync(Prompt body, CancellationToken cancellationToken = default);

    Task<ScheduleGroup> CreateArchitectScheduleGroupsAsync(ScheduleGroup body, CancellationToken cancellationToken = default);

    Task<Schedule> CreateArchitectSchedulesAsync(Schedule body, CancellationToken cancellationToken = default);

    Task<Operation> CreateArchitectSystempromptHistoryAsync(string promptId, CancellationToken cancellationToken = default);

    Task<PromptAssetUpload> CreateArchitectSystempromptResourceUploadsAsync(string promptId, string languageCode, CancellationToken cancellationToken = default);

    Task<SystemPromptAsset> CreateArchitectSystempromptResourcesAsync(string promptId, SystemPromptAsset body, CancellationToken cancellationToken = default);

    Task<Operation> CreateFlowHistoryAsync(string flowId, CancellationToken cancellationToken = default);

    Task<FlowSettingsResponse> CreateFlowInstancesSettingsLoglevelsAsync(string flowId, FlowLogLevelRequest body, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<FlowVersion> CreateFlowVersionsAsync(string flowId, object body, CancellationToken cancellationToken = default);

    Task<Flow> CreateFlowsAsync(Flow body, string language = null, CancellationToken cancellationToken = default);

    Task<Operation> CreateFlowsActionsCheckinAsync(string flow, CancellationToken cancellationToken = default);

    Task<Flow> CreateFlowsActionsCheckoutAsync(string flow, CancellationToken cancellationToken = default);

    Task<Flow> CreateFlowsActionsDeactivateAsync(string flow, CancellationToken cancellationToken = default);

    Task<Operation> CreateFlowsActionsPublishAsync(string flow, string version = null, CancellationToken cancellationToken = default);

    Task<Flow> CreateFlowsActionsRevertAsync(string flow, CancellationToken cancellationToken = default);

    Task<Flow> CreateFlowsActionsUnlockAsync(string flow, CancellationToken cancellationToken = default);

    Task<DataTableExportJob> CreateFlowsDatatableExportJobsAsync(string datatableId, CancellationToken cancellationToken = default);

    Task<DataTableImportJob> CreateFlowsDatatableImportJobsAsync(string datatableId, DataTableImportJob body, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> CreateFlowsDatatableRowsAsync(string datatableId, object dataTableRow, CancellationToken cancellationToken = default);

    Task<DataTable> CreateFlowsDatatablesAsync(DataTable body, CancellationToken cancellationToken = default);

    Task<FlowExecutionLaunchResponse> CreateFlowsExecutionsAsync(FlowExecutionLaunchRequest flowLaunchRequest, CancellationToken cancellationToken = default);

    Task<RegisterArchitectExportJobResponse> CreateFlowsExportJobsAsync(RegisterArchitectExportJob body, CancellationToken cancellationToken = default);

    Task<GetFlowExecutionDataJobResult> CreateFlowsInstancesJobsAsync(ExecutionDataRequest body, string expand = null, CancellationToken cancellationToken = default);

    Task<FlowResultEntityListing> CreateFlowsInstancesQueryAsync(CriteriaQuery body, bool? indexOnly = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<RegisterArchitectJobResponse> CreateFlowsJobsAsync(CancellationToken cancellationToken = default);

    Task<FlowMilestone> CreateFlowsMilestonesAsync(FlowMilestone body, CancellationToken cancellationToken = default);

    Task<FlowOutcome> CreateFlowsOutcomesAsync(FlowOutcome body, CancellationToken cancellationToken = default);

    Task<EmergencyGroup> UpdateArchitectEmergencygroupAsync(string emergencyGroupId, EmergencyGroup body, CancellationToken cancellationToken = default);

    Task<IVR> UpdateArchitectIvrAsync(string ivrId, IVR body, CancellationToken cancellationToken = default);

    Task<IdentityResolutionConfig> UpdateArchitectIvrIdentityresolutionAsync(string ivrId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    Task<Prompt> UpdateArchitectPromptAsync(string promptId, Prompt body, CancellationToken cancellationToken = default);

    Task<PromptAsset> UpdateArchitectPromptResourceAsync(string promptId, string languageCode, PromptAsset body, CancellationToken cancellationToken = default);

    Task<Schedule> UpdateArchitectScheduleAsync(string scheduleId, Schedule body, CancellationToken cancellationToken = default);

    Task<ScheduleGroup> UpdateArchitectScheduleGroupAsync(string scheduleGroupId, ScheduleGroup body, CancellationToken cancellationToken = default);

    Task<SystemPromptAsset> UpdateArchitectSystemPromptResourceAsync(string promptId, string languageCode, SystemPromptAsset body, CancellationToken cancellationToken = default);

    Task<Flow> UpdateFlowAsync(string flowId, Flow body, CancellationToken cancellationToken = default);

    Task<FlowSettingsResponse> UpdateFlowInstancesSettingsLoglevelsAsync(string flowId, FlowLogLevelRequest body, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<DataTable> UpdateFlowsDatatableAsync(string datatableId, DataTable body, string expand = null, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> UpdateFlowsDatatableRowAsync(string datatableId, string rowId, object body = null, CancellationToken cancellationToken = default);

    Task<FlowSettingsResponse> UpdateFlowsInstancesSettingsLoglevelsDefaultAsync(FlowLogLevelRequest body, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<FlowMilestone> UpdateFlowsMilestoneAsync(string milestoneId, FlowMilestone body, CancellationToken cancellationToken = default);

    Task<Operation> UpdateFlowsOutcomeAsync(string flowOutcomeId, FlowOutcome body, CancellationToken cancellationToken = default);
}
