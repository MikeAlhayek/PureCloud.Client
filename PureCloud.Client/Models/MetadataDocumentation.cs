using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Additional documentation about an artifact
/// </summary>

public partial class MetadataDocumentation : IEquatable<MetadataDocumentation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MetadataDocumentation" /> class.
    /// </summary>
    public MetadataDocumentation()
    {

    }



    /// <summary>
    /// description of the documentation
    /// </summary>
    /// <value>description of the documentation</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// location where the documentation can be accessed
    /// </summary>
    /// <value>location where the documentation can be accessed</value>
    [JsonPropertyName("location")]
    public string Location { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MetadataDocumentation {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
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
        return Equals(obj as MetadataDocumentation);
    }

    /// <summary>
    /// Returns true if MetadataDocumentation instances are equal
    /// </summary>
    /// <param name="other">Instance of MetadataDocumentation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MetadataDocumentation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            return hash;
        }
    }
}
