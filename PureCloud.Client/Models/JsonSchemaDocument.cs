using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A JSON Schema document.
/// </summary>
[DataContract]
public partial class JsonSchemaDocument : IEquatable<JsonSchemaDocument>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSchemaDocument" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Schema">Schema.</param>
    /// <param name="Title">Title.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Required">Required.</param>
    /// <param name="Properties">Properties.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public JsonSchemaDocument(string Id = null, string Schema = null, string Title = null, string Description = null, string Type = null, List<string> Required = null, Dictionary<string, object> Properties = null, object AdditionalProperties = null)
    {
        this.Id = Id;
        this.Schema = Schema;
        this.Title = Title;
        this.Description = Description;
        this.Type = Type;
        this.Required = Required;
        this.Properties = Properties;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    [DataMember(Name = "$schema", EmitDefaultValue = false)]
    public string Schema { get; set; }



    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name = "required", EmitDefaultValue = false)]
    public List<string> Required { get; set; }



    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public Dictionary<string, object> Properties { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public object AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JsonSchemaDocument {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Required: ").Append(Required).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as JsonSchemaDocument);
    }

    /// <summary>
    /// Returns true if JsonSchemaDocument instances are equal
    /// </summary>
    /// <param name="other">Instance of JsonSchemaDocument to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JsonSchemaDocument other)
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
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Required == other.Required ||
                Required != null &&
                Required.SequenceEqual(other.Required)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.Equals(other.AdditionalProperties)
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

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
