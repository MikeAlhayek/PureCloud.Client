using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// The settings for User Video
/// </summary>
[DataContract]
public partial class UserVideoSettings : IEquatable<UserVideoSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserVideoSettings" /> class.
    /// </summary>
    /// <param name="AllowCamera">whether or not user camera is allowed.</param>
    /// <param name="AllowScreenShare">whether or not user screen share is allowed.</param>
    public UserVideoSettings(bool? AllowCamera = null, bool? AllowScreenShare = null)
    {
        this.AllowCamera = AllowCamera;
        this.AllowScreenShare = AllowScreenShare;

    }



    /// <summary>
    /// whether or not user camera is allowed
    /// </summary>
    /// <value>whether or not user camera is allowed</value>
    [DataMember(Name = "allowCamera", EmitDefaultValue = false)]
    public bool? AllowCamera { get; set; }



    /// <summary>
    /// whether or not user screen share is allowed
    /// </summary>
    /// <value>whether or not user screen share is allowed</value>
    [DataMember(Name = "allowScreenShare", EmitDefaultValue = false)]
    public bool? AllowScreenShare { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserVideoSettings {\n");

        sb.Append("  AllowCamera: ").Append(AllowCamera).Append("\n");
        sb.Append("  AllowScreenShare: ").Append(AllowScreenShare).Append("\n");
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
        return Equals(obj as UserVideoSettings);
    }

    /// <summary>
    /// Returns true if UserVideoSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of UserVideoSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserVideoSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AllowCamera == other.AllowCamera ||
                AllowCamera != null &&
                AllowCamera.Equals(other.AllowCamera)
            ) &&
            (
                AllowScreenShare == other.AllowScreenShare ||
                AllowScreenShare != null &&
                AllowScreenShare.Equals(other.AllowScreenShare)
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
            if (AllowCamera != null)
            {
                hash = hash * 59 + AllowCamera.GetHashCode();
            }

            if (AllowScreenShare != null)
            {
                hash = hash * 59 + AllowScreenShare.GetHashCode();
            }

            return hash;
        }
    }
}
