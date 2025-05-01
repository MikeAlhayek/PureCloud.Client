using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Policy
/// </summary>
[DataContract]
public partial class Policy : IEquatable<Policy>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Policy" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Order">Order.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="MediaPolicies">Conditions and actions per media type.</param>
    /// <param name="Conditions">Conditions.</param>
    /// <param name="Actions">Actions.</param>
    /// <param name="PolicyErrors">PolicyErrors.</param>
    public Policy(string Name = null, DateTime? ModifiedDate = null, DateTime? CreatedDate = null, int? Order = null, string Description = null, bool? Enabled = null, MediaPolicies MediaPolicies = null, PolicyConditions Conditions = null, PolicyActions Actions = null, PolicyErrors PolicyErrors = null)
    {
        this.Name = Name;
        this.ModifiedDate = ModifiedDate;
        this.CreatedDate = CreatedDate;
        this.Order = Order;
        this.Description = Description;
        this.Enabled = Enabled;
        this.MediaPolicies = MediaPolicies;
        this.Conditions = Conditions;
        this.Actions = Actions;
        this.PolicyErrors = PolicyErrors;

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
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name = "order", EmitDefaultValue = false)]
    public int? Order { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Conditions and actions per media type
    /// </summary>
    /// <value>Conditions and actions per media type</value>
    [DataMember(Name = "mediaPolicies", EmitDefaultValue = false)]
    public MediaPolicies MediaPolicies { get; set; }



    /// <summary>
    /// Conditions
    /// </summary>
    /// <value>Conditions</value>
    [DataMember(Name = "conditions", EmitDefaultValue = false)]
    public PolicyConditions Conditions { get; set; }



    /// <summary>
    /// Actions
    /// </summary>
    /// <value>Actions</value>
    [DataMember(Name = "actions", EmitDefaultValue = false)]
    public PolicyActions Actions { get; set; }



    /// <summary>
    /// Gets or Sets PolicyErrors
    /// </summary>
    [DataMember(Name = "policyErrors", EmitDefaultValue = false)]
    public PolicyErrors PolicyErrors { get; set; }



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
        sb.Append("class Policy {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MediaPolicies: ").Append(MediaPolicies).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
        sb.Append("  PolicyErrors: ").Append(PolicyErrors).Append("\n");
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
        return Equals(obj as Policy);
    }

    /// <summary>
    /// Returns true if Policy instances are equal
    /// </summary>
    /// <param name="other">Instance of Policy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Policy other)
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
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                MediaPolicies == other.MediaPolicies ||
                MediaPolicies != null &&
                MediaPolicies.Equals(other.MediaPolicies)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.Equals(other.Conditions)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.Equals(other.Actions)
            ) &&
            (
                PolicyErrors == other.PolicyErrors ||
                PolicyErrors != null &&
                PolicyErrors.Equals(other.PolicyErrors)
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

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (MediaPolicies != null)
            {
                hash = hash * 59 + MediaPolicies.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            if (PolicyErrors != null)
            {
                hash = hash * 59 + PolicyErrors.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
