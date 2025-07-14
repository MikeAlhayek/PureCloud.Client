using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Recognition
{
    /// <summary>
    /// The type of recognition
    /// </summary>
    /// <value>The type of recognition</value>
    public RecognitionTypeEnum? Type { get; set; }

    /// <summary>
    /// The context type (optional)
    /// </summary>
    /// <value>The context type (optional)</value>
    public RecognitionContextTypeEnum? ContextType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The recipient of the recognition
    /// </summary>
    /// <value>The recipient of the recognition</value>
    public UserReference Recipient { get; set; }

    /// <summary>
    /// The creator of the recognition
    /// </summary>
    /// <value>The creator of the recognition</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The recognition title
    /// </summary>
    /// <value>The recognition title</value>
    public string Title { get; set; }

    /// <summary>
    /// The recognition note
    /// </summary>
    /// <value>The recognition note</value>
    public string Note { get; set; }

    /// <summary>
    /// The context id (optional)
    /// </summary>
    /// <value>The context id (optional)</value>
    public string ContextId { get; set; }

    /// <summary>
    /// The displayed date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The displayed date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateDisplayed { get; set; }

    /// <summary>
    /// The acknowledged date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The acknowledged date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateAcknowledged { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
