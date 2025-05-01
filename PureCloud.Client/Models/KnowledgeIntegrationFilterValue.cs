using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeIntegrationFilterValue
/// </summary>
[DataContract]
public partial class KnowledgeIntegrationFilterValue : IEquatable<KnowledgeIntegrationFilterValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeIntegrationFilterValue" /> class.
    /// </summary>
    /// <param name="Key">The key that can be used as a value of a filter setting in a knowledge source..</param>
    /// <param name="Value">The display label of the filter value..</param>
    public KnowledgeIntegrationFilterValue(string Key = null, string Value = null)
    {
        this.Key = Key;
        this.Value = Value;

    }



    /// <summary>
    /// The key that can be used as a value of a filter setting in a knowledge source.
    /// </summary>
    /// <value>The key that can be used as a value of a filter setting in a knowledge source.</value>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }



    /// <summary>
    /// The display label of the filter value.
    /// </summary>
    /// <value>The display label of the filter value.</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeIntegrationFilterValue {\n");

        sb.Append("  Key: ").Append(Key).Append("\n");
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
        return Equals(obj as KnowledgeIntegrationFilterValue);
    }

    /// <summary>
    /// Returns true if KnowledgeIntegrationFilterValue instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeIntegrationFilterValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeIntegrationFilterValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
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
            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
