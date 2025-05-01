using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InboundOnlySetting
/// </summary>
[DataContract]
public partial class InboundOnlySetting : IEquatable<InboundOnlySetting>
{
    /// <summary>
    /// Gets or Sets Inbound
    /// </summary>
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
    /// Gets or Sets Inbound
    /// </summary>
    [DataMember(Name = "inbound", EmitDefaultValue = false)]
    public InboundEnum? Inbound { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="InboundOnlySetting" /> class.
    /// </summary>
    /// <param name="Inbound">Inbound.</param>
    public InboundOnlySetting(InboundEnum? Inbound = null)
    {
        this.Inbound = Inbound;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InboundOnlySetting {\n");

        sb.Append("  Inbound: ").Append(Inbound).Append("\n");
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
        return Equals(obj as InboundOnlySetting);
    }

    /// <summary>
    /// Returns true if InboundOnlySetting instances are equal
    /// </summary>
    /// <param name="other">Instance of InboundOnlySetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InboundOnlySetting other)
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

            return hash;
        }
    }
}
