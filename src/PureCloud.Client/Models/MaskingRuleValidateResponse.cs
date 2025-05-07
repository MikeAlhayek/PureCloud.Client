using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MaskingRuleValidateResponse
/// </summary>

public partial class MaskingRuleValidateResponse : IEquatable<MaskingRuleValidateResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MaskingRuleValidateResponse" /> class.
    /// </summary>
    public MaskingRuleValidateResponse()
    {

    }



    /// <summary>
    /// is masking rule definition valid?
    /// </summary>
    /// <value>is masking rule definition valid?</value>
    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }



    /// <summary>
    /// Validation message.
    /// </summary>
    /// <value>Validation message.</value>
    [JsonPropertyName("validationMessage")]
    public string ValidationMessage { get; set; }



    /// <summary>
    /// Masked text.
    /// </summary>
    /// <value>Masked text.</value>
    [JsonPropertyName("maskedText")]
    public string MaskedText { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MaskingRuleValidateResponse {\n");

        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  ValidationMessage: ").Append(ValidationMessage).Append("\n");
        sb.Append("  MaskedText: ").Append(MaskedText).Append("\n");
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
        return Equals(obj as MaskingRuleValidateResponse);
    }

    /// <summary>
    /// Returns true if MaskingRuleValidateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of MaskingRuleValidateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MaskingRuleValidateResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Valid == other.Valid ||
                Valid != null &&
                Valid.Equals(other.Valid)
            ) &&
            (
                ValidationMessage == other.ValidationMessage ||
                ValidationMessage != null &&
                ValidationMessage.Equals(other.ValidationMessage)
            ) &&
            (
                MaskedText == other.MaskedText ||
                MaskedText != null &&
                MaskedText.Equals(other.MaskedText)
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
            if (Valid != null)
            {
                hash = hash * 59 + Valid.GetHashCode();
            }

            if (ValidationMessage != null)
            {
                hash = hash * 59 + ValidationMessage.GetHashCode();
            }

            if (MaskedText != null)
            {
                hash = hash * 59 + MaskedText.GetHashCode();
            }

            return hash;
        }
    }
}
