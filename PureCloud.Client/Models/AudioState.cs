using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AudioState
/// </summary>
[DataContract]
public partial class AudioState : IEquatable<AudioState>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AudioState" /> class.
    /// </summary>
    /// <param name="CanHear">Indicates that this communication&#39;s audio allows its participant to hear others..</param>
    /// <param name="CanSpeak">Indicates that this communication&#39;s audio allows others to hear this participant..</param>
    public AudioState(bool? CanHear = null, bool? CanSpeak = null)
    {
        this.CanHear = CanHear;
        this.CanSpeak = CanSpeak;

    }



    /// <summary>
    /// Indicates that this communication&#39;s audio allows its participant to hear others.
    /// </summary>
    /// <value>Indicates that this communication&#39;s audio allows its participant to hear others.</value>
    [DataMember(Name = "canHear", EmitDefaultValue = false)]
    public bool? CanHear { get; set; }



    /// <summary>
    /// Indicates that this communication&#39;s audio allows others to hear this participant.
    /// </summary>
    /// <value>Indicates that this communication&#39;s audio allows others to hear this participant.</value>
    [DataMember(Name = "canSpeak", EmitDefaultValue = false)]
    public bool? CanSpeak { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AudioState {\n");

        sb.Append("  CanHear: ").Append(CanHear).Append("\n");
        sb.Append("  CanSpeak: ").Append(CanSpeak).Append("\n");
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
        return Equals(obj as AudioState);
    }

    /// <summary>
    /// Returns true if AudioState instances are equal
    /// </summary>
    /// <param name="other">Instance of AudioState to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AudioState other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CanHear == other.CanHear ||
                CanHear != null &&
                CanHear.Equals(other.CanHear)
            ) &&
            (
                CanSpeak == other.CanSpeak ||
                CanSpeak != null &&
                CanSpeak.Equals(other.CanSpeak)
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
            if (CanHear != null)
            {
                hash = hash * 59 + CanHear.GetHashCode();
            }

            if (CanSpeak != null)
            {
                hash = hash * 59 + CanSpeak.GetHashCode();
            }

            return hash;
        }
    }
}
