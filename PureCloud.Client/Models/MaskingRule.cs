using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MaskingRule
/// </summary>
[DataContract]
public partial class MaskingRule : IEquatable<MaskingRule>
{
    /// <summary>
    /// Masking rule type
    /// </summary>
    /// <value>Masking rule type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom,

        /// <summary>
        /// Enum Predefined for "Predefined"
        /// </summary>
        [EnumMember(Value = "Predefined")]
        Predefined,

        /// <summary>
        /// Enum Default for "Default"
        /// </summary>
        [EnumMember(Value = "Default")]
        Default
    }
    /// <summary>
    /// Masking rule type
    /// </summary>
    /// <value>Masking rule type</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MaskingRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MaskingRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MaskingRule" /> class.
    /// </summary>
    /// <param name="Name">Masking rule name. (required).</param>
    /// <param name="Description">Description about masking rule..</param>
    /// <param name="SubstituteCharacter">Replacement character for masked text character. (required).</param>
    /// <param name="Definition">Definition of masking rule (a valid regex or builtin AI based mask name). (required).</param>
    /// <param name="Enabled">True/False (required).</param>
    /// <param name="Type">Masking rule type (required).</param>
    /// <param name="Integrations">Associated integration channels.</param>
    public MaskingRule(string Name = null, string Description = null, string SubstituteCharacter = null, string Definition = null, bool? Enabled = null, TypeEnum? Type = null, List<string> Integrations = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.SubstituteCharacter = SubstituteCharacter;
        this.Definition = Definition;
        this.Enabled = Enabled;
        this.Type = Type;
        this.Integrations = Integrations;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Masking rule name.
    /// </summary>
    /// <value>Masking rule name.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Description about masking rule.
    /// </summary>
    /// <value>Description about masking rule.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Replacement character for masked text character.
    /// </summary>
    /// <value>Replacement character for masked text character.</value>
    [DataMember(Name = "substituteCharacter", EmitDefaultValue = false)]
    public string SubstituteCharacter { get; set; }



    /// <summary>
    /// Definition of masking rule (a valid regex or builtin AI based mask name).
    /// </summary>
    /// <value>Definition of masking rule (a valid regex or builtin AI based mask name).</value>
    [DataMember(Name = "definition", EmitDefaultValue = false)]
    public string Definition { get; set; }



    /// <summary>
    /// True/False
    /// </summary>
    /// <value>True/False</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }





    /// <summary>
    /// Associated integration channels
    /// </summary>
    /// <value>Associated integration channels</value>
    [DataMember(Name = "integrations", EmitDefaultValue = false)]
    public List<string> Integrations { get; set; }



    /// <summary>
    /// Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MaskingRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SubstituteCharacter: ").Append(SubstituteCharacter).Append("\n");
        sb.Append("  Definition: ").Append(Definition).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Integrations: ").Append(Integrations).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as MaskingRule);
    }

    /// <summary>
    /// Returns true if MaskingRule instances are equal
    /// </summary>
    /// <param name="other">Instance of MaskingRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MaskingRule other)
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
                SubstituteCharacter == other.SubstituteCharacter ||
                SubstituteCharacter != null &&
                SubstituteCharacter.Equals(other.SubstituteCharacter)
            ) &&
            (
                Definition == other.Definition ||
                Definition != null &&
                Definition.Equals(other.Definition)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Integrations == other.Integrations ||
                Integrations != null &&
                Integrations.SequenceEqual(other.Integrations)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (SubstituteCharacter != null)
            {
                hash = hash * 59 + SubstituteCharacter.GetHashCode();
            }

            if (Definition != null)
            {
                hash = hash * 59 + Definition.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Integrations != null)
            {
                hash = hash * 59 + Integrations.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            return hash;
        }
    }
}
