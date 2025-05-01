using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Education
/// </summary>
[DataContract]
public partial class Education : IEquatable<Education>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Education" /> class.
    /// </summary>
    /// <param name="School">School.</param>
    /// <param name="FieldOfStudy">FieldOfStudy.</param>
    /// <param name="Notes">Notes about education has a 2000 character limit.</param>
    /// <param name="DateStart">Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="DateEnd">Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public Education(string School = null, string FieldOfStudy = null, string Notes = null, string DateStart = null, string DateEnd = null)
    {
        this.School = School;
        this.FieldOfStudy = FieldOfStudy;
        this.Notes = Notes;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;

    }



    /// <summary>
    /// Gets or Sets School
    /// </summary>
    [DataMember(Name = "school", EmitDefaultValue = false)]
    public string School { get; set; }



    /// <summary>
    /// Gets or Sets FieldOfStudy
    /// </summary>
    [DataMember(Name = "fieldOfStudy", EmitDefaultValue = false)]
    public string FieldOfStudy { get; set; }



    /// <summary>
    /// Notes about education has a 2000 character limit
    /// </summary>
    /// <value>Notes about education has a 2000 character limit</value>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public string DateStart { get; set; }



    /// <summary>
    /// Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public string DateEnd { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Education {\n");

        sb.Append("  School: ").Append(School).Append("\n");
        sb.Append("  FieldOfStudy: ").Append(FieldOfStudy).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
        return Equals(obj as Education);
    }

    /// <summary>
    /// Returns true if Education instances are equal
    /// </summary>
    /// <param name="other">Instance of Education to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Education other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                School == other.School ||
                School != null &&
                School.Equals(other.School)
            ) &&
            (
                FieldOfStudy == other.FieldOfStudy ||
                FieldOfStudy != null &&
                FieldOfStudy.Equals(other.FieldOfStudy)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
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
            if (School != null)
            {
                hash = hash * 59 + School.GetHashCode();
            }

            if (FieldOfStudy != null)
            {
                hash = hash * 59 + FieldOfStudy.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            return hash;
        }
    }
}
