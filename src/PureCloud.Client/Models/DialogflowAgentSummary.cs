using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialogflowAgentSummary
/// </summary>

public partial class DialogflowAgentSummary : IEquatable<DialogflowAgentSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialogflowAgentSummary" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Project">The project this Dialogflow agent belongs to..</param>
    /// <param name="Description">A description of the Dialogflow agent..</param>
    /// <param name="Integration">The Integration this Dialogflow agent was referenced from..</param>
    public DialogflowAgentSummary(string Name = null, DialogflowProject Project = null, string Description = null, DomainEntityRef Integration = null)
    {
        this.Name = Name;
        this.Project = Project;
        this.Description = Description;
        this.Integration = Integration;

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
    /// The project this Dialogflow agent belongs to.
    /// </summary>
    /// <value>The project this Dialogflow agent belongs to.</value>
    [JsonPropertyName("project")]
    public DialogflowProject Project { get; set; }



    /// <summary>
    /// A description of the Dialogflow agent.
    /// </summary>
    /// <value>A description of the Dialogflow agent.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The Integration this Dialogflow agent was referenced from.
    /// </summary>
    /// <value>The Integration this Dialogflow agent was referenced from.</value>
    [JsonPropertyName("integration")]
    public DomainEntityRef Integration { get; set; }



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
        sb.Append("class DialogflowAgentSummary {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Project: ").Append(Project).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as DialogflowAgentSummary);
    }

    /// <summary>
    /// Returns true if DialogflowAgentSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of DialogflowAgentSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialogflowAgentSummary other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
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
