using PureCloud.Client.Models;
using RestSharp;

namespace PureCloud.Client;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IChatApi : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// Delete a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns></returns>

    void DeleteChatsRoomMessage(string roomJid, string messageId);

    /// <summary>
    /// Delete a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteChatsRoomMessageWithHttpInfo(string roomJid, string messageId);

    /// <summary>
    /// Remove a pinned message from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns></returns>

    void DeleteChatsRoomMessagesPin(string roomJid, string pinnedMessageId);

    /// <summary>
    /// Remove a pinned message from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteChatsRoomMessagesPinWithHttpInfo(string roomJid, string pinnedMessageId);

    /// <summary>
    /// Remove a user from a room.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns></returns>

    void DeleteChatsRoomParticipant(string roomJid, string userId);

    /// <summary>
    /// Remove a user from a room.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteChatsRoomParticipantWithHttpInfo(string roomJid, string userId);

    /// <summary>
    /// Delete a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns></returns>

    void DeleteChatsUserMessage(string userId, string messageId);

    /// <summary>
    /// Delete a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteChatsUserMessageWithHttpInfo(string userId, string messageId);

    /// <summary>
    /// Remove a pinned message from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns></returns>

    void DeleteChatsUserMessagesPin(string userId, string pinnedMessageId);

    /// <summary>
    /// Remove a pinned message from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> DeleteChatsUserMessagesPinWithHttpInfo(string userId, string pinnedMessageId);

    /// <summary>
    /// Get a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>ChatMessageResponse</returns>

    ChatMessageResponse GetChatsMessage(string messageId);

    /// <summary>
    /// Get a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>ApiResponse of ChatMessageResponse</returns>

    ApiResponse<ChatMessageResponse> GetChatsMessageWithHttpInfo(string messageId);

    /// <summary>
    /// Get a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Room</returns>

    Room GetChatsRoom(string roomJid);

    /// <summary>
    /// Get a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>ApiResponse of Room</returns>

    ApiResponse<Room> GetChatsRoomWithHttpInfo(string roomJid);

    /// <summary>
    /// Get messages by id(s) from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ChatMessageEntityListing</returns>

    ChatMessageEntityListing GetChatsRoomMessage(string roomJid, string messageIds);

    /// <summary>
    /// Get messages by id(s) from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    ApiResponse<ChatMessageEntityListing> GetChatsRoomMessageWithHttpInfo(string roomJid, string messageIds);

    /// <summary>
    /// Get a room&#39;s message history
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ChatMessageEntityListing</returns>

    ChatMessageEntityListing GetChatsRoomMessages(string roomJid, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get a room&#39;s message history
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    ApiResponse<ChatMessageEntityListing> GetChatsRoomMessagesWithHttpInfo(string roomJid, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get a room participant
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>RoomParticipant</returns>

    RoomParticipant GetChatsRoomParticipant(string roomJid, string participantJid);

    /// <summary>
    /// Get a room participant
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>ApiResponse of RoomParticipant</returns>

    ApiResponse<RoomParticipant> GetChatsRoomParticipantWithHttpInfo(string roomJid, string participantJid);

    /// <summary>
    /// Get room participants in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>RoomParticipantsResponse</returns>

    RoomParticipantsResponse GetChatsRoomParticipants(string roomJid);

    /// <summary>
    /// Get room participants in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>ApiResponse of RoomParticipantsResponse</returns>

    ApiResponse<RoomParticipantsResponse> GetChatsRoomParticipantsWithHttpInfo(string roomJid);

    /// <summary>
    /// Get Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ChatSettings</returns>

    ChatSettings GetChatsSettings();

    /// <summary>
    /// Get Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ChatSettings</returns>

    ApiResponse<ChatSettings> GetChatsSettingsWithHttpInfo();

    /// <summary>
    /// Get history by thread
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ChatMessageEntityListing</returns>

    ChatMessageEntityListing GetChatsThreadMessages(string threadId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get history by thread
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    ApiResponse<ChatMessageEntityListing> GetChatsThreadMessagesWithHttpInfo(string threadId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get information for a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>OneOnOne</returns>

    OneOnOne GetChatsUser(string userId);

    /// <summary>
    /// Get information for a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>ApiResponse of OneOnOne</returns>

    ApiResponse<OneOnOne> GetChatsUserWithHttpInfo(string userId);

    /// <summary>
    /// Get messages by id(s) from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ChatMessageEntityListing</returns>

    ChatMessageEntityListing GetChatsUserMessage(string userId, string messageIds);

    /// <summary>
    /// Get messages by id(s) from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    ApiResponse<ChatMessageEntityListing> GetChatsUserMessageWithHttpInfo(string userId, string messageIds);

    /// <summary>
    /// Get 1on1 History between a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ChatMessageResponse</returns>

    ChatMessageResponse GetChatsUserMessages(string userId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get 1on1 History between a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ApiResponse of ChatMessageResponse</returns>

    ApiResponse<ChatMessageResponse> GetChatsUserMessagesWithHttpInfo(string userId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>ChatUserSettings</returns>

    ChatUserSettings GetChatsUserSettings(string userId);

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    ApiResponse<ChatUserSettings> GetChatsUserSettingsWithHttpInfo(string userId);

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ChatUserSettings</returns>

    ChatUserSettings GetChatsUsersMeSettings();

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    ApiResponse<ChatUserSettings> GetChatsUsersMeSettingsWithHttpInfo();

    /// <summary>
    /// Set properties for a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns></returns>

    void PatchChatsRoom(string roomJid, RoomUpdateRequest body);

    /// <summary>
    /// Set properties for a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> PatchChatsRoomWithHttpInfo(string roomJid, RoomUpdateRequest body);

    /// <summary>
    /// Edit a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ChatSendMessageResponse</returns>

    ChatSendMessageResponse PatchChatsRoomMessage(string roomJid, string messageId, SendMessageBody body);

    /// <summary>
    /// Edit a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    ApiResponse<ChatSendMessageResponse> PatchChatsRoomMessageWithHttpInfo(string roomJid, string messageId, SendMessageBody body);

    /// <summary>
    /// Patch Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ChatSettings</returns>

    ChatSettings PatchChatsSettings(ChatSettings body);

    /// <summary>
    /// Patch Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ApiResponse of ChatSettings</returns>

    ApiResponse<ChatSettings> PatchChatsSettingsWithHttpInfo(ChatSettings body);

    /// <summary>
    /// Edit a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>ChatSendMessageResponse</returns>

    ChatSendMessageResponse PatchChatsUserMessage(string userId, string messageId, SendMessageBody body);

    /// <summary>
    /// Edit a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    ApiResponse<ChatSendMessageResponse> PatchChatsUserMessageWithHttpInfo(string userId, string messageId, SendMessageBody body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>ChatUserSettings</returns>

    ChatUserSettings PatchChatsUserSettings(string userId, ChatUserSettings body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    ApiResponse<ChatUserSettings> PatchChatsUserSettingsWithHttpInfo(string userId, ChatUserSettings body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ChatUserSettings</returns>

    ChatUserSettings PatchChatsUsersMeSettings(ChatUserSettings body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    ApiResponse<ChatUserSettings> PatchChatsUsersMeSettingsWithHttpInfo(ChatUserSettings body);

    /// <summary>
    /// Send a message to a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ChatSendMessageResponse</returns>

    ChatSendMessageResponse PostChatsRoomMessages(string roomJid, SendMessageBody body);

    /// <summary>
    /// Send a message to a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    ApiResponse<ChatSendMessageResponse> PostChatsRoomMessagesWithHttpInfo(string roomJid, SendMessageBody body);

    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns></returns>

    void PostChatsRoomMessagesPins(string roomJid, PinnedMessageRequest body);

    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> PostChatsRoomMessagesPinsWithHttpInfo(string roomJid, PinnedMessageRequest body);

    /// <summary>
    /// Join a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns></returns>

    void PostChatsRoomParticipant(string roomJid, string userId);

    /// <summary>
    /// Join a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> PostChatsRoomParticipantWithHttpInfo(string roomJid, string userId);

    /// <summary>
    /// Create an adhoc room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>CreateRoomResponse</returns>

    CreateRoomResponse PostChatsRooms(CreateRoomRequest body);

    /// <summary>
    /// Create an adhoc room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>ApiResponse of CreateRoomResponse</returns>

    ApiResponse<CreateRoomResponse> PostChatsRoomsWithHttpInfo(CreateRoomRequest body);

    /// <summary>
    /// Send a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>ChatSendMessageResponse</returns>

    ChatSendMessageResponse PostChatsUserMessages(string userId, SendMessageBody body);

    /// <summary>
    /// Send a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    ApiResponse<ChatSendMessageResponse> PostChatsUserMessagesWithHttpInfo(string userId, SendMessageBody body);

    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns></returns>

    void PostChatsUserMessagesPins(string userId, PinnedMessageRequest body);

    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> PostChatsUserMessagesPinsWithHttpInfo(string userId, PinnedMessageRequest body);

    /// <summary>
    /// Update reactions to a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns></returns>

    void PutChatsMessageReactions(string messageId, ChatReactionUpdate body);

    /// <summary>
    /// Update reactions to a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns>ApiResponse of Object(void)</returns>

    ApiResponse<object> PutChatsMessageReactionsWithHttpInfo(string messageId, ChatReactionUpdate body);

    /// <summary>
    /// Update Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ChatSettings</returns>

    ChatSettings PutChatsSettings(ChatSettings body);

    /// <summary>
    /// Update Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ApiResponse of ChatSettings</returns>

    ApiResponse<ChatSettings> PutChatsSettingsWithHttpInfo(ChatSettings body);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Delete a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of void</returns>

    Task DeleteChatsRoomMessageAsync(string roomJid, string messageId);

    /// <summary>
    /// Delete a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteChatsRoomMessageAsyncWithHttpInfo(string roomJid, string messageId);

    /// <summary>
    /// Remove a pinned message from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of void</returns>

    Task DeleteChatsRoomMessagesPinAsync(string roomJid, string pinnedMessageId);

    /// <summary>
    /// Remove a pinned message from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteChatsRoomMessagesPinAsyncWithHttpInfo(string roomJid, string pinnedMessageId);

    /// <summary>
    /// Remove a user from a room.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of void</returns>

    Task DeleteChatsRoomParticipantAsync(string roomJid, string userId);

    /// <summary>
    /// Remove a user from a room.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteChatsRoomParticipantAsyncWithHttpInfo(string roomJid, string userId);

    /// <summary>
    /// Delete a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of void</returns>

    Task DeleteChatsUserMessageAsync(string userId, string messageId);

    /// <summary>
    /// Delete a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteChatsUserMessageAsyncWithHttpInfo(string userId, string messageId);

    /// <summary>
    /// Remove a pinned message from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of void</returns>

    Task DeleteChatsUserMessagesPinAsync(string userId, string pinnedMessageId);

    /// <summary>
    /// Remove a pinned message from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> DeleteChatsUserMessagesPinAsyncWithHttpInfo(string userId, string pinnedMessageId);

    /// <summary>
    /// Get a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ChatMessageResponse</returns>

    Task<ChatMessageResponse> GetChatsMessageAsync(string messageId);

    /// <summary>
    /// Get a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>

    Task<ApiResponse<ChatMessageResponse>> GetChatsMessageAsyncWithHttpInfo(string messageId);

    /// <summary>
    /// Get a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of Room</returns>

    Task<Room> GetChatsRoomAsync(string roomJid);

    /// <summary>
    /// Get a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of ApiResponse (Room)</returns>

    Task<ApiResponse<Room>> GetChatsRoomAsyncWithHttpInfo(string roomJid);

    /// <summary>
    /// Get messages by id(s) from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    Task<ChatMessageEntityListing> GetChatsRoomMessageAsync(string roomJid, string messageIds);

    /// <summary>
    /// Get messages by id(s) from a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessageAsyncWithHttpInfo(string roomJid, string messageIds);

    /// <summary>
    /// Get a room&#39;s message history
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync(string roomJid, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get a room&#39;s message history
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessagesAsyncWithHttpInfo(string roomJid, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get a room participant
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>Task of RoomParticipant</returns>

    Task<RoomParticipant> GetChatsRoomParticipantAsync(string roomJid, string participantJid);

    /// <summary>
    /// Get a room participant
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>Task of ApiResponse (RoomParticipant)</returns>

    Task<ApiResponse<RoomParticipant>> GetChatsRoomParticipantAsyncWithHttpInfo(string roomJid, string participantJid);

    /// <summary>
    /// Get room participants in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of RoomParticipantsResponse</returns>

    Task<RoomParticipantsResponse> GetChatsRoomParticipantsAsync(string roomJid);

    /// <summary>
    /// Get room participants in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of ApiResponse (RoomParticipantsResponse)</returns>

    Task<ApiResponse<RoomParticipantsResponse>> GetChatsRoomParticipantsAsyncWithHttpInfo(string roomJid);

    /// <summary>
    /// Get Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ChatSettings</returns>

    Task<ChatSettings> GetChatsSettingsAsync();

    /// <summary>
    /// Get Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (ChatSettings)</returns>

    Task<ApiResponse<ChatSettings>> GetChatsSettingsAsyncWithHttpInfo();

    /// <summary>
    /// Get history by thread
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    Task<ChatMessageEntityListing> GetChatsThreadMessagesAsync(string threadId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get history by thread
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    Task<ApiResponse<ChatMessageEntityListing>> GetChatsThreadMessagesAsyncWithHttpInfo(string threadId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get information for a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>Task of OneOnOne</returns>

    Task<OneOnOne> GetChatsUserAsync(string userId);

    /// <summary>
    /// Get information for a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>Task of ApiResponse (OneOnOne)</returns>

    Task<ApiResponse<OneOnOne>> GetChatsUserAsyncWithHttpInfo(string userId);

    /// <summary>
    /// Get messages by id(s) from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    Task<ChatMessageEntityListing> GetChatsUserMessageAsync(string userId, string messageIds);

    /// <summary>
    /// Get messages by id(s) from a 1on1
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    Task<ApiResponse<ChatMessageEntityListing>> GetChatsUserMessageAsyncWithHttpInfo(string userId, string messageIds);

    /// <summary>
    /// Get 1on1 History between a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ChatMessageResponse</returns>

    Task<ChatMessageResponse> GetChatsUserMessagesAsync(string userId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get 1on1 History between a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>

    Task<ApiResponse<ChatMessageResponse>> GetChatsUserMessagesAsyncWithHttpInfo(string userId, string limit = null, string before = null, string after = null);

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>Task of ChatUserSettings</returns>

    Task<ChatUserSettings> GetChatsUserSettingsAsync(string userId);

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    Task<ApiResponse<ChatUserSettings>> GetChatsUserSettingsAsyncWithHttpInfo(string userId);

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ChatUserSettings</returns>

    Task<ChatUserSettings> GetChatsUsersMeSettingsAsync();

    /// <summary>
    /// Get a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    Task<ApiResponse<ChatUserSettings>> GetChatsUsersMeSettingsAsyncWithHttpInfo();

    /// <summary>
    /// Set properties for a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns>Task of void</returns>

    Task PatchChatsRoomAsync(string roomJid, RoomUpdateRequest body);

    /// <summary>
    /// Set properties for a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> PatchChatsRoomAsyncWithHttpInfo(string roomJid, RoomUpdateRequest body);

    /// <summary>
    /// Edit a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    Task<ChatSendMessageResponse> PatchChatsRoomMessageAsync(string roomJid, string messageId, SendMessageBody body);

    /// <summary>
    /// Edit a message in a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    Task<ApiResponse<ChatSendMessageResponse>> PatchChatsRoomMessageAsyncWithHttpInfo(string roomJid, string messageId, SendMessageBody body);

    /// <summary>
    /// Patch Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ChatSettings</returns>

    Task<ChatSettings> PatchChatsSettingsAsync(ChatSettings body);

    /// <summary>
    /// Patch Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ApiResponse (ChatSettings)</returns>

    Task<ApiResponse<ChatSettings>> PatchChatsSettingsAsyncWithHttpInfo(ChatSettings body);

    /// <summary>
    /// Edit a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    Task<ChatSendMessageResponse> PatchChatsUserMessageAsync(string userId, string messageId, SendMessageBody body);

    /// <summary>
    /// Edit a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    Task<ApiResponse<ChatSendMessageResponse>> PatchChatsUserMessageAsyncWithHttpInfo(string userId, string messageId, SendMessageBody body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>Task of ChatUserSettings</returns>

    Task<ChatUserSettings> PatchChatsUserSettingsAsync(string userId, ChatUserSettings body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    Task<ApiResponse<ChatUserSettings>> PatchChatsUserSettingsAsyncWithHttpInfo(string userId, ChatUserSettings body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ChatUserSettings</returns>

    Task<ChatUserSettings> PatchChatsUsersMeSettingsAsync(ChatUserSettings body);

    /// <summary>
    /// Update a user&#39;s chat settings
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    Task<ApiResponse<ChatUserSettings>> PatchChatsUsersMeSettingsAsyncWithHttpInfo(ChatUserSettings body);

    /// <summary>
    /// Send a message to a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    Task<ChatSendMessageResponse> PostChatsRoomMessagesAsync(string roomJid, SendMessageBody body);

    /// <summary>
    /// Send a message to a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    Task<ApiResponse<ChatSendMessageResponse>> PostChatsRoomMessagesAsyncWithHttpInfo(string roomJid, SendMessageBody body);

    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of void</returns>

    Task PostChatsRoomMessagesPinsAsync(string roomJid, PinnedMessageRequest body);

    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> PostChatsRoomMessagesPinsAsyncWithHttpInfo(string roomJid, PinnedMessageRequest body);

    /// <summary>
    /// Join a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of void</returns>

    Task PostChatsRoomParticipantAsync(string roomJid, string userId);

    /// <summary>
    /// Join a room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> PostChatsRoomParticipantAsyncWithHttpInfo(string roomJid, string userId);

    /// <summary>
    /// Create an adhoc room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>Task of CreateRoomResponse</returns>

    Task<CreateRoomResponse> PostChatsRoomsAsync(CreateRoomRequest body);

    /// <summary>
    /// Create an adhoc room
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>Task of ApiResponse (CreateRoomResponse)</returns>

    Task<ApiResponse<CreateRoomResponse>> PostChatsRoomsAsyncWithHttpInfo(CreateRoomRequest body);

    /// <summary>
    /// Send a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    Task<ChatSendMessageResponse> PostChatsUserMessagesAsync(string userId, SendMessageBody body);

    /// <summary>
    /// Send a message to a user
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    Task<ApiResponse<ChatSendMessageResponse>> PostChatsUserMessagesAsyncWithHttpInfo(string userId, SendMessageBody body);

    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of void</returns>

    Task PostChatsUserMessagesPinsAsync(string userId, PinnedMessageRequest body);

    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> PostChatsUserMessagesPinsAsyncWithHttpInfo(string userId, PinnedMessageRequest body);

    /// <summary>
    /// Update reactions to a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns>Task of void</returns>

    Task PutChatsMessageReactionsAsync(string messageId, ChatReactionUpdate body);

    /// <summary>
    /// Update reactions to a message
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns>Task of ApiResponse</returns>

    Task<ApiResponse<object>> PutChatsMessageReactionsAsyncWithHttpInfo(string messageId, ChatReactionUpdate body);

    /// <summary>
    /// Update Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ChatSettings</returns>

    Task<ChatSettings> PutChatsSettingsAsync(ChatSettings body);

    /// <summary>
    /// Update Chat Settings.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ApiResponse (ChatSettings)</returns>

    Task<ApiResponse<ChatSettings>> PutChatsSettingsAsyncWithHttpInfo(ChatSettings body);

    #endregion Asynchronous Operations

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ChatApi : IChatApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ChatApi(string basePath)
    {
        Configuration = new Configuration(new ApiClient(basePath));

        // ensure API client has configuration ready
        if (Configuration.ApiClient.Configuration == null)
        {
            Configuration.ApiClient.Configuration = Configuration;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public ChatApi(Configuration configuration = null)
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
    /// Delete a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns></returns>

    public void DeleteChatsRoomMessage(string roomJid, string messageId)
    {
        DeleteChatsRoomMessageWithHttpInfo(roomJid, messageId);
    }

    /// <summary>
    /// Delete a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteChatsRoomMessageWithHttpInfo(string roomJid, string messageId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomMessage");
        }
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsRoomMessage");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteChatsRoomMessageAsync(string roomJid, string messageId)
    {
        await DeleteChatsRoomMessageAsyncWithHttpInfo(roomJid, messageId);

    }

    /// <summary>
    /// Delete a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteChatsRoomMessageAsyncWithHttpInfo(string roomJid, string messageId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomMessage");
        }

        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsRoomMessage");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Remove a pinned message from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns></returns>

    public void DeleteChatsRoomMessagesPin(string roomJid, string pinnedMessageId)
    {
        DeleteChatsRoomMessagesPinWithHttpInfo(roomJid, pinnedMessageId);
    }

    /// <summary>
    /// Remove a pinned message from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteChatsRoomMessagesPinWithHttpInfo(string roomJid, string pinnedMessageId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomMessagesPin");
        }
        // verify the required parameter 'pinnedMessageId' is set
        if (pinnedMessageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pinnedMessageId' when calling ChatApi->DeleteChatsRoomMessagesPin");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/pins/{pinnedMessageId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (pinnedMessageId != null)
        {
            localVarPathParams.Add("pinnedMessageId", Configuration.ApiClient.ParameterToString(pinnedMessageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessagesPin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessagesPin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Remove a pinned message from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteChatsRoomMessagesPinAsync(string roomJid, string pinnedMessageId)
    {
        await DeleteChatsRoomMessagesPinAsyncWithHttpInfo(roomJid, pinnedMessageId);

    }

    /// <summary>
    /// Remove a pinned message from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteChatsRoomMessagesPinAsyncWithHttpInfo(string roomJid, string pinnedMessageId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomMessagesPin");
        }

        // verify the required parameter 'pinnedMessageId' is set
        if (pinnedMessageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pinnedMessageId' when calling ChatApi->DeleteChatsRoomMessagesPin");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/pins/{pinnedMessageId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (pinnedMessageId != null)
        {
            localVarPathParams.Add("pinnedMessageId", Configuration.ApiClient.ParameterToString(pinnedMessageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessagesPin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomMessagesPin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Remove a user from a room. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns></returns>

    public void DeleteChatsRoomParticipant(string roomJid, string userId)
    {
        DeleteChatsRoomParticipantWithHttpInfo(roomJid, userId);
    }

    /// <summary>
    /// Remove a user from a room. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteChatsRoomParticipantWithHttpInfo(string roomJid, string userId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomParticipant");
        }
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsRoomParticipant");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Remove a user from a room. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteChatsRoomParticipantAsync(string roomJid, string userId)
    {
        await DeleteChatsRoomParticipantAsyncWithHttpInfo(roomJid, userId);

    }

    /// <summary>
    /// Remove a user from a room. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteChatsRoomParticipantAsyncWithHttpInfo(string roomJid, string userId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomParticipant");
        }

        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsRoomParticipant");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Delete a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns></returns>

    public void DeleteChatsUserMessage(string userId, string messageId)
    {
        DeleteChatsUserMessageWithHttpInfo(userId, messageId);
    }

    /// <summary>
    /// Delete a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteChatsUserMessageWithHttpInfo(string userId, string messageId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsUserMessage");
        }
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsUserMessage");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Delete a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteChatsUserMessageAsync(string userId, string messageId)
    {
        await DeleteChatsUserMessageAsyncWithHttpInfo(userId, messageId);

    }

    /// <summary>
    /// Delete a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteChatsUserMessageAsyncWithHttpInfo(string userId, string messageId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsUserMessage");
        }

        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsUserMessage");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Remove a pinned message from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns></returns>

    public void DeleteChatsUserMessagesPin(string userId, string pinnedMessageId)
    {
        DeleteChatsUserMessagesPinWithHttpInfo(userId, pinnedMessageId);
    }

    /// <summary>
    /// Remove a pinned message from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> DeleteChatsUserMessagesPinWithHttpInfo(string userId, string pinnedMessageId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsUserMessagesPin");
        }
        // verify the required parameter 'pinnedMessageId' is set
        if (pinnedMessageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pinnedMessageId' when calling ChatApi->DeleteChatsUserMessagesPin");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/pins/{pinnedMessageId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (pinnedMessageId != null)
        {
            localVarPathParams.Add("pinnedMessageId", Configuration.ApiClient.ParameterToString(pinnedMessageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessagesPin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessagesPin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Remove a pinned message from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of void</returns>

    public async Task DeleteChatsUserMessagesPinAsync(string userId, string pinnedMessageId)
    {
        await DeleteChatsUserMessagesPinAsyncWithHttpInfo(userId, pinnedMessageId);

    }

    /// <summary>
    /// Remove a pinned message from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="pinnedMessageId">pinnedMessageId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> DeleteChatsUserMessagesPinAsyncWithHttpInfo(string userId, string pinnedMessageId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsUserMessagesPin");
        }

        // verify the required parameter 'pinnedMessageId' is set
        if (pinnedMessageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'pinnedMessageId' when calling ChatApi->DeleteChatsUserMessagesPin");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/pins/{pinnedMessageId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (pinnedMessageId != null)
        {
            localVarPathParams.Add("pinnedMessageId", Configuration.ApiClient.ParameterToString(pinnedMessageId));
        }

        // Query params

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
            Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessagesPin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling DeleteChatsUserMessagesPin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>ChatMessageResponse</returns>

    public ChatMessageResponse GetChatsMessage(string messageId)
    {
        ApiResponse<ChatMessageResponse> localVarResponse = GetChatsMessageWithHttpInfo(messageId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>ApiResponse of ChatMessageResponse</returns>

    public ApiResponse<ChatMessageResponse> GetChatsMessageWithHttpInfo(string messageId)
    {
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->GetChatsMessage");
        }

        var localVarPath = "/api/v2/chats/messages/{messageId}";
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
        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ChatMessageResponse</returns>

    public async Task<ChatMessageResponse> GetChatsMessageAsync(string messageId)
    {
        ApiResponse<ChatMessageResponse> localVarResponse = await GetChatsMessageAsyncWithHttpInfo(messageId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>

    public async Task<ApiResponse<ChatMessageResponse>> GetChatsMessageAsyncWithHttpInfo(string messageId)
    {
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->GetChatsMessage");
        }

        var localVarPath = "/api/v2/chats/messages/{messageId}";
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
        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Room</returns>

    public Room GetChatsRoom(string roomJid)
    {
        ApiResponse<Room> localVarResponse = GetChatsRoomWithHttpInfo(roomJid);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>ApiResponse of Room</returns>

    public ApiResponse<Room> GetChatsRoomWithHttpInfo(string roomJid)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoom");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Room>(localVarStatusCode,
            localVarHeaders,
            (Room)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Room)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of Room</returns>

    public async Task<Room> GetChatsRoomAsync(string roomJid)
    {
        ApiResponse<Room> localVarResponse = await GetChatsRoomAsyncWithHttpInfo(roomJid);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of ApiResponse (Room)</returns>

    public async Task<ApiResponse<Room>> GetChatsRoomAsyncWithHttpInfo(string roomJid)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoom");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<Room>(localVarStatusCode,
            localVarHeaders,
            (Room)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Room)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get messages by id(s) from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ChatMessageEntityListing</returns>

    public ChatMessageEntityListing GetChatsRoomMessage(string roomJid, string messageIds)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsRoomMessageWithHttpInfo(roomJid, messageIds);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get messages by id(s) from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    public ApiResponse<ChatMessageEntityListing> GetChatsRoomMessageWithHttpInfo(string roomJid, string messageIds)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessage");
        }
        // verify the required parameter 'messageIds' is set
        if (messageIds == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsRoomMessage");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageIds}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (messageIds != null)
        {
            localVarPathParams.Add("messageIds", Configuration.ApiClient.ParameterToString(messageIds));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get messages by id(s) from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    public async Task<ChatMessageEntityListing> GetChatsRoomMessageAsync(string roomJid, string messageIds)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsRoomMessageAsyncWithHttpInfo(roomJid, messageIds);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get messages by id(s) from a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    public async Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessageAsyncWithHttpInfo(string roomJid, string messageIds)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessage");
        }

        // verify the required parameter 'messageIds' is set
        if (messageIds == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsRoomMessage");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageIds}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (messageIds != null)
        {
            localVarPathParams.Add("messageIds", Configuration.ApiClient.ParameterToString(messageIds));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a room&#39;s message history 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ChatMessageEntityListing</returns>

    public ChatMessageEntityListing GetChatsRoomMessages(string roomJid, string limit = null, string before = null, string after = null)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsRoomMessagesWithHttpInfo(roomJid, limit, before, after);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a room&#39;s message history 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    public ApiResponse<ChatMessageEntityListing> GetChatsRoomMessagesWithHttpInfo(string roomJid, string limit = null, string before = null, string after = null)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessages");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        // Query params
        if (limit != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("limit", Configuration.ApiClient.ParameterToString(limit)));
        }

        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a room&#39;s message history 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    public async Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync(string roomJid, string limit = null, string before = null, string after = null)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsRoomMessagesAsyncWithHttpInfo(roomJid, limit, before, after);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a room&#39;s message history 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    public async Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessagesAsyncWithHttpInfo(string roomJid, string limit = null, string before = null, string after = null)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessages");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        // Query params
        if (limit != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("limit", Configuration.ApiClient.ParameterToString(limit)));
        }

        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a room participant 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>RoomParticipant</returns>

    public RoomParticipant GetChatsRoomParticipant(string roomJid, string participantJid)
    {
        ApiResponse<RoomParticipant> localVarResponse = GetChatsRoomParticipantWithHttpInfo(roomJid, participantJid);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a room participant 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>ApiResponse of RoomParticipant</returns>

    public ApiResponse<RoomParticipant> GetChatsRoomParticipantWithHttpInfo(string roomJid, string participantJid)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomParticipant");
        }
        // verify the required parameter 'participantJid' is set
        if (participantJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'participantJid' when calling ChatApi->GetChatsRoomParticipant");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{participantJid}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (participantJid != null)
        {
            localVarPathParams.Add("participantJid", Configuration.ApiClient.ParameterToString(participantJid));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<RoomParticipant>(localVarStatusCode,
            localVarHeaders,
            (RoomParticipant)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomParticipant)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a room participant 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>Task of RoomParticipant</returns>

    public async Task<RoomParticipant> GetChatsRoomParticipantAsync(string roomJid, string participantJid)
    {
        ApiResponse<RoomParticipant> localVarResponse = await GetChatsRoomParticipantAsyncWithHttpInfo(roomJid, participantJid);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a room participant 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="participantJid">participantJid</param>
    /// <returns>Task of ApiResponse (RoomParticipant)</returns>

    public async Task<ApiResponse<RoomParticipant>> GetChatsRoomParticipantAsyncWithHttpInfo(string roomJid, string participantJid)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomParticipant");
        }

        // verify the required parameter 'participantJid' is set
        if (participantJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'participantJid' when calling ChatApi->GetChatsRoomParticipant");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{participantJid}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (participantJid != null)
        {
            localVarPathParams.Add("participantJid", Configuration.ApiClient.ParameterToString(participantJid));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<RoomParticipant>(localVarStatusCode,
            localVarHeaders,
            (RoomParticipant)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomParticipant)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get room participants in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>RoomParticipantsResponse</returns>

    public RoomParticipantsResponse GetChatsRoomParticipants(string roomJid)
    {
        ApiResponse<RoomParticipantsResponse> localVarResponse = GetChatsRoomParticipantsWithHttpInfo(roomJid);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get room participants in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>ApiResponse of RoomParticipantsResponse</returns>

    public ApiResponse<RoomParticipantsResponse> GetChatsRoomParticipantsWithHttpInfo(string roomJid)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomParticipants");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<RoomParticipantsResponse>(localVarStatusCode,
            localVarHeaders,
            (RoomParticipantsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomParticipantsResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get room participants in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of RoomParticipantsResponse</returns>

    public async Task<RoomParticipantsResponse> GetChatsRoomParticipantsAsync(string roomJid)
    {
        ApiResponse<RoomParticipantsResponse> localVarResponse = await GetChatsRoomParticipantsAsyncWithHttpInfo(roomJid);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get room participants in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <returns>Task of ApiResponse (RoomParticipantsResponse)</returns>

    public async Task<ApiResponse<RoomParticipantsResponse>> GetChatsRoomParticipantsAsyncWithHttpInfo(string roomJid)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomParticipants");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsRoomParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<RoomParticipantsResponse>(localVarStatusCode,
            localVarHeaders,
            (RoomParticipantsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomParticipantsResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ChatSettings</returns>

    public ChatSettings GetChatsSettings()
    {
        ApiResponse<ChatSettings> localVarResponse = GetChatsSettingsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ChatSettings</returns>

    public ApiResponse<ChatSettings> GetChatsSettingsWithHttpInfo()
    {

        var localVarPath = "/api/v2/chats/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ChatSettings</returns>

    public async Task<ChatSettings> GetChatsSettingsAsync()
    {
        ApiResponse<ChatSettings> localVarResponse = await GetChatsSettingsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (ChatSettings)</returns>

    public async Task<ApiResponse<ChatSettings>> GetChatsSettingsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/chats/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get history by thread 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ChatMessageEntityListing</returns>

    public ChatMessageEntityListing GetChatsThreadMessages(string threadId, string limit = null, string before = null, string after = null)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsThreadMessagesWithHttpInfo(threadId, limit, before, after);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get history by thread 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    public ApiResponse<ChatMessageEntityListing> GetChatsThreadMessagesWithHttpInfo(string threadId, string limit = null, string before = null, string after = null)
    {
        // verify the required parameter 'threadId' is set
        if (threadId == null)
        {
            throw new ApiException(400, "Missing required parameter 'threadId' when calling ChatApi->GetChatsThreadMessages");
        }

        var localVarPath = "/api/v2/chats/threads/{threadId}/messages";
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
        if (threadId != null)
        {
            localVarPathParams.Add("threadId", Configuration.ApiClient.ParameterToString(threadId));
        }

        // Query params
        if (limit != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("limit", Configuration.ApiClient.ParameterToString(limit)));
        }

        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get history by thread 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    public async Task<ChatMessageEntityListing> GetChatsThreadMessagesAsync(string threadId, string limit = null, string before = null, string after = null)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsThreadMessagesAsyncWithHttpInfo(threadId, limit, before, after);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get history by thread 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="threadId">threadId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    public async Task<ApiResponse<ChatMessageEntityListing>> GetChatsThreadMessagesAsyncWithHttpInfo(string threadId, string limit = null, string before = null, string after = null)
    {
        // verify the required parameter 'threadId' is set
        if (threadId == null)
        {
            throw new ApiException(400, "Missing required parameter 'threadId' when calling ChatApi->GetChatsThreadMessages");
        }

        var localVarPath = "/api/v2/chats/threads/{threadId}/messages";
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
        if (threadId != null)
        {
            localVarPathParams.Add("threadId", Configuration.ApiClient.ParameterToString(threadId));
        }

        // Query params
        if (limit != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("limit", Configuration.ApiClient.ParameterToString(limit)));
        }

        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get information for a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>OneOnOne</returns>

    public OneOnOne GetChatsUser(string userId)
    {
        ApiResponse<OneOnOne> localVarResponse = GetChatsUserWithHttpInfo(userId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get information for a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>ApiResponse of OneOnOne</returns>

    public ApiResponse<OneOnOne> GetChatsUserWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUser");
        }

        var localVarPath = "/api/v2/chats/users/{userId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<OneOnOne>(localVarStatusCode,
            localVarHeaders,
            (OneOnOne)Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneOnOne)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get information for a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>Task of OneOnOne</returns>

    public async Task<OneOnOne> GetChatsUserAsync(string userId)
    {
        ApiResponse<OneOnOne> localVarResponse = await GetChatsUserAsyncWithHttpInfo(userId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get information for a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <returns>Task of ApiResponse (OneOnOne)</returns>

    public async Task<ApiResponse<OneOnOne>> GetChatsUserAsyncWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUser");
        }

        var localVarPath = "/api/v2/chats/users/{userId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<OneOnOne>(localVarStatusCode,
            localVarHeaders,
            (OneOnOne)Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneOnOne)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get messages by id(s) from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ChatMessageEntityListing</returns>

    public ChatMessageEntityListing GetChatsUserMessage(string userId, string messageIds)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsUserMessageWithHttpInfo(userId, messageIds);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get messages by id(s) from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>ApiResponse of ChatMessageEntityListing</returns>

    public ApiResponse<ChatMessageEntityListing> GetChatsUserMessageWithHttpInfo(string userId, string messageIds)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessage");
        }
        // verify the required parameter 'messageIds' is set
        if (messageIds == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsUserMessage");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageIds}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (messageIds != null)
        {
            localVarPathParams.Add("messageIds", Configuration.ApiClient.ParameterToString(messageIds));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get messages by id(s) from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ChatMessageEntityListing</returns>

    public async Task<ChatMessageEntityListing> GetChatsUserMessageAsync(string userId, string messageIds)
    {
        ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsUserMessageAsyncWithHttpInfo(userId, messageIds);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get messages by id(s) from a 1on1 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageIds">messageIds, comma separated</param>
    /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>

    public async Task<ApiResponse<ChatMessageEntityListing>> GetChatsUserMessageAsyncWithHttpInfo(string userId, string messageIds)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessage");
        }

        // verify the required parameter 'messageIds' is set
        if (messageIds == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsUserMessage");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageIds}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (messageIds != null)
        {
            localVarPathParams.Add("messageIds", Configuration.ApiClient.ParameterToString(messageIds));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageEntityListing)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get 1on1 History between a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ChatMessageResponse</returns>

    public ChatMessageResponse GetChatsUserMessages(string userId, string limit = null, string before = null, string after = null)
    {
        ApiResponse<ChatMessageResponse> localVarResponse = GetChatsUserMessagesWithHttpInfo(userId, limit, before, after);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get 1on1 History between a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>ApiResponse of ChatMessageResponse</returns>

    public ApiResponse<ChatMessageResponse> GetChatsUserMessagesWithHttpInfo(string userId, string limit = null, string before = null, string after = null)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessages");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params
        if (limit != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("limit", Configuration.ApiClient.ParameterToString(limit)));
        }

        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get 1on1 History between a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ChatMessageResponse</returns>

    public async Task<ChatMessageResponse> GetChatsUserMessagesAsync(string userId, string limit = null, string before = null, string after = null)
    {
        ApiResponse<ChatMessageResponse> localVarResponse = await GetChatsUserMessagesAsyncWithHttpInfo(userId, limit, before, after);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get 1on1 History between a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
    /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
    /// <param name="after">The beginning date for messages to retrieve (optional)</param>
    /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>

    public async Task<ApiResponse<ChatMessageResponse>> GetChatsUserMessagesAsyncWithHttpInfo(string userId, string limit = null, string before = null, string after = null)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessages");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params
        if (limit != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("limit", Configuration.ApiClient.ParameterToString(limit)));
        }

        if (before != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("before", Configuration.ApiClient.ParameterToString(before)));
        }

        if (after != null)
        {
            localVarQueryParams.Add(new Tuple<string, string>("after", Configuration.ApiClient.ParameterToString(after)));
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>ChatUserSettings</returns>

    public ChatUserSettings GetChatsUserSettings(string userId)
    {
        ApiResponse<ChatUserSettings> localVarResponse = GetChatsUserSettingsWithHttpInfo(userId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    public ApiResponse<ChatUserSettings> GetChatsUserSettingsWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserSettings");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/settings";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>Task of ChatUserSettings</returns>

    public async Task<ChatUserSettings> GetChatsUserSettingsAsync(string userId)
    {
        ApiResponse<ChatUserSettings> localVarResponse = await GetChatsUserSettingsAsyncWithHttpInfo(userId);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    public async Task<ApiResponse<ChatUserSettings>> GetChatsUserSettingsAsyncWithHttpInfo(string userId)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserSettings");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/settings";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUserSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ChatUserSettings</returns>

    public ChatUserSettings GetChatsUsersMeSettings()
    {
        ApiResponse<ChatUserSettings> localVarResponse = GetChatsUsersMeSettingsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    public ApiResponse<ChatUserSettings> GetChatsUsersMeSettingsWithHttpInfo()
    {

        var localVarPath = "/api/v2/chats/users/me/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUsersMeSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUsersMeSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ChatUserSettings</returns>

    public async Task<ChatUserSettings> GetChatsUsersMeSettingsAsync()
    {
        ApiResponse<ChatUserSettings> localVarResponse = await GetChatsUsersMeSettingsAsyncWithHttpInfo();
        return localVarResponse.Data;

    }

    /// <summary>
    /// Get a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    public async Task<ApiResponse<ChatUserSettings>> GetChatsUsersMeSettingsAsyncWithHttpInfo()
    {

        var localVarPath = "/api/v2/chats/users/me/settings";
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
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUsersMeSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling GetChatsUsersMeSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Set properties for a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns></returns>

    public void PatchChatsRoom(string roomJid, RoomUpdateRequest body)
    {
        PatchChatsRoomWithHttpInfo(roomJid, body);
    }

    /// <summary>
    /// Set properties for a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> PatchChatsRoomWithHttpInfo(string roomJid, RoomUpdateRequest body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoom");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoom");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Set properties for a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns>Task of void</returns>

    public async Task PatchChatsRoomAsync(string roomJid, RoomUpdateRequest body)
    {
        await PatchChatsRoomAsyncWithHttpInfo(roomJid, body);

    }

    /// <summary>
    /// Set properties for a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Room properties</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> PatchChatsRoomAsyncWithHttpInfo(string roomJid, RoomUpdateRequest body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoom");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoom");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Edit a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ChatSendMessageResponse</returns>

    public ChatSendMessageResponse PatchChatsRoomMessage(string roomJid, string messageId, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = PatchChatsRoomMessageWithHttpInfo(roomJid, messageId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Edit a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    public ApiResponse<ChatSendMessageResponse> PatchChatsRoomMessageWithHttpInfo(string roomJid, string messageId, SendMessageBody body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoomMessage");
        }
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsRoomMessage");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoomMessage");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Edit a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    public async Task<ChatSendMessageResponse> PatchChatsRoomMessageAsync(string roomJid, string messageId, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = await PatchChatsRoomMessageAsyncWithHttpInfo(roomJid, messageId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Edit a message in a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    public async Task<ApiResponse<ChatSendMessageResponse>> PatchChatsRoomMessageAsyncWithHttpInfo(string roomJid, string messageId, SendMessageBody body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoomMessage");
        }

        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsRoomMessage");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoomMessage");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Patch Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ChatSettings</returns>

    public ChatSettings PatchChatsSettings(ChatSettings body)
    {
        ApiResponse<ChatSettings> localVarResponse = PatchChatsSettingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Patch Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ApiResponse of ChatSettings</returns>

    public ApiResponse<ChatSettings> PatchChatsSettingsWithHttpInfo(ChatSettings body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsSettings");
        }

        var localVarPath = "/api/v2/chats/settings";
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Patch Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ChatSettings</returns>

    public async Task<ChatSettings> PatchChatsSettingsAsync(ChatSettings body)
    {
        ApiResponse<ChatSettings> localVarResponse = await PatchChatsSettingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Patch Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ApiResponse (ChatSettings)</returns>

    public async Task<ApiResponse<ChatSettings>> PatchChatsSettingsAsyncWithHttpInfo(ChatSettings body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsSettings");
        }

        var localVarPath = "/api/v2/chats/settings";
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Edit a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>ChatSendMessageResponse</returns>

    public ChatSendMessageResponse PatchChatsUserMessage(string userId, string messageId, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = PatchChatsUserMessageWithHttpInfo(userId, messageId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Edit a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    public ApiResponse<ChatSendMessageResponse> PatchChatsUserMessageWithHttpInfo(string userId, string messageId, SendMessageBody body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PatchChatsUserMessage");
        }
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsUserMessage");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUserMessage");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Edit a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    public async Task<ChatSendMessageResponse> PatchChatsUserMessageAsync(string userId, string messageId, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = await PatchChatsUserMessageAsyncWithHttpInfo(userId, messageId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Edit a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="messageId">messageId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    public async Task<ApiResponse<ChatSendMessageResponse>> PatchChatsUserMessageAsyncWithHttpInfo(string userId, string messageId, SendMessageBody body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PatchChatsUserMessage");
        }

        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsUserMessage");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUserMessage");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>ChatUserSettings</returns>

    public ChatUserSettings PatchChatsUserSettings(string userId, ChatUserSettings body)
    {
        ApiResponse<ChatUserSettings> localVarResponse = PatchChatsUserSettingsWithHttpInfo(userId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    public ApiResponse<ChatUserSettings> PatchChatsUserSettingsWithHttpInfo(string userId, ChatUserSettings body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PatchChatsUserSettings");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUserSettings");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/settings";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>Task of ChatUserSettings</returns>

    public async Task<ChatUserSettings> PatchChatsUserSettingsAsync(string userId, ChatUserSettings body)
    {
        ApiResponse<ChatUserSettings> localVarResponse = await PatchChatsUserSettingsAsyncWithHttpInfo(userId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">User ID</param>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    public async Task<ApiResponse<ChatUserSettings>> PatchChatsUserSettingsAsyncWithHttpInfo(string userId, ChatUserSettings body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PatchChatsUserSettings");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUserSettings");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/settings";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUserSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ChatUserSettings</returns>

    public ChatUserSettings PatchChatsUsersMeSettings(ChatUserSettings body)
    {
        ApiResponse<ChatUserSettings> localVarResponse = PatchChatsUsersMeSettingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of ChatUserSettings</returns>

    public ApiResponse<ChatUserSettings> PatchChatsUsersMeSettingsWithHttpInfo(ChatUserSettings body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUsersMeSettings");
        }

        var localVarPath = "/api/v2/chats/users/me/settings";
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUsersMeSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUsersMeSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ChatUserSettings</returns>

    public async Task<ChatUserSettings> PatchChatsUsersMeSettingsAsync(ChatUserSettings body)
    {
        ApiResponse<ChatUserSettings> localVarResponse = await PatchChatsUsersMeSettingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update a user&#39;s chat settings 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (ChatUserSettings)</returns>

    public async Task<ApiResponse<ChatUserSettings>> PatchChatsUsersMeSettingsAsyncWithHttpInfo(ChatUserSettings body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUsersMeSettings");
        }

        var localVarPath = "/api/v2/chats/users/me/settings";
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
            Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUsersMeSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PatchChatsUsersMeSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatUserSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatUserSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatUserSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Send a message to a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ChatSendMessageResponse</returns>

    public ChatSendMessageResponse PostChatsRoomMessages(string roomJid, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = PostChatsRoomMessagesWithHttpInfo(roomJid, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Send a message to a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    public ApiResponse<ChatSendMessageResponse> PostChatsRoomMessagesWithHttpInfo(string roomJid, SendMessageBody body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomMessages");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomMessages");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Send a message to a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    public async Task<ChatSendMessageResponse> PostChatsRoomMessagesAsync(string roomJid, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = await PostChatsRoomMessagesAsyncWithHttpInfo(roomJid, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Send a message to a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomId</param>
    /// <param name="body">messageBody</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    public async Task<ApiResponse<ChatSendMessageResponse>> PostChatsRoomMessagesAsyncWithHttpInfo(string roomJid, SendMessageBody body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomMessages");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomMessages");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns></returns>

    public void PostChatsRoomMessagesPins(string roomJid, PinnedMessageRequest body)
    {
        PostChatsRoomMessagesPinsWithHttpInfo(roomJid, body);
    }

    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> PostChatsRoomMessagesPinsWithHttpInfo(string roomJid, PinnedMessageRequest body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomMessagesPins");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomMessagesPins");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/pins";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessagesPins: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessagesPins: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of void</returns>

    public async Task PostChatsRoomMessagesPinsAsync(string roomJid, PinnedMessageRequest body)
    {
        await PostChatsRoomMessagesPinsAsyncWithHttpInfo(roomJid, body);

    }

    /// <summary>
    /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> PostChatsRoomMessagesPinsAsyncWithHttpInfo(string roomJid, PinnedMessageRequest body)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomMessagesPins");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomMessagesPins");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/pins";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessagesPins: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomMessagesPins: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Join a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns></returns>

    public void PostChatsRoomParticipant(string roomJid, string userId)
    {
        PostChatsRoomParticipantWithHttpInfo(roomJid, userId);
    }

    /// <summary>
    /// Join a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> PostChatsRoomParticipantWithHttpInfo(string roomJid, string userId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomParticipant");
        }
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsRoomParticipant");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Join a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of void</returns>

    public async Task PostChatsRoomParticipantAsync(string roomJid, string userId)
    {
        await PostChatsRoomParticipantAsyncWithHttpInfo(roomJid, userId);

    }

    /// <summary>
    /// Join a room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="roomJid">roomJid</param>
    /// <param name="userId">userId</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> PostChatsRoomParticipantAsyncWithHttpInfo(string roomJid, string userId)
    {
        // verify the required parameter 'roomJid' is set
        if (roomJid == null)
        {
            throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomParticipant");
        }

        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsRoomParticipant");
        }

        var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
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
        if (roomJid != null)
        {
            localVarPathParams.Add("roomJid", Configuration.ApiClient.ParameterToString(roomJid));
        }

        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
        }

        // Query params

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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Create an adhoc room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>CreateRoomResponse</returns>

    public CreateRoomResponse PostChatsRooms(CreateRoomRequest body)
    {
        ApiResponse<CreateRoomResponse> localVarResponse = PostChatsRoomsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create an adhoc room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>ApiResponse of CreateRoomResponse</returns>

    public ApiResponse<CreateRoomResponse> PostChatsRoomsWithHttpInfo(CreateRoomRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRooms");
        }

        var localVarPath = "/api/v2/chats/rooms";
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CreateRoomResponse>(localVarStatusCode,
            localVarHeaders,
            (CreateRoomResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateRoomResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Create an adhoc room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>Task of CreateRoomResponse</returns>

    public async Task<CreateRoomResponse> PostChatsRoomsAsync(CreateRoomRequest body)
    {
        ApiResponse<CreateRoomResponse> localVarResponse = await PostChatsRoomsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Create an adhoc room 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Room properties</param>
    /// <returns>Task of ApiResponse (CreateRoomResponse)</returns>

    public async Task<ApiResponse<CreateRoomResponse>> PostChatsRoomsAsyncWithHttpInfo(CreateRoomRequest body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRooms");
        }

        var localVarPath = "/api/v2/chats/rooms";
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<CreateRoomResponse>(localVarStatusCode,
            localVarHeaders,
            (CreateRoomResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateRoomResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Send a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>ChatSendMessageResponse</returns>

    public ChatSendMessageResponse PostChatsUserMessages(string userId, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = PostChatsUserMessagesWithHttpInfo(userId, body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Send a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>ApiResponse of ChatSendMessageResponse</returns>

    public ApiResponse<ChatSendMessageResponse> PostChatsUserMessagesWithHttpInfo(string userId, SendMessageBody body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsUserMessages");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsUserMessages");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Send a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ChatSendMessageResponse</returns>

    public async Task<ChatSendMessageResponse> PostChatsUserMessagesAsync(string userId, SendMessageBody body)
    {
        ApiResponse<ChatSendMessageResponse> localVarResponse = await PostChatsUserMessagesAsyncWithHttpInfo(userId, body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Send a message to a user 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">message body</param>
    /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>

    public async Task<ApiResponse<ChatSendMessageResponse>> PostChatsUserMessagesAsyncWithHttpInfo(string userId, SendMessageBody body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsUserMessages");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsUserMessages");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
            localVarHeaders,
            (ChatSendMessageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns></returns>

    public void PostChatsUserMessagesPins(string userId, PinnedMessageRequest body)
    {
        PostChatsUserMessagesPinsWithHttpInfo(userId, body);
    }

    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> PostChatsUserMessagesPinsWithHttpInfo(string userId, PinnedMessageRequest body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsUserMessagesPins");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsUserMessagesPins");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/pins";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessagesPins: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessagesPins: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of void</returns>

    public async Task PostChatsUserMessagesPinsAsync(string userId, PinnedMessageRequest body)
    {
        await PostChatsUserMessagesPinsAsyncWithHttpInfo(userId, body);

    }

    /// <summary>
    /// Add pinned messages for a 1on1, up to a maximum of 5 pinned messages 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">userId</param>
    /// <param name="body">Pinned Message Ids</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> PostChatsUserMessagesPinsAsyncWithHttpInfo(string userId, PinnedMessageRequest body)
    {
        // verify the required parameter 'userId' is set
        if (userId == null)
        {
            throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsUserMessagesPins");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsUserMessagesPins");
        }

        var localVarPath = "/api/v2/chats/users/{userId}/messages/pins";
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
        if (userId != null)
        {
            localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
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
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessagesPins: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PostChatsUserMessagesPins: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update reactions to a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns></returns>

    public void PutChatsMessageReactions(string messageId, ChatReactionUpdate body)
    {
        PutChatsMessageReactionsWithHttpInfo(messageId, body);
    }

    /// <summary>
    /// Update reactions to a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns>ApiResponse of Object(void)</returns>

    public ApiResponse<object> PutChatsMessageReactionsWithHttpInfo(string messageId, ChatReactionUpdate body)
    {
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PutChatsMessageReactions");
        }
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatsMessageReactions");
        }

        var localVarPath = "/api/v2/chats/messages/{messageId}/reactions";
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
        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutChatsMessageReactions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutChatsMessageReactions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update reactions to a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns>Task of void</returns>

    public async Task PutChatsMessageReactionsAsync(string messageId, ChatReactionUpdate body)
    {
        await PutChatsMessageReactionsAsyncWithHttpInfo(messageId, body);

    }

    /// <summary>
    /// Update reactions to a message 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="messageId">messageId</param>
    /// <param name="body">reactionUpdate</param>
    /// <returns>Task of ApiResponse</returns>

    public async Task<ApiResponse<object>> PutChatsMessageReactionsAsyncWithHttpInfo(string messageId, ChatReactionUpdate body)
    {
        // verify the required parameter 'messageId' is set
        if (messageId == null)
        {
            throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PutChatsMessageReactions");
        }

        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatsMessageReactions");
        }

        var localVarPath = "/api/v2/chats/messages/{messageId}/reactions";
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
        if (messageId != null)
        {
            localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId));
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutChatsMessageReactions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutChatsMessageReactions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<object>(localVarStatusCode,
            localVarHeaders,
            null,
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



    /// <summary>
    /// Update Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ChatSettings</returns>

    public ChatSettings PutChatsSettings(ChatSettings body)
    {
        ApiResponse<ChatSettings> localVarResponse = PutChatsSettingsWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>ApiResponse of ChatSettings</returns>

    public ApiResponse<ChatSettings> PutChatsSettingsWithHttpInfo(ChatSettings body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatsSettings");
        }

        var localVarPath = "/api/v2/chats/settings";
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }


    /// <summary>
    /// Update Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ChatSettings</returns>

    public async Task<ChatSettings> PutChatsSettingsAsync(ChatSettings body)
    {
        ApiResponse<ChatSettings> localVarResponse = await PutChatsSettingsAsyncWithHttpInfo(body);
        return localVarResponse.Data;

    }

    /// <summary>
    /// Update Chat Settings. 
    /// 
    /// </summary>
    /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Chat</param>
    /// <returns>Task of ApiResponse (ChatSettings)</returns>

    public async Task<ApiResponse<ChatSettings>> PutChatsSettingsAsyncWithHttpInfo(ChatSettings body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
        {
            throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatsSettings");
        }

        var localVarPath = "/api/v2/chats/settings";
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
            throw new ApiException(localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
        }
        else if (localVarStatusCode == 0)
        {
            throw new ApiException(localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
        }

        return new ApiResponse<ChatSettings>(localVarStatusCode,
            localVarHeaders,
            (ChatSettings)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
            localVarResponse.Content,
            localVarResponse.StatusDescription);
    }



}
