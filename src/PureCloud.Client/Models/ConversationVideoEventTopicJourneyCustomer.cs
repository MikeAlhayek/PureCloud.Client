using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationVideoEventTopicJourneyCustomer
{
    /// <summary>
    /// An ID of a customer within the Journey System at a point-in-time.  Note that a customer entity can have multiple customerIds based on the stitching process.  Depending on the context within the PureCloudEnvironment conversation, this may or may not be mutable.
    /// </summary>
    /// <value>An ID of a customer within the Journey System at a point-in-time.  Note that a customer entity can have multiple customerIds based on the stitching process.  Depending on the context within the PureCloudEnvironment conversation, this may or may not be mutable.</value>
    public string Id { get; set; }

    /// <summary>
    /// The type of the customerId within the Journey System (e.g. cookie).
    /// </summary>
    /// <value>The type of the customerId within the Journey System (e.g. cookie).</value>
    public string IdType { get; set; }
}
