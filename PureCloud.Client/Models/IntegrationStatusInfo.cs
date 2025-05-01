using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Status information for an Integration.
/// </summary>
[DataContract]
public partial class IntegrationStatusInfo : IEquatable<IntegrationStatusInfo>
{
    /// <summary>
    /// Machine-readable status as reported by the integration.
    /// </summary>
    /// <value>Machine-readable status as reported by the integration.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Activating for "ACTIVATING"
        /// </summary>
        [EnumMember(Value = "ACTIVATING")]
        Activating,

        /// <summary>
        /// Enum Inactive for "INACTIVE"
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        Inactive,

        /// <summary>
        /// Enum Deactivating for "DEACTIVATING"
        /// </summary>
        [EnumMember(Value = "DEACTIVATING")]
        Deactivating,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error
    }
    /// <summary>
    /// Machine-readable status as reported by the integration.
    /// </summary>
    /// <value>Machine-readable status as reported by the integration.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public CodeEnum? Code { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationStatusInfo" /> class.
    /// </summary>
    public IntegrationStatusInfo()
    {

    }





    /// <summary>
    /// Localized, human-readable, effective status of the integration.
    /// </summary>
    /// <value>Localized, human-readable, effective status of the integration.</value>
    [DataMember(Name = "effective", EmitDefaultValue = false)]
    public string Effective { get; private set; }



    /// <summary>
    /// Localizable status details for the integration.
    /// </summary>
    /// <value>Localizable status details for the integration.</value>
    [DataMember(Name = "detail", EmitDefaultValue = false)]
    public MessageInfo Detail { get; private set; }



    /// <summary>
    /// Date and time (in UTC) when the integration status (i.e. the code field) was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time (in UTC) when the integration status (i.e. the code field) was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
    public DateTime? LastUpdated { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IntegrationStatusInfo {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Effective: ").Append(Effective).Append("\n");
        sb.Append("  Detail: ").Append(Detail).Append("\n");
        sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
        return Equals(obj as IntegrationStatusInfo);
    }

    /// <summary>
    /// Returns true if IntegrationStatusInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of IntegrationStatusInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntegrationStatusInfo other)
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
                Effective == other.Effective ||
                Effective != null &&
                Effective.Equals(other.Effective)
            ) &&
            (
                Detail == other.Detail ||
                Detail != null &&
                Detail.Equals(other.Detail)
            ) &&
            (
                LastUpdated == other.LastUpdated ||
                LastUpdated != null &&
                LastUpdated.Equals(other.LastUpdated)
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

            if (Effective != null)
            {
                hash = hash * 59 + Effective.GetHashCode();
            }

            if (Detail != null)
            {
                hash = hash * 59 + Detail.GetHashCode();
            }

            if (LastUpdated != null)
            {
                hash = hash * 59 + LastUpdated.GetHashCode();
            }

            return hash;
        }
    }
}
