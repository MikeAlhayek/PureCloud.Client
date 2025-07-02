using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IUserApi
{
    // User Management
    Task<User> CreateUserAsync(CreateUser user, CancellationToken cancellationToken = default);

    Task<User> DeleteUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<User> GetUserAsync(string userId, UserSearchContext context = null, CancellationToken cancellationToken = default);

    Task<User> GetCurrentUserAsync(IEnumerable<string> expands = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default);

    Task<User> UpdateUpdateAsync(string userId, UpdateUser user, CancellationToken cancellationToken = default);

    // Search
    Task<SearchResult<User>> SearchUsersAsync(UserSearchRequest request, CancellationToken cancellationToken = default);

    Task<UsersSearchResponse> CreateUsersSearchAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    Task<UsersSearchResponse> CreateUsersSearchConversationTargetAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    Task<UsersSearchResponse> CreateUsersSearchQueuemembersManageAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    Task<UsersSearchResponse> CreateUsersSearchTeamsAssignAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    // Analytics
    Task<AsyncQueryStatus> GetAnalyticsUsersAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<UserAsyncAggregateQueryResponse> GetAnalyticsUsersAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    Task<AnalyticsUserDetailsAsyncQueryResponse> GetAnalyticsUsersDetailsJobResultsAsync(string jobId, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DataAvailabilityResponse> GetAnalyticsUsersDetailsJobsAvailabilityAsync(CancellationToken cancellationToken = default);

    Task<UserActivityResponse> CreateAnalyticsUsersActivityQueryAsync(UserActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsUsersAggregatesJobsAsync(UserAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    Task<UserAggregateQueryResponse> CreateAnalyticsUsersAggregatesQueryAsync(UserAggregationQuery body, CancellationToken cancellationToken = default);

    Task<AsyncQueryResponse> CreateAnalyticsUsersDetailsJobsAsync(AsyncUserDetailsQuery body, CancellationToken cancellationToken = default);

    Task<AnalyticsUserDetailsQueryResponse> CreateAnalyticsUsersDetailsQueryAsync(UserDetailsQuery body, CancellationToken cancellationToken = default);

    Task<UserObservationQueryResponse> CreateAnalyticsUsersObservationsQueryAsync(UserObservationQuery body, CancellationToken cancellationToken = default);

    // Authorization
    Task<List<AuthzDivision>> GetAuthorizationDivisionspermittedMeAsync(string permission, string name = null, CancellationToken cancellationToken = default);

    Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedMeAsync(string permission, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedSubjectIdAsync(string subjectId, string permission, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<AuthzSubject> GetAuthorizationSubjectAsync(string subjectId, bool? includeDuplicates = null, CancellationToken cancellationToken = default);

    Task<AuthzSubject> GetAuthorizationSubjectsMeAsync(bool? includeDuplicates = null, CancellationToken cancellationToken = default);

    Task CreateAuthorizationSubjectBulkaddAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default);

    Task CreateAuthorizationSubjectBulkremoveAsync(string subjectId, RoleDivisionGrants body, CancellationToken cancellationToken = default);

    Task CreateAuthorizationSubjectBulkreplaceAsync(string subjectId, RoleDivisionGrants body, string subjectType = null, CancellationToken cancellationToken = default);

    Task CreateAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, string subjectType = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteAuthorizationSubjectDivisionRoleAsync(string subjectId, string divisionId, string roleId, CancellationToken cancellationToken = default);

    // Routing
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings settings, CancellationToken cancellationToken = default);

    Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    Task<AgentMaxUtilizationResponse> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);

    Task<bool> DeleteRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    // User State and Status
    Task<RoutingStatus> UpdateUserRoutingstatusAsync(string userId, RoutingStatus body, CancellationToken cancellationToken = default);

    Task<UserState> UpdateUserStateAsync(string userId, UserState body, CancellationToken cancellationToken = default);

    Task<RoutingStatus> GetUserRoutingstatusAsync(string userId, CancellationToken cancellationToken = default);

    Task<UserState> GetUserStateAsync(string userId, CancellationToken cancellationToken = default);

    // User Skills and Languages
    Task<UserRoutingSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);

    Task<UserSkillEntityListing> UpdateUserRoutingskillsBulkAsync(string userId, List<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

    Task<UserRoutingLanguage> CreateUserRoutinglanguagesAsync(string userId, UserRoutingLanguagePost body, CancellationToken cancellationToken = default);

    Task<UserRoutingSkill> CreateUserRoutingskillsAsync(string userId, UserRoutingSkillPost body, CancellationToken cancellationToken = default);

    Task<UserLanguageEntityListing> UpdateUserRoutinglanguagesBulkAsync(string userId, List<UserRoutingLanguagePost> body, CancellationToken cancellationToken = default);

    Task<UserSkillEntityListing> PatchUserRoutingskillsBulkAsync(string userId, List<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

    Task<UserLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default);

    // User Stations
    Task CreateUserStationAssociatedstationAsync(string userId, string stationId, CancellationToken cancellationToken = default);

    Task CreateUserStationDefaultstationAsync(string userId, string stationId, CancellationToken cancellationToken = default);

    Task<UserStations> GetUserStationAsync(string userId, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserStationAssociatedstationAsync(string userId, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserStationDefaultstationAsync(string userId, CancellationToken cancellationToken = default);

    // User Verifiers
    Task<Verifier> UpdateUserVerifierAsync(string userId, string verifierId, UpdateVerifierRequest body, CancellationToken cancellationToken = default);

    Task<VerifierEntityListing> GetUserVerifiersAsync(string userId, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserVerifierAsync(string userId, string verifierId, CancellationToken cancellationToken = default);

    // User Profiles and Skills
    Task<UserProfile> GetUserProfileAsync(string userId, List<string> expand = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default);

    Task<string[]> UpdateUserProfileskillsAsync(string userId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    Task<List<string>> GetUserProfileskillsAsync(string userId, CancellationToken cancellationToken = default);

    // User Queues
    // Task<UserQueueEntityListing> GetUserQueuesAsync(string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, List<string> divisionId = null, CancellationToken cancellationToken = default);

    Task<UserQueue> UpdateUserQueueAsync(string queueId, string userId, UserQueue body, CancellationToken cancellationToken = default);

    // User Favorites
    Task<UserEntityListing> GetUserFavoritesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default);

    // User Geolocation
    Task<Geolocation> GetUserGeolocationAsync(string userId, string clientId, CancellationToken cancellationToken = default);

    Task<Geolocation> UpdateUserGeolocationAsync(string userId, string clientId, Geolocation body, CancellationToken cancellationToken = default);

    // User Call Forwarding
    Task<CallForwarding> GetUserCallforwardingAsync(string userId, CancellationToken cancellationToken = default);

    Task<CallForwarding> UpdateUserCallforwardingAsync(string userId, CallForwarding body, CancellationToken cancellationToken = default);

    Task<CallForwarding> PutUserCallforwardingAsync(string userId, CallForwarding body, CancellationToken cancellationToken = default);

    // User Out of Office
    Task<OutOfOffice> GetUserOutofofficeAsync(string userId, CancellationToken cancellationToken = default);

    Task<OutOfOffice> UpdateUserOutofofficeAsync(string userId, OutOfOffice body, CancellationToken cancellationToken = default);

    // User Adjacents
    Task<Adjacents> GetUserAdjacentsAsync(string userId, List<string> expand = null, CancellationToken cancellationToken = default);

    // User Superiors
    Task<List<User>> GetUserSuperiorsAsync(string userId, List<string> expand = null, CancellationToken cancellationToken = default);

    // User Trustors
    Task<TrustorEntityListing> GetUserTrustorsAsync(string userId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    // User Development Activities
    Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesAsync(
        List<string> userId = null,
        string moduleId = null,
        string interval = null,
        string completionInterval = null,
        string overdue = null,
        string pass = null,
        int? pageSize = null,
        int? pageNumber = null,
        string sortOrder = null,
        List<string> types = null,
        List<string> statuses = null,
        List<string> relationship = null,
        CancellationToken cancellationToken = default);

    Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesMeAsync(
        string moduleId = null,
        string interval = null,
        string completionInterval = null,
        string overdue = null,
        string pass = null,
        int? pageSize = null,
        int? pageNumber = null,
        string sortOrder = null,
        List<string> types = null,
        List<string> statuses = null,
        List<string> relationship = null,
        CancellationToken cancellationToken = default);

    Task<DevelopmentActivity> GetUsersDevelopmentActivityAsync(string activityId, string type, CancellationToken cancellationToken = default);

    Task<DevelopmentActivityAggregateResponse> CreateUsersDevelopmentActivitiesAggregatesQueryAsync(DevelopmentActivityAggregateParam body, CancellationToken cancellationToken = default);

    // User Password
    Task CreateUsersMePasswordAsync(ChangeMyPasswordRequest body, CancellationToken cancellationToken = default);

    Task CreateUserPasswordAsync(string userId, ChangePasswordRequest body, CancellationToken cancellationToken = default);

    // User Invite
    Task CreateUserInviteAsync(string userId, bool? force = null, CancellationToken cancellationToken = default);

    // Bulk Operations
    Task<UserEntityListing> UpdateUsersBulkAsync(List<PatchUser> body, CancellationToken cancellationToken = default);
}
