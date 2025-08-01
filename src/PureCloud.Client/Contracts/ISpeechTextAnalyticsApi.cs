using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Represents speech and text analytics API operations
/// </summary>
public interface ISpeechTextAnalyticsApi
{
    // DELETE methods
    /// <summary>
    /// Deletes a speech and text analytics category
    /// </summary>
    /// <param name="categoryId">The ID of the category to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the category was successfully deleted</returns>
    Task<bool> DeleteSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes dictionary feedback for speech and text analytics
    /// </summary>
    /// <param name="dictionaryFeedbackId">The ID of the dictionary feedback to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the dictionary feedback was successfully deleted</returns>
    Task<bool> DeleteSpeechTextAnalyticsDictionaryFeedbackAsync(string dictionaryFeedbackId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program to delete</param>
    /// <param name="forceDelete">Indicates whether to force delete the program</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The delete program response</returns>
    Task<DeleteProgramResponse> DeleteSpeechTextAnalyticsProgramAsync(string programId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes all sentiment feedback for speech and text analytics
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the sentiment feedback was successfully deleted</returns>
    Task<bool> DeleteSpeechTextAnalyticsSentimentFeedbackAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes sentiment feedback by ID for speech and text analytics
    /// </summary>
    /// <param name="sentimentFeedbackId">The ID of the sentiment feedback to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the sentiment feedback was successfully deleted</returns>
    Task<bool> DeleteSpeechTextAnalyticsSentimentFeedbackByIdAsync(string sentimentFeedbackId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a speech and text analytics topic
    /// </summary>
    /// <param name="topicId">The ID of the topic to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the topic was successfully deleted</returns>
    Task<bool> DeleteSpeechTextAnalyticsTopicAsync(string topicId, CancellationToken cancellationToken = default);

    // GET methods
    /// <summary>
    /// Gets a list of speech and text analytics categories
    /// </summary>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="pageNumber">The page number to retrieve</param>
    /// <param name="name">Filter by category name</param>
    /// <param name="sortOrder">Sort order (asc/desc)</param>
    /// <param name="sortBy">Field to sort by</param>
    /// <param name="ids">List of category IDs to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of speech and text analytics categories</returns>
    Task<CategoriesEntityListing> GetSpeechTextAnalyticsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a specific speech and text analytics category
    /// </summary>
    /// <param name="categoryId">The ID of the category to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The speech and text analytics category</returns>
    Task<StaCategory> GetSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets conversation metrics for speech and text analytics
    /// </summary>
    /// <param name="conversationId">The ID of the conversation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The conversation metrics</returns>
    Task<ConversationMetrics> GetSpeechTextAnalyticsConversationAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets conversation categories for speech and text analytics
    /// </summary>
    /// <param name="conversationId">The ID of the conversation</param>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="pageNumber">The page number to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of conversation categories</returns>
    Task<ConversationCategoriesEntityListing> GetSpeechTextAnalyticsConversationCategoriesAsync(string conversationId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a transcript URL for a specific communication in a conversation
    /// </summary>
    /// <param name="conversationId">The ID of the conversation</param>
    /// <param name="communicationId">The ID of the communication</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The transcript URL</returns>
    Task<TranscriptUrl> GetSpeechTextAnalyticsConversationCommunicationTranscriptUrlAsync(string conversationId, string communicationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets transcript URLs for a specific communication in a conversation
    /// </summary>
    /// <param name="conversationId">The ID of the conversation</param>
    /// <param name="communicationId">The ID of the communication</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The transcript URLs</returns>
    Task<TranscriptUrls> GetSpeechTextAnalyticsConversationCommunicationTranscriptUrlsAsync(string conversationId, string communicationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets conversation summaries for speech and text analytics
    /// </summary>
    /// <param name="conversationId">The ID of the conversation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of conversation summaries</returns>
    Task<SpeechTextAnalyticsConversationSummaryListing> GetSpeechTextAnalyticsConversationSummariesAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets dictionary feedback for speech and text analytics
    /// </summary>
    /// <param name="dialect">Filter by dialect</param>
    /// <param name="nextPage">Next page cursor for pagination</param>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of dictionary feedback</returns>
    Task<DictionaryFeedbackEntityListing> GetSpeechTextAnalyticsDictionaryFeedbackAsync(string dialect = null, string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets specific dictionary feedback by ID for speech and text analytics
    /// </summary>
    /// <param name="dictionaryFeedbackId">The ID of the dictionary feedback to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The dictionary feedback</returns>
    Task<DictionaryFeedback> GetSpeechTextAnalyticsDictionaryFeedbackByIdAsync(string dictionaryFeedbackId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a specific speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The speech and text analytics program</returns>
    Task<Program> GetSpeechTextAnalyticsProgramAsync(string programId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets mappings for a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The program mappings</returns>
    Task<ProgramMappings> GetSpeechTextAnalyticsProgramMappingsAsync(string programId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets insights settings for a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The program insights settings</returns>
    Task<ProgramInsightsSettings> GetSpeechTextAnalyticsProgramSettingsInsightsAsync(string programId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets transcription engines for a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The program transcription engines</returns>
    Task<ProgramTranscriptionEngines> GetSpeechTextAnalyticsProgramTranscriptionEnginesAsync(string programId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of speech and text analytics programs
    /// </summary>
    /// <param name="nextPage">Next page cursor for pagination</param>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="state">Filter by program state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of speech and text analytics programs</returns>
    Task<ProgramsEntityListing> GetSpeechTextAnalyticsProgramsAsync(string nextPage = null, int? pageSize = null, string state = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a general program job for speech and text analytics
    /// </summary>
    /// <param name="jobId">The ID of the job to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The general program job</returns>
    Task<GeneralProgramJob> GetSpeechTextAnalyticsProgramsGeneralJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets mappings for all speech and text analytics programs
    /// </summary>
    /// <param name="nextPage">Next page cursor for pagination</param>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of program mappings</returns>
    Task<ProgramsMappingsEntityListing> GetSpeechTextAnalyticsProgramsMappingsAsync(string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a publish job for speech and text analytics programs
    /// </summary>
    /// <param name="jobId">The ID of the job to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The program publish job</returns>
    Task<ProgramJob> GetSpeechTextAnalyticsProgramsPublishJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets insights settings for all speech and text analytics programs
    /// </summary>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="pageNumber">The page number to retrieve</param>
    /// <param name="programIds">List of program IDs to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of program insights settings</returns>
    Task<ProgramInsightsSettingsEntityListing> GetSpeechTextAnalyticsProgramsSettingsInsightsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> programIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets supported dialects for speech and text analytics transcription engines
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of supported dialects</returns>
    Task<SupportedDialectsEntityListing> GetSpeechTextAnalyticsProgramsTranscriptionEnginesDialectsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets unpublished speech and text analytics programs
    /// </summary>
    /// <param name="nextPage">Next page cursor for pagination</param>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of unpublished programs</returns>
    Task<UnpublishedProgramsEntityListing> GetSpeechTextAnalyticsProgramsUnpublishedAsync(string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets sentiment dialects for speech and text analytics
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of sentiment dialects</returns>
    Task<EntityListing> GetSpeechTextAnalyticsSentimentDialectsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets sentiment feedback for speech and text analytics
    /// </summary>
    /// <param name="dialect">Filter by dialect</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of sentiment feedback</returns>
    Task<SentimentFeedbackEntityListing> GetSpeechTextAnalyticsSentimentFeedbackAsync(string dialect = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets speech and text analytics settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The speech and text analytics settings</returns>
    Task<SpeechTextAnalyticsSettingsResponse> GetSpeechTextAnalyticsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a specific speech and text analytics topic
    /// </summary>
    /// <param name="topicId">The ID of the topic to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The speech and text analytics topic</returns>
    Task<Topic> GetSpeechTextAnalyticsTopicAsync(string topicId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of speech and text analytics topics
    /// </summary>
    /// <param name="nextPage">Next page cursor for pagination</param>
    /// <param name="pageSize">The number of results per page</param>
    /// <param name="state">Filter by topic state</param>
    /// <param name="name">Filter by topic name</param>
    /// <param name="ids">List of topic IDs to filter by</param>
    /// <param name="dialects">List of dialects to filter by</param>
    /// <param name="sortBy">Field to sort by</param>
    /// <param name="sortOrder">Sort order (asc/desc)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of speech and text analytics topics</returns>
    Task<TopicsEntityListing> GetSpeechTextAnalyticsTopicsAsync(string nextPage = null, int? pageSize = null, string state = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> dialects = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets dialects for speech and text analytics topics
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of topic dialects</returns>
    Task<EntityListing> GetSpeechTextAnalyticsTopicsDialectsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets general topics for speech and text analytics
    /// </summary>
    /// <param name="dialect">Filter by dialect</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of general topics</returns>
    Task<GeneralTopicsEntityListing> GetSpeechTextAnalyticsTopicsGeneralAsync(string dialect = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets status of general topics for speech and text analytics
    /// </summary>
    /// <param name="dialect">Filter by dialect</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A listing of unified general topic status</returns>
    Task<UnifiedGeneralTopicEntityListing> GetSpeechTextAnalyticsTopicsGeneralStatusAsync(string dialect = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a publish job for speech and text analytics topics
    /// </summary>
    /// <param name="jobId">The ID of the job to retrieve</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The topic publish job</returns>
    Task<TopicJob> GetSpeechTextAnalyticsTopicsPublishJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets translation for a specific language and conversation
    /// </summary>
    /// <param name="languageId">The ID of the language</param>
    /// <param name="conversationId">The ID of the conversation</param>
    /// <param name="communicationId">The ID of the communication</param>
    /// <param name="recordingId">The ID of the recording</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of communication translations</returns>
    Task<CommunicationTranslationList> GetSpeechTextAnalyticsTranslationsLanguageConversationAsync(string languageId, string conversationId, string communicationId = null, string recordingId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets supported languages for speech and text analytics translations
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of supported languages for translation</returns>
    Task<TranslateSupportedLanguageList> GetSpeechTextAnalyticsTranslationsLanguagesAsync(CancellationToken cancellationToken = default);

    // UPDATE methods (PATCH)
    /// <summary>
    /// Updates speech and text analytics settings using partial update
    /// </summary>
    /// <param name="body">The settings update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated speech and text analytics settings</returns>
    Task<SpeechTextAnalyticsSettingsResponse> UpdateSpeechTextAnalyticsSettingsAsync(SpeechTextAnalyticsSettingsRequest body, CancellationToken cancellationToken = default);

    // CREATE methods (POST)
    /// <summary>
    /// Creates a new speech and text analytics category
    /// </summary>
    /// <param name="body">The category creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created speech and text analytics category</returns>
    Task<StaCategory> CreateSpeechTextAnalyticsCategoryAsync(CategoryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates new dictionary feedback for speech and text analytics
    /// </summary>
    /// <param name="body">The dictionary feedback to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created dictionary feedback</returns>
    Task<DictionaryFeedback> CreateSpeechTextAnalyticsDictionaryFeedbackAsync(DictionaryFeedback body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new speech and text analytics program
    /// </summary>
    /// <param name="body">The program creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created speech and text analytics program</returns>
    Task<Program> CreateSpeechTextAnalyticsProgramAsync(ProgramRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a general job for speech and text analytics programs
    /// </summary>
    /// <param name="body">The general program job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created general program job</returns>
    Task<GeneralProgramJob> CreateSpeechTextAnalyticsProgramsGeneralJobAsync(GeneralProgramJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a publish job for speech and text analytics programs
    /// </summary>
    /// <param name="body">The program job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created program publish job</returns>
    Task<ProgramJob> CreateSpeechTextAnalyticsProgramsPublishJobAsync(ProgramJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates new sentiment feedback for speech and text analytics
    /// </summary>
    /// <param name="body">The sentiment feedback to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sentiment feedback</returns>
    Task<SentimentFeedback> CreateSpeechTextAnalyticsSentimentFeedbackAsync(SentimentFeedback body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new speech and text analytics topic
    /// </summary>
    /// <param name="body">The topic creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created speech and text analytics topic</returns>
    Task<Topic> CreateSpeechTextAnalyticsTopicAsync(TopicRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a publish job for speech and text analytics topics
    /// </summary>
    /// <param name="body">The topic job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created topic publish job</returns>
    Task<TopicJob> CreateSpeechTextAnalyticsTopicsPublishJobAsync(TopicJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a search for speech and text analytics transcripts
    /// </summary>
    /// <param name="body">The transcript search request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The search response with transcript results</returns>
    Task<JsonSearchResponse> CreateSpeechTextAnalyticsTranscriptsSearchAsync(TranscriptSearchRequest body, CancellationToken cancellationToken = default);

    // UPDATE methods (PUT)
    /// <summary>
    /// Updates a speech and text analytics category
    /// </summary>
    /// <param name="categoryId">The ID of the category to update</param>
    /// <param name="body">The category update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated speech and text analytics category</returns>
    Task<StaCategory> UpdateSpeechTextAnalyticsCategoryAsync(string categoryId, CategoryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates dictionary feedback for speech and text analytics
    /// </summary>
    /// <param name="dictionaryFeedbackId">The ID of the dictionary feedback to update</param>
    /// <param name="body">The dictionary feedback update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated dictionary feedback</returns>
    Task<DictionaryFeedback> UpdateSpeechTextAnalyticsDictionaryFeedbackAsync(string dictionaryFeedbackId, DictionaryFeedback body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program to update</param>
    /// <param name="body">The program update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated speech and text analytics program</returns>
    Task<Program> UpdateSpeechTextAnalyticsProgramAsync(string programId, ProgramRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates mappings for a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program</param>
    /// <param name="body">The program mappings update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated program mappings</returns>
    Task<ProgramMappings> UpdateSpeechTextAnalyticsProgramMappingsAsync(string programId, ProgramMappingsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates insights settings for a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program</param>
    /// <param name="body">The insights settings update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated program insights settings</returns>
    Task<ProgramInsightsSettings> UpdateSpeechTextAnalyticsProgramSettingsInsightsAsync(string programId, InsightsSettingsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates transcription engines for a speech and text analytics program
    /// </summary>
    /// <param name="programId">The ID of the program</param>
    /// <param name="body">The transcription engines update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated program transcription engines</returns>
    Task<ProgramTranscriptionEngines> UpdateSpeechTextAnalyticsProgramTranscriptionEnginesAsync(string programId, TranscriptionEnginesRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates speech and text analytics settings using full update
    /// </summary>
    /// <param name="body">The complete settings update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated speech and text analytics settings</returns>
    Task<SpeechTextAnalyticsSettingsResponse> UpdateSpeechTextAnalyticsSettingsFullAsync(SpeechTextAnalyticsSettingsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a speech and text analytics topic
    /// </summary>
    /// <param name="topicId">The ID of the topic to update</param>
    /// <param name="body">The topic update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated speech and text analytics topic</returns>
    Task<Topic> UpdateSpeechTextAnalyticsTopicAsync(string topicId, TopicRequest body, CancellationToken cancellationToken = default);
}
