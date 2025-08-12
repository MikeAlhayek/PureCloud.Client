using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Contracts;

public interface ILocationsApi
{
    /// <summary>
    /// Delete a location
    /// </summary>
    /// <param name="locationId">Location ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<bool> DeleteLocationAsync(string locationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Location by ID
    /// </summary>
    /// <param name="locationId">Location ID</param>
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationDefinition> GetLocationAsync(string locationId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sublocations for location ID
    /// </summary>
    /// <param name="locationId">Location ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationEntityListing> GetLocationSublocationsAsync(string locationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of all locations
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="locationIds">List of location IDs to filter by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationEntityListing> GetLocationsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> locationIds = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a location
    /// </summary>
    /// <param name="locationId">Location ID</param>
    /// <param name="body">Location</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationDefinition> UpdateLocationAsync(string locationId, LocationUpdateDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a location
    /// </summary>
    /// <param name="body">Location</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationDefinition> CreateLocationAsync(LocationCreateDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LocationsSearchResponse> CreateLocationsSearchAsync(LocationSearchRequest body, CancellationToken cancellationToken = default);
}
