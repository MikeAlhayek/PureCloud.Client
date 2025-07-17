using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IGeolocationApi
{
    Task<GeolocationSettings> GetGeolocationsSettingsAsync(CancellationToken cancellationToken = default);

    Task<Geolocation> GetUserGeolocationAsync(string userId, string clientId, CancellationToken cancellationToken = default);

    Task<GeolocationSettings> UpdateGeolocationsSettingsAsync(GeolocationSettings body, CancellationToken cancellationToken = default);

    Task<Geolocation> PatchUserGeolocationAsync(string userId, string clientId, Geolocation body, CancellationToken cancellationToken = default);
}
