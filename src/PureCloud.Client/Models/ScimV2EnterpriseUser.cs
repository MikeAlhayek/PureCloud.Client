using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM enterprise user.
/// </summary>

public partial class ScimV2EnterpriseUser : IEquatable<ScimV2EnterpriseUser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2EnterpriseUser" /> class.
    /// </summary>
    /// <param name="Division">The division that the user belongs to..</param>
    /// <param name="Department">The department that the user belongs to..</param>
    /// <param name="Manager">The user&#39;s manager..</param>
    /// <param name="EmployeeNumber">The user&#39;s employee number..</param>
    /// <param name="DateHire">The user&#39;s hire date. Format in JSON will be YYYY-MM-DD..</param>
    public ScimV2EnterpriseUser(string Division = null, string Department = null, Manager Manager = null, string EmployeeNumber = null, string DateHire = null)
    {
        this.Division = Division;
        this.Department = Department;
        this.Manager = Manager;
        this.EmployeeNumber = EmployeeNumber;
        this.DateHire = DateHire;

    }



    /// <summary>
    /// The division that the user belongs to.
    /// </summary>
    /// <value>The division that the user belongs to.</value>
    [JsonPropertyName("division")]
    public string Division { get; set; }



    /// <summary>
    /// The department that the user belongs to.
    /// </summary>
    /// <value>The department that the user belongs to.</value>
    [JsonPropertyName("department")]
    public string Department { get; set; }



    /// <summary>
    /// The user&#39;s manager.
    /// </summary>
    /// <value>The user&#39;s manager.</value>
    [JsonPropertyName("manager")]
    public Manager Manager { get; set; }



    /// <summary>
    /// The user&#39;s employee number.
    /// </summary>
    /// <value>The user&#39;s employee number.</value>
    [JsonPropertyName("employeeNumber")]
    public string EmployeeNumber { get; set; }



    /// <summary>
    /// The user&#39;s hire date. Format in JSON will be YYYY-MM-DD.
    /// </summary>
    /// <value>The user&#39;s hire date. Format in JSON will be YYYY-MM-DD.</value>
    [JsonPropertyName("dateHire")]
    public string DateHire { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2EnterpriseUser {\n");

        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Department: ").Append(Department).Append("\n");
        sb.Append("  Manager: ").Append(Manager).Append("\n");
        sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
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
        return Equals(obj as ScimV2EnterpriseUser);
    }

    /// <summary>
    /// Returns true if ScimV2EnterpriseUser instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2EnterpriseUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2EnterpriseUser other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Department == other.Department ||
                Department != null &&
                Department.Equals(other.Department)
            ) &&
            (
                Manager == other.Manager ||
                Manager != null &&
                Manager.Equals(other.Manager)
            ) &&
            (
                EmployeeNumber == other.EmployeeNumber ||
                EmployeeNumber != null &&
                EmployeeNumber.Equals(other.EmployeeNumber)
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
            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Department != null)
            {
                hash = hash * 59 + Department.GetHashCode();
            }

            if (Manager != null)
            {
                hash = hash * 59 + Manager.GetHashCode();
            }

            if (EmployeeNumber != null)
            {
                hash = hash * 59 + EmployeeNumber.GetHashCode();
            }

            if (DateHire != null)
            {
                hash = hash * 59 + DateHire.GetHashCode();
            }

            return hash;
        }
    }
}
