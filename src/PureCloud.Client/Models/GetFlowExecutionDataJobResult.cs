using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// This is a list of executionData links that can be used to download the complete executionData
/// </summary>

public partial class GetFlowExecutionDataJobResult : IEquatable<GetFlowExecutionDataJobResult>
{
    /// <summary>
    /// The state of the backend process to prep the files for download.
    /// </summary>
    /// <value>The state of the backend process to prep the files for download.</value>
    
    public enum JobStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Registered for "Registered"
        /// </summary>
        [EnumMember(Value = "Registered")]
        Registered,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// The state of the backend process to prep the files for download.
    /// </summary>
    /// <value>The state of the backend process to prep the files for download.</value>
    [JsonPropertyName("jobState")]
    public JobStateEnum? JobState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetFlowExecutionDataJobResult" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Entities">On jobState &#x3D; Success this field will be populated with the list of results of files for download..</param>
    /// <param name="JobState">The state of the backend process to prep the files for download..</param>
    public GetFlowExecutionDataJobResult(string Name = null, List<ExecutionDataEntity> Entities = null, JobStateEnum? JobState = null)
    {
        this.Name = Name;
        this.Entities = Entities;
        this.JobState = JobState;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// On jobState &#x3D; Success this field will be populated with the list of results of files for download.
    /// </summary>
    /// <value>On jobState &#x3D; Success this field will be populated with the list of results of files for download.</value>
    [JsonPropertyName("entities")]
    public List<ExecutionDataEntity> Entities { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetFlowExecutionDataJobResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  JobState: ").Append(JobState).Append("\n");
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
        return Equals(obj as GetFlowExecutionDataJobResult);
    }

    /// <summary>
    /// Returns true if GetFlowExecutionDataJobResult instances are equal
    /// </summary>
    /// <param name="other">Instance of GetFlowExecutionDataJobResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GetFlowExecutionDataJobResult other)
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
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                JobState == other.JobState ||
                JobState != null &&
                JobState.Equals(other.JobState)
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

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (JobState != null)
            {
                hash = hash * 59 + JobState.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
