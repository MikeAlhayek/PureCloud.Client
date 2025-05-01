using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange
/// </summary>
[DataContract]
public partial class EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange : IEquatable<EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange(string Id = null, EdgeLogicalInterfacesChangeTopicErrorInfo ErrorInfo = null)
    {
        this.Id = Id;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [DataMember(Name = "errorInfo", EmitDefaultValue = false)]
    public EdgeLogicalInterfacesChangeTopicErrorInfo ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange);
    }

    /// <summary>
    /// Returns true if EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
