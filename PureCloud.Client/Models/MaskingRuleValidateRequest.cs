using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MaskingRuleValidateRequest
/// </summary>
[DataContract]
public partial class MaskingRuleValidateRequest : IEquatable<MaskingRuleValidateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MaskingRuleValidateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MaskingRuleValidateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MaskingRuleValidateRequest" /> class.
    /// </summary>
    /// <param name="Text">Text to mask. (required).</param>
    /// <param name="Definition">Regex to be applied (required).</param>
    public MaskingRuleValidateRequest(string Text = null, string Definition = null)
    {
        this.Text = Text;
        this.Definition = Definition;

    }



    /// <summary>
    /// Text to mask.
    /// </summary>
    /// <value>Text to mask.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Regex to be applied
    /// </summary>
    /// <value>Regex to be applied</value>
    [DataMember(Name = "definition", EmitDefaultValue = false)]
    public string Definition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MaskingRuleValidateRequest {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Definition: ").Append(Definition).Append("\n");
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
        return Equals(obj as MaskingRuleValidateRequest);
    }

    /// <summary>
    /// Returns true if MaskingRuleValidateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MaskingRuleValidateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MaskingRuleValidateRequest other)
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
                Definition == other.Definition ||
                Definition != null &&
                Definition.Equals(other.Definition)
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

            if (Definition != null)
            {
                hash = hash * 59 + Definition.GetHashCode();
            }

            return hash;
        }
    }
}
