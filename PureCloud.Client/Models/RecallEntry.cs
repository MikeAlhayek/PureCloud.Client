using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecallEntry
/// </summary>
[DataContract]
public partial class RecallEntry : IEquatable<RecallEntry>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecallEntry" /> class.
    /// </summary>
    /// <param name="NbrAttempts">NbrAttempts.</param>
    /// <param name="MinutesBetweenAttempts">MinutesBetweenAttempts.</param>
    public RecallEntry(int? NbrAttempts = null, int? MinutesBetweenAttempts = null)
    {
        this.NbrAttempts = NbrAttempts;
        this.MinutesBetweenAttempts = MinutesBetweenAttempts;

    }



    /// <summary>
    /// Gets or Sets NbrAttempts
    /// </summary>
    [DataMember(Name = "nbrAttempts", EmitDefaultValue = false)]
    public int? NbrAttempts { get; set; }



    /// <summary>
    /// Gets or Sets MinutesBetweenAttempts
    /// </summary>
    [DataMember(Name = "minutesBetweenAttempts", EmitDefaultValue = false)]
    public int? MinutesBetweenAttempts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecallEntry {\n");

        sb.Append("  NbrAttempts: ").Append(NbrAttempts).Append("\n");
        sb.Append("  MinutesBetweenAttempts: ").Append(MinutesBetweenAttempts).Append("\n");
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
        return Equals(obj as RecallEntry);
    }

    /// <summary>
    /// Returns true if RecallEntry instances are equal
    /// </summary>
    /// <param name="other">Instance of RecallEntry to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecallEntry other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                NbrAttempts == other.NbrAttempts ||
                NbrAttempts != null &&
                NbrAttempts.Equals(other.NbrAttempts)
            ) &&
            (
                MinutesBetweenAttempts == other.MinutesBetweenAttempts ||
                MinutesBetweenAttempts != null &&
                MinutesBetweenAttempts.Equals(other.MinutesBetweenAttempts)
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
            if (NbrAttempts != null)
            {
                hash = hash * 59 + NbrAttempts.GetHashCode();
            }

            if (MinutesBetweenAttempts != null)
            {
                hash = hash * 59 + MinutesBetweenAttempts.GetHashCode();
            }

            return hash;
        }
    }
}
