using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PerformancePredictionRecalculationCompleteEventTopicErrorBody
/// </summary>

public partial class PerformancePredictionRecalculationCompleteEventTopicErrorBody : IEquatable<PerformancePredictionRecalculationCompleteEventTopicErrorBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PerformancePredictionRecalculationCompleteEventTopicErrorBody" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    /// <param name="Code">Code.</param>
    /// <param name="Message">Message.</param>
    /// <param name="MessageParams">MessageParams.</param>
    public PerformancePredictionRecalculationCompleteEventTopicErrorBody(long? Status = null, string Code = null, string Message = null, Dictionary<string, string> MessageParams = null)
    {
        this.Status = Status;
        this.Code = Code;
        this.Message = Message;
        this.MessageParams = MessageParams;

    }



    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets MessageParams
    /// </summary>
    [JsonPropertyName("messageParams")]
    public Dictionary<string, string> MessageParams { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PerformancePredictionRecalculationCompleteEventTopicErrorBody {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
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
        return Equals(obj as PerformancePredictionRecalculationCompleteEventTopicErrorBody);
    }

    /// <summary>
    /// Returns true if PerformancePredictionRecalculationCompleteEventTopicErrorBody instances are equal
    /// </summary>
    /// <param name="other">Instance of PerformancePredictionRecalculationCompleteEventTopicErrorBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PerformancePredictionRecalculationCompleteEventTopicErrorBody other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
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
                MessageParams == other.MessageParams ||
                MessageParams != null &&
                MessageParams.SequenceEqual(other.MessageParams)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (MessageParams != null)
            {
                hash = hash * 59 + MessageParams.GetHashCode();
            }

            return hash;
        }
    }
}
