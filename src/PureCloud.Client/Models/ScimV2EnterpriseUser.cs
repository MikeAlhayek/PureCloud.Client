using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM enterprise user.
/// </summary>

public sealed class ScimV2EnterpriseUser
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2EnterpriseUser" /> class.
    /// </summary>
    /// <param name="Division">The division that the user belongs to..</param>
    /// <param name="Department">The department that the user belongs to..</param>
    /// <param name="Manager">The user&#39;s manager..</param>
    /// <param name="EmployeeNumber">The user&#39;s employee number..</param>
    /// <param name="DateHire">The user&#39;s hire date. Format in JSON will be YYYY-MM-DD..</param>



    /// <summary>
    /// The division that the user belongs to.
    /// </summary>
    /// <value>The division that the user belongs to.</value>
    public string Division { get; set; }



    /// <summary>
    /// The department that the user belongs to.
    /// </summary>
    /// <value>The department that the user belongs to.</value>
    public string Department { get; set; }



    /// <summary>
    /// The user&#39;s manager.
    /// </summary>
    /// <value>The user&#39;s manager.</value>
    public Manager Manager { get; set; }



    /// <summary>
    /// The user&#39;s employee number.
    /// </summary>
    /// <value>The user&#39;s employee number.</value>
    public string EmployeeNumber { get; set; }



    /// <summary>
    /// The user&#39;s hire date. Format in JSON will be YYYY-MM-DD.
    /// </summary>
    /// <value>The user&#39;s hire date. Format in JSON will be YYYY-MM-DD.</value>
    public string DateHire { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if ScimV2EnterpriseUser instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2EnterpriseUser to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
