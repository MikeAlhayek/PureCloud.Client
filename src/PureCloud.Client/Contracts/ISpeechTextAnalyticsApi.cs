using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Represents speech and text analytics API operations
/// </summary>
public interface ISpeechTextAnalyticsApi
{
    // DELETE methods
    Task<bool> DeleteSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default);
    Task<bool> DeleteSpeechTextAnalyticsDictionaryFeedbackAsync(string dictionaryFeedbackId, CancellationToken cancellationToken = default);
    Task<DeleteProgramResponse> DeleteSpeechTextAnalyticsProgramAsync(string programId, bool? forceDelete = null, CancellationToken cancellationToken = default);
    Task<bool> DeleteSpeechTextAnalyticsSentimentFeedbackAsync(CancellationToken cancellationToken = default);
    Task<bool> DeleteSpeechTextAnalyticsSentimentFeedbackByIdAsync(string sentimentFeedbackId, CancellationToken cancellationToken = default);
    Task<bool> DeleteSpeechTextAnalyticsTopicAsync(string topicId, CancellationToken cancellationToken = default);

    // GET methods
    Task<CategoriesEntityListing> GetSpeechTextAnalyticsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);
    Task<StaCategory> GetSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default);
    Task<ConversationMetrics> GetSpeechTextAnalyticsConversationAsync(string conversationId, CancellationToken cancellationToken = default);
    Task<ConversationCategoriesEntityListing> GetSpeechTextAnalyticsConversationCategoriesAsync(string conversationId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);
    Task<TranscriptUrl> GetSpeechTextAnalyticsConversationCommunicationTranscriptUrlAsync(string conversationId, string communicationId, CancellationToken cancellationToken = default);
    Task<TranscriptUrls> GetSpeechTextAnalyticsConversationCommunicationTranscriptUrlsAsync(string conversationId, string communicationId, CancellationToken cancellationToken = default);
    Task<SpeechTextAnalyticsConversationSummaryListing> GetSpeechTextAnalyticsConversationSummariesAsync(string conversationId, CancellationToken cancellationToken = default);
    Task<DictionaryFeedbackEntityListing> GetSpeechTextAnalyticsDictionaryFeedbackAsync(string dialect = null, string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default);
    Task<DictionaryFeedback> GetSpeechTextAnalyticsDictionaryFeedbackByIdAsync(string dictionaryFeedbackId, CancellationToken cancellationToken = default);
    Task<Program> GetSpeechTextAnalyticsProgramAsync(string programId, CancellationToken cancellationToken = default);
    Task<ProgramMappings> GetSpeechTextAnalyticsProgramMappingsAsync(string programId, CancellationToken cancellationToken = default);
    Task<ProgramInsightsSettings> GetSpeechTextAnalyticsProgramSettingsInsightsAsync(string programId, CancellationToken cancellationToken = default);
    Task<ProgramTranscriptionEngines> GetSpeechTextAnalyticsProgramTranscriptionEnginesAsync(string programId, CancellationToken cancellationToken = default);
    Task<ProgramsEntityListing> GetSpeechTextAnalyticsProgramsAsync(string nextPage = null, int? pageSize = null, string state = null, CancellationToken cancellationToken = default);
    Task<GeneralProgramJob> GetSpeechTextAnalyticsProgramsGeneralJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<ProgramsMappingsEntityListing> GetSpeechTextAnalyticsProgramsMappingsAsync(string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default);
    Task<ProgramJob> GetSpeechTextAnalyticsProgramsPublishJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<ProgramInsightsSettingsEntityListing> GetSpeechTextAnalyticsProgramsSettingsInsightsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> programIds = null, CancellationToken cancellationToken = default);
    Task<SupportedDialectsEntityListing> GetSpeechTextAnalyticsProgramsTranscriptionEnginesDialectsAsync(CancellationToken cancellationToken = default);
    Task<UnpublishedProgramsEntityListing> GetSpeechTextAnalyticsProgramsUnpublishedAsync(string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default);
    Task<EntityListing> GetSpeechTextAnalyticsSentimentDialectsAsync(CancellationToken cancellationToken = default);
    Task<SentimentFeedbackEntityListing> GetSpeechTextAnalyticsSentimentFeedbackAsync(string dialect = null, CancellationToken cancellationToken = default);
    Task<SpeechTextAnalyticsSettingsResponse> GetSpeechTextAnalyticsSettingsAsync(CancellationToken cancellationToken = default);
    Task<Topic> GetSpeechTextAnalyticsTopicAsync(string topicId, CancellationToken cancellationToken = default);
    Task<TopicsEntityListing> GetSpeechTextAnalyticsTopicsAsync(string nextPage = null, int? pageSize = null, string state = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> dialects = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    Task<EntityListing> GetSpeechTextAnalyticsTopicsDialectsAsync(CancellationToken cancellationToken = default);
    Task<GeneralTopicsEntityListing> GetSpeechTextAnalyticsTopicsGeneralAsync(string dialect = null, CancellationToken cancellationToken = default);
    Task<UnifiedGeneralTopicEntityListing> GetSpeechTextAnalyticsTopicsGeneralStatusAsync(string dialect = null, CancellationToken cancellationToken = default);
    Task<TopicJob> GetSpeechTextAnalyticsTopicsPublishJobAsync(string jobId, CancellationToken cancellationToken = default);
    Task<CommunicationTranslationList> GetSpeechTextAnalyticsTranslationsLanguageConversationAsync(string languageId, string conversationId, string communicationId = null, string recordingId = null, CancellationToken cancellationToken = default);
    Task<TranslateSupportedLanguageList> GetSpeechTextAnalyticsTranslationsLanguagesAsync(CancellationToken cancellationToken = default);

    // UPDATE methods (PATCH)
    Task<SpeechTextAnalyticsSettingsResponse> UpdateSpeechTextAnalyticsSettingsAsync(SpeechTextAnalyticsSettingsRequest body, CancellationToken cancellationToken = default);

    // CREATE methods (POST)
    Task<StaCategory> CreateSpeechTextAnalyticsCategoryAsync(CategoryRequest body, CancellationToken cancellationToken = default);
    Task<DictionaryFeedback> CreateSpeechTextAnalyticsDictionaryFeedbackAsync(DictionaryFeedback body, CancellationToken cancellationToken = default);
    Task<Program> CreateSpeechTextAnalyticsProgramAsync(ProgramRequest body, CancellationToken cancellationToken = default);
    Task<GeneralProgramJob> CreateSpeechTextAnalyticsProgramsGeneralJobAsync(GeneralProgramJobRequest body, CancellationToken cancellationToken = default);
    Task<ProgramJob> CreateSpeechTextAnalyticsProgramsPublishJobAsync(ProgramJobRequest body, CancellationToken cancellationToken = default);
    Task<SentimentFeedback> CreateSpeechTextAnalyticsSentimentFeedbackAsync(SentimentFeedback body, CancellationToken cancellationToken = default);
    Task<Topic> CreateSpeechTextAnalyticsTopicAsync(TopicRequest body, CancellationToken cancellationToken = default);
    Task<TopicJob> CreateSpeechTextAnalyticsTopicsPublishJobAsync(TopicJobRequest body, CancellationToken cancellationToken = default);
    Task<JsonSearchResponse> CreateSpeechTextAnalyticsTranscriptsSearchAsync(TranscriptSearchRequest body, CancellationToken cancellationToken = default);

    // UPDATE methods (PUT)
    Task<StaCategory> UpdateSpeechTextAnalyticsCategoryAsync(string categoryId, CategoryRequest body, CancellationToken cancellationToken = default);
    Task<DictionaryFeedback> UpdateSpeechTextAnalyticsDictionaryFeedbackAsync(string dictionaryFeedbackId, DictionaryFeedback body = null, CancellationToken cancellationToken = default);
    Task<Program> UpdateSpeechTextAnalyticsProgramAsync(string programId, ProgramRequest body, CancellationToken cancellationToken = default);
    Task<ProgramMappings> UpdateSpeechTextAnalyticsProgramMappingsAsync(string programId, ProgramMappingsRequest body, CancellationToken cancellationToken = default);
    Task<ProgramInsightsSettings> UpdateSpeechTextAnalyticsProgramSettingsInsightsAsync(string programId, InsightsSettingsRequest body, CancellationToken cancellationToken = default);
    Task<ProgramTranscriptionEngines> UpdateSpeechTextAnalyticsProgramTranscriptionEnginesAsync(string programId, TranscriptionEnginesRequest body, CancellationToken cancellationToken = default);
    Task<SpeechTextAnalyticsSettingsResponse> UpdateSpeechTextAnalyticsSettingsFullAsync(SpeechTextAnalyticsSettingsRequest body, CancellationToken cancellationToken = default);
    Task<Topic> UpdateSpeechTextAnalyticsTopicAsync(string topicId, TopicRequest body, CancellationToken cancellationToken = default);
}