using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PlanningGroup
/// </summary>

public partial class PlanningGroup : IEquatable<PlanningGroup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanningGroup" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ServiceGoalTemplate">The ID of the service goal template associated with this planning group.</param>
    /// <param name="RoutePaths">Set of route paths associated with the planning group.</param>
    /// <param name="Metadata">Version metadata for the planning group.</param>
    public PlanningGroup(string Name = null, ServiceGoalTemplateReference ServiceGoalTemplate = null, List<RoutePathResponse> RoutePaths = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.ServiceGoalTemplate = ServiceGoalTemplate;
        this.RoutePaths = RoutePaths;
        this.Metadata = Metadata;

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
    /// The ID of the service goal template associated with this planning group
    /// </summary>
    /// <value>The ID of the service goal template associated with this planning group</value>
    [JsonPropertyName("serviceGoalTemplate")]
    public ServiceGoalTemplateReference ServiceGoalTemplate { get; set; }



    /// <summary>
    /// Set of route paths associated with the planning group
    /// </summary>
    /// <value>Set of route paths associated with the planning group</value>
    [JsonPropertyName("routePaths")]
    public List<RoutePathResponse> RoutePaths { get; set; }



    /// <summary>
    /// Version metadata for the planning group
    /// </summary>
    /// <value>Version metadata for the planning group</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



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
        sb.Append("class PlanningGroup {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ServiceGoalTemplate: ").Append(ServiceGoalTemplate).Append("\n");
        sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as PlanningGroup);
    }

    /// <summary>
    /// Returns true if PlanningGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of PlanningGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PlanningGroup other)
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
                ServiceGoalTemplate == other.ServiceGoalTemplate ||
                ServiceGoalTemplate != null &&
                ServiceGoalTemplate.Equals(other.ServiceGoalTemplate)
            ) &&
            (
                RoutePaths == other.RoutePaths ||
                RoutePaths != null &&
                RoutePaths.SequenceEqual(other.RoutePaths)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (ServiceGoalTemplate != null)
            {
                hash = hash * 59 + ServiceGoalTemplate.GetHashCode();
            }

            if (RoutePaths != null)
            {
                hash = hash * 59 + RoutePaths.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
