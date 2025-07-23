namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Status
/// </summary>
public enum EvaluationResponseStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "PENDING"
    /// </summary>
    Pending,

    /// <summary>
    /// Enum Inprogress for "INPROGRESS"
    /// </summary>
    Inprogress,

    /// <summary>
    /// Enum Finished for "FINISHED"
    /// </summary>
    Finished,

    /// <summary>
    /// Enum Inreview for "INREVIEW"
    /// </summary>
    Inreview,

    /// <summary>
    /// Enum Retracted for "RETRACTED"
    /// </summary>
    Retracted
}