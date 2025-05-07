using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An event definition used when creating journey views
/// </summary>

public partial class JourneyEventDefinition : IEquatable<JourneyEventDefinition>
{
    /// <summary>
    /// The source of the event definition
    /// </summary>
    /// <value>The source of the event definition</value>
    
    public enum SourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Native for "Native"
        /// </summary>
        [EnumMember(Value = "Native")]
        Native,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom
    }
    /// <summary>
    /// The source of the event definition
    /// </summary>
    /// <value>The source of the event definition</value>
    [JsonPropertyName("source")]
    public SourceEnum? Source { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyEventDefinition" /> class.
    /// </summary>
    public JourneyEventDefinition()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the event definition
    /// </summary>
    /// <value>The name of the event definition</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// The description of this event definition
    /// </summary>
    /// <value>The description of this event definition</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The JSON schema of this event definition
    /// </summary>
    /// <value>The JSON schema of this event definition</value>
    [JsonPropertyName("jsonSchema")]
    public JsonSchemaDocument JsonSchema { get; set; }



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
        sb.Append("class JourneyEventDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
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
        return Equals(obj as JourneyEventDefinition);
    }

    /// <summary>
    /// Returns true if JourneyEventDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyEventDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyEventDefinition other)
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
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                JsonSchema == other.JsonSchema ||
                JsonSchema != null &&
                JsonSchema.Equals(other.JsonSchema)
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

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (JsonSchema != null)
            {
                hash = hash * 59 + JsonSchema.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
