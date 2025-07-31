using System;
using System.Threading;
using System.Threading.Tasks;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Groups;
using PureCloud.Client.Models.Locations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface ISearchApi
{
    /// <summary>
    /// Search documentation
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>DocumentationSearchResponse</returns>
    Task<DocumentationSearchResponse> CreateDocumentationSearchAsync(DocumentationSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search gkn documentation
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>GKNDocumentationSearchResponse</returns>
    Task<GKNDocumentationSearchResponse> CreateDocumentationGknSearchAsync(GKNDocumentationSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search users
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UsersSearchResponse</returns>
    Task<UsersSearchResponse> CreateUsersSearchAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search groups
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>GroupsSearchResponse</returns>
    Task<GroupsSearchResponse> CreateGroupsSearchAsync(GroupSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LocationsSearchResponse</returns>
    Task<LocationsSearchResponse> CreateLocationsSearchAsync(LocationSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonNodeSearchResponse</returns>
    Task<JsonNodeSearchResponse> GetSearchAsync(string q64, IEnumerable<string> expand = null, bool? profile = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonNodeSearchResponse</returns>
    Task<JsonNodeSearchResponse> GetSearchSuggestAsync(string q64, IEnumerable<string> expand = null, bool? profile = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search resources
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonNodeSearchResponse</returns>
    Task<JsonNodeSearchResponse> CreateSearchAsync(SearchRequest body, bool? profile = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Suggest resources
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonNodeSearchResponse</returns>
    Task<JsonNodeSearchResponse> CreateSearchSuggestAsync(SuggestSearchRequest body, bool? profile = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search sites
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SitesSearchResponse</returns>
    Task<SitesSearchResponse> CreateTelephonyProvidersEdgesSitesSearchAsync(SiteSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>GKNDocumentationSearchResponse</returns>
    Task<GKNDocumentationSearchResponse> GetDocumentationGknSearchAsync(string q64, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>DocumentationSearchResponse</returns>
    Task<DocumentationSearchResponse> GetDocumentationSearchAsync(string q64, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search groups using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>GroupsSearchResponse</returns>
    Task<GroupsSearchResponse> GetGroupsSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LocationsSearchResponse</returns>
    Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search sites using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SitesSearchResponse</returns>
    Task<SitesSearchResponse> GetTelephonyProvidersEdgesSitesSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search users using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UsersSearchResponse</returns>
    Task<UsersSearchResponse> GetUsersSearchAsync(string q64, IEnumerable<string> expand = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search
    /// </summary>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>VoicemailsSearchResponse</returns>
    Task<VoicemailsSearchResponse> GetVoicemailSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search resources
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>AnalyticsConversationWithoutAttributesMultiGetResponse</returns>
    Task<AnalyticsConversationWithoutAttributesMultiGetResponse> CreateAnalyticsConversationsTranscriptsQueryAsync(TranscriptConversationDetailSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search conversations
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonCursorSearchResponse</returns>
    Task<JsonCursorSearchResponse> CreateConversationsParticipantsAttributesSearchAsync(ConversationParticipantSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search all documents
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonNodeSearchResponse</returns>
    Task<JsonNodeSearchResponse> CreateDocumentationAllSearchAsync(DocumentationV2SearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search Documents
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>KnowledgeSearchResponse</returns>
    Task<KnowledgeSearchResponse> CreateKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search resources
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>JsonSearchResponse</returns>
    Task<JsonSearchResponse> CreateSpeechandtextanalyticsTranscriptsSearchAsync(TranscriptSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search resources
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>TeamsSearchResponse</returns>
    Task<TeamsSearchResponse> CreateTeamsSearchAsync(TeamSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search users as conversation targets
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UsersSearchResponse</returns>
    Task<UsersSearchResponse> CreateUsersSearchConversationTargetAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search manage queue member
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UsersSearchResponse</returns>
    Task<UsersSearchResponse> CreateUsersSearchQueuemembersManageAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search users assigned to teams
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>UsersSearchResponse</returns>
    Task<UsersSearchResponse> CreateUsersSearchTeamsAssignAsync(UserSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search voicemails
    /// </summary>
    /// <param name="body">Search request options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>VoicemailsSearchResponse</returns>
    Task<VoicemailsSearchResponse> CreateVoicemailSearchAsync(VoicemailSearchRequest body, CancellationToken cancellationToken = default);
}
