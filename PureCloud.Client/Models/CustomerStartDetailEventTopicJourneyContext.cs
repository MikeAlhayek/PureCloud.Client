using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CustomerStartDetailEventTopicJourneyContext
/// </summary>
[DataContract]
public partial class CustomerStartDetailEventTopicJourneyContext : IEquatable<CustomerStartDetailEventTopicJourneyContext>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerStartDetailEventTopicJourneyContext" /> class.
    /// </summary>
    /// <param name="SessionId">SessionId.</param>
    /// <param name="SessionIdType">SessionIdType.</param>
    /// <param name="ActionId">ActionId.</param>
    /// <param name="ActionMapId">ActionMapId.</param>
    public CustomerStartDetailEventTopicJourneyContext(string SessionId = null, string SessionIdType = null, string ActionId = null, string ActionMapId = null)
    {
        this.SessionId = SessionId;
        this.SessionIdType = SessionIdType;
        this.ActionId = ActionId;
        this.ActionMapId = ActionMapId;

    }



    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Gets or Sets SessionIdType
    /// </summary>
    [DataMember(Name = "sessionIdType", EmitDefaultValue = false)]
    public string SessionIdType { get; set; }



    /// <summary>
    /// Gets or Sets ActionId
    /// </summary>
    [DataMember(Name = "actionId", EmitDefaultValue = false)]
    public string ActionId { get; set; }



    /// <summary>
    /// Gets or Sets ActionMapId
    /// </summary>
    [DataMember(Name = "actionMapId", EmitDefaultValue = false)]
    public string ActionMapId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CustomerStartDetailEventTopicJourneyContext {\n");

        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  SessionIdType: ").Append(SessionIdType).Append("\n");
        sb.Append("  ActionId: ").Append(ActionId).Append("\n");
        sb.Append("  ActionMapId: ").Append(ActionMapId).Append("\n");
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
        return Equals(obj as CustomerStartDetailEventTopicJourneyContext);
    }

    /// <summary>
    /// Returns true if CustomerStartDetailEventTopicJourneyContext instances are equal
    /// </summary>
    /// <param name="other">Instance of CustomerStartDetailEventTopicJourneyContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CustomerStartDetailEventTopicJourneyContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                SessionIdType == other.SessionIdType ||
                SessionIdType != null &&
                SessionIdType.Equals(other.SessionIdType)
            ) &&
            (
                ActionId == other.ActionId ||
                ActionId != null &&
                ActionId.Equals(other.ActionId)
            ) &&
            (
                ActionMapId == other.ActionMapId ||
                ActionMapId != null &&
                ActionMapId.Equals(other.ActionMapId)
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
            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (SessionIdType != null)
            {
                hash = hash * 59 + SessionIdType.GetHashCode();
            }

            if (ActionId != null)
            {
                hash = hash * 59 + ActionId.GetHashCode();
            }

            if (ActionMapId != null)
            {
                hash = hash * 59 + ActionMapId.GetHashCode();
            }

            return hash;
        }
    }
}
