using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseBatchAssignmentRequest
/// </summary>

public partial class LicenseBatchAssignmentRequest : IEquatable<LicenseBatchAssignmentRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseBatchAssignmentRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LicenseBatchAssignmentRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseBatchAssignmentRequest" /> class.
    /// </summary>
    /// <param name="Assignments">The list of license assignment updates to make. (required).</param>
    public LicenseBatchAssignmentRequest(List<LicenseAssignmentRequest> Assignments = null)
    {
        this.Assignments = Assignments;

    }



    /// <summary>
    /// The list of license assignment updates to make.
    /// </summary>
    /// <value>The list of license assignment updates to make.</value>
    [JsonPropertyName("assignments")]
    public List<LicenseAssignmentRequest> Assignments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LicenseBatchAssignmentRequest {\n");

        sb.Append("  Assignments: ").Append(Assignments).Append("\n");
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
        return Equals(obj as LicenseBatchAssignmentRequest);
    }

    /// <summary>
    /// Returns true if LicenseBatchAssignmentRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LicenseBatchAssignmentRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LicenseBatchAssignmentRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Assignments == other.Assignments ||
                Assignments != null &&
                Assignments.SequenceEqual(other.Assignments)
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
            if (Assignments != null)
            {
                hash = hash * 59 + Assignments.GetHashCode();
            }

            return hash;
        }
    }
}
