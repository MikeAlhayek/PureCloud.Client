using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserRoutingStatusUserRoutingStatus
/// </summary>
[DataContract]
public partial class UserRoutingStatusUserRoutingStatus : IEquatable<UserRoutingStatusUserRoutingStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingStatusUserRoutingStatus" /> class.
    /// </summary>
    /// <param name="Id">The unique identifier of the user..</param>
    /// <param name="RoutingStatus">RoutingStatus.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public UserRoutingStatusUserRoutingStatus(string Id = null, UserRoutingStatusRoutingStatus RoutingStatus = null, UserRoutingStatusErrorInfo ErrorInfo = null)
    {
        this.Id = Id;
        this.RoutingStatus = RoutingStatus;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    /// <value>The unique identifier of the user.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    [DataMember(Name = "routingStatus", EmitDefaultValue = false)]
    public UserRoutingStatusRoutingStatus RoutingStatus { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [DataMember(Name = "errorInfo", EmitDefaultValue = false)]
    public UserRoutingStatusErrorInfo ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserRoutingStatusUserRoutingStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
        return this.Equals(obj as UserRoutingStatusUserRoutingStatus);
    }

    /// <summary>
    /// Returns true if UserRoutingStatusUserRoutingStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of UserRoutingStatusUserRoutingStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserRoutingStatusUserRoutingStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.RoutingStatus == other.RoutingStatus ||
                this.RoutingStatus != null &&
                this.RoutingStatus.Equals(other.RoutingStatus)
            ) &&
            (
                this.ErrorInfo == other.ErrorInfo ||
                this.ErrorInfo != null &&
                this.ErrorInfo.Equals(other.ErrorInfo)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.RoutingStatus != null)
            {
                hash = hash * 59 + this.RoutingStatus.GetHashCode();
            }

            if (this.ErrorInfo != null)
            {
                hash = hash * 59 + this.ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
