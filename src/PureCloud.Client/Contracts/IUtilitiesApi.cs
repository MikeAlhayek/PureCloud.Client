using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IUtilitiesApi
{
    Task<ServerDate> GetDateAsync(CancellationToken cancellationToken = default);

    Task<IpAddressRangeListing> GetIprangesAsync(CancellationToken cancellationToken = default);

    Task<TimeZoneEntityListing> GetTimezonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<ParsedCertificate> CreateCertificateDetailsAsync(Certificate body, CancellationToken cancellationToken = default);
}