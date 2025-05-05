using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A subset of the Journey System&#39;s tracked customer session data at a point-in-time (for external linkage and internal usage/context)
/// </summary>

public partial class ConversationVideoEventTopicJourneyCustomerSession : IEquatable<ConversationVideoEventTopicJourneyCustomerSession>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationVideoEventTopicJourneyCustomerSession" /> class.
    /// </summary>
    /// <param name="Id">An ID of a Customer/User&#39;s session within the Journey System at a point-in-time.</param>
    /// <param name="Type">The type of the Customer/User&#39;s session within the Journey System (e.g. web, app).</param>
    public ConversationVideoEventTopicJourneyCustomerSession(string Id = null, string Type = null)
    {
        this.Id = Id;
        this.Type = Type;

    }



    /// <summary>
    /// An ID of a Customer/User&#39;s session within the Journey System at a point-in-time
    /// </summary>
    /// <value>An ID of a Customer/User&#39;s session within the Journey System at a point-in-time</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The type of the Customer/User&#39;s session within the Journey System (e.g. web, app)
    /// </summary>
    /// <value>The type of the Customer/User&#39;s session within the Journey System (e.g. web, app)</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationVideoEventTopicJourneyCustomerSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as ConversationVideoEventTopicJourneyCustomerSession);
    }

    /// <summary>
    /// Returns true if ConversationVideoEventTopicJourneyCustomerSession instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationVideoEventTopicJourneyCustomerSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationVideoEventTopicJourneyCustomerSession other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
