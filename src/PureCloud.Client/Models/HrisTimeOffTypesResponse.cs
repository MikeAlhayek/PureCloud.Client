using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HrisTimeOffTypesResponse
/// </summary>

public partial class HrisTimeOffTypesResponse : IEquatable<HrisTimeOffTypesResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HrisTimeOffTypesResponse" /> class.
    /// </summary>
    /// <param name="Job">The asynchronous job handling the query.</param>
    /// <param name="Entities">List of time off types. It is available only via notification.</param>
    public HrisTimeOffTypesResponse(HrisTimeOffTypesJobReference Job = null, List<HrisTimeOffTypeResponse> Entities = null)
    {
        this.Job = Job;
        this.Entities = Entities;

    }



    /// <summary>
    /// The asynchronous job handling the query
    /// </summary>
    /// <value>The asynchronous job handling the query</value>
    [JsonPropertyName("job")]
    public HrisTimeOffTypesJobReference Job { get; set; }



    /// <summary>
    /// List of time off types. It is available only via notification
    /// </summary>
    /// <value>List of time off types. It is available only via notification</value>
    [JsonPropertyName("entities")]
    public List<HrisTimeOffTypeResponse> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HrisTimeOffTypesResponse {\n");

        sb.Append("  Job: ").Append(Job).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as HrisTimeOffTypesResponse);
    }

    /// <summary>
    /// Returns true if HrisTimeOffTypesResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HrisTimeOffTypesResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HrisTimeOffTypesResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Job == other.Job ||
                Job != null &&
                Job.Equals(other.Job)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Job != null)
            {
                hash = hash * 59 + Job.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
