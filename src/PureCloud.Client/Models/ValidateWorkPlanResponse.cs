using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidateWorkPlanResponse
/// </summary>

public partial class ValidateWorkPlanResponse : IEquatable<ValidateWorkPlanResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidateWorkPlanResponse" /> class.
    /// </summary>
    /// <param name="WorkPlan">The work plan reference associated with this response.</param>
    /// <param name="Valid">Whether the work plan is valid or not.</param>
    /// <param name="Messages">Validation messages for this work plan.</param>
    public ValidateWorkPlanResponse(WorkPlanReference WorkPlan = null, bool? Valid = null, ValidateWorkPlanMessages Messages = null)
    {
        this.WorkPlan = WorkPlan;
        this.Valid = Valid;
        this.Messages = Messages;

    }



    /// <summary>
    /// The work plan reference associated with this response
    /// </summary>
    /// <value>The work plan reference associated with this response</value>
    [JsonPropertyName("workPlan")]
    public WorkPlanReference WorkPlan { get; set; }



    /// <summary>
    /// Whether the work plan is valid or not
    /// </summary>
    /// <value>Whether the work plan is valid or not</value>
    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }



    /// <summary>
    /// Validation messages for this work plan
    /// </summary>
    /// <value>Validation messages for this work plan</value>
    [JsonPropertyName("messages")]
    public ValidateWorkPlanMessages Messages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidateWorkPlanResponse {\n");

        sb.Append("  WorkPlan: ").Append(WorkPlan).Append("\n");
        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
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
        return Equals(obj as ValidateWorkPlanResponse);
    }

    /// <summary>
    /// Returns true if ValidateWorkPlanResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidateWorkPlanResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidateWorkPlanResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WorkPlan == other.WorkPlan ||
                WorkPlan != null &&
                WorkPlan.Equals(other.WorkPlan)
            ) &&
            (
                Valid == other.Valid ||
                Valid != null &&
                Valid.Equals(other.Valid)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.Equals(other.Messages)
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
            if (WorkPlan != null)
            {
                hash = hash * 59 + WorkPlan.GetHashCode();
            }

            if (Valid != null)
            {
                hash = hash * 59 + Valid.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            return hash;
        }
    }
}
