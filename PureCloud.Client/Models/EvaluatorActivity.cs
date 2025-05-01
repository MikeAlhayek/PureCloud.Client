using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluatorActivity
/// </summary>
[DataContract]
public partial class EvaluatorActivity : IEquatable<EvaluatorActivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluatorActivity" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Evaluator">Evaluator.</param>
    /// <param name="NumEvaluationsAssigned">NumEvaluationsAssigned.</param>
    /// <param name="NumEvaluationsStarted">NumEvaluationsStarted.</param>
    /// <param name="NumEvaluationsCompleted">NumEvaluationsCompleted.</param>
    /// <param name="NumCalibrationsAssigned">NumCalibrationsAssigned.</param>
    /// <param name="NumCalibrationsStarted">NumCalibrationsStarted.</param>
    /// <param name="NumCalibrationsCompleted">NumCalibrationsCompleted.</param>
    /// <param name="NumEvaluationsWithoutViewPermission">NumEvaluationsWithoutViewPermission.</param>
    public EvaluatorActivity(string Name = null, User Evaluator = null, int? NumEvaluationsAssigned = null, int? NumEvaluationsStarted = null, int? NumEvaluationsCompleted = null, int? NumCalibrationsAssigned = null, int? NumCalibrationsStarted = null, int? NumCalibrationsCompleted = null, int? NumEvaluationsWithoutViewPermission = null)
    {
        this.Name = Name;
        this.Evaluator = Evaluator;
        this.NumEvaluationsAssigned = NumEvaluationsAssigned;
        this.NumEvaluationsStarted = NumEvaluationsStarted;
        this.NumEvaluationsCompleted = NumEvaluationsCompleted;
        this.NumCalibrationsAssigned = NumCalibrationsAssigned;
        this.NumCalibrationsStarted = NumCalibrationsStarted;
        this.NumCalibrationsCompleted = NumCalibrationsCompleted;
        this.NumEvaluationsWithoutViewPermission = NumEvaluationsWithoutViewPermission;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Evaluator
    /// </summary>
    [DataMember(Name = "evaluator", EmitDefaultValue = false)]
    public User Evaluator { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluationsAssigned
    /// </summary>
    [DataMember(Name = "numEvaluationsAssigned", EmitDefaultValue = false)]
    public int? NumEvaluationsAssigned { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluationsStarted
    /// </summary>
    [DataMember(Name = "numEvaluationsStarted", EmitDefaultValue = false)]
    public int? NumEvaluationsStarted { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluationsCompleted
    /// </summary>
    [DataMember(Name = "numEvaluationsCompleted", EmitDefaultValue = false)]
    public int? NumEvaluationsCompleted { get; set; }



    /// <summary>
    /// Gets or Sets NumCalibrationsAssigned
    /// </summary>
    [DataMember(Name = "numCalibrationsAssigned", EmitDefaultValue = false)]
    public int? NumCalibrationsAssigned { get; set; }



    /// <summary>
    /// Gets or Sets NumCalibrationsStarted
    /// </summary>
    [DataMember(Name = "numCalibrationsStarted", EmitDefaultValue = false)]
    public int? NumCalibrationsStarted { get; set; }



    /// <summary>
    /// Gets or Sets NumCalibrationsCompleted
    /// </summary>
    [DataMember(Name = "numCalibrationsCompleted", EmitDefaultValue = false)]
    public int? NumCalibrationsCompleted { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluationsWithoutViewPermission
    /// </summary>
    [DataMember(Name = "numEvaluationsWithoutViewPermission", EmitDefaultValue = false)]
    public int? NumEvaluationsWithoutViewPermission { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluatorActivity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
        sb.Append("  NumEvaluationsAssigned: ").Append(NumEvaluationsAssigned).Append("\n");
        sb.Append("  NumEvaluationsStarted: ").Append(NumEvaluationsStarted).Append("\n");
        sb.Append("  NumEvaluationsCompleted: ").Append(NumEvaluationsCompleted).Append("\n");
        sb.Append("  NumCalibrationsAssigned: ").Append(NumCalibrationsAssigned).Append("\n");
        sb.Append("  NumCalibrationsStarted: ").Append(NumCalibrationsStarted).Append("\n");
        sb.Append("  NumCalibrationsCompleted: ").Append(NumCalibrationsCompleted).Append("\n");
        sb.Append("  NumEvaluationsWithoutViewPermission: ").Append(NumEvaluationsWithoutViewPermission).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as EvaluatorActivity);
    }

    /// <summary>
    /// Returns true if EvaluatorActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluatorActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluatorActivity other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Evaluator == other.Evaluator ||
                Evaluator != null &&
                Evaluator.Equals(other.Evaluator)
            ) &&
            (
                NumEvaluationsAssigned == other.NumEvaluationsAssigned ||
                NumEvaluationsAssigned != null &&
                NumEvaluationsAssigned.Equals(other.NumEvaluationsAssigned)
            ) &&
            (
                NumEvaluationsStarted == other.NumEvaluationsStarted ||
                NumEvaluationsStarted != null &&
                NumEvaluationsStarted.Equals(other.NumEvaluationsStarted)
            ) &&
            (
                NumEvaluationsCompleted == other.NumEvaluationsCompleted ||
                NumEvaluationsCompleted != null &&
                NumEvaluationsCompleted.Equals(other.NumEvaluationsCompleted)
            ) &&
            (
                NumCalibrationsAssigned == other.NumCalibrationsAssigned ||
                NumCalibrationsAssigned != null &&
                NumCalibrationsAssigned.Equals(other.NumCalibrationsAssigned)
            ) &&
            (
                NumCalibrationsStarted == other.NumCalibrationsStarted ||
                NumCalibrationsStarted != null &&
                NumCalibrationsStarted.Equals(other.NumCalibrationsStarted)
            ) &&
            (
                NumCalibrationsCompleted == other.NumCalibrationsCompleted ||
                NumCalibrationsCompleted != null &&
                NumCalibrationsCompleted.Equals(other.NumCalibrationsCompleted)
            ) &&
            (
                NumEvaluationsWithoutViewPermission == other.NumEvaluationsWithoutViewPermission ||
                NumEvaluationsWithoutViewPermission != null &&
                NumEvaluationsWithoutViewPermission.Equals(other.NumEvaluationsWithoutViewPermission)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Evaluator != null)
            {
                hash = hash * 59 + Evaluator.GetHashCode();
            }

            if (NumEvaluationsAssigned != null)
            {
                hash = hash * 59 + NumEvaluationsAssigned.GetHashCode();
            }

            if (NumEvaluationsStarted != null)
            {
                hash = hash * 59 + NumEvaluationsStarted.GetHashCode();
            }

            if (NumEvaluationsCompleted != null)
            {
                hash = hash * 59 + NumEvaluationsCompleted.GetHashCode();
            }

            if (NumCalibrationsAssigned != null)
            {
                hash = hash * 59 + NumCalibrationsAssigned.GetHashCode();
            }

            if (NumCalibrationsStarted != null)
            {
                hash = hash * 59 + NumCalibrationsStarted.GetHashCode();
            }

            if (NumCalibrationsCompleted != null)
            {
                hash = hash * 59 + NumCalibrationsCompleted.GetHashCode();
            }

            if (NumEvaluationsWithoutViewPermission != null)
            {
                hash = hash * 59 + NumEvaluationsWithoutViewPermission.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
