using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IPresenceApi
{
    /// <summary>
    /// Get a Presence Definition
    /// </summary>
    Task<OrganizationPresenceDefinition> GetPresenceDefinitionAsync(string definitionId, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Definitions
    /// </summary>
    Task<OrganizationPresenceDefinitionEntityListing> GetPresenceDefinitionsAsync(string deactivated = null, IEnumerable<string> divisionId = null, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the presence settings
    /// </summary>
    Task<PresenceSettings> GetPresenceSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's Genesys Cloud presence
    /// </summary>
    Task<UserPresence> GetUserPresenceAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Definition
    /// </summary>
    Task<OrganizationPresenceDefinition> CreatePresenceDefinitionAsync(OrganizationPresenceDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the presence settings
    /// </summary>
    Task<PresenceSettings> UpdatePresenceSettingsAsync(PresenceSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's Genesys Cloud presence
    /// </summary>
    Task<UserPresence> UpdateUserPresenceAsync(string userId, UserPresence body, CancellationToken cancellationToken = default);
}