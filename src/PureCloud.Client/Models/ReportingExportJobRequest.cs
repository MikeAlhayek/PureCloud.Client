using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingExportJobRequest
{
    /// <summary>
    /// The requested format of the exported data
    /// </summary>
    /// <value>The requested format of the exported data</value>
    public ReportingExportJobRequestExportFormatEnum? ExportFormat { get; set; }

    /// <summary>
    /// The type of view export job to be created
    /// </summary>
    /// <value>The type of view export job to be created</value>
    public ReportingExportJobRequestViewTypeEnum? ViewType { get; set; }

    /// <summary>
    /// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
    /// </summary>
    /// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>
    public ReportingExportJobRequestCsvDelimiterEnum? CsvDelimiter { get; set; }

    /// <summary>
    /// Indicates the duration format for the exports
    /// </summary>
    /// <value>Indicates the duration format for the exports</value>
    public ReportingExportJobRequestDurationFormatEnum? DurationFormat { get; set; }

    /// <summary>
    /// The user supplied name of the export request
    /// </summary>
    /// <value>The user supplied name of the export request</value>
    public string Name { get; set; }

    /// <summary>
    /// The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    public string TimeZone { get; set; }

    /// <summary>
    /// The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    public string Period { get; set; }

    /// <summary>
    /// Filters to apply to create the view
    /// </summary>
    /// <value>Filters to apply to create the view</value>
    public ViewFilter Filter { get; set; }

    /// <summary>
    /// Indicates if the request has been marked as read
    /// </summary>
    /// <value>Indicates if the request has been marked as read</value>
    public bool? Read { get; set; }

    /// <summary>
    /// The locale used for localization of the exported data, i.e. en-US, es
    /// </summary>
    /// <value>The locale used for localization of the exported data, i.e. en-US, es</value>
    public string Locale { get; set; }

    /// <summary>
    /// Indicates if durations are formatted in hh:mm:ss format instead of ms
    /// </summary>
    /// <value>Indicates if durations are formatted in hh:mm:ss format instead of ms</value>
    public bool? HasFormatDurations { get; set; }

    /// <summary>
    /// Indicates if filters will be split in aggregate detail exports
    /// </summary>
    /// <value>Indicates if filters will be split in aggregate detail exports</value>
    public bool? HasSplitFilters { get; set; }

    /// <summary>
    /// Excludes empty rows from the exports
    /// </summary>
    /// <value>Excludes empty rows from the exports</value>
    public bool? ExcludeEmptyRows { get; set; }

    /// <summary>
    /// Indicates if media type will be split in aggregate detail exports
    /// </summary>
    /// <value>Indicates if media type will be split in aggregate detail exports</value>
    public bool? HasSplitByMedia { get; set; }

    /// <summary>
    /// Indicates if summary row needs to be present in exports
    /// </summary>
    /// <value>Indicates if summary row needs to be present in exports</value>
    public bool? HasSummaryRow { get; set; }

    /// <summary>
    /// The list of ordered selected columns from the export view by the user
    /// </summary>
    /// <value>The list of ordered selected columns from the export view by the user</value>
    public IEnumerable<SelectedColumns> SelectedColumns { get; set; }

    /// <summary>
    /// Indicates if custom participant attributes will be exported
    /// </summary>
    /// <value>Indicates if custom participant attributes will be exported</value>
    public bool? HasCustomParticipantAttributes { get; set; }

    /// <summary>
    /// The list of email recipients for the exports
    /// </summary>
    /// <value>The list of email recipients for the exports</value>
    public IEnumerable<string> RecipientEmails { get; set; }

    /// <summary>
    /// Indicates whether to include selected duration format to the column headers
    /// </summary>
    /// <value>Indicates whether to include selected duration format to the column headers</value>
    public bool? IncludeDurationFormatInHeader { get; set; }
}
