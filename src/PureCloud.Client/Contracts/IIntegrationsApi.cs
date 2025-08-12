using PureCloud.Client.Models;
using ActionModel = PureCloud.Client.Models.Action;

namespace PureCloud.Client.Contracts;

public interface IIntegrationsApi
{
    /// <summary>
    /// Delete Integration.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Integration> DeleteIntegrationAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Action.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteIntegrationsActionAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete ActionDraft.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Credential.
    /// </summary>
    /// <param name="credentialId">The credential ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Integration.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Integration> GetIntegrationAsync(string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get IntegrationConfigCurrent.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<IntegrationConfiguration> GetIntegrationConfigCurrentAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get .
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<IntegrationEntityListing> GetIntegrationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Action.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="expand">Expand options</param>
    /// <param name="flatten">Flatten response</param>
    /// <param name="includeConfig">Include configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Actions> GetIntegrationsActionAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraft.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="expand">Expand options</param>
    /// <param name="flatten">Flatten response</param>
    /// <param name="includeConfig">Include configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Actions> GetIntegrationsActionDraftAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftFunction.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    Task<FunctionConfig> GetIntegrationsActionDraftFunctionAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftSchema.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="fileName">The file name</param>
    Task<JsonSchemaDocument> GetIntegrationsActionDraftSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftTemplate.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="fileName">The file name</param>
    Task<string> GetIntegrationsActionDraftTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionDraftValidation.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    Task<DraftValidationResult> GetIntegrationsActionDraftValidationAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionFunction.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    Task<FunctionConfig> GetIntegrationsActionFunctionAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionSchema.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="fileName">The file name</param>
    Task<JsonSchemaDocument> GetIntegrationsActionSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionTemplate.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="fileName">The file name</param>
    Task<string> GetIntegrationsActionTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Actions.
    /// </summary>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="category">The category</param>
    /// <param name="name">The name</param>
    /// <param name="ids">The ids</param>
    /// <param name="secure">The secure</param>
    /// <param name="includeAuthActions">The includeAuthActions</param>
    Task<ActionEntityListing> GetIntegrationsActionsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsCategories.
    /// </summary>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="secure">The secure</param>
    Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsCertificates.
    /// </summary>
    /// <param name="status">The status</param>
    /// <param name="type">The type</param>
    Task<ActionCertificateListing> GetIntegrationsActionsCertificatesAsync(string status = null, string type = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsCertificatesTruststore.
    /// </summary>
    Task<TrustedCertificates> GetIntegrationsActionsCertificatesTruststoreAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ActionsDrafts.
    /// </summary>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="category">The category</param>
    /// <param name="name">The name</param>
    /// <param name="ids">The ids</param>
    /// <param name="secure">The secure</param>
    /// <param name="includeAuthActions">The includeAuthActions</param>
    Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default);

