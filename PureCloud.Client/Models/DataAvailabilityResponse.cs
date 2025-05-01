using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// DataAvailabilityResponse
/// </summary>
[DataContract]
public partial class DataAvailabilityResponse : IEquatable<DataAvailabilityResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataAvailabilityResponse" /> class.
    /// </summary>
    /// <param name="DataAvailabilityDate">Date and time before which data is guaranteed to be available in the datalake. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public DataAvailabilityResponse(DateTime? DataAvailabilityDate = null)
    {
        this.DataAvailabilityDate = DataAvailabilityDate;

    }



    /// <summary>
    /// Date and time before which data is guaranteed to be available in the datalake. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time before which data is guaranteed to be available in the datalake. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dataAvailabilityDate", EmitDefaultValue = false)]
    public DateTime? DataAvailabilityDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataAvailabilityResponse {\n");

        sb.Append("  DataAvailabilityDate: ").Append(DataAvailabilityDate).Append("\n");
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
        return this.Equals(obj as DataAvailabilityResponse);
    }

    /// <summary>
    /// Returns true if DataAvailabilityResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of DataAvailabilityResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataAvailabilityResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DataAvailabilityDate == other.DataAvailabilityDate ||
                this.DataAvailabilityDate != null &&
                this.DataAvailabilityDate.Equals(other.DataAvailabilityDate)
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
            if (this.DataAvailabilityDate != null)
            {
                hash = hash * 59 + this.DataAvailabilityDate.GetHashCode();
            }

            return hash;
        }
    }
}
