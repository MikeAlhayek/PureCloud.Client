using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SystemPrompt
/// </summary>
[DataContract]
public partial class SystemPrompt : IEquatable<SystemPrompt>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SystemPrompt" /> class.
    /// </summary>
    /// <param name="Id">The system prompt identifier.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Resources">Resources.</param>
    public SystemPrompt(string Id = null, string Name = null, string Description = null, List<SystemPromptAsset> Resources = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Resources = Resources;

    }



    /// <summary>
    /// The system prompt identifier
    /// </summary>
    /// <value>The system prompt identifier</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [DataMember(Name = "resources", EmitDefaultValue = false)]
    public List<SystemPromptAsset> Resources { get; set; }



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
        sb.Append("class SystemPrompt {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
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
        return Equals(obj as SystemPrompt);
    }

    /// <summary>
    /// Returns true if SystemPrompt instances are equal
    /// </summary>
    /// <param name="other">Instance of SystemPrompt to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SystemPrompt other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Resources == other.Resources ||
                Resources != null &&
                Resources.SequenceEqual(other.Resources)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Resources != null)
            {
                hash = hash * 59 + Resources.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
