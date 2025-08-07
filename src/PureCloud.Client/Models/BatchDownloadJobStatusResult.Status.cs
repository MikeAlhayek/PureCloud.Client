namespace PureCloud.Client.Models;

/// <summary>
/// Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.
/// </summary>
public enum BatchDownloadJobStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inprogress for "InProgress"
    /// </summary>
    Inprogress,

    /// <summary>
    /// Enum Completed for "Completed"
    /// </summary>
    Completed
}
