using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityPlanRunJobResponse
/// </summary>
[DataContract]
public partial class ActivityPlanRunJobResponse : IEquatable<ActivityPlanRunJobResponse>
{
    /// <summary>
    /// The status of the job
    /// </summary>
    /// <value>The status of the job</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The status of the job
    /// </summary>
    /// <value>The status of the job</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityPlanRunJobResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActivityPlanRunJobResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityPlanRunJobResponse" /> class.
    /// </summary>
    /// <param name="ActivityPlan">The activity plan associated with this job (required).</param>
    /// <param name="Status">The status of the job (required).</param>
    /// <param name="Exceptions">The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing (required).</param>
    /// <param name="Error">Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete.</param>
    public ActivityPlanRunJobResponse(ActivityPlanReference ActivityPlan = null, StatusEnum? Status = null, List<ActivityPlanJobException> Exceptions = null, ErrorBody Error = null)
    {
        this.ActivityPlan = ActivityPlan;
        this.Status = Status;
        this.Exceptions = Exceptions;
        this.Error = Error;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The activity plan associated with this job
    /// </summary>
    /// <value>The activity plan associated with this job</value>
    [DataMember(Name = "activityPlan", EmitDefaultValue = false)]
    public ActivityPlanReference ActivityPlan { get; set; }





    /// <summary>
    /// The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing
    /// </summary>
    /// <value>The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing</value>
    [DataMember(Name = "exceptions", EmitDefaultValue = false)]
    public List<ActivityPlanJobException> Exceptions { get; set; }



    /// <summary>
    /// Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete
    /// </summary>
    /// <value>Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public ErrorBody Error { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActivityPlanRunJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ActivityPlan: ").Append(ActivityPlan).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
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
        return Equals(obj as ActivityPlanRunJobResponse);
    }

    /// <summary>
    /// Returns true if ActivityPlanRunJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ActivityPlanRunJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActivityPlanRunJobResponse other)
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
                ActivityPlan == other.ActivityPlan ||
                ActivityPlan != null &&
                ActivityPlan.Equals(other.ActivityPlan)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Exceptions == other.Exceptions ||
                Exceptions != null &&
                Exceptions.SequenceEqual(other.Exceptions)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
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

            if (ActivityPlan != null)
            {
                hash = hash * 59 + ActivityPlan.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Exceptions != null)
            {
                hash = hash * 59 + Exceptions.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
