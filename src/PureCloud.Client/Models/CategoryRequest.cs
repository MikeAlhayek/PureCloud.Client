using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CategoryRequest
/// </summary>

public partial class CategoryRequest : IEquatable<CategoryRequest>
{
    /// <summary>
    /// The type of interaction the category will apply to
    /// </summary>
    /// <value>The type of interaction the category will apply to</value>
    
    public enum InteractionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Digital for "Digital"
        /// </summary>
        [EnumMember(Value = "Digital")]
        Digital,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All
    }
    /// <summary>
    /// The type of interaction the category will apply to
    /// </summary>
    /// <value>The type of interaction the category will apply to</value>
    [JsonPropertyName("interactionType")]
    public InteractionTypeEnum? InteractionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the category (required).</param>
    /// <param name="Description">The description of the category.</param>
    /// <param name="InteractionType">The type of interaction the category will apply to (required).</param>
    /// <param name="Criteria">A collection of conditions joined together by logical operation to provide more refined filtering of conversations (required).</param>
    public CategoryRequest(string Name = null, string Description = null, InteractionTypeEnum? InteractionType = null, Operand Criteria = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.InteractionType = InteractionType;
        this.Criteria = Criteria;

    }



    /// <summary>
    /// The name of the category
    /// </summary>
    /// <value>The name of the category</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of the category
    /// </summary>
    /// <value>The description of the category</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
    /// </summary>
    /// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
    [JsonPropertyName("criteria")]
    public Operand Criteria { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CategoryRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
        return Equals(obj as CategoryRequest);
    }

    /// <summary>
    /// Returns true if CategoryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CategoryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoryRequest other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                InteractionType == other.InteractionType ||
                InteractionType != null &&
                InteractionType.Equals(other.InteractionType)
            ) &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.Equals(other.Criteria)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (InteractionType != null)
            {
                hash = hash * 59 + InteractionType.GetHashCode();
            }

            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            return hash;
        }
    }
}
