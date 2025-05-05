using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreatePlanningGroupRequest
/// </summary>

public partial class CreatePlanningGroupRequest : IEquatable<CreatePlanningGroupRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreatePlanningGroupRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreatePlanningGroupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreatePlanningGroupRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the planning group (required).</param>
    /// <param name="RoutePaths">Set of route paths to associate with the planning group (required).</param>
    /// <param name="ServiceGoalTemplateId">The ID of the service goal template to associate with this planning group (required).</param>
    public CreatePlanningGroupRequest(string Name = null, List<RoutePathRequest> RoutePaths = null, string ServiceGoalTemplateId = null)
    {
        this.Name = Name;
        this.RoutePaths = RoutePaths;
        this.ServiceGoalTemplateId = ServiceGoalTemplateId;

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
    public List<RoutePathRequest> RoutePaths { get; set; }



    /// <summary>
    /// The ID of the service goal template to associate with this planning group
    /// </summary>
    /// <value>The ID of the service goal template to associate with this planning group</value>
    [JsonPropertyName("serviceGoalTemplateId")]
    public string ServiceGoalTemplateId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreatePlanningGroupRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
        sb.Append("  ServiceGoalTemplateId: ").Append(ServiceGoalTemplateId).Append("\n");
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
        return Equals(obj as CreatePlanningGroupRequest);
    }

    /// <summary>
    /// Returns true if CreatePlanningGroupRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreatePlanningGroupRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreatePlanningGroupRequest other)
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
                RoutePaths.SequenceEqual(other.RoutePaths)
            ) &&
            (
                ServiceGoalTemplateId == other.ServiceGoalTemplateId ||
                ServiceGoalTemplateId != null &&
                ServiceGoalTemplateId.Equals(other.ServiceGoalTemplateId)
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

            return hash;
        }
    }
}
