using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DownloadResponse
/// </summary>

public partial class DownloadResponse : IEquatable<DownloadResponse>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DownloadResponse" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ContentLocationUri">ContentLocationUri.</param>
    /// <param name="ImageUri">ImageUri.</param>
    /// <param name="Thumbnails">Thumbnails.</param>
    /// <param name="State">State.</param>
    /// <param name="ResultUri">ResultUri.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public DownloadResponse(string Id = null, string ContentLocationUri = null, string ImageUri = null, List<DocumentThumbnail> Thumbnails = null, StateEnum? State = null, string ResultUri = null, string SelfUri = null)
    {
        this.Id = Id;
        this.ContentLocationUri = ContentLocationUri;
        this.ImageUri = ImageUri;
        this.Thumbnails = Thumbnails;
        this.State = State;
        this.ResultUri = ResultUri;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ContentLocationUri
    /// </summary>
    [JsonPropertyName("contentLocationUri")]
    public string ContentLocationUri { get; set; }



    /// <summary>
    /// Gets or Sets ImageUri
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string ImageUri { get; set; }



    /// <summary>
    /// Gets or Sets Thumbnails
    /// </summary>
    [JsonPropertyName("thumbnails")]
    public List<DocumentThumbnail> Thumbnails { get; set; }





    /// <summary>
    /// Gets or Sets ResultUri
    /// </summary>
    [JsonPropertyName("resultUri")]
    public string ResultUri { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DownloadResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ContentLocationUri: ").Append(ContentLocationUri).Append("\n");
        sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
        sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ResultUri: ").Append(ResultUri).Append("\n");
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
        return Equals(obj as DownloadResponse);
    }

    /// <summary>
    /// Returns true if DownloadResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of DownloadResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DownloadResponse other)
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
                ContentLocationUri == other.ContentLocationUri ||
                ContentLocationUri != null &&
                ContentLocationUri.Equals(other.ContentLocationUri)
            ) &&
            (
                ImageUri == other.ImageUri ||
                ImageUri != null &&
                ImageUri.Equals(other.ImageUri)
            ) &&
            (
                Thumbnails == other.Thumbnails ||
                Thumbnails != null &&
                Thumbnails.SequenceEqual(other.Thumbnails)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ResultUri == other.ResultUri ||
                ResultUri != null &&
                ResultUri.Equals(other.ResultUri)
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

            if (ContentLocationUri != null)
            {
                hash = hash * 59 + ContentLocationUri.GetHashCode();
            }

            if (ImageUri != null)
            {
                hash = hash * 59 + ImageUri.GetHashCode();
            }

            if (Thumbnails != null)
            {
                hash = hash * 59 + Thumbnails.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ResultUri != null)
            {
                hash = hash * 59 + ResultUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
