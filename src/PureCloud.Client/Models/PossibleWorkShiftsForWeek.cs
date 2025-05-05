using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PossibleWorkShiftsForWeek
/// </summary>

public partial class PossibleWorkShiftsForWeek : IEquatable<PossibleWorkShiftsForWeek>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PossibleWorkShiftsForWeek" /> class.
    /// </summary>
    /// <param name="Id">ID of this possible weekly shift.</param>
    /// <param name="DailyPossibleShifts">Daily shifts in this possible weekly shift.</param>
    public PossibleWorkShiftsForWeek(int? Id = null, List<DailyPossibleShift> DailyPossibleShifts = null)
    {
        this.Id = Id;
        this.DailyPossibleShifts = DailyPossibleShifts;

    }



    /// <summary>
    /// ID of this possible weekly shift
    /// </summary>
    /// <value>ID of this possible weekly shift</value>
    [JsonPropertyName("id")]
    public int? Id { get; set; }



    /// <summary>
    /// Daily shifts in this possible weekly shift
    /// </summary>
    /// <value>Daily shifts in this possible weekly shift</value>
    [JsonPropertyName("dailyPossibleShifts")]
    public List<DailyPossibleShift> DailyPossibleShifts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PossibleWorkShiftsForWeek {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DailyPossibleShifts: ").Append(DailyPossibleShifts).Append("\n");
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
        return Equals(obj as PossibleWorkShiftsForWeek);
    }

    /// <summary>
    /// Returns true if PossibleWorkShiftsForWeek instances are equal
    /// </summary>
    /// <param name="other">Instance of PossibleWorkShiftsForWeek to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PossibleWorkShiftsForWeek other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                DailyPossibleShifts == other.DailyPossibleShifts ||
                DailyPossibleShifts != null &&
                DailyPossibleShifts.SequenceEqual(other.DailyPossibleShifts)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (DailyPossibleShifts != null)
            {
                hash = hash * 59 + DailyPossibleShifts.GetHashCode();
            }

            return hash;
        }
    }
}
