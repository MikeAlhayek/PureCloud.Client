using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmMoveAgentsCompleteTopicWfmMoveAgentDataResultEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Alreadymoved for "AlreadyMoved"
    /// </summary>
    [EnumMember(Value = "AlreadyMoved")]
    Alreadymoved,

    /// <summary>
    /// Enum Destinationbusinessunitagentlimitexceeded for "DestinationBusinessUnitAgentLimitExceeded"
    /// </summary>
    [EnumMember(Value = "DestinationBusinessUnitAgentLimitExceeded")]
    Destinationbusinessunitagentlimitexceeded,

    /// <summary>
    /// Enum Destinationmanagementunitagentlimitexceeded for "DestinationManagementUnitAgentLimitExceeded"
    /// </summary>
    [EnumMember(Value = "DestinationManagementUnitAgentLimitExceeded")]
    Destinationmanagementunitagentlimitexceeded,

    /// <summary>
    /// Enum Destinationmanagementunitdoesnotexist for "DestinationManagementUnitDoesNotExist"
    /// </summary>
    [EnumMember(Value = "DestinationManagementUnitDoesNotExist")]
    Destinationmanagementunitdoesnotexist,

    /// <summary>
    /// Enum Movesuccessful for "MoveSuccessful"
    /// </summary>
    [EnumMember(Value = "MoveSuccessful")]
    Movesuccessful,

    /// <summary>
    /// Enum Movingtodifferentmanagementunit for "MovingToDifferentManagementUnit"
    /// </summary>
    [EnumMember(Value = "MovingToDifferentManagementUnit")]
    Movingtodifferentmanagementunit,

    /// <summary>
    /// Enum Nothingtodo for "NothingToDo"
    /// </summary>
    [EnumMember(Value = "NothingToDo")]
    Nothingtodo,

    /// <summary>
    /// Enum Sourcemanagementunitnotauthorized for "SourceManagementUnitNotAuthorized"
    /// </summary>
    [EnumMember(Value = "SourceManagementUnitNotAuthorized")]
    Sourcemanagementunitnotauthorized
}
