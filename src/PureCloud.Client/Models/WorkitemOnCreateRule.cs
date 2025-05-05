using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemOnCreateRule
/// </summary>

public partial class WorkitemOnCreateRule : IEquatable<WorkitemOnCreateRule>
{
    /// <summary>
    /// The type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
    
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
        /// Enum Oncreate for "OnCreate"
        /// </summary>
        [EnumMember(Value = "OnCreate")]
        Oncreate,

        /// <summary>
        /// Enum Onattributechange for "OnAttributeChange"
        /// </summary>
        [EnumMember(Value = "OnAttributeChange")]
        Onattributechange,

        /// <summary>
        /// Enum Date for "Date"
        /// </summary>
        [EnumMember(Value = "Date")]
        Date
    }
    /// <summary>
    /// The type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemOnCreateRule" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">The type of the rule..</param>
    /// <param name="Action">The rules action. If the condition criteria is met this action will be executed..</param>
    /// <param name="Worktype">The Worktype containing the rule..</param>
    public WorkitemOnCreateRule(string Name = null, TypeEnum? Type = null, WorkitemRuleAction Action = null, WorktypeReference Worktype = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Action = Action;
        this.Worktype = Worktype;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// The rules action. If the condition criteria is met this action will be executed.
    /// </summary>
    /// <value>The rules action. If the condition criteria is met this action will be executed.</value>
    [JsonPropertyName("action")]
    public WorkitemRuleAction Action { get; set; }



    /// <summary>
    /// The Worktype containing the rule.
    /// </summary>
    /// <value>The Worktype containing the rule.</value>
    [JsonPropertyName("worktype")]
    public WorktypeReference Worktype { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemOnCreateRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Worktype: ").Append(Worktype).Append("\n");
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
        return Equals(obj as WorkitemOnCreateRule);
    }

    /// <summary>
    /// Returns true if WorkitemOnCreateRule instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemOnCreateRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemOnCreateRule other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                Worktype == other.Worktype ||
                Worktype != null &&
                Worktype.Equals(other.Worktype)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (Worktype != null)
            {
                hash = hash * 59 + Worktype.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
