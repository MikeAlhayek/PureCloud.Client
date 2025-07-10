using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class ChatApi : IChatApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ChatApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<bool> DeleteChatsRoomMessageAsync(string roomJid, string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/chats/rooms/{roomJid}/messages/{messageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteChatsRoomMessagesPinAsync(string roomJid, string pinnedMessageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentException.ThrowIfNullOrEmpty(pinnedMessageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/chats/rooms/{roomJid}/messages/pins/{pinnedMessageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteChatsRoomParticipantAsync(string roomJid, string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/chats/rooms/{roomJid}/participants/{userId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteChatsUserMessageAsync(string userId, string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/chats/users/{userId}/messages/{messageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteChatsUserMessagesPinAsync(string userId, string pinnedMessageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(pinnedMessageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/chats/users/{userId}/messages/pins/{pinnedMessageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<ChatMessageResponse> GetChatsMessageAsync(string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/messages/{messageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatMessageResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Room> GetChatsRoomAsync(string roomJid, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/rooms/{roomJid}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Room>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync(string roomJid, string messageIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentException.ThrowIfNullOrEmpty(messageIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/rooms/{roomJid}/messages/{messageIds}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatMessageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync(string roomJid, string limit = null, string before = null, string after = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection
        {
            { "limit", limit },
            { "before", before },
            { "after", after }
        };

        var response = await client.GetAsync(UriHelper.GetUri($"api/v2/chats/rooms/{roomJid}/messages", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatMessageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoomParticipant> GetChatsRoomParticipantAsync(string roomJid, string participantJid, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentException.ThrowIfNullOrEmpty(participantJid);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);


        var response = await client.GetAsync($"api/v2/chats/rooms/{roomJid}/participants/{participantJid}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoomParticipant>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoomParticipantsResponse> GetChatsRoomParticipantsAsync(string roomJid, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/rooms/{roomJid}/participants", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoomParticipantsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatSettings> GetChatsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/chats/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatMessageEntityListing> GetChatsThreadMessagesAsync(string threadId, string limit = null, string before = null, string after = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(threadId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection
        {
            { "limit", limit },
            { "before", before },
            { "after", after }
        };

        var uri = $"api/v2/chats/threads/{threadId}/messages{(parameters.Count > 0 ? "?" + UriHelper.GetUri(string.Empty, parameters) : string.Empty)}";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatMessageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OneOnOne> GetChatsUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/users/{userId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OneOnOne>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatMessageEntityListing> GetChatsUserMessageAsync(string userId, string messageIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentException.ThrowIfNullOrEmpty(messageIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/users/{userId}/messages/{messageIds}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatMessageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatMessageResponse> GetChatsUserMessagesAsync(string userId, string limit = null, string before = null, string after = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(limit))
        {
            parameters.Add("limit", limit);
        }

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        var url = UriHelper.GetUri($"api/v2/chats/users/{userId}/messages", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatMessageResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatUserSettings> GetChatsUserSettingsAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/chats/users/{Uri.EscapeDataString(userId)}/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatUserSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatUserSettings> GetChatsUsersMeSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/chats/users/me/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatUserSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> UpdateChatsRoomAsync(string roomJid, RoomUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(roomJid);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/chats/rooms/{roomJid}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<ChatSendMessageResponse> UpdateChatsRoomMessageAsync(string roomJid, string messageId, SendMessageBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(roomJid);

        ArgumentException.ThrowIfNullOrWhiteSpace(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/chats/rooms/{roomJid}/messages/{messageId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSendMessageResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatSettings> PatchUpdateChatsSettingsAsync(ChatSettings body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/chats/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatSendMessageResponse> PatchChatsUsersMessagesAsync(string userId, string messageId, SendMessageBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(userId);

        ArgumentException.ThrowIfNullOrWhiteSpace(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/chats/users/{userId}/messages/{messageId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSendMessageResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatUserSettings> PatchChatsUsersSettingsAsync(string userId, ChatUserSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/chats/users/{userId}/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatUserSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatUserSettings> UpdateChatsUsersMeSettingsAsync(ChatUserSettings body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/chats/users/me/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatUserSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatSendMessageResponse> CreateChatsRoomMessagesAsync(string roomJid, SendMessageBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/chats/rooms/{roomJid}/messages", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSendMessageResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> CreateChatsRoomMessagesPinsAsync(string roomJid, PinnedMessageRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/chats/rooms/{roomJid}/messages/pins", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> CreateChatsRoomParticipantAsync(string roomJid, string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(roomJid);

        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/chats/rooms/{roomJid}/participants/{userId}", null, cancellationToken);

        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;
    }

    public async Task<CreateRoomResponse> CreateChatsRoomsAsync(CreateRoomRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/chats/rooms", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CreateRoomResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ChatSendMessageResponse> CreateChatsUsersMessagesAsync(string userId, SendMessageBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/chats/users/{userId}/messages", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSendMessageResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> CreateChatsUsersMessagesPinsAsync(string userId, PinnedMessageRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/chats/users/{userId}/messages/pins", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateChatsMessageReactionsAsync(string messageId, ChatReactionUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/chats/messages/{messageId}/reactions", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<ChatSettings> UpdateChatsSettingsAsync(ChatSettings body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/chats/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ChatSettings>(_options.JsonSerializerOptions, cancellationToken);
    }


}
