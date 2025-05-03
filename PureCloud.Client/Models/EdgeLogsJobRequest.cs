using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeLogsJobRequest
/// </summary>

public partial class EdgeLogsJobRequest : IEquatable<EdgeLogsJobRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeLogsJobRequest" /> class.
    /// </summary>
    /// <param name="Path">A relative directory to the root Edge log folder to query from..</param>
    /// <param name="Query">The pattern to use when searching for logs, which may include the wildcards {*, ?}.  Multiple search patterns may be combined using a pipe &#39;|&#39; as a delimiter..</param>
    /// <param name="Recurse">Boolean whether or not to recurse into directories..</param>
    public EdgeLogsJobRequest(string Path = null, string Query = null, bool? Recurse = null)
    {
        this.Path = Path;
        this.Query = Query;
        this.Recurse = Recurse;

    }



    /// <summary>
    /// A relative directory to the root Edge log folder to query from.
    /// </summary>
    /// <value>A relative directory to the root Edge log folder to query from.</value>
    [JsonPropertyName("path")]
    public string Path { get; set; }



    /// <summary>
    /// The pattern to use when searching for logs, which may include the wildcards {*, ?}.  Multiple search patterns may be combined using a pipe &#39;|&#39; as a delimiter.
    /// </summary>
    /// <value>The pattern to use when searching for logs, which may include the wildcards {*, ?}.  Multiple search patterns may be combined using a pipe &#39;|&#39; as a delimiter.</value>
    [JsonPropertyName("query")]
    public string Query { get; set; }



    /// <summary>
    /// Boolean whether or not to recurse into directories.
    /// </summary>
    /// <value>Boolean whether or not to recurse into directories.</value>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeLogsJobRequest {\n");

        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  Recurse: ").Append(Recurse).Append("\n");
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
        return Equals(obj as EdgeLogsJobRequest);
    }

    /// <summary>
    /// Returns true if EdgeLogsJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeLogsJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeLogsJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Path == other.Path ||
                Path != null &&
                Path.Equals(other.Path)
            ) &&
            (
                Query == other.Query ||
                Query != null &&
                Query.Equals(other.Query)
            ) &&
            (
                Recurse == other.Recurse ||
                Recurse != null &&
                Recurse.Equals(other.Recurse)
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
            if (Path != null)
            {
                hash = hash * 59 + Path.GetHashCode();
            }

            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (Recurse != null)
            {
                hash = hash * 59 + Recurse.GetHashCode();
            }

            return hash;
        }
    }
}
