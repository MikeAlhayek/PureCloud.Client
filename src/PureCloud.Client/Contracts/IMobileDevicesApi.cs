using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IMobileDevicesApi
{
    /// <summary>
    /// Delete device
    /// </summary>
    Task<bool> DeleteMobileDeviceAsync(string deviceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get device
    /// </summary>
    Task<UserDevice> GetMobileDeviceAsync(string deviceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of all devices
    /// </summary>
    Task<DirectoryUserDevicesListing> GetMobileDevicesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create User device
    /// </summary>
    Task<UserDevice> CreateMobileDeviceAsync(UserDevice body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update device
    /// </summary>
    Task<UserDevice> UpdateMobileDeviceAsync(string deviceId, UserDevice body = null, CancellationToken cancellationToken = default);
}