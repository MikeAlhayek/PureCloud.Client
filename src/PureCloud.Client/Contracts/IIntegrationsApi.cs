using PureCloud.Client.Models;
using ActionModel = PureCloud.Client.Models.Action;

namespace PureCloud.Client.Contracts;

public interface IIntegrationsApi
{
    /// <summary>
    /// Delete Integration.
    /// </summary>
    Task<Integration> DeleteIntegrationAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Action.
    /// </summary>
    Task<bool> DeleteIntegrationsActionAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete ActionDraft.
    /// </summary>
    Task<bool> DeleteIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Credential.
    /// </summary>
    Task<bool> DeleteIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Integration.
    /// </summary>
    Task<Integration> GetIntegrationAsync(string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get IntegrationConfigCurrent.
    /// </summary>
    Task<IntegrationConfiguration> GetIntegrationConfigCurrentAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get .
    /// </summary>
    Task<IntegrationEntityListing> GetIntegrationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Action.
    /// </summary>
    Task<Actions> GetIntegrationsActionAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraft.
    /// </summary>
    Task<Actions> GetIntegrationsActionDraftAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftFunction.
    /// </summary>
    Task<FunctionConfig> GetIntegrationsActionDraftFunctionAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftSchema.
    /// </summary>
    Task<JsonSchemaDocument> GetIntegrationsActionDraftSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftTemplate.
    /// </summary>
    Task<string> GetIntegrationsActionDraftTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftValidation.
    /// </summary>
    Task<DraftValidationResult> GetIntegrationsActionDraftValidationAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionFunction.
    /// </summary>
    Task<FunctionConfig> GetIntegrationsActionFunctionAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionSchema.
    /// </summary>
    Task<JsonSchemaDocument> GetIntegrationsActionSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionTemplate.
    /// </summary>
    Task<string> GetIntegrationsActionTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Actions.
    /// </summary>
    Task<ActionEntityListing> GetIntegrationsActionsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsCategories.
    /// </summary>
    Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsCertificates.
    /// </summary>
    Task<ActionCertificateListing> GetIntegrationsActionsCertificatesAsync(string status = null, string type = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsCertificatesTruststore.
    /// </summary>
    Task<TrustedCertificates> GetIntegrationsActionsCertificatesTruststoreAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsDrafts.
    /// </summary>
    Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default);

    Task<IList<FunctionRuntime>> GetIntegrationsActionsFunctionsRuntimesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBot.
    /// </summary>
    Task<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotAsync(string integrationId, string botId, string version = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBotVersions.
    /// </summary>
    Task<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsync(string integrationId, string botId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBots.
    /// </summary>
    Task<BotList> GetIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBotsSummaries.
    /// </summary>
    Task<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsync(string integrationId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ClientApps.
    /// </summary>
    Task<ClientAppEntityListing> GetIntegrationsClientAppsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ClientAppsUnifiedCommunications.
    /// </summary>
    Task<UCIntegrationListing> GetIntegrationsClientAppsUnifiedCommunicationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Credential.
    /// </summary>
    Task<Credential> GetIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Credentials.
    /// </summary>
    Task<CredentialInfoListing> GetIntegrationsCredentialsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get CredentialsTypes.
    /// </summary>
    Task<CredentialTypeListing> GetIntegrationsCredentialsTypesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechAudioconnector.
    /// </summary>
    Task<AudioConnectorIntegrationEntityListing> GetIntegrationsSpeechAudioconnectorAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechAudioconnectorIntegrationId.
    /// </summary>
    Task<AudioConnectorIntegration> GetIntegrationsSpeechAudioconnectorIntegrationIdAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowAgent.
    /// </summary>
    Task<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowAgents.
    /// </summary>
    Task<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowCxAgent.
    /// </summary>
    Task<DialogflowCXAgent> GetIntegrationsSpeechDialogflowCxAgentAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowCxAgents.
    /// </summary>
    Task<DialogflowCXAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowCxAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexBotAlias.
    /// </summary>
    Task<LexBotAlias> GetIntegrationsSpeechLexBotAliasAsync(string aliasId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexBotBotIdAliases.
    /// </summary>
    Task<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexBots.
    /// </summary>
    Task<LexBotEntityListing> GetIntegrationsSpeechLexBotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexV2BotAlias.
    /// </summary>
    Task<LexV2BotAlias> GetIntegrationsSpeechLexV2BotAliasAsync(string aliasId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexV2BotBotIdAliases.
    /// </summary>
    Task<LexV2BotAliasEntityListing> GetIntegrationsSpeechLexV2BotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexV2Bots.
    /// </summary>
    Task<LexV2BotEntityListing> GetIntegrationsSpeechLexV2BotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBot.
    /// </summary>
    Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotAsync(string nuanceIntegrationId, string botId, IList<string> expand = null, string targetChannel = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotJob.
    /// </summary>
    Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotJobAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotJobResults.
    /// </summary>
    Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotJobResultsAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBots.
    /// </summary>
    Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotsJob.
    /// </summary>
    Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotsJobAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotsJobResults.
    /// </summary>
    Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsJobResultsAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechSttEngine.
    /// </summary>
    Task<SttEngineEntity> GetIntegrationsSpeechSttEngineAsync(string engineId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechSttEngines.
    /// </summary>
    Task<SttEngineEntityListing> GetIntegrationsSpeechSttEnginesAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngine.
    /// </summary>
    Task<TtsEngineEntity> GetIntegrationsSpeechTtsEngineAsync(string engineId, bool? includeVoices = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngineVoice.
    /// </summary>
    Task<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceAsync(string engineId, string voiceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngineVoices.
    /// </summary>
    Task<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesAsync(string engineId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngines.
    /// </summary>
    Task<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesAsync(int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsSettings.
    /// </summary>
    Task<TtsSettings> GetIntegrationsSpeechTtsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Type.
    /// </summary>
    Task<IntegrationType> GetIntegrationsTypeAsync(string typeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get TypeConfigSchema.
    /// </summary>
    Task<JsonSchemaDocument> GetIntegrationsTypeConfigSchemaAsync(string typeId, string configType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Types.
    /// </summary>
    Task<IntegrationTypeEntityListing> GetIntegrationsTypesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get UnifiedcommunicationsClientapp.
    /// </summary>
    Task<UnifiedCommunicationsIntegration> GetIntegrationsUnifiedcommunicationsClientappAsync(string ucIntegrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get UnifiedcommunicationsClientapps.
    /// </summary>
    Task<UnifiedCommunicationsIntegrationListing> GetIntegrationsUnifiedcommunicationsClientappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Userapps.
    /// </summary>
    Task<UserAppEntityListing> GetIntegrationsUserappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Integration.
    /// </summary>
    Task<Integration> UpdateIntegrationAsync(string integrationId, Integration body, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Action.
    /// </summary>
    Task<ActionModel> PatchIntegrationsActionAsync(string actionId, UpdateActionInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update ActionDraft.
    /// </summary>
    Task<ActionModel> PatchIntegrationsActionDraftAsync(string actionId, UpdateDraftInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Integration.
    /// </summary>
    Task<Integration> CreateIntegrationAsync(CreateIntegrationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraft.
    /// </summary>
    Task<ActionModel> PostIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraftFunctionUpload.
    /// </summary>
    Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync(string actionId, FunctionUploadRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraftPublish.
    /// </summary>
    Task<ActionModel> PostIntegrationsActionDraftPublishAsync(string actionId, PublishDraftInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraftTest.
    /// </summary>
    Task<TestExecutionResult> PostIntegrationsActionDraftTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionExecute.
    /// </summary>
    Task<object> PostIntegrationsActionExecuteAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionTest.
    /// </summary>
    Task<TestExecutionResult> PostIntegrationsActionTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Action.
    /// </summary>
    Task<ActionModel> CreateIntegrationsActionAsync(PostActionInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionsDrafts.
    /// </summary>
    Task<ActionModel> CreateIntegrationsActionsDraftsAsync(PostActionInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Credentials.
    /// </summary>
    Task<CredentialInfo> CreateIntegrationsCredentialsAsync(Credential body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SpeechNuanceNuanceIntegrationIdBotJobs.
    /// </summary>
    Task<AsyncJob> CreateIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsync(string nuanceIntegrationId, string botId, IList<string> expand = null, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SpeechNuanceIntegrationIdBotsJobs.
    /// </summary>
    Task<AsyncJob> CreateIntegrationsSpeechNuanceIntegrationIdBotsJobsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SpeechNuanceIntegrationIdBotsLaunchValidate.
    /// </summary>
    Task<object> CreateIntegrationsSpeechNuanceIntegrationIdBotsLaunchValidateAsync(string nuanceIntegrationId, BotExecutionConfiguration settings, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create WebhookEvents.
    /// </summary>
    Task<WebhookInvocationResponse> CreateIntegrationsWebhookEventsAsync(string tokenId, object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update IntegrationConfigCurrent.
    /// </summary>
    Task<IntegrationConfiguration> UpdateIntegrationConfigCurrentAsync(string integrationId, IntegrationConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update ActionDraftFunction.
    /// </summary>
    Task<FunctionConfig> UpdateIntegrationsActionDraftFunctionAsync(string actionId, Function body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update BotconnectorIntegrationIdBots.
    /// </summary>
    Task<object> PutIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, BotList botList, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Credential.
    /// </summary>
    Task<CredentialInfo> UpdateIntegrationsCredentialAsync(string credentialId, Credential body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update SpeechNuanceIntegrationBotsLaunchSettings.
    /// </summary>
    Task<object> UpdateIntegrationsSpeechNuanceIntegrationBotsLaunchSettingsAsync(string nuanceIntegrationId, NuanceBotLaunchSettings settings, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update SpeechTtsSettings.
    /// </summary>
    Task<TtsSettings> UpdateIntegrationsSpeechTtsSettingsAsync(TtsSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update UnifiedcommunicationsThirdPartyPresences.
    /// </summary>
    Task<string> UpdateIntegrationsUnifiedcommunicationsThirdPartyPresencesAsync(string ucIntegrationId, IEnumerable<UCThirdPartyPresence> body, CancellationToken cancellationToken = default);
}
