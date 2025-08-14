using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IStationsApi
{
    Task<bool> DeleteStationAssociatedUserAsync(string stationId, CancellationToken cancellationToken = default);

    Task<Station> GetStationAsync(string stationId, CancellationToken cancellationToken = default);

    Task<StationEntityListing> GetStationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null, CancellationToken cancellationToken = default);
}