using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IChatApi
{
    Task<bool> DeleteChatsRoomMessageAsync(string roomJid, string messageId, CancellationToken cancellationToken = default);

    Task<bool> DeleteChatsRoomMessagesPinAsync(string roomJid, string pinnedMessageId, CancellationToken cancellationToken = default);

    Task<bool> DeleteChatsRoomParticipantAsync(string roomJid, string userId, CancellationToken cancellationToken = default);

    Task<bool> DeleteChatsUserMessageAsync(string userId, string messageId, CancellationToken cancellationToken = default);

    Task<bool> DeleteChatsUserMessagesPinAsync(string userId, string pinnedMessageId, CancellationToken cancellationToken = default);

    Task<ChatMessageResponse> GetChatsMessageAsync(string messageId, CancellationToken cancellationToken = default);

    Task<Room> GetChatsRoomAsync(string roomJid, CancellationToken cancellationToken = default);

    Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync(string roomJid, string messageIds, CancellationToken cancellationToken = default);

    Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync(string roomJid, string limit = null, string before = null, string after = null, CancellationToken cancellationToken = default);

    Task<RoomParticipant> GetChatsRoomParticipantAsync(string roomJid, string participantJid, CancellationToken cancellationToken = default);

    Task<RoomParticipantsResponse> GetChatsRoomParticipantsAsync(string roomJid, CancellationToken cancellationToken = default);

    Task<ChatSettings> GetChatsSettingsAsync(CancellationToken cancellationToken = default);

    Task<ChatMessageEntityListing> GetChatsThreadMessagesAsync(string threadId, string limit = null, string before = null, string after = null, CancellationToken cancellationToken = default);

    Task<OneOnOne> GetChatsUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<ChatMessageEntityListing> GetChatsUserMessageAsync(string userId, string messageIds, CancellationToken cancellationToken = default);

    Task<ChatMessageResponse> GetChatsUserMessagesAsync(string userId, string limit = null, string before = null, string after = null, CancellationToken cancellationToken = default);

    Task<ChatUserSettings> GetChatsUserSettingsAsync(string userId, CancellationToken cancellationToken = default);

    Task<ChatUserSettings> GetChatsUsersMeSettingsAsync(CancellationToken cancellationToken = default);

    Task<bool> UpdateChatsRoomAsync(string roomJid, RoomUpdateRequest body, CancellationToken cancellationToken = default);

    Task<ChatSendMessageResponse> UpdateChatsRoomMessageAsync(string roomJid, string messageId, SendMessageBody body, CancellationToken cancellationToken = default);

    Task<ChatSettings> PatchUpdateChatsSettingsAsync(ChatSettings body, CancellationToken cancellationToken = default);

    Task<ChatSendMessageResponse> PatchChatsUsersMessagesAsync(string userId, string messageId, SendMessageBody body, CancellationToken cancellationToken = default);

    Task<ChatUserSettings> PatchChatsUsersSettingsAsync(string userId, ChatUserSettings body, CancellationToken cancellationToken = default);

    Task<ChatUserSettings> UpdateChatsUsersMeSettingsAsync(ChatUserSettings body, CancellationToken cancellationToken = default);

    Task<ChatSendMessageResponse> CreateChatsRoomMessagesAsync(string roomJid, SendMessageBody body, CancellationToken cancellationToken = default);

    Task<bool> CreateChatsRoomMessagesPinsAsync(string roomJid, PinnedMessageRequest body, CancellationToken cancellationToken = default);

    Task<bool> CreateChatsRoomParticipantAsync(string roomJid, string userId, CancellationToken cancellationToken = default);

    Task<CreateRoomResponse> CreateChatsRoomsAsync(CreateRoomRequest body, CancellationToken cancellationToken = default);

    Task<ChatSendMessageResponse> CreateChatsUsersMessagesAsync(string userId, SendMessageBody body, CancellationToken cancellationToken = default);

    Task<bool> CreateChatsUsersMessagesPinsAsync(string userId, PinnedMessageRequest body, CancellationToken cancellationToken = default);

    Task<bool> UpdateChatsMessageReactionsAsync(string messageId, ChatReactionUpdate body, CancellationToken cancellationToken = default);

    Task<ChatSettings> UpdateChatsSettingsAsync(ChatSettings body, CancellationToken cancellationToken = default);
}
