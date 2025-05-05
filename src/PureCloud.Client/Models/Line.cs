using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Line
/// </summary>

public partial class Line : IEquatable<Line>
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
    public StateEnum? State { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Line" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Line() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Line" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="Properties">Properties.</param>
    /// <param name="EdgeGroup">The edge group associated with the line. (Deprecated).</param>
    /// <param name="Template">Template.</param>
    /// <param name="Site">Site.</param>
    /// <param name="LineBaseSettings">LineBaseSettings.</param>
    /// <param name="PrimaryEdge">The primary edge associated to the line. (Deprecated).</param>
    /// <param name="SecondaryEdge">The secondary edge associated to the line. (Deprecated).</param>
    /// <param name="LoggedInUser">LoggedInUser.</param>
    /// <param name="DefaultForUser">DefaultForUser.</param>
    public Line(string Name = null, Division Division = null, string Description = null, int? Version = null, Dictionary<string, object> Properties = null, DomainEntityRef EdgeGroup = null, DomainEntityRef Template = null, DomainEntityRef Site = null, DomainEntityRef LineBaseSettings = null, Edge PrimaryEdge = null, Edge SecondaryEdge = null, DomainEntityRef LoggedInUser = null, DomainEntityRef DefaultForUser = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.Properties = Properties;
        this.EdgeGroup = EdgeGroup;
        this.Template = Template;
        this.Site = Site;
        this.LineBaseSettings = LineBaseSettings;
        this.PrimaryEdge = PrimaryEdge;
        this.SecondaryEdge = SecondaryEdge;
        this.LoggedInUser = LoggedInUser;
        this.DefaultForUser = DefaultForUser;

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
    /// Gets or Sets Properties
    /// </summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, object> Properties { get; set; }



    /// <summary>
    /// The edge group associated with the line. (Deprecated)
    /// </summary>
    /// <value>The edge group associated with the line. (Deprecated)</value>
    [JsonPropertyName("edgeGroup")]
    public DomainEntityRef EdgeGroup { get; set; }



    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [JsonPropertyName("template")]
    public DomainEntityRef Template { get; set; }



    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    [JsonPropertyName("site")]
    public DomainEntityRef Site { get; set; }



    /// <summary>
    /// Gets or Sets LineBaseSettings
    /// </summary>
    [JsonPropertyName("lineBaseSettings")]
    public DomainEntityRef LineBaseSettings { get; set; }



    /// <summary>
    /// The primary edge associated to the line. (Deprecated)
    /// </summary>
    /// <value>The primary edge associated to the line. (Deprecated)</value>
    [JsonPropertyName("primaryEdge")]
    public Edge PrimaryEdge { get; set; }



    /// <summary>
    /// The secondary edge associated to the line. (Deprecated)
    /// </summary>
    /// <value>The secondary edge associated to the line. (Deprecated)</value>
    [JsonPropertyName("secondaryEdge")]
    public Edge SecondaryEdge { get; set; }



    /// <summary>
    /// Gets or Sets LoggedInUser
    /// </summary>
    [JsonPropertyName("loggedInUser")]
    public DomainEntityRef LoggedInUser { get; set; }



    /// <summary>
    /// Gets or Sets DefaultForUser
    /// </summary>
    [JsonPropertyName("defaultForUser")]
    public DomainEntityRef DefaultForUser { get; set; }



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
        sb.Append("class Line {\n");

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
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
        sb.Append("  Template: ").Append(Template).Append("\n");
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  LineBaseSettings: ").Append(LineBaseSettings).Append("\n");
        sb.Append("  PrimaryEdge: ").Append(PrimaryEdge).Append("\n");
        sb.Append("  SecondaryEdge: ").Append(SecondaryEdge).Append("\n");
        sb.Append("  LoggedInUser: ").Append(LoggedInUser).Append("\n");
        sb.Append("  DefaultForUser: ").Append(DefaultForUser).Append("\n");
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
        return Equals(obj as Line);
    }

    /// <summary>
    /// Returns true if Line instances are equal
    /// </summary>
    /// <param name="other">Instance of Line to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Line other)
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
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                EdgeGroup == other.EdgeGroup ||
                EdgeGroup != null &&
                EdgeGroup.Equals(other.EdgeGroup)
            ) &&
            (
                Template == other.Template ||
                Template != null &&
                Template.Equals(other.Template)
            ) &&
            (
                Site == other.Site ||
                Site != null &&
                Site.Equals(other.Site)
            ) &&
            (
                LineBaseSettings == other.LineBaseSettings ||
                LineBaseSettings != null &&
                LineBaseSettings.Equals(other.LineBaseSettings)
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
                LoggedInUser == other.LoggedInUser ||
                LoggedInUser != null &&
                LoggedInUser.Equals(other.LoggedInUser)
            ) &&
            (
                DefaultForUser == other.DefaultForUser ||
                DefaultForUser != null &&
                DefaultForUser.Equals(other.DefaultForUser)
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

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (EdgeGroup != null)
            {
                hash = hash * 59 + EdgeGroup.GetHashCode();
            }

            if (Template != null)
            {
                hash = hash * 59 + Template.GetHashCode();
            }

            if (Site != null)
            {
                hash = hash * 59 + Site.GetHashCode();
            }

            if (LineBaseSettings != null)
            {
                hash = hash * 59 + LineBaseSettings.GetHashCode();
            }

            if (PrimaryEdge != null)
            {
                hash = hash * 59 + PrimaryEdge.GetHashCode();
            }

            if (SecondaryEdge != null)
            {
                hash = hash * 59 + SecondaryEdge.GetHashCode();
            }

            if (LoggedInUser != null)
            {
                hash = hash * 59 + LoggedInUser.GetHashCode();
            }

            if (DefaultForUser != null)
            {
                hash = hash * 59 + DefaultForUser.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
