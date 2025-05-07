using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Endpoint
/// </summary>

public partial class Endpoint : IEquatable<Endpoint>
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    
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
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Endpoint" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Endpoint() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Endpoint" /> class.
    /// </summary>
    /// <param name="Name">Name (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="Count">Count.</param>
    /// <param name="Properties">Properties.</param>
    /// <param name="Schema">Schema (required).</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="Site">Site.</param>
    /// <param name="Dids">Dids.</param>
    public Endpoint(string Name = null, Division Division = null, string Description = null, int? Version = null, int? Count = null, Dictionary<string, object> Properties = null, DomainEntityRef Schema = null, bool? Enabled = null, DomainEntityRef Site = null, List<string> Dids = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.Count = Count;
        this.Properties = Properties;
        this.Schema = Schema;
        this.Enabled = Enabled;
        this.Site = Site;
        this.Dids = Dids;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// The resource&#39;s description.
    /// </summary>
    /// <value>The resource&#39;s description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The current version of the resource.
    /// </summary>
    /// <value>The current version of the resource.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }



    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }





    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    [JsonPropertyName("modifiedByApp")]
    public string ModifiedByApp { get; set; }



    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    [JsonPropertyName("createdByApp")]
    public string CreatedByApp { get; set; }



    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }



    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, object> Properties { get; set; }



    /// <summary>
    /// Schema
    /// </summary>
    /// <value>Schema</value>
    [JsonPropertyName("schema")]
    public DomainEntityRef Schema { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    [JsonPropertyName("site")]
    public DomainEntityRef Site { get; set; }



    /// <summary>
    /// Gets or Sets Dids
    /// </summary>
    [JsonPropertyName("dids")]
    public List<string> Dids { get; set; }



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
        sb.Append("class Endpoint {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
        sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  Dids: ").Append(Dids).Append("\n");
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
        return Equals(obj as Endpoint);
    }

    /// <summary>
    /// Returns true if Endpoint instances are equal
    /// </summary>
    /// <param name="other">Instance of Endpoint to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Endpoint other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ModifiedByApp == other.ModifiedByApp ||
                ModifiedByApp != null &&
                ModifiedByApp.Equals(other.ModifiedByApp)
            ) &&
            (
                CreatedByApp == other.CreatedByApp ||
                CreatedByApp != null &&
                CreatedByApp.Equals(other.CreatedByApp)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Site == other.Site ||
                Site != null &&
                Site.Equals(other.Site)
            ) &&
            (
                Dids == other.Dids ||
                Dids != null &&
                Dids.SequenceEqual(other.Dids)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ModifiedByApp != null)
            {
                hash = hash * 59 + ModifiedByApp.GetHashCode();
            }

            if (CreatedByApp != null)
            {
                hash = hash * 59 + CreatedByApp.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Site != null)
            {
                hash = hash * 59 + Site.GetHashCode();
            }

            if (Dids != null)
            {
                hash = hash * 59 + Dids.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
