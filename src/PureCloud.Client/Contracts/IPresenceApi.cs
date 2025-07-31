using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IPresenceApi
{
    /// <summary>
    /// Delete a Presence Definition
    /// </summary>
    /// <param name="definitionId">Organization Presence Definition ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeletePresenceDefinitionAsync(string definitionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Presence Source
    /// </summary>
    /// <param name="sourceId">Presence Source ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeletePresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Presence Definition (Legacy)
    /// </summary>
    /// <param name="presenceId">Organization Presence ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    [Obsolete("Apps should migrate to use DeletePresenceDefinitionAsync instead")]
    Task<bool> DeletePresenceDefinitionLegacyAsync(string presenceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Presence Definition
    /// </summary>
    /// <param name="definitionId">Organization Presence Definition ID</param>
    /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Presence definition</returns>
    Task<OrganizationPresenceDefinition> GetPresenceDefinitionAsync(string definitionId, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Definitions
    /// </summary>
    /// <param name="deactivated">Deactivated query can be TRUE or FALSE</param>
    /// <param name="divisionIds">One or more division IDs. If nothing is provided, the definitions associated with the list of divisions that the user has access to will be returned.</param>
    /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of presence definitions</returns>
    Task<OrganizationPresenceDefinitionEntityListing> GetPresenceDefinitionsAsync(string deactivated = null, IEnumerable<string> divisionIds = null, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the presence settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Presence settings</returns>
    Task<PresenceSettings> GetPresenceSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Presence Source
    /// </summary>
    /// <param name="sourceId">Presence Source ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Presence source</returns>
    Task<Source> GetPresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Sources
    /// </summary>
    /// <param name="deactivated">Deactivated query can be TRUE or FALSE</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of presence sources</returns>
    Task<SourceEntityListing> GetPresenceSourcesAsync(string deactivated = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's primary presence source
    /// </summary>
    /// <param name="userId">user ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User's primary presence source</returns>
    Task<UserPrimarySource> GetUserPrimarySourceAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Presence Definition (Legacy)
    /// </summary>
    /// <param name="presenceId">Organization Presence ID</param>
    /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Presence definition</returns>
    [Obsolete("Apps should migrate to use GetPresenceDefinitionAsync instead")]
    Task<OrganizationPresence> GetPresenceDefinitionLegacyAsync(string presenceId, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of Presence Definitions (Legacy)
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL</param>
    /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of presence definitions</returns>
    [Obsolete("Apps should migrate to use GetPresenceDefinitionsAsync instead")]
    Task<OrganizationPresenceEntityListing> GetPresenceDefinitionsLegacyAsync(int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of system presences
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of system presences</returns>
    Task<IEnumerable<SystemPresence>> GetSystemPresencesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's presence
    /// </summary>
    /// <param name="userId">user ID</param>
    /// <param name="sourceId">Presence source ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User presence</returns>
    Task<UserPresence> GetUserPresenceAsync(string userId, string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's Genesys Cloud presence
    /// </summary>
    /// <param name="userId">user ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User presence</returns>
    Task<UserPresence> GetUserPresencePurecloudAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk user presences for a presence source
    /// </summary>
    /// <param name="sourceId">Presence source ID</param>
    /// <param name="ids">A comma separated list of user IDs to fetch their presence status in bulk. Limit 50.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of user presences</returns>
    Task<IEnumerable<UcUserPresence>> GetUsersPresenceBulkAsync(string sourceId, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get bulk user presences for Genesys Cloud
    /// </summary>
    /// <param name="ids">A comma separated list of user IDs to fetch their presence status in bulk. Limit 50.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of user presences</returns>
    Task<IEnumerable<UcUserPresence>> GetUsersPresencesPurecloudBulkAsync(IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's presence
    /// </summary>
    /// <param name="userId">user ID</param>
    /// <param name="sourceId">Presence source ID</param>
    /// <param name="body">User presence</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user presence</returns>
    Task<UserPresence> UpdateUserPresenceAsync(string userId, string sourceId, UserPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's Genesys Cloud presence
    /// </summary>
    /// <param name="userId">user ID</param>
    /// <param name="body">User presence</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user presence</returns>
    Task<UserPresence> UpdateUserPresencePurecloudAsync(string userId, UserPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Definition
    /// </summary>
    /// <param name="body">The Presence Definition to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created presence definition</returns>
    Task<OrganizationPresenceDefinition> CreatePresenceDefinitionAsync(OrganizationPresenceDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Source
    /// </summary>
    /// <param name="body">The Presence Source to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created presence source</returns>
    Task<Source> CreatePresenceSourceAsync(Source body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Presence Definition (Legacy)
    /// </summary>
    /// <param name="body">The OrganizationPresence to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created presence definition</returns>
    [Obsolete("Apps should migrate to use CreatePresenceDefinitionAsync instead")]
    Task<OrganizationPresence> CreatePresenceDefinitionLegacyAsync(OrganizationPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Presence Definition
    /// </summary>
    /// <param name="definitionId">Organization Presence Definition ID</param>
    /// <param name="body">The OrganizationPresenceDefinition to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated presence definition</returns>
    Task<OrganizationPresenceDefinition> UpdatePresenceDefinitionAsync(string definitionId, OrganizationPresenceDefinition body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the presence settings
    /// </summary>
    /// <param name="body">Presence Settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated presence settings</returns>
    Task<PresenceSettings> UpdatePresenceSettingsAsync(PresenceSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Presence Source
    /// </summary>
    /// <param name="sourceId">Presence Source ID</param>
    /// <param name="body">The Source to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated presence source</returns>
    Task<Source> UpdatePresenceSourceAsync(string sourceId, Source body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's primary presence source
    /// </summary>
    /// <param name="userId">user ID</param>
    /// <param name="body">Primary source</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated primary source</returns>
    Task<UserPrimarySource> UpdateUserPrimarySourceAsync(string userId, UserPrimarySource body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Presence Definition (Legacy)
    /// </summary>
    /// <param name="presenceId">Organization Presence ID</param>
    /// <param name="body">The OrganizationPresence to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated presence definition</returns>
    [Obsolete("Apps should migrate to use UpdatePresenceDefinitionAsync instead")]
    Task<OrganizationPresence> UpdatePresenceDefinitionLegacyAsync(string presenceId, OrganizationPresence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Bulk update user presences
    /// </summary>
    /// <param name="body">List of User presences</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user presences</returns>
    Task<IEnumerable<UserPresence>> UpdateUsersPresencesBulkAsync(IEnumerable<MutableUserPresence> body, CancellationToken cancellationToken = default);
}
