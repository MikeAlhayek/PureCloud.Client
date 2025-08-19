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

    /// <summary>
    /// Get benefit assessment jobs (multiple divisions)
    /// </summary>
    /// <param name="divisionIds">List of division IDs to filter jobs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment job listing</returns>
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all available media types for routing
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Available media type listing</returns>
    Task<AvailableMediaTypeEntityListing> GetRoutingAvailablemediatypesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the logged-in user's direct routing backup settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a route for an email domain
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the identity resolution settings for an email domain route
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> GetRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get routes for an email domain
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route entity listing</returns>
    Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get email domains
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain entity listing</returns>
    Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the activation status for an outbound email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email outbound domain result</returns>
    Task<EmailOutboundDomainResult> GetRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an outbound email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> GetRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for outbound email domains
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Outbound domain</returns>
    Task<OutboundDomain> GetRoutingEmailOutboundDomainSearchAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get outbound email domains with pagination
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="filter">Filter to apply to search</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Outbound domain entity listing</returns>
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(int? pageSize = null, int? pageNumber = null, string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get email setup configuration
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email setup</returns>
    Task<EmailSetup> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a routing language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language</returns>
    Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get routing languages
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language entity listing</returns>    /// <summary>
    /// Get the list of routing languages
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Filter by name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language listing</returns>
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get messagerecipient
    /// </summary>
    /// <param name="recipientId">Recipientid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient</returns>
    Task<Recipient> GetRoutingMessageRecipientAsync(string recipientId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get messagerecipients
    /// </summary>
    /// <param name="messengerType">Messengertype parameter</param>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>RecipientListing</returns>
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, string name = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get predictor
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor</returns>
    Task<Predictor> GetRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get predictor model features
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="modelId">Model ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor model feature listing</returns>
    Task<PredictorModelFeatureListing> GetRoutingPredictorModelFeaturesAsync(string predictorId, string modelId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get predictormodels
    /// </summary>
    /// <param name="predictorId">Predictorid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>PredictorModelListing</returns>
    Task<PredictorModelListing> GetRoutingPredictorModelsAsync(string predictorId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get predictors
    /// </summary>
    /// <param name="before">Before parameter</param>
    /// <param name="after">After parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>PredictorListing</returns>
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, int? limit = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get key performance indicators for predictors
    /// </summary>
    /// <param name="kpiIds">List of KPI IDs to filter</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Key performance indicator listing</returns>
    Task<KeyPerformanceIndicatorListing> GetRoutingPredictorsKeyperformanceindicatorsAsync(IEnumerable<string> kpiIds = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue assistant configuration
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="expand">Which fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assistant queue</returns>
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue assistant configuration
    /// </summary>

    /// <summary>
    /// Get details about a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get comparison period for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="comparisonPeriodId">Comparison period ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Comparison period</returns>
    Task<ComparisonPeriod> GetRoutingQueueComparisonperiodAsync(string queueId, string comparisonPeriodId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get comparison periods for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Comparison period listing</returns>
    Task<ComparisonPeriodListing> GetRoutingQueueComparisonperiodsAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimated wait time for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimated wait time predictions</returns>
    Task<EstimatedWaitTimePredictions> GetRoutingQueueEstimatedwaittimeAsync(string queueId, string conversationId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get identity resolution settings for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Identity resolution queue config</returns>
    Task<IdentityResolutionQueueConfig> GetRoutingQueueIdentityresolutionAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimated wait time for a queue by media type with label
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="mediaType">Media type</param>
    /// <param name="labelId">Label ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimated wait time predictions</returns>
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, string labelId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue members with extended filters
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="joined">Filter by joined status</param>
    /// <param name="name">Name filter</param>
    /// <param name="profileSkills">Profile skills filter</param>
    /// <param name="skills">Skills filter</param>
    /// <param name="languages">Languages filter</param>
    /// <param name="routingStatus">Routing status filter</param>
    /// <param name="presence">Presence filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue users
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="joined">Filter by joined status</param>
    /// <param name="name">Name filter</param>
    /// <param name="profileSkills">Profile skills filter</param>
    /// <param name="skills">Skills filter</param>
    /// <param name="languages">Languages filter</param>
    /// <param name="routingStatus">Routing status filter</param>
    /// <param name="presence">Presence filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing V1</returns>
    Task<QueueMemberEntityListingV1> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

        /// <summary>
    /// Get queuewrapupcodes
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WrapupCodeEntityListing</returns>
    Task<WrapupCodeEntityListing> GetRoutingQueueWrapupcodesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

        /// <summary>
    /// Get queues
    /// </summary>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="name">Name parameter</param>
    /// <param name="hasMember">Hasmember parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QueueEntityListing</returns>
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string hasMember = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get queuesdivisionviewsall
    /// </summary>
    /// <param name="sortBy">Sortby parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QueueEntityListing</returns>
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAllAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get queuesdivisionviews
    /// </summary>
    /// <param name="sortBy">Sortby parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QueueEntityListing</returns>
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get queuesme
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserQueueEntityListing</returns>
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

        /// <summary>
    /// Get settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>RoutingSettings</returns>
    Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Get settingscontactcenter
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ContactCenterSettings</returns>
    Task<ContactCenterSettings> GetRoutingSettingsContactcenterAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Get settingstranscription
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TranscriptionSettings</returns>
    Task<TranscriptionSettings> GetRoutingSettingsTranscriptionAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Get skill
    /// </summary>
    /// <param name="skillId">Skillid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>RoutingSkill</returns>
    Task<RoutingSkill> GetRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get skillgroup
    /// </summary>
    /// <param name="skillGroupId">Skillgroupid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SkillGroup</returns>
    Task<SkillGroup> GetRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get skillgroupmembers
    /// </summary>
    /// <param name="skillGroupId">Skillgroupid parameter</param>
    /// <param name="after">After parameter</param>
    /// <param name="before">Before parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SkillGroupMemberEntityListing</returns>
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, string after = null, string before = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

        /// <summary>
    /// Get skillgroupmembersdivisions
    /// </summary>
    /// <param name="skillGroupId">Skillgroupid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SkillGroupMemberDivisionListing</returns>
    Task<SkillGroupMemberDivisionListing> GetRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

        /// <summary>
    /// Get skillgroups
    /// </summary>
    /// <param name="name">Name parameter</param>
    /// <param name="after">After parameter</param>
    /// <param name="before">Before parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SkillGroupEntityListing</returns>
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string name = null, string after = null, string before = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get skills
    /// </summary>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SkillEntityListing</returns>
    Task<SkillEntityListing> GetRoutingSkillsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsaddress
    /// </summary>
    /// <param name="addressId">Addressid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SmsAddress</returns>
    Task<SmsAddress> GetRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsaddresses
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SmsAddressEntityListing</returns>
    Task<SmsAddressEntityListing> GetRoutingSmsAddressesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

        /// <summary>
    /// Get smsavailablephonenumbers
    /// </summary>
    /// <param name="countryCode">Countrycode parameter</param>
    /// <param name="phoneNumberType">Phonenumbertype parameter</param>
    /// <param name="region">Region parameter</param>
    /// <param name="city">City parameter</param>
    /// <param name="areaCode">Areacode parameter</param>
    /// <param name="pattern">Pattern parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMSAvailablePhoneNumberEntityListing</returns>
    Task<SMSAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, bool? addressRequirement = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsidentityresolutionphonenumber
    /// </summary>
    /// <param name="addressId">Addressid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IdentityResolutionConfig</returns>
    Task<IdentityResolutionConfig> GetRoutingSmsIdentityresolutionPhonenumberAsync(string addressId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsphonenumber
    /// </summary>
    /// <param name="phoneNumberId">Phonenumberid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SmsPhoneNumber</returns>
    Task<SmsPhoneNumber> GetRoutingSmsPhoneNumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsphonenumbers
    /// </summary>
    /// <param name="phoneNumber">Phonenumber parameter</param>
    /// <param name="phoneNumberType">Phonenumbertype parameter</param>
    /// <param name="phoneNumberStatus">Phonenumberstatus parameter</param>
    /// <param name="sortBy">Sortby parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="language">Language parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SmsPhoneNumberEntityListing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsphonenumber
    /// </summary>
    /// <param name="phoneNumberId">Phonenumberid parameter</param>
    /// <param name="expand">Expand parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SmsPhoneNumber</returns>
    Task<SmsPhoneNumber> GetRoutingSmsPhonenumberAsync(string phoneNumberId, string expand = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get smsphonenumbers
    /// </summary>
    /// <param name="phoneNumber">Phonenumber parameter</param>
    /// <param name="sortBy">Sortby parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="language">Language parameter</param>
    /// <param name="integrationId">Integrationid parameter</param>
    /// <param name="supportedContentId">Supportedcontentid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SmsPhoneNumberEntityListing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, IEnumerable<string> phoneNumberType = null, IEnumerable<string> phoneNumberStatus = null, IEnumerable<string> countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get userdirectroutingbackupsettings
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentDirectRoutingBackupSettings</returns>
    Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get userutilization
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentMaxUtilizationResponse</returns>
    Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilization
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationResponse</returns>
    Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilizationlabelagents
    /// </summary>
    /// <param name="labelId">Labelid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentManagementUnitReference[]</returns>
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationLabelAgentsAsync(string labelId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilizationlabel
    /// </summary>
    /// <param name="labelId">Labelid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationLabel</returns>
    Task<UtilizationLabel> GetRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilizationlabels
    /// </summary>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationLabelEntityListing</returns>
    Task<UtilizationLabelEntityListing> GetRoutingUtilizationLabelsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilizationtagagents
    /// </summary>
    /// <param name="tagId">Tagid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentManagementUnitReference[]</returns>
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationTagAgentsAsync(string tagId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilizationtag
    /// </summary>
    /// <param name="tagId">Tagid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationTag</returns>
    Task<UtilizationTag> GetRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get utilizationtags
    /// </summary>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationTagEntityListing</returns>
    Task<UtilizationTagEntityListing> GetRoutingUtilizationTagsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get wrapupcode
    /// </summary>
    /// <param name="codeId">Codeid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WrapupCode</returns>
    Task<WrapupCode> GetRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get wrapupcodes
    /// </summary>
    /// <param name="sortBy">Sortby parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WrapupCodeEntityListing</returns>
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get wrapupcodesdivisionview
    /// </summary>
    /// <param name="codeId">Codeid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WrapupCode</returns>
    Task<WrapupCode> GetRoutingWrapupcodesDivisionviewAsync(string codeId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get wrapupcodesdivisionviews
    /// </summary>
    /// <param name="name">Name parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WrapupCodeDivisionViewEntityListing</returns>
    Task<WrapupCodeDivisionViewEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? includeState = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get getuserqueues
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserQueueEntityListing</returns>
    Task<UserQueueEntityListing> GetUserQueuesAsync(string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get getuserroutinglanguages
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserLanguageEntityListing</returns>
    Task<UserLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get getuserroutingskills
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="sortOrder">Sortorder parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserSkillEntityListing</returns>
    Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Get getuserskillgroups
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="after">After parameter</param>
    /// <param name="before">Before parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserSkillGroupEntityListing</returns>
    Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Perform operation on testroutingemaildomainconnection
    /// </summary>
    /// <param name="domainId">Domainid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TestMessage</returns>
    Task<TestMessage> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update attributes of an in-queue conversation
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="body">Conversation Attributes</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>RoutingConversationAttributesResponse</returns>
    Task<RoutingConversationAttributesResponse> UpdateRoutingConversationAsync(string conversationId, RoutingConversationAttributesRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update directroutingbackupsettingsme
    /// </summary>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentDirectRoutingBackupSettings</returns>
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update emaildomain
    /// </summary>
    /// <param name="domainId">Domainid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>InboundDomain</returns>
    Task<InboundDomain> UpdateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update emaildomainroute
    /// </summary>
    /// <param name="domainName">Domainname parameter</param>
    /// <param name="routeId">Routeid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>InboundRoute</returns>
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update emaildomainrouteidentityresolution
    /// </summary>
    /// <param name="domainName">Domainname parameter</param>
    /// <param name="routeId">Routeid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IdentityResolutionConfig</returns>
    Task<IdentityResolutionConfig> UpdateRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update emaildomainvalidate
    /// </summary>
    /// <param name="domainId">Domainid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>InboundDomain</returns>
    Task<InboundDomain> UpdateRoutingEmailDomainValidateAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update emailoutbounddomainactivation
    /// </summary>
    /// <param name="domainId">Domainid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EmailOutboundDomainResult</returns>
    Task<EmailOutboundDomainResult> UpdateRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update messagerecipient
    /// </summary>
    /// <param name="recipientId">Recipientid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient</returns>
    Task<Recipient> UpdateRoutingMessageRecipientAsync(string recipientId, Recipient body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update predictor
    /// </summary>
    /// <param name="predictorId">Predictorid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor</returns>
    Task<Predictor> UpdateRoutingPredictorAsync(string predictorId, CreatePredictorRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update queue
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update queueidentityresolution
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IdentityResolutionQueueConfig</returns>
    Task<IdentityResolutionQueueConfig> UpdateRoutingQueueIdentityresolutionAsync(string queueId, IdentityResolutionQueueConfig body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update queuemember
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="memberId">Memberid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>bool</returns>
    Task<bool> UpdateRoutingQueueMemberAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update queuemembers
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QueueMemberEntityListing</returns>
    Task<QueueMemberEntityListing> UpdateRoutingQueueMembersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update queueuser
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="memberId">Memberid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QueueMember</returns>
    Task<QueueMember> UpdateRoutingQueueUserAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update queueusers
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>QueueMemberEntityListing</returns>
    Task<QueueMemberEntityListing> UpdateRoutingQueueUsersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update settings
    /// </summary>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>RoutingSettings</returns>
    Task<RoutingSettings> UpdateRoutingSettingsAsync(RoutingSettings body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update settingscontactcenter
    /// </summary>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ContactCenterSettings</returns>
    Task<ContactCenterSettings> UpdateRoutingSettingsContactcenterAsync(ContactCenterSettings body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update settingstranscription
    /// </summary>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TranscriptionSettings</returns>
    Task<TranscriptionSettings> UpdateRoutingSettingsTranscriptionAsync(TranscriptionSettings body, CancellationToken cancellationToken = default);

    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update smsidentityresolutionphonenumber
    /// </summary>
    /// <param name="phoneNumberId">Phonenumberid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IdentityResolutionConfig</returns>
    Task<IdentityResolutionConfig> UpdateRoutingSmsIdentityresolutionPhonenumberAsync(string phoneNumberId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update userdirectroutingbackupsettings
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AgentDirectRoutingBackupSettings</returns>
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update userutilization
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserUtilization</returns>
    Task<UserUtilization> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update utilization
    /// </summary>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationResponse</returns>
    Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update utilizationlabel
    /// </summary>
    /// <param name="labelId">Labelid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UtilizationLabel</returns>
    Task<UtilizationLabel> UpdateRoutingUtilizationLabelAsync(string labelId, UpdateUtilizationLabelRequest body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update wrapupcode
    /// </summary>
    /// <param name="codeId">Codeid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WrapupCode</returns>
    Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update userqueue
    /// </summary>
    /// <param name="queueId">Queueid parameter</param>
    /// <param name="userId">Userid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserQueue</returns>
    Task<UserQueue> UpdateUserQueueAsync(string queueId, string userId, UserQueue body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update userqueues
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserQueueEntityListing</returns>
    Task<UserQueueEntityListing> UpdateUserQueuesAsync(string userId, IEnumerable<UserQueue> body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update userroutinglanguage
    /// </summary>
    /// <param name="userId">Userid parameter</param>
    /// <param name="languageId">Languageid parameter</param>
    /// <param name="body">Body parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UserRoutingLanguage</returns>
    Task<UserRoutingLanguage> UpdateUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update routing languages for a user in bulk
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Routing languages to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing language listing</returns>
    Task<UserRoutingLanguageEntityListing> UpdateUserRoutinglanguagesBulkAsync(string userId, IEnumerable<UserRoutingLanguage> body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update routing skill for a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="skillId">Skill ID</param>
    /// <param name="body">User routing skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing skill</returns>
    Task<UserRoutingSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);
    /// <summary>
    /// Update routing skills for a user in bulk
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Routing skills to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill listing</returns>
    Task<UserSkillEntityListing> UpdateUserRoutingskillsBulkAsync(string userId, IEnumerable<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

}
