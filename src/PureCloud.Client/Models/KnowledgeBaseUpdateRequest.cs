using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeBaseUpdateRequest
/// </summary>

public partial class KnowledgeBaseUpdateRequest : IEquatable<KnowledgeBaseUpdateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeBaseUpdateRequest" /> class.
    /// </summary>
    /// <param name="Name">Knowledge base name.</param>
    /// <param name="Description">Knowledge base description.</param>
    public KnowledgeBaseUpdateRequest(string Name = null, string Description = null)
    {
        this.Name = Name;
        this.Description = Description;

    }



    /// <summary>
    /// Knowledge base name
    /// </summary>
    /// <value>Knowledge base name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Knowledge base description
    /// </summary>
    /// <value>Knowledge base description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeBaseUpdateRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as KnowledgeBaseUpdateRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeBaseUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeBaseUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeBaseUpdateRequest other)
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

            return hash;
        }
    }
}
