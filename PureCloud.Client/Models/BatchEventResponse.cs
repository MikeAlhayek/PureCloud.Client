using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BatchEventResponse
/// </summary>
[DataContract]
public partial class BatchEventResponse : IEquatable<BatchEventResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchEventResponse" /> class.
    /// </summary>
    /// <param name="Errors">A list of validation or server errors that occurred for posted events..</param>
    public BatchEventResponse(List<EventError> Errors = null)
    {
        this.Errors = Errors;

    }



    /// <summary>
    /// A list of validation or server errors that occurred for posted events.
    /// </summary>
    /// <value>A list of validation or server errors that occurred for posted events.</value>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    public List<EventError> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchEventResponse {\n");

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
        return Equals(obj as BatchEventResponse);
    }

    /// <summary>
    /// Returns true if BatchEventResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BatchEventResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BatchEventResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            return hash;
        }
    }
}
