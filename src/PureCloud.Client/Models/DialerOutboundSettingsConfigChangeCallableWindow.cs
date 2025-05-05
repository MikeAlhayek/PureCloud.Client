using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerOutboundSettingsConfigChangeCallableWindow
/// </summary>

public partial class DialerOutboundSettingsConfigChangeCallableWindow : IEquatable<DialerOutboundSettingsConfigChangeCallableWindow>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerOutboundSettingsConfigChangeCallableWindow" /> class.
    /// </summary>
    /// <param name="Mapped">Mapped.</param>
    /// <param name="Unmapped">Unmapped.</param>
    public DialerOutboundSettingsConfigChangeCallableWindow(DialerOutboundSettingsConfigChangeAtzmTimeSlot Mapped = null, DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone Unmapped = null)
    {
        this.Mapped = Mapped;
        this.Unmapped = Unmapped;

    }



    /// <summary>
    /// Gets or Sets Mapped
    /// </summary>
    [JsonPropertyName("mapped")]
    public DialerOutboundSettingsConfigChangeAtzmTimeSlot Mapped { get; set; }



    /// <summary>
    /// Gets or Sets Unmapped
    /// </summary>
    [JsonPropertyName("unmapped")]
    public DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone Unmapped { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerOutboundSettingsConfigChangeCallableWindow {\n");

        sb.Append("  Mapped: ").Append(Mapped).Append("\n");
        sb.Append("  Unmapped: ").Append(Unmapped).Append("\n");
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
        return Equals(obj as DialerOutboundSettingsConfigChangeCallableWindow);
    }

    /// <summary>
    /// Returns true if DialerOutboundSettingsConfigChangeCallableWindow instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerOutboundSettingsConfigChangeCallableWindow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerOutboundSettingsConfigChangeCallableWindow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Mapped == other.Mapped ||
                Mapped != null &&
                Mapped.Equals(other.Mapped)
            ) &&
            (
                Unmapped == other.Unmapped ||
                Unmapped != null &&
                Unmapped.Equals(other.Unmapped)
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
            if (Mapped != null)
            {
                hash = hash * 59 + Mapped.GetHashCode();
            }

            if (Unmapped != null)
            {
                hash = hash * 59 + Unmapped.GetHashCode();
            }

            return hash;
        }
    }
}
