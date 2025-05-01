using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkJobAddWorkitemSummary
/// </summary>
[DataContract]
public partial class BulkJobAddWorkitemSummary : IEquatable<BulkJobAddWorkitemSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkJobAddWorkitemSummary" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Workbin">The workbin of the workitem..</param>
    /// <param name="Type">The worktype of the workitem..</param>
    public BulkJobAddWorkitemSummary(string Name = null, WorkbinReference Workbin = null, WorktypeReference Type = null)
    {
        this.Name = Name;
        this.Workbin = Workbin;
        this.Type = Type;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The workbin of the workitem.
    /// </summary>
    /// <value>The workbin of the workitem.</value>
    [DataMember(Name = "workbin", EmitDefaultValue = false)]
    public WorkbinReference Workbin { get; set; }



    /// <summary>
    /// The worktype of the workitem.
    /// </summary>
    /// <value>The worktype of the workitem.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public WorktypeReference Type { get; set; }



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
        sb.Append("class BulkJobAddWorkitemSummary {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Workbin: ").Append(Workbin).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as BulkJobAddWorkitemSummary);
    }

    /// <summary>
    /// Returns true if BulkJobAddWorkitemSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkJobAddWorkitemSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkJobAddWorkitemSummary other)
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
                Workbin == other.Workbin ||
                Workbin != null &&
                Workbin.Equals(other.Workbin)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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

            if (Workbin != null)
            {
                hash = hash * 59 + Workbin.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
