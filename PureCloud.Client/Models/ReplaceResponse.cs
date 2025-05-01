using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReplaceResponse
/// </summary>
[DataContract]
public partial class ReplaceResponse : IEquatable<ReplaceResponse>
{
    /// <summary>
    /// Gets or Sets UploadMethod
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UploadMethodEnum
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
    /// Gets or Sets UploadMethod
    /// </summary>
    [DataMember(Name = "uploadMethod", EmitDefaultValue = false)]
    public UploadMethodEnum? UploadMethod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReplaceResponse" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="ChangeNumber">ChangeNumber.</param>
    /// <param name="UploadStatus">UploadStatus.</param>
    /// <param name="UploadDestinationUri">UploadDestinationUri.</param>
    /// <param name="UploadMethod">UploadMethod.</param>
    public ReplaceResponse(string Id = null, string Name = null, int? ChangeNumber = null, DomainEntityRef UploadStatus = null, string UploadDestinationUri = null, UploadMethodEnum? UploadMethod = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.ChangeNumber = ChangeNumber;
        this.UploadStatus = UploadStatus;
        this.UploadDestinationUri = UploadDestinationUri;
        this.UploadMethod = UploadMethod;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    [DataMember(Name = "changeNumber", EmitDefaultValue = false)]
    public int? ChangeNumber { get; set; }



    /// <summary>
    /// Gets or Sets UploadStatus
    /// </summary>
    [DataMember(Name = "uploadStatus", EmitDefaultValue = false)]
    public DomainEntityRef UploadStatus { get; set; }



    /// <summary>
    /// Gets or Sets UploadDestinationUri
    /// </summary>
    [DataMember(Name = "uploadDestinationUri", EmitDefaultValue = false)]
    public string UploadDestinationUri { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReplaceResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
        sb.Append("  UploadDestinationUri: ").Append(UploadDestinationUri).Append("\n");
        sb.Append("  UploadMethod: ").Append(UploadMethod).Append("\n");
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
        return Equals(obj as ReplaceResponse);
    }

    /// <summary>
    /// Returns true if ReplaceResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ReplaceResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReplaceResponse other)
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
                ChangeNumber == other.ChangeNumber ||
                ChangeNumber != null &&
                ChangeNumber.Equals(other.ChangeNumber)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
            ) &&
            (
                UploadDestinationUri == other.UploadDestinationUri ||
                UploadDestinationUri != null &&
                UploadDestinationUri.Equals(other.UploadDestinationUri)
            ) &&
            (
                UploadMethod == other.UploadMethod ||
                UploadMethod != null &&
                UploadMethod.Equals(other.UploadMethod)
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

            if (ChangeNumber != null)
            {
                hash = hash * 59 + ChangeNumber.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            if (UploadDestinationUri != null)
            {
                hash = hash * 59 + UploadDestinationUri.GetHashCode();
            }

            if (UploadMethod != null)
            {
                hash = hash * 59 + UploadMethod.GetHashCode();
            }

            return hash;
        }
    }
}
