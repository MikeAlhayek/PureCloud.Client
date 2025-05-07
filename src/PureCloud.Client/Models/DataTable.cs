using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Contains a metadata representation for a JSON schema stored in DataTables along with an optional field for the schema itself
/// </summary>

public partial class DataTable : IEquatable<DataTable>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataTable" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The description from the JSON schema (equates to the Description field on the JSON schema.).</param>
    /// <param name="Schema">the schema as stored in the system..</param>
    public DataTable(string Name = null, WritableDivision Division = null, string Description = null, JsonSchemaDocument Schema = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Schema = Schema;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// The description from the JSON schema (equates to the Description field on the JSON schema.)
    /// </summary>
    /// <value>The description from the JSON schema (equates to the Description field on the JSON schema.)</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// the schema as stored in the system.
    /// </summary>
    /// <value>the schema as stored in the system.</value>
    [JsonPropertyName("schema")]
    public JsonSchemaDocument Schema { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataTable {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
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
        return Equals(obj as DataTable);
    }

    /// <summary>
    /// Returns true if DataTable instances are equal
    /// </summary>
    /// <param name="other">Instance of DataTable to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataTable other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
