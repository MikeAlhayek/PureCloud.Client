using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module inform steps request
/// </summary>

public partial class LearningModuleInformStepRequest : IEquatable<LearningModuleInformStepRequest>
{
    /// <summary>
    /// The learning module inform step type
    /// </summary>
    /// <value>The learning module inform step type</value>
    
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
        /// Enum Url for "Url"
        /// </summary>
        [EnumMember(Value = "Url")]
        Url,

        /// <summary>
        /// Enum Content for "Content"
        /// </summary>
        [EnumMember(Value = "Content")]
        Content,

        /// <summary>
        /// Enum Genesysbuiltincourse for "GenesysBuiltInCourse"
        /// </summary>
        [EnumMember(Value = "GenesysBuiltInCourse")]
        Genesysbuiltincourse,

        /// <summary>
        /// Enum Richtext for "RichText"
        /// </summary>
        [EnumMember(Value = "RichText")]
        Richtext,

        /// <summary>
        /// Enum Scorm for "Scorm"
        /// </summary>
        [EnumMember(Value = "Scorm")]
        Scorm
    }
    /// <summary>
    /// The learning module inform step type
    /// </summary>
    /// <value>The learning module inform step type</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleInformStepRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningModuleInformStepRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleInformStepRequest" /> class.
    /// </summary>
    /// <param name="Type">The learning module inform step type (required).</param>
    /// <param name="Name">The name of the inform step or content.</param>
    /// <param name="Value">The value for inform step (required).</param>
    /// <param name="SharingUri">The sharing uri for Content type inform step.</param>
    /// <param name="ContentType">The document type for Content type Inform step.</param>
    /// <param name="Order">The order of inform step in a learning module (required).</param>
    /// <param name="DisplayName">The display name for the inform step.</param>
    /// <param name="Description">The description for the inform step.</param>
    public LearningModuleInformStepRequest(TypeEnum? Type = null, string Name = null, string Value = null, string SharingUri = null, string ContentType = null, int? Order = null, string DisplayName = null, string Description = null)
    {
        this.Type = Type;
        this.Name = Name;
        this.Value = Value;
        this.SharingUri = SharingUri;
        this.ContentType = ContentType;
        this.Order = Order;
        this.DisplayName = DisplayName;
        this.Description = Description;

    }





    /// <summary>
    /// The name of the inform step or content
    /// </summary>
    /// <value>The name of the inform step or content</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The value for inform step
    /// </summary>
    /// <value>The value for inform step</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// The sharing uri for Content type inform step
    /// </summary>
    /// <value>The sharing uri for Content type inform step</value>
    [JsonPropertyName("sharingUri")]
    public string SharingUri { get; set; }



    /// <summary>
    /// The document type for Content type Inform step
    /// </summary>
    /// <value>The document type for Content type Inform step</value>
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; }



    /// <summary>
    /// The order of inform step in a learning module
    /// </summary>
    /// <value>The order of inform step in a learning module</value>
    [JsonPropertyName("order")]
    public int? Order { get; set; }



    /// <summary>
    /// The display name for the inform step
    /// </summary>
    /// <value>The display name for the inform step</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// The description for the inform step
    /// </summary>
    /// <value>The description for the inform step</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleInformStepRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  SharingUri: ").Append(SharingUri).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as LearningModuleInformStepRequest);
    }

    /// <summary>
    /// Returns true if LearningModuleInformStepRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModuleInformStepRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModuleInformStepRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                SharingUri == other.SharingUri ||
                SharingUri != null &&
                SharingUri.Equals(other.SharingUri)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (SharingUri != null)
            {
                hash = hash * 59 + SharingUri.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            return hash;
        }
    }
}
