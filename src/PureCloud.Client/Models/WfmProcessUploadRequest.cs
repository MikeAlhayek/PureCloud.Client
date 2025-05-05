using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmProcessUploadRequest
/// </summary>

public partial class WfmProcessUploadRequest : IEquatable<WfmProcessUploadRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmProcessUploadRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmProcessUploadRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmProcessUploadRequest" /> class.
    /// </summary>
    /// <param name="UploadKey">The uploadKey provided by the request to get an upload URL (required).</param>
    public WfmProcessUploadRequest(string UploadKey = null)
    {
        this.UploadKey = UploadKey;

    }



    /// <summary>
    /// The uploadKey provided by the request to get an upload URL
    /// </summary>
    /// <value>The uploadKey provided by the request to get an upload URL</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmProcessUploadRequest {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
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
        return Equals(obj as WfmProcessUploadRequest);
    }

    /// <summary>
    /// Returns true if WfmProcessUploadRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmProcessUploadRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmProcessUploadRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
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
            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            return hash;
        }
    }
}
