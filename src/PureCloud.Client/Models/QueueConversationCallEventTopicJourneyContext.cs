using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallEventTopicJourneyContext
/// </summary>

public partial class QueueConversationCallEventTopicJourneyContext : IEquatable<QueueConversationCallEventTopicJourneyContext>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallEventTopicJourneyContext" /> class.
    /// </summary>
    /// <param name="Customer">Customer.</param>
    /// <param name="CustomerSession">CustomerSession.</param>
    /// <param name="TriggeringAction">TriggeringAction.</param>
    public QueueConversationCallEventTopicJourneyContext(QueueConversationCallEventTopicJourneyCustomer Customer = null, QueueConversationCallEventTopicJourneyCustomerSession CustomerSession = null, QueueConversationCallEventTopicJourneyAction TriggeringAction = null)
    {
        this.Customer = Customer;
        this.CustomerSession = CustomerSession;
        this.TriggeringAction = TriggeringAction;

    }



    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [JsonPropertyName("customer")]
    public QueueConversationCallEventTopicJourneyCustomer Customer { get; set; }



    /// <summary>
    /// Gets or Sets CustomerSession
    /// </summary>
    [JsonPropertyName("customerSession")]
    public QueueConversationCallEventTopicJourneyCustomerSession CustomerSession { get; set; }



    /// <summary>
    /// Gets or Sets TriggeringAction
    /// </summary>
    [JsonPropertyName("triggeringAction")]
    public QueueConversationCallEventTopicJourneyAction TriggeringAction { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallEventTopicJourneyContext {\n");

        sb.Append("  Customer: ").Append(Customer).Append("\n");
        sb.Append("  CustomerSession: ").Append(CustomerSession).Append("\n");
        sb.Append("  TriggeringAction: ").Append(TriggeringAction).Append("\n");
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
        return Equals(obj as QueueConversationCallEventTopicJourneyContext);
    }

    /// <summary>
    /// Returns true if QueueConversationCallEventTopicJourneyContext instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallEventTopicJourneyContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallEventTopicJourneyContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Customer == other.Customer ||
                Customer != null &&
                Customer.Equals(other.Customer)
            ) &&
            (
                CustomerSession == other.CustomerSession ||
                CustomerSession != null &&
                CustomerSession.Equals(other.CustomerSession)
            ) &&
            (
                TriggeringAction == other.TriggeringAction ||
                TriggeringAction != null &&
                TriggeringAction.Equals(other.TriggeringAction)
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
            if (Customer != null)
            {
                hash = hash * 59 + Customer.GetHashCode();
            }

            if (CustomerSession != null)
            {
                hash = hash * 59 + CustomerSession.GetHashCode();
            }

            if (TriggeringAction != null)
            {
                hash = hash * 59 + TriggeringAction.GetHashCode();
            }

            return hash;
        }
    }
}
