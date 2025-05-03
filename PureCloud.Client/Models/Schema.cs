using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Schema
/// </summary>

public partial class Schema : IEquatable<Schema>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Schema" /> class.
    /// </summary>
    public Schema()
    {

    }



    /// <summary>
    /// A core type&#39;s title
    /// </summary>
    /// <value>A core type&#39;s title</value>
    [JsonPropertyName("title")]
    public string Title { get; private set; }



    /// <summary>
    /// A core type&#39;s description
    /// </summary>
    /// <value>A core type&#39;s description</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// An array of fundamental JSON Schema primitive types on which the core type is based
    /// </summary>
    /// <value>An array of fundamental JSON Schema primitive types on which the core type is based</value>
    [JsonPropertyName("type")]
    public List<string> Type { get; private set; }



    /// <summary>
    /// Denotes the type and pattern of the items in an enum core type
    /// </summary>
    /// <value>Denotes the type and pattern of the items in an enum core type</value>
    [JsonPropertyName("items")]
    public Items Items { get; private set; }



    /// <summary>
    /// For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format
    /// </summary>
    /// <value>For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format</value>
    [JsonPropertyName("pattern")]
    public string Pattern { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Schema {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Items: ").Append(Items).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
        return Equals(obj as Schema);
    }

    /// <summary>
    /// Returns true if Schema instances are equal
    /// </summary>
    /// <param name="other">Instance of Schema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Schema other)
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
                Type.SequenceEqual(other.Type)
            ) &&
            (
                Items == other.Items ||
                Items != null &&
                Items.Equals(other.Items)
            ) &&
            (
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
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

            if (Items != null)
            {
                hash = hash * 59 + Items.GetHashCode();
            }

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            return hash;
        }
    }
}
