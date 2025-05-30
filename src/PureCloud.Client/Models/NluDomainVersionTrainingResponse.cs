using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDomainVersionTrainingResponse
/// </summary>

public partial class NluDomainVersionTrainingResponse : IEquatable<NluDomainVersionTrainingResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersionTrainingResponse" /> class.
    /// </summary>
    /// <param name="Version">Version.</param>
    public NluDomainVersionTrainingResponse(NluDomainVersion Version = null)
    {
        this.Version = Version;

    }



    /// <summary>
    /// A message indicating result of the action.
    /// </summary>
    /// <value>A message indicating result of the action.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public NluDomainVersion Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluDomainVersionTrainingResponse {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as NluDomainVersionTrainingResponse);
    }

    /// <summary>
    /// Returns true if NluDomainVersionTrainingResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDomainVersionTrainingResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDomainVersionTrainingResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
