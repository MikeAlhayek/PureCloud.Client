using PureCloud.Client.Models;
using System.Threading;
using System.Threading.Tasks;

namespace PureCloud.Client.Contracts;

public interface IInfrastructureAsCodeApi
{
    Task<AcceleratorSpecification> GetInfrastructureAsCodeAcceleratorAsync(string acceleratorId, string preferredLanguage = null, CancellationToken cancellationToken = default);

    Task<AcceleratorList> GetInfrastructureAsCodeAcceleratorsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null, CancellationToken cancellationToken = default);

    Task<InfrastructureascodeJob> GetInfrastructureAsCodeJobAsync(string jobId, bool? details = null, CancellationToken cancellationToken = default);

    Task<InfrastructureascodeJob> GetInfrastructureAsCodeJobsAsync(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null, CancellationToken cancellationToken = default);

    Task<InfrastructureascodeJob> CreateInfrastructureAsCodeJobsAsync(AcceleratorInput body, CancellationToken cancellationToken = default);
}
