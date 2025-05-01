using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FieldConfigs
/// </summary>
[DataContract]
public partial class FieldConfigs : IEquatable<FieldConfigs>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FieldConfigs" /> class.
    /// </summary>
    /// <param name="Org">Org.</param>
    /// <param name="Person">Person.</param>
    /// <param name="Group">Group.</param>
    public FieldConfigs(FieldConfig Org = null, FieldConfig Person = null, FieldConfig Group = null)
    {
        this.Org = Org;
        this.Person = Person;
        this.Group = Group;

    }



    /// <summary>
    /// Gets or Sets Org
    /// </summary>
    [DataMember(Name = "org", EmitDefaultValue = false)]
    public FieldConfig Org { get; set; }



    /// <summary>
    /// Gets or Sets Person
    /// </summary>
    [DataMember(Name = "person", EmitDefaultValue = false)]
    public FieldConfig Person { get; set; }



    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name = "group", EmitDefaultValue = false)]
    public FieldConfig Group { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FieldConfigs {\n");

        sb.Append("  Org: ").Append(Org).Append("\n");
        sb.Append("  Person: ").Append(Person).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
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
        return Equals(obj as FieldConfigs);
    }

    /// <summary>
    /// Returns true if FieldConfigs instances are equal
    /// </summary>
    /// <param name="other">Instance of FieldConfigs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FieldConfigs other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Org == other.Org ||
                Org != null &&
                Org.Equals(other.Org)
            ) &&
            (
                Person == other.Person ||
                Person != null &&
                Person.Equals(other.Person)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
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
            if (Org != null)
            {
                hash = hash * 59 + Org.GetHashCode();
            }

            if (Person != null)
            {
                hash = hash * 59 + Person.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            return hash;
        }
    }
}
