using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundOnlySetting
/// </summary>
[DataContract]
public partial class OutboundOnlySetting : IEquatable<OutboundOnlySetting>
{
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
    /// Status for the Outbound Direction
    /// </summary>
    /// <value>Status for the Outbound Direction</value>
    [DataMember(Name = "outbound", EmitDefaultValue = false)]
    public OutboundEnum? Outbound { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundOnlySetting" /> class.
    /// </summary>
    /// <param name="Outbound">Status for the Outbound Direction.</param>
    public OutboundOnlySetting(OutboundEnum? Outbound = null)
    {
        this.Outbound = Outbound;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundOnlySetting {\n");

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
        return Equals(obj as OutboundOnlySetting);
    }

    /// <summary>
    /// Returns true if OutboundOnlySetting instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundOnlySetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundOnlySetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Outbound != null)
            {
                hash = hash * 59 + Outbound.GetHashCode();
            }

            return hash;
        }
    }
}
