using PureCloud.Client.Models;

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

    // TODO: Add remaining ~290 methods after creating required models:
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
