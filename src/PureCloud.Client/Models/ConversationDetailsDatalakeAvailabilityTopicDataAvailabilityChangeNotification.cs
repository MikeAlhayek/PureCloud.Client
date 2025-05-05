namespace PureCloud.Client.Models;

public sealed class ConversationDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification
{
    /// <summary>
    /// Date and time before which data is guaranteed to be available in the datalake
    /// </summary>
    /// <value>Date and time before which data is guaranteed to be available in the datalake</value>
    public DateTime? DataAvailabilityDate { get; set; }
}
