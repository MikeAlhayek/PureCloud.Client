namespace PureCloud.Client.Models;

public sealed class ReportingExportJobResponse
{
    /// <summary>
    /// The current status of the export request
    /// </summary>
    /// <value>The current status of the export request</value>
    public ReportingExportJobResponseStatus? Status { get; set; }

    /// <summary>
    /// The requested format of the exported data
    /// </summary>
    /// <value>The requested format of the exported data</value>
    public ReportingExportJobResponseExportFormatEnum? ExportFormat { get; set; }

    /// <summary>
    /// The type of view export job to be created
    /// </summary>
    /// <value>The type of view export job to be created</value>
    public ReportingExportJobResponseViewTypeEnum? ViewType { get; set; }

    /// <summary>
    /// The error message in case the export request failed
    /// </summary>
    /// <value>The error message in case the export request failed</value>
    public ReportingExportJobResponseExportErrorMessagesTypeEnum? ExportErrorMessagesType { get; set; }

    /// <summary>
    /// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
    /// </summary>
    /// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>
    public ReportingExportJobResponseCsvDelimiterEnum? CsvDelimiter { get; set; }

    /// <summary>
    /// Indicates the duration format for the exports
    /// </summary>
    /// <value>Indicates the duration format for the exports</value>
    public ReportingExportJobResponseDurationFormatEnum? DurationFormat { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique run id of the export schedule execute
    /// </summary>
    /// <value>The unique run id of the export schedule execute</value>
    public string RunId { get; set; }

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
    /// The url to download the request if it&#39;s status is completed
    /// </summary>
    /// <value>The url to download the request if it&#39;s status is completed</value>
    public string DownloadUrl { get; set; }

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
    /// The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDateTime { get; set; }

    /// <summary>
    /// The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDateTime { get; set; }

    /// <summary>
    /// The locale use for localization of the exported data, i.e. en-us, es-mx  
    /// </summary>
    /// <value>The locale use for localization of the exported data, i.e. en-us, es-mx  </value>
    public string Locale { get; set; }

    /// <summary>
    /// The percentage of the job that has completed processing
    /// </summary>
    /// <value>The percentage of the job that has completed processing</value>
    public double? PercentageComplete { get; set; }

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
    /// The status of individual email addresses as a map
    /// </summary>
    /// <value>The status of individual email addresses as a map</value>
    public Dictionary<string, string> EmailStatuses { get; set; }

    /// <summary>
    /// The optional error message in case the export fail to email
    /// </summary>
    /// <value>The optional error message in case the export fail to email</value>
    public string EmailErrorDescription { get; set; }

    /// <summary>
    /// Indicates whether to include selected duration format to the column headers
    /// </summary>
    /// <value>Indicates whether to include selected duration format to the column headers</value>
    public bool? IncludeDurationFormatInHeader { get; set; }

    /// <summary>
    /// Indicates whether the export run is allowed to rerun
    /// </summary>
    /// <value>Indicates whether the export run is allowed to rerun</value>
    public bool? ExportAllowedToRerun { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
