using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DeleteRetention
/// </summary>

public partial class DeleteRetention : IEquatable<DeleteRetention>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteRetention" /> class.
    /// </summary>
    /// <param name="Days">Days.</param>
    public DeleteRetention(int? Days = null)
    {
        this.Days = Days;

    }



    /// <summary>
    /// Gets or Sets Days
    /// </summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DeleteRetention {\n");

        sb.Append("  Days: ").Append(Days).Append("\n");
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
        return Equals(obj as DeleteRetention);
    }

    /// <summary>
    /// Returns true if DeleteRetention instances are equal
    /// </summary>
    /// <param name="other">Instance of DeleteRetention to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DeleteRetention other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Days == other.Days ||
                Days != null &&
                Days.Equals(other.Days)
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
            if (Days != null)
            {
                hash = hash * 59 + Days.GetHashCode();
            }

            return hash;
        }
    }
}
