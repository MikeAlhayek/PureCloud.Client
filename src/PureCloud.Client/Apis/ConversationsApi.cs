using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Apis;

public sealed class ConversationsApi : IConversationsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ConversationsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    #region Converations
    public async Task<Conversation> GetConversationAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        try
        {
            var response = await client.GetAsync($"api/v2/conversations/{conversationId}", cancellationToken);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Conversation>(_options.JsonSerializerOptions, cancellationToken);
        }
        catch (Exception ex)
        {
            var t = ex;
        }

        return null;
    }

    public async Task<AnalyticsConversationWithoutAttributes> GetConversationDetailsAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/conversations/{conversationId}/details", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationWithoutAttributes>(_options.JsonSerializerOptions, cancellationToken);
    }

    #endregion


    #region Jobs
    public async Task<bool> DeleteJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/analytics/conversations/details/jobs/{jobId}", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }
    #endregion

    #region Codes

    /// <summary>
    /// Delete a code used to add a communication to this participant 
    /// </summary>
    /// <param name="conversationId"></param>
    /// <param name="participantId"></param>
    /// <param name="addCommunicationCode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteParticipantCodeAsync(string conversationId, string participantId, string addCommunicationCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(participantId);
        ArgumentException.ThrowIfNullOrEmpty(addCommunicationCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode}", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }
    #endregion

    #region Flagged Reasons

    /// <summary>
    /// Remove flagged reason from conversation participant. 
    /// </summary>
    /// <param name="conversationId"></param>
    /// <param name="participantId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteParticipantFlaggedReasonAsync(string conversationId, string participantId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(participantId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }
    #endregion

    #region Messagining Settings

    /// <summary>
    /// Delete a messaging setting .
    /// </summary>
    /// <param name="messageSettingId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteMessagingSettingAsync(string messageSettingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageSettingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/messaging/settings/{messageSettingId}", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Delete the organization's default setting, a global default will be applied to integrations without settings 
    /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be assigned to it.
    /// </summary>
    /// <param name="messageSettingId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteMessagingDefaultSettingAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/conversations/messaging/settings/default", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    #endregion

    #region Consults or Transfers

    /// <summary>
    /// Cancel the transfer 
    /// </summary>
    /// <param name="conversationId"></param>
    /// <param name="participantId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteParticipantConsultAsync(string conversationId, string participantId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(participantId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }
    #endregion

    #region Support Contents

    /// <summary>
    /// Cancel the transfer 
    /// </summary>
    /// <param name="supportedContentId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteMessagingSupportedContentAsync(string supportedContentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(supportedContentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/messaging/supportedcontent/{supportedContentId}", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }
    #endregion

    #region Attachments

    /// <summary>
    /// Delete attachment from draft.
    /// </summary>
    /// <param name="conversationId"></param>
    /// <param name="attachmentId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteAttachmentAsync(string conversationId, string attachmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(attachmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId}", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    #endregion

    #region Facebook Messaging Integrations

    /// <summary>
    /// Delete a Facebook messaging integration.
    /// </summary>
    /// <param name="integrationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<bool> DeleteFacebookMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        return DeleteMessagingIntegrationAsync("facebook", integrationId, cancellationToken);
    }

    #endregion


    #region Instagram Integrations

    /// <summary>
    /// Delete a Instagram messaging integration.
    /// </summary>
    /// <param name="integrationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<bool> DeleteInstagramMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        return DeleteMessagingIntegrationAsync("integration", integrationId, cancellationToken);
    }

    #endregion

    #region Open Messagining Integrations

    /// <summary>
    /// Delete a Open messaging integration.
    /// </summary>
    /// <param name="integrationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<bool> DeleteOpenMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        return DeleteMessagingIntegrationAsync("open", integrationId, cancellationToken);
    }

    #endregion

    #region Twitter Messagining Integrations

    /// <summary>
    /// Delete a Twitter messaging integration.
    /// </summary>
    /// <param name="integrationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<bool> DeleteTwitterMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        return DeleteMessagingIntegrationAsync("twitter", integrationId, cancellationToken);
    }

    #endregion


    #region Whatsapp Messagining Integrations

    /// <summary>
    /// Delete a Twitter messaging integration.
    /// </summary>
    /// <param name="integrationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<bool> DeleteWhatsappMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        return DeleteMessagingIntegrationAsync("whatsapp", integrationId, cancellationToken);
    }

    #endregion

    private async Task<bool> DeleteMessagingIntegrationAsync(string provider, string integrationId, CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/messaging/integrations/{provider}/{integrationId}", cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }
}
