using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// StationsApi interface
/// </summary>
public interface IStationsApi
{
    /// <summary>
    /// Unassociates a user from a station
    /// </summary>
    /// <param name="stationId">Station ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteStationAssociatedUserAsync(string stationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get station by ID
    /// </summary>
    /// <param name="stationId">Station ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Station</returns>
    Task<Station> GetStationAsync(string stationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of available stations
    /// </summary>
    /// <param name="pageSize">The total page size requested</param>
    /// <param name="pageNumber">The page number requested</param>
    /// <param name="sortBy">variable name requested to sort by</param>
    /// <param name="name">Station name</param>
    /// <param name="userSelectable">True for stations that the user can select; false for stations that the user cannot select</param>
    /// <param name="webRtcUserId">Filter for the webRtc station using a specific user id</param>
    /// <param name="id">Comma separated list of station IDs</param>
    /// <param name="lineAppearanceId">lineAppearanceId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>StationEntityListing</returns>
    Task<StationEntityListing> GetStationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null, CancellationToken cancellationToken = default);
}