using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ICoachingApi
{
    Task<CoachingAppointmentReference> DeleteCoachingAppointmentAsync(string appointmentId, CancellationToken cancellationToken = default);

    Task<bool> DeleteCoachingAppointmentAnnotationAsync(string appointmentId, string annotationId, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentResponse> GetCoachingAppointmentAsync(string appointmentId, CancellationToken cancellationToken = default);

    Task<CoachingAnnotation> GetCoachingAppointmentAnnotationAsync(string appointmentId, string annotationId, CancellationToken cancellationToken = default);

    Task<CoachingAnnotationList> GetCoachingAppointmentAnnotationsAsync(string appointmentId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentStatusResponseList> GetCoachingAppointmentStatusesAsync(string appointmentId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentResponseList> GetCoachingAppointmentsAsync(IList<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, IList<string> statuses = null, IList<string> facilitatorIds = null, string sortOrder = null, IList<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentResponseList> GetCoachingAppointmentsMeAsync(string interval = null, int? pageNumber = null, int? pageSize = null, IList<string> statuses = null, IList<string> facilitatorIds = null, string sortOrder = null, IList<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null, CancellationToken cancellationToken = default);

    Task<CoachingNotification> GetCoachingNotificationAsync(string notificationId, IList<string> expand = null, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentResponse> PatchCoachingAppointmentAsync(string appointmentId, UpdateCoachingAppointmentRequest body, CancellationToken cancellationToken = default);

    Task<CoachingAnnotation> PatchCoachingAppointmentAnnotationAsync(string appointmentId, string annotationId, CoachingAnnotation body, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentStatusResponse> PatchCoachingAppointmentStatusAsync(string appointmentId, CoachingAppointmentStatusRequest body, CancellationToken cancellationToken = default);

    Task<CoachingNotification> PatchCoachingNotificationAsync(string notificationId, CoachingNotification body, CancellationToken cancellationToken = default);

    Task<CoachingAnnotation> CreateCoachingAppointmentAnnotationAsync(string appointmentId, CoachingAnnotationCreateRequest body, CancellationToken cancellationToken = default);

    Task<AddConversationResponse> CreateCoachingAppointmentConversationAsync(string appointmentId, AddConversationRequest body, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentResponse> CreateCoachingAppointmentAsync(CreateCoachingAppointmentRequest body, CancellationToken cancellationToken = default);

    Task<CoachingAppointmentAggregateResponse> CreateCoachingAppointmentAggregatesQueryAsync(CoachingAppointmentAggregateRequest body, CancellationToken cancellationToken = default);

    Task<CoachingSlotsResponse> CreateCoachingScheduleslotsQueryAsync(CoachingSlotsRequest body, CancellationToken cancellationToken = default);
}
