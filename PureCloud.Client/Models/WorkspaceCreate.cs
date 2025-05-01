using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkspaceCreate
/// </summary>
[DataContract]
public partial class WorkspaceCreate : IEquatable<WorkspaceCreate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkspaceCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceCreate" /> class.
    /// </summary>
    /// <param name="Name">The workspace name (required).</param>
    /// <param name="Bucket">Bucket.</param>
    /// <param name="Description">Description.</param>
    public WorkspaceCreate(string Name = null, string Bucket = null, string Description = null)
    {
        this.Name = Name;
        this.Bucket = Bucket;
        this.Description = Description;

    }



    /// <summary>
    /// The workspace name
    /// </summary>
    /// <value>The workspace name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Bucket
    /// </summary>
    [DataMember(Name = "bucket", EmitDefaultValue = false)]
    public string Bucket { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkspaceCreate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Bucket: ").Append(Bucket).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as WorkspaceCreate);
    }

    /// <summary>
    /// Returns true if WorkspaceCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkspaceCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkspaceCreate other)
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
                Bucket == other.Bucket ||
                Bucket != null &&
                Bucket.Equals(other.Bucket)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (Bucket != null)
            {
                hash = hash * 59 + Bucket.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            return hash;
        }
    }
}
