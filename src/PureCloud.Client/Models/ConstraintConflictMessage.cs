using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConstraintConflictMessage
/// </summary>

public partial class ConstraintConflictMessage : IEquatable<ConstraintConflictMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConstraintConflictMessage" /> class.
    /// </summary>
    /// <param name="Message">Message for how to resolve a set of conflicted work plan constraints.</param>
    /// <param name="ConflictedConstraintMessages">Messages for the set of conflicted work plan constraints. Each element indicates the message of a work plan constraint that is conflicted in the set.</param>
    public ConstraintConflictMessage(WorkPlanConstraintConflictMessage Message = null, List<WorkPlanConstraintMessage> ConflictedConstraintMessages = null)
    {
        this.Message = Message;
        this.ConflictedConstraintMessages = ConflictedConstraintMessages;

    }



    /// <summary>
    /// Message for how to resolve a set of conflicted work plan constraints
    /// </summary>
    /// <value>Message for how to resolve a set of conflicted work plan constraints</value>
    [JsonPropertyName("message")]
    public WorkPlanConstraintConflictMessage Message { get; set; }



    /// <summary>
    /// Messages for the set of conflicted work plan constraints. Each element indicates the message of a work plan constraint that is conflicted in the set
    /// </summary>
    /// <value>Messages for the set of conflicted work plan constraints. Each element indicates the message of a work plan constraint that is conflicted in the set</value>
    [JsonPropertyName("conflictedConstraintMessages")]
    public List<WorkPlanConstraintMessage> ConflictedConstraintMessages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConstraintConflictMessage {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ConflictedConstraintMessages: ").Append(ConflictedConstraintMessages).Append("\n");
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
        return Equals(obj as ConstraintConflictMessage);
    }

    /// <summary>
    /// Returns true if ConstraintConflictMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of ConstraintConflictMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConstraintConflictMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                ConflictedConstraintMessages == other.ConflictedConstraintMessages ||
                ConflictedConstraintMessages != null &&
                ConflictedConstraintMessages.SequenceEqual(other.ConflictedConstraintMessages)
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
            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (ConflictedConstraintMessages != null)
            {
                hash = hash * 59 + ConflictedConstraintMessages.GetHashCode();
            }

            return hash;
        }
    }
}
