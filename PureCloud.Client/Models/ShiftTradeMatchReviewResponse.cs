using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeMatchReviewResponse
/// </summary>
[DataContract]
public partial class ShiftTradeMatchReviewResponse : IEquatable<ShiftTradeMatchReviewResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeMatchReviewResponse" /> class.
    /// </summary>
    /// <param name="InitiatingUser">Details for the initiatingUser side of the shift trade.</param>
    /// <param name="ReceivingUser">Details for the receivingUser side of the shift trade.</param>
    /// <param name="Violations">Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator.</param>
    /// <param name="AdminReviewViolations">Constraint violations associated with this shift trade which require shift trade administrator review.</param>
    public ShiftTradeMatchReviewResponse(ShiftTradeMatchReviewUserResponse InitiatingUser = null, ShiftTradeMatchReviewUserResponse ReceivingUser = null, List<ShiftTradeMatchViolation> Violations = null, List<ShiftTradeMatchViolation> AdminReviewViolations = null)
    {
        this.InitiatingUser = InitiatingUser;
        this.ReceivingUser = ReceivingUser;
        this.Violations = Violations;
        this.AdminReviewViolations = AdminReviewViolations;

    }



    /// <summary>
    /// Details for the initiatingUser side of the shift trade
    /// </summary>
    /// <value>Details for the initiatingUser side of the shift trade</value>
    [DataMember(Name = "initiatingUser", EmitDefaultValue = false)]
    public ShiftTradeMatchReviewUserResponse InitiatingUser { get; set; }



    /// <summary>
    /// Details for the receivingUser side of the shift trade
    /// </summary>
    /// <value>Details for the receivingUser side of the shift trade</value>
    [DataMember(Name = "receivingUser", EmitDefaultValue = false)]
    public ShiftTradeMatchReviewUserResponse ReceivingUser { get; set; }



    /// <summary>
    /// Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator
    /// </summary>
    /// <value>Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator</value>
    [DataMember(Name = "violations", EmitDefaultValue = false)]
    public List<ShiftTradeMatchViolation> Violations { get; set; }



    /// <summary>
    /// Constraint violations associated with this shift trade which require shift trade administrator review
    /// </summary>
    /// <value>Constraint violations associated with this shift trade which require shift trade administrator review</value>
    [DataMember(Name = "adminReviewViolations", EmitDefaultValue = false)]
    public List<ShiftTradeMatchViolation> AdminReviewViolations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeMatchReviewResponse {\n");

        sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
        sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
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
        return Equals(obj as ShiftTradeMatchReviewResponse);
    }

    /// <summary>
    /// Returns true if ShiftTradeMatchReviewResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeMatchReviewResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeMatchReviewResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                InitiatingUser == other.InitiatingUser ||
                InitiatingUser != null &&
                InitiatingUser.Equals(other.InitiatingUser)
            ) &&
            (
                ReceivingUser == other.ReceivingUser ||
                ReceivingUser != null &&
                ReceivingUser.Equals(other.ReceivingUser)
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
            if (InitiatingUser != null)
            {
                hash = hash * 59 + InitiatingUser.GetHashCode();
            }

            if (ReceivingUser != null)
            {
                hash = hash * 59 + ReceivingUser.GetHashCode();
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
