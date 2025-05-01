using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DataRange
/// </summary>
[DataContract]
public partial class DataRange : IEquatable<DataRange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataRange" /> class.
    /// </summary>
    public DataRange()
    {

    }



    /// <summary>
    /// The first event timestamp found. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The first event timestamp found. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateMin", EmitDefaultValue = false)]
    public DateTime? DateMin { get; private set; }



    /// <summary>
    /// The last event timestamp found. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last event timestamp found. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateMax", EmitDefaultValue = false)]
    public DateTime? DateMax { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataRange {\n");

        sb.Append("  DateMin: ").Append(DateMin).Append("\n");
        sb.Append("  DateMax: ").Append(DateMax).Append("\n");
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
        return Equals(obj as DataRange);
    }

    /// <summary>
    /// Returns true if DataRange instances are equal
    /// </summary>
    /// <param name="other">Instance of DataRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataRange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateMin == other.DateMin ||
                DateMin != null &&
                DateMin.Equals(other.DateMin)
            ) &&
            (
                DateMax == other.DateMax ||
                DateMax != null &&
                DateMax.Equals(other.DateMax)
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
            if (DateMin != null)
            {
                hash = hash * 59 + DateMin.GetHashCode();
            }

            if (DateMax != null)
            {
                hash = hash * 59 + DateMax.GetHashCode();
            }

            return hash;
        }
    }
}
