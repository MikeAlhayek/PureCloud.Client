namespace PureCloud.Client.Models;

/// <summary>
/// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
/// </summary>
public enum EvaluationResponseResourceType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    Email
}