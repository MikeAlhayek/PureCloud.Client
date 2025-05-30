using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JsonCursorSearchResponse
/// </summary>

public partial class JsonCursorSearchResponse : IEquatable<JsonCursorSearchResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonCursorSearchResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JsonCursorSearchResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JsonCursorSearchResponse" /> class.
    /// </summary>
    /// <param name="Types">Resource types the search was performed against (required).</param>
    /// <param name="Results">Search results (required).</param>
    /// <param name="Aggregations">Aggregations.</param>
    /// <param name="Cursor">The page cursor.</param>
    public JsonCursorSearchResponse(List<string> Types = null, object Results = null, object Aggregations = null, string Cursor = null)
    {
        this.Types = Types;
        this.Results = Results;
        this.Aggregations = Aggregations;
        this.Cursor = Cursor;

    }



    /// <summary>
    /// Resource types the search was performed against
    /// </summary>
    /// <value>Resource types the search was performed against</value>
    [JsonPropertyName("types")]
    public List<string> Types { get; set; }



    /// <summary>
    /// Search results
    /// </summary>
    /// <value>Search results</value>
    [JsonPropertyName("results")]
    public object Results { get; set; }



    /// <summary>
    /// Gets or Sets Aggregations
    /// </summary>
    [JsonPropertyName("aggregations")]
    public object Aggregations { get; set; }



    /// <summary>
    /// The page cursor
    /// </summary>
    /// <value>The page cursor</value>
    [JsonPropertyName("cursor")]
    public string Cursor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JsonCursorSearchResponse {\n");

        sb.Append("  Types: ").Append(Types).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
        sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
        return Equals(obj as JsonCursorSearchResponse);
    }

    /// <summary>
    /// Returns true if JsonCursorSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of JsonCursorSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JsonCursorSearchResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Types == other.Types ||
                Types != null &&
                Types.SequenceEqual(other.Types)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.Equals(other.Results)
            ) &&
            (
                Aggregations == other.Aggregations ||
                Aggregations != null &&
                Aggregations.Equals(other.Aggregations)
            ) &&
            (
                Cursor == other.Cursor ||
                Cursor != null &&
                Cursor.Equals(other.Cursor)
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
            if (Types != null)
            {
                hash = hash * 59 + Types.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (Aggregations != null)
            {
                hash = hash * 59 + Aggregations.GetHashCode();
            }

            if (Cursor != null)
            {
                hash = hash * 59 + Cursor.GetHashCode();
            }

            return hash;
        }
    }
}
