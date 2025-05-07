using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AiScoring
/// </summary>

public partial class AiScoring : IEquatable<AiScoring>
{
    /// <summary>
    /// The type of error that occurred while processing AI scores. It is null where there is no error.
    /// </summary>
    /// <value>The type of error that occurred while processing AI scores. It is null where there is no error.</value>
    
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
        /// Enum Quotareached for "QuotaReached"
        /// </summary>
        [EnumMember(Value = "QuotaReached")]
        Quotareached,

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
        /// Enum Invalidrequest for "InvalidRequest"
        /// </summary>
        [EnumMember(Value = "InvalidRequest")]
        Invalidrequest,

        /// <summary>
        /// Enum Duplicateformsameagent for "DuplicateFormSameAgent"
        /// </summary>
        [EnumMember(Value = "DuplicateFormSameAgent")]
        Duplicateformsameagent,

        /// <summary>
        /// Enum Unauthorized for "Unauthorized"
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized
    }
    /// <summary>
    /// The type of error that occurred while processing AI scores. It is null where there is no error.
    /// </summary>
    /// <value>The type of error that occurred while processing AI scores. It is null where there is no error.</value>
    [JsonPropertyName("failureType")]
    public FailureTypeEnum? FailureType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AiScoring" /> class.
    /// </summary>
    public AiScoring()
    {

    }





    /// <summary>
    /// Indicates whether AI scoring is currently processing the evaluation.
    /// </summary>
    /// <value>Indicates whether AI scoring is currently processing the evaluation.</value>
    [JsonPropertyName("pending")]
    public bool? Pending { get; set; }



    /// <summary>
    /// The date when the AI scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the AI scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateLastChanged")]
    public DateTime? DateLastChanged { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AiScoring {\n");

        sb.Append("  FailureType: ").Append(FailureType).Append("\n");
        sb.Append("  Pending: ").Append(Pending).Append("\n");
        sb.Append("  DateLastChanged: ").Append(DateLastChanged).Append("\n");
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
        return Equals(obj as AiScoring);
    }

    /// <summary>
    /// Returns true if AiScoring instances are equal
    /// </summary>
    /// <param name="other">Instance of AiScoring to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AiScoring other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FailureType == other.FailureType ||
                FailureType != null &&
                FailureType.Equals(other.FailureType)
            ) &&
            (
                Pending == other.Pending ||
                Pending != null &&
                Pending.Equals(other.Pending)
            ) &&
            (
                DateLastChanged == other.DateLastChanged ||
                DateLastChanged != null &&
                DateLastChanged.Equals(other.DateLastChanged)
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
            if (FailureType != null)
            {
                hash = hash * 59 + FailureType.GetHashCode();
            }

            if (Pending != null)
            {
                hash = hash * 59 + Pending.GetHashCode();
            }

            if (DateLastChanged != null)
            {
                hash = hash * 59 + DateLastChanged.GetHashCode();
            }

            return hash;
        }
    }
}
