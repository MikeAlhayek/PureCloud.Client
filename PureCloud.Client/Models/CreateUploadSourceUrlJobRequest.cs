using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateUploadSourceUrlJobRequest
/// </summary>
[DataContract]
public partial class CreateUploadSourceUrlJobRequest : IEquatable<CreateUploadSourceUrlJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUploadSourceUrlJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateUploadSourceUrlJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUploadSourceUrlJobRequest" /> class.
    /// </summary>
    /// <param name="UploadUrl">The URL of the content to upload. (required).</param>
    public CreateUploadSourceUrlJobRequest(string UploadUrl = null)
    {
        this.UploadUrl = UploadUrl;

    }



    /// <summary>
    /// The URL of the content to upload.
    /// </summary>
    /// <value>The URL of the content to upload.</value>
    [DataMember(Name = "uploadUrl", EmitDefaultValue = false)]
    public string UploadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateUploadSourceUrlJobRequest {\n");

        sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
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
        return Equals(obj as CreateUploadSourceUrlJobRequest);
    }

    /// <summary>
    /// Returns true if CreateUploadSourceUrlJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateUploadSourceUrlJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateUploadSourceUrlJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadUrl == other.UploadUrl ||
                UploadUrl != null &&
                UploadUrl.Equals(other.UploadUrl)
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
            if (UploadUrl != null)
            {
                hash = hash * 59 + UploadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
