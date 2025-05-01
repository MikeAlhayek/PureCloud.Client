using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainPermission
/// </summary>
[DataContract]
public partial class DomainPermission : IEquatable<DomainPermission>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainPermission" /> class.
    /// </summary>
    /// <param name="Domain">Domain.</param>
    /// <param name="EntityType">EntityType.</param>
    /// <param name="Action">Action.</param>
    /// <param name="Label">Label.</param>
    /// <param name="AllowsConditions">AllowsConditions.</param>
    /// <param name="DivisionAware">DivisionAware.</param>
    public DomainPermission(string Domain = null, string EntityType = null, string Action = null, string Label = null, bool? AllowsConditions = null, bool? DivisionAware = null)
    {
        this.Domain = Domain;
        this.EntityType = EntityType;
        this.Action = Action;
        this.Label = Label;
        this.AllowsConditions = AllowsConditions;
        this.DivisionAware = DivisionAware;

    }



    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name = "domain", EmitDefaultValue = false)]
    public string Domain { get; set; }



    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public string EntityType { get; set; }



    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public string Action { get; set; }



    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }



    /// <summary>
    /// Gets or Sets AllowsConditions
    /// </summary>
    [DataMember(Name = "allowsConditions", EmitDefaultValue = false)]
    public bool? AllowsConditions { get; set; }



    /// <summary>
    /// Gets or Sets DivisionAware
    /// </summary>
    [DataMember(Name = "divisionAware", EmitDefaultValue = false)]
    public bool? DivisionAware { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainPermission {\n");

        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("  AllowsConditions: ").Append(AllowsConditions).Append("\n");
        sb.Append("  DivisionAware: ").Append(DivisionAware).Append("\n");
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
        return Equals(obj as DomainPermission);
    }

    /// <summary>
    /// Returns true if DomainPermission instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainPermission to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainPermission other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
            ) &&
            (
                AllowsConditions == other.AllowsConditions ||
                AllowsConditions != null &&
                AllowsConditions.Equals(other.AllowsConditions)
            ) &&
            (
                DivisionAware == other.DivisionAware ||
                DivisionAware != null &&
                DivisionAware.Equals(other.DivisionAware)
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
            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            if (AllowsConditions != null)
            {
                hash = hash * 59 + AllowsConditions.GetHashCode();
            }

            if (DivisionAware != null)
            {
                hash = hash * 59 + DivisionAware.GetHashCode();
            }

            return hash;
        }
    }
}
