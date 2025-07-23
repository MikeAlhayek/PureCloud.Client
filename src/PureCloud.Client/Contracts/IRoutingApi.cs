using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
    /// <summary>
    /// Delete single benefit assessment.
    /// </summary>
    Task DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single benefit assessment.
    /// </summary>
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get domain
    /// </summary>
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment.
    /// </summary>
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default);
}