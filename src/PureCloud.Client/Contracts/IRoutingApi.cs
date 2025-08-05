using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Users;

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

    /// <summary>
    /// Get routing language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language details</returns>

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

    /// <summary>
    /// Create a queue
    /// </summary>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created queue</returns>

    /// <summary>
    /// Update a queue
    /// </summary>
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

    /// <summary>
    /// Delete an organization's routing settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>

    /// <summary>
    /// Delete the organization-wide max utilization settings and revert to the system default
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>

    /// <summary>
    /// Delete the user's max utilization settings and revert to the organization-wide default
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>

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

    /// <summary>
    /// Get a route
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="routeId">route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Route details</returns>

    /// <summary>
    /// Get routes
    /// </summary>
    /// <param name="domainName">email domain</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pattern">Filter routes by the route's pattern property</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Route listings</returns>

    /// <summary>
    /// Get domains
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="excludeStatus">Exclude MX record data</param>
    /// <param name="filter">Optional search filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Domain listings</returns>

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

    /// <summary>
    /// Get an assistant associated with a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="expand">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assistant queue</returns>
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a comparison period
    /// </summary>
    /// <param name="queueId">Queue id</param>
    /// <param name="comparisonPeriodId">ComparisonPeriod id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Comparison period</returns>
    Task<ComparisonPeriod> GetRoutingQueueComparisonperiodAsync(string queueId, string comparisonPeriodId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of comparison periods
    /// </summary>
    /// <param name="queueId">Queue id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Comparison period listing</returns>
    Task<ComparisonPeriodListing> GetRoutingQueueComparisonperiodsAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimated wait time
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimated wait time predictions</returns>
    Task<EstimatedWaitTimePredictions> GetRoutingQueueEstimatedwaittimeAsync(string queueId, string conversationId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue identity resolution settings
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Identity resolution queue config</returns>
    Task<IdentityResolutionQueueConfig> GetRoutingQueueIdentityresolutionAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimated wait time for media type
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="mediaType">Media type</param>
    /// <param name="labelId">Unique id that represents the interaction label used with media type for EWT calculation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimated wait time predictions</returns>
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, string labelId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill group members
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">The cursor that points to the next item in the list</param>
    /// <param name="before">The cursor that points to the previous item in the list</param>
    /// <param name="expand">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member entity listing</returns>

    /// <summary>
    /// Get SMS phone number
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> GetRoutingSmsPhonenumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get wrap-up codes
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name</param>
    /// <param name="ids">List of IDs</param>
    /// <param name="divisionIds">List of division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code entity listing</returns>
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get wrap-up codes division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="name">Name</param>
    /// <param name="ids">List of IDs</param>
    /// <param name="divisionIds">List of division IDs</param>
    /// <param name="includeState">Include state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code division view entity listing</returns>
    Task<WrapupCodeDivisionViewEntityListing> GetRoutingWrapupcodesDivisionviewAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? includeState = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user routing languages
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing language entity listing</returns>
    Task<UserRoutingLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user routing skills
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill entity listing</returns>
    Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user skill groups
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill group entity listing</returns>
    Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SMS identity resolution settings
    /// </summary>
    /// <param name="addressId">Address ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Identity resolution configuration</returns>
    Task<IdentityResolutionConfig> GetRoutingSmsIdentityresolutionPhonenumberAsync(string addressId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get phone numbers provisioned for SMS
    /// </summary>
    /// <param name="phoneNumber">Phone number</param>
    /// <param name="phoneNumberType">Phone number type</param>
    /// <param name="phoneNumberStatus">Phone number status</param>
    /// <param name="region">Region</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number entity listing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, string region = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get wrap-up codes division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code entity listing</returns>
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queues for user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="joined">Joined</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User queue entity listing</returns>
    Task<UserQueueEntityListing> GetUserQueuesAsync(string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the ring number or joined status for a queue member
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="memberId">Member ID</param>
    /// <param name="body">Queue Member</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> PatchRoutingQueueMemberAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Join or unjoin a set of users for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue Members</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> PatchRoutingQueueMembersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a queue
    /// </summary>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> PostRoutingQueuesAsync(CreateQueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a routing skill
    /// </summary>
    /// <param name="body">Skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing skill</returns>
    Task<RoutingSkill> PostRoutingSkillsAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a wrap-up code
    /// </summary>
    /// <param name="body">Wrap-up Code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> PostRoutingWrapupcodesAsync(WrapupCode body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> PutRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update routing settings
    /// </summary>
    /// <param name="body">Routing Settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing settings</returns>
    Task<RoutingSettings> PutRoutingSettingsAsync(RoutingSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a wrap-up code
    /// </summary>
    /// <param name="codeId">Code ID</param>
    /// <param name="body">Wrap-up Code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> PutRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision an SMS phone number
    /// </summary>
    /// <param name="body">SMS phone number provision</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> PostRoutingSmsPhonenumbersAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision an SMS address
    /// </summary>
    /// <param name="body">SMS address provision</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS address</returns>
    Task<SmsAddress> PostRoutingSmsAddressesAsync(SmsAddressProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a language
    /// </summary>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language</returns>
    Task<Language> PostRoutingLanguagesAsync(Language body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Join or unjoin a queue for a user
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="userId">User ID</param>
    /// <param name="body">User Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User queue</returns>
    Task<UserQueue> PatchUserQueueAsync(string queueId, string userId, UserQueue body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Join or unjoin a set of queues for a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">User Queues</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User queue entity listing</returns>
    Task<UserQueueEntityListing> PatchUserQueuesAsync(string userId, IEnumerable<UserQueue> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update routing language for user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="languageId">Language ID</param>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing language</returns>
    Task<UserRoutingLanguage> PatchUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add routing language to user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User language entity listing</returns>
    Task<UserLanguageEntityListing> PostUserRoutinglanguagesAsync(string userId, UserRoutingLanguagePost body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add routing skill to user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill entity listing</returns>
    Task<UserSkillEntityListing> PostUserRoutingskillsAsync(string userId, UserRoutingSkillPost body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an email domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> PostRoutingEmailDomainsAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an outbound email domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email outbound domain result</returns>
    Task<EmailOutboundDomainResult> PostRoutingEmailOutboundDomainsAsync(OutboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update domain settings
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> PatchRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment
    /// </summary>
    /// <param name="body">Assessment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment</returns>
    Task<BenefitAssessment> PostRoutingAssessmentsAsync(CreateBenefitAssessmentRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agents for utilization label
    /// </summary>
    /// <param name="labelId">Label ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent management unit references</returns>
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationLabelAgentsAsync(string labelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agents for utilization tag
    /// </summary>
    /// <param name="tagId">Tag ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent management unit references</returns>
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationTagAgentsAsync(string tagId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a conversation by setting its priority or state
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="body">Conversation</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Conversation</returns>
    Task<Conversation> PatchRoutingConversationAsync(string conversationId, Conversation body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate domain settings
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> PatchRoutingEmailDomainValidateAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update single predictor
    /// </summary>
    /// <param name="predictorId">Predictor ID</param>
    /// <param name="body">Predictor</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor</returns>
    Task<Predictor> PatchRoutingPredictorAsync(string predictorId, CreatePredictorRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a queue member
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="memberId">Member ID</param>
    /// <param name="body">Queue member</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member</returns>
    Task<QueueMember> PatchRoutingQueueUserAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Join or unjoin a set of users for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue members</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> PatchRoutingQueueUsersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update organization-level contact center settings
    /// </summary>
    /// <param name="body">Contact center settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Contact center settings</returns>
    Task<ContactCenterSettings> PatchRoutingSettingsContactcenterAsync(ContactCenterSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update transcription settings
    /// </summary>
    /// <param name="body">Transcription settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Transcription settings</returns>
    Task<TranscriptionSettings> PatchRoutingSettingsTranscriptionAsync(TranscriptionSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update skill group definition
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="body">Skill group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group</returns>
    Task<SkillGroup> PatchRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's routing languages in bulk
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Routing languages</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing language entity listing</returns>
    Task<UserRoutingLanguageEntityListing> PatchUserRoutinglanguagesBulkAsync(string userId, IEnumerable<UserRoutingLanguage> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk add/remove routing skills to/from a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Routing skills</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill entity listing</returns>
    Task<UserSkillEntityListing> PatchUserRoutingskillsBulkAsync(string userId, IEnumerable<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for queue observations
    /// </summary>
    /// <param name="body">Query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Analytics query response</returns>
    Task<AnalyticsQueryResponse> PostAnalyticsQueuesObservationsQueryAsync(QueueObservationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for user activity observations
    /// </summary>
    /// <param name="body">Query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing activity response</returns>
    Task<RoutingActivityResponse> PostAnalyticsRoutingActivityQueryAsync(RoutingActivityQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment job
    /// </summary>
    /// <param name="body">Job request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment job</returns>
    Task<BenefitAssessmentJob> PostRoutingAssessmentsJobsAsync(CreateBenefitAssessmentJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a route
    /// </summary>
    /// <param name="domainName">Email domain</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> PostRoutingEmailDomainRoutesAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test the connection settings for a domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Test message</returns>
    Task<TestMessage> PostRoutingEmailDomainTestconnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a simulated outbound domain
    /// </summary>
    /// <param name="body">Outbound domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email outbound domain result</returns>
    Task<EmailOutboundDomainResult> PostRoutingEmailOutboundDomainsSimulatedAsync(OutboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Predictor
    /// </summary>
    /// <param name="body">Predictor</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor</returns>
    Task<Predictor> PostRoutingPredictorsAsync(CreatePredictorRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk add queue members
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue members</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member</returns>
    Task<QueueMember> PostRoutingQueueMembersAsync(string queueId, IEnumerable<WritableEntity> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk add queue users
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue users</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member</returns>
    Task<QueueMember> PostRoutingQueueUsersAsync(string queueId, IEnumerable<WritableEntity> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add up to 100 wrap-up codes to a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Wrap-up codes</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up codes</returns>
    Task<WrapupCode[]> PostRoutingQueueWrapupcodesAsync(string queueId, IEnumerable<WrapupCodeReference> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add skill group member divisions
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="body">Skill group member divisions</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member division listing</returns>
    Task<SkillGroupMemberDivisionListing> PostRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, SkillGroupMemberDivisions body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a skill group
    /// </summary>
    /// <param name="body">Skill group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group</returns>
    Task<SkillGroup> PostRoutingSkillgroupsAsync(SkillGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision an alphanumeric SMS sender ID
    /// </summary>
    /// <param name="body">SMS alphanumeric configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS alphanumeric config</returns>
    Task<SmsAlphanumericConfig> PostRoutingSmsPhonenumbersAlphanumericAsync(SmsAlphanumericConfig body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Import SMS phone numbers
    /// </summary>
    /// <param name="body">Import request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number import job response</returns>
    Task<SmsPhoneNumberImportJobResponse> PostRoutingSmsPhonenumbersImportAsync(SmsPhoneNumberImportJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new utilization label
    /// </summary>
    /// <param name="body">Utilization label</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization label</returns>
    Task<UtilizationLabel> PostRoutingUtilizationLabelsAsync(CreateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new utilization tag
    /// </summary>
    /// <param name="body">Utilization tag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization tag</returns>
    Task<UtilizationTag> PostRoutingUtilizationTagsAsync(CreateUtilizationTagRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set the user's Direct Routing Backup settings
    /// </summary>
    /// <param name="body">Settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> PutRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a route
    /// </summary>
    /// <param name="domainName">Email domain</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> PutRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Configure identity resolution for a route
    /// </summary>
    /// <param name="domainName">Email domain</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="body">Identity resolution config</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Identity resolution config</returns>
    Task<IdentityResolutionConfig> PutRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Request activation of the outbound domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email outbound domain result</returns>
    Task<EmailOutboundDomainResult> PutRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a recipient
    /// </summary>
    /// <param name="recipientId">Recipient ID</param>
    /// <param name="body">Recipient</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient</returns>
    Task<Recipient> PutRoutingMessageRecipientAsync(string recipientId, Recipient body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Configure identity resolution for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Identity resolution config</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Identity resolution queue config</returns>
    Task<IdentityResolutionQueueConfig> PutRoutingQueueIdentityresolutionAsync(string queueId, IdentityResolutionQueueConfig body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update transcription settings
    /// </summary>
    /// <param name="body">Transcription settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Transcription settings</returns>
    Task<TranscriptionSettings> PutRoutingSettingsTranscriptionAsync(TranscriptionSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Configure SMS identity resolution for a phone number
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="body">Identity resolution config</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Identity resolution config</returns>
    Task<IdentityResolutionConfig> PutRoutingSmsIdentityresolutionPhonenumberAsync(string phoneNumberId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set the user's Direct Routing Backup settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Agent direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> PutRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the user's max utilization settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Utilization request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User utilization</returns>
    Task<UserUtilization> PutRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the organization-wide max utilization settings
    /// </summary>
    /// <param name="body">Utilization request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization response</returns>
    Task<UtilizationResponse> PutRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a utilization label
    /// </summary>
    /// <param name="labelId">Label ID</param>
    /// <param name="body">Update utilization label request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization label</returns>
    Task<UtilizationLabel> PutRoutingUtilizationLabelAsync(string labelId, UpdateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update routing skill for user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="skillId">Skill ID</param>
    /// <param name="body">Routing skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing skill</returns>
    Task<UserRoutingSkill> PutUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace all routing skills assigned to a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Routing skills</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill entity listing</returns>
    Task<UserSkillEntityListing> PutUserRoutingskillsBulkAsync(string userId, IEnumerable<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);



    /// <summary>
    /// Retrieve the latest assessment jobs for all queues in the organization
    /// </summary>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment job listing</returns>
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get outbound email domains
    /// </summary>
    /// <param name="filter">Filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Outbound domain entity listing</returns>
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of supported languages
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Language name</param>
    /// <param name="ids">Language IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language entity listing</returns>
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a recipient
    /// </summary>
    /// <param name="messengerType">Messenger type</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient listing</returns>
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all Predictors
    /// </summary>
    /// <param name="before">Before cursor</param>
    /// <param name="after">After cursor</param>
    /// <param name="limit">Limit</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="queueIds">Queue IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor listing</returns>
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue agent assistant data
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assistant queue</returns>
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimated wait time for queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimated wait time predictions</returns>
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the members of this queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the users in this queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

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
    /// <returns>Queue entity listing</returns>
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string hasMember = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all queue division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue entity listing</returns>
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, bool? joined = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill group members
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">After</param>
    /// <param name="expand">Expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member entity listing</returns>
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, int? after = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill group member divisions
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member division listing</returns>
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string name = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get available SMS phone numbers
    /// </summary>
    /// <param name="countryCode">Country code</param>
    /// <param name="phoneNumberType">Phone number type</param>
    /// <param name="region">Region</param>
    /// <param name="city">City</param>
    /// <param name="areaCode">Area code</param>
    /// <param name="pattern">Pattern</param>
    /// <param name="addressRequirement">Address requirement</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS available phone number entity listing</returns>
    Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, bool? addressRequirement = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SMS phone numbers
    /// </summary>
    /// <param name="phoneNumber">Phone number</param>
    /// <param name="phoneNumberType">Phone number type</param>
    /// <param name="phoneNumberStatus">Phone number status</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number entity listing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get utilization labels
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Label utilization entity listing</returns>
    /// Get wrapup codes division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="name">Name</param>
    /// <param name="ids">IDs</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="includeState">Include state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrapup code entity listing</returns>
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? includeState = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user skill groups
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">After</param>
    /// <param name="before">Before</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill group entity listing</returns>
    Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);
}
