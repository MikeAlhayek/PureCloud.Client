using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AiAnswer
/// </summary>
[DataContract]
public partial class AiAnswer : IEquatable<AiAnswer>
{
    /// <summary>
    /// Describes the type of error associated with the AI answer.
    /// </summary>
    /// <value>Describes the type of error associated with the AI answer.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FailureTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Lowconfidenceerror for "LowConfidenceError"
        /// </summary>
        [EnumMember(Value = "LowConfidenceError")]
        Lowconfidenceerror,

        /// <summary>
        /// Enum Parsingerror for "ParsingError"
        /// </summary>
        [EnumMember(Value = "ParsingError")]
        Parsingerror,

        /// <summary>
        /// Enum Serviceerror for "ServiceError"
        /// </summary>
        [EnumMember(Value = "ServiceError")]
        Serviceerror,

        /// <summary>
        /// Enum Lowhistoricalaccuracyerror for "LowHistoricalAccuracyError"
        /// </summary>
        [EnumMember(Value = "LowHistoricalAccuracyError")]
        Lowhistoricalaccuracyerror
    }
    /// <summary>
    /// Describes the type of error associated with the AI answer.
    /// </summary>
    /// <value>Describes the type of error associated with the AI answer.</value>
    [DataMember(Name = "failureType", EmitDefaultValue = false)]
    public FailureTypeEnum? FailureType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AiAnswer" /> class.
    /// </summary>
    /// <param name="AnswerId">The unique identifier of the suggested AI answer..</param>
    /// <param name="Explanation">An explanation providing the reasoning behind the suggested answer..</param>
    /// <param name="FailureType">Describes the type of error associated with the AI answer..</param>
    public AiAnswer(string AnswerId = null, string Explanation = null, FailureTypeEnum? FailureType = null)
    {
        this.AnswerId = AnswerId;
        this.Explanation = Explanation;
        this.FailureType = FailureType;

    }



    /// <summary>
    /// The unique identifier of the suggested AI answer.
    /// </summary>
    /// <value>The unique identifier of the suggested AI answer.</value>
    [DataMember(Name = "answerId", EmitDefaultValue = false)]
    public string AnswerId { get; set; }



    /// <summary>
    /// An explanation providing the reasoning behind the suggested answer.
    /// </summary>
    /// <value>An explanation providing the reasoning behind the suggested answer.</value>
    [DataMember(Name = "explanation", EmitDefaultValue = false)]
    public string Explanation { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AiAnswer {\n");

        sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
        sb.Append("  Explanation: ").Append(Explanation).Append("\n");
        sb.Append("  FailureType: ").Append(FailureType).Append("\n");
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
        return Equals(obj as AiAnswer);
    }

    /// <summary>
    /// Returns true if AiAnswer instances are equal
    /// </summary>
    /// <param name="other">Instance of AiAnswer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AiAnswer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AnswerId == other.AnswerId ||
                AnswerId != null &&
                AnswerId.Equals(other.AnswerId)
            ) &&
            (
                Explanation == other.Explanation ||
                Explanation != null &&
                Explanation.Equals(other.Explanation)
            ) &&
            (
                FailureType == other.FailureType ||
                FailureType != null &&
                FailureType.Equals(other.FailureType)
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
            if (AnswerId != null)
            {
                hash = hash * 59 + AnswerId.GetHashCode();
            }

            if (Explanation != null)
            {
                hash = hash * 59 + Explanation.GetHashCode();
            }

            if (FailureType != null)
            {
                hash = hash * 59 + FailureType.GetHashCode();
            }

            return hash;
        }
    }
}
