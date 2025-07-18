using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InfrastructureascodeJob
{
    /// <summary>
    /// Job status
    /// </summary>
    /// <value>Job status</value>
    public InfrastructureascodeJobStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Whether or not the job was a dry run
    /// </summary>
    /// <value>Whether or not the job was a dry run</value>
    public bool? DryRun { get; set; }

    /// <summary>
    /// Accelerator associated with the job
    /// </summary>
    /// <value>Accelerator associated with the job</value>
    public string AcceleratorId { get; set; }

    /// <summary>
    /// Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateSubmitted { get; set; }

    /// <summary>
    /// User who submitted the job
    /// </summary>
    /// <value>User who submitted the job</value>
    public UserReference SubmittedBy { get; set; }

    /// <summary>
    /// Information about errors, if any
    /// </summary>
    /// <value>Information about errors, if any</value>
    public ErrorInfo ErrorInfo { get; set; }

    /// <summary>
    /// The output results of the terraform job
    /// </summary>
    /// <value>The output results of the terraform job</value>
    public string Results { get; set; }

    /// <summary>
    /// The results of rolling back the job if there were errors.  Not returned if job was successful.
    /// </summary>
    /// <value>The results of rolling back the job if there were errors.  Not returned if job was successful.</value>
    public string RollbackResults { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
