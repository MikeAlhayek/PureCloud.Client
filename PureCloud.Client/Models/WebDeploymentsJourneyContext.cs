using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsJourneyContext
/// </summary>

public partial class WebDeploymentsJourneyContext : IEquatable<WebDeploymentsJourneyContext>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsJourneyContext" /> class.
    /// </summary>
    /// <param name="JourneyAction">A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context).</param>
    /// <param name="Customer">Journey customer information. Used for linking the authenticated customer with the journey. .</param>
    /// <param name="CustomerSession">Contains the Journey System&#39;s customer session details..</param>
    public WebDeploymentsJourneyContext(JourneyAction JourneyAction = null, JourneyCustomer Customer = null, JourneyCustomerSession CustomerSession = null)
    {
        this.JourneyAction = JourneyAction;
        this.Customer = Customer;
        this.CustomerSession = CustomerSession;

    }



    /// <summary>
    /// A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)
    /// </summary>
    /// <value>A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)</value>
    [JsonPropertyName("journeyAction")]
    public JourneyAction JourneyAction { get; set; }



    /// <summary>
    /// Journey customer information. Used for linking the authenticated customer with the journey. 
    /// </summary>
    /// <value>Journey customer information. Used for linking the authenticated customer with the journey. </value>
    [JsonPropertyName("customer")]
    public JourneyCustomer Customer { get; set; }



    /// <summary>
    /// Contains the Journey System&#39;s customer session details.
    /// </summary>
    /// <value>Contains the Journey System&#39;s customer session details.</value>
    [JsonPropertyName("customerSession")]
    public JourneyCustomerSession CustomerSession { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentsJourneyContext {\n");

        sb.Append("  JourneyAction: ").Append(JourneyAction).Append("\n");
        sb.Append("  Customer: ").Append(Customer).Append("\n");
        sb.Append("  CustomerSession: ").Append(CustomerSession).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as WebDeploymentsJourneyContext);
    }

    /// <summary>
    /// Returns true if WebDeploymentsJourneyContext instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentsJourneyContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentsJourneyContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                JourneyAction == other.JourneyAction ||
                JourneyAction != null &&
                JourneyAction.Equals(other.JourneyAction)
            ) &&
            (
                Customer == other.Customer ||
                Customer != null &&
                Customer.Equals(other.Customer)
            ) &&
            (
                CustomerSession == other.CustomerSession ||
                CustomerSession != null &&
                CustomerSession.Equals(other.CustomerSession)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (JourneyAction != null)
            {
                hash = hash * 59 + JourneyAction.GetHashCode();
            }

            if (Customer != null)
            {
                hash = hash * 59 + Customer.GetHashCode();
            }

            if (CustomerSession != null)
            {
                hash = hash * 59 + CustomerSession.GetHashCode();
            }

            return hash;
        }
    }
}
