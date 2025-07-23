using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Contracts;

public interface ILocationsApi
{
    /// <summary>
    /// Delete a location
    /// </summary>
    Task DeleteLocationAsync(string locationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Location by ID
    /// </summary>
    Task<LocationDefinition> GetLocationAsync(string locationId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sublocations for location ID
    /// </summary>
    Task<LocationEntityListing> GetLocationSublocationsAsync(string locationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of all locations
    /// </summary>
    Task<LocationEntityListing> GetLocationsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> id = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a location
    /// </summary>
    Task<LocationDefinition> UpdateLocationAsync(string locationId, LocationUpdateDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a location
    /// </summary>
    Task<LocationDefinition> CreateLocationAsync(LocationCreateDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search locations
    /// </summary>
    Task<LocationsSearchResponse> CreateLocationsSearchAsync(LocationSearchRequest body, CancellationToken cancellationToken = default);
}