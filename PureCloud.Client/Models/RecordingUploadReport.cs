using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingUploadReport
/// </summary>

public partial class RecordingUploadReport : IEquatable<RecordingUploadReport>
{
    /// <summary>
    /// The current status of the upload report.
    /// </summary>
    /// <value>The current status of the upload report.</value>
    
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
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// The current status of the upload report.
    /// </summary>
    /// <value>The current status of the upload report.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingUploadReport" /> class.
    /// </summary>
    /// <param name="Id">The report id..</param>
    /// <param name="Name">Name.</param>
    /// <param name="State">The current status of the upload report..</param>
    /// <param name="SignedUrl">For COMPLETED tasks, the signed url to download the report..</param>
    public RecordingUploadReport(string Id = null, string Name = null, StateEnum? State = null, string SignedUrl = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.State = State;
        this.SignedUrl = SignedUrl;

    }



    /// <summary>
    /// The report id.
    /// </summary>
    /// <value>The report id.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// For COMPLETED tasks, the signed url to download the report.
    /// </summary>
    /// <value>For COMPLETED tasks, the signed url to download the report.</value>
    [JsonPropertyName("signedUrl")]
    public string SignedUrl { get; set; }



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
        sb.Append("class RecordingUploadReport {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  SignedUrl: ").Append(SignedUrl).Append("\n");
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
        return Equals(obj as RecordingUploadReport);
    }

    /// <summary>
    /// Returns true if RecordingUploadReport instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingUploadReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingUploadReport other)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                SignedUrl == other.SignedUrl ||
                SignedUrl != null &&
                SignedUrl.Equals(other.SignedUrl)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (SignedUrl != null)
            {
                hash = hash * 59 + SignedUrl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
