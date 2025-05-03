using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Section
/// </summary>

public partial class Section : IEquatable<Section>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Section" /> class.
    /// </summary>
    /// <param name="FieldList">FieldList.</param>
    /// <param name="InstructionText">InstructionText.</param>
    /// <param name="Key">Key.</param>
    /// <param name="State">State.</param>
    public Section(List<FieldList> FieldList = null, string InstructionText = null, string Key = null, string State = null)
    {
        this.FieldList = FieldList;
        this.InstructionText = InstructionText;
        this.Key = Key;
        this.State = State;

    }



    /// <summary>
    /// Gets or Sets FieldList
    /// </summary>
    [JsonPropertyName("fieldList")]
    public List<FieldList> FieldList { get; set; }



    /// <summary>
    /// Gets or Sets InstructionText
    /// </summary>
    [JsonPropertyName("instructionText")]
    public string InstructionText { get; set; }



    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }



    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Section {\n");

        sb.Append("  FieldList: ").Append(FieldList).Append("\n");
        sb.Append("  InstructionText: ").Append(InstructionText).Append("\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as Section);
    }

    /// <summary>
    /// Returns true if Section instances are equal
    /// </summary>
    /// <param name="other">Instance of Section to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Section other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FieldList == other.FieldList ||
                FieldList != null &&
                FieldList.SequenceEqual(other.FieldList)
            ) &&
            (
                InstructionText == other.InstructionText ||
                InstructionText != null &&
                InstructionText.Equals(other.InstructionText)
            ) &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (FieldList != null)
            {
                hash = hash * 59 + FieldList.GetHashCode();
            }

            if (InstructionText != null)
            {
                hash = hash * 59 + InstructionText.GetHashCode();
            }

            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
