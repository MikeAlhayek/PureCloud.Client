namespace PureCloud.Client.Models;

public sealed class LocationAddressVerificationDetails
{
    /// <summary>
    /// Status of address verification process
    /// </summary>
    /// <value>Status of address verification process</value>
    public LocationAddressVerificationDetailsStatus? Status { get; set; }

    /// <summary>
    /// Finished time of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Finished time of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateFinished { get; set; }

    /// <summary>
    /// Time started of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Time started of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStarted { get; set; }

    /// <summary>
    /// Third party service used for address verification
    /// </summary>
    /// <value>Third party service used for address verification</value>
    public string Service { get; set; }
}
