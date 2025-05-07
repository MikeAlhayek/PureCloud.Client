using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Phone
/// </summary>

public partial class Phone : IEquatable<Phone>
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
    /// Initializes a new instance of the <see cref="Phone" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Phone() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Phone" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="Site">The site associated to the phone. (required).</param>
    /// <param name="PhoneBaseSettings">Phone Base Settings (required).</param>
    /// <param name="LineBaseSettings">LineBaseSettings.</param>
    /// <param name="PhoneMetaBase">PhoneMetaBase.</param>
    /// <param name="Lines">Lines (required).</param>
    /// <param name="Status">The status of the phone and lines from the primary Edge..</param>
    /// <param name="SecondaryStatus">The status of the phone and lines from the secondary Edge..</param>
    /// <param name="Properties">Properties.</param>
    /// <param name="Capabilities">Capabilities.</param>
    /// <param name="WebRtcUser">This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones..</param>
    /// <param name="PrimaryEdge">PrimaryEdge.</param>
    /// <param name="SecondaryEdge">SecondaryEdge.</param>
    public Phone(string Name = null, Division Division = null, string Description = null, int? Version = null, DomainEntityRef Site = null, PhoneBaseSettings PhoneBaseSettings = null, DomainEntityRef LineBaseSettings = null, DomainEntityRef PhoneMetaBase = null, List<Line> Lines = null, PhoneStatus Status = null, PhoneStatus SecondaryStatus = null, Dictionary<string, object> Properties = null, PhoneCapabilities Capabilities = null, DomainEntityRef WebRtcUser = null, Edge PrimaryEdge = null, Edge SecondaryEdge = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.Site = Site;
        this.PhoneBaseSettings = PhoneBaseSettings;
        this.LineBaseSettings = LineBaseSettings;
        this.PhoneMetaBase = PhoneMetaBase;
        this.Lines = Lines;
        this.Status = Status;
        this.SecondaryStatus = SecondaryStatus;
        this.Properties = Properties;
        this.Capabilities = Capabilities;
        this.WebRtcUser = WebRtcUser;
        this.PrimaryEdge = PrimaryEdge;
        this.SecondaryEdge = SecondaryEdge;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



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
    /// The site associated to the phone.
    /// </summary>
    /// <value>The site associated to the phone.</value>
    [JsonPropertyName("site")]
    public DomainEntityRef Site { get; set; }



    /// <summary>
    /// Phone Base Settings
    /// </summary>
    /// <value>Phone Base Settings</value>
    [JsonPropertyName("phoneBaseSettings")]
    public PhoneBaseSettings PhoneBaseSettings { get; set; }



    /// <summary>
    /// Gets or Sets LineBaseSettings
    /// </summary>
    [JsonPropertyName("lineBaseSettings")]
    public DomainEntityRef LineBaseSettings { get; set; }



    /// <summary>
    /// Gets or Sets PhoneMetaBase
    /// </summary>
    [JsonPropertyName("phoneMetaBase")]
    public DomainEntityRef PhoneMetaBase { get; set; }



    /// <summary>
    /// Lines
    /// </summary>
    /// <value>Lines</value>
    [JsonPropertyName("lines")]
    public List<Line> Lines { get; set; }



    /// <summary>
    /// The status of the phone and lines from the primary Edge.
    /// </summary>
    /// <value>The status of the phone and lines from the primary Edge.</value>
    [JsonPropertyName("status")]
    public PhoneStatus Status { get; set; }



    /// <summary>
    /// The status of the phone and lines from the secondary Edge.
    /// </summary>
    /// <value>The status of the phone and lines from the secondary Edge.</value>
    [JsonPropertyName("secondaryStatus")]
    public PhoneStatus SecondaryStatus { get; set; }



    /// <summary>
    /// User Agent Information for this phone. This includes model, firmware version, and manufacturer.
    /// </summary>
    /// <value>User Agent Information for this phone. This includes model, firmware version, and manufacturer.</value>
    [JsonPropertyName("userAgentInfo")]
    public UserAgentInfo UserAgentInfo { get; set; }



    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, object> Properties { get; set; }



    /// <summary>
    /// Gets or Sets Capabilities
    /// </summary>
    [JsonPropertyName("capabilities")]
    public PhoneCapabilities Capabilities { get; set; }



    /// <summary>
    /// This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones.
    /// </summary>
    /// <value>This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones.</value>
    [JsonPropertyName("webRtcUser")]
    public DomainEntityRef WebRtcUser { get; set; }



    /// <summary>
    /// Gets or Sets PrimaryEdge
    /// </summary>
    [JsonPropertyName("primaryEdge")]
    public Edge PrimaryEdge { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryEdge
    /// </summary>
    [JsonPropertyName("secondaryEdge")]
    public Edge SecondaryEdge { get; set; }



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
        sb.Append("class Phone {\n");

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
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  PhoneBaseSettings: ").Append(PhoneBaseSettings).Append("\n");
        sb.Append("  LineBaseSettings: ").Append(LineBaseSettings).Append("\n");
        sb.Append("  PhoneMetaBase: ").Append(PhoneMetaBase).Append("\n");
        sb.Append("  Lines: ").Append(Lines).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  SecondaryStatus: ").Append(SecondaryStatus).Append("\n");
        sb.Append("  UserAgentInfo: ").Append(UserAgentInfo).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
        sb.Append("  WebRtcUser: ").Append(WebRtcUser).Append("\n");
        sb.Append("  PrimaryEdge: ").Append(PrimaryEdge).Append("\n");
        sb.Append("  SecondaryEdge: ").Append(SecondaryEdge).Append("\n");
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
        return Equals(obj as Phone);
    }

    /// <summary>
    /// Returns true if Phone instances are equal
    /// </summary>
    /// <param name="other">Instance of Phone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Phone other)
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
                Site == other.Site ||
                Site != null &&
                Site.Equals(other.Site)
            ) &&
            (
                PhoneBaseSettings == other.PhoneBaseSettings ||
                PhoneBaseSettings != null &&
                PhoneBaseSettings.Equals(other.PhoneBaseSettings)
            ) &&
            (
                LineBaseSettings == other.LineBaseSettings ||
                LineBaseSettings != null &&
                LineBaseSettings.Equals(other.LineBaseSettings)
            ) &&
            (
                PhoneMetaBase == other.PhoneMetaBase ||
                PhoneMetaBase != null &&
                PhoneMetaBase.Equals(other.PhoneMetaBase)
            ) &&
            (
                Lines == other.Lines ||
                Lines != null &&
                Lines.SequenceEqual(other.Lines)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                SecondaryStatus == other.SecondaryStatus ||
                SecondaryStatus != null &&
                SecondaryStatus.Equals(other.SecondaryStatus)
            ) &&
            (
                UserAgentInfo == other.UserAgentInfo ||
                UserAgentInfo != null &&
                UserAgentInfo.Equals(other.UserAgentInfo)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                Capabilities == other.Capabilities ||
                Capabilities != null &&
                Capabilities.Equals(other.Capabilities)
            ) &&
            (
                WebRtcUser == other.WebRtcUser ||
                WebRtcUser != null &&
                WebRtcUser.Equals(other.WebRtcUser)
            ) &&
            (
                PrimaryEdge == other.PrimaryEdge ||
                PrimaryEdge != null &&
                PrimaryEdge.Equals(other.PrimaryEdge)
            ) &&
            (
                SecondaryEdge == other.SecondaryEdge ||
                SecondaryEdge != null &&
                SecondaryEdge.Equals(other.SecondaryEdge)
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

            if (Site != null)
            {
                hash = hash * 59 + Site.GetHashCode();
            }

            if (PhoneBaseSettings != null)
            {
                hash = hash * 59 + PhoneBaseSettings.GetHashCode();
            }

            if (LineBaseSettings != null)
            {
                hash = hash * 59 + LineBaseSettings.GetHashCode();
            }

            if (PhoneMetaBase != null)
            {
                hash = hash * 59 + PhoneMetaBase.GetHashCode();
            }

            if (Lines != null)
            {
                hash = hash * 59 + Lines.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SecondaryStatus != null)
            {
                hash = hash * 59 + SecondaryStatus.GetHashCode();
            }

            if (UserAgentInfo != null)
            {
                hash = hash * 59 + UserAgentInfo.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Capabilities != null)
            {
                hash = hash * 59 + Capabilities.GetHashCode();
            }

            if (WebRtcUser != null)
            {
                hash = hash * 59 + WebRtcUser.GetHashCode();
            }

            if (PrimaryEdge != null)
            {
                hash = hash * 59 + PrimaryEdge.GetHashCode();
            }

            if (SecondaryEdge != null)
            {
                hash = hash * 59 + SecondaryEdge.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
