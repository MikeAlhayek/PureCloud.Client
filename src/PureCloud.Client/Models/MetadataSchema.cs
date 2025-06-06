using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A description of the contents of a data gathering interface for an accelerator
/// </summary>

public partial class MetadataSchema : IEquatable<MetadataSchema>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MetadataSchema" /> class.
    /// </summary>
    public MetadataSchema()
    {

    }



    /// <summary>
    /// title for the data gathering page
    /// </summary>
    /// <value>title for the data gathering page</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// description of the data being gathered on this page
    /// </summary>
    /// <value>description of the data being gathered on this page</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// type of data being gathered
    /// </summary>
    /// <value>type of data being gathered</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// list of properties for which input is to be gathered, bother required and optional
    /// </summary>
    /// <value>list of properties for which input is to be gathered, bother required and optional</value>
    [JsonPropertyName("properties")]
    public List<Dictionary<string, MetadataProperty>> Properties { get; set; }



    /// <summary>
    /// list of required properties
    /// </summary>
    /// <value>list of required properties</value>
    [JsonPropertyName("required")]
    public List<string> Required { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MetadataSchema {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Required: ").Append(Required).Append("\n");
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
        return Equals(obj as MetadataSchema);
    }

    /// <summary>
    /// Returns true if MetadataSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of MetadataSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MetadataSchema other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                Required == other.Required ||
                Required != null &&
                Required.SequenceEqual(other.Required)
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

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            return hash;
        }
    }
}
