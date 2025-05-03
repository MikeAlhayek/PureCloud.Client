using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyErrorMessage
/// </summary>

public partial class PolicyErrorMessage : IEquatable<PolicyErrorMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyErrorMessage" /> class.
    /// </summary>
    /// <param name="StatusCode">StatusCode.</param>
    /// <param name="UserMessage">UserMessage.</param>
    /// <param name="UserParamsMessage">UserParamsMessage.</param>
    /// <param name="ErrorCode">ErrorCode.</param>
    /// <param name="CorrelationId">CorrelationId.</param>
    /// <param name="UserParams">UserParams.</param>
    /// <param name="InsertDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public PolicyErrorMessage(int? StatusCode = null, object UserMessage = null, string UserParamsMessage = null, string ErrorCode = null, string CorrelationId = null, List<UserParam> UserParams = null, DateTime? InsertDate = null)
    {
        this.StatusCode = StatusCode;
        this.UserMessage = UserMessage;
        this.UserParamsMessage = UserParamsMessage;
        this.ErrorCode = ErrorCode;
        this.CorrelationId = CorrelationId;
        this.UserParams = UserParams;
        this.InsertDate = InsertDate;

    }



    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }



    /// <summary>
    /// Gets or Sets UserMessage
    /// </summary>
    [JsonPropertyName("userMessage")]
    public object UserMessage { get; set; }



    /// <summary>
    /// Gets or Sets UserParamsMessage
    /// </summary>
    [JsonPropertyName("userParamsMessage")]
    public string UserParamsMessage { get; set; }



    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; }



    /// <summary>
    /// Gets or Sets UserParams
    /// </summary>
    [JsonPropertyName("userParams")]
    public List<UserParam> UserParams { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("insertDate")]
    public DateTime? InsertDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyErrorMessage {\n");

        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
        sb.Append("  UserParamsMessage: ").Append(UserParamsMessage).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  UserParams: ").Append(UserParams).Append("\n");
        sb.Append("  InsertDate: ").Append(InsertDate).Append("\n");
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
        return Equals(obj as PolicyErrorMessage);
    }

    /// <summary>
    /// Returns true if PolicyErrorMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyErrorMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyErrorMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StatusCode == other.StatusCode ||
                StatusCode != null &&
                StatusCode.Equals(other.StatusCode)
            ) &&
            (
                UserMessage == other.UserMessage ||
                UserMessage != null &&
                UserMessage.Equals(other.UserMessage)
            ) &&
            (
                UserParamsMessage == other.UserParamsMessage ||
                UserParamsMessage != null &&
                UserParamsMessage.Equals(other.UserParamsMessage)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                CorrelationId == other.CorrelationId ||
                CorrelationId != null &&
                CorrelationId.Equals(other.CorrelationId)
            ) &&
            (
                UserParams == other.UserParams ||
                UserParams != null &&
                UserParams.SequenceEqual(other.UserParams)
            ) &&
            (
                InsertDate == other.InsertDate ||
                InsertDate != null &&
                InsertDate.Equals(other.InsertDate)
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
            if (StatusCode != null)
            {
                hash = hash * 59 + StatusCode.GetHashCode();
            }

            if (UserMessage != null)
            {
                hash = hash * 59 + UserMessage.GetHashCode();
            }

            if (UserParamsMessage != null)
            {
                hash = hash * 59 + UserParamsMessage.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (CorrelationId != null)
            {
                hash = hash * 59 + CorrelationId.GetHashCode();
            }

            if (UserParams != null)
            {
                hash = hash * 59 + UserParams.GetHashCode();
            }

            if (InsertDate != null)
            {
                hash = hash * 59 + InsertDate.GetHashCode();
            }

            return hash;
        }
    }
}
