using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Operation
{
    /// <summary>
    /// Action name
    /// </summary>
    /// <value>Action name</value>
    public OperationActionNameEnum? ActionName { get; set; }

    /// <summary>
    /// Action status
    /// </summary>
    /// <value>Action status</value>
    public OperationActionStatusEnum? ActionStatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Complete
    /// </summary>
    public bool? Complete { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    public DomainEntityRef Client { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ErrorDetails
    /// </summary>
    public IEnumerable<Detail> ErrorDetails { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessageParams
    /// </summary>
    public Dictionary<string, string> ErrorMessageParams { get; set; }
}
