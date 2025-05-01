using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Validation results
/// </summary>
[DataContract]
public partial class DraftValidationResult : IEquatable<DraftValidationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DraftValidationResult" /> class.
    /// </summary>
    /// <param name="Valid">Indicates if configuration is valid.</param>
    /// <param name="Errors">List of errors causing validation failure.</param>
    public DraftValidationResult(bool? Valid = null, List<ErrorBody> Errors = null)
    {
        this.Valid = Valid;
        this.Errors = Errors;

    }



    /// <summary>
    /// Indicates if configuration is valid
    /// </summary>
    /// <value>Indicates if configuration is valid</value>
    [DataMember(Name = "valid", EmitDefaultValue = false)]
    public bool? Valid { get; set; }



    /// <summary>
    /// List of errors causing validation failure
    /// </summary>
    /// <value>List of errors causing validation failure</value>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    public List<ErrorBody> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DraftValidationResult {\n");

        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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
        return Equals(obj as DraftValidationResult);
    }

    /// <summary>
    /// Returns true if DraftValidationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of DraftValidationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DraftValidationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Valid == other.Valid ||
                Valid != null &&
                Valid.Equals(other.Valid)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
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
            if (Valid != null)
            {
                hash = hash * 59 + Valid.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            return hash;
        }
    }
}
