using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValueWrapperLocalDate
/// </summary>
[DataContract]
public partial class ValueWrapperLocalDate : IEquatable<ValueWrapperLocalDate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValueWrapperLocalDate" /> class.
    /// </summary>
    /// <param name="Value">The value for the associated field. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public ValueWrapperLocalDate(string Value = null)
    {
        this.Value = Value;

    }



    /// <summary>
    /// The value for the associated field. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The value for the associated field. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValueWrapperLocalDate {\n");

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
        return this.Equals(obj as ValueWrapperLocalDate);
    }

    /// <summary>
    /// Returns true if ValueWrapperLocalDate instances are equal
    /// </summary>
    /// <param name="other">Instance of ValueWrapperLocalDate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValueWrapperLocalDate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
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
            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            return hash;
        }
    }
}
