using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The target language of the Lex bot
/// </summary>
/// <value>The target language of the Lex bot</value>

public enum LexBotAliasLanguageEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Enus for "en-US"
    /// </summary>
    [EnumMember(Value = "en-US")]
    Enus
}
