using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;
using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IEmployeeEngagementApi
{
    Task<bool> DeleteEmployeeengagementCelebrationAsync(string celebrationId, CancellationToken cancellationToken = default);

    Task<GetCelebrationListing> GetEmployeeengagementCelebrationsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<Recognition> GetEmployeeengagementRecognitionAsync(string recognitionId, CancellationToken cancellationToken = default);

    Task<bool> UpdateEmployeeengagementCelebrationAsync(string celebrationId, CelebrationStateParam body, CancellationToken cancellationToken = default);

    Task<RecognitionBase> CreateEmployeeengagementRecognitionAsync(CreateRecognition body, CancellationToken cancellationToken = default);
}
