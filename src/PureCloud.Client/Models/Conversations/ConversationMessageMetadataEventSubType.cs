using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Event subtype
/// </summary>
/// <value>Event subtype</value>

public enum ConversationMessageMetadataEventSubType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum On for "On"
    /// </summary>
    [EnumMember(Value = "On")]
    On,

    /// <summary>
    /// Enum Join for "Join"
    /// </summary>
    [EnumMember(Value = "Join")]
    Join,

    /// <summary>
    /// Enum Offering for "Offering"
    /// </summary>
    [EnumMember(Value = "Offering")]
    Offering,

    /// <summary>
    /// Enum Offeringexpired for "OfferingExpired"
    /// </summary>
    [EnumMember(Value = "OfferingExpired")]
    Offeringexpired,

    /// <summary>
    /// Enum Offeringaccepted for "OfferingAccepted"
    /// </summary>
    [EnumMember(Value = "OfferingAccepted")]
    Offeringaccepted,

    /// <summary>
    /// Enum Offeringrejected for "OfferingRejected"
    /// </summary>
    [EnumMember(Value = "OfferingRejected")]
    Offeringrejected,

    /// <summary>
    /// Enum Disconnect for "Disconnect"
    /// </summary>
    [EnumMember(Value = "Disconnect")]
    Disconnect,

    /// <summary>
    /// Enum Clear for "Clear"
    /// </summary>
    [EnumMember(Value = "Clear")]
    Clear,

    /// <summary>
    /// Enum Signin for "SignIn"
    /// </summary>
    [EnumMember(Value = "SignIn")]
    Signin,

    /// <summary>
    /// Enum Sessionexpired for "SessionExpired"
    /// </summary>
    [EnumMember(Value = "SessionExpired")]
    Sessionexpired,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
