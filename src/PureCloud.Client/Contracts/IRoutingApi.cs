using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
    /// <summary>
    /// Query for queue observations
    /// </summary>
    /// <param name="body">Query criteria</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue observation query response</returns>
    Task<QueueObservationQueryResponse> CreateAnalyticsQueuesObservationsQueryAsync(QueueObservationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for user activity observations
    /// </summary>
    /// <param name="body">Query criteria</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing activity query response</returns>
    Task<RoutingActivityResponse> CreateAnalyticsRoutingActivityQueryAsync(RoutingActivityQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment
    /// </summary>
    /// <param name="body">Benefit assessment request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment</returns>
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Submit a request to create a benefit assessment job
    /// </summary>
    /// <param name="body">Benefit assessment job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment job</returns>
    Task<BenefitAssessmentJob> CreateRoutingAssessmentsJobsAsync(CreateBenefitAssessmentJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an email domain
    /// </summary>
    /// <param name="body">Inbound domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a route for an email domain
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="body">Inbound route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create routes for an email domain
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="body">Inbound route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> CreateRoutingEmailDomainRoutesAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test the connection settings for an email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Test message</returns>
    Task<TestMessage> CreateRoutingEmailDomainTestconnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an outbound email domain
    /// </summary>
    /// <param name="body">Inbound domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> CreateRoutingEmailOutboundDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a simulated outbound email domain
    /// </summary>
    /// <param name="body">Outbound domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email outbound domain result</returns>
    Task<EmailOutboundDomainResult> CreateRoutingEmailOutboundDomainsSimulatedAsync(OutboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a language
    /// </summary>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language</returns>
    Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a predictor
    /// </summary>
    /// <param name="body">Predictor request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor</returns>
    Task<Predictor> CreateRoutingPredictorsAsync(CreatePredictorRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a queue
    /// </summary>
    /// <param name="body">Queue request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> CreateRoutingQueueAsync(QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a queue
    /// </summary>
    /// <param name="body">Create queue request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> CreateRoutingQueueAsync(CreateQueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk add queue members
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue members</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member</returns>
    Task<QueueMember> CreateRoutingQueueMembersAsync(string queueId, IEnumerable<WritableEntity> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add users to a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue members to add</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member</returns>
    Task<QueueMember> CreateRoutingQueueUsersAsync(string queueId, IEnumerable<WritableEntity> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add wrap-up codes to a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Wrap-up code references</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up codes</returns>
    Task<WrapupCode[]> CreateRoutingQueueWrapupcodesAsync(string queueId, IEnumerable<WrapupCodeReference> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a routing skill
    /// </summary>
    /// <param name="body">Routing skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing skill</returns>
    Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a skill group
    /// </summary>
    /// <param name="body">Skill group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group</returns>
    Task<SkillGroup> CreateRoutingSkillgroupAsync(SkillGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add or remove members to a skill group across divisions
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="body">Skill group member divisions</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member division listing</returns>
    Task<SkillGroupMemberDivisionListing> CreateRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, SkillGroupMemberDivisions body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an SMS address
    /// </summary>
    /// <param name="body">SMS address provision details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS address</returns>
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddressProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an SMS address
    /// </summary>
    /// <param name="body">SMS address</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS address</returns>
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddress body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision an SMS phone number
    /// </summary>
    /// <param name="body">SMS phone number provision details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> CreateRoutingSmsPhoneNumberAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Configure alphanumeric SMS phone numbers
    /// </summary>
    /// <param name="body">Alphanumeric configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS alphanumeric configuration</returns>
    Task<SmsAlphanumericConfig> CreateRoutingSmsPhonenumbersAlphanumericAsync(SmsAlphanumericConfig body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Import SMS phone numbers
    /// </summary>
    /// <param name="body">Import job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number import job response</returns>
    Task<SmsPhoneNumberImportJobResponse> CreateRoutingSmsPhonenumbersImportAsync(SmsPhoneNumberImportJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a utilization label
    /// </summary>
    /// <param name="body">Create utilization label request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization label</returns>
    Task<UtilizationLabel> CreateRoutingUtilizationLabelsAsync(CreateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a utilization tag
    /// </summary>
    /// <param name="body">Create utilization tag request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization tag</returns>
    Task<UtilizationTag> CreateRoutingUtilizationTagsAsync(CreateUtilizationTagRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a wrap-up code
    /// </summary>
    /// <param name="body">Wrap-up code request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCodeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add routing languages to a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">User routing language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User language entity listing</returns>
    Task<UserLanguageEntityListing> CreateUserRoutinglanguagesAsync(string userId, UserRoutingLanguagePost body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add routing skills to a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">User routing skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill entity listing</returns>
    Task<UserSkillEntityListing> CreateUserRoutingskillsAsync(string userId, UserRoutingSkillPost body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a benefit assessment
    /// </summary>
    /// <param name="assessmentId">Benefit assessment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the user's direct routing backup settings and revert to the direct routing queue default
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a route for an email domain
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an outbound email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a routing language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a predictor
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="forceDelete">Force delete the queue even if it has dependencies</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue member
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="memberId">Member ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingQueueMemberAsync(string queueId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue user
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="memberId">Member ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingQueueUserAsync(string queueId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a wrap-up code from a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="codeId">Code ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingQueueWrapupcodeAsync(string queueId, string codeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete routing settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a routing skill
    /// </summary>
    /// <param name="skillId">Skill ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a skill group
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an SMS address
    /// </summary>
    /// <param name="addressId">Address ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an SMS phone number
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingSmsPhonenumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user's direct routing backup settings and revert to default
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user's utilization settings and revert to organization default
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete organization-wide utilization settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a utilization label
    /// </summary>
    /// <param name="labelId">Label ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a utilization tag
    /// </summary>
    /// <param name="tagId">Tag ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a wrap-up code
    /// </summary>
    /// <param name="codeId">Code ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a routing language from a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a routing skill from a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="skillId">Skill ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a single benefit assessment
    /// </summary>
    /// <param name="assessmentId">Benefit assessment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment</returns>
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get benefit assessments
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities to be returned</param>
    /// <param name="after">The cursor that points to the end of the set of entities to be returned</param>
    /// <param name="limit">Number of entities to return</param>
    /// <param name="pageSize">Number of entities per page</param>
    /// <param name="queueIds">List of queue IDs to filter assessments</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment listing</returns>
    Task<AssessmentListing> GetRoutingAssessmentsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a single benefit assessment job
    /// </summary>
    /// <param name="jobId">Benefit assessment job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment job</returns>
    Task<BenefitAssessmentJob> GetRoutingAssessmentsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get benefit assessment jobs (single division)
    /// </summary>
    /// <param name="divisionId">Division ID to filter jobs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment job listing</returns>
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get benefit assessment jobs (multiple divisions)
    /// </summary>
    /// <param name="divisionIds">List of division IDs to filter jobs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment job listing</returns>
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AvailableMediaTypeEntityListing> GetRoutingAvailablemediatypesAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> GetRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailOutboundDomainResult> GetRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> GetRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomain> GetRoutingEmailOutboundDomainSearchAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(int? pageSize = null, int? pageNumber = null, string filter = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailSetup> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Recipient> GetRoutingMessageRecipientAsync(string recipientId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, string name = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> GetRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorModelFeatureListing> GetRoutingPredictorModelFeaturesAsync(string predictorId, string modelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorModelListing> GetRoutingPredictorModelsAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, int? limit = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<KeyPerformanceIndicatorListing> GetRoutingPredictorsKeyperformanceindicatorsAsync(IEnumerable<string> kpiIds = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, string expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ComparisonPeriod> GetRoutingQueueComparisonperiodAsync(string queueId, string comparisonPeriodId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ComparisonPeriodListing> GetRoutingQueueComparisonperiodsAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueEstimatedwaittimeAsync(string queueId, string conversationId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionQueueConfig> GetRoutingQueueIdentityresolutionAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, string labelId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListingV1> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingQueueWrapupcodesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, bool? active = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string hasMember = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAllAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, bool? joined = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ContactCenterSettings> GetRoutingSettingsContactcenterAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TranscriptionSettings> GetRoutingSettingsTranscriptionAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSkill> GetRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> GetRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, string after = null, string before = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberDivisionListing> GetRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string name = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillEntityListing> GetRoutingSkillsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddress> GetRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddressEntityListing> GetRoutingSmsAddressesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SMSAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, bool? addressRequirement = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionConfig> GetRoutingSmsIdentityresolutionPhonenumberAsync(string addressId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> GetRoutingSmsPhoneNumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> GetRoutingSmsPhonenumberAsync(string phoneNumberId, string expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, IEnumerable<string> phoneNumberType = null, IEnumerable<string> phoneNumberStatus = null, IEnumerable<string> countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationLabelAgentsAsync(string labelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> GetRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabelEntityListing> GetRoutingUtilizationLabelsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationTagAgentsAsync(string tagId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTag> GetRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTagEntityListing> GetRoutingUtilizationTagsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> GetRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> GetRoutingWrapupcodesDivisionviewAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeDivisionViewEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? includeState = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetUserQueuesAsync(string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TestMessage> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Conversation> UpdateRoutingConversationAsync(string conversationId, Conversation body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> UpdateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionConfig> UpdateRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> UpdateRoutingEmailDomainValidateAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailOutboundDomainResult> UpdateRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Recipient> UpdateRoutingMessageRecipientAsync(string recipientId, Recipient body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> UpdateRoutingPredictorAsync(string predictorId, CreatePredictorRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionQueueConfig> UpdateRoutingQueueIdentityresolutionAsync(string queueId, IdentityResolutionQueueConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> UpdateRoutingQueueMemberAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> UpdateRoutingQueueMembersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMember> UpdateRoutingQueueUserAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> UpdateRoutingQueueUsersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSettings> UpdateRoutingSettingsAsync(RoutingSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ContactCenterSettings> UpdateRoutingSettingsContactcenterAsync(ContactCenterSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TranscriptionSettings> UpdateRoutingSettingsTranscriptionAsync(TranscriptionSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionConfig> UpdateRoutingSmsIdentityresolutionPhonenumberAsync(string phoneNumberId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserUtilization> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> UpdateRoutingUtilizationLabelAsync(string labelId, UpdateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueue> UpdateUserQueueAsync(string queueId, string userId, UserQueue body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> UpdateUserQueuesAsync(string userId, IEnumerable<UserQueue> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserRoutingLanguage> UpdateUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserRoutingLanguageEntityListing> UpdateUserRoutinglanguagesBulkAsync(string userId, IEnumerable<UserRoutingLanguage> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserRoutingSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillEntityListing> UpdateUserRoutingskillsBulkAsync(string userId, IEnumerable<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

}
