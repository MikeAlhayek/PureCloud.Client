using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Workspace
/// </summary>

public partial class Workspace : IEquatable<Workspace>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Workspace" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Workspace() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Workspace" /> class.
    /// </summary>
    /// <param name="Name">The current name of the workspace. (required).</param>
    /// <param name="Type">Type.</param>
    /// <param name="IsCurrentUserWorkspace">IsCurrentUserWorkspace.</param>
    /// <param name="User">User.</param>
    /// <param name="Bucket">Bucket.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Summary">Summary.</param>
    /// <param name="Acl">Acl.</param>
    /// <param name="Description">Description.</param>
    public Workspace(string Name = null, TypeEnum? Type = null, bool? IsCurrentUserWorkspace = null, DomainEntityRef User = null, string Bucket = null, DateTime? DateCreated = null, DateTime? DateModified = null, WorkspaceSummary Summary = null, List<string> Acl = null, string Description = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.IsCurrentUserWorkspace = IsCurrentUserWorkspace;
        this.User = User;
        this.Bucket = Bucket;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Summary = Summary;
        this.Acl = Acl;
        this.Description = Description;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The current name of the workspace.
    /// </summary>
    /// <value>The current name of the workspace.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// Gets or Sets IsCurrentUserWorkspace
    /// </summary>
    [JsonPropertyName("isCurrentUserWorkspace")]
    public bool? IsCurrentUserWorkspace { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public DomainEntityRef User { get; set; }



    /// <summary>
    /// Gets or Sets Bucket
    /// </summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [JsonPropertyName("summary")]
    public WorkspaceSummary Summary { get; set; }



    /// <summary>
    /// Gets or Sets Acl
    /// </summary>
    [JsonPropertyName("acl")]
    public List<string> Acl { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



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
        sb.Append("class Workspace {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  IsCurrentUserWorkspace: ").Append(IsCurrentUserWorkspace).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Bucket: ").Append(Bucket).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Summary: ").Append(Summary).Append("\n");
        sb.Append("  Acl: ").Append(Acl).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as Workspace);
    }

    /// <summary>
    /// Returns true if Workspace instances are equal
    /// </summary>
    /// <param name="other">Instance of Workspace to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Workspace other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                IsCurrentUserWorkspace == other.IsCurrentUserWorkspace ||
                IsCurrentUserWorkspace != null &&
                IsCurrentUserWorkspace.Equals(other.IsCurrentUserWorkspace)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Bucket == other.Bucket ||
                Bucket != null &&
                Bucket.Equals(other.Bucket)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Summary == other.Summary ||
                Summary != null &&
                Summary.Equals(other.Summary)
            ) &&
            (
                Acl == other.Acl ||
                Acl != null &&
                Acl.SequenceEqual(other.Acl)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (IsCurrentUserWorkspace != null)
            {
                hash = hash * 59 + IsCurrentUserWorkspace.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Bucket != null)
            {
                hash = hash * 59 + Bucket.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Summary != null)
            {
                hash = hash * 59 + Summary.GetHashCode();
            }

            if (Acl != null)
            {
                hash = hash * 59 + Acl.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
