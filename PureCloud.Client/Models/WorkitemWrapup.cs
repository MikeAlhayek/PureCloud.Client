using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemWrapup
/// </summary>

public partial class WorkitemWrapup : IEquatable<WorkitemWrapup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemWrapup" /> class.
    /// </summary>
    /// <param name="Workitem">Workitem that the wrapup code has been added to..</param>
    /// <param name="WrapupCode">The wrapup code used in the workitem..</param>
    /// <param name="ModifiedBy">The user who added the wrapup code to the workitem..</param>
    /// <param name="User">The user for whom wrapup code was added. This may be the same as modifiedBy..</param>
    /// <param name="DateModified">The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public WorkitemWrapup(WorkitemReference Workitem = null, WrapupIdReference WrapupCode = null, UserReference ModifiedBy = null, UserReference User = null, DateTime? DateModified = null)
    {
        this.Workitem = Workitem;
        this.WrapupCode = WrapupCode;
        this.ModifiedBy = ModifiedBy;
        this.User = User;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// Workitem that the wrapup code has been added to.
    /// </summary>
    /// <value>Workitem that the wrapup code has been added to.</value>
    [JsonPropertyName("workitem")]
    public WorkitemReference Workitem { get; set; }



    /// <summary>
    /// The wrapup code used in the workitem.
    /// </summary>
    /// <value>The wrapup code used in the workitem.</value>
    [JsonPropertyName("wrapupCode")]
    public WrapupIdReference WrapupCode { get; set; }



    /// <summary>
    /// The user who added the wrapup code to the workitem.
    /// </summary>
    /// <value>The user who added the wrapup code to the workitem.</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The user for whom wrapup code was added. This may be the same as modifiedBy.
    /// </summary>
    /// <value>The user for whom wrapup code was added. This may be the same as modifiedBy.</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemWrapup {\n");

        sb.Append("  Workitem: ").Append(Workitem).Append("\n");
        sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as WorkitemWrapup);
    }

    /// <summary>
    /// Returns true if WorkitemWrapup instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemWrapup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemWrapup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Workitem == other.Workitem ||
                Workitem != null &&
                Workitem.Equals(other.Workitem)
            ) &&
            (
                WrapupCode == other.WrapupCode ||
                WrapupCode != null &&
                WrapupCode.Equals(other.WrapupCode)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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
            if (Workitem != null)
            {
                hash = hash * 59 + Workitem.GetHashCode();
            }

            if (WrapupCode != null)
            {
                hash = hash * 59 + WrapupCode.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            return hash;
        }
    }
}
