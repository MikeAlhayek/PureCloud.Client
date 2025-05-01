using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SettingDirection
/// </summary>
[DataContract]
public partial class SettingDirection : IEquatable<SettingDirection>
{
    /// <summary>
    /// Status for the Inbound Direction
    /// </summary>
    /// <value>Status for the Inbound Direction</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InboundEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enabled for "Enabled"
        /// </summary>
        [EnumMember(Value = "Enabled")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    /// <summary>
    /// Status for the Outbound Direction
    /// </summary>
    /// <value>Status for the Outbound Direction</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OutboundEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enabled for "Enabled"
        /// </summary>
        [EnumMember(Value = "Enabled")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    /// <summary>
    /// Status for the Inbound Direction
    /// </summary>
    /// <value>Status for the Inbound Direction</value>
    [DataMember(Name = "inbound", EmitDefaultValue = false)]
    public InboundEnum? Inbound { get; set; }
    /// <summary>
    /// Status for the Outbound Direction
    /// </summary>
    /// <value>Status for the Outbound Direction</value>
    [DataMember(Name = "outbound", EmitDefaultValue = false)]
    public OutboundEnum? Outbound { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SettingDirection" /> class.
    /// </summary>
    /// <param name="Inbound">Status for the Inbound Direction.</param>
    /// <param name="Outbound">Status for the Outbound Direction.</param>
    public SettingDirection(InboundEnum? Inbound = null, OutboundEnum? Outbound = null)
    {
        this.Inbound = Inbound;
        this.Outbound = Outbound;

    }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SettingDirection {\n");

        sb.Append("  Inbound: ").Append(Inbound).Append("\n");
        sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
        return Equals(obj as SettingDirection);
    }

    /// <summary>
    /// Returns true if SettingDirection instances are equal
    /// </summary>
    /// <param name="other">Instance of SettingDirection to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SettingDirection other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Inbound == other.Inbound ||
                Inbound != null &&
                Inbound.Equals(other.Inbound)
            ) &&
            (
                Outbound == other.Outbound ||
                Outbound != null &&
                Outbound.Equals(other.Outbound)
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
            if (Inbound != null)
            {
                hash = hash * 59 + Inbound.GetHashCode();
            }

            if (Outbound != null)
            {
                hash = hash * 59 + Outbound.GetHashCode();
            }

            return hash;
        }
    }
}
