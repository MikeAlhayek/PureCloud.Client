using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OperatorPosition
/// </summary>
[DataContract]
public partial class OperatorPosition : IEquatable<OperatorPosition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OperatorPosition" /> class.
    /// </summary>
    /// <param name="VoiceSecondsPosition">Number of seconds (for voice interactions) from operand match.</param>
    /// <param name="DigitalWordsPosition">Number of words (for digital interactions) from operand match.</param>
    public OperatorPosition(int? VoiceSecondsPosition = null, int? DigitalWordsPosition = null)
    {
        this.VoiceSecondsPosition = VoiceSecondsPosition;
        this.DigitalWordsPosition = DigitalWordsPosition;

    }



    /// <summary>
    /// Number of seconds (for voice interactions) from operand match
    /// </summary>
    /// <value>Number of seconds (for voice interactions) from operand match</value>
    [DataMember(Name = "voiceSecondsPosition", EmitDefaultValue = false)]
    public int? VoiceSecondsPosition { get; set; }



    /// <summary>
    /// Number of words (for digital interactions) from operand match
    /// </summary>
    /// <value>Number of words (for digital interactions) from operand match</value>
    [DataMember(Name = "digitalWordsPosition", EmitDefaultValue = false)]
    public int? DigitalWordsPosition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OperatorPosition {\n");

        sb.Append("  VoiceSecondsPosition: ").Append(VoiceSecondsPosition).Append("\n");
        sb.Append("  DigitalWordsPosition: ").Append(DigitalWordsPosition).Append("\n");
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
        return Equals(obj as OperatorPosition);
    }

    /// <summary>
    /// Returns true if OperatorPosition instances are equal
    /// </summary>
    /// <param name="other">Instance of OperatorPosition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OperatorPosition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                VoiceSecondsPosition == other.VoiceSecondsPosition ||
                VoiceSecondsPosition != null &&
                VoiceSecondsPosition.Equals(other.VoiceSecondsPosition)
            ) &&
            (
                DigitalWordsPosition == other.DigitalWordsPosition ||
                DigitalWordsPosition != null &&
                DigitalWordsPosition.Equals(other.DigitalWordsPosition)
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
            if (VoiceSecondsPosition != null)
            {
                hash = hash * 59 + VoiceSecondsPosition.GetHashCode();
            }

            if (DigitalWordsPosition != null)
            {
                hash = hash * 59 + DigitalWordsPosition.GetHashCode();
            }

            return hash;
        }
    }
}
