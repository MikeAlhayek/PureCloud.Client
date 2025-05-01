using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkInstanceTopicTrunkErrorInfo
/// </summary>
[DataContract]
public partial class TrunkInstanceTopicTrunkErrorInfo : IEquatable<TrunkInstanceTopicTrunkErrorInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkErrorInfo" /> class.
    /// </summary>
    /// <param name="Text">Text.</param>
    /// <param name="Code">Code.</param>
    /// <param name="Details">Details.</param>
    public TrunkInstanceTopicTrunkErrorInfo(string Text = null, string Code = null, TrunkInstanceTopicTrunkErrorInfoDetails Details = null)
    {
        this.Text = Text;
        this.Code = Code;
        this.Details = Details;

    }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name = "details", EmitDefaultValue = false)]
    public TrunkInstanceTopicTrunkErrorInfoDetails Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkInstanceTopicTrunkErrorInfo {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
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
        return Equals(obj as TrunkInstanceTopicTrunkErrorInfo);
    }

    /// <summary>
    /// Returns true if TrunkInstanceTopicTrunkErrorInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkInstanceTopicTrunkErrorInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkInstanceTopicTrunkErrorInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.Equals(other.Details)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            return hash;
        }
    }
}
