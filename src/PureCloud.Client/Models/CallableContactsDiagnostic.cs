using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallableContactsDiagnostic
/// </summary>

public partial class CallableContactsDiagnostic : IEquatable<CallableContactsDiagnostic>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallableContactsDiagnostic" /> class.
    /// </summary>
    public CallableContactsDiagnostic()
    {

    }



    /// <summary>
    /// Attempt limits for the campaign&#39;s contact list
    /// </summary>
    /// <value>Attempt limits for the campaign&#39;s contact list</value>
    [JsonPropertyName("attemptLimits")]
    public DomainEntityRef AttemptLimits { get; set; }



    /// <summary>
    /// Do not call lists for the campaign
    /// </summary>
    /// <value>Do not call lists for the campaign</value>
    [JsonPropertyName("dncLists")]
    public List<DomainEntityRef> DncLists { get; set; }



    /// <summary>
    /// Callable time sets for the campaign
    /// </summary>
    /// <value>Callable time sets for the campaign</value>
    [JsonPropertyName("callableTimeSet")]
    public DomainEntityRef CallableTimeSet { get; set; }



    /// <summary>
    /// Rule sets for the campaign
    /// </summary>
    /// <value>Rule sets for the campaign</value>
    [JsonPropertyName("ruleSets")]
    public List<DomainEntityRef> RuleSets { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallableContactsDiagnostic {\n");

        sb.Append("  AttemptLimits: ").Append(AttemptLimits).Append("\n");
        sb.Append("  DncLists: ").Append(DncLists).Append("\n");
        sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
        sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
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
        return Equals(obj as CallableContactsDiagnostic);
    }

    /// <summary>
    /// Returns true if CallableContactsDiagnostic instances are equal
    /// </summary>
    /// <param name="other">Instance of CallableContactsDiagnostic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallableContactsDiagnostic other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AttemptLimits == other.AttemptLimits ||
                AttemptLimits != null &&
                AttemptLimits.Equals(other.AttemptLimits)
            ) &&
            (
                DncLists == other.DncLists ||
                DncLists != null &&
                DncLists.SequenceEqual(other.DncLists)
            ) &&
            (
                CallableTimeSet == other.CallableTimeSet ||
                CallableTimeSet != null &&
                CallableTimeSet.Equals(other.CallableTimeSet)
            ) &&
            (
                RuleSets == other.RuleSets ||
                RuleSets != null &&
                RuleSets.SequenceEqual(other.RuleSets)
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
            if (AttemptLimits != null)
            {
                hash = hash * 59 + AttemptLimits.GetHashCode();
            }

            if (DncLists != null)
            {
                hash = hash * 59 + DncLists.GetHashCode();
            }

            if (CallableTimeSet != null)
            {
                hash = hash * 59 + CallableTimeSet.GetHashCode();
            }

            if (RuleSets != null)
            {
                hash = hash * 59 + RuleSets.GetHashCode();
            }

            return hash;
        }
    }
}
