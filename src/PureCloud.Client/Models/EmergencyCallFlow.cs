using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An emergency flow associates a call flow to use in an emergency with the ivr(s) to route to it.
/// </summary>

public partial class EmergencyCallFlow : IEquatable<EmergencyCallFlow>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmergencyCallFlow" /> class.
    /// </summary>
    /// <param name="EmergencyFlow">The call flow to execute in an emergency..</param>
    /// <param name="Ivrs">The IVR(s) to route to the call flow during an emergency..</param>
    public EmergencyCallFlow(DomainEntityRef EmergencyFlow = null, List<DomainEntityRef> Ivrs = null)
    {
        this.EmergencyFlow = EmergencyFlow;
        this.Ivrs = Ivrs;

    }



    /// <summary>
    /// The call flow to execute in an emergency.
    /// </summary>
    /// <value>The call flow to execute in an emergency.</value>
    [JsonPropertyName("emergencyFlow")]
    public DomainEntityRef EmergencyFlow { get; set; }



    /// <summary>
    /// The IVR(s) to route to the call flow during an emergency.
    /// </summary>
    /// <value>The IVR(s) to route to the call flow during an emergency.</value>
    [JsonPropertyName("ivrs")]
    public List<DomainEntityRef> Ivrs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmergencyCallFlow {\n");

        sb.Append("  EmergencyFlow: ").Append(EmergencyFlow).Append("\n");
        sb.Append("  Ivrs: ").Append(Ivrs).Append("\n");
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
        return Equals(obj as EmergencyCallFlow);
    }

    /// <summary>
    /// Returns true if EmergencyCallFlow instances are equal
    /// </summary>
    /// <param name="other">Instance of EmergencyCallFlow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmergencyCallFlow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EmergencyFlow == other.EmergencyFlow ||
                EmergencyFlow != null &&
                EmergencyFlow.Equals(other.EmergencyFlow)
            ) &&
            (
                Ivrs == other.Ivrs ||
                Ivrs != null &&
                Ivrs.SequenceEqual(other.Ivrs)
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
            if (EmergencyFlow != null)
            {
                hash = hash * 59 + EmergencyFlow.GetHashCode();
            }

            if (Ivrs != null)
            {
                hash = hash * 59 + Ivrs.GetHashCode();
            }

            return hash;
        }
    }
}
