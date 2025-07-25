using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GDPRJourneyCustomer
{
    /// <summary>
    /// The type of the customerId within the Journey System (e.g. cookie). Required if &#x60;id&#x60; is defined.
    /// </summary>
    /// <value>The type of the customerId within the Journey System (e.g. cookie). Required if &#x60;id&#x60; is defined.</value>
    public string Type { get; set; }

    /// <summary>
    /// An ID of a customer within the Journey System at a point-in-time. Required if &#x60;type&#x60; is defined.
    /// </summary>
    /// <value>An ID of a customer within the Journey System at a point-in-time. Required if &#x60;type&#x60; is defined.</value>
    public string Id { get; set; }
}
