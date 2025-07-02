using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DashboardConfiguration
{
    /// <summary>
    /// The layout type of the dashboard
    /// </summary>
    /// <value>The layout type of the dashboard</value>
    public DashboardConfigurationLayoutTypeEnum? LayoutType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of dashboard configuration.
    /// </summary>
    /// <value>The name of dashboard configuration.</value>
    public string Name { get; set; }

    /// <summary>
    /// The count of rows for the specific dashboard configuration.
    /// </summary>
    /// <value>The count of rows for the specific dashboard configuration.</value>
    public int? Rows { get; set; }

    /// <summary>
    /// The count of columns for the specific dashboard.
    /// </summary>
    /// <value>The count of columns for the specific dashboard.</value>
    public int? Columns { get; set; }

    /// <summary>
    /// List of widgets for dashboard configuration.
    /// </summary>
    /// <value>List of widgets for dashboard configuration.</value>
    public IEnumerable<Widget> Widgets { get; set; }

    /// <summary>
    /// The flag indicates if the dashboard is favorited by the user
    /// </summary>
    /// <value>The flag indicates if the dashboard is favorited by the user</value>
    public bool? Favorite { get; set; }

    /// <summary>
    /// The flag to indicate if the dashboard is published by an user
    /// </summary>
    /// <value>The flag to indicate if the dashboard is published by an user</value>
    public bool? PublicDashboard { get; set; }

    /// <summary>
    /// The flag to indicate if the dashboard has any restricted data for that user
    /// </summary>
    /// <value>The flag to indicate if the dashboard has any restricted data for that user</value>
    public bool? Restricted { get; set; }

    /// <summary>
    /// The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// The id of user who created the dashboard
    /// </summary>
    /// <value>The id of user who created the dashboard</value>
    public AddressableEntityRef CreatedBy { get; set; }

    /// <summary>
    /// The flag to indicate if the dashboard is shared
    /// </summary>
    /// <value>The flag to indicate if the dashboard is shared</value>
    public bool? Shared { get; set; }

    /// <summary>
    /// The list of users and teams the dashboard is shared with
    /// </summary>
    /// <value>The list of users and teams the dashboard is shared with</value>
    public DashboardsSharedWith DashboardsSharedWith { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
