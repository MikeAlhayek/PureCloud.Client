using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuthorizationPolicy
/// </summary>

public partial class AuthorizationPolicy : IEquatable<AuthorizationPolicy>
{
    /// <summary>
    /// The effect this policy should have when its conditions are met
    /// </summary>
    /// <value>The effect this policy should have when its conditions are met</value>
    
    public enum EffectEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Allow for "ALLOW"
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        Allow,

        /// <summary>
        /// Enum Deny for "DENY"
        /// </summary>
        [EnumMember(Value = "DENY")]
        Deny
    }
    /// <summary>
    /// The effect this policy should have when its conditions are met
    /// </summary>
    /// <value>The effect this policy should have when its conditions are met</value>
    [JsonPropertyName("effect")]
    public EffectEnum? Effect { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthorizationPolicy" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuthorizationPolicy() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthorizationPolicy" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Subject">The subject to whom the policy will apply, including type and id (required).</param>
    /// <param name="Effect">The effect this policy should have when its conditions are met (required).</param>
    /// <param name="Condition">The condition tree the policy will evaluate.</param>
    /// <param name="Description">Description.</param>
    /// <param name="PresetAttributes">Map of names and values of preset attributes to use in policy evaluation.</param>
    /// <param name="Active">Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users..</param>
    public AuthorizationPolicy(string Name = null, Subject Subject = null, EffectEnum? Effect = null, object Condition = null, string Description = null, Dictionary<string, TypedAttribute> PresetAttributes = null, bool? Active = null)
    {
        this.Name = Name;
        this.Subject = Subject;
        this.Effect = Effect;
        this.Condition = Condition;
        this.Description = Description;
        this.PresetAttributes = PresetAttributes;
        this.Active = Active;

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
    /// The targeted resource to which the policy should apply, in the form of domain:entity:action
    /// </summary>
    /// <value>The targeted resource to which the policy should apply, in the form of domain:entity:action</value>
    [JsonPropertyName("targetResource")]
    public string TargetResource { get; set; }



    /// <summary>
    /// The subject to whom the policy will apply, including type and id
    /// </summary>
    /// <value>The subject to whom the policy will apply, including type and id</value>
    [JsonPropertyName("subject")]
    public Subject Subject { get; set; }





    /// <summary>
    /// The condition tree the policy will evaluate
    /// </summary>
    /// <value>The condition tree the policy will evaluate</value>
    [JsonPropertyName("condition")]
    public object Condition { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Map of names and values of preset attributes to use in policy evaluation
    /// </summary>
    /// <value>Map of names and values of preset attributes to use in policy evaluation</value>
    [JsonPropertyName("presetAttributes")]
    public Dictionary<string, TypedAttribute> PresetAttributes { get; set; }



    /// <summary>
    /// Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users.
    /// </summary>
    /// <value>Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users.</value>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



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
        sb.Append("class AuthorizationPolicy {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TargetResource: ").Append(TargetResource).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  Effect: ").Append(Effect).Append("\n");
        sb.Append("  Condition: ").Append(Condition).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  PresetAttributes: ").Append(PresetAttributes).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
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
        return Equals(obj as AuthorizationPolicy);
    }

    /// <summary>
    /// Returns true if AuthorizationPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthorizationPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthorizationPolicy other)
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
                TargetResource == other.TargetResource ||
                TargetResource != null &&
                TargetResource.Equals(other.TargetResource)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                Effect == other.Effect ||
                Effect != null &&
                Effect.Equals(other.Effect)
            ) &&
            (
                Condition == other.Condition ||
                Condition != null &&
                Condition.Equals(other.Condition)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                PresetAttributes == other.PresetAttributes ||
                PresetAttributes != null &&
                PresetAttributes.SequenceEqual(other.PresetAttributes)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
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

            if (TargetResource != null)
            {
                hash = hash * 59 + TargetResource.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (Effect != null)
            {
                hash = hash * 59 + Effect.GetHashCode();
            }

            if (Condition != null)
            {
                hash = hash * 59 + Condition.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (PresetAttributes != null)
            {
                hash = hash * 59 + PresetAttributes.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
