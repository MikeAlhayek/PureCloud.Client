using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicExternalId
/// </summary>

public partial class ExternalContactsUnresolvedContactChangedTopicExternalId : IEquatable<ExternalContactsUnresolvedContactChangedTopicExternalId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicExternalId" /> class.
    /// </summary>
    /// <param name="ExternalSource">ExternalSource.</param>
    /// <param name="Value">Value.</param>
    public ExternalContactsUnresolvedContactChangedTopicExternalId(ExternalContactsUnresolvedContactChangedTopicExternalSource ExternalSource = null, string Value = null)
    {
        this.ExternalSource = ExternalSource;
        this.Value = Value;

    }



    /// <summary>
    /// Gets or Sets ExternalSource
    /// </summary>
    [JsonPropertyName("externalSource")]
    public ExternalContactsUnresolvedContactChangedTopicExternalSource ExternalSource { get; set; }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicExternalId {\n");

        sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
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
        return Equals(obj as ExternalContactsUnresolvedContactChangedTopicExternalId);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicExternalId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicExternalId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicExternalId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExternalSource == other.ExternalSource ||
                ExternalSource != null &&
                ExternalSource.Equals(other.ExternalSource)
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
            if (ExternalSource != null)
            {
                hash = hash * 59 + ExternalSource.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
