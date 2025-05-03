using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutOfOfficeEventOutOfOffice
/// </summary>

public partial class OutOfOfficeEventOutOfOffice : IEquatable<OutOfOfficeEventOutOfOffice>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutOfOfficeEventOutOfOffice" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="Active">Active.</param>
    /// <param name="Indefinite">Indefinite.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="EndDate">EndDate.</param>
    public OutOfOfficeEventOutOfOffice(OutOfOfficeEventUser User = null, bool? Active = null, bool? Indefinite = null, DateTime? StartDate = null, DateTime? EndDate = null)
    {
        this.User = User;
        this.Active = Active;
        this.Indefinite = Indefinite;
        this.StartDate = StartDate;
        this.EndDate = EndDate;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public OutOfOfficeEventUser User { get; set; }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



    /// <summary>
    /// Gets or Sets Indefinite
    /// </summary>
    [JsonPropertyName("indefinite")]
    public bool? Indefinite { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutOfOfficeEventOutOfOffice {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  Indefinite: ").Append(Indefinite).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
        return Equals(obj as OutOfOfficeEventOutOfOffice);
    }

    /// <summary>
    /// Returns true if OutOfOfficeEventOutOfOffice instances are equal
    /// </summary>
    /// <param name="other">Instance of OutOfOfficeEventOutOfOffice to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutOfOfficeEventOutOfOffice other)
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
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                Indefinite == other.Indefinite ||
                Indefinite != null &&
                Indefinite.Equals(other.Indefinite)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
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

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (Indefinite != null)
            {
                hash = hash * 59 + Indefinite.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            return hash;
        }
    }
}
