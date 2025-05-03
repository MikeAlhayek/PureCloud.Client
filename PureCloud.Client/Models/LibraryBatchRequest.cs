using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LibraryBatchRequest
/// </summary>

public partial class LibraryBatchRequest : IEquatable<LibraryBatchRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryBatchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LibraryBatchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryBatchRequest" /> class.
    /// </summary>
    /// <param name="LibraryIds">List of Library IDs (required).</param>
    public LibraryBatchRequest(List<string> LibraryIds = null)
    {
        this.LibraryIds = LibraryIds;

    }



    /// <summary>
    /// List of Library IDs
    /// </summary>
    /// <value>List of Library IDs</value>
    [JsonPropertyName("libraryIds")]
    public List<string> LibraryIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LibraryBatchRequest {\n");

        sb.Append("  LibraryIds: ").Append(LibraryIds).Append("\n");
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
        return Equals(obj as LibraryBatchRequest);
    }

    /// <summary>
    /// Returns true if LibraryBatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LibraryBatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LibraryBatchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LibraryIds == other.LibraryIds ||
                LibraryIds != null &&
                LibraryIds.SequenceEqual(other.LibraryIds)
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
            if (LibraryIds != null)
            {
                hash = hash * 59 + LibraryIds.GetHashCode();
            }

            return hash;
        }
    }
}
