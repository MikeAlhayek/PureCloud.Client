using System.Threading;
using System.Threading.Tasks;
using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IFaxApi
{
    Task<bool> DeleteFaxDocumentAsync(string documentId, CancellationToken cancellationToken = default);

    Task<FaxDocument> GetFaxDocumentAsync(string documentId, CancellationToken cancellationToken = default);

    Task<DownloadResponse> GetFaxDocumentContentAsync(string documentId, CancellationToken cancellationToken = default);

    Task<FaxDocumentEntityListing> GetFaxDocumentsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<FaxConfig> GetFaxSettingsAsync(CancellationToken cancellationToken = default);

    Task<FaxSummary> GetFaxSummaryAsync(CancellationToken cancellationToken = default);

    Task<FaxDocument> UpdateFaxDocumentAsync(string documentId, FaxDocument body, CancellationToken cancellationToken = default);

    Task<FaxConfig> UpdateFaxSettingsAsync(FaxConfig body, CancellationToken cancellationToken = default);
}
