using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InitiatingAlternativeShift
/// </summary>

public partial class InitiatingAlternativeShift : IEquatable<InitiatingAlternativeShift>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="InitiatingAlternativeShift" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InitiatingAlternativeShift() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InitiatingAlternativeShift" /> class.
    /// </summary>
    /// <param name="Id">The ID of the shift from a user&#39;s schedule (required).</param>
    /// <param name="StartDate">The start date for the shift in the user&#39;s schedule in ISO-8601 format. For example: YYYY-MM-DDThh:mm:ss.SSSZ (required).</param>
    public InitiatingAlternativeShift(string Id = null, DateTime? StartDate = null)
    {
        this.Id = Id;
        this.StartDate = StartDate;

    }



    /// <summary>
    /// The ID of the shift from a user&#39;s schedule
    /// </summary>
    /// <value>The ID of the shift from a user&#39;s schedule</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The start date for the shift in the user&#39;s schedule in ISO-8601 format. For example: YYYY-MM-DDThh:mm:ss.SSSZ
    /// </summary>
    /// <value>The start date for the shift in the user&#39;s schedule in ISO-8601 format. For example: YYYY-MM-DDThh:mm:ss.SSSZ</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InitiatingAlternativeShift {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
        return Equals(obj as InitiatingAlternativeShift);
    }

    /// <summary>
    /// Returns true if InitiatingAlternativeShift instances are equal
    /// </summary>
    /// <param name="other">Instance of InitiatingAlternativeShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InitiatingAlternativeShift other)
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
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
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

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            return hash;
        }
    }
}
