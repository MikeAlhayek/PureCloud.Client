using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionCannedResponse
/// </summary>

public partial class SuggestionCannedResponse : IEquatable<SuggestionCannedResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionCannedResponse" /> class.
    /// </summary>
    public SuggestionCannedResponse()
    {

    }



    /// <summary>
    /// The suggested response.
    /// </summary>
    /// <value>The suggested response.</value>
    [JsonPropertyName("response")]
    public AddressableEntityRef Response { get; private set; }



    /// <summary>
    /// The library from which the canned response is suggested
    /// </summary>
    /// <value>The library from which the canned response is suggested</value>
    [JsonPropertyName("library")]
    public AddressableEntityRef Library { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionCannedResponse {\n");

        sb.Append("  Response: ").Append(Response).Append("\n");
        sb.Append("  Library: ").Append(Library).Append("\n");
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
        return Equals(obj as SuggestionCannedResponse);
    }

    /// <summary>
    /// Returns true if SuggestionCannedResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionCannedResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionCannedResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Response == other.Response ||
                Response != null &&
                Response.Equals(other.Response)
            ) &&
            (
                Library == other.Library ||
                Library != null &&
                Library.Equals(other.Library)
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
            if (Response != null)
            {
                hash = hash * 59 + Response.GetHashCode();
            }

            if (Library != null)
            {
                hash = hash * 59 + Library.GetHashCode();
            }

            return hash;
        }
    }
}
