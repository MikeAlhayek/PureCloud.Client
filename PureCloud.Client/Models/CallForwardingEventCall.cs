using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallForwardingEventCall
/// </summary>

public partial class CallForwardingEventCall : IEquatable<CallForwardingEventCall>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallForwardingEventCall" /> class.
    /// </summary>
    /// <param name="Targets">Targets.</param>
    public CallForwardingEventCall(List<CallForwardingEventTarget> Targets = null)
    {
        this.Targets = Targets;

    }



    /// <summary>
    /// Gets or Sets Targets
    /// </summary>
    [JsonPropertyName("targets")]
    public List<CallForwardingEventTarget> Targets { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallForwardingEventCall {\n");

        sb.Append("  Targets: ").Append(Targets).Append("\n");
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
        return Equals(obj as CallForwardingEventCall);
    }

    /// <summary>
    /// Returns true if CallForwardingEventCall instances are equal
    /// </summary>
    /// <param name="other">Instance of CallForwardingEventCall to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallForwardingEventCall other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Targets == other.Targets ||
                Targets != null &&
                Targets.SequenceEqual(other.Targets)
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
            if (Targets != null)
            {
                hash = hash * 59 + Targets.GetHashCode();
            }

            return hash;
        }
    }
}
