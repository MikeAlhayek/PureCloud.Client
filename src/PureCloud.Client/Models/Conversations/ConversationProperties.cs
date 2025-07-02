using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationProperties
{
    /// <summary>
    /// Indicates filtering for waiting
    /// </summary>
    /// <value>Indicates filtering for waiting</value>
    public bool? IsWaiting { get; set; }

    /// <summary>
    /// Indicates filtering for active
    /// </summary>
    /// <value>Indicates filtering for active</value>
    public bool? IsActive { get; set; }

    /// <summary>
    /// Indicates filtering for Acd
    /// </summary>
    /// <value>Indicates filtering for Acd</value>
    public bool? IsAcd { get; set; }

    /// <summary>
    /// Indicates filtering for Preferred Agent Routing
    /// </summary>
    /// <value>Indicates filtering for Preferred Agent Routing</value>
    public bool? IsPreferred { get; set; }

    /// <summary>
    /// Indicates filtering for screenshare
    /// </summary>
    /// <value>Indicates filtering for screenshare</value>
    public bool? IsScreenshare { get; set; }

    /// <summary>
    /// Indicates filtering for Cobrowse
    /// </summary>
    /// <value>Indicates filtering for Cobrowse</value>
    public bool? IsCobrowse { get; set; }

    /// <summary>
    /// Indicates filtering for Voice mail
    /// </summary>
    /// <value>Indicates filtering for Voice mail</value>
    public bool? IsVoicemail { get; set; }

    /// <summary>
    /// Indicates filtering for flagged
    /// </summary>
    /// <value>Indicates filtering for flagged</value>
    public bool? IsFlagged { get; set; }

    /// <summary>
    /// Indicates filtering for monitored
    /// </summary>
    /// <value>Indicates filtering for monitored</value>
    public bool? IsMonitored { get; set; }

    /// <summary>
    /// Indicates filtering for screenMonitored
    /// </summary>
    /// <value>Indicates filtering for screenMonitored</value>
    public bool? IsScreenMonitored { get; set; }

    /// <summary>
    /// Indicates filtering for WrapUpNotes
    /// </summary>
    /// <value>Indicates filtering for WrapUpNotes</value>
    public bool? FilterWrapUpNotes { get; set; }

    /// <summary>
    /// Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic
    /// </summary>
    /// <value>Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic</value>
    public bool? MatchAll { get; set; }
}
