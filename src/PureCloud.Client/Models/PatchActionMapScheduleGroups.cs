using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchActionMapScheduleGroups
/// </summary>

public partial class PatchActionMapScheduleGroups : IEquatable<PatchActionMapScheduleGroups>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionMapScheduleGroups" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchActionMapScheduleGroups() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionMapScheduleGroups" /> class.
    /// </summary>
    /// <param name="ActionMapScheduleGroup">The actions map&#39;s associated schedule group. (required).</param>
    /// <param name="EmergencyActionMapScheduleGroup">The action map&#39;s associated emergency schedule group..</param>
    public PatchActionMapScheduleGroups(ActionMapScheduleGroup ActionMapScheduleGroup = null, ActionMapScheduleGroup EmergencyActionMapScheduleGroup = null)
    {
        this.ActionMapScheduleGroup = ActionMapScheduleGroup;
        this.EmergencyActionMapScheduleGroup = EmergencyActionMapScheduleGroup;

    }



    /// <summary>
    /// The actions map&#39;s associated schedule group.
    /// </summary>
    /// <value>The actions map&#39;s associated schedule group.</value>
    [JsonPropertyName("actionMapScheduleGroup")]
    public ActionMapScheduleGroup ActionMapScheduleGroup { get; set; }



    /// <summary>
    /// The action map&#39;s associated emergency schedule group.
    /// </summary>
    /// <value>The action map&#39;s associated emergency schedule group.</value>
    [JsonPropertyName("emergencyActionMapScheduleGroup")]
    public ActionMapScheduleGroup EmergencyActionMapScheduleGroup { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchActionMapScheduleGroups {\n");

        sb.Append("  ActionMapScheduleGroup: ").Append(ActionMapScheduleGroup).Append("\n");
        sb.Append("  EmergencyActionMapScheduleGroup: ").Append(EmergencyActionMapScheduleGroup).Append("\n");
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
        return Equals(obj as PatchActionMapScheduleGroups);
    }

    /// <summary>
    /// Returns true if PatchActionMapScheduleGroups instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchActionMapScheduleGroups to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchActionMapScheduleGroups other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActionMapScheduleGroup == other.ActionMapScheduleGroup ||
                ActionMapScheduleGroup != null &&
                ActionMapScheduleGroup.Equals(other.ActionMapScheduleGroup)
            ) &&
            (
                EmergencyActionMapScheduleGroup == other.EmergencyActionMapScheduleGroup ||
                EmergencyActionMapScheduleGroup != null &&
                EmergencyActionMapScheduleGroup.Equals(other.EmergencyActionMapScheduleGroup)
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
            if (ActionMapScheduleGroup != null)
            {
                hash = hash * 59 + ActionMapScheduleGroup.GetHashCode();
            }

            if (EmergencyActionMapScheduleGroup != null)
            {
                hash = hash * 59 + EmergencyActionMapScheduleGroup.GetHashCode();
            }

            return hash;
        }
    }
}
