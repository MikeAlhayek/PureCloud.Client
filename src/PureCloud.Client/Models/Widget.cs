using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Widget
{
    /// <summary>
    /// The type of dashboard widget configuration.
    /// </summary>
    /// <value>The type of dashboard widget configuration.</value>
    public WidgetTypeEnum? Type { get; set; }

    /// <summary>
    /// The sort order of the table.
    /// </summary>
    /// <value>The sort order of the table.</value>
    public WidgetSortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// The sort key of the table.
    /// </summary>
    /// <value>The sort key of the table.</value>
    public WidgetSortKeyEnum? SortKey { get; set; }

    /// <summary>
    /// The sort order of the interactions in the agent status widget.
    /// </summary>
    /// <value>The sort order of the interactions in the agent status widget.</value>
    public WidgetAgentInteractionSortOrderEnum? AgentInteractionSortOrder { get; set; }

    /// <summary>
    /// The row number for the specific dashboard widget configuration.
    /// </summary>
    /// <value>The row number for the specific dashboard widget configuration.</value>
    public int? Row { get; set; }

    /// <summary>
    /// The column number for the specific dashboard widget configuration.
    /// </summary>
    /// <value>The column number for the specific dashboard widget configuration.</value>
    public int? Column { get; set; }

    /// <summary>
    /// The title for the dashboard widget configuration.
    /// </summary>
    /// <value>The title for the dashboard widget configuration.</value>
    public string Title { get; set; }

    /// <summary>
    /// The list of metrics for the dashboard widget configuration.
    /// </summary>
    /// <value>The list of metrics for the dashboard widget configuration.</value>
    public IEnumerable<WidgetMetricsEnum> Metrics { get; set; }

    /// <summary>
    /// The display text for the dashboard widget configuration.
    /// </summary>
    /// <value>The display text for the dashboard widget configuration.</value>
    public string DisplayText { get; set; }

    /// <summary>
    /// The color of the display text for the dashboard widget configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).
    /// </summary>
    /// <value>The color of the display text for the dashboard widget configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).</value>
    public string DisplayTextColor { get; set; }

    /// <summary>
    /// The external web URL for the dashboard widget configuration.
    /// </summary>
    /// <value>The external web URL for the dashboard widget configuration.</value>
    public string WebContentUrl { get; set; }

    /// <summary>
    /// Indicates each filter to be displayed individually.
    /// </summary>
    /// <value>Indicates each filter to be displayed individually.</value>
    public bool? SplitFilters { get; set; }

    /// <summary>
    /// Indicates that data for each media type should be shown individually.
    /// </summary>
    /// <value>Indicates that data for each media type should be shown individually.</value>
    public bool? SplitByMediaType { get; set; }

    /// <summary>
    /// Indicates the display be the longest time.
    /// </summary>
    /// <value>Indicates the display be the longest time.</value>
    public bool? ShowLongest { get; set; }

    /// <summary>
    /// Indicates the widget to be displayed as table.
    /// </summary>
    /// <value>Indicates the widget to be displayed as table.</value>
    public bool? DisplayAsTable { get; set; }

    /// <summary>
    /// Indicates the display to include duration.
    /// </summary>
    /// <value>Indicates the display to include duration.</value>
    public bool? ShowDuration { get; set; }

    /// <summary>
    /// Indicates the limit of displayed entities.
    /// </summary>
    /// <value>Indicates the limit of displayed entities.</value>
    public int? EntityLimit { get; set; }

    /// <summary>
    /// Indicates whether to display aggregate across all entity and media type combination.
    /// </summary>
    /// <value>Indicates whether to display aggregate across all entity and media type combination.</value>
    public bool? DisplayAggregates { get; set; }

    /// <summary>
    /// Indicates whether a widget should take the full width of a dashboard or be shown only in a single slot.
    /// </summary>
    /// <value>Indicates whether a widget should take the full width of a dashboard or be shown only in a single slot.</value>
    public bool? IsFullWidth { get; set; }

    /// <summary>
    /// Indicates whether a widget should show the percentage diff between two values.
    /// </summary>
    /// <value>Indicates whether a widget should show the percentage diff between two values.</value>
    public bool? ShowPercentageChange { get; set; }

    /// <summary>
    /// Indicates whether a widget should show the profile picture of an agent.
    /// </summary>
    /// <value>Indicates whether a widget should show the profile picture of an agent.</value>
    public bool? ShowProfilePicture { get; set; }

    /// <summary>
    /// The filters to be applied for dashboard widget configuration
    /// </summary>
    /// <value>The filters to be applied for dashboard widget configuration</value>
    public ViewFilter Filter { get; set; }

    /// <summary>
    /// The list of periods for the dashboard widget configuration
    /// </summary>
    /// <value>The list of periods for the dashboard widget configuration</value>
    public IEnumerable<WidgetPeriodsEnum> Periods { get; set; }

    /// <summary>
    /// The list of media types for the dashboard widget configuration
    /// </summary>
    /// <value>The list of media types for the dashboard widget configuration</value>
    public IEnumerable<WidgetMediaTypesEnum> MediaTypes { get; set; }

    /// <summary>
    /// List of warnings for dashboard widget configuration
    /// </summary>
    /// <value>List of warnings for dashboard widget configuration</value>
    public IEnumerable<Warning> Warnings { get; set; }

    /// <summary>
    /// Indicates the show time in status of a widget configuration.
    /// </summary>
    /// <value>Indicates the show time in status of a widget configuration.</value>
    public bool? ShowTimeInStatus { get; set; }

    /// <summary>
    /// Indicates to show offline agent widget.
    /// </summary>
    /// <value>Indicates to show offline agent widget.</value>
    public bool? ShowOfflineAgents { get; set; }

    /// <summary>
    /// Indicates the selected statuses used to filter the agent widget in the dashboard.
    /// </summary>
    /// <value>Indicates the selected statuses used to filter the agent widget in the dashboard.</value>
    public IEnumerable<WidgetSelectedStatusesEnum> SelectedStatuses { get; set; }

    /// <summary>
    /// Indicates the selected segment types used to filter the agent activity in the dashboard.
    /// </summary>
    /// <value>Indicates the selected segment types used to filter the agent activity in the dashboard.</value>
    public IEnumerable<WidgetSelectedSegmentTypesEnum> SelectedSegmentTypes { get; set; }
}
