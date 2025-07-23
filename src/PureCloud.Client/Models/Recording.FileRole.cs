namespace PureCloud.Client.Models;

/// <summary>
/// Role of the file recording. It can be either customer_experience or adhoc.
/// </summary>
public enum RecordingFileRole
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum CustomerExperience for "CUSTOMER_EXPERIENCE"
    /// </summary>
    CustomerExperience,

    /// <summary>
    /// Enum Adhoc for "ADHOC"
    /// </summary>
    Adhoc
}