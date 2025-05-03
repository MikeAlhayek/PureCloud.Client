using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneChangeTopicPhone
/// </summary>

public partial class PhoneChangeTopicPhone : IEquatable<PhoneChangeTopicPhone>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneChangeTopicPhone" /> class.
    /// </summary>
    /// <param name="UserAgentInfo">UserAgentInfo.</param>
    /// <param name="Id">Id.</param>
    /// <param name="Status">Status.</param>
    /// <param name="SecondaryStatus">SecondaryStatus.</param>
    public PhoneChangeTopicPhone(PhoneChangeTopicUserAgentInfo UserAgentInfo = null, string Id = null, PhoneChangeTopicPhoneStatus Status = null, PhoneChangeTopicPhoneStatus SecondaryStatus = null)
    {
        this.UserAgentInfo = UserAgentInfo;
        this.Id = Id;
        this.Status = Status;
        this.SecondaryStatus = SecondaryStatus;

    }



    /// <summary>
    /// Gets or Sets UserAgentInfo
    /// </summary>
    [JsonPropertyName("userAgentInfo")]
    public PhoneChangeTopicUserAgentInfo UserAgentInfo { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public PhoneChangeTopicPhoneStatus Status { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryStatus
    /// </summary>
    [JsonPropertyName("secondaryStatus")]
    public PhoneChangeTopicPhoneStatus SecondaryStatus { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneChangeTopicPhone {\n");

        sb.Append("  UserAgentInfo: ").Append(UserAgentInfo).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  SecondaryStatus: ").Append(SecondaryStatus).Append("\n");
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
        return Equals(obj as PhoneChangeTopicPhone);
    }

    /// <summary>
    /// Returns true if PhoneChangeTopicPhone instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneChangeTopicPhone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneChangeTopicPhone other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserAgentInfo == other.UserAgentInfo ||
                UserAgentInfo != null &&
                UserAgentInfo.Equals(other.UserAgentInfo)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                SecondaryStatus == other.SecondaryStatus ||
                SecondaryStatus != null &&
                SecondaryStatus.Equals(other.SecondaryStatus)
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
            if (UserAgentInfo != null)
            {
                hash = hash * 59 + UserAgentInfo.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SecondaryStatus != null)
            {
                hash = hash * 59 + SecondaryStatus.GetHashCode();
            }

            return hash;
        }
    }
}
