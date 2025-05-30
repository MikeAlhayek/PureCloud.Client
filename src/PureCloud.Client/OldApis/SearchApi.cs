using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client.Apis;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISearchApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>GKNDocumentationSearchResponse</returns>

    GKNDocumentationSearchResponse GetDocumentationGknSearch(string q64);

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>ApiResponse of GKNDocumentationSearchResponse</returns>

    ApiResponse<GKNDocumentationSearchResponse> GetDocumentationGknSearchWithHttpInfo(string q64);

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>DocumentationSearchResponse</returns>

    DocumentationSearchResponse GetDocumentationSearch(string q64);

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>ApiResponse of DocumentationSearchResponse</returns>

    ApiResponse<DocumentationSearchResponse> GetDocumentationSearchWithHttpInfo(string q64);

    /// <summary>
    /// Search groups using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>GroupsSearchResponse</returns>

    GroupsSearchResponse GetGroupsSearch(string q64, List<string> expand = null);

    /// <summary>
    /// Search groups using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>ApiResponse of GroupsSearchResponse</returns>

    ApiResponse<GroupsSearchResponse> GetGroupsSearchWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>LocationsSearchResponse</returns>

    LocationsSearchResponse GetLocationsSearch(string q64, List<string> expand = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    ApiResponse<LocationsSearchResponse> GetLocationsSearchWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search using the q64 value returned from a previous search.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    JsonNodeSearchResponse GetSearch(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Search using the q64 value returned from a previous search.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    ApiResponse<JsonNodeSearchResponse> GetSearchWithHttpInfo(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    JsonNodeSearchResponse GetSearchSuggest(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    ApiResponse<JsonNodeSearchResponse> GetSearchSuggestWithHttpInfo(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Search sites using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>SitesSearchResponse</returns>

    SitesSearchResponse GetTelephonyProvidersEdgesSitesSearch(string q64, List<string> expand = null);

    /// <summary>
    /// Search sites using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>ApiResponse of SitesSearchResponse</returns>

    ApiResponse<SitesSearchResponse> GetTelephonyProvidersEdgesSitesSearchWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search users using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>UsersSearchResponse</returns>

    UsersSearchResponse GetUsersSearch(string q64, List<string> expand = null, string integrationPresenceSource = null);

    /// <summary>
    /// Search users using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    ApiResponse<UsersSearchResponse> GetUsersSearchWithHttpInfo(string q64, List<string> expand = null, string integrationPresenceSource = null);

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>VoicemailsSearchResponse</returns>

    VoicemailsSearchResponse GetVoicemailSearch(string q64, List<string> expand = null);

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>ApiResponse of VoicemailsSearchResponse</returns>

    ApiResponse<VoicemailsSearchResponse> GetVoicemailSearchWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>AnalyticsConversationWithoutAttributesMultiGetResponse</returns>

    AnalyticsConversationWithoutAttributesMultiGetResponse PostAnalyticsConversationsTranscriptsQuery(TranscriptConversationDetailSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of AnalyticsConversationWithoutAttributesMultiGetResponse</returns>

    ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse> PostAnalyticsConversationsTranscriptsQueryWithHttpInfo(TranscriptConversationDetailSearchRequest body);

    /// <summary>
    /// Search conversations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>JsonCursorSearchResponse</returns>

    JsonCursorSearchResponse PostConversationsParticipantsAttributesSearch(ConversationParticipantSearchRequest body);

    /// <summary>
    /// Search conversations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of JsonCursorSearchResponse</returns>

    ApiResponse<JsonCursorSearchResponse> PostConversationsParticipantsAttributesSearchWithHttpInfo(ConversationParticipantSearchRequest body);

    /// <summary>
    /// Search all documents
    /// </summary>
    /// <remarks>
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>JsonNodeSearchResponse</returns>

    JsonNodeSearchResponse PostDocumentationAllSearch(DocumentationV2SearchRequest body);

    /// <summary>
    /// Search all documents
    /// </summary>
    /// <remarks>
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    ApiResponse<JsonNodeSearchResponse> PostDocumentationAllSearchWithHttpInfo(DocumentationV2SearchRequest body);

    /// <summary>
    /// Search gkn documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>GKNDocumentationSearchResponse</returns>

    GKNDocumentationSearchResponse PostDocumentationGknSearch(GKNDocumentationSearchRequest body);

    /// <summary>
    /// Search gkn documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of GKNDocumentationSearchResponse</returns>

    ApiResponse<GKNDocumentationSearchResponse> PostDocumentationGknSearchWithHttpInfo(GKNDocumentationSearchRequest body);

    /// <summary>
    /// Search documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>DocumentationSearchResponse</returns>

    DocumentationSearchResponse PostDocumentationSearch(DocumentationSearchRequest body);

    /// <summary>
    /// Search documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of DocumentationSearchResponse</returns>

    ApiResponse<DocumentationSearchResponse> PostDocumentationSearchWithHttpInfo(DocumentationSearchRequest body);

    /// <summary>
    /// Search groups
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>GroupsSearchResponse</returns>

    GroupsSearchResponse PostGroupsSearch(GroupSearchRequest body);

    /// <summary>
    /// Search groups
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of GroupsSearchResponse</returns>

    ApiResponse<GroupsSearchResponse> PostGroupsSearchWithHttpInfo(GroupSearchRequest body);

    /// <summary>
    /// Search Documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>KnowledgeSearchResponse</returns>
    [Obsolete]
    KnowledgeSearchResponse PostKnowledgeKnowledgebaseSearch(string knowledgeBaseId, KnowledgeSearchRequest body = null);

    /// <summary>
    /// Search Documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of KnowledgeSearchResponse</returns>
    [Obsolete]
    ApiResponse<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchWithHttpInfo(string knowledgeBaseId, KnowledgeSearchRequest body = null);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>LocationsSearchResponse</returns>

    LocationsSearchResponse PostLocationsSearch(LocationSearchRequest body);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    ApiResponse<LocationsSearchResponse> PostLocationsSearchWithHttpInfo(LocationSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    JsonNodeSearchResponse PostSearch(SearchRequest body, bool? profile = null);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    ApiResponse<JsonNodeSearchResponse> PostSearchWithHttpInfo(SearchRequest body, bool? profile = null);

    /// <summary>
    /// Suggest resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    JsonNodeSearchResponse PostSearchSuggest(SuggestSearchRequest body, bool? profile = null);

    /// <summary>
    /// Suggest resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    ApiResponse<JsonNodeSearchResponse> PostSearchSuggestWithHttpInfo(SuggestSearchRequest body, bool? profile = null);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>JsonSearchResponse</returns>

    JsonSearchResponse PostSpeechandtextanalyticsTranscriptsSearch(TranscriptSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of JsonSearchResponse</returns>

    ApiResponse<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo(TranscriptSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>TeamsSearchResponse</returns>

    TeamsSearchResponse PostTeamsSearch(TeamSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of TeamsSearchResponse</returns>

    ApiResponse<TeamsSearchResponse> PostTeamsSearchWithHttpInfo(TeamSearchRequest body);

    /// <summary>
    /// Search sites
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>SitesSearchResponse</returns>

    SitesSearchResponse PostTelephonyProvidersEdgesSitesSearch(SiteSearchRequest body);

    /// <summary>
    /// Search sites
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of SitesSearchResponse</returns>

    ApiResponse<SitesSearchResponse> PostTelephonyProvidersEdgesSitesSearchWithHttpInfo(SiteSearchRequest body);

    /// <summary>
    /// Search users
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    UsersSearchResponse PostUsersSearch(UserSearchRequest body);

    /// <summary>
    /// Search users
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    ApiResponse<UsersSearchResponse> PostUsersSearchWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search users as conversation targets
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    UsersSearchResponse PostUsersSearchConversationTarget(UserSearchRequest body);

    /// <summary>
    /// Search users as conversation targets
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    ApiResponse<UsersSearchResponse> PostUsersSearchConversationTargetWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search manage queue member
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    UsersSearchResponse PostUsersSearchQueuemembersManage(UserSearchRequest body);

    /// <summary>
    /// Search manage queue member
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    ApiResponse<UsersSearchResponse> PostUsersSearchQueuemembersManageWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search users assigned to teams
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    UsersSearchResponse PostUsersSearchTeamsAssign(UserSearchRequest body);

    /// <summary>
    /// Search users assigned to teams
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    ApiResponse<UsersSearchResponse> PostUsersSearchTeamsAssignWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search voicemails
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>VoicemailsSearchResponse</returns>

    VoicemailsSearchResponse PostVoicemailSearch(VoicemailSearchRequest body);

    /// <summary>
    /// Search voicemails
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of VoicemailsSearchResponse</returns>

    ApiResponse<VoicemailsSearchResponse> PostVoicemailSearchWithHttpInfo(VoicemailSearchRequest body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of GKNDocumentationSearchResponse</returns>

    Task<GKNDocumentationSearchResponse> GetDocumentationGknSearchAsync(string q64);

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of ApiResponse (GKNDocumentationSearchResponse)</returns>

    Task<ApiResponse<GKNDocumentationSearchResponse>> GetDocumentationGknSearchAsyncWithHttpInfo(string q64);

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of DocumentationSearchResponse</returns>

    Task<DocumentationSearchResponse> GetDocumentationSearchAsync(string q64);

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of ApiResponse (DocumentationSearchResponse)</returns>

    Task<ApiResponse<DocumentationSearchResponse>> GetDocumentationSearchAsyncWithHttpInfo(string q64);

    /// <summary>
    /// Search groups using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of GroupsSearchResponse</returns>

    Task<GroupsSearchResponse> GetGroupsSearchAsync(string q64, List<string> expand = null);

    /// <summary>
    /// Search groups using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of ApiResponse (GroupsSearchResponse)</returns>

    Task<ApiResponse<GroupsSearchResponse>> GetGroupsSearchAsyncWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, List<string> expand = null);

    /// <summary>
    /// Search locations using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    Task<ApiResponse<LocationsSearchResponse>> GetLocationsSearchAsyncWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search using the q64 value returned from a previous search.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    Task<JsonNodeSearchResponse> GetSearchAsync(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Search using the q64 value returned from a previous search.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    Task<ApiResponse<JsonNodeSearchResponse>> GetSearchAsyncWithHttpInfo(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    Task<JsonNodeSearchResponse> GetSearchSuggestAsync(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    Task<ApiResponse<JsonNodeSearchResponse>> GetSearchSuggestAsyncWithHttpInfo(string q64, List<string> expand = null, bool? profile = null);

    /// <summary>
    /// Search sites using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of SitesSearchResponse</returns>

    Task<SitesSearchResponse> GetTelephonyProvidersEdgesSitesSearchAsync(string q64, List<string> expand = null);

    /// <summary>
    /// Search sites using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of ApiResponse (SitesSearchResponse)</returns>

    Task<ApiResponse<SitesSearchResponse>> GetTelephonyProvidersEdgesSitesSearchAsyncWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search users using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>Task of UsersSearchResponse</returns>

    Task<UsersSearchResponse> GetUsersSearchAsync(string q64, List<string> expand = null, string integrationPresenceSource = null);

    /// <summary>
    /// Search users using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    Task<ApiResponse<UsersSearchResponse>> GetUsersSearchAsyncWithHttpInfo(string q64, List<string> expand = null, string integrationPresenceSource = null);

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of VoicemailsSearchResponse</returns>

    Task<VoicemailsSearchResponse> GetVoicemailSearchAsync(string q64, List<string> expand = null);

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>

    Task<ApiResponse<VoicemailsSearchResponse>> GetVoicemailSearchAsyncWithHttpInfo(string q64, List<string> expand = null);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of AnalyticsConversationWithoutAttributesMultiGetResponse</returns>

    Task<AnalyticsConversationWithoutAttributesMultiGetResponse> PostAnalyticsConversationsTranscriptsQueryAsync(TranscriptConversationDetailSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (AnalyticsConversationWithoutAttributesMultiGetResponse)</returns>

    Task<ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse>> PostAnalyticsConversationsTranscriptsQueryAsyncWithHttpInfo(TranscriptConversationDetailSearchRequest body);

    /// <summary>
    /// Search conversations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of JsonCursorSearchResponse</returns>

    Task<JsonCursorSearchResponse> PostConversationsParticipantsAttributesSearchAsync(ConversationParticipantSearchRequest body);

    /// <summary>
    /// Search conversations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (JsonCursorSearchResponse)</returns>

    Task<ApiResponse<JsonCursorSearchResponse>> PostConversationsParticipantsAttributesSearchAsyncWithHttpInfo(ConversationParticipantSearchRequest body);

    /// <summary>
    /// Search all documents
    /// </summary>
    /// <remarks>
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    Task<JsonNodeSearchResponse> PostDocumentationAllSearchAsync(DocumentationV2SearchRequest body);

    /// <summary>
    /// Search all documents
    /// </summary>
    /// <remarks>
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    Task<ApiResponse<JsonNodeSearchResponse>> PostDocumentationAllSearchAsyncWithHttpInfo(DocumentationV2SearchRequest body);

    /// <summary>
    /// Search gkn documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of GKNDocumentationSearchResponse</returns>

    Task<GKNDocumentationSearchResponse> PostDocumentationGknSearchAsync(GKNDocumentationSearchRequest body);

    /// <summary>
    /// Search gkn documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (GKNDocumentationSearchResponse)</returns>

    Task<ApiResponse<GKNDocumentationSearchResponse>> PostDocumentationGknSearchAsyncWithHttpInfo(GKNDocumentationSearchRequest body);

    /// <summary>
    /// Search documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of DocumentationSearchResponse</returns>

    Task<DocumentationSearchResponse> PostDocumentationSearchAsync(DocumentationSearchRequest body);

    /// <summary>
    /// Search documentation
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (DocumentationSearchResponse)</returns>

    Task<ApiResponse<DocumentationSearchResponse>> PostDocumentationSearchAsyncWithHttpInfo(DocumentationSearchRequest body);

    /// <summary>
    /// Search groups
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of GroupsSearchResponse</returns>

    Task<GroupsSearchResponse> PostGroupsSearchAsync(GroupSearchRequest body);

    /// <summary>
    /// Search groups
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (GroupsSearchResponse)</returns>

    Task<ApiResponse<GroupsSearchResponse>> PostGroupsSearchAsyncWithHttpInfo(GroupSearchRequest body);

    /// <summary>
    /// Search Documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of KnowledgeSearchResponse</returns>
    [Obsolete]
    Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null);

    /// <summary>
    /// Search Documents
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (KnowledgeSearchResponse)</returns>
    [Obsolete]
    Task<ApiResponse<KnowledgeSearchResponse>> PostKnowledgeKnowledgebaseSearchAsyncWithHttpInfo(string knowledgeBaseId, KnowledgeSearchRequest body = null);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    Task<LocationsSearchResponse> PostLocationsSearchAsync(LocationSearchRequest body);

    /// <summary>
    /// Search locations
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    Task<ApiResponse<LocationsSearchResponse>> PostLocationsSearchAsyncWithHttpInfo(LocationSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    Task<JsonNodeSearchResponse> PostSearchAsync(SearchRequest body, bool? profile = null);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    Task<ApiResponse<JsonNodeSearchResponse>> PostSearchAsyncWithHttpInfo(SearchRequest body, bool? profile = null);

    /// <summary>
    /// Suggest resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    Task<JsonNodeSearchResponse> PostSearchSuggestAsync(SuggestSearchRequest body, bool? profile = null);

    /// <summary>
    /// Suggest resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    Task<ApiResponse<JsonNodeSearchResponse>> PostSearchSuggestAsyncWithHttpInfo(SuggestSearchRequest body, bool? profile = null);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of JsonSearchResponse</returns>

    Task<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchAsync(TranscriptSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (JsonSearchResponse)</returns>

    Task<ApiResponse<JsonSearchResponse>> PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo(TranscriptSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of TeamsSearchResponse</returns>

    Task<TeamsSearchResponse> PostTeamsSearchAsync(TeamSearchRequest body);

    /// <summary>
    /// Search resources.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (TeamsSearchResponse)</returns>

    Task<ApiResponse<TeamsSearchResponse>> PostTeamsSearchAsyncWithHttpInfo(TeamSearchRequest body);

    /// <summary>
    /// Search sites
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of SitesSearchResponse</returns>

    Task<SitesSearchResponse> PostTelephonyProvidersEdgesSitesSearchAsync(SiteSearchRequest body);

    /// <summary>
    /// Search sites
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (SitesSearchResponse)</returns>

    Task<ApiResponse<SitesSearchResponse>> PostTelephonyProvidersEdgesSitesSearchAsyncWithHttpInfo(SiteSearchRequest body);

    /// <summary>
    /// Search users
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    Task<UsersSearchResponse> PostUsersSearchAsync(UserSearchRequest body);

    /// <summary>
    /// Search users
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    Task<ApiResponse<UsersSearchResponse>> PostUsersSearchAsyncWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search users as conversation targets
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    Task<UsersSearchResponse> PostUsersSearchConversationTargetAsync(UserSearchRequest body);

    /// <summary>
    /// Search users as conversation targets
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    Task<ApiResponse<UsersSearchResponse>> PostUsersSearchConversationTargetAsyncWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search manage queue member
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    Task<UsersSearchResponse> PostUsersSearchQueuemembersManageAsync(UserSearchRequest body);

    /// <summary>
    /// Search manage queue member
    /// </summary>
    /// <remarks>
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    Task<ApiResponse<UsersSearchResponse>> PostUsersSearchQueuemembersManageAsyncWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search users assigned to teams
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    Task<UsersSearchResponse> PostUsersSearchTeamsAssignAsync(UserSearchRequest body);

    /// <summary>
    /// Search users assigned to teams
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    Task<ApiResponse<UsersSearchResponse>> PostUsersSearchTeamsAssignAsyncWithHttpInfo(UserSearchRequest body);

    /// <summary>
    /// Search voicemails
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of VoicemailsSearchResponse</returns>

    Task<VoicemailsSearchResponse> PostVoicemailSearchAsync(VoicemailSearchRequest body);

    /// <summary>
    /// Search voicemails
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>

    Task<ApiResponse<VoicemailsSearchResponse>> PostVoicemailSearchAsyncWithHttpInfo(VoicemailSearchRequest body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class SearchApi : ISearchApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchApi"/> class.
    /// </summary>
    /// <returns></returns>
    public SearchApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SearchApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public SearchApi(Configuration configuration = null)
    {
        if (configuration == null) // use the default one in Configuration
        {
            Configuration = Configuration.Default;
        }
        else
        {
            Configuration = configuration;
        }

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
    public void SetBasePath(string basePath)
    {
        // do nothing
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public Configuration Configuration { get; set; }

    /// <summary>
    /// Gets the default header.
    /// </summary>
    /// <returns>Dictionary of HTTP header</returns>
    [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
    public Dictionary<string, string> DefaultHeader()
    {
        return Configuration.DefaultHeader;
    }

    /// <summary>
    /// Add default header.
    /// </summary>
    /// <param name="key">Header field name.</param>
    /// <param name="value">Header field value.</param>
    /// <returns></returns>
    [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
    public void AddDefaultHeader(string key, string value)
    {
        Configuration.AddDefaultHeader(key, value);
    }


    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>GKNDocumentationSearchResponse</returns>

    public GKNDocumentationSearchResponse GetDocumentationGknSearch(string q64)
    {
        ApiResponse<GKNDocumentationSearchResponse> localVarResponse = GetDocumentationGknSearchWithHttpInfo(q64);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>ApiResponse of GKNDocumentationSearchResponse</returns>

    public ApiResponse<GKNDocumentationSearchResponse> GetDocumentationGknSearchWithHttpInfo(string q64)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetDocumentationGknSearch");
        }

        var localVarPath = "/api/v2/documentation/gkn/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        // Header params

        // Form params

        // Body param


        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationGknSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationGknSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GKNDocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GKNDocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GKNDocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of GKNDocumentationSearchResponse</returns>

    public async Task<GKNDocumentationSearchResponse> GetDocumentationGknSearchAsync(string q64)
    {
        ApiResponse<GKNDocumentationSearchResponse> localVarResponse = await GetDocumentationGknSearchAsyncWithHttpInfo(q64);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search gkn documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of ApiResponse (GKNDocumentationSearchResponse)</returns>

    public async Task<ApiResponse<GKNDocumentationSearchResponse>> GetDocumentationGknSearchAsyncWithHttpInfo(string q64)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetDocumentationGknSearch");
        }

        var localVarPath = "/api/v2/documentation/gkn/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        // Header params

        // Form params

        // Body param


        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationGknSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationGknSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GKNDocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GKNDocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GKNDocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>DocumentationSearchResponse</returns>

    public DocumentationSearchResponse GetDocumentationSearch(string q64)
    {
        ApiResponse<DocumentationSearchResponse> localVarResponse = GetDocumentationSearchWithHttpInfo(q64);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>ApiResponse of DocumentationSearchResponse</returns>

    public ApiResponse<DocumentationSearchResponse> GetDocumentationSearchWithHttpInfo(string q64)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetDocumentationSearch");
        }

        var localVarPath = "/api/v2/documentation/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        // Header params

        // Form params

        // Body param


        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<DocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (DocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of DocumentationSearchResponse</returns>

    public async Task<DocumentationSearchResponse> GetDocumentationSearchAsync(string q64)
    {
        ApiResponse<DocumentationSearchResponse> localVarResponse = await GetDocumentationSearchAsyncWithHttpInfo(q64);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search documentation using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <returns>Task of ApiResponse (DocumentationSearchResponse)</returns>

    public async Task<ApiResponse<DocumentationSearchResponse>> GetDocumentationSearchAsyncWithHttpInfo(string q64)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetDocumentationSearch");
        }

        var localVarPath = "/api/v2/documentation/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        // Header params

        // Form params

        // Body param


        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetDocumentationSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<DocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (DocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search groups using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>GroupsSearchResponse</returns>

    public GroupsSearchResponse GetGroupsSearch(string q64, List<string> expand = null)
    {
        ApiResponse<GroupsSearchResponse> localVarResponse = GetGroupsSearchWithHttpInfo(q64, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search groups using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>ApiResponse of GroupsSearchResponse</returns>

    public ApiResponse<GroupsSearchResponse> GetGroupsSearchWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetGroupsSearch");
        }

        var localVarPath = "/api/v2/groups/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGroupsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGroupsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GroupsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GroupsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search groups using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of GroupsSearchResponse</returns>

    public async Task<GroupsSearchResponse> GetGroupsSearchAsync(string q64, List<string> expand = null)
    {
        ApiResponse<GroupsSearchResponse> localVarResponse = await GetGroupsSearchAsyncWithHttpInfo(q64, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search groups using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of ApiResponse (GroupsSearchResponse)</returns>

    public async Task<ApiResponse<GroupsSearchResponse>> GetGroupsSearchAsyncWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetGroupsSearch");
        }

        var localVarPath = "/api/v2/groups/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGroupsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetGroupsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GroupsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GroupsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>LocationsSearchResponse</returns>

    public LocationsSearchResponse GetLocationsSearch(string q64, List<string> expand = null)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = GetLocationsSearchWithHttpInfo(q64, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    public ApiResponse<LocationsSearchResponse> GetLocationsSearchWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    public async Task<LocationsSearchResponse> GetLocationsSearchAsync(string q64, List<string> expand = null)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = await GetLocationsSearchAsyncWithHttpInfo(q64, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search locations using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Provides more details about a specified resource (optional)</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    public async Task<ApiResponse<LocationsSearchResponse>> GetLocationsSearchAsyncWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search using the q64 value returned from a previous search. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    public JsonNodeSearchResponse GetSearch(string q64, List<string> expand = null, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = GetSearchWithHttpInfo(q64, expand, profile);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search using the q64 value returned from a previous search. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    public ApiResponse<JsonNodeSearchResponse> GetSearchWithHttpInfo(string q64, List<string> expand = null, bool? profile = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetSearch");
        }

        var localVarPath = "/api/v2/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search using the q64 value returned from a previous search. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    public async Task<JsonNodeSearchResponse> GetSearchAsync(string q64, List<string> expand = null, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = await GetSearchAsyncWithHttpInfo(q64, expand, profile);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search using the q64 value returned from a previous search. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    public async Task<ApiResponse<JsonNodeSearchResponse>> GetSearchAsyncWithHttpInfo(string q64, List<string> expand = null, bool? profile = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetSearch");
        }

        var localVarPath = "/api/v2/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    public JsonNodeSearchResponse GetSearchSuggest(string q64, List<string> expand = null, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = GetSearchSuggestWithHttpInfo(q64, expand, profile);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    public ApiResponse<JsonNodeSearchResponse> GetSearchSuggestWithHttpInfo(string q64, List<string> expand = null, bool? profile = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetSearchSuggest");
        }

        var localVarPath = "/api/v2/search/suggest";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    public async Task<JsonNodeSearchResponse> GetSearchSuggestAsync(string q64, List<string> expand = null, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = await GetSearchSuggestAsyncWithHttpInfo(q64, expand, profile);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Suggest resources using the q64 value returned from a previous suggest query. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">Which fields, if any, to expand (optional)</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    public async Task<ApiResponse<JsonNodeSearchResponse>> GetSearchSuggestAsyncWithHttpInfo(string q64, List<string> expand = null, bool? profile = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetSearchSuggest");
        }

        var localVarPath = "/api/v2/search/suggest";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search sites using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>SitesSearchResponse</returns>

    public SitesSearchResponse GetTelephonyProvidersEdgesSitesSearch(string q64, List<string> expand = null)
    {
        ApiResponse<SitesSearchResponse> localVarResponse = GetTelephonyProvidersEdgesSitesSearchWithHttpInfo(q64, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search sites using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>ApiResponse of SitesSearchResponse</returns>

    public ApiResponse<SitesSearchResponse> GetTelephonyProvidersEdgesSitesSearchWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetTelephonyProvidersEdgesSitesSearch");
        }

        var localVarPath = "/api/v2/telephony/providers/edges/sites/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetTelephonyProvidersEdgesSitesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetTelephonyProvidersEdgesSitesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SitesSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (SitesSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SitesSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search sites using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of SitesSearchResponse</returns>

    public async Task<SitesSearchResponse> GetTelephonyProvidersEdgesSitesSearchAsync(string q64, List<string> expand = null)
    {
        ApiResponse<SitesSearchResponse> localVarResponse = await GetTelephonyProvidersEdgesSitesSearchAsyncWithHttpInfo(q64, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search sites using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of ApiResponse (SitesSearchResponse)</returns>

    public async Task<ApiResponse<SitesSearchResponse>> GetTelephonyProvidersEdgesSitesSearchAsyncWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetTelephonyProvidersEdgesSitesSearch");
        }

        var localVarPath = "/api/v2/telephony/providers/edges/sites/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetTelephonyProvidersEdgesSitesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetTelephonyProvidersEdgesSitesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SitesSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (SitesSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SitesSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search users using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>UsersSearchResponse</returns>

    public UsersSearchResponse GetUsersSearch(string q64, List<string> expand = null, string integrationPresenceSource = null)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = GetUsersSearchWithHttpInfo(q64, expand, integrationPresenceSource);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search users using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    public ApiResponse<UsersSearchResponse> GetUsersSearchWithHttpInfo(string q64, List<string> expand = null, string integrationPresenceSource = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetUsersSearch");
        }

        var localVarPath = "/api/v2/users/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (integrationPresenceSource != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("integrationPresenceSource", Configuration.ApiClient.ParameterToString(integrationPresenceSource)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search users using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>Task of UsersSearchResponse</returns>

    public async Task<UsersSearchResponse> GetUsersSearchAsync(string q64, List<string> expand = null, string integrationPresenceSource = null)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = await GetUsersSearchAsyncWithHttpInfo(q64, expand, integrationPresenceSource);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search users using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <param name="integrationPresenceSource">integrationPresenceSource (optional)</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    public async Task<ApiResponse<UsersSearchResponse>> GetUsersSearchAsyncWithHttpInfo(string q64, List<string> expand = null, string integrationPresenceSource = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetUsersSearch");
        }

        var localVarPath = "/api/v2/users/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        if (integrationPresenceSource != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("integrationPresenceSource", Configuration.ApiClient.ParameterToString(integrationPresenceSource)));
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>VoicemailsSearchResponse</returns>

    public VoicemailsSearchResponse GetVoicemailSearch(string q64, List<string> expand = null)
    {
        ApiResponse<VoicemailsSearchResponse> localVarResponse = GetVoicemailSearchWithHttpInfo(q64, expand);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>ApiResponse of VoicemailsSearchResponse</returns>

    public ApiResponse<VoicemailsSearchResponse> GetVoicemailSearchWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetVoicemailSearch");
        }

        var localVarPath = "/api/v2/voicemail/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetVoicemailSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetVoicemailSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (VoicemailsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of VoicemailsSearchResponse</returns>

    public async Task<VoicemailsSearchResponse> GetVoicemailSearchAsync(string q64, List<string> expand = null)
    {
        ApiResponse<VoicemailsSearchResponse> localVarResponse = await GetVoicemailSearchAsyncWithHttpInfo(q64, expand);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search voicemails using the q64 value returned from a previous search 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="q64">q64</param>
    /// <param name="expand">expand (optional)</param>
    /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>

    public async Task<ApiResponse<VoicemailsSearchResponse>> GetVoicemailSearchAsyncWithHttpInfo(string q64, List<string> expand = null)
    {
        // verify the required parameter 'q64' is set
        if (q64 == null)
        {
            throw new ApiException(400, "Missing required parameter 'q64' when calling SearchApi->GetVoicemailSearch");
        }

        var localVarPath = "/api/v2/voicemail/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"
        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (q64 != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("q64", Configuration.ApiClient.ParameterToString(q64)));
        }

        if (expand != null)
        {
            expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
        }

        // Header params

        // Form params

        // Body param


        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetVoicemailSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetVoicemailSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (VoicemailsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>AnalyticsConversationWithoutAttributesMultiGetResponse</returns>

    public AnalyticsConversationWithoutAttributesMultiGetResponse PostAnalyticsConversationsTranscriptsQuery(TranscriptConversationDetailSearchRequest body)
    {
        ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse> localVarResponse = PostAnalyticsConversationsTranscriptsQueryWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of AnalyticsConversationWithoutAttributesMultiGetResponse</returns>

    public ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse> PostAnalyticsConversationsTranscriptsQueryWithHttpInfo(TranscriptConversationDetailSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostAnalyticsConversationsTranscriptsQuery");
        }

        var localVarPath = "/api/v2/analytics/conversations/transcripts/query";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsConversationsTranscriptsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsConversationsTranscriptsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse>(localVarStatusCode,
            localVarHeaders,
            (AnalyticsConversationWithoutAttributesMultiGetResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationWithoutAttributesMultiGetResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of AnalyticsConversationWithoutAttributesMultiGetResponse</returns>

    public async Task<AnalyticsConversationWithoutAttributesMultiGetResponse> PostAnalyticsConversationsTranscriptsQueryAsync(TranscriptConversationDetailSearchRequest body)
    {
        ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse> localVarResponse = await PostAnalyticsConversationsTranscriptsQueryAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (AnalyticsConversationWithoutAttributesMultiGetResponse)</returns>

    public async Task<ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse>> PostAnalyticsConversationsTranscriptsQueryAsyncWithHttpInfo(TranscriptConversationDetailSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostAnalyticsConversationsTranscriptsQuery");
        }

        var localVarPath = "/api/v2/analytics/conversations/transcripts/query";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsConversationsTranscriptsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostAnalyticsConversationsTranscriptsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<AnalyticsConversationWithoutAttributesMultiGetResponse>(localVarStatusCode,
            localVarHeaders,
            (AnalyticsConversationWithoutAttributesMultiGetResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationWithoutAttributesMultiGetResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search conversations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>JsonCursorSearchResponse</returns>

    public JsonCursorSearchResponse PostConversationsParticipantsAttributesSearch(ConversationParticipantSearchRequest body)
    {
        ApiResponse<JsonCursorSearchResponse> localVarResponse = PostConversationsParticipantsAttributesSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search conversations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of JsonCursorSearchResponse</returns>

    public ApiResponse<JsonCursorSearchResponse> PostConversationsParticipantsAttributesSearchWithHttpInfo(ConversationParticipantSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostConversationsParticipantsAttributesSearch");
        }

        var localVarPath = "/api/v2/conversations/participants/attributes/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostConversationsParticipantsAttributesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostConversationsParticipantsAttributesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonCursorSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonCursorSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonCursorSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search conversations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of JsonCursorSearchResponse</returns>

    public async Task<JsonCursorSearchResponse> PostConversationsParticipantsAttributesSearchAsync(ConversationParticipantSearchRequest body)
    {
        ApiResponse<JsonCursorSearchResponse> localVarResponse = await PostConversationsParticipantsAttributesSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search conversations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (JsonCursorSearchResponse)</returns>

    public async Task<ApiResponse<JsonCursorSearchResponse>> PostConversationsParticipantsAttributesSearchAsyncWithHttpInfo(ConversationParticipantSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostConversationsParticipantsAttributesSearch");
        }

        var localVarPath = "/api/v2/conversations/participants/attributes/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostConversationsParticipantsAttributesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostConversationsParticipantsAttributesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonCursorSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonCursorSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonCursorSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search all documents 
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>JsonNodeSearchResponse</returns>

    public JsonNodeSearchResponse PostDocumentationAllSearch(DocumentationV2SearchRequest body)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = PostDocumentationAllSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search all documents 
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    public ApiResponse<JsonNodeSearchResponse> PostDocumentationAllSearchWithHttpInfo(DocumentationV2SearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostDocumentationAllSearch");
        }

        var localVarPath = "/api/v2/documentation/all/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationAllSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationAllSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search all documents 
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    public async Task<JsonNodeSearchResponse> PostDocumentationAllSearchAsync(DocumentationV2SearchRequest body)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostDocumentationAllSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search all documents 
    /// 
    /// PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    public async Task<ApiResponse<JsonNodeSearchResponse>> PostDocumentationAllSearchAsyncWithHttpInfo(DocumentationV2SearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostDocumentationAllSearch");
        }

        var localVarPath = "/api/v2/documentation/all/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationAllSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationAllSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search gkn documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>GKNDocumentationSearchResponse</returns>

    public GKNDocumentationSearchResponse PostDocumentationGknSearch(GKNDocumentationSearchRequest body)
    {
        ApiResponse<GKNDocumentationSearchResponse> localVarResponse = PostDocumentationGknSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search gkn documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of GKNDocumentationSearchResponse</returns>

    public ApiResponse<GKNDocumentationSearchResponse> PostDocumentationGknSearchWithHttpInfo(GKNDocumentationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostDocumentationGknSearch");
        }

        var localVarPath = "/api/v2/documentation/gkn/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationGknSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationGknSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GKNDocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GKNDocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GKNDocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search gkn documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of GKNDocumentationSearchResponse</returns>

    public async Task<GKNDocumentationSearchResponse> PostDocumentationGknSearchAsync(GKNDocumentationSearchRequest body)
    {
        ApiResponse<GKNDocumentationSearchResponse> localVarResponse = await PostDocumentationGknSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search gkn documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (GKNDocumentationSearchResponse)</returns>

    public async Task<ApiResponse<GKNDocumentationSearchResponse>> PostDocumentationGknSearchAsyncWithHttpInfo(GKNDocumentationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostDocumentationGknSearch");
        }

        var localVarPath = "/api/v2/documentation/gkn/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationGknSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationGknSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GKNDocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GKNDocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GKNDocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>DocumentationSearchResponse</returns>

    public DocumentationSearchResponse PostDocumentationSearch(DocumentationSearchRequest body)
    {
        ApiResponse<DocumentationSearchResponse> localVarResponse = PostDocumentationSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of DocumentationSearchResponse</returns>

    public ApiResponse<DocumentationSearchResponse> PostDocumentationSearchWithHttpInfo(DocumentationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostDocumentationSearch");
        }

        var localVarPath = "/api/v2/documentation/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<DocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (DocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of DocumentationSearchResponse</returns>

    public async Task<DocumentationSearchResponse> PostDocumentationSearchAsync(DocumentationSearchRequest body)
    {
        ApiResponse<DocumentationSearchResponse> localVarResponse = await PostDocumentationSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search documentation 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (DocumentationSearchResponse)</returns>

    public async Task<ApiResponse<DocumentationSearchResponse>> PostDocumentationSearchAsyncWithHttpInfo(DocumentationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostDocumentationSearch");
        }

        var localVarPath = "/api/v2/documentation/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostDocumentationSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<DocumentationSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (DocumentationSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentationSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search groups 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>GroupsSearchResponse</returns>

    public GroupsSearchResponse PostGroupsSearch(GroupSearchRequest body)
    {
        ApiResponse<GroupsSearchResponse> localVarResponse = PostGroupsSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search groups 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of GroupsSearchResponse</returns>

    public ApiResponse<GroupsSearchResponse> PostGroupsSearchWithHttpInfo(GroupSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostGroupsSearch");
        }

        var localVarPath = "/api/v2/groups/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGroupsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGroupsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GroupsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GroupsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search groups 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of GroupsSearchResponse</returns>

    public async Task<GroupsSearchResponse> PostGroupsSearchAsync(GroupSearchRequest body)
    {
        ApiResponse<GroupsSearchResponse> localVarResponse = await PostGroupsSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search groups 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (GroupsSearchResponse)</returns>

    public async Task<ApiResponse<GroupsSearchResponse>> PostGroupsSearchAsyncWithHttpInfo(GroupSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostGroupsSearch");
        }

        var localVarPath = "/api/v2/groups/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGroupsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostGroupsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<GroupsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (GroupsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search Documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>KnowledgeSearchResponse</returns>
    [Obsolete]
    public KnowledgeSearchResponse PostKnowledgeKnowledgebaseSearch(string knowledgeBaseId, KnowledgeSearchRequest body = null)
    {
        ApiResponse<KnowledgeSearchResponse> localVarResponse = PostKnowledgeKnowledgebaseSearchWithHttpInfo(knowledgeBaseId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search Documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>ApiResponse of KnowledgeSearchResponse</returns>
    [Obsolete]
    public ApiResponse<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchWithHttpInfo(string knowledgeBaseId, KnowledgeSearchRequest body = null)
    {
        // verify the required parameter 'knowledgeBaseId' is set
        if (knowledgeBaseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling SearchApi->PostKnowledgeKnowledgebaseSearch");
        }

        var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (knowledgeBaseId != null)
        {
            localVarPathParams.Add("knowledgeBaseId", Configuration.ApiClient.ParameterToString(knowledgeBaseId));
        }

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<KnowledgeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (KnowledgeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search Documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of KnowledgeSearchResponse</returns>
    [Obsolete]
    public async Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null)
    {
        ApiResponse<KnowledgeSearchResponse> localVarResponse = await PostKnowledgeKnowledgebaseSearchAsyncWithHttpInfo(knowledgeBaseId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search Documents 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (KnowledgeSearchResponse)</returns>
    [Obsolete]
    public async Task<ApiResponse<KnowledgeSearchResponse>> PostKnowledgeKnowledgebaseSearchAsyncWithHttpInfo(string knowledgeBaseId, KnowledgeSearchRequest body = null)
    {
        // verify the required parameter 'knowledgeBaseId' is set
        if (knowledgeBaseId == null)
        {
            throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling SearchApi->PostKnowledgeKnowledgebaseSearch");
        }

        var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params
        if (knowledgeBaseId != null)
        {
            localVarPathParams.Add("knowledgeBaseId", Configuration.ApiClient.ParameterToString(knowledgeBaseId));
        }

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<KnowledgeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (KnowledgeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>LocationsSearchResponse</returns>

    public LocationsSearchResponse PostLocationsSearch(LocationSearchRequest body)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = PostLocationsSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of LocationsSearchResponse</returns>

    public ApiResponse<LocationsSearchResponse> PostLocationsSearchWithHttpInfo(LocationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of LocationsSearchResponse</returns>

    public async Task<LocationsSearchResponse> PostLocationsSearchAsync(LocationSearchRequest body)
    {
        ApiResponse<LocationsSearchResponse> localVarResponse = await PostLocationsSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search locations 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (LocationsSearchResponse)</returns>

    public async Task<ApiResponse<LocationsSearchResponse>> PostLocationsSearchAsyncWithHttpInfo(LocationSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostLocationsSearch");
        }

        var localVarPath = "/api/v2/locations/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostLocationsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<LocationsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (LocationsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    public JsonNodeSearchResponse PostSearch(SearchRequest body, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = PostSearchWithHttpInfo(body, profile);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    public ApiResponse<JsonNodeSearchResponse> PostSearchWithHttpInfo(SearchRequest body, bool? profile = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostSearch");
        }

        var localVarPath = "/api/v2/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    public async Task<JsonNodeSearchResponse> PostSearchAsync(SearchRequest body, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostSearchAsyncWithHttpInfo(body, profile);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    public async Task<ApiResponse<JsonNodeSearchResponse>> PostSearchAsyncWithHttpInfo(SearchRequest body, bool? profile = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostSearch");
        }

        var localVarPath = "/api/v2/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Suggest resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>JsonNodeSearchResponse</returns>

    public JsonNodeSearchResponse PostSearchSuggest(SuggestSearchRequest body, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = PostSearchSuggestWithHttpInfo(body, profile);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Suggest resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>ApiResponse of JsonNodeSearchResponse</returns>

    public ApiResponse<JsonNodeSearchResponse> PostSearchSuggestWithHttpInfo(SuggestSearchRequest body, bool? profile = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostSearchSuggest");
        }

        var localVarPath = "/api/v2/search/suggest";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Suggest resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of JsonNodeSearchResponse</returns>

    public async Task<JsonNodeSearchResponse> PostSearchSuggestAsync(SuggestSearchRequest body, bool? profile = null)
    {
        ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostSearchSuggestAsyncWithHttpInfo(body, profile);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Suggest resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <param name="profile">profile (optional, default to true)</param>
    /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>

    public async Task<ApiResponse<JsonNodeSearchResponse>> PostSearchSuggestAsyncWithHttpInfo(SuggestSearchRequest body, bool? profile = null)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostSearchSuggest");
        }

        var localVarPath = "/api/v2/search/suggest";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params
        if (profile != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("profile", Configuration.ApiClient.ParameterToString(profile)));
        }

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonNodeSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>JsonSearchResponse</returns>

    public JsonSearchResponse PostSpeechandtextanalyticsTranscriptsSearch(TranscriptSearchRequest body)
    {
        ApiResponse<JsonSearchResponse> localVarResponse = PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of JsonSearchResponse</returns>

    public ApiResponse<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo(TranscriptSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostSpeechandtextanalyticsTranscriptsSearch");
        }

        var localVarPath = "/api/v2/speechandtextanalytics/transcripts/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of JsonSearchResponse</returns>

    public async Task<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchAsync(TranscriptSearchRequest body)
    {
        ApiResponse<JsonSearchResponse> localVarResponse = await PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (JsonSearchResponse)</returns>

    public async Task<ApiResponse<JsonSearchResponse>> PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo(TranscriptSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostSpeechandtextanalyticsTranscriptsSearch");
        }

        var localVarPath = "/api/v2/speechandtextanalytics/transcripts/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<JsonSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (JsonSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>TeamsSearchResponse</returns>

    public TeamsSearchResponse PostTeamsSearch(TeamSearchRequest body)
    {
        ApiResponse<TeamsSearchResponse> localVarResponse = PostTeamsSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of TeamsSearchResponse</returns>

    public ApiResponse<TeamsSearchResponse> PostTeamsSearchWithHttpInfo(TeamSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostTeamsSearch");
        }

        var localVarPath = "/api/v2/teams/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TeamsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (TeamsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of TeamsSearchResponse</returns>

    public async Task<TeamsSearchResponse> PostTeamsSearchAsync(TeamSearchRequest body)
    {
        ApiResponse<TeamsSearchResponse> localVarResponse = await PostTeamsSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search resources. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (TeamsSearchResponse)</returns>

    public async Task<ApiResponse<TeamsSearchResponse>> PostTeamsSearchAsyncWithHttpInfo(TeamSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostTeamsSearch");
        }

        var localVarPath = "/api/v2/teams/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<TeamsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (TeamsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search sites 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>SitesSearchResponse</returns>

    public SitesSearchResponse PostTelephonyProvidersEdgesSitesSearch(SiteSearchRequest body)
    {
        ApiResponse<SitesSearchResponse> localVarResponse = PostTelephonyProvidersEdgesSitesSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search sites 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of SitesSearchResponse</returns>

    public ApiResponse<SitesSearchResponse> PostTelephonyProvidersEdgesSitesSearchWithHttpInfo(SiteSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostTelephonyProvidersEdgesSitesSearch");
        }

        var localVarPath = "/api/v2/telephony/providers/edges/sites/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTelephonyProvidersEdgesSitesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTelephonyProvidersEdgesSitesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SitesSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (SitesSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SitesSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search sites 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of SitesSearchResponse</returns>

    public async Task<SitesSearchResponse> PostTelephonyProvidersEdgesSitesSearchAsync(SiteSearchRequest body)
    {
        ApiResponse<SitesSearchResponse> localVarResponse = await PostTelephonyProvidersEdgesSitesSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search sites 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (SitesSearchResponse)</returns>

    public async Task<ApiResponse<SitesSearchResponse>> PostTelephonyProvidersEdgesSitesSearchAsyncWithHttpInfo(SiteSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostTelephonyProvidersEdgesSitesSearch");
        }

        var localVarPath = "/api/v2/telephony/providers/edges/sites/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTelephonyProvidersEdgesSitesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostTelephonyProvidersEdgesSitesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<SitesSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (SitesSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SitesSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search users 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    public UsersSearchResponse PostUsersSearch(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = PostUsersSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search users 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    public ApiResponse<UsersSearchResponse> PostUsersSearchWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearch");
        }

        var localVarPath = "/api/v2/users/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search users 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    public async Task<UsersSearchResponse> PostUsersSearchAsync(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = await PostUsersSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search users 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    public async Task<ApiResponse<UsersSearchResponse>> PostUsersSearchAsyncWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearch");
        }

        var localVarPath = "/api/v2/users/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search users as conversation targets 
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    public UsersSearchResponse PostUsersSearchConversationTarget(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = PostUsersSearchConversationTargetWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search users as conversation targets 
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    public ApiResponse<UsersSearchResponse> PostUsersSearchConversationTargetWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearchConversationTarget");
        }

        var localVarPath = "/api/v2/users/search/conversation/target";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchConversationTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchConversationTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search users as conversation targets 
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    public async Task<UsersSearchResponse> PostUsersSearchConversationTargetAsync(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = await PostUsersSearchConversationTargetAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search users as conversation targets 
    /// 
    /// PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    public async Task<ApiResponse<UsersSearchResponse>> PostUsersSearchConversationTargetAsyncWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearchConversationTarget");
        }

        var localVarPath = "/api/v2/users/search/conversation/target";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchConversationTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchConversationTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search manage queue member 
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    public UsersSearchResponse PostUsersSearchQueuemembersManage(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = PostUsersSearchQueuemembersManageWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search manage queue member 
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    public ApiResponse<UsersSearchResponse> PostUsersSearchQueuemembersManageWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearchQueuemembersManage");
        }

        var localVarPath = "/api/v2/users/search/queuemembers/manage";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchQueuemembersManage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchQueuemembersManage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search manage queue member 
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    public async Task<UsersSearchResponse> PostUsersSearchQueuemembersManageAsync(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = await PostUsersSearchQueuemembersManageAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search manage queue member 
    /// 
    /// PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    public async Task<ApiResponse<UsersSearchResponse>> PostUsersSearchQueuemembersManageAsyncWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearchQueuemembersManage");
        }

        var localVarPath = "/api/v2/users/search/queuemembers/manage";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchQueuemembersManage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchQueuemembersManage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search users assigned to teams 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>UsersSearchResponse</returns>

    public UsersSearchResponse PostUsersSearchTeamsAssign(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = PostUsersSearchTeamsAssignWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search users assigned to teams 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of UsersSearchResponse</returns>

    public ApiResponse<UsersSearchResponse> PostUsersSearchTeamsAssignWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearchTeamsAssign");
        }

        var localVarPath = "/api/v2/users/search/teams/assign";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchTeamsAssign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchTeamsAssign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search users assigned to teams 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of UsersSearchResponse</returns>

    public async Task<UsersSearchResponse> PostUsersSearchTeamsAssignAsync(UserSearchRequest body)
    {
        ApiResponse<UsersSearchResponse> localVarResponse = await PostUsersSearchTeamsAssignAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search users assigned to teams 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>

    public async Task<ApiResponse<UsersSearchResponse>> PostUsersSearchTeamsAssignAsyncWithHttpInfo(UserSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostUsersSearchTeamsAssign");
        }

        var localVarPath = "/api/v2/users/search/teams/assign";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchTeamsAssign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostUsersSearchTeamsAssign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (UsersSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Search voicemails 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>VoicemailsSearchResponse</returns>

    public VoicemailsSearchResponse PostVoicemailSearch(VoicemailSearchRequest body)
    {
        ApiResponse<VoicemailsSearchResponse> localVarResponse = PostVoicemailSearchWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Search voicemails 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>ApiResponse of VoicemailsSearchResponse</returns>

    public ApiResponse<VoicemailsSearchResponse> PostVoicemailSearchWithHttpInfo(VoicemailSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostVoicemailSearch");
        }

        var localVarPath = "/api/v2/voicemail/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostVoicemailSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostVoicemailSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (VoicemailsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Search voicemails 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of VoicemailsSearchResponse</returns>

    public async Task<VoicemailsSearchResponse> PostVoicemailSearchAsync(VoicemailSearchRequest body)
    {
        ApiResponse<VoicemailsSearchResponse> localVarResponse = await PostVoicemailSearchAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Search voicemails 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Search request options</param>
    /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>

    public async Task<ApiResponse<VoicemailsSearchResponse>> PostVoicemailSearchAsyncWithHttpInfo(VoicemailSearchRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling SearchApi->PostVoicemailSearch");
        }

        var localVarPath = "/api/v2/voicemail/search";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<Tuple<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] {
            "application/json"

        };
        string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        // to determine the Accept header
        string[] localVarHttpHeaderAccepts = new string[] {

            "application/json"


        };
        string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
        {
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
        }

        // set "format" to json by default
        // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
        localVarPathParams.Add("format", "json");

        // Path params

        // Query params

        // Header params

        // Form params

        // Body param
        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }



        // authentication (PureCloudEnvironment OAuth) required
        // oauth required
        if (!string.IsNullOrEmpty(Configuration.AccessToken))
        {
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
        }

        // make the HTTP request
        RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        int localVarStatusCode = (int)localVarResponse.StatusCode;

        Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>();

        if (localVarStatusCode >= 400)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostVoicemailSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostVoicemailSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
            localVarHeaders,
            (VoicemailsSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
