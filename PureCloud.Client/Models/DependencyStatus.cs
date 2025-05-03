using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DependencyStatus
/// </summary>

public partial class DependencyStatus : IEquatable<DependencyStatus>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
        /// Enum Buildincomplete for "BUILDINCOMPLETE"
        /// </summary>
        [EnumMember(Value = "BUILDINCOMPLETE")]
        Buildincomplete,

        /// <summary>
        /// Enum Buildinitializing for "BUILDINITIALIZING"
        /// </summary>
        [EnumMember(Value = "BUILDINITIALIZING")]
        Buildinitializing,

        /// <summary>
        /// Enum Buildinprogress for "BUILDINPROGRESS"
        /// </summary>
        [EnumMember(Value = "BUILDINPROGRESS")]
        Buildinprogress,

        /// <summary>
        /// Enum Notbuilt for "NOTBUILT"
        /// </summary>
        [EnumMember(Value = "NOTBUILT")]
        Notbuilt,

        /// <summary>
        /// Enum Operational for "OPERATIONAL"
        /// </summary>
        [EnumMember(Value = "OPERATIONAL")]
        Operational,

        /// <summary>
        /// Enum Operationalneedsrebuild for "OPERATIONALNEEDSREBUILD"
        /// </summary>
        [EnumMember(Value = "OPERATIONALNEEDSREBUILD")]
        Operationalneedsrebuild
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DependencyStatus" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="User">User that initiated the build..</param>
    /// <param name="Client">OAuth client that initiated the build..</param>
    /// <param name="BuildId">BuildId.</param>
    /// <param name="DateStarted">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateCompleted">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Status">Status.</param>
    /// <param name="FailedObjects">FailedObjects.</param>
    public DependencyStatus(string Name = null, User User = null, DomainEntityRef Client = null, string BuildId = null, DateTime? DateStarted = null, DateTime? DateCompleted = null, StatusEnum? Status = null, List<FailedObject> FailedObjects = null)
    {
        this.Name = Name;
        this.User = User;
        this.Client = Client;
        this.BuildId = BuildId;
        this.DateStarted = DateStarted;
        this.DateCompleted = DateCompleted;
        this.Status = Status;
        this.FailedObjects = FailedObjects;

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
    /// User that initiated the build.
    /// </summary>
    /// <value>User that initiated the build.</value>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// OAuth client that initiated the build.
    /// </summary>
    /// <value>OAuth client that initiated the build.</value>
    [JsonPropertyName("client")]
    public DomainEntityRef Client { get; set; }



    /// <summary>
    /// Gets or Sets BuildId
    /// </summary>
    [JsonPropertyName("buildId")]
    public string BuildId { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; set; }





    /// <summary>
    /// Gets or Sets FailedObjects
    /// </summary>
    [JsonPropertyName("failedObjects")]
    public List<FailedObject> FailedObjects { get; set; }



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
        sb.Append("class DependencyStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  BuildId: ").Append(BuildId).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  FailedObjects: ").Append(FailedObjects).Append("\n");
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
        return Equals(obj as DependencyStatus);
    }

    /// <summary>
    /// Returns true if DependencyStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of DependencyStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DependencyStatus other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                BuildId == other.BuildId ||
                BuildId != null &&
                BuildId.Equals(other.BuildId)
            ) &&
            (
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                FailedObjects == other.FailedObjects ||
                FailedObjects != null &&
                FailedObjects.SequenceEqual(other.FailedObjects)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (BuildId != null)
            {
                hash = hash * 59 + BuildId.GetHashCode();
            }

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (FailedObjects != null)
            {
                hash = hash * 59 + FailedObjects.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
