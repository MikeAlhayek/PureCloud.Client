using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The error message in case the export request failed
/// </summary>
/// <value>The error message in case the export request failed</value>

public enum ReportingExportJobResponseExportErrorMessagesTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum FailedConvertingExportJob for "FAILED_CONVERTING_EXPORT_JOB"
    /// </summary>
    [EnumMember(Value = "FAILED_CONVERTING_EXPORT_JOB")]
    FailedConvertingExportJob,

    /// <summary>
    /// Enum FailedNoDataExportJobFound for "FAILED_NO_DATA_EXPORT_JOB_FOUND"
    /// </summary>
    [EnumMember(Value = "FAILED_NO_DATA_EXPORT_JOB_FOUND")]
    FailedNoDataExportJobFound,

    /// <summary>
    /// Enum FailedGettingDataFromService for "FAILED_GETTING_DATA_FROM_SERVICE"
    /// </summary>
    [EnumMember(Value = "FAILED_GETTING_DATA_FROM_SERVICE")]
    FailedGettingDataFromService,

    /// <summary>
    /// Enum FailedGeneratingTempFile for "FAILED_GENERATING_TEMP_FILE"
    /// </summary>
    [EnumMember(Value = "FAILED_GENERATING_TEMP_FILE")]
    FailedGeneratingTempFile,

    /// <summary>
    /// Enum FailedSavingFileToS3 for "FAILED_SAVING_FILE_TO_S3"
    /// </summary>
    [EnumMember(Value = "FAILED_SAVING_FILE_TO_S3")]
    FailedSavingFileToS3,

    /// <summary>
    /// Enum FailedNotifyingSkywalkerOfDownload for "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD"
    /// </summary>
    [EnumMember(Value = "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD")]
    FailedNotifyingSkywalkerOfDownload,

    /// <summary>
    /// Enum FailedBuildingDownloadUrlFromSkywalkerResponse for "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE"
    /// </summary>
    [EnumMember(Value = "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE")]
    FailedBuildingDownloadUrlFromSkywalkerResponse,

    /// <summary>
    /// Enum FailedConvertingExportJobToQueuePerformanceJob for "FAILED_CONVERTING_EXPORT_JOB_TO_QUEUE_PERFORMANCE_JOB"
    /// </summary>
    [EnumMember(Value = "FAILED_CONVERTING_EXPORT_JOB_TO_QUEUE_PERFORMANCE_JOB")]
    FailedConvertingExportJobToQueuePerformanceJob,

    /// <summary>
    /// Enum ExportTypeNotImplemented for "EXPORT_TYPE_NOT_IMPLEMENTED"
    /// </summary>
    [EnumMember(Value = "EXPORT_TYPE_NOT_IMPLEMENTED")]
    ExportTypeNotImplemented,

    /// <summary>
    /// Enum ReachedMaximumAttemptOfRetry for "REACHED_MAXIMUM_ATTEMPT_OF_RETRY"
    /// </summary>
    [EnumMember(Value = "REACHED_MAXIMUM_ATTEMPT_OF_RETRY")]
    ReachedMaximumAttemptOfRetry,

    /// <summary>
    /// Enum FailedLongRunningExport for "FAILED_LONG_RUNNING_EXPORT"
    /// </summary>
    [EnumMember(Value = "FAILED_LONG_RUNNING_EXPORT")]
    FailedLongRunningExport,

    /// <summary>
    /// Enum TooManyRequestsFromAnOrganization for "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION"
    /// </summary>
    [EnumMember(Value = "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION")]
    TooManyRequestsFromAnOrganization,

    /// <summary>
    /// Enum FailedAsExportFileSizeIsGreaterThan10mb for "FAILED_AS_EXPORT_FILE_SIZE_IS_GREATER_THAN_10MB"
    /// </summary>
    [EnumMember(Value = "FAILED_AS_EXPORT_FILE_SIZE_IS_GREATER_THAN_10MB")]
    FailedAsExportFileSizeIsGreaterThan10mb,

    /// <summary>
    /// Enum NotAuthorizedToViewExport for "NOT_AUTHORIZED_TO_VIEW_EXPORT"
    /// </summary>
    [EnumMember(Value = "NOT_AUTHORIZED_TO_VIEW_EXPORT")]
    NotAuthorizedToViewExport,

    /// <summary>
    /// Enum StaticLinkExportFailed for "STATIC_LINK_EXPORT_FAILED"
    /// </summary>
    [EnumMember(Value = "STATIC_LINK_EXPORT_FAILED")]
    StaticLinkExportFailed,

    /// <summary>
    /// Enum TooManySearchCriteria for "TOO_MANY_SEARCH_CRITERIA"
    /// </summary>
    [EnumMember(Value = "TOO_MANY_SEARCH_CRITERIA")]
    TooManySearchCriteria,

    /// <summary>
    /// Enum SearchCriteriaValuesExceedLimit for "SEARCH_CRITERIA_VALUES_EXCEED_LIMIT"
    /// </summary>
    [EnumMember(Value = "SEARCH_CRITERIA_VALUES_EXCEED_LIMIT")]
    SearchCriteriaValuesExceedLimit,

    /// <summary>
    /// Enum ExportEmailFileSizeExceededLimit for "EXPORT_EMAIL_FILE_SIZE_EXCEEDED_LIMIT"
    /// </summary>
    [EnumMember(Value = "EXPORT_EMAIL_FILE_SIZE_EXCEEDED_LIMIT")]
    ExportEmailFileSizeExceededLimit,

    /// <summary>
    /// Enum CircuitBreakerOpenForViewType for "CIRCUIT_BREAKER_OPEN_FOR_VIEW_TYPE"
    /// </summary>
    [EnumMember(Value = "CIRCUIT_BREAKER_OPEN_FOR_VIEW_TYPE")]
    CircuitBreakerOpenForViewType,

    /// <summary>
    /// Enum BadRequestScheduledRun for "BAD_REQUEST_SCHEDULED_RUN"
    /// </summary>
    [EnumMember(Value = "BAD_REQUEST_SCHEDULED_RUN")]
    BadRequestScheduledRun
}
