using System.Threading;
using System.Threading.Tasks;
using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IGeneralDataProtectionRegulationApi
{
    Task<GDPRRequest> GetGdprRequestAsync(string requestId, CancellationToken cancellationToken = default);

    Task<GDPRRequestEntityListing> GetGdprRequestsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<GDPRSubjectEntityListing> GetGdprSubjectsAsync(string searchType, string searchValue, CancellationToken cancellationToken = default);

    Task<GDPRRequest> CreateGdprRequestsAsync(GDPRRequest body, bool? deleteConfirmed = null, CancellationToken cancellationToken = default);
}
