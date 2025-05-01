using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationAssignment
/// </summary>
[DataContract]
public partial class EvaluationAssignment : IEquatable<EvaluationAssignment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationAssignment" /> class.
    /// </summary>
    /// <param name="EvaluationForm">EvaluationForm.</param>
    /// <param name="User">User.</param>
    public EvaluationAssignment(EvaluationForm EvaluationForm = null, User User = null)
    {
        this.EvaluationForm = EvaluationForm;
        this.User = User;

    }



    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    [DataMember(Name = "evaluationForm", EmitDefaultValue = false)]
    public EvaluationForm EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public User User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationAssignment {\n");

        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as EvaluationAssignment);
    }

    /// <summary>
    /// Returns true if EvaluationAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationAssignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EvaluationForm == other.EvaluationForm ||
                EvaluationForm != null &&
                EvaluationForm.Equals(other.EvaluationForm)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (EvaluationForm != null)
            {
                hash = hash * 59 + EvaluationForm.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
