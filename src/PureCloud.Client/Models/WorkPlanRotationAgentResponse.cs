using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanRotationAgentResponse
/// </summary>

public partial class WorkPlanRotationAgentResponse : IEquatable<WorkPlanRotationAgentResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanRotationAgentResponse" /> class.
    /// </summary>
    /// <param name="User">The user associated with this work plan rotation.</param>
    /// <param name="DateRange">The date range to which this agent is effective in the work plan rotation.</param>
    /// <param name="Position">Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0.</param>
    public WorkPlanRotationAgentResponse(UserReference User = null, DateRangeWithOptionalEnd DateRange = null, int? Position = null)
    {
        this.User = User;
        this.DateRange = DateRange;
        this.Position = Position;

    }



    /// <summary>
    /// The user associated with this work plan rotation
    /// </summary>
    /// <value>The user associated with this work plan rotation</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The date range to which this agent is effective in the work plan rotation
    /// </summary>
    /// <value>The date range to which this agent is effective in the work plan rotation</value>
    [JsonPropertyName("dateRange")]
    public DateRangeWithOptionalEnd DateRange { get; set; }



    /// <summary>
    /// Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0
    /// </summary>
    /// <value>Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0</value>
    [JsonPropertyName("position")]
    public int? Position { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanRotationAgentResponse {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  DateRange: ").Append(DateRange).Append("\n");
        sb.Append("  Position: ").Append(Position).Append("\n");
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
        return Equals(obj as WorkPlanRotationAgentResponse);
    }

    /// <summary>
    /// Returns true if WorkPlanRotationAgentResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanRotationAgentResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanRotationAgentResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                DateRange == other.DateRange ||
                DateRange != null &&
                DateRange.Equals(other.DateRange)
            ) &&
            (
                Position == other.Position ||
                Position != null &&
                Position.Equals(other.Position)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (DateRange != null)
            {
                hash = hash * 59 + DateRange.GetHashCode();
            }

            if (Position != null)
            {
                hash = hash * 59 + Position.GetHashCode();
            }

            return hash;
        }
    }
}
