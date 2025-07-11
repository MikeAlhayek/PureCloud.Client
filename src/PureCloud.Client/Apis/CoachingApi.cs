using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class CoachingApi : ICoachingApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public CoachingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<CoachingAppointmentReference> DeleteCoachingAppointmentAsync(string appointmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/coaching/appointments/{appointmentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentReference>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteCoachingAppointmentAnnotationAsync(string appointmentId, string annotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentException.ThrowIfNullOrEmpty(annotationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<CoachingAppointmentResponse> GetCoachingAppointmentAsync(string appointmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/coaching/appointments/{appointmentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAnnotation> GetCoachingAppointmentAnnotationAsync(string appointmentId, string annotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentException.ThrowIfNullOrEmpty(annotationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAnnotation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAnnotationList> GetCoachingAppointmentAnnotationsAsync(string appointmentId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            query["pageNumber"] = pageNumber.Value.ToString();
        }

        if (pageSize.HasValue)
        {
            query["pageSize"] = pageSize.Value.ToString();
        }

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}/annotations", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAnnotationList>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<CoachingAppointmentStatusResponseList> GetCoachingAppointmentStatusesAsync(string appointmentId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            queryParams.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            queryParams.Add("pageSize", pageSize.Value.ToString());
        }

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}/statuses", queryParams);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentStatusResponseList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAppointmentResponseList> GetCoachingAppointmentsAsync(IList<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, IList<string> statuses = null, IList<string> facilitatorIds = null, string sortOrder = null, IList<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null, CancellationToken cancellationToken = default)
    {
        if (userIds.Count == 0)
        {
            throw new ArgumentException("At least one userId must be provided.", nameof(userIds));
        }

        ArgumentException.ThrowIfNullOrEmpty(sortOrder, nameof(sortOrder));

        ArgumentException.ThrowIfNullOrEmpty(intervalCondition, nameof(intervalCondition));

        ArgumentException.ThrowIfNullOrEmpty(overdue, nameof(overdue));

        ArgumentException.ThrowIfNullOrEmpty(completionInterval, nameof(completionInterval));

        ArgumentException.ThrowIfNullOrEmpty(interval, nameof(interval));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new NameValueCollection();

        foreach (var userId in userIds)
        {
            queryParams.Add("userIds", userId);
        }

        if (interval != null)
        {
            queryParams.Add("interval", interval);
        }

        if (pageNumber.HasValue)
        {
            queryParams.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            queryParams.Add("pageSize", pageSize.Value.ToString());
        }

        if (statuses != null)
        {
            foreach (var status in statuses)
            {
                queryParams.Add("statuses", status);
            }
        }

        if (facilitatorIds != null)
        {
            foreach (var facilitatorId in facilitatorIds)
            {
                queryParams.Add("facilitatorIds", facilitatorId);
            }
        }

        if (sortOrder != null)
        {
            queryParams.Add("sortOrder", sortOrder);
        }

        if (relationships != null)
        {
            foreach (var relationship in relationships)
            {
                queryParams.Add("relationships", relationship);
            }
        }

        if (completionInterval != null)
        {
            queryParams.Add("completionInterval", completionInterval);
        }

        if (overdue != null)
        {
            queryParams.Add("overdue", overdue);
        }

        if (intervalCondition != null)
        {
            queryParams.Add("intervalCondition", intervalCondition);
        }

        var uri = UriHelper.GetUri("api/v2/coaching/appointments", queryParams);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentResponseList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAppointmentResponseList> GetCoachingAppointmentsMeAsync(string interval = null, int? pageNumber = null, int? pageSize = null, IList<string> statuses = null, IList<string> facilitatorIds = null, string sortOrder = null, IList<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new NameValueCollection();

        if (interval != null)
        {
            queryParams.Add("interval", interval);
        }

        if (pageNumber.HasValue)
        {
            queryParams.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (pageSize.HasValue)
        {
            queryParams.Add("pageSize", pageSize.Value.ToString());
        }

        if (statuses != null)
        {
            foreach (var status in statuses)
            {
                queryParams.Add("statuses", status);
            }
        }

        if (facilitatorIds != null)
        {
            foreach (var facilitatorId in facilitatorIds)
            {
                queryParams.Add("facilitatorIds", facilitatorId);
            }
        }

        if (sortOrder != null)
        {
            queryParams.Add("sortOrder", sortOrder);
        }

        if (relationships != null)
        {
            foreach (var r in relationships)
            {
                queryParams.Add("relationships", r);
            }
        }

        if (completionInterval != null)
        {
            queryParams.Add("completionInterval", completionInterval);
        }

        if (overdue != null)
        {
            queryParams.Add("overdue", overdue);
        }

        if (intervalCondition != null)
        {
            queryParams.Add("intervalCondition", intervalCondition);
        }

        var uri = UriHelper.GetUri("api/v2/coaching/appointments/me", queryParams);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentResponseList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingNotification> GetCoachingNotificationAsync(string notificationId, IList<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(notificationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                queryParams.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/coaching/notifications/{notificationId}", queryParams);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingNotification>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAppointmentResponse> PatchCoachingAppointmentAsync(string appointmentId, UpdateCoachingAppointmentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAnnotation> PatchCoachingAppointmentAnnotationAsync(string appointmentId, string annotationId, CoachingAnnotation body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentException.ThrowIfNullOrEmpty(annotationId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAnnotation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAppointmentStatusResponse> PatchCoachingAppointmentStatusAsync(string appointmentId, CoachingAppointmentStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}/status", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingNotification> PatchCoachingNotificationAsync(string notificationId, CoachingNotification body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(notificationId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/coaching/notifications/{notificationId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingNotification>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAnnotation> CreateCoachingAppointmentAnnotationAsync(string appointmentId, CoachingAnnotationCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}/annotations", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAnnotation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AddConversationResponse> CreateCoachingAppointmentConversationAsync(string appointmentId, AddConversationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(appointmentId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/coaching/appointments/{appointmentId}/conversations", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AddConversationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAppointmentResponse> CreateCoachingAppointmentAsync(CreateCoachingAppointmentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/coaching/appointments", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingAppointmentAggregateResponse> CreateCoachingAppointmentAggregatesQueryAsync(CoachingAppointmentAggregateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/coaching/appointments/aggregates/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingAppointmentAggregateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoachingSlotsResponse> CreateCoachingScheduleslotsQueryAsync(CoachingSlotsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/coaching/scheduleslots/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoachingSlotsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }


}
