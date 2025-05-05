using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkErrorInfo
/// </summary>

public partial class TrunkErrorInfo : IEquatable<TrunkErrorInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkErrorInfo" /> class.
    /// </summary>
    /// <param name="Text">Text.</param>
    /// <param name="Code">Code.</param>
    /// <param name="Details">Details.</param>
    public TrunkErrorInfo(string Text = null, string Code = null, TrunkErrorInfoDetails Details = null)
    {
        this.Text = Text;
        this.Code = Code;
        this.Details = Details;

    }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [JsonPropertyName("details")]
    public TrunkErrorInfoDetails Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkErrorInfo {\n");

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
        return Equals(obj as TrunkErrorInfo);
    }

    /// <summary>
    /// Returns true if TrunkErrorInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkErrorInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkErrorInfo other)
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
