using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AddWorkPlanRotationRequest
/// </summary>

public partial class AddWorkPlanRotationRequest : IEquatable<AddWorkPlanRotationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AddWorkPlanRotationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddWorkPlanRotationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AddWorkPlanRotationRequest" /> class.
    /// </summary>
    /// <param name="Name">Name of this work plan rotation (required).</param>
    /// <param name="DateRange">The date range to which this work plan rotation applies (required).</param>
    /// <param name="Agents">Agents in this work plan rotation.</param>
    /// <param name="Pattern">Pattern with list of work plan IDs that rotate on a weekly basis (required).</param>
    public AddWorkPlanRotationRequest(string Name = null, DateRangeWithOptionalEnd DateRange = null, List<AddWorkPlanRotationAgentRequest> Agents = null, WorkPlanPatternRequest Pattern = null)
    {
        this.Name = Name;
        this.DateRange = DateRange;
        this.Agents = Agents;
        this.Pattern = Pattern;

    }



    /// <summary>
    /// Name of this work plan rotation
    /// </summary>
    /// <value>Name of this work plan rotation</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The date range to which this work plan rotation applies
    /// </summary>
    /// <value>The date range to which this work plan rotation applies</value>
    [JsonPropertyName("dateRange")]
    public DateRangeWithOptionalEnd DateRange { get; set; }



    /// <summary>
    /// Agents in this work plan rotation
    /// </summary>
    /// <value>Agents in this work plan rotation</value>
    [JsonPropertyName("agents")]
    public List<AddWorkPlanRotationAgentRequest> Agents { get; set; }



    /// <summary>
    /// Pattern with list of work plan IDs that rotate on a weekly basis
    /// </summary>
    /// <value>Pattern with list of work plan IDs that rotate on a weekly basis</value>
    [JsonPropertyName("pattern")]
    public WorkPlanPatternRequest Pattern { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddWorkPlanRotationRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateRange: ").Append(DateRange).Append("\n");
        sb.Append("  Agents: ").Append(Agents).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
        return Equals(obj as AddWorkPlanRotationRequest);
    }

    /// <summary>
    /// Returns true if AddWorkPlanRotationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AddWorkPlanRotationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AddWorkPlanRotationRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DateRange == other.DateRange ||
                DateRange != null &&
                DateRange.Equals(other.DateRange)
            ) &&
            (
                Agents == other.Agents ||
                Agents != null &&
                Agents.SequenceEqual(other.Agents)
            ) &&
            (
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateRange != null)
            {
                hash = hash * 59 + DateRange.GetHashCode();
            }

            if (Agents != null)
            {
                hash = hash * 59 + Agents.GetHashCode();
            }

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            return hash;
        }
    }
}
