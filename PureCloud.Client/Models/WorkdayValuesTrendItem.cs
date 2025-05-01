using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayValuesTrendItem
/// </summary>
[DataContract]
public partial class WorkdayValuesTrendItem : IEquatable<WorkdayValuesTrendItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayValuesTrendItem" /> class.
    /// </summary>
    public WorkdayValuesTrendItem()
    {

    }



    /// <summary>
    /// The workday for the metric value. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The workday for the metric value. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateWorkday", EmitDefaultValue = false)]
    public string DateWorkday { get; private set; }



    /// <summary>
    /// The metric value
    /// </summary>
    /// <value>The metric value</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public double? Value { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayValuesTrendItem {\n");

        sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
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
        return Equals(obj as WorkdayValuesTrendItem);
    }

    /// <summary>
    /// Returns true if WorkdayValuesTrendItem instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayValuesTrendItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayValuesTrendItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateWorkday == other.DateWorkday ||
                DateWorkday != null &&
                DateWorkday.Equals(other.DateWorkday)
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
            if (DateWorkday != null)
            {
                hash = hash * 59 + DateWorkday.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
