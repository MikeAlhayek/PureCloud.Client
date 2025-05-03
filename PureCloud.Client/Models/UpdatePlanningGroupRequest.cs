using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdatePlanningGroupRequest
/// </summary>

public partial class UpdatePlanningGroupRequest : IEquatable<UpdatePlanningGroupRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdatePlanningGroupRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdatePlanningGroupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdatePlanningGroupRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the planning group.</param>
    /// <param name="RoutePaths">Set of route paths to associate with the planning group.</param>
    /// <param name="ServiceGoalTemplateId">The ID of the service goal template to associate with this planning group.</param>
    /// <param name="Metadata">Version metadata for the planning group (required).</param>
    public UpdatePlanningGroupRequest(string Name = null, SetWrapperRoutePathRequest RoutePaths = null, string ServiceGoalTemplateId = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.RoutePaths = RoutePaths;
        this.ServiceGoalTemplateId = ServiceGoalTemplateId;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The name of the planning group
    /// </summary>
    /// <value>The name of the planning group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Set of route paths to associate with the planning group
    /// </summary>
    /// <value>Set of route paths to associate with the planning group</value>
    [JsonPropertyName("routePaths")]
    public SetWrapperRoutePathRequest RoutePaths { get; set; }



    /// <summary>
    /// The ID of the service goal template to associate with this planning group
    /// </summary>
    /// <value>The ID of the service goal template to associate with this planning group</value>
    [JsonPropertyName("serviceGoalTemplateId")]
    public string ServiceGoalTemplateId { get; set; }



    /// <summary>
    /// Version metadata for the planning group
    /// </summary>
    /// <value>Version metadata for the planning group</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdatePlanningGroupRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
        sb.Append("  ServiceGoalTemplateId: ").Append(ServiceGoalTemplateId).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as UpdatePlanningGroupRequest);
    }

    /// <summary>
    /// Returns true if UpdatePlanningGroupRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdatePlanningGroupRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdatePlanningGroupRequest other)
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
                RoutePaths == other.RoutePaths ||
                RoutePaths != null &&
                RoutePaths.Equals(other.RoutePaths)
            ) &&
            (
                ServiceGoalTemplateId == other.ServiceGoalTemplateId ||
                ServiceGoalTemplateId != null &&
                ServiceGoalTemplateId.Equals(other.ServiceGoalTemplateId)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (RoutePaths != null)
            {
                hash = hash * 59 + RoutePaths.GetHashCode();
            }

            if (ServiceGoalTemplateId != null)
            {
                hash = hash * 59 + ServiceGoalTemplateId.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
