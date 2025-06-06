using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictorModelRetrainingError
/// </summary>

public partial class PredictorModelRetrainingError : IEquatable<PredictorModelRetrainingError>
{
    /// <summary>
    /// Error code describing model training failure.
    /// </summary>
    /// <value>Error code describing model training failure.</value>
    
    public enum ErrorCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Notenoughdata for "NotEnoughData"
        /// </summary>
        [EnumMember(Value = "NotEnoughData")]
        Notenoughdata,

        /// <summary>
        /// Enum Serviceerror for "ServiceError"
        /// </summary>
        [EnumMember(Value = "ServiceError")]
        Serviceerror,

        /// <summary>
        /// Enum Unknownerror for "UnknownError"
        /// </summary>
        [EnumMember(Value = "UnknownError")]
        Unknownerror
    }
    /// <summary>
    /// Error code describing model training failure.
    /// </summary>
    /// <value>Error code describing model training failure.</value>
    [JsonPropertyName("errorCode")]
    public ErrorCodeEnum? ErrorCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorModelRetrainingError" /> class.
    /// </summary>
    public PredictorModelRetrainingError()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Date when the first retraining failure happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the first retraining failure happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateOfFirstOccurrence")]
    public DateTime? DateOfFirstOccurrence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorModelRetrainingError {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  DateOfFirstOccurrence: ").Append(DateOfFirstOccurrence).Append("\n");
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
        return Equals(obj as PredictorModelRetrainingError);
    }

    /// <summary>
    /// Returns true if PredictorModelRetrainingError instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorModelRetrainingError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorModelRetrainingError other)
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
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                DateOfFirstOccurrence == other.DateOfFirstOccurrence ||
                DateOfFirstOccurrence != null &&
                DateOfFirstOccurrence.Equals(other.DateOfFirstOccurrence)
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

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (DateOfFirstOccurrence != null)
            {
                hash = hash * 59 + DateOfFirstOccurrence.GetHashCode();
            }

            return hash;
        }
    }
}
