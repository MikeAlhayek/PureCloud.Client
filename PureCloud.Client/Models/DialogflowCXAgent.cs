using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DialogflowCXAgent
/// </summary>
[DataContract]
public partial class DialogflowCXAgent : IEquatable<DialogflowCXAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialogflowCXAgent" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Project">The project this Dialogflow CX agent belongs to..</param>
    /// <param name="Languages">The supported languages of the Dialogflow CX agent.  Each value will be a language code in the country-locale format. e.g. en-us, es-us, fr-ca, etc..</param>
    /// <param name="Environments">Available environments for this CX agent..</param>
    /// <param name="Integration">The Integration this Dialogflow CX agent was referenced from..</param>
    public DialogflowCXAgent(string Name = null, DialogflowCXProject Project = null, List<string> Languages = null, List<DialogflowCXEnvironment> Environments = null, DomainEntityRef Integration = null)
    {
        this.Name = Name;
        this.Project = Project;
        this.Languages = Languages;
        this.Environments = Environments;
        this.Integration = Integration;

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
    /// The project this Dialogflow CX agent belongs to.
    /// </summary>
    /// <value>The project this Dialogflow CX agent belongs to.</value>
    [DataMember(Name = "project", EmitDefaultValue = false)]
    public DialogflowCXProject Project { get; set; }



    /// <summary>
    /// The supported languages of the Dialogflow CX agent.  Each value will be a language code in the country-locale format. e.g. en-us, es-us, fr-ca, etc.
    /// </summary>
    /// <value>The supported languages of the Dialogflow CX agent.  Each value will be a language code in the country-locale format. e.g. en-us, es-us, fr-ca, etc.</value>
    [DataMember(Name = "languages", EmitDefaultValue = false)]
    public List<string> Languages { get; set; }



    /// <summary>
    /// Available environments for this CX agent.
    /// </summary>
    /// <value>Available environments for this CX agent.</value>
    [DataMember(Name = "environments", EmitDefaultValue = false)]
    public List<DialogflowCXEnvironment> Environments { get; set; }



    /// <summary>
    /// The Integration this Dialogflow CX agent was referenced from.
    /// </summary>
    /// <value>The Integration this Dialogflow CX agent was referenced from.</value>
    [DataMember(Name = "integration", EmitDefaultValue = false)]
    public DomainEntityRef Integration { get; set; }



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
        sb.Append("class DialogflowCXAgent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Project: ").Append(Project).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  Environments: ").Append(Environments).Append("\n");
        sb.Append("  Integration: ").Append(Integration).Append("\n");
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
        return Equals(obj as DialogflowCXAgent);
    }

    /// <summary>
    /// Returns true if DialogflowCXAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of DialogflowCXAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialogflowCXAgent other)
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
                Project == other.Project ||
                Project != null &&
                Project.Equals(other.Project)
            ) &&
            (
                Languages == other.Languages ||
                Languages != null &&
                Languages.SequenceEqual(other.Languages)
            ) &&
            (
                Environments == other.Environments ||
                Environments != null &&
                Environments.SequenceEqual(other.Environments)
            ) &&
            (
                Integration == other.Integration ||
                Integration != null &&
                Integration.Equals(other.Integration)
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

            if (Project != null)
            {
                hash = hash * 59 + Project.GetHashCode();
            }

            if (Languages != null)
            {
                hash = hash * 59 + Languages.GetHashCode();
            }

            if (Environments != null)
            {
                hash = hash * 59 + Environments.GetHashCode();
            }

            if (Integration != null)
            {
                hash = hash * 59 + Integration.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
