using PureCloud.Client.Models;
using ActionModel = PureCloud.Client.Models.Action;

namespace PureCloud.Client.Contracts;

public interface IIntegrationsApi
{
    Task<Integration> DeleteIntegrationAsync(string integrationId, CancellationToken cancellationToken = default);

    Task<object> DeleteIntegrationsActionAsync(string actionId, CancellationToken cancellationToken = default);

    Task<object> DeleteIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default);

    Task<object> DeleteIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default);

    Task<Integration> GetIntegrationAsync(string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<IntegrationConfiguration> GetIntegrationConfigCurrentAsync(string integrationId, CancellationToken cancellationToken = default);

    Task<IntegrationEntityListing> GetIntegrationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<Actions> GetIntegrationsActionAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default);

    Task<Actions> GetIntegrationsActionDraftAsync(string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null, CancellationToken cancellationToken = default);

    Task<FunctionConfig> GetIntegrationsActionDraftFunctionAsync(string actionId, CancellationToken cancellationToken = default);

    Task<JsonSchemaDocument> GetIntegrationsActionDraftSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default);

    Task<string> GetIntegrationsActionDraftTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default);

    Task<DraftValidationResult> GetIntegrationsActionDraftValidationAsync(string actionId, CancellationToken cancellationToken = default);

    Task<FunctionConfig> GetIntegrationsActionFunctionAsync(string actionId, CancellationToken cancellationToken = default);

    Task<JsonSchemaDocument> GetIntegrationsActionSchemaAsync(string actionId, string fileName, bool? flatten = null, CancellationToken cancellationToken = default);

    Task<string> GetIntegrationsActionTemplateAsync(string actionId, string fileName, CancellationToken cancellationToken = default);

    Task<ActionEntityListing> GetIntegrationsActionsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default);

    Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null, CancellationToken cancellationToken = default);

    Task<ActionCertificateListing> GetIntegrationsActionsCertificatesAsync(string status = null, string type = null, CancellationToken cancellationToken = default);

    Task<TrustedCertificates> GetIntegrationsActionsCertificatesTruststoreAsync(CancellationToken cancellationToken = default);

    Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync(int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null, CancellationToken cancellationToken = default);

    Task<IList<FunctionRuntime>> GetIntegrationsActionsFunctionsRuntimesAsync(CancellationToken cancellationToken = default);

    Task<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotAsync(string integrationId, string botId, string version = null, CancellationToken cancellationToken = default);

    Task<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsync(string integrationId, string botId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<BotList> GetIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, CancellationToken cancellationToken = default);

    Task<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsync(string integrationId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<ClientAppEntityListing> GetIntegrationsClientAppsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<UCIntegrationListing> GetIntegrationsClientAppsUnifiedCommunicationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<Credential> GetIntegrationsCredentialAsync(string credentialId, CancellationToken cancellationToken = default);

    Task<CredentialInfoListing> GetIntegrationsCredentialsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<CredentialTypeListing> GetIntegrationsCredentialsTypesAsync(CancellationToken cancellationToken = default);

    Task<AudioConnectorIntegrationEntityListing> GetIntegrationsSpeechAudioconnectorAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AudioConnectorIntegration> GetIntegrationsSpeechAudioconnectorIntegrationIdAsync(string integrationId, CancellationToken cancellationToken = default);

    Task<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentAsync(string agentId, CancellationToken cancellationToken = default);

    Task<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<DialogflowCXAgent> GetIntegrationsSpeechDialogflowCxAgentAsync(string agentId, CancellationToken cancellationToken = default);

    Task<DialogflowCXAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowCxAgentsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<LexBotAlias> GetIntegrationsSpeechLexBotAliasAsync(string aliasId, CancellationToken cancellationToken = default);

    Task<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default);

    Task<LexBotEntityListing> GetIntegrationsSpeechLexBotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<LexV2BotAlias> GetIntegrationsSpeechLexV2BotAliasAsync(string aliasId, CancellationToken cancellationToken = default);

    Task<LexV2BotAliasEntityListing> GetIntegrationsSpeechLexV2BotBotIdAliasesAsync(string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null, CancellationToken cancellationToken = default);

    Task<LexV2BotEntityListing> GetIntegrationsSpeechLexV2BotsAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotAsync(string nuanceIntegrationId, string botId, IList<string> expand = null, string targetChannel = null, CancellationToken cancellationToken = default);

    Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotJobAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default);

    Task<NuanceBot> GetIntegrationsSpeechNuanceIntegrationIdBotJobResultsAsync(string nuanceIntegrationId, string botId, string jobId, CancellationToken cancellationToken = default);

    Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default);

    Task<AsyncJob> GetIntegrationsSpeechNuanceIntegrationIdBotsJobAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default);

    Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceIntegrationIdBotsJobResultsAsync(string nuanceIntegrationId, string jobId, CancellationToken cancellationToken = default);

    Task<SttEngineEntity> GetIntegrationsSpeechSttEngineAsync(string engineId, CancellationToken cancellationToken = default);

    Task<SttEngineEntityListing> GetIntegrationsSpeechSttEnginesAsync(int? pageNumber = null, int? pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<TtsEngineEntity> GetIntegrationsSpeechTtsEngineAsync(string engineId, bool? includeVoices = null, CancellationToken cancellationToken = default);

    Task<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceAsync(string engineId, string voiceId, CancellationToken cancellationToken = default);

    Task<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesAsync(string engineId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesAsync(int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null, CancellationToken cancellationToken = default);

    Task<TtsSettings> GetIntegrationsSpeechTtsSettingsAsync(CancellationToken cancellationToken = default);

    Task<IntegrationType> GetIntegrationsTypeAsync(string typeId, CancellationToken cancellationToken = default);

    Task<JsonSchemaDocument> GetIntegrationsTypeConfigSchemaAsync(string typeId, string configType, CancellationToken cancellationToken = default);

    Task<IntegrationTypeEntityListing> GetIntegrationsTypesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<UnifiedCommunicationsIntegration> GetIntegrationsUnifiedcommunicationsClientappAsync(string ucIntegrationId, CancellationToken cancellationToken = default);

    Task<UnifiedCommunicationsIntegrationListing> GetIntegrationsUnifiedcommunicationsClientappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<UserAppEntityListing> GetIntegrationsUserappsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null, CancellationToken cancellationToken = default);

    Task<Integration> UpdateIntegrationAsync(string integrationId, Integration body, int? pageSize = null, int? pageNumber = null, string sortBy = null, IList<string> expand = null, string nextPage = null, string previousPage = null, CancellationToken cancellationToken = default);

    Task<ActionModel> PatchIntegrationsActionAsync(string actionId, UpdateActionInput body, CancellationToken cancellationToken = default);

    Task<ActionModel> PatchIntegrationsActionDraftAsync(string actionId, UpdateDraftInput body, CancellationToken cancellationToken = default);

    Task<Integration> CreateIntegrationAsync(CreateIntegrationRequest body, CancellationToken cancellationToken = default);

    Task<ActionModel> PostIntegrationsActionDraftAsync(string actionId, CancellationToken cancellationToken = default);

    Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync(string actionId, FunctionUploadRequest body, CancellationToken cancellationToken = default);

    Task<ActionModel> PostIntegrationsActionDraftPublishAsync(string actionId, PublishDraftInput body, CancellationToken cancellationToken = default);

    Task<TestExecutionResult> PostIntegrationsActionDraftTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    Task<object> PostIntegrationsActionExecuteAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    Task<TestExecutionResult> PostIntegrationsActionTestAsync(string actionId, object body, bool? flatten = null, CancellationToken cancellationToken = default);

    Task<ActionModel> CreateIntegrationsActionAsync(PostActionInput body, CancellationToken cancellationToken = default);

    Task<ActionModel> CreateIntegrationsActionsDraftsAsync(PostActionInput body, CancellationToken cancellationToken = default);

    Task<CredentialInfo> CreateIntegrationsCredentialsAsync(Credential body = null, CancellationToken cancellationToken = default);

    Task<AsyncJob> CreateIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsync(string nuanceIntegrationId, string botId, IList<string> expand = null, string body = null, CancellationToken cancellationToken = default);

    Task<AsyncJob> CreateIntegrationsSpeechNuanceIntegrationIdBotsJobsAsync(string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null, CancellationToken cancellationToken = default);

    Task<object> CreateIntegrationsSpeechNuanceIntegrationIdBotsLaunchValidateAsync(string nuanceIntegrationId, BotExecutionConfiguration settings, CancellationToken cancellationToken = default);

    Task<WebhookInvocationResponse> CreateIntegrationsWebhookEventsAsync(string tokenId, object body, CancellationToken cancellationToken = default);

    Task<IntegrationConfiguration> UpdateIntegrationConfigCurrentAsync(string integrationId, IntegrationConfiguration body, CancellationToken cancellationToken = default);

    Task<FunctionConfig> UpdateIntegrationsActionDraftFunctionAsync(string actionId, Function body, CancellationToken cancellationToken = default);

    Task<object> PutIntegrationsBotconnectorIntegrationIdBotsAsync(string integrationId, BotList botList, CancellationToken cancellationToken = default);

    Task<CredentialInfo> UpdateIntegrationsCredentialAsync(string credentialId, Credential body, CancellationToken cancellationToken = default);

    Task<object> UpdateIntegrationsSpeechNuanceIntegrationBotsLaunchSettingsAsync(string nuanceIntegrationId, NuanceBotLaunchSettings settings, CancellationToken cancellationToken = default);

    Task<TtsSettings> UpdateIntegrationsSpeechTtsSettingsAsync(TtsSettings body, CancellationToken cancellationToken = default);

    Task<string> UpdateIntegrationsUnifiedcommunicationsThirdPartyPresencesAsync(string ucIntegrationId, IEnumerable<UCThirdPartyPresence> body, CancellationToken cancellationToken = default);
}
