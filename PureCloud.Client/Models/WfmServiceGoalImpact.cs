using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmServiceGoalImpact
/// </summary>
[DataContract]
public partial class WfmServiceGoalImpact : IEquatable<WfmServiceGoalImpact>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmServiceGoalImpact" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmServiceGoalImpact() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmServiceGoalImpact" /> class.
    /// </summary>
    /// <param name="IncreaseByPercent">The maximum allowed percent increase from the configured goal (required).</param>
    /// <param name="DecreaseByPercent">The maximum allowed percent decrease from the configured goal (required).</param>
    public WfmServiceGoalImpact(double? IncreaseByPercent = null, double? DecreaseByPercent = null)
    {
        this.IncreaseByPercent = IncreaseByPercent;
        this.DecreaseByPercent = DecreaseByPercent;

    }



    /// <summary>
    /// The maximum allowed percent increase from the configured goal
    /// </summary>
    /// <value>The maximum allowed percent increase from the configured goal</value>
    [DataMember(Name = "increaseByPercent", EmitDefaultValue = false)]
    public double? IncreaseByPercent { get; set; }



    /// <summary>
    /// The maximum allowed percent decrease from the configured goal
    /// </summary>
    /// <value>The maximum allowed percent decrease from the configured goal</value>
    [DataMember(Name = "decreaseByPercent", EmitDefaultValue = false)]
    public double? DecreaseByPercent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmServiceGoalImpact {\n");

        sb.Append("  IncreaseByPercent: ").Append(IncreaseByPercent).Append("\n");
        sb.Append("  DecreaseByPercent: ").Append(DecreaseByPercent).Append("\n");
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
        return Equals(obj as WfmServiceGoalImpact);
    }

    /// <summary>
    /// Returns true if WfmServiceGoalImpact instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmServiceGoalImpact to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmServiceGoalImpact other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IncreaseByPercent == other.IncreaseByPercent ||
                IncreaseByPercent != null &&
                IncreaseByPercent.Equals(other.IncreaseByPercent)
            ) &&
            (
                DecreaseByPercent == other.DecreaseByPercent ||
                DecreaseByPercent != null &&
                DecreaseByPercent.Equals(other.DecreaseByPercent)
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
            if (IncreaseByPercent != null)
            {
                hash = hash * 59 + IncreaseByPercent.GetHashCode();
            }

            if (DecreaseByPercent != null)
            {
                hash = hash * 59 + DecreaseByPercent.GetHashCode();
            }

            return hash;
        }
    }
}
