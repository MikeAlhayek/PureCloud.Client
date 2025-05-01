using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExpansionCriterium
/// </summary>
[DataContract]
public partial class ExpansionCriterium : IEquatable<ExpansionCriterium>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum TimeoutSeconds for "TIMEOUT_SECONDS"
        /// </summary>
        [EnumMember(Value = "TIMEOUT_SECONDS")]
        TimeoutSeconds
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExpansionCriterium" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="Threshold">Threshold.</param>
    public ExpansionCriterium(TypeEnum? Type = null, double? Threshold = null)
    {
        this.Type = Type;
        this.Threshold = Threshold;

    }





    /// <summary>
    /// Gets or Sets Threshold
    /// </summary>
    [DataMember(Name = "threshold", EmitDefaultValue = false)]
    public double? Threshold { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExpansionCriterium {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Threshold: ").Append(Threshold).Append("\n");
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
        return Equals(obj as ExpansionCriterium);
    }

    /// <summary>
    /// Returns true if ExpansionCriterium instances are equal
    /// </summary>
    /// <param name="other">Instance of ExpansionCriterium to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExpansionCriterium other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Threshold == other.Threshold ||
                Threshold != null &&
                Threshold.Equals(other.Threshold)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Threshold != null)
            {
                hash = hash * 59 + Threshold.GetHashCode();
            }

            return hash;
        }
    }
}
