using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IUtilitiesApi
{
    /// <summary>
    /// Get the current system date/time
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of ServerDate</returns>
    Task<ServerDate> GetDateAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get public ip address ranges for Genesys Cloud
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of IpAddressRangeListing</returns>
    Task<IpAddressRangeListing> GetIprangesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time zones list
    /// </summary>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of TimeZoneEntityListing</returns>
    Task<TimeZoneEntityListing> GetTimezonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the information about an X509 PEM encoded certificate or certificate chain.
    /// </summary>
    /// <param name="body">Certificate</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of ParsedCertificate</returns>
    Task<ParsedCertificate> CreateCertificateDetailsAsync(Certificate body, CancellationToken cancellationToken = default);
}
