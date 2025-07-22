using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public enum CobrowseSettingsChannelsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Webmessaging for "Webmessaging"
    /// </summary>
    [EnumMember(Value = "Webmessaging")]
    Webmessaging,

    /// <summary>
    /// Enum Voice for "Voice"
    /// </summary>
    [EnumMember(Value = "Voice")]
    Voice
}

public sealed class CobrowseSettings
{
    /// <summary>
    /// Whether or not cobrowse is enabled
    /// </summary>
    /// <value>Whether or not cobrowse is enabled</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Whether the viewer should have option to request control
    /// </summary>
    /// <value>Whether the viewer should have option to request control</value>
    public bool? AllowAgentControl { get; set; }

    /// <summary>
    /// Whether the viewer should have option to request navigation
    /// </summary>
    /// <value>Whether the viewer should have option to request navigation</value>
    public bool? AllowAgentNavigation { get; set; }

    /// <summary>
    /// Should cobrowse draw be enabled
    /// </summary>
    /// <value>Should cobrowse draw be enabled</value>
    public bool? AllowDraw { get; set; }

    /// <summary>
    /// Mask patterns that will apply to pages being shared
    /// </summary>
    /// <value>Mask patterns that will apply to pages being shared</value>
    public IEnumerable<string> MaskSelectors { get; set; }

    /// <summary>
    /// Cobrowse channels for web messenger
    /// </summary>
    /// <value>Cobrowse channels for web messenger</value>
    public IEnumerable<CobrowseSettingsChannelsEnum> Channels { get; set; }

    /// <summary>
    /// Readonly patterns that will apply to pages being shared
    /// </summary>
    /// <value>Readonly patterns that will apply to pages being shared</value>
    public IEnumerable<string> ReadonlySelectors { get; set; }

    /// <summary>
    /// Pause criteria that will pause cobrowse if some of them are met in the user&#39;s URL
    /// </summary>
    /// <value>Pause criteria that will pause cobrowse if some of them are met in the user&#39;s URL</value>
    public IEnumerable<PauseCriteria> PauseCriteria { get; set; }
}
