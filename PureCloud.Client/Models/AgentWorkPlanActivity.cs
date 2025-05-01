using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlanActivity
/// </summary>
[DataContract]
public partial class AgentWorkPlanActivity : IEquatable<AgentWorkPlanActivity>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanActivity" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlanActivity() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanActivity" /> class.
    /// </summary>
    /// <param name="LengthMinutes">Length of the activity in minutes (required).</param>
    /// <param name="CountsAsPaidTime">Whether the activity is paid (required).</param>
    public AgentWorkPlanActivity(int? LengthMinutes = null, bool? CountsAsPaidTime = null)
    {
        this.LengthMinutes = LengthMinutes;
        this.CountsAsPaidTime = CountsAsPaidTime;

    }



    /// <summary>
    /// Length of the activity in minutes
    /// </summary>
    /// <value>Length of the activity in minutes</value>
    [DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// Whether the activity is paid
    /// </summary>
    /// <value>Whether the activity is paid</value>
    [DataMember(Name = "countsAsPaidTime", EmitDefaultValue = false)]
    public bool? CountsAsPaidTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentWorkPlanActivity {\n");

        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
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
        return Equals(obj as AgentWorkPlanActivity);
    }

    /// <summary>
    /// Returns true if AgentWorkPlanActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlanActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlanActivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                CountsAsPaidTime == other.CountsAsPaidTime ||
                CountsAsPaidTime != null &&
                CountsAsPaidTime.Equals(other.CountsAsPaidTime)
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
            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            return hash;
        }
    }
}
