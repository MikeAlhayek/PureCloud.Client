using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Snapshots
/// </summary>

public partial class Snapshots : IEquatable<Snapshots>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Snapshots" /> class.
    /// </summary>
    /// <param name="Id">The snapshot Id.</param>
    /// <param name="DaysInPast">The number of days from today denoting when the snapshot was captured.</param>
    public Snapshots(string Id = null, int? DaysInPast = null)
    {
        this.Id = Id;
        this.DaysInPast = DaysInPast;

    }



    /// <summary>
    /// The snapshot Id
    /// </summary>
    /// <value>The snapshot Id</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The number of days from today denoting when the snapshot was captured
    /// </summary>
    /// <value>The number of days from today denoting when the snapshot was captured</value>
    [JsonPropertyName("daysInPast")]
    public int? DaysInPast { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Snapshots {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DaysInPast: ").Append(DaysInPast).Append("\n");
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
        return Equals(obj as Snapshots);
    }

    /// <summary>
    /// Returns true if Snapshots instances are equal
    /// </summary>
    /// <param name="other">Instance of Snapshots to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Snapshots other)
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
                DaysInPast == other.DaysInPast ||
                DaysInPast != null &&
                DaysInPast.Equals(other.DaysInPast)
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

            if (DaysInPast != null)
            {
                hash = hash * 59 + DaysInPast.GetHashCode();
            }

            return hash;
        }
    }
}
