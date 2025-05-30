using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MatchShiftTradeResponse
/// </summary>

public partial class MatchShiftTradeResponse : IEquatable<MatchShiftTradeResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MatchShiftTradeResponse" /> class.
    /// </summary>
    /// <param name="Trade">The associated shift trade.</param>
    /// <param name="Violations">Constraint violations which disallow this shift trade.</param>
    /// <param name="AdminReviewViolations">Constraint violations for this shift trade which require shift trade administrator review.</param>
    public MatchShiftTradeResponse(ShiftTradeResponse Trade = null, List<ShiftTradeMatchViolation> Violations = null, List<ShiftTradeMatchViolation> AdminReviewViolations = null)
    {
        this.Trade = Trade;
        this.Violations = Violations;
        this.AdminReviewViolations = AdminReviewViolations;

    }



    /// <summary>
    /// The associated shift trade
    /// </summary>
    /// <value>The associated shift trade</value>
    [JsonPropertyName("trade")]
    public ShiftTradeResponse Trade { get; set; }



    /// <summary>
    /// Constraint violations which disallow this shift trade
    /// </summary>
    /// <value>Constraint violations which disallow this shift trade</value>
    [JsonPropertyName("violations")]
    public List<ShiftTradeMatchViolation> Violations { get; set; }



    /// <summary>
    /// Constraint violations for this shift trade which require shift trade administrator review
    /// </summary>
    /// <value>Constraint violations for this shift trade which require shift trade administrator review</value>
    [JsonPropertyName("adminReviewViolations")]
    public List<ShiftTradeMatchViolation> AdminReviewViolations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchShiftTradeResponse {\n");

        sb.Append("  Trade: ").Append(Trade).Append("\n");
        sb.Append("  Violations: ").Append(Violations).Append("\n");
        sb.Append("  AdminReviewViolations: ").Append(AdminReviewViolations).Append("\n");
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
        return Equals(obj as MatchShiftTradeResponse);
    }

    /// <summary>
    /// Returns true if MatchShiftTradeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of MatchShiftTradeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MatchShiftTradeResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Trade == other.Trade ||
                Trade != null &&
                Trade.Equals(other.Trade)
            ) &&
            (
                Violations == other.Violations ||
                Violations != null &&
                Violations.SequenceEqual(other.Violations)
            ) &&
            (
                AdminReviewViolations == other.AdminReviewViolations ||
                AdminReviewViolations != null &&
                AdminReviewViolations.SequenceEqual(other.AdminReviewViolations)
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
            if (Trade != null)
            {
                hash = hash * 59 + Trade.GetHashCode();
            }

            if (Violations != null)
            {
                hash = hash * 59 + Violations.GetHashCode();
            }

            if (AdminReviewViolations != null)
            {
                hash = hash * 59 + AdminReviewViolations.GetHashCode();
            }

            return hash;
        }
    }
}
