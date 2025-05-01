using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeIntegrationFilter
/// </summary>
[DataContract]
public partial class KnowledgeIntegrationFilter : IEquatable<KnowledgeIntegrationFilter>
{
    /// <summary>
    /// Filter name, which is the name of a setting in a knowledge source.
    /// </summary>
    /// <value>Filter name, which is the name of a setting in a knowledge source.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Categories for "categories"
        /// </summary>
        [EnumMember(Value = "categories")]
        Categories,

        /// <summary>
        /// Enum Channel for "channel"
        /// </summary>
        [EnumMember(Value = "channel")]
        Channel,

        /// <summary>
        /// Enum Knowledgebaseids for "knowledgeBaseIds"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseIds")]
        Knowledgebaseids
    }
    /// <summary>
    /// Filter type.
    /// </summary>
    /// <value>Filter type.</value>
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
        /// Enum Singleselect for "SingleSelect"
        /// </summary>
        [EnumMember(Value = "SingleSelect")]
        Singleselect,

        /// <summary>
        /// Enum Multiselect for "MultiSelect"
        /// </summary>
        [EnumMember(Value = "MultiSelect")]
        Multiselect
    }
    /// <summary>
    /// Filter action.
    /// </summary>
    /// <value>Filter action.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,

        /// <summary>
        /// Enum Filterupdate for "FilterUpdate"
        /// </summary>
        [EnumMember(Value = "FilterUpdate")]
        Filterupdate
    }
    /// <summary>
    /// Filter name, which is the name of a setting in a knowledge source.
    /// </summary>
    /// <value>Filter name, which is the name of a setting in a knowledge source.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public NameEnum? Name { get; set; }
    /// <summary>
    /// Filter type.
    /// </summary>
    /// <value>Filter type.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Filter action.
    /// </summary>
    /// <value>Filter action.</value>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeIntegrationFilter" /> class.
    /// </summary>
    /// <param name="Name">Filter name, which is the name of a setting in a knowledge source..</param>
    /// <param name="Type">Filter type..</param>
    /// <param name="Action">Filter action..</param>
    /// <param name="Values">Available options of the filter setting..</param>
    public KnowledgeIntegrationFilter(NameEnum? Name = null, TypeEnum? Type = null, ActionEnum? Action = null, List<KnowledgeIntegrationFilterValue> Values = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Action = Action;
        this.Values = Values;

    }









    /// <summary>
    /// Available options of the filter setting.
    /// </summary>
    /// <value>Available options of the filter setting.</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<KnowledgeIntegrationFilterValue> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeIntegrationFilter {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as KnowledgeIntegrationFilter);
    }

    /// <summary>
    /// Returns true if KnowledgeIntegrationFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeIntegrationFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeIntegrationFilter other)
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
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
