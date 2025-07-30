using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILicenseApi
{
    Task<LicenseDefinition> GetLicenseDefinitionAsync(string licenseId, CancellationToken cancellationToken = default);

    Task<List<LicenseDefinition>> GetLicenseDefinitionsAsync(CancellationToken cancellationToken = default);

    Task<LicenseUser> GetLicenseUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<UserLicensesEntityListing> GetLicenseUsersAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<List<string>> CreateLicenseInferAsync(IEnumerable<string> body = null, CancellationToken cancellationToken = default);

    Task<List<LicenseUpdateStatus>> UpdateLicenseOrganizationAsync(LicenseBatchAssignmentRequest body = null, CancellationToken cancellationToken = default);

    Task<LicenseOrgToggle> GetLicenseToggleAsync(string featureName, CancellationToken cancellationToken = default);

    Task<LicenseOrgToggle> CreateLicenseToggleAsync(string featureName, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> CreateLicenseUsersAsync(IEnumerable<string> body = null, CancellationToken cancellationToken = default);
}