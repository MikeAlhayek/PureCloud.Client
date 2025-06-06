using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkbinCreate
/// </summary>

public partial class WorkbinCreate : IEquatable<WorkbinCreate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkbinCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkbinCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkbinCreate" /> class.
    /// </summary>
    /// <param name="Name">Workbin name. Valid length between 3 and 256 characters. (required).</param>
    /// <param name="Description">Workbin description. Maximum length of 512 characters..</param>
    /// <param name="DivisionId">The ID of the division the Workbin belongs to. Defaults to home division ID..</param>
    public WorkbinCreate(string Name = null, string Description = null, string DivisionId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.DivisionId = DivisionId;

    }



    /// <summary>
    /// Workbin name. Valid length between 3 and 256 characters.
    /// </summary>
    /// <value>Workbin name. Valid length between 3 and 256 characters.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Workbin description. Maximum length of 512 characters.
    /// </summary>
    /// <value>Workbin description. Maximum length of 512 characters.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the division the Workbin belongs to. Defaults to home division ID.
    /// </summary>
    /// <value>The ID of the division the Workbin belongs to. Defaults to home division ID.</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkbinCreate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
        return Equals(obj as WorkbinCreate);
    }

    /// <summary>
    /// Returns true if WorkbinCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkbinCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkbinCreate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            return hash;
        }
    }
}
