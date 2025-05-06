using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed partial class AuditTopicAuditLogMessage
{
    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    public ServiceNameEnum? ServiceName { get; set; }


    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public ActionEnum? Action { get; set; }


    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    ///
    public EntityTypeEnum? EntityType { get; set; }


    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }


    /// <summary>
    /// Gets or Sets UserHomeOrgId
    /// </summary>
    public string UserHomeOrgId { get; set; }


    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    public AuditTopicDomainEntityRef Username { get; set; }


    /// <summary>
    /// Gets or Sets UserDisplay
    /// </summary>
    public string UserDisplay { get; set; }


    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    public AuditTopicAddressableEntityRef ClientId { get; set; }


    /// <summary>
    /// Gets or Sets RemoteIp
    /// </summary>
    public IEnumerable<string> RemoteIp { get; set; }


    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    public string Level { get; set; }


    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public DateTime? EventTime { get; set; }


    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public AuditTopicMessageInfo Message { get; set; }


    /// <summary>
    /// Gets or Sets Entity
    /// </summary>
    public AuditTopicDomainEntityRef Entity { get; set; }


    /// <summary>
    /// Gets or Sets PropertyChanges
    /// </summary>
    [JsonPropertyName("propertyChanges")]
    public IEnumerable<AuditTopicPropertyChange> PropertyChanges { get; set; }


    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    public Dictionary<string, string> Context { get; set; }
}
