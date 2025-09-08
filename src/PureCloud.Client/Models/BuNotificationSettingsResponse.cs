namespace PureCloud.Client.Models;

/// <summary>
/// BuNotificationSettingsResponse
/// </summary>
public sealed class BuNotificationSettingsResponse
{
    /// <summary>
    /// Schedule notification settings
    /// </summary>
    /// <value>Schedule notification settings</value>
    public BuScheduleNotificationsSettingsResponse Scheduling { get; set; }
}
