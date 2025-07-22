using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILicenseApi
{
    Task<LicenseDefinition> GetLicenseDefinitionAsync(string licenseId, CancellationToken cancellationToken = default);

    Task<LicenseDefinition[]> GetLicenseDefinitionsAsync(CancellationToken cancellationToken = default);

    Task<LicenseUser> GetLicenseUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<UserLicensesEntityListing> GetLicenseUsersAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<string[]> CreateLicenseInferAsync(IEnumerable<string> body = null, CancellationToken cancellationToken = default);

    Task<LicenseUpdateStatus[]> UpdateLicenseOrganizationAsync(LicenseBatchAssignmentRequest body = null, CancellationToken cancellationToken = default);
}