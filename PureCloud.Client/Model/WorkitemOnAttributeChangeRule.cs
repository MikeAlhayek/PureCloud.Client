using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// WorkitemOnAttributeChangeRule
/// </summary>
[DataContract]
public partial class WorkitemOnAttributeChangeRule : IEquatable<WorkitemOnAttributeChangeRule>
{
    /// <summary>
    /// The type of the rule.
    /// </summary>
    /// <value>The type of the rule.</value>
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
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeRule" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">The type of the rule..</param>
    /// <param name="Action">The rules action. If the condition criteria is met this action will be executed..</param>
    /// <param name="Worktype">The Worktype containing the rule..</param>
    /// <param name="Condition">The rules condition. If the condition criteria is met the rules action will be executed..</param>
    public WorkitemOnAttributeChangeRule(string Name = null, TypeEnum? Type = null, WorkitemRuleAction Action = null, WorktypeReference Worktype = null, WorkitemOnAttributeChangeCondition Condition = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Action = Action;
        this.Worktype = Worktype;
        this.Condition = Condition;

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
    /// The rules action. If the condition criteria is met this action will be executed.
    /// </summary>
    /// <value>The rules action. If the condition criteria is met this action will be executed.</value>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public WorkitemRuleAction Action { get; set; }



    /// <summary>
    /// The Worktype containing the rule.
    /// </summary>
    /// <value>The Worktype containing the rule.</value>
    [DataMember(Name = "worktype", EmitDefaultValue = false)]
    public WorktypeReference Worktype { get; set; }



    /// <summary>
    /// The rules condition. If the condition criteria is met the rules action will be executed.
    /// </summary>
    /// <value>The rules condition. If the condition criteria is met the rules action will be executed.</value>
    [DataMember(Name = "condition", EmitDefaultValue = false)]
    public WorkitemOnAttributeChangeCondition Condition { get; set; }



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
        sb.Append("class WorkitemOnAttributeChangeRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Worktype: ").Append(Worktype).Append("\n");
        sb.Append("  Condition: ").Append(Condition).Append("\n");
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
        return this.Equals(obj as WorkitemOnAttributeChangeRule);
    }

    /// <summary>
    /// Returns true if WorkitemOnAttributeChangeRule instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemOnAttributeChangeRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemOnAttributeChangeRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Action == other.Action ||
                this.Action != null &&
                this.Action.Equals(other.Action)
            ) &&
            (
                this.Worktype == other.Worktype ||
                this.Worktype != null &&
                this.Worktype.Equals(other.Worktype)
            ) &&
            (
                this.Condition == other.Condition ||
                this.Condition != null &&
                this.Condition.Equals(other.Condition)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Action != null)
            {
                hash = hash * 59 + this.Action.GetHashCode();
            }

            if (this.Worktype != null)
            {
                hash = hash * 59 + this.Worktype.GetHashCode();
            }

            if (this.Condition != null)
            {
                hash = hash * 59 + this.Condition.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
