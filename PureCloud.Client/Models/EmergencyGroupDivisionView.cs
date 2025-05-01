using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A group of call flows.
/// </summary>
[DataContract]
public partial class EmergencyGroupDivisionView : IEquatable<EmergencyGroupDivisionView>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EmergencyGroupDivisionView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmergencyGroupDivisionView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmergencyGroupDivisionView" /> class.
    /// </summary>
    /// <param name="Id">The emergency group identifier.</param>
    /// <param name="Name">The emergency group name (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    public EmergencyGroupDivisionView(string Id = null, string Name = null, WritableDivision Division = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Division = Division;

    }



    /// <summary>
    /// The emergency group identifier
    /// </summary>
    /// <value>The emergency group identifier</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The emergency group name
    /// </summary>
    /// <value>The emergency group name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmergencyGroupDivisionView {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as EmergencyGroupDivisionView);
    }

    /// <summary>
    /// Returns true if EmergencyGroupDivisionView instances are equal
    /// </summary>
    /// <param name="other">Instance of EmergencyGroupDivisionView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmergencyGroupDivisionView other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
