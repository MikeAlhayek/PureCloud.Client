using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Site
/// </summary>

public partial class Site : IEquatable<Site>
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
    /// Media model for the site
    /// </summary>
    /// <value>Media model for the site</value>
    
    public enum MediaModelEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Premises for "Premises"
        /// </summary>
        [EnumMember(Value = "Premises")]
        Premises,

        /// <summary>
        /// Enum Cloud for "Cloud"
        /// </summary>
        [EnumMember(Value = "Cloud")]
        Cloud
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// Media model for the site
    /// </summary>
    /// <value>Media model for the site</value>
    [JsonPropertyName("mediaModel")]
    public MediaModelEnum? MediaModel { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Site" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Site() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Site" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="PrimarySites">PrimarySites.</param>
    /// <param name="SecondarySites">SecondarySites.</param>
    /// <param name="PrimaryEdges">PrimaryEdges.</param>
    /// <param name="SecondaryEdges">SecondaryEdges.</param>
    /// <param name="Addresses">Addresses.</param>
    /// <param name="Edges">Edges.</param>
    /// <param name="EdgeAutoUpdateConfig">Recurrance rule, time zone, and start/end settings for automatic edge updates for this site.</param>
    /// <param name="MediaRegionsUseLatencyBased">MediaRegionsUseLatencyBased.</param>
    /// <param name="Location">Location (required).</param>
    /// <param name="Managed">Managed.</param>
    /// <param name="NtpSettings">Network Time Protocol settings for the site.</param>
    /// <param name="MediaModel">Media model for the site.</param>
    /// <param name="CoreSite">Is this site a core site.</param>
    /// <param name="SiteConnections">The site connections.</param>
    /// <param name="MediaRegions">The ordered list of AWS regions through which media can stream..</param>
    /// <param name="CallerId">The caller ID value for the site..</param>
    /// <param name="CallerName">The caller name for the site..</param>
    /// <param name="CloudProxyForceTurn">Enables premises Edge Force Turn .</param>
    public Site(string Name = null, Division Division = null, string Description = null, int? Version = null, List<DomainEntityRef> PrimarySites = null, List<DomainEntityRef> SecondarySites = null, List<Edge> PrimaryEdges = null, List<Edge> SecondaryEdges = null, List<Contact> Addresses = null, List<Edge> Edges = null, EdgeAutoUpdateConfig EdgeAutoUpdateConfig = null, bool? MediaRegionsUseLatencyBased = null, LocationDefinition Location = null, bool? Managed = null, NTPSettings NtpSettings = null, MediaModelEnum? MediaModel = null, bool? CoreSite = null, List<SiteConnection> SiteConnections = null, List<string> MediaRegions = null, string CallerId = null, string CallerName = null, bool? CloudProxyForceTurn = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.PrimarySites = PrimarySites;
        this.SecondarySites = SecondarySites;
        this.PrimaryEdges = PrimaryEdges;
        this.SecondaryEdges = SecondaryEdges;
        this.Addresses = Addresses;
        this.Edges = Edges;
        this.EdgeAutoUpdateConfig = EdgeAutoUpdateConfig;
        this.MediaRegionsUseLatencyBased = MediaRegionsUseLatencyBased;
        this.Location = Location;
        this.Managed = Managed;
        this.NtpSettings = NtpSettings;
        this.MediaModel = MediaModel;
        this.CoreSite = CoreSite;
        this.SiteConnections = SiteConnections;
        this.MediaRegions = MediaRegions;
        this.CallerId = CallerId;
        this.CallerName = CallerName;
        this.CloudProxyForceTurn = CloudProxyForceTurn;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
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
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; private set; }



    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; private set; }





    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    [JsonPropertyName("modifiedByApp")]
    public string ModifiedByApp { get; private set; }



    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    [JsonPropertyName("createdByApp")]
    public string CreatedByApp { get; private set; }



    /// <summary>
    /// Gets or Sets PrimarySites
    /// </summary>
    [JsonPropertyName("primarySites")]
    public List<DomainEntityRef> PrimarySites { get; set; }



    /// <summary>
    /// Gets or Sets SecondarySites
    /// </summary>
    [JsonPropertyName("secondarySites")]
    public List<DomainEntityRef> SecondarySites { get; set; }



    /// <summary>
    /// Gets or Sets PrimaryEdges
    /// </summary>
    [JsonPropertyName("primaryEdges")]
    public List<Edge> PrimaryEdges { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryEdges
    /// </summary>
    [JsonPropertyName("secondaryEdges")]
    public List<Edge> SecondaryEdges { get; set; }



    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [JsonPropertyName("addresses")]
    public List<Contact> Addresses { get; set; }



    /// <summary>
    /// Gets or Sets Edges
    /// </summary>
    [JsonPropertyName("edges")]
    public List<Edge> Edges { get; set; }



    /// <summary>
    /// Recurrance rule, time zone, and start/end settings for automatic edge updates for this site
    /// </summary>
    /// <value>Recurrance rule, time zone, and start/end settings for automatic edge updates for this site</value>
    [JsonPropertyName("edgeAutoUpdateConfig")]
    public EdgeAutoUpdateConfig EdgeAutoUpdateConfig { get; set; }



    /// <summary>
    /// Gets or Sets MediaRegionsUseLatencyBased
    /// </summary>
    [JsonPropertyName("mediaRegionsUseLatencyBased")]
    public bool? MediaRegionsUseLatencyBased { get; set; }



    /// <summary>
    /// Location
    /// </summary>
    /// <value>Location</value>
    [JsonPropertyName("location")]
    public LocationDefinition Location { get; set; }



    /// <summary>
    /// Gets or Sets Managed
    /// </summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }



    /// <summary>
    /// Network Time Protocol settings for the site
    /// </summary>
    /// <value>Network Time Protocol settings for the site</value>
    [JsonPropertyName("ntpSettings")]
    public NTPSettings NtpSettings { get; set; }





    /// <summary>
    /// Is this site a core site
    /// </summary>
    /// <value>Is this site a core site</value>
    [JsonPropertyName("coreSite")]
    public bool? CoreSite { get; set; }



    /// <summary>
    /// The site connections
    /// </summary>
    /// <value>The site connections</value>
    [JsonPropertyName("siteConnections")]
    public List<SiteConnection> SiteConnections { get; set; }



    /// <summary>
    /// The ordered list of AWS regions through which media can stream.
    /// </summary>
    /// <value>The ordered list of AWS regions through which media can stream.</value>
    [JsonPropertyName("mediaRegions")]
    public List<string> MediaRegions { get; set; }



    /// <summary>
    /// The caller ID value for the site.
    /// </summary>
    /// <value>The caller ID value for the site.</value>
    [JsonPropertyName("callerId")]
    public string CallerId { get; set; }



    /// <summary>
    /// The caller name for the site.
    /// </summary>
    /// <value>The caller name for the site.</value>
    [JsonPropertyName("callerName")]
    public string CallerName { get; set; }



    /// <summary>
    /// Enables premises Edge Force Turn 
    /// </summary>
    /// <value>Enables premises Edge Force Turn </value>
    [JsonPropertyName("cloudProxyForceTurn")]
    public bool? CloudProxyForceTurn { get; set; }



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
        sb.Append("class Site {\n");

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
        sb.Append("  PrimarySites: ").Append(PrimarySites).Append("\n");
        sb.Append("  SecondarySites: ").Append(SecondarySites).Append("\n");
        sb.Append("  PrimaryEdges: ").Append(PrimaryEdges).Append("\n");
        sb.Append("  SecondaryEdges: ").Append(SecondaryEdges).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  Edges: ").Append(Edges).Append("\n");
        sb.Append("  EdgeAutoUpdateConfig: ").Append(EdgeAutoUpdateConfig).Append("\n");
        sb.Append("  MediaRegionsUseLatencyBased: ").Append(MediaRegionsUseLatencyBased).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  Managed: ").Append(Managed).Append("\n");
        sb.Append("  NtpSettings: ").Append(NtpSettings).Append("\n");
        sb.Append("  MediaModel: ").Append(MediaModel).Append("\n");
        sb.Append("  CoreSite: ").Append(CoreSite).Append("\n");
        sb.Append("  SiteConnections: ").Append(SiteConnections).Append("\n");
        sb.Append("  MediaRegions: ").Append(MediaRegions).Append("\n");
        sb.Append("  CallerId: ").Append(CallerId).Append("\n");
        sb.Append("  CallerName: ").Append(CallerName).Append("\n");
        sb.Append("  CloudProxyForceTurn: ").Append(CloudProxyForceTurn).Append("\n");
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
        return Equals(obj as Site);
    }

    /// <summary>
    /// Returns true if Site instances are equal
    /// </summary>
    /// <param name="other">Instance of Site to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Site other)
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
                PrimarySites == other.PrimarySites ||
                PrimarySites != null &&
                PrimarySites.SequenceEqual(other.PrimarySites)
            ) &&
            (
                SecondarySites == other.SecondarySites ||
                SecondarySites != null &&
                SecondarySites.SequenceEqual(other.SecondarySites)
            ) &&
            (
                PrimaryEdges == other.PrimaryEdges ||
                PrimaryEdges != null &&
                PrimaryEdges.SequenceEqual(other.PrimaryEdges)
            ) &&
            (
                SecondaryEdges == other.SecondaryEdges ||
                SecondaryEdges != null &&
                SecondaryEdges.SequenceEqual(other.SecondaryEdges)
            ) &&
            (
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                Edges == other.Edges ||
                Edges != null &&
                Edges.SequenceEqual(other.Edges)
            ) &&
            (
                EdgeAutoUpdateConfig == other.EdgeAutoUpdateConfig ||
                EdgeAutoUpdateConfig != null &&
                EdgeAutoUpdateConfig.Equals(other.EdgeAutoUpdateConfig)
            ) &&
            (
                MediaRegionsUseLatencyBased == other.MediaRegionsUseLatencyBased ||
                MediaRegionsUseLatencyBased != null &&
                MediaRegionsUseLatencyBased.Equals(other.MediaRegionsUseLatencyBased)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
            ) &&
            (
                Managed == other.Managed ||
                Managed != null &&
                Managed.Equals(other.Managed)
            ) &&
            (
                NtpSettings == other.NtpSettings ||
                NtpSettings != null &&
                NtpSettings.Equals(other.NtpSettings)
            ) &&
            (
                MediaModel == other.MediaModel ||
                MediaModel != null &&
                MediaModel.Equals(other.MediaModel)
            ) &&
            (
                CoreSite == other.CoreSite ||
                CoreSite != null &&
                CoreSite.Equals(other.CoreSite)
            ) &&
            (
                SiteConnections == other.SiteConnections ||
                SiteConnections != null &&
                SiteConnections.SequenceEqual(other.SiteConnections)
            ) &&
            (
                MediaRegions == other.MediaRegions ||
                MediaRegions != null &&
                MediaRegions.SequenceEqual(other.MediaRegions)
            ) &&
            (
                CallerId == other.CallerId ||
                CallerId != null &&
                CallerId.Equals(other.CallerId)
            ) &&
            (
                CallerName == other.CallerName ||
                CallerName != null &&
                CallerName.Equals(other.CallerName)
            ) &&
            (
                CloudProxyForceTurn == other.CloudProxyForceTurn ||
                CloudProxyForceTurn != null &&
                CloudProxyForceTurn.Equals(other.CloudProxyForceTurn)
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

            if (PrimarySites != null)
            {
                hash = hash * 59 + PrimarySites.GetHashCode();
            }

            if (SecondarySites != null)
            {
                hash = hash * 59 + SecondarySites.GetHashCode();
            }

            if (PrimaryEdges != null)
            {
                hash = hash * 59 + PrimaryEdges.GetHashCode();
            }

            if (SecondaryEdges != null)
            {
                hash = hash * 59 + SecondaryEdges.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (Edges != null)
            {
                hash = hash * 59 + Edges.GetHashCode();
            }

            if (EdgeAutoUpdateConfig != null)
            {
                hash = hash * 59 + EdgeAutoUpdateConfig.GetHashCode();
            }

            if (MediaRegionsUseLatencyBased != null)
            {
                hash = hash * 59 + MediaRegionsUseLatencyBased.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            if (Managed != null)
            {
                hash = hash * 59 + Managed.GetHashCode();
            }

            if (NtpSettings != null)
            {
                hash = hash * 59 + NtpSettings.GetHashCode();
            }

            if (MediaModel != null)
            {
                hash = hash * 59 + MediaModel.GetHashCode();
            }

            if (CoreSite != null)
            {
                hash = hash * 59 + CoreSite.GetHashCode();
            }

            if (SiteConnections != null)
            {
                hash = hash * 59 + SiteConnections.GetHashCode();
            }

            if (MediaRegions != null)
            {
                hash = hash * 59 + MediaRegions.GetHashCode();
            }

            if (CallerId != null)
            {
                hash = hash * 59 + CallerId.GetHashCode();
            }

            if (CallerName != null)
            {
                hash = hash * 59 + CallerName.GetHashCode();
            }

            if (CloudProxyForceTurn != null)
            {
                hash = hash * 59 + CloudProxyForceTurn.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
