using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowHealthIntentUtteranceStaticValidationResultsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Toofewutterances for "TooFewUtterances"
    /// </summary>
    [EnumMember(Value = "TooFewUtterances")]
    Toofewutterances,

    /// <summary>
    /// Enum Toomanyutterances for "TooManyUtterances"
    /// </summary>
    [EnumMember(Value = "TooManyUtterances")]
    Toomanyutterances,

    /// <summary>
    /// Enum Utterancetooshort for "UtteranceTooShort"
    /// </summary>
    [EnumMember(Value = "UtteranceTooShort")]
    Utterancetooshort,

    /// <summary>
    /// Enum Utterancetoolong for "UtteranceTooLong"
    /// </summary>
    [EnumMember(Value = "UtteranceTooLong")]
    Utterancetoolong
}
