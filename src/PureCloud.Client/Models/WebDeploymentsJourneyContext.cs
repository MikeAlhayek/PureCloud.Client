namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsJourneyContext
/// </summary>
public sealed class WebDeploymentsJourneyContext
{
    /// <summary>
    /// A subset of the Journey System's action data relevant to a part of a conversation (for external linkage and internal usage/context)
    /// </summary>
    /// <value>A subset of the Journey System's action data relevant to a part of a conversation (for external linkage and internal usage/context)</value>
    public JourneyAction JourneyAction { get; set; }

    /// <summary>
    /// Journey customer information. Used for linking the authenticated customer with the journey. 
    /// </summary>
    /// <value>Journey customer information. Used for linking the authenticated customer with the journey. </value>
    public JourneyCustomer Customer { get; set; }

    /// <summary>
    /// Contains the Journey System's customer session details.
    /// </summary>
    /// <value>Contains the Journey System's customer session details.</value>
    public JourneyCustomerSession CustomerSession { get; set; }
}
