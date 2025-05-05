using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TemplateParameter
/// </summary>

public partial class TemplateParameter : IEquatable<TemplateParameter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TemplateParameter" /> class.
    /// </summary>
    /// <param name="Id">Response substitution identifier.</param>
    /// <param name="Value">Response substitution value.</param>
    public TemplateParameter(string Id = null, string Value = null)
    {
        this.Id = Id;
        this.Value = Value;

    }



    /// <summary>
    /// Response substitution identifier
    /// </summary>
    /// <value>Response substitution identifier</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Response substitution value
    /// </summary>
    /// <value>Response substitution value</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TemplateParameter {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as TemplateParameter);
    }

    /// <summary>
    /// Returns true if TemplateParameter instances are equal
    /// </summary>
    /// <param name="other">Instance of TemplateParameter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TemplateParameter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
