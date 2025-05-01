using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EmployerInfo
/// </summary>
[DataContract]
public partial class EmployerInfo : IEquatable<EmployerInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployerInfo" /> class.
    /// </summary>
    /// <param name="OfficialName">OfficialName.</param>
    /// <param name="EmployeeId">EmployeeId.</param>
    /// <param name="EmployeeType">EmployeeType.</param>
    /// <param name="DateHire">DateHire.</param>
    public EmployerInfo(string OfficialName = null, string EmployeeId = null, string EmployeeType = null, string DateHire = null)
    {
        this.OfficialName = OfficialName;
        this.EmployeeId = EmployeeId;
        this.EmployeeType = EmployeeType;
        this.DateHire = DateHire;

    }



    /// <summary>
    /// Gets or Sets OfficialName
    /// </summary>
    [DataMember(Name = "officialName", EmitDefaultValue = false)]
    public string OfficialName { get; set; }



    /// <summary>
    /// Gets or Sets EmployeeId
    /// </summary>
    [DataMember(Name = "employeeId", EmitDefaultValue = false)]
    public string EmployeeId { get; set; }



    /// <summary>
    /// Gets or Sets EmployeeType
    /// </summary>
    [DataMember(Name = "employeeType", EmitDefaultValue = false)]
    public string EmployeeType { get; set; }



    /// <summary>
    /// Gets or Sets DateHire
    /// </summary>
    [DataMember(Name = "dateHire", EmitDefaultValue = false)]
    public string DateHire { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmployerInfo {\n");

        sb.Append("  OfficialName: ").Append(OfficialName).Append("\n");
        sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
        sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
        sb.Append("  DateHire: ").Append(DateHire).Append("\n");
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
        return Equals(obj as EmployerInfo);
    }

    /// <summary>
    /// Returns true if EmployerInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of EmployerInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmployerInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OfficialName == other.OfficialName ||
                OfficialName != null &&
                OfficialName.Equals(other.OfficialName)
            ) &&
            (
                EmployeeId == other.EmployeeId ||
                EmployeeId != null &&
                EmployeeId.Equals(other.EmployeeId)
            ) &&
            (
                EmployeeType == other.EmployeeType ||
                EmployeeType != null &&
                EmployeeType.Equals(other.EmployeeType)
            ) &&
            (
                DateHire == other.DateHire ||
                DateHire != null &&
                DateHire.Equals(other.DateHire)
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
            if (OfficialName != null)
            {
                hash = hash * 59 + OfficialName.GetHashCode();
            }

            if (EmployeeId != null)
            {
                hash = hash * 59 + EmployeeId.GetHashCode();
            }

            if (EmployeeType != null)
            {
                hash = hash * 59 + EmployeeType.GetHashCode();
            }

            if (DateHire != null)
            {
                hash = hash * 59 + DateHire.GetHashCode();
            }

            return hash;
        }
    }
}
