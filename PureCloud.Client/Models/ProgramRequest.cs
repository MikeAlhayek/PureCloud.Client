using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramRequest
/// </summary>

public partial class ProgramRequest : IEquatable<ProgramRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ProgramRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramRequest" /> class.
    /// </summary>
    /// <param name="Name">The program name (required).</param>
    /// <param name="Description">The program description.</param>
    /// <param name="TopicIds">The ids of topics associated to the program.</param>
    /// <param name="Tags">The program tags.</param>
    public ProgramRequest(string Name = null, string Description = null, List<string> TopicIds = null, List<string> Tags = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.TopicIds = TopicIds;
        this.Tags = Tags;

    }



    /// <summary>
    /// The program name
    /// </summary>
    /// <value>The program name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The program description
    /// </summary>
    /// <value>The program description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The ids of topics associated to the program
    /// </summary>
    /// <value>The ids of topics associated to the program</value>
    [JsonPropertyName("topicIds")]
    public List<string> TopicIds { get; set; }



    /// <summary>
    /// The program tags
    /// </summary>
    /// <value>The program tags</value>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  TopicIds: ").Append(TopicIds).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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
        return Equals(obj as ProgramRequest);
    }

    /// <summary>
    /// Returns true if ProgramRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramRequest other)
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
                TopicIds == other.TopicIds ||
                TopicIds != null &&
                TopicIds.SequenceEqual(other.TopicIds)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
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

            if (TopicIds != null)
            {
                hash = hash * 59 + TopicIds.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            return hash;
        }
    }
}
