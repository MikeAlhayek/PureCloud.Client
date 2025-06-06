using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidateWorkPlanMessages
/// </summary>

public partial class ValidateWorkPlanMessages : IEquatable<ValidateWorkPlanMessages>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidateWorkPlanMessages" /> class.
    /// </summary>
    /// <param name="ViolationMessages">Messages for work plan violating some rules such as no shifts in a work plan.</param>
    /// <param name="ConstraintConflictMessage">This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated.</param>
    public ValidateWorkPlanMessages(List<WorkPlanConfigurationViolationMessage> ViolationMessages = null, ConstraintConflictMessage ConstraintConflictMessage = null)
    {
        this.ViolationMessages = ViolationMessages;
        this.ConstraintConflictMessage = ConstraintConflictMessage;

    }



    /// <summary>
    /// Messages for work plan violating some rules such as no shifts in a work plan
    /// </summary>
    /// <value>Messages for work plan violating some rules such as no shifts in a work plan</value>
    [JsonPropertyName("violationMessages")]
    public List<WorkPlanConfigurationViolationMessage> ViolationMessages { get; set; }



    /// <summary>
    /// This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated
    /// </summary>
    /// <value>This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated</value>
    [JsonPropertyName("constraintConflictMessage")]
    public ConstraintConflictMessage ConstraintConflictMessage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidateWorkPlanMessages {\n");

        sb.Append("  ViolationMessages: ").Append(ViolationMessages).Append("\n");
        sb.Append("  ConstraintConflictMessage: ").Append(ConstraintConflictMessage).Append("\n");
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
        return Equals(obj as ValidateWorkPlanMessages);
    }

    /// <summary>
    /// Returns true if ValidateWorkPlanMessages instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidateWorkPlanMessages to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidateWorkPlanMessages other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ViolationMessages == other.ViolationMessages ||
                ViolationMessages != null &&
                ViolationMessages.SequenceEqual(other.ViolationMessages)
            ) &&
            (
                ConstraintConflictMessage == other.ConstraintConflictMessage ||
                ConstraintConflictMessage != null &&
                ConstraintConflictMessage.Equals(other.ConstraintConflictMessage)
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
            if (ViolationMessages != null)
            {
                hash = hash * 59 + ViolationMessages.GetHashCode();
            }

            if (ConstraintConflictMessage != null)
            {
                hash = hash * 59 + ConstraintConflictMessage.GetHashCode();
            }

            return hash;
        }
    }
}
