using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DashboardConfiguration
/// </summary>

public partial class DashboardConfiguration : IEquatable<DashboardConfiguration>
{
    /// <summary>
    /// The layout type of the dashboard
    /// </summary>
    /// <value>The layout type of the dashboard</value>
    
    public enum LayoutTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Grid for "Grid"
        /// </summary>
        [EnumMember(Value = "Grid")]
        Grid,

        /// <summary>
        /// Enum Flow for "Flow"
        /// </summary>
        [EnumMember(Value = "Flow")]
        Flow
    }
    /// <summary>
    /// The layout type of the dashboard
    /// </summary>
    /// <value>The layout type of the dashboard</value>
    [JsonPropertyName("layoutType")]
    public LayoutTypeEnum? LayoutType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DashboardConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardConfiguration" /> class.
    /// </summary>
    /// <param name="Name">The name of dashboard configuration. (required).</param>
    /// <param name="Rows">The count of rows for the specific dashboard configuration..</param>
    /// <param name="Columns">The count of columns for the specific dashboard..</param>
    /// <param name="Widgets">List of widgets for dashboard configuration. (required).</param>
    /// <param name="Favorite">The flag indicates if the dashboard is favorited by the user.</param>
    /// <param name="PublicDashboard">The flag to indicate if the dashboard is published by an user.</param>
    /// <param name="LayoutType">The layout type of the dashboard.</param>
    /// <param name="DateCreated">The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateModified">The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateDeleted">The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Shared">The flag to indicate if the dashboard is shared.</param>
    /// <param name="DashboardsSharedWith">The list of users and teams the dashboard is shared with.</param>
    public DashboardConfiguration(string Name = null, int? Rows = null, int? Columns = null, List<Widget> Widgets = null, bool? Favorite = null, bool? PublicDashboard = null, LayoutTypeEnum? LayoutType = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateDeleted = null, bool? Shared = null, DashboardsSharedWith DashboardsSharedWith = null)
    {
        this.Name = Name;
        this.Rows = Rows;
        this.Columns = Columns;
        this.Widgets = Widgets;
        this.Favorite = Favorite;
        this.PublicDashboard = PublicDashboard;
        this.LayoutType = LayoutType;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DateDeleted = DateDeleted;
        this.Shared = Shared;
        this.DashboardsSharedWith = DashboardsSharedWith;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of dashboard configuration.
    /// </summary>
    /// <value>The name of dashboard configuration.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The count of rows for the specific dashboard configuration.
    /// </summary>
    /// <value>The count of rows for the specific dashboard configuration.</value>
    [JsonPropertyName("rows")]
    public int? Rows { get; set; }



    /// <summary>
    /// The count of columns for the specific dashboard.
    /// </summary>
    /// <value>The count of columns for the specific dashboard.</value>
    [JsonPropertyName("columns")]
    public int? Columns { get; set; }



    /// <summary>
    /// List of widgets for dashboard configuration.
    /// </summary>
    /// <value>List of widgets for dashboard configuration.</value>
    [JsonPropertyName("widgets")]
    public List<Widget> Widgets { get; set; }



    /// <summary>
    /// The flag indicates if the dashboard is favorited by the user
    /// </summary>
    /// <value>The flag indicates if the dashboard is favorited by the user</value>
    [JsonPropertyName("favorite")]
    public bool? Favorite { get; set; }



    /// <summary>
    /// The flag to indicate if the dashboard is published by an user
    /// </summary>
    /// <value>The flag to indicate if the dashboard is published by an user</value>
    [JsonPropertyName("publicDashboard")]
    public bool? PublicDashboard { get; set; }



    /// <summary>
    /// The flag to indicate if the dashboard has any restricted data for that user
    /// </summary>
    /// <value>The flag to indicate if the dashboard has any restricted data for that user</value>
    [JsonPropertyName("restricted")]
    public bool? Restricted { get; private set; }





    /// <summary>
    /// The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateDeleted")]
    public DateTime? DateDeleted { get; set; }



    /// <summary>
    /// The id of user who created the dashboard
    /// </summary>
    /// <value>The id of user who created the dashboard</value>
    [JsonPropertyName("createdBy")]
    public AddressableEntityRef CreatedBy { get; private set; }



    /// <summary>
    /// The flag to indicate if the dashboard is shared
    /// </summary>
    /// <value>The flag to indicate if the dashboard is shared</value>
    [JsonPropertyName("shared")]
    public bool? Shared { get; set; }



    /// <summary>
    /// The list of users and teams the dashboard is shared with
    /// </summary>
    /// <value>The list of users and teams the dashboard is shared with</value>
    [JsonPropertyName("dashboardsSharedWith")]
    public DashboardsSharedWith DashboardsSharedWith { get; set; }



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
        sb.Append("class DashboardConfiguration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Rows: ").Append(Rows).Append("\n");
        sb.Append("  Columns: ").Append(Columns).Append("\n");
        sb.Append("  Widgets: ").Append(Widgets).Append("\n");
        sb.Append("  Favorite: ").Append(Favorite).Append("\n");
        sb.Append("  PublicDashboard: ").Append(PublicDashboard).Append("\n");
        sb.Append("  Restricted: ").Append(Restricted).Append("\n");
        sb.Append("  LayoutType: ").Append(LayoutType).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Shared: ").Append(Shared).Append("\n");
        sb.Append("  DashboardsSharedWith: ").Append(DashboardsSharedWith).Append("\n");
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
        return Equals(obj as DashboardConfiguration);
    }

    /// <summary>
    /// Returns true if DashboardConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of DashboardConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DashboardConfiguration other)
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
                Rows == other.Rows ||
                Rows != null &&
                Rows.Equals(other.Rows)
            ) &&
            (
                Columns == other.Columns ||
                Columns != null &&
                Columns.Equals(other.Columns)
            ) &&
            (
                Widgets == other.Widgets ||
                Widgets != null &&
                Widgets.SequenceEqual(other.Widgets)
            ) &&
            (
                Favorite == other.Favorite ||
                Favorite != null &&
                Favorite.Equals(other.Favorite)
            ) &&
            (
                PublicDashboard == other.PublicDashboard ||
                PublicDashboard != null &&
                PublicDashboard.Equals(other.PublicDashboard)
            ) &&
            (
                Restricted == other.Restricted ||
                Restricted != null &&
                Restricted.Equals(other.Restricted)
            ) &&
            (
                LayoutType == other.LayoutType ||
                LayoutType != null &&
                LayoutType.Equals(other.LayoutType)
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
                DateDeleted == other.DateDeleted ||
                DateDeleted != null &&
                DateDeleted.Equals(other.DateDeleted)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                Shared == other.Shared ||
                Shared != null &&
                Shared.Equals(other.Shared)
            ) &&
            (
                DashboardsSharedWith == other.DashboardsSharedWith ||
                DashboardsSharedWith != null &&
                DashboardsSharedWith.Equals(other.DashboardsSharedWith)
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

            if (Rows != null)
            {
                hash = hash * 59 + Rows.GetHashCode();
            }

            if (Columns != null)
            {
                hash = hash * 59 + Columns.GetHashCode();
            }

            if (Widgets != null)
            {
                hash = hash * 59 + Widgets.GetHashCode();
            }

            if (Favorite != null)
            {
                hash = hash * 59 + Favorite.GetHashCode();
            }

            if (PublicDashboard != null)
            {
                hash = hash * 59 + PublicDashboard.GetHashCode();
            }

            if (Restricted != null)
            {
                hash = hash * 59 + Restricted.GetHashCode();
            }

            if (LayoutType != null)
            {
                hash = hash * 59 + LayoutType.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateDeleted != null)
            {
                hash = hash * 59 + DateDeleted.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (Shared != null)
            {
                hash = hash * 59 + Shared.GetHashCode();
            }

            if (DashboardsSharedWith != null)
            {
                hash = hash * 59 + DashboardsSharedWith.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
