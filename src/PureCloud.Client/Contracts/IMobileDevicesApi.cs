using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IMobileDevicesApi
{
    Task DeleteMobileDeviceAsync(string deviceId, CancellationToken cancellationToken = default);

    Task<UserDevice> GetMobileDeviceAsync(string deviceId, CancellationToken cancellationToken = default);

    Task<DirectoryUserDevicesListing> GetMobileDevicesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<UserDevice> CreateMobileDeviceAsync(UserDevice body, CancellationToken cancellationToken = default);

    Task<UserDevice> UpdateMobileDeviceAsync(string deviceId, UserDevice body = null, CancellationToken cancellationToken = default);
}