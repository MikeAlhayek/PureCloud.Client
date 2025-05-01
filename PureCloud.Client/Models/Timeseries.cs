using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Timeseries
/// </summary>
[DataContract]
public partial class Timeseries : IEquatable<Timeseries>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Timeseries" /> class.
    /// </summary>
    /// <param name="PlanningGroup">The planning group ID.</param>
    /// <param name="Weeks">List of data for each week.</param>
    public Timeseries(string PlanningGroup = null, List<Weeks> Weeks = null)
    {
        this.PlanningGroup = PlanningGroup;
        this.Weeks = Weeks;

    }



    /// <summary>
    /// The planning group ID
    /// </summary>
    /// <value>The planning group ID</value>
    [DataMember(Name = "planningGroup", EmitDefaultValue = false)]
    public string PlanningGroup { get; set; }



    /// <summary>
    /// List of data for each week
    /// </summary>
    /// <value>List of data for each week</value>
    [DataMember(Name = "weeks", EmitDefaultValue = false)]
    public List<Weeks> Weeks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Timeseries {\n");

        sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
        sb.Append("  Weeks: ").Append(Weeks).Append("\n");
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
        return Equals(obj as Timeseries);
    }

    /// <summary>
    /// Returns true if Timeseries instances are equal
    /// </summary>
    /// <param name="other">Instance of Timeseries to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Timeseries other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroup == other.PlanningGroup ||
                PlanningGroup != null &&
                PlanningGroup.Equals(other.PlanningGroup)
            ) &&
            (
                Weeks == other.Weeks ||
                Weeks != null &&
                Weeks.SequenceEqual(other.Weeks)
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
            if (PlanningGroup != null)
            {
                hash = hash * 59 + PlanningGroup.GetHashCode();
            }

            if (Weeks != null)
            {
                hash = hash * 59 + Weeks.GetHashCode();
            }

            return hash;
        }
    }
}
