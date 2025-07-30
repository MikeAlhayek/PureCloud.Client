using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IPresenceApi
{
    /// <summary>
    /// Delete a Presence Definition
    /// </summary>
    Task<bool> DeletePresenceDefinitionAsync(string definitionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Presence Source
    /// </summary>
    Task<bool> DeletePresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Presence Definition (Legacy)
    /// </summary>
    [Obsolete("Apps should migrate to use DeletePresenceDefinitionAsync instead")]
    Task<bool> DeletePresenceDefinitionLegacyAsync(string presenceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Presence Definition
    /// </summary>
    Task<OrganizationPresenceDefinition> GetPresenceDefinitionAsync(string definitionId, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Definitions
    /// </summary>
    Task<OrganizationPresenceDefinitionEntityListing> GetPresenceDefinitionsAsync(string deactivated = null, IEnumerable<string> divisionIds = null, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the presence settings
    /// </summary>
    Task<PresenceSettings> GetPresenceSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Presence Source
    /// </summary>
    Task<Source> GetPresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Sources
    /// </summary>
    Task<SourceEntityListing> GetPresenceSourcesAsync(string deactivated = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's primary presence source
    /// </summary>
    Task<UserPrimarySource> GetUserPrimarySourceAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Presence Definition (Legacy)
    /// </summary>
    [Obsolete("Apps should migrate to use GetPresenceDefinitionAsync instead")]
    Task<OrganizationPresence> GetPresenceDefinitionLegacyAsync(string presenceId, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Definitions (Legacy)
    /// </summary>
    [Obsolete("Apps should migrate to use GetPresenceDefinitionsAsync instead")]
    Task<OrganizationPresenceEntityListing> GetPresenceDefinitionsLegacyAsync(int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of system presences
    /// </summary>
    Task<IEnumerable<SystemPresence>> GetSystemPresencesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's presence
    /// </summary>
    Task<UserPresence> GetUserPresenceAsync(string userId, string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's Genesys Cloud presence
    /// </summary>
    Task<UserPresence> GetUserPresencePurecloudAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk user presences for a presence source
    /// </summary>
    Task<IEnumerable<UcUserPresence>> GetUsersPresenceBulkAsync(string sourceId, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk user presences for Genesys Cloud
    /// </summary>
    Task<IEnumerable<UcUserPresence>> GetUsersPresencesPurecloudBulkAsync(IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's presence
    /// </summary>
    Task<UserPresence> UpdateUserPresenceAsync(string userId, string sourceId, UserPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's Genesys Cloud presence
    /// </summary>
    Task<UserPresence> UpdateUserPresencePurecloudAsync(string userId, UserPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Definition
    /// </summary>
    Task<OrganizationPresenceDefinition> CreatePresenceDefinitionAsync(OrganizationPresenceDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Source
    /// </summary>
    Task<Source> CreatePresenceSourceAsync(Source body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Definition (Legacy)
    /// </summary>
    [Obsolete("Apps should migrate to use CreatePresenceDefinitionAsync instead")]
    Task<OrganizationPresence> CreatePresenceDefinitionLegacyAsync(OrganizationPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Presence Definition
    /// </summary>
    Task<OrganizationPresenceDefinition> UpdatePresenceDefinitionAsync(string definitionId, OrganizationPresenceDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the presence settings
    /// </summary>
    Task<PresenceSettings> UpdatePresenceSettingsAsync(PresenceSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Presence Source
    /// </summary>
    Task<Source> UpdatePresenceSourceAsync(string sourceId, Source body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's primary presence source
    /// </summary>
    Task<UserPrimarySource> UpdateUserPrimarySourceAsync(string userId, UserPrimarySource body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Presence Definition (Legacy)
    /// </summary>
    [Obsolete("Apps should migrate to use UpdatePresenceDefinitionAsync instead")]
    Task<OrganizationPresence> UpdatePresenceDefinitionLegacyAsync(string presenceId, OrganizationPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk update user presences
    /// </summary>
    Task<IEnumerable<UserPresence>> UpdateUsersPresencesBulkAsync(IEnumerable<MutableUserPresence> body, CancellationToken cancellationToken = default);
}