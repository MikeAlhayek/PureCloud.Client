using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Contracts;

public interface ILanguageUnderstandingApi
{
    /// <summary>
    /// Delete an NLU Domain.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if successful.</returns>
    Task<bool> DeleteLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the feedback on the NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="feedbackId">ID of the Feedback</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if successful.</returns>
    Task<bool> DeleteLanguageUnderstandingDomainFeedbackAsync(string domainId, string feedbackId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an NLU Domain Version
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if successful.</returns>
    Task<bool> DeleteLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a miner.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if successful.</returns>
    Task<bool> DeleteLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a draft
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="draftId">Draft ID</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if successful.</returns>
    Task<bool> DeleteLanguageUnderstandingMinerDraftAsync(string minerId, string draftId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Find an NLU Domain.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain.</returns>
    Task<NluDomain> GetLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all feedback in the given NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="intentName">The top intent name to retrieve feedback for.</param>
    /// <param name="assessment">The top assessment to retrieve feedback for.</param>
    /// <param name="dateStart">Begin of time window as ISO-8601 date.</param>
    /// <param name="dateEnd">End of time window as ISO-8601 date.</param>
    /// <param name="includeDeleted">Whether to include soft-deleted items in the result.</param>
    /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br.</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="enableCursorPagination">Enable Cursor Pagination</param>
    /// <param name="includeTrainingUtterances">Include Training Utterances. By default they're included.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination=true</param>
    /// <param name="fields">Fields and properties to get, comma-separated</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Feedback Listing.</returns>
    Task<NluFeedbackListing> GetLanguageUnderstandingDomainFeedbackAsync(string domainId, string intentName = null, string assessment = null, string dateStart = null, string dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, IEnumerable<string> fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Find a Feedback
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="feedbackId">ID of the Feedback</param>
    /// <param name="fields">Fields and properties to get, comma-separated</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Feedback Response.</returns>
    Task<NluFeedbackResponse> GetLanguageUnderstandingDomainFeedbackAsync(string domainId, string feedbackId, IEnumerable<string> fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Find an NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version.</returns>
    Task<NluDomainVersion> GetLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, bool? includeUtterances = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieved quality report for the specified NLU Domain Version
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version Quality Report.</returns>
    Task<NluDomainVersionQualityReport> GetLanguageUnderstandingDomainVersionReportAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all NLU Domain Versions for a given Domain.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response.</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version Listing.</returns>
    Task<NluDomainVersionListing> GetLanguageUnderstandingDomainVersionsAsync(string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all NLU Domains.
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Listing.</returns>
    Task<NluDomainListing> GetLanguageUnderstandingDomainsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get information about a miner.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner.</returns>
    Task<Miner> GetLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get information about a draft.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="draftId">Draft ID</param>
    /// <param name="draftIntentId">Parameter to filter a specific intent.</param>
    /// <param name="draftTopicId">Parameter to filter a specific topic.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Draft.</returns>
    Task<Draft> GetLanguageUnderstandingMinerDraftAsync(string minerId, string draftId, string draftIntentId = null, string draftTopicId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve the list of drafts created.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Draft Listing.</returns>
    Task<DraftListing> GetLanguageUnderstandingMinerDraftsAsync(string minerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get information about a mined intent
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="intentId">The ID of the intent to be retrieved.</param>
    /// <param name="expand">Option to fetch utterances</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner Intent.</returns>
    Task<MinerIntent> GetLanguageUnderstandingMinerIntentAsync(string minerId, string intentId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a list of mined intents.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="expand">Option to fetch utterances.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Mined Intents Listing.</returns>
    Task<MinedIntentsListing> GetLanguageUnderstandingMinerIntentsAsync(string minerId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves details of a particular topic.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="topicId">The ID of the topic to be retrieved.</param>
    /// <param name="expand">Option to fetch phrases</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner Topic.</returns>
    Task<MinerTopic> GetLanguageUnderstandingMinerTopicAsync(string minerId, string topicId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves utterances related to a phrase in a topic.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="topicId">The ID of the topic to be retrieved.</param>
    /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner Topic Phrase.</returns>
    Task<MinerTopicPhrase> GetLanguageUnderstandingMinerTopicPhraseAsync(string minerId, string topicId, string phraseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a list of mined topics.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner Topics Listing.</returns>
    Task<MinerTopicsListing> GetLanguageUnderstandingMinerTopicsAsync(string minerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve the list of miners created.
    /// </summary>
    /// <param name="minerType">Type of miner, either intent or topic</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner Listing.</returns>
    Task<MinerListing> GetLanguageUnderstandingMinersAsync(string minerType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Organization Configuration
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Organization.</returns>
    Task<NluOrganization> GetLanguageUnderstandingSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an NLU Domain.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="body">The updated NLU Domain.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain.</returns>
    Task<NluDomain> UpdateLanguageUnderstandingDomainAsync(string domainId, NluDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save information for the draft. Either topic draft or intent draft should be sent.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="draftId">Draft ID</param>
    /// <param name="body">Draft request</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Draft.</returns>
    Task<Draft> UpdateLanguageUnderstandingMinerDraftAsync(string minerId, string draftId, DraftRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create feedback for the NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="body">The Feedback to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Feedback Response.</returns>
    Task<NluFeedbackResponse> CreateLanguageUnderstandingDomainFeedbackAsync(string domainId, NluFeedbackRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="body">The input data to perform detection on.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Detection Response.</returns>
    Task<NluDetectionResponse> CreateLanguageUnderstandingDomainVersionDetectAsync(string domainId, string domainVersionId, NluDetectionRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publish the draft NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version.</returns>
    Task<NluDomainVersion> CreateLanguageUnderstandingDomainVersionPublishAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Train the draft NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version Training Response.</returns>
    Task<NluDomainVersionTrainingResponse> CreateLanguageUnderstandingDomainVersionTrainAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="body">The NLU Domain Version to create.</param>
    /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version.</returns>
    Task<NluDomainVersion> CreateLanguageUnderstandingDomainVersionsAsync(string domainId, NluDomainVersion body, bool? includeUtterances = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an NLU Domain.
    /// </summary>
    /// <param name="body">The NLU Domain to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain.</returns>
    Task<NluDomain> CreateLanguageUnderstandingDomainsAsync(NluDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new draft resource.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">Details for creating draft resource</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Draft.</returns>
    Task<Draft> CreateLanguageUnderstandingMinerDraftsAsync(string minerId, Draft body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.
    /// </summary>
    /// <param name="minerId">Miner ID</param>
    /// <param name="body">Mining execution request</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner.</returns>
    Task<Miner> CreateLanguageUnderstandingMinerExecuteAsync(string minerId, MinerExecuteRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a unique miner.
    /// </summary>
    /// <param name="body">Details for creating a new miner resource.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Miner.</returns>
    Task<Miner> CreateLanguageUnderstandingMinersAsync(Miner body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an NLU Domain Version.
    /// </summary>
    /// <param name="domainId">ID of the NLU domain.</param>
    /// <param name="domainVersionId">ID of the NLU domain version.</param>
    /// <param name="body">The updated NLU Domain Version.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>NLU Domain Version.</returns>
    Task<NluDomainVersion> UpdateLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, NluDomainVersion body, CancellationToken cancellationToken = default);
}
