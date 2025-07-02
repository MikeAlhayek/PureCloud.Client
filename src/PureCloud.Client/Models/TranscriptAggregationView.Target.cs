using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TranscriptAggregationViewTargetEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ntopiccommunications for "nTopicCommunications"
    /// </summary>
    [EnumMember(Value = "nTopicCommunications")]
    Ntopiccommunications,

    /// <summary>
    /// Enum Ocustomersentiment for "oCustomerSentiment"
    /// </summary>
    [EnumMember(Value = "oCustomerSentiment")]
    Ocustomersentiment,

    /// <summary>
    /// Enum Oovertalkspeechinstances for "oOverTalkSpeechInstances"
    /// </summary>
    [EnumMember(Value = "oOverTalkSpeechInstances")]
    Oovertalkspeechinstances,

    /// <summary>
    /// Enum Osentimentscore for "oSentimentScore"
    /// </summary>
    [EnumMember(Value = "oSentimentScore")]
    Osentimentscore,

    /// <summary>
    /// Enum Tagentspeech for "tAgentSpeech"
    /// </summary>
    [EnumMember(Value = "tAgentSpeech")]
    Tagentspeech,

    /// <summary>
    /// Enum Tcustomerspeech for "tCustomerSpeech"
    /// </summary>
    [EnumMember(Value = "tCustomerSpeech")]
    Tcustomerspeech,

    /// <summary>
    /// Enum Totheraudio for "tOtherAudio"
    /// </summary>
    [EnumMember(Value = "tOtherAudio")]
    Totheraudio,

    /// <summary>
    /// Enum Tovertalkspeech for "tOverTalkSpeech"
    /// </summary>
    [EnumMember(Value = "tOverTalkSpeech")]
    Tovertalkspeech,

    /// <summary>
    /// Enum Tsilence for "tSilence"
    /// </summary>
    [EnumMember(Value = "tSilence")]
    Tsilence,

    /// <summary>
    /// Enum Ttotalspeechandsilence for "tTotalSpeechAndSilence"
    /// </summary>
    [EnumMember(Value = "tTotalSpeechAndSilence")]
    Ttotalspeechandsilence
}
