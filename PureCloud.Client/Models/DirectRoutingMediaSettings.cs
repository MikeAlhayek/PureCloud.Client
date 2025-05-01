using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DirectRoutingMediaSettings
/// </summary>
[DataContract]
public partial class DirectRoutingMediaSettings : IEquatable<DirectRoutingMediaSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DirectRoutingMediaSettings" /> class.
    /// </summary>
    /// <param name="UseAgentAddressOutbound">Toggle that enables using an agent&#39;s Direct Routing address outbound on behalf of queue for this media type..</param>
    public DirectRoutingMediaSettings(bool? UseAgentAddressOutbound = null)
    {
        this.UseAgentAddressOutbound = UseAgentAddressOutbound;

    }



    /// <summary>
    /// Toggle that enables using an agent&#39;s Direct Routing address outbound on behalf of queue for this media type.
    /// </summary>
    /// <value>Toggle that enables using an agent&#39;s Direct Routing address outbound on behalf of queue for this media type.</value>
    [DataMember(Name = "useAgentAddressOutbound", EmitDefaultValue = false)]
    public bool? UseAgentAddressOutbound { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DirectRoutingMediaSettings {\n");

        sb.Append("  UseAgentAddressOutbound: ").Append(UseAgentAddressOutbound).Append("\n");
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
        return Equals(obj as DirectRoutingMediaSettings);
    }

    /// <summary>
    /// Returns true if DirectRoutingMediaSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of DirectRoutingMediaSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DirectRoutingMediaSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UseAgentAddressOutbound == other.UseAgentAddressOutbound ||
                UseAgentAddressOutbound != null &&
                UseAgentAddressOutbound.Equals(other.UseAgentAddressOutbound)
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
            if (UseAgentAddressOutbound != null)
            {
                hash = hash * 59 + UseAgentAddressOutbound.GetHashCode();
            }

            return hash;
        }
    }
}
