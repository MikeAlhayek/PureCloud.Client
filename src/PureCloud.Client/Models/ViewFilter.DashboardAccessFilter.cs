using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of dashboard access being filtered
/// </summary>
/// <value>The type of dashboard access being filtered</value>

public enum ViewFilterDashboardAccessFilterEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ownedbyme for "OwnedByMe"
    /// </summary>
    [EnumMember(Value = "OwnedByMe")]
    Ownedbyme,

    /// <summary>
    /// Enum Ownedbyanyone for "OwnedByAnyone"
    /// </summary>
    [EnumMember(Value = "OwnedByAnyone")]
    Ownedbyanyone,

    /// <summary>
    /// Enum Notownedbyme for "NotOwnedByMe"
    /// </summary>
    [EnumMember(Value = "NotOwnedByMe")]
    Notownedbyme
}