    Task<IList<FunctionRuntime>> GetIntegrationsActionsFunctionsRuntimesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBot.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="botId">The bot ID</param>
    /// <param name="version">The version</param>
    Task<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotAsync(string integrationId, string botId, string version = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBotVersions.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="botId">The bot ID</param>
    Task<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsync(string integrationId, string botId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBots.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    Task<BotList> GetIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get BotconnectorIntegrationIdBotsSummaries.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    Task<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsync(string integrationId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ClientApps.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ClientAppEntityListing> GetIntegrationsClientAppsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ClientAppsUnifiedCommunications.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<UCIntegrationListing> GetIntegrationsClientAppsUnifiedCommunicationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Credential.
    /// </summary>
    /// <param name="credentialId">The credential ID</param>
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
    /// <param name="integrationId">The integration ID</param>
    Task<AudioConnectorIntegration> GetIntegrationsSpeechAudioconnectorIntegrationIdAsync(string integrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowAgent.
    /// </summary>
    /// <param name="agentId">The agent id</param>
    Task<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowAgents.
    /// </summary>
    /// <param name="name">The name</param>
    Task<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowCxAgent.
    /// </summary>
    /// <param name="agentId">The agent id</param>
    Task<DialogflowCXAgent> GetIntegrationsSpeechDialogflowCxAgentAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechDialogflowCxAgents.
    /// </summary>
    /// <param name="name">The name</param>
    Task<DialogflowCXAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowCxAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexBotAlias.
    /// </summary>
    /// <param name="aliasId">The alias id</param>
    Task<LexBotAlias> GetIntegrationsSpeechLexBotAliasAsync(string aliasId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexBotBotIdAliases.
    /// </summary>
    /// <param name="botId">The bot ID</param>
    /// <param name="status">The status</param>
    /// <param name="name">The name</param>
    Task<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexBots.
    /// </summary>
    /// <param name="name">The name</param>
    Task<LexBotEntityListing> GetIntegrationsSpeechLexBotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexV2BotAlias.
    /// </summary>
    /// <param name="aliasId">The alias id</param>
    Task<LexV2BotAlias> GetIntegrationsSpeechLexV2BotAliasAsync(string aliasId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexV2BotBotIdAliases.
    /// </summary>
    /// <param name="botId">The bot ID</param>
    /// <param name="status">The status</param>
    /// <param name="name">The name</param>
    Task<LexV2BotAliasEntityListing> GetIntegrationsSpeechLexV2BotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechLexV2Bots.
    /// </summary>
    /// <param name="name">The name</param>
    Task<LexV2BotEntityListing> GetIntegrationsSpeechLexV2BotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBot.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="botId">The bot ID</param>
    /// <param name="expands">Expand options</param>
    /// <param name="targetChannel">The targetChannel</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotAsync(string nuanceIntegrationId, string botId, IList<string> expands = null, string targetChannel = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotJob.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="botId">The bot ID</param>
    /// <param name="jobId">The job id</param>
    Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotJobAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotJobResults.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="botId">The bot ID</param>
    /// <param name="jobId">The job id</param>
    Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotJobResultsAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBots.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotsJob.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="jobId">The job id</param>
    Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotsJobAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechNuanceIntegrationIdBotsJobResults.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="jobId">The job id</param>
    Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsJobResultsAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechSttEngine.
    /// </summary>
    /// <param name="engineId">The engine id</param>
    Task<SttEngineEntity> GetIntegrationsSpeechSttEngineAsync(string engineId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechSttEngines.
    /// </summary>
    /// <param name="name">The name</param>
    Task<SttEngineEntityListing> GetIntegrationsSpeechSttEnginesAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngine.
    /// </summary>
    /// <param name="engineId">The engine id</param>
    Task<TtsEngineEntity> GetIntegrationsSpeechTtsEngineAsync(string engineId, bool? includeVoices = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngineVoice.
    /// </summary>
    /// <param name="engineId">The engine id</param>
    /// <param name="voiceId">The voice id</param>
    Task<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceAsync(string engineId, string voiceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngineVoices.
    /// </summary>
    /// <param name="engineId">The engine id</param>
    Task<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesAsync(string engineId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsEngines.
    /// </summary>
    /// <param name="name">The name</param>
    /// <param name="language">The language</param>
    Task<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesAsync(int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SpeechTtsSettings.
    /// </summary>
    Task<TtsSettings> GetIntegrationsSpeechTtsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Type.
    /// </summary>
    /// <param name="typeId">The type id</param>
    Task<IntegrationType> GetIntegrationsTypeAsync(string typeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get TypeConfigSchema.
    /// </summary>
    /// <param name="typeId">The type id</param>
    /// <param name="configType">The configType</param>
    Task<JsonSchemaDocument> GetIntegrationsTypeConfigSchemaAsync(string typeId, string configType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Types.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<IntegrationTypeEntityListing> GetIntegrationsTypesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get UnifiedcommunicationsClientapp.
    /// </summary>
    /// <param name="ucIntegrationId">The ucintegration id</param>
    Task<UnifiedCommunicationsIntegration> GetIntegrationsUnifiedcommunicationsClientappAsync(string ucIntegrationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get UnifiedcommunicationsClientapps.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<UnifiedCommunicationsIntegrationListing> GetIntegrationsUnifiedcommunicationsClientappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Userapps.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="appHost">The appHost</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<UserAppEntityListing> GetIntegrationsUserappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, string appHost = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Integration.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="body">Request body</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expands">Expand options</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Integration> UpdateIntegrationAsync(string integrationId, Integration body, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expands = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Action.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<ActionModel> PatchIntegrationsActionAsync(string actionId, UpdateActionInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update ActionDraft.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<ActionModel> PatchIntegrationsActionDraftAsync(string actionId, UpdateDraftInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Integration.
    /// </summary>
    /// <param name="body">Request body</param>
    Task<Integration> CreateIntegrationAsync(CreateIntegrationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraft.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    Task<ActionModel> PostIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraftFunctionUpload.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync(string actionId, FunctionUploadRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraftPublish.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<ActionModel> PostIntegrationsActionDraftPublishAsync(string actionId, PublishDraftInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionDraftTest.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<TestExecutionResult> PostIntegrationsActionDraftTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionExecute.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<object> PostIntegrationsActionExecuteAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionTest.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<TestExecutionResult> PostIntegrationsActionTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Action.
    /// </summary>
    /// <param name="body">Request body</param>
    Task<ActionModel> CreateIntegrationsActionAsync(PostActionInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ActionsDrafts.
    /// </summary>
    /// <param name="body">Request body</param>
    Task<ActionModel> CreateIntegrationsActionsDraftsAsync(PostActionInput body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Credentials.
    /// </summary>
    /// <param name="body">Request body</param>
    Task<CredentialInfo> CreateIntegrationsCredentialsAsync(Credential body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SpeechNuanceNuanceIntegrationIdBotJobs.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="botId">The bot ID</param>
    /// <param name="expands">Expand options</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AsyncJob> CreateIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsync(string nuanceIntegrationId, string botId, IList<string> expands = null, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SpeechNuanceIntegrationIdBotsJobs.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    Task<AsyncJob> CreateIntegrationsSpeechNuanceIntegrationIdBotsJobsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SpeechNuanceIntegrationIdBotsLaunchValidate.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="settings">The settings</param>
    Task<object> CreateIntegrationsSpeechNuanceIntegrationIdBotsLaunchValidateAsync(string nuanceIntegrationId, BotExecutionConfiguration settings, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create WebhookEvents.
    /// </summary>
    /// <param name="tokenId">The token ID</param>
    /// <param name="body">Request body</param>
    Task<WebhookInvocationResponse> CreateIntegrationsWebhookEventsAsync(string tokenId, object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update IntegrationConfigCurrent.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="body">Request body</param>
    Task<IntegrationConfiguration> UpdateIntegrationConfigCurrentAsync(string integrationId, IntegrationConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update ActionDraftFunction.
    /// </summary>
    /// <param name="actionId">The action ID</param>
    /// <param name="body">Request body</param>
    Task<FunctionConfig> UpdateIntegrationsActionDraftFunctionAsync(string actionId, Function body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update BotconnectorIntegrationIdBots.
    /// </summary>
    /// <param name="integrationId">The integration ID</param>
    /// <param name="botList">The botList</param>
    Task<object> PutIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, BotList botList, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Credential.
    /// </summary>
    /// <param name="credentialId">The credential ID</param>
    /// <param name="body">Request body</param>
    Task<CredentialInfo> UpdateIntegrationsCredentialAsync(string credentialId, Credential body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update SpeechNuanceIntegrationBotsLaunchSettings.
    /// </summary>
    /// <param name="nuanceIntegrationId">The Nuance integration ID</param>
    /// <param name="settings">The settings</param>
    Task<object> UpdateIntegrationsSpeechNuanceIntegrationBotsLaunchSettingsAsync(string nuanceIntegrationId, NuanceBotLaunchSettings settings, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update SpeechTtsSettings.
    /// </summary>
    /// <param name="body">Request body</param>
    Task<TtsSettings> UpdateIntegrationsSpeechTtsSettingsAsync(TtsSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update UnifiedcommunicationsThirdPartyPresences.
    /// </summary>
    /// <param name="ucIntegrationId">The ucintegration id</param>
    Task<string> UpdateIntegrationsUnifiedcommunicationsThirdPartyPresencesAsync(string ucIntegrationId, IEnumerable<UCThirdPartyPresence> body, CancellationToken cancellationToken = default);
}
