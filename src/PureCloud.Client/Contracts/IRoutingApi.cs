using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
    /// <summary>
    /// Delete single benefit assessment.
    /// </summary>
    /// <param name="assessmentId">Benefit Assessment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the user's Direct Routing Backup settings and revert to the Direct Routing Queue default.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a domain.
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a route.
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an outbound domain.
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a routing language.
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue.
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="forceDelete">Force delete (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a routing skill.
    /// </summary>
    /// <param name="skillId">Skill ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single benefit assessment.
    /// </summary>
    /// <param name="assessmentId">Benefit Assessment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The benefit assessment</returns>
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get domain.
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The inbound domain</returns>
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a route.
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The inbound route</returns>
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment.
    /// </summary>
    /// <param name="body">The benefit assessment request (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created benefit assessment</returns>
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a domain.
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created inbound domain</returns>
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a route.
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created inbound route</returns>
    Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a route.
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated inbound route</returns>
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    // Additional queue operations - requiring Queue and QueueEntityListing models
    // TODO: Implement after creating required models:
    // Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default);
    // Task<QueueEntityListing> GetRoutingQueuesAsync(...);

    /// <summary>
    /// Delete a queue member.
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="memberId">Member ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingQueueMemberAsync(string queueId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue user.
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="memberId">Member ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingQueueUserAsync(string queueId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue wrapup code.
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="codeId">Code ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingQueueWrapupcodeAsync(string queueId, string codeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete single predictor.
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete routing settings.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a skill group.
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an SMS address.
    /// </summary>
    /// <param name="addressId">Address ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an SMS phone number.
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingSmsPhonenumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the user's Direct Routing Backup settings.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the user's utilization settings.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete utilization settings.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a utilization label.
    /// </summary>
    /// <param name="labelId">Label ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a utilization tag.
    /// </summary>
    /// <param name="tagId">Tag ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a wrap-up code.
    /// </summary>
    /// <param name="codeId">Code ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a routing language for a user.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a routing skill for a user.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="skillId">Skill ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all benefit assessments.
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities</param>
    /// <param name="after">The cursor that points to the end of the set of entities</param>
    /// <param name="limit">Number of entities to return. Maximum of 200</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200</param>
    /// <param name="queueId">Queue ID(s) to filter assessments by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment listing</returns>
    Task<AssessmentListing> GetRoutingAssessmentsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single benefit assessments job.
    /// </summary>
    /// <param name="jobId">Benefit Assessment Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment job</returns>
    Task<BenefitAssessmentJob> GetRoutingAssessmentsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all benefit assessment jobs.
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment job listing</returns>
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get available media types.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Available media type listing</returns>
    Task<AvailableMediaTypeEntityListing> GetRoutingAvailablemediatypesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user's Direct Routing Backup settings.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get domains.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain entity listing</returns>
    Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get routes.
    /// </summary>
    /// <param name="domainName">Email domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route entity listing</returns>
    Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of supported languages.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language entity listing</returns>
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a routing language.
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language</returns>
    Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of queues.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name filter</param>
    /// <param name="active">Active filter</param>
    /// <param name="divisionId">Division ID filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue entity listing</returns>
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, bool? active = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get details about this queue.
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a queue.
    /// </summary>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> CreateRoutingQueueAsync(QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a queue.
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a language.
    /// </summary>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language</returns>
    Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a skill.
    /// </summary>
    /// <param name="body">Skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing skill</returns>
    Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a wrap-up code.
    /// </summary>
    /// <param name="body">WrapupCode</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCodeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get details about this skill.
    /// </summary>
    /// <param name="skillId">Skill ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing skill</returns>
    Task<RoutingSkill> GetRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get details about this wrap-up code.
    /// </summary>
    /// <param name="codeId">Wrapup Code ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> GetRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get routing settings.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing settings</returns>
    Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the organization-wide max utilization settings.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization response</returns>
    Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get details about this utilization label.
    /// </summary>
    /// <param name="labelId">Utilization Label ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization label</returns>
    Task<UtilizationLabel> GetRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get details about this utilization tag.
    /// </summary>
    /// <param name="tagId">Utilization Tag ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization tag</returns>
    Task<UtilizationTag> GetRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user's Direct Routing Backup settings.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user's max utilization settings.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent max utilization response</returns>
    Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the User Identity Resolution for domain route
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Route details</returns>
    Task<InboundRoute> GetRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Outbound domain</returns>
    Task<InboundDomain> GetRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get email setup information
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email setup configuration</returns>
    Task<string> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activation status of a domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activation status</returns>
    Task<string> GetRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search a domain across organizations
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results</returns>
    Task<string> GetRoutingEmailOutboundDomainSearchAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the user's Direct Routing Backup settings
    /// </summary>
    /// <param name="body">Agent direct routing backup settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated settings</returns>
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Request an activation status of a domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="body">Activation request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activation response</returns>
    Task<string> UpdateRoutingEmailOutboundDomainActivationAsync(string domainId, object body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Tests the connection settings for a domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Test results</returns>
    Task<string> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created domain</returns>
    Task<InboundDomain> CreateRoutingEmailOutboundDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    // TODO: Add remaining ~110 methods after migrating required models:
    // - Delete methods: ~15 more (DeleteRoutingPredictor, DeleteRoutingSettings, etc.)
    // - Get methods: ~75 more (GetRoutingLanguage, GetRoutingLanguages, GetRoutingSkills, etc.) 
    // - Create methods: ~20 more (CreateRoutingLanguage, CreateRoutingQueue, CreateRoutingSkill, etc.)
    // - Update methods: ~21 more (UpdateRoutingLanguage, UpdateRoutingQueue, UpdateRoutingSkill, etc.)
    // 
    // Required models to create or fix:
    // - Language, LanguageEntityListing (exists but not building correctly)
    // - QueueRequest, CreateQueueRequest
    // - RoutingSkill, SkillEntityListing
    // - SkillGroup, SkillGroupEntityListing  
    // - WrapupCode, WrapupCodeEntityListing
    // - OutboundDomain, OutboundDomainEntityListing
    // - And ~50 more model classes
}
