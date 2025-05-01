using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmMoveManagementUnitTopicMoveManagementUnitNotification
/// </summary>
[DataContract]
public partial class WfmMoveManagementUnitTopicMoveManagementUnitNotification : IEquatable<WfmMoveManagementUnitTopicMoveManagementUnitNotification>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmMoveManagementUnitTopicMoveManagementUnitNotification" /> class.
    /// </summary>
    /// <param name="BusinessUnit">BusinessUnit.</param>
    /// <param name="Status">Status.</param>
    public WfmMoveManagementUnitTopicMoveManagementUnitNotification(WfmMoveManagementUnitTopicBusinessUnit BusinessUnit = null, StatusEnum? Status = null)
    {
        this.BusinessUnit = BusinessUnit;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    [DataMember(Name = "businessUnit", EmitDefaultValue = false)]
    public WfmMoveManagementUnitTopicBusinessUnit BusinessUnit { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmMoveManagementUnitTopicMoveManagementUnitNotification {\n");

        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as WfmMoveManagementUnitTopicMoveManagementUnitNotification);
    }

    /// <summary>
    /// Returns true if WfmMoveManagementUnitTopicMoveManagementUnitNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmMoveManagementUnitTopicMoveManagementUnitNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmMoveManagementUnitTopicMoveManagementUnitNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
