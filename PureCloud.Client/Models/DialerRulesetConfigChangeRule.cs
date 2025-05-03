using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerRulesetConfigChangeRule
/// </summary>

public partial class DialerRulesetConfigChangeRule : IEquatable<DialerRulesetConfigChangeRule>
{
    /// <summary>
    /// The category of the rule
    /// </summary>
    /// <value>The category of the rule</value>
    
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
        /// Enum Precall for "DIALER_PRECALL"
        /// </summary>
        [EnumMember(Value = "DIALER_PRECALL")]
        Precall,

        /// <summary>
        /// Enum Wrapup for "DIALER_WRAPUP"
        /// </summary>
        [EnumMember(Value = "DIALER_WRAPUP")]
        Wrapup
    }
    /// <summary>
    /// The category of the rule
    /// </summary>
    /// <value>The category of the rule</value>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeRule" /> class.
    /// </summary>
    /// <param name="Conditions">The list of rule conditions; all must evaluate to true to trigger the rule actions.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The identifier of the rule.</param>
    /// <param name="Name">The name of the rule.</param>
    /// <param name="Order">The ranked order of the rule; rules are processed from lowest number to highest.</param>
    /// <param name="Category">The category of the rule.</param>
    /// <param name="Actions">The list of rule actions to be taken if the conditions are true.</param>
    public DialerRulesetConfigChangeRule(List<DialerRulesetConfigChangeCondition> Conditions = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, long? Order = null, CategoryEnum? Category = null, List<DialerRulesetConfigChangeAction> Actions = null)
    {
        this.Conditions = Conditions;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.Order = Order;
        this.Category = Category;
        this.Actions = Actions;

    }



    /// <summary>
    /// The list of rule conditions; all must evaluate to true to trigger the rule actions
    /// </summary>
    /// <value>The list of rule conditions; all must evaluate to true to trigger the rule actions</value>
    [JsonPropertyName("conditions")]
    public List<DialerRulesetConfigChangeCondition> Conditions { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The identifier of the rule
    /// </summary>
    /// <value>The identifier of the rule</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the rule
    /// </summary>
    /// <value>The name of the rule</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The ranked order of the rule; rules are processed from lowest number to highest
    /// </summary>
    /// <value>The ranked order of the rule; rules are processed from lowest number to highest</value>
    [JsonPropertyName("order")]
    public long? Order { get; set; }





    /// <summary>
    /// The list of rule actions to be taken if the conditions are true
    /// </summary>
    /// <value>The list of rule actions to be taken if the conditions are true</value>
    [JsonPropertyName("actions")]
    public List<DialerRulesetConfigChangeAction> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerRulesetConfigChangeRule {\n");

        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
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
        return Equals(obj as DialerRulesetConfigChangeRule);
    }

    /// <summary>
    /// Returns true if DialerRulesetConfigChangeRule instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerRulesetConfigChangeRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerRulesetConfigChangeRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.SequenceEqual(other.Conditions)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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
            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

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

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
