using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification
/// </summary>

public partial class UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification : IEquatable<UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification" /> class.
    /// </summary>
    /// <param name="DataAvailabilityDate">Date and time before which data is guaranteed to be available in the datalake.</param>
    public UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification(DateTime? DataAvailabilityDate = null)
    {
        this.DataAvailabilityDate = DataAvailabilityDate;

    }



    /// <summary>
    /// Date and time before which data is guaranteed to be available in the datalake
    /// </summary>
    /// <value>Date and time before which data is guaranteed to be available in the datalake</value>
    [JsonPropertyName("dataAvailabilityDate")]
    public DateTime? DataAvailabilityDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification {\n");

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
        return Equals(obj as UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification);
    }

    /// <summary>
    /// Returns true if UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DataAvailabilityDate == other.DataAvailabilityDate ||
                DataAvailabilityDate != null &&
                DataAvailabilityDate.Equals(other.DataAvailabilityDate)
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
            if (DataAvailabilityDate != null)
            {
                hash = hash * 59 + DataAvailabilityDate.GetHashCode();
            }

            return hash;
        }
    }
}
