using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FaxSendResponse
/// </summary>

public partial class FaxSendResponse : IEquatable<FaxSendResponse>
{
    /// <summary>
    /// Gets or Sets UploadMethodType
    /// </summary>
    
    public enum UploadMethodTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum SinglePut for "SINGLE_PUT"
        /// </summary>
        [EnumMember(Value = "SINGLE_PUT")]
        SinglePut,

        /// <summary>
        /// Enum MultipartPost for "MULTIPART_POST"
        /// </summary>
        [EnumMember(Value = "MULTIPART_POST")]
        MultipartPost
    }
    /// <summary>
    /// Gets or Sets UploadMethodType
    /// </summary>
    [JsonPropertyName("uploadMethodType")]
    public UploadMethodTypeEnum? UploadMethodType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxSendResponse" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="UploadDestinationUri">UploadDestinationUri.</param>
    /// <param name="UploadMethodType">UploadMethodType.</param>
    /// <param name="Headers">Headers.</param>
    public FaxSendResponse(string Name = null, string UploadDestinationUri = null, UploadMethodTypeEnum? UploadMethodType = null, Dictionary<string, string> Headers = null)
    {
        this.Name = Name;
        this.UploadDestinationUri = UploadDestinationUri;
        this.UploadMethodType = UploadMethodType;
        this.Headers = Headers;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets UploadDestinationUri
    /// </summary>
    [JsonPropertyName("uploadDestinationUri")]
    public string UploadDestinationUri { get; set; }





    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FaxSendResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UploadDestinationUri: ").Append(UploadDestinationUri).Append("\n");
        sb.Append("  UploadMethodType: ").Append(UploadMethodType).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as FaxSendResponse);
    }

    /// <summary>
    /// Returns true if FaxSendResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of FaxSendResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FaxSendResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                UploadDestinationUri == other.UploadDestinationUri ||
                UploadDestinationUri != null &&
                UploadDestinationUri.Equals(other.UploadDestinationUri)
            ) &&
            (
                UploadMethodType == other.UploadMethodType ||
                UploadMethodType != null &&
                UploadMethodType.Equals(other.UploadMethodType)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (UploadDestinationUri != null)
            {
                hash = hash * 59 + UploadDestinationUri.GetHashCode();
            }

            if (UploadMethodType != null)
            {
                hash = hash * 59 + UploadMethodType.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
