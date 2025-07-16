using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportJobResponse
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public ContactImportJobResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// Detailed description for the Job execution state
    /// </summary>
    /// <value>Detailed description for the Job execution state</value>
    public ContactImportJobResponseExecutionStepEnum? ExecutionStep { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Detailed description for JobStatus.
    /// </summary>
    /// <value>Detailed description for JobStatus.</value>
    public string StatusDetails { get; set; }

    /// <summary>
    /// Metadata for the job
    /// </summary>
    /// <value>Metadata for the job</value>
    public ContactImportJobMetadata Metadata { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary
    public string SelfUri { get; set; }

    /// <summary>
    /// Settings
    /// </summary>
    /// <value>Settings</value>
    public AddressableEntityRef Settings { get; set; }
}
