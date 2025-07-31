using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
    /// <inheritdoc />
    Task<bool> DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    // TODO: Add remaining 139 methods after creating required models:
    // - Delete methods: ~18 more (DeleteRoutingLanguage, DeleteRoutingQueue, DeleteRoutingSkill, etc.)
    // - Get methods: ~80 more (GetRoutingLanguage, GetRoutingLanguages, GetRoutingQueues, GetRoutingSkills, etc.) 
    // - Create methods: ~20 more (CreateRoutingLanguage, CreateRoutingQueue, CreateRoutingSkill, etc.)
    // - Update methods: ~21 more (UpdateRoutingLanguage, UpdateRoutingQueue, UpdateRoutingSkill, etc.)
    // 
    // Required models to create or fix:
    // - Language, LanguageEntityListing (exists but not building correctly)
    // - Queue, QueueEntityListing, QueueRequest, CreateQueueRequest
    // - RoutingSkill, SkillEntityListing
    // - SkillGroup, SkillGroupEntityListing  
    // - WrapupCode, WrapupCodeEntityListing
    // - OutboundDomain, OutboundDomainEntityListing
    // - And ~50 more model classes
}