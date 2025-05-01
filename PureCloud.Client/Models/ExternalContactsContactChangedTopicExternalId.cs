using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactChangedTopicExternalId
/// </summary>
[DataContract]
public partial class ExternalContactsContactChangedTopicExternalId : IEquatable<ExternalContactsContactChangedTopicExternalId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicExternalId" /> class.
    /// </summary>
    /// <param name="ExternalSource">ExternalSource.</param>
    /// <param name="Value">Value.</param>
    public ExternalContactsContactChangedTopicExternalId(ExternalContactsContactChangedTopicExternalSource ExternalSource = null, string Value = null)
    {
        this.ExternalSource = ExternalSource;
        this.Value = Value;

    }



    /// <summary>
    /// Gets or Sets ExternalSource
    /// </summary>
    [DataMember(Name = "externalSource", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicExternalSource ExternalSource { get; set; }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsContactChangedTopicExternalId {\n");

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
        return Equals(obj as ExternalContactsContactChangedTopicExternalId);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactChangedTopicExternalId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactChangedTopicExternalId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactChangedTopicExternalId other)
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
