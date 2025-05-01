using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DateRangeWithOptionalEnd
/// </summary>
[DataContract]
public partial class DateRangeWithOptionalEnd : IEquatable<DateRangeWithOptionalEnd>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DateRangeWithOptionalEnd" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DateRangeWithOptionalEnd() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DateRangeWithOptionalEnd" /> class.
    /// </summary>
    /// <param name="StartBusinessUnitDate">The start date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="EndBusinessUnitDate">The end date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Null denotes open ended date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public DateRangeWithOptionalEnd(string StartBusinessUnitDate = null, string EndBusinessUnitDate = null)
    {
        this.StartBusinessUnitDate = StartBusinessUnitDate;
        this.EndBusinessUnitDate = EndBusinessUnitDate;

    }



    /// <summary>
    /// The start date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "startBusinessUnitDate", EmitDefaultValue = false)]
    public string StartBusinessUnitDate { get; set; }



    /// <summary>
    /// The end date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Null denotes open ended date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The end date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Null denotes open ended date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "endBusinessUnitDate", EmitDefaultValue = false)]
    public string EndBusinessUnitDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DateRangeWithOptionalEnd {\n");

        sb.Append("  StartBusinessUnitDate: ").Append(StartBusinessUnitDate).Append("\n");
        sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
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
        return Equals(obj as DateRangeWithOptionalEnd);
    }

    /// <summary>
    /// Returns true if DateRangeWithOptionalEnd instances are equal
    /// </summary>
    /// <param name="other">Instance of DateRangeWithOptionalEnd to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DateRangeWithOptionalEnd other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartBusinessUnitDate == other.StartBusinessUnitDate ||
                StartBusinessUnitDate != null &&
                StartBusinessUnitDate.Equals(other.StartBusinessUnitDate)
            ) &&
            (
                EndBusinessUnitDate == other.EndBusinessUnitDate ||
                EndBusinessUnitDate != null &&
                EndBusinessUnitDate.Equals(other.EndBusinessUnitDate)
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
            if (StartBusinessUnitDate != null)
            {
                hash = hash * 59 + StartBusinessUnitDate.GetHashCode();
            }

            if (EndBusinessUnitDate != null)
            {
                hash = hash * 59 + EndBusinessUnitDate.GetHashCode();
            }

            return hash;
        }
    }
}
