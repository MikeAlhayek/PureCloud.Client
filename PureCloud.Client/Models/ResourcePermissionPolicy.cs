using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResourcePermissionPolicy
/// </summary>
[DataContract]
public partial class ResourcePermissionPolicy : IEquatable<ResourcePermissionPolicy>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResourcePermissionPolicy" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Domain">Domain.</param>
    /// <param name="EntityName">EntityName.</param>
    /// <param name="PolicyName">PolicyName.</param>
    /// <param name="PolicyDescription">PolicyDescription.</param>
    /// <param name="ActionSetKey">ActionSetKey.</param>
    /// <param name="AllowConditions">AllowConditions.</param>
    /// <param name="ResourceConditionNode">ResourceConditionNode.</param>
    /// <param name="NamedResources">NamedResources.</param>
    /// <param name="ResourceCondition">ResourceCondition.</param>
    /// <param name="ActionSet">ActionSet.</param>
    public ResourcePermissionPolicy(string Id = null, string Domain = null, string EntityName = null, string PolicyName = null, string PolicyDescription = null, string ActionSetKey = null, bool? AllowConditions = null, ResourceConditionNode ResourceConditionNode = null, List<string> NamedResources = null, string ResourceCondition = null, List<string> ActionSet = null)
    {
        this.Id = Id;
        this.Domain = Domain;
        this.EntityName = EntityName;
        this.PolicyName = PolicyName;
        this.PolicyDescription = PolicyDescription;
        this.ActionSetKey = ActionSetKey;
        this.AllowConditions = AllowConditions;
        this.ResourceConditionNode = ResourceConditionNode;
        this.NamedResources = NamedResources;
        this.ResourceCondition = ResourceCondition;
        this.ActionSet = ActionSet;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name = "domain", EmitDefaultValue = false)]
    public string Domain { get; set; }



    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    [DataMember(Name = "entityName", EmitDefaultValue = false)]
    public string EntityName { get; set; }



    /// <summary>
    /// Gets or Sets PolicyName
    /// </summary>
    [DataMember(Name = "policyName", EmitDefaultValue = false)]
    public string PolicyName { get; set; }



    /// <summary>
    /// Gets or Sets PolicyDescription
    /// </summary>
    [DataMember(Name = "policyDescription", EmitDefaultValue = false)]
    public string PolicyDescription { get; set; }



    /// <summary>
    /// Gets or Sets ActionSetKey
    /// </summary>
    [DataMember(Name = "actionSetKey", EmitDefaultValue = false)]
    public string ActionSetKey { get; set; }



    /// <summary>
    /// Gets or Sets AllowConditions
    /// </summary>
    [DataMember(Name = "allowConditions", EmitDefaultValue = false)]
    public bool? AllowConditions { get; set; }



    /// <summary>
    /// Gets or Sets ResourceConditionNode
    /// </summary>
    [DataMember(Name = "resourceConditionNode", EmitDefaultValue = false)]
    public ResourceConditionNode ResourceConditionNode { get; set; }



    /// <summary>
    /// Gets or Sets NamedResources
    /// </summary>
    [DataMember(Name = "namedResources", EmitDefaultValue = false)]
    public List<string> NamedResources { get; set; }



    /// <summary>
    /// Gets or Sets ResourceCondition
    /// </summary>
    [DataMember(Name = "resourceCondition", EmitDefaultValue = false)]
    public string ResourceCondition { get; set; }



    /// <summary>
    /// Gets or Sets ActionSet
    /// </summary>
    [DataMember(Name = "actionSet", EmitDefaultValue = false)]
    public List<string> ActionSet { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResourcePermissionPolicy {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
        sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
        sb.Append("  PolicyDescription: ").Append(PolicyDescription).Append("\n");
        sb.Append("  ActionSetKey: ").Append(ActionSetKey).Append("\n");
        sb.Append("  AllowConditions: ").Append(AllowConditions).Append("\n");
        sb.Append("  ResourceConditionNode: ").Append(ResourceConditionNode).Append("\n");
        sb.Append("  NamedResources: ").Append(NamedResources).Append("\n");
        sb.Append("  ResourceCondition: ").Append(ResourceCondition).Append("\n");
        sb.Append("  ActionSet: ").Append(ActionSet).Append("\n");
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
        return Equals(obj as ResourcePermissionPolicy);
    }

    /// <summary>
    /// Returns true if ResourcePermissionPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of ResourcePermissionPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResourcePermissionPolicy other)
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
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                EntityName == other.EntityName ||
                EntityName != null &&
                EntityName.Equals(other.EntityName)
            ) &&
            (
                PolicyName == other.PolicyName ||
                PolicyName != null &&
                PolicyName.Equals(other.PolicyName)
            ) &&
            (
                PolicyDescription == other.PolicyDescription ||
                PolicyDescription != null &&
                PolicyDescription.Equals(other.PolicyDescription)
            ) &&
            (
                ActionSetKey == other.ActionSetKey ||
                ActionSetKey != null &&
                ActionSetKey.Equals(other.ActionSetKey)
            ) &&
            (
                AllowConditions == other.AllowConditions ||
                AllowConditions != null &&
                AllowConditions.Equals(other.AllowConditions)
            ) &&
            (
                ResourceConditionNode == other.ResourceConditionNode ||
                ResourceConditionNode != null &&
                ResourceConditionNode.Equals(other.ResourceConditionNode)
            ) &&
            (
                NamedResources == other.NamedResources ||
                NamedResources != null &&
                NamedResources.SequenceEqual(other.NamedResources)
            ) &&
            (
                ResourceCondition == other.ResourceCondition ||
                ResourceCondition != null &&
                ResourceCondition.Equals(other.ResourceCondition)
            ) &&
            (
                ActionSet == other.ActionSet ||
                ActionSet != null &&
                ActionSet.SequenceEqual(other.ActionSet)
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

            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (EntityName != null)
            {
                hash = hash * 59 + EntityName.GetHashCode();
            }

            if (PolicyName != null)
            {
                hash = hash * 59 + PolicyName.GetHashCode();
            }

            if (PolicyDescription != null)
            {
                hash = hash * 59 + PolicyDescription.GetHashCode();
            }

            if (ActionSetKey != null)
            {
                hash = hash * 59 + ActionSetKey.GetHashCode();
            }

            if (AllowConditions != null)
            {
                hash = hash * 59 + AllowConditions.GetHashCode();
            }

            if (ResourceConditionNode != null)
            {
                hash = hash * 59 + ResourceConditionNode.GetHashCode();
            }

            if (NamedResources != null)
            {
                hash = hash * 59 + NamedResources.GetHashCode();
            }

            if (ResourceCondition != null)
            {
                hash = hash * 59 + ResourceCondition.GetHashCode();
            }

            if (ActionSet != null)
            {
                hash = hash * 59 + ActionSet.GetHashCode();
            }

            return hash;
        }
    }
}
