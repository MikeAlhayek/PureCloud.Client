using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContentSetting
/// </summary>

public partial class ContentSetting : IEquatable<ContentSetting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentSetting" /> class.
    /// </summary>
    /// <param name="Story">Settings relating to facebook and instagram stories feature.</param>
    public ContentSetting(StorySetting Story = null)
    {
        this.Story = Story;

    }



    /// <summary>
    /// Settings relating to facebook and instagram stories feature
    /// </summary>
    /// <value>Settings relating to facebook and instagram stories feature</value>
    [JsonPropertyName("story")]
    public StorySetting Story { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentSetting {\n");

        sb.Append("  Story: ").Append(Story).Append("\n");
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
        return Equals(obj as ContentSetting);
    }

    /// <summary>
    /// Returns true if ContentSetting instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentSetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentSetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Story == other.Story ||
                Story != null &&
                Story.Equals(other.Story)
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
            if (Story != null)
            {
                hash = hash * 59 + Story.GetHashCode();
            }

            return hash;
        }
    }
}
