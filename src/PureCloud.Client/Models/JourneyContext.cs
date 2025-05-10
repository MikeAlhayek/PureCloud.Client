namespace PureCloud.Client.Models;

public sealed class JourneyContext
{
    /// <summary>
    /// A subset of the Journey System&#39;s customer data at a point-in-time (for external linkage and internal usage/context)
    /// </summary>
    /// <value>A subset of the Journey System&#39;s customer data at a point-in-time (for external linkage and internal usage/context)</value>
    public JourneyCustomer Customer { get; set; }

    /// <summary>
    /// A subset of the Journey System&#39;s tracked customer session data at a point-in-time (for external linkage and internal usage/context)
    /// </summary>
    /// <value>A subset of the Journey System&#39;s tracked customer session data at a point-in-time (for external linkage and internal usage/context)</value>
    public JourneyCustomerSession CustomerSession { get; set; }

    /// <summary>
    /// A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)
    /// </summary>
    /// <value>A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)</value>
    public JourneyAction TriggeringAction { get; set; }
}
