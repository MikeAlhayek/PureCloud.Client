using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IOrganizationAuthorizationApi
{
    Task<TrustEntityListing> GetTrusteesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<Trustee> GetTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    Task<Trustee> CreateTrusteeAsync(TrustCreate body, CancellationToken cancellationToken = default);

    Task<Trustee> UpdateTrusteeAsync(string trusteeOrgId, TrustUpdate body, CancellationToken cancellationToken = default);

    Task DeleteTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default);

    Task<TrustorEntityListing> GetTrustorsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<Trustor> GetTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    Task DeleteTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default);

    Task<TrustRequest> GetPairingAsync(string pairingId, CancellationToken cancellationToken = default);

    Task<TrustRequest> CreatePairingAsync(TrustRequestCreate body, CancellationToken cancellationToken = default);
}