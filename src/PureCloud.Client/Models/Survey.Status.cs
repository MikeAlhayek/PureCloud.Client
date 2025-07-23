namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Status
/// </summary>
public enum SurveyStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    Pending,

    /// <summary>
    /// Enum Sent for "Sent"
    /// </summary>
    Sent,

    /// <summary>
    /// Enum Inprogress for "InProgress"
    /// </summary>
    Inprogress,

    /// <summary>
    /// Enum Finished for "Finished"
    /// </summary>
    Finished,

    /// <summary>
    /// Enum Optout for "OptOut"
    /// </summary>
    Optout,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    Error,

    /// <summary>
    /// Enum Expired for "Expired"
    /// </summary>
    Expired
}