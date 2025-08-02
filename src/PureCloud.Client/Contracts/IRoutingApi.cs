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
    /// <param name="queueIds">Queue ID(s) to filter assessments by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment listing</returns>
    Task<AssessmentListing> GetRoutingAssessmentsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

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
    Task<EmailSetup> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get activation status of a domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Activation status</returns>
    Task<EmailOutboundDomainResult> GetRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search a domain across organizations
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results</returns>
    Task<OutboundDomain> GetRoutingEmailOutboundDomainSearchAsync(string domainId, CancellationToken cancellationToken = default);

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
    Task<EmailOutboundDomainResult> UpdateRoutingEmailOutboundDomainActivationAsync(string domainId, object body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Tests the connection settings for a domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Test results</returns>
    Task<TestMessage> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created domain</returns>
    Task<InboundDomain> CreateRoutingEmailOutboundDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recipients
    /// </summary>
    /// <param name="messengerType">Messenger Type</param>
    /// <param name="name">Recipient Name</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient listings</returns>
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, string name = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a recipient
    /// </summary>
    /// <param name="recipientId">Recipient ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient details</returns>
    Task<Recipient> GetRoutingMessageRecipientAsync(string recipientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a list of predictors
    /// </summary>
    /// <param name="before">Cursor for previous page</param>
    /// <param name="after">Cursor for next page</param>
    /// <param name="limit">Number of entities to return</param>
    /// <param name="queueIds">Queue IDs to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor listings</returns>
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, int? limit = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single predictor
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor details</returns>
    Task<Predictor> GetRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve Predictor Models
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor model listings</returns>
    Task<PredictorModelListing> GetRoutingPredictorModelsAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve Predictor Model Features
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="modelId">Model ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Model feature listings</returns>
    Task<PredictorModelFeatureListing> GetRoutingPredictorModelFeaturesAsync(string predictorId, string modelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Key Performance Indicators
    /// </summary>
    /// <param name="kpiIds">Key Performance Indicator IDs</param>
    /// <param name="expand">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Key performance indicator listings</returns>
    Task<KeyPerformanceIndicatorListing> GetRoutingPredictorsKeyperformanceindicatorsAsync(IEnumerable<string> kpiIds = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of routing queues
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Queue name</param>
    /// <param name="ids">Queue IDs</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="hasMember">Has member</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue listings</returns>
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? hasMember = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the members of this queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expand">Fields to expand</param>
    /// <param name="joined">Filter by joined status</param>
    /// <param name="name">Member name</param>
    /// <param name="profileSkills">Profile skills</param>
    /// <param name="skills">Skills</param>
    /// <param name="languages">Languages</param>
    /// <param name="routingStatus">Routing status</param>
    /// <param name="presence">Presence</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member listings</returns>
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the members of this queue as a user listing
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expand">Fields to expand</param>
    /// <param name="joined">Filter by joined status</param>
    /// <param name="name">Member name</param>
    /// <param name="profileSkills">Profile skills</param>
    /// <param name="skills">Skills</param>
    /// <param name="languages">Languages</param>
    /// <param name="routingStatus">Routing status</param>
    /// <param name="presence">Presence</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member listings</returns>
    Task<QueueMemberEntityListingV1> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the wrap-up codes for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code listings</returns>
    Task<WrapupCodeEntityListing> GetRoutingQueueWrapupcodesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Addresses
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS address listings</returns>
    Task<SmsAddressEntityListing> GetRoutingSmsAddressesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of available phone numbers for SMS provisioning
    /// </summary>
    /// <param name="countryCode">The two-character country code</param>
    /// <param name="phoneNumberType">Type of phone number</param>
    /// <param name="region">Region/province/state for the phone number</param>
    /// <param name="city">City for the phone number</param>
    /// <param name="areaCode">Area code for the phone number</param>
    /// <param name="pattern">A pattern to match phone numbers</param>
    /// <param name="addressRequirement">This indicates whether the phone number requires to have an Address registered</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Available phone number listings</returns>
    Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of provisioned phone numbers
    /// </summary>
    /// <param name="phoneNumber">Filter on phone number address. Allowable characters are the digits '0-9' and the wild card character '*'</param>
    /// <param name="phoneNumberType">Filter on phone number type</param>
    /// <param name="phoneNumberStatus">Filter on phone number status</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Optional field to sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="language">A language specified as an ISO 639-1 language code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number listings</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill groups
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">The cursor that points to the next item</param>
    /// <param name="before">The cursor that points to the previous item</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group listings</returns>
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill group members
    /// </summary>
    /// <param name="skillGroupId">Skill Group ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">The cursor that points to the next item</param>
    /// <param name="before">The cursor that points to the previous item</param>
    /// <param name="expand">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member listings</returns>
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, string after = null, string before = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the organization-wide max utilization settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization settings</returns>
    Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an organization's routing settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing settings</returns>
    Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Contact Center Settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Contact center settings</returns>
    Task<ContactCenterSettings> GetRoutingSettingsContactcenterAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Transcription Settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Transcription settings</returns>
    Task<TranscriptionSettings> GetRoutingSettingsTranscriptionAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of routing skills
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="name">Filter for results that start with this value</param>
    /// <param name="ids">ID(s) to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill listings</returns>
    Task<SkillEntityListing> GetRoutingSkillsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of supported languages
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Ascending or descending sort order</param>
    /// <param name="name">Name</param>
    /// <param name="ids">IDs to filter by</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language listings</returns>
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get routing language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language details</returns>
    Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Language
    /// </summary>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created language</returns>
    Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Skill
    /// </summary>
    /// <param name="body">Skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created skill</returns>
    Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a skill group
    /// </summary>
    /// <param name="body">Create skill group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created skill group</returns>
    Task<SkillGroup> CreateRoutingSkillgroupAsync(SkillGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a wrap-up code
    /// </summary>
    /// <param name="body">WrapupCode</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created wrap-up code</returns>
    Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCode body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a queue
    /// </summary>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created queue</returns>
    Task<Queue> CreateRoutingQueueAsync(QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated queue</returns>
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a skill group
    /// </summary>
    /// <param name="skillGroupId">Skill Group ID</param>
    /// <param name="body">Update skill group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated skill group</returns>
    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update wrap-up code
    /// </summary>
    /// <param name="codeId">The wrap-up code ID</param>
    /// <param name="body">WrapupCode</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated wrap-up code</returns>
    Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the organization-wide max utilization settings
    /// </summary>
    /// <param name="body">utilization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated utilization settings</returns>
    Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user's max utilization settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User utilization settings</returns>
    Task<UserUtilization> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the user's max utilization settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">utilization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user utilization settings</returns>
    Task<UserUtilization> UpdateRoutingUserUtilizationAsync(string userId, UserUtilization body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user's Direct Routing Backup settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the user's Direct Routing Backup settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">directRoutingBackup</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a route
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created route</returns>
    Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate domain settings
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Validated domain</returns>
    Task<InboundDomain> ValidateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="forceDelete">forceDelete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an organization's routing settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the organization-wide max utilization settings and revert to the system default
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the user's max utilization settings and revert to the organization-wide default
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update domain settings
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated domain</returns>
    Task<InboundDomain> UpdateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a route
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated route</returns>
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a route
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Route details</returns>
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get routes
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pattern">Filter routes by the route's pattern property</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Route listings</returns>
    Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, int? pageSize = null, int? pageNumber = null, string pattern = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get domains
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="excludeStatus">Exclude MX record data</param>
    /// <param name="filter">Optional search filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Domain listings</returns>
    Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(int? pageSize = null, int? pageNumber = null, bool? excludeStatus = null, string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created domain</returns>
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a domain
    /// </summary>
    /// <param name="domainId">domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a route
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision an Address for SMS
    /// </summary>
    /// <param name="body">SmsAddress</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created SMS address</returns>
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddressProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision a phone number for SMS
    /// </summary>
    /// <param name="body">SmsPhoneNumber</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created SMS phone number</returns>
    Task<SmsPhoneNumber> CreateRoutingSmsPhoneNumberAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of supported Email Outbound Domains
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="filter">Filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Outbound domain entity listing</returns>
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(int? pageSize = null, int? pageNumber = null, string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get paged listing of simplified queue objects filterable by division
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name</param>
    /// <param name="ids">Queue IDs</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue entity listing</returns>
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get paged listing of simplified queue objects filterable by division, including all division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue entity listing</returns>
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAllAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user's queues
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="joined">Filter by queue joined status</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User queue entity listing</returns>
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get details about this skill group
    /// </summary>
    /// <param name="skillGroupId">Skill Group ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group</returns>
    Task<SkillGroup> GetRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of members in a skill group
    /// </summary>
    /// <param name="skillGroupId">Skill Group ID</param>
    /// <param name="expands">Expand divisions</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member divisions</returns>
    Task<SkillGroupMemberDivisions> GetRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an Address by Id for SMS
    /// </summary>
    /// <param name="addressId">Address ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS address</returns>
    Task<SmsAddress> GetRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a phone number for SMS by its unique identifier
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> GetRoutingSmsPhoneNumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of SMS phone numbers
    /// </summary>
    /// <param name="phoneNumber">Filter by phone number</param>
    /// <param name="phoneNumberTypes">Filter by phone number types</param>
    /// <param name="phoneNumberStatuses">Filter by phone number statuses</param>
    /// <param name="countryCodes">Filter by country codes</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="language">Language</param>
    /// <param name="integrationId">Integration ID</param>
    /// <param name="supportedContentId">Supported content ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number entity listing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, IEnumerable<string> phoneNumberTypes = null, IEnumerable<string> phoneNumberStatuses = null, IEnumerable<string> countryCodes = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get utilization labels
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Utilization label name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization label entity listing</returns>
    Task<UtilizationLabelEntityListing> GetRoutingUtilizationLabelsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get utilization tags
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Utilization tag name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization tag entity listing</returns>
    Task<UtilizationTagEntityListing> GetRoutingUtilizationTagsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);
}
