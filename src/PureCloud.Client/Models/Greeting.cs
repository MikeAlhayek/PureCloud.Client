using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Greeting
{
    /// <summary>
    /// Greeting type
    /// </summary>
    /// <value>Greeting type</value>
    public GreetingTypeEnum? Type { get; set; }

    /// <summary>
    /// Greeting owner type
    /// </summary>
    /// <value>Greeting owner type</value>
    public GreetingOwnerTypeEnum? OwnerType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Greeting owner
    /// </summary>
    /// <value>Greeting owner</value>
    public DomainEntity Owner { get; set; }

    /// <summary>
    /// Gets or Sets AudioFile
    /// </summary>
    public GreetingAudioFile AudioFile { get; set; }

    /// <summary>
    /// Gets or Sets AudioTTS
    /// </summary>
    public string AudioTTS { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public string ModifiedBy { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
