using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkEntityErrorNote
/// </summary>

public partial class BulkEntityErrorNote : IEquatable<BulkEntityErrorNote>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkEntityErrorNote" /> class.
    /// </summary>
    /// <param name="Code">An error code for the specific error condition..</param>
    /// <param name="Message">A short error message..</param>
    /// <param name="Status">The HTTP Status Code for the error..</param>
    /// <param name="Retryable">Whether this particular error should be retried..</param>
    /// <param name="Details">Additional error details for specific fields..</param>
    /// <param name="Entity">The entity body specified in the Bulk request operation that caused this error..</param>
    public BulkEntityErrorNote(string Code = null, string Message = null, int? Status = null, bool? Retryable = null, List<BulkErrorDetail> Details = null, Note Entity = null)
    {
        this.Code = Code;
        this.Message = Message;
        this.Status = Status;
        this.Retryable = Retryable;
        this.Details = Details;
        this.Entity = Entity;

    }



    /// <summary>
    /// An error code for the specific error condition.
    /// </summary>
    /// <value>An error code for the specific error condition.</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// A short error message.
    /// </summary>
    /// <value>A short error message.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// The HTTP Status Code for the error.
    /// </summary>
    /// <value>The HTTP Status Code for the error.</value>
    [JsonPropertyName("status")]
    public int? Status { get; set; }



    /// <summary>
    /// Whether this particular error should be retried.
    /// </summary>
    /// <value>Whether this particular error should be retried.</value>
    [JsonPropertyName("retryable")]
    public bool? Retryable { get; set; }



    /// <summary>
    /// Additional error details for specific fields.
    /// </summary>
    /// <value>Additional error details for specific fields.</value>
    [JsonPropertyName("details")]
    public List<BulkErrorDetail> Details { get; set; }



    /// <summary>
    /// The entity body specified in the Bulk request operation that caused this error.
    /// </summary>
    /// <value>The entity body specified in the Bulk request operation that caused this error.</value>
    [JsonPropertyName("entity")]
    public Note Entity { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkEntityErrorNote {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Retryable: ").Append(Retryable).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
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
        return Equals(obj as BulkEntityErrorNote);
    }

    /// <summary>
    /// Returns true if BulkEntityErrorNote instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkEntityErrorNote to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkEntityErrorNote other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Retryable == other.Retryable ||
                Retryable != null &&
                Retryable.Equals(other.Retryable)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.SequenceEqual(other.Details)
            ) &&
            (
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Retryable != null)
            {
                hash = hash * 59 + Retryable.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            return hash;
        }
    }
}
