using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AddWorkPlanRotationAgentRequest
/// </summary>

public partial class AddWorkPlanRotationAgentRequest : IEquatable<AddWorkPlanRotationAgentRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AddWorkPlanRotationAgentRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddWorkPlanRotationAgentRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AddWorkPlanRotationAgentRequest" /> class.
    /// </summary>
    /// <param name="UserId">The ID of an agent in this work plan rotation (required).</param>
    /// <param name="DateRange">The date range to which this agent is effective in the work plan rotation (required).</param>
    /// <param name="Position">Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0 (required).</param>
    public AddWorkPlanRotationAgentRequest(string UserId = null, DateRangeWithOptionalEnd DateRange = null, int? Position = null)
    {
        this.UserId = UserId;
        this.DateRange = DateRange;
        this.Position = Position;

    }



    /// <summary>
    /// The ID of an agent in this work plan rotation
    /// </summary>
    /// <value>The ID of an agent in this work plan rotation</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



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
        sb.Append("class AddWorkPlanRotationAgentRequest {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return Equals(obj as AddWorkPlanRotationAgentRequest);
    }

    /// <summary>
    /// Returns true if AddWorkPlanRotationAgentRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AddWorkPlanRotationAgentRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AddWorkPlanRotationAgentRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
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
