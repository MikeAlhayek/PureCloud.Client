using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DigitalRule
/// </summary>

public partial class DigitalRule : IEquatable<DigitalRule>
{
    /// <summary>
    /// The category of the rule.
    /// </summary>
    /// <value>The category of the rule.</value>
    
    public enum CategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Precontact for "PreContact"
        /// </summary>
        [EnumMember(Value = "PreContact")]
        Precontact,

        /// <summary>
        /// Enum Postcontact for "PostContact"
        /// </summary>
        [EnumMember(Value = "PostContact")]
        Postcontact
    }
    /// <summary>
    /// The category of the rule.
    /// </summary>
    /// <value>The category of the rule.</value>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DigitalRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DigitalRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DigitalRule" /> class.
    /// </summary>
    /// <param name="Name">The name of the rule. (required).</param>
    /// <param name="Order">The ranked order of the rule. Rules are processed from lowest number to highest. (required).</param>
    /// <param name="Category">The category of the rule. (required).</param>
    /// <param name="Conditions">A list of conditions to evaluate. All of the Conditions must evaluate to true to trigger the actions. (required).</param>
    /// <param name="Actions">The list of actions to be taken if all conditions are true. (required).</param>
    public DigitalRule(string Name = null, int? Order = null, CategoryEnum? Category = null, List<DigitalCondition> Conditions = null, List<DigitalAction> Actions = null)
    {
        this.Name = Name;
        this.Order = Order;
        this.Category = Category;
        this.Conditions = Conditions;
        this.Actions = Actions;

    }



    /// <summary>
    /// The identifier of the rule.
    /// </summary>
    /// <value>The identifier of the rule.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the rule.
    /// </summary>
    /// <value>The name of the rule.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The ranked order of the rule. Rules are processed from lowest number to highest.
    /// </summary>
    /// <value>The ranked order of the rule. Rules are processed from lowest number to highest.</value>
    [JsonPropertyName("order")]
    public int? Order { get; set; }





    /// <summary>
    /// A list of conditions to evaluate. All of the Conditions must evaluate to true to trigger the actions.
    /// </summary>
    /// <value>A list of conditions to evaluate. All of the Conditions must evaluate to true to trigger the actions.</value>
    [JsonPropertyName("conditions")]
    public List<DigitalCondition> Conditions { get; set; }



    /// <summary>
    /// The list of actions to be taken if all conditions are true.
    /// </summary>
    /// <value>The list of actions to be taken if all conditions are true.</value>
    [JsonPropertyName("actions")]
    public List<DigitalAction> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DigitalRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
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
        return Equals(obj as DigitalRule);
    }

    /// <summary>
    /// Returns true if DigitalRule instances are equal
    /// </summary>
    /// <param name="other">Instance of DigitalRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DigitalRule other)
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
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.SequenceEqual(other.Conditions)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.SequenceEqual(other.Actions)
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

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
