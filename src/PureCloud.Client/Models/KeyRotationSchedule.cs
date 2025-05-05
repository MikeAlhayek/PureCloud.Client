using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KeyRotationSchedule
/// </summary>

public partial class KeyRotationSchedule : IEquatable<KeyRotationSchedule>
{
    /// <summary>
    /// Value to set schedule to
    /// </summary>
    /// <value>Value to set schedule to</value>
    
    public enum PeriodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Disabled for "DISABLED"
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        Disabled,

        /// <summary>
        /// Enum Daily for "DAILY"
        /// </summary>
        [EnumMember(Value = "DAILY")]
        Daily,

        /// <summary>
        /// Enum Weekly for "WEEKLY"
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        Weekly,

        /// <summary>
        /// Enum Monthly for "MONTHLY"
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        Monthly,

        /// <summary>
        /// Enum Yearly for "YEARLY"
        /// </summary>
        [EnumMember(Value = "YEARLY")]
        Yearly
    }
    /// <summary>
    /// Value to set schedule to
    /// </summary>
    /// <value>Value to set schedule to</value>
    [JsonPropertyName("period")]
    public PeriodEnum? Period { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KeyRotationSchedule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KeyRotationSchedule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyRotationSchedule" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Period">Value to set schedule to (required).</param>
    public KeyRotationSchedule(string Name = null, PeriodEnum? Period = null)
    {
        this.Name = Name;
        this.Period = Period;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KeyRotationSchedule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Period: ").Append(Period).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KeyRotationSchedule);
    }

    /// <summary>
    /// Returns true if KeyRotationSchedule instances are equal
    /// </summary>
    /// <param name="other">Instance of KeyRotationSchedule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KeyRotationSchedule other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Period == other.Period ||
                Period != null &&
                Period.Equals(other.Period)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Period != null)
            {
                hash = hash * 59 + Period.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
