using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class CallForwarding
{
    /// <summary>
    /// The type of voicemail to use with the callForwarding configuration
    /// </summary>
    /// <value>The type of voicemail to use with the callForwarding configuration</value>
    public CallForwardingVoicemailEnum? Voicemail { get; set; }

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
    /// Gets or Sets User
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Whether or not CallForwarding is enabled
    /// </summary>
    /// <value>Whether or not CallForwarding is enabled</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// This property is deprecated. Please use the calls property
    /// </summary>
    /// <value>This property is deprecated. Please use the calls property</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// An ordered list of CallRoutes to be executed when CallForwarding is enabled
    /// </summary>
    /// <value>An ordered list of CallRoutes to be executed when CallForwarding is enabled</value>
    public IEnumerable<CallRoute> Calls { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
