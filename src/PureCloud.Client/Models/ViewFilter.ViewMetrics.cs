using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ViewMetrics
/// </summary>

public enum ViewFilterViewMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum AvgTalkTime for "AVG_TALK_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_TALK_TIME")]
    AvgTalkTime,

    /// <summary>
    /// Enum AvgHoldTime for "AVG_HOLD_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_HOLD_TIME")]
    AvgHoldTime,

    /// <summary>
    /// Enum AvgAcwTime for "AVG_ACW_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_ACW_TIME")]
    AvgAcwTime,

    /// <summary>
    /// Enum AvgWaitTime for "AVG_WAIT_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_WAIT_TIME")]
    AvgWaitTime,

    /// <summary>
    /// Enum AvgHandleTime for "AVG_HANDLE_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_HANDLE_TIME")]
    AvgHandleTime,

    /// <summary>
    /// Enum AvgAlertTime for "AVG_ALERT_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_ALERT_TIME")]
    AvgAlertTime,

    /// <summary>
    /// Enum AvgAnswerTime for "AVG_ANSWER_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_ANSWER_TIME")]
    AvgAnswerTime,

    /// <summary>
    /// Enum AvgAbandonTime for "AVG_ABANDON_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_ABANDON_TIME")]
    AvgAbandonTime,

    /// <summary>
    /// Enum TotalTalkTime for "TOTAL_TALK_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_TALK_TIME")]
    TotalTalkTime,

    /// <summary>
    /// Enum TotalHandleTime for "TOTAL_HANDLE_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_HANDLE_TIME")]
    TotalHandleTime,

    /// <summary>
    /// Enum TotalHoldTime for "TOTAL_HOLD_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_HOLD_TIME")]
    TotalHoldTime,

    /// <summary>
    /// Enum TotalAcwTime for "TOTAL_ACW_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_ACW_TIME")]
    TotalAcwTime,

    /// <summary>
    /// Enum TotalAlertTime for "TOTAL_ALERT_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_ALERT_TIME")]
    TotalAlertTime,

    /// <summary>
    /// Enum MaxAbandonTime for "MAX_ABANDON_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_ABANDON_TIME")]
    MaxAbandonTime,

    /// <summary>
    /// Enum MaxWaitTime for "MAX_WAIT_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_WAIT_TIME")]
    MaxWaitTime,

    /// <summary>
    /// Enum MaxTalkTime for "MAX_TALK_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_TALK_TIME")]
    MaxTalkTime,

    /// <summary>
    /// Enum MaxHoldTime for "MAX_HOLD_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_HOLD_TIME")]
    MaxHoldTime,

    /// <summary>
    /// Enum MaxAcwTime for "MAX_ACW_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_ACW_TIME")]
    MaxAcwTime,

    /// <summary>
    /// Enum MinAbandonTime for "MIN_ABANDON_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_ABANDON_TIME")]
    MinAbandonTime,

    /// <summary>
    /// Enum MinWaitTime for "MIN_WAIT_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_WAIT_TIME")]
    MinWaitTime,

    /// <summary>
    /// Enum MinTalkTime for "MIN_TALK_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_TALK_TIME")]
    MinTalkTime,

    /// <summary>
    /// Enum MinHoldTime for "MIN_HOLD_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_HOLD_TIME")]
    MinHoldTime,

    /// <summary>
    /// Enum MinAcwTime for "MIN_ACW_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_ACW_TIME")]
    MinAcwTime,

    /// <summary>
    /// Enum AlertCount for "ALERT_COUNT"
    /// </summary>
    [EnumMember(Value = "ALERT_COUNT")]
    AlertCount,

    /// <summary>
    /// Enum OfferedCount for "OFFERED_COUNT"
    /// </summary>
    [EnumMember(Value = "OFFERED_COUNT")]
    OfferedCount,

    /// <summary>
    /// Enum AbandonedCount for "ABANDONED_COUNT"
    /// </summary>
    [EnumMember(Value = "ABANDONED_COUNT")]
    AbandonedCount,

    /// <summary>
    /// Enum AbandonedPercent for "ABANDONED_PERCENT"
    /// </summary>
    [EnumMember(Value = "ABANDONED_PERCENT")]
    AbandonedPercent,

    /// <summary>
    /// Enum ShortAbandonedCount for "SHORT_ABANDONED_COUNT"
    /// </summary>
    [EnumMember(Value = "SHORT_ABANDONED_COUNT")]
    ShortAbandonedCount,

    /// <summary>
    /// Enum ShortAbandonedPercent for "SHORT_ABANDONED_PERCENT"
    /// </summary>
    [EnumMember(Value = "SHORT_ABANDONED_PERCENT")]
    ShortAbandonedPercent,

    /// <summary>
    /// Enum AbandonedNoShortCount for "ABANDONED_NO_SHORT_COUNT"
    /// </summary>
    [EnumMember(Value = "ABANDONED_NO_SHORT_COUNT")]
    AbandonedNoShortCount,

    /// <summary>
    /// Enum AbandonedNoShortPercent for "ABANDONED_NO_SHORT_PERCENT"
    /// </summary>
    [EnumMember(Value = "ABANDONED_NO_SHORT_PERCENT")]
    AbandonedNoShortPercent,

    /// <summary>
    /// Enum AnsweredCount for "ANSWERED_COUNT"
    /// </summary>
    [EnumMember(Value = "ANSWERED_COUNT")]
    AnsweredCount,

    /// <summary>
    /// Enum AnsweredPercent for "ANSWERED_PERCENT"
    /// </summary>
    [EnumMember(Value = "ANSWERED_PERCENT")]
    AnsweredPercent,

    /// <summary>
    /// Enum FlowoutCount for "FLOWOUT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOWOUT_COUNT")]
    FlowoutCount,

    /// <summary>
    /// Enum FlowoutPercent for "FLOWOUT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOWOUT_PERCENT")]
    FlowoutPercent,

    /// <summary>
    /// Enum OutboundCount for "OUTBOUND_COUNT"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_COUNT")]
    OutboundCount,

    /// <summary>
    /// Enum OutboundAttemptedCount for "OUTBOUND_ATTEMPTED_COUNT"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_ATTEMPTED_COUNT")]
    OutboundAttemptedCount,

    /// <summary>
    /// Enum VoicemailCount for "VOICEMAIL_COUNT"
    /// </summary>
    [EnumMember(Value = "VOICEMAIL_COUNT")]
    VoicemailCount,

    /// <summary>
    /// Enum HandledCount for "HANDLED_COUNT"
    /// </summary>
    [EnumMember(Value = "HANDLED_COUNT")]
    HandledCount,

    /// <summary>
    /// Enum HeldCount for "HELD_COUNT"
    /// </summary>
    [EnumMember(Value = "HELD_COUNT")]
    HeldCount,

    /// <summary>
    /// Enum TransferredCount for "TRANSFERRED_COUNT"
    /// </summary>
    [EnumMember(Value = "TRANSFERRED_COUNT")]
    TransferredCount,

    /// <summary>
    /// Enum TransferredPercent for "TRANSFERRED_PERCENT"
    /// </summary>
    [EnumMember(Value = "TRANSFERRED_PERCENT")]
    TransferredPercent,

    /// <summary>
    /// Enum WaitingCurrent for "WAITING_CURRENT"
    /// </summary>
    [EnumMember(Value = "WAITING_CURRENT")]
    WaitingCurrent,

    /// <summary>
    /// Enum InteractingCurrent for "INTERACTING_CURRENT"
    /// </summary>
    [EnumMember(Value = "INTERACTING_CURRENT")]
    InteractingCurrent,

    /// <summary>
    /// Enum HeldCurrent for "HELD_CURRENT"
    /// </summary>
    [EnumMember(Value = "HELD_CURRENT")]
    HeldCurrent,

    /// <summary>
    /// Enum AlertingCurrent for "ALERTING_CURRENT"
    /// </summary>
    [EnumMember(Value = "ALERTING_CURRENT")]
    AlertingCurrent,

    /// <summary>
    /// Enum ServiceLevel for "SERVICE_LEVEL"
    /// </summary>
    [EnumMember(Value = "SERVICE_LEVEL")]
    ServiceLevel,

    /// <summary>
    /// Enum OverServiceLevel for "OVER_SERVICE_LEVEL"
    /// </summary>
    [EnumMember(Value = "OVER_SERVICE_LEVEL")]
    OverServiceLevel,

    /// <summary>
    /// Enum OnlineAgents for "ONLINE_AGENTS"
    /// </summary>
    [EnumMember(Value = "ONLINE_AGENTS")]
    OnlineAgents,

    /// <summary>
    /// Enum AvailableAgents for "AVAILABLE_AGENTS"
    /// </summary>
    [EnumMember(Value = "AVAILABLE_AGENTS")]
    AvailableAgents,

    /// <summary>
    /// Enum AwayAgents for "AWAY_AGENTS"
    /// </summary>
    [EnumMember(Value = "AWAY_AGENTS")]
    AwayAgents,

    /// <summary>
    /// Enum BreakAgents for "BREAK_AGENTS"
    /// </summary>
    [EnumMember(Value = "BREAK_AGENTS")]
    BreakAgents,

    /// <summary>
    /// Enum MealAgents for "MEAL_AGENTS"
    /// </summary>
    [EnumMember(Value = "MEAL_AGENTS")]
    MealAgents,

    /// <summary>
    /// Enum TrainingAgents for "TRAINING_AGENTS"
    /// </summary>
    [EnumMember(Value = "TRAINING_AGENTS")]
    TrainingAgents,

    /// <summary>
    /// Enum BusyAgents for "BUSY_AGENTS"
    /// </summary>
    [EnumMember(Value = "BUSY_AGENTS")]
    BusyAgents,

    /// <summary>
    /// Enum MeetingAgents for "MEETING_AGENTS"
    /// </summary>
    [EnumMember(Value = "MEETING_AGENTS")]
    MeetingAgents,

    /// <summary>
    /// Enum SystemAwayAgents for "SYSTEM_AWAY_AGENTS"
    /// </summary>
    [EnumMember(Value = "SYSTEM_AWAY_AGENTS")]
    SystemAwayAgents,

    /// <summary>
    /// Enum OfflineAgents for "OFFLINE_AGENTS"
    /// </summary>
    [EnumMember(Value = "OFFLINE_AGENTS")]
    OfflineAgents,

    /// <summary>
    /// Enum OnQueueAgents for "ON_QUEUE_AGENTS"
    /// </summary>
    [EnumMember(Value = "ON_QUEUE_AGENTS")]
    OnQueueAgents,

    /// <summary>
    /// Enum OffQueueAgents for "OFF_QUEUE_AGENTS"
    /// </summary>
    [EnumMember(Value = "OFF_QUEUE_AGENTS")]
    OffQueueAgents,

    /// <summary>
    /// Enum InteractingAgents for "INTERACTING_AGENTS"
    /// </summary>
    [EnumMember(Value = "INTERACTING_AGENTS")]
    InteractingAgents,

    /// <summary>
    /// Enum AcwAgents for "ACW_AGENTS"
    /// </summary>
    [EnumMember(Value = "ACW_AGENTS")]
    AcwAgents,

    /// <summary>
    /// Enum CommunicatingAgents for "COMMUNICATING_AGENTS"
    /// </summary>
    [EnumMember(Value = "COMMUNICATING_AGENTS")]
    CommunicatingAgents,

    /// <summary>
    /// Enum IdleAgents for "IDLE_AGENTS"
    /// </summary>
    [EnumMember(Value = "IDLE_AGENTS")]
    IdleAgents,

    /// <summary>
    /// Enum NotRespondingAgents for "NOT_RESPONDING_AGENTS"
    /// </summary>
    [EnumMember(Value = "NOT_RESPONDING_AGENTS")]
    NotRespondingAgents,

    /// <summary>
    /// Enum LongestWaiting for "LONGEST_WAITING"
    /// </summary>
    [EnumMember(Value = "LONGEST_WAITING")]
    LongestWaiting,

    /// <summary>
    /// Enum LongestInteracting for "LONGEST_INTERACTING"
    /// </summary>
    [EnumMember(Value = "LONGEST_INTERACTING")]
    LongestInteracting,

    /// <summary>
    /// Enum FlowActiveLongest for "FLOW_ACTIVE_LONGEST"
    /// </summary>
    [EnumMember(Value = "FLOW_ACTIVE_LONGEST")]
    FlowActiveLongest,

    /// <summary>
    /// Enum FlowActiveCurrent for "FLOW_ACTIVE_CURRENT"
    /// </summary>
    [EnumMember(Value = "FLOW_ACTIVE_CURRENT")]
    FlowActiveCurrent,

    /// <summary>
    /// Enum FlowEntriesCount for "FLOW_ENTRIES_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_ENTRIES_COUNT")]
    FlowEntriesCount,

    /// <summary>
    /// Enum FlowTotalDuration for "FLOW_TOTAL_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_TOTAL_DURATION")]
    FlowTotalDuration,

    /// <summary>
    /// Enum FlowMaxDuration for "FLOW_MAX_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_MAX_DURATION")]
    FlowMaxDuration,

    /// <summary>
    /// Enum FlowAvgDuration for "FLOW_AVG_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_AVG_DURATION")]
    FlowAvgDuration,

    /// <summary>
    /// Enum FlowDisconnectCount for "FLOW_DISCONNECT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_DISCONNECT_COUNT")]
    FlowDisconnectCount,

    /// <summary>
    /// Enum FlowDisconnectPercent for "FLOW_DISCONNECT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_DISCONNECT_PERCENT")]
    FlowDisconnectPercent,

    /// <summary>
    /// Enum FlowTotalDisconnectDuration for "FLOW_TOTAL_DISCONNECT_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_TOTAL_DISCONNECT_DURATION")]
    FlowTotalDisconnectDuration,

    /// <summary>
    /// Enum FlowAvgDisconnectDuration for "FLOW_AVG_DISCONNECT_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_AVG_DISCONNECT_DURATION")]
    FlowAvgDisconnectDuration,

    /// <summary>
    /// Enum FlowMaxDisconnectDuration for "FLOW_MAX_DISCONNECT_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_MAX_DISCONNECT_DURATION")]
    FlowMaxDisconnectDuration,

    /// <summary>
    /// Enum FlowFlowDisconnect for "FLOW_FLOW_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_FLOW_DISCONNECT")]
    FlowFlowDisconnect,

    /// <summary>
    /// Enum FlowFlowDisconnectPercent for "FLOW_FLOW_DISCONNECT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_FLOW_DISCONNECT_PERCENT")]
    FlowFlowDisconnectPercent,

    /// <summary>
    /// Enum FlowSystemErrorDisconnect for "FLOW_SYSTEM_ERROR_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT")]
    FlowSystemErrorDisconnect,

    /// <summary>
    /// Enum FlowSystemErrorDisconnectPercent for "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT")]
    FlowSystemErrorDisconnectPercent,

    /// <summary>
    /// Enum FlowCustomerDisconnect for "FLOW_CUSTOMER_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT")]
    FlowCustomerDisconnect,

    /// <summary>
    /// Enum FlowCustomerDisconnectPercent for "FLOW_CUSTOMER_DISCONNECT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT_PERCENT")]
    FlowCustomerDisconnectPercent,

    /// <summary>
    /// Enum FlowShortDisconnect for "FLOW_SHORT_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_SHORT_DISCONNECT")]
    FlowShortDisconnect,

    /// <summary>
    /// Enum FlowShortDisconnectPercent for "FLOW_SHORT_DISCONNECT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_SHORT_DISCONNECT_PERCENT")]
    FlowShortDisconnectPercent,

    /// <summary>
    /// Enum FlowExitCount for "FLOW_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_EXIT_COUNT")]
    FlowExitCount,

    /// <summary>
    /// Enum FlowExitPercent for "FLOW_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_EXIT_PERCENT")]
    FlowExitPercent,

    /// <summary>
    /// Enum FlowTotalExitDuration for "FLOW_TOTAL_EXIT_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_TOTAL_EXIT_DURATION")]
    FlowTotalExitDuration,

    /// <summary>
    /// Enum FlowMaxExitDuration for "FLOW_MAX_EXIT_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_MAX_EXIT_DURATION")]
    FlowMaxExitDuration,

    /// <summary>
    /// Enum FlowAvgExitDuration for "FLOW_AVG_EXIT_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_AVG_EXIT_DURATION")]
    FlowAvgExitDuration,

    /// <summary>
    /// Enum FlowAcdExitCount for "FLOW_ACD_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_ACD_EXIT_COUNT")]
    FlowAcdExitCount,

    /// <summary>
    /// Enum FlowAcdExitPercent for "FLOW_ACD_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_ACD_EXIT_PERCENT")]
    FlowAcdExitPercent,

    /// <summary>
    /// Enum FlowGroupExitCount for "FLOW_GROUP_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_GROUP_EXIT_COUNT")]
    FlowGroupExitCount,

    /// <summary>
    /// Enum FlowGroupExitPercent for "FLOW_GROUP_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_GROUP_EXIT_PERCENT")]
    FlowGroupExitPercent,

    /// <summary>
    /// Enum FlowNumberExitCount for "FLOW_NUMBER_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_NUMBER_EXIT_COUNT")]
    FlowNumberExitCount,

    /// <summary>
    /// Enum FlowNumberExitPercent for "FLOW_NUMBER_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_NUMBER_EXIT_PERCENT")]
    FlowNumberExitPercent,

    /// <summary>
    /// Enum FlowUserExitCount for "FLOW_USER_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_USER_EXIT_COUNT")]
    FlowUserExitCount,

    /// <summary>
    /// Enum FlowUserExitPercent for "FLOW_USER_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_USER_EXIT_PERCENT")]
    FlowUserExitPercent,

    /// <summary>
    /// Enum FlowFlowExitCount for "FLOW_FLOW_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_FLOW_EXIT_COUNT")]
    FlowFlowExitCount,

    /// <summary>
    /// Enum FlowFlowExitPercent for "FLOW_FLOW_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_FLOW_EXIT_PERCENT")]
    FlowFlowExitPercent,

    /// <summary>
    /// Enum FlowSecureFlowExitCount for "FLOW_SECURE_FLOW_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_COUNT")]
    FlowSecureFlowExitCount,

    /// <summary>
    /// Enum FlowSecureFlowExitPercent for "FLOW_SECURE_FLOW_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_PERCENT")]
    FlowSecureFlowExitPercent,

    /// <summary>
    /// Enum FlowAcdVoicemailExitCount for "FLOW_ACD_VOICEMAIL_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_COUNT")]
    FlowAcdVoicemailExitCount,

    /// <summary>
    /// Enum FlowAcdVoicemailExitPercent for "FLOW_ACD_VOICEMAIL_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_PERCENT")]
    FlowAcdVoicemailExitPercent,

    /// <summary>
    /// Enum FlowUserVoicemailExitCount for "FLOW_USER_VOICEMAIL_EXIT_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_COUNT")]
    FlowUserVoicemailExitCount,

    /// <summary>
    /// Enum FlowUserVoicemailExitPercent for "FLOW_USER_VOICEMAIL_EXIT_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_PERCENT")]
    FlowUserVoicemailExitPercent,

    /// <summary>
    /// Enum FlowOutcomeCount for "FLOW_OUTCOME_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_COUNT")]
    FlowOutcomeCount,

    /// <summary>
    /// Enum FlowAvgOutcomeDecimal for "FLOW_AVG_OUTCOME_DECIMAL"
    /// </summary>
    [EnumMember(Value = "FLOW_AVG_OUTCOME_DECIMAL")]
    FlowAvgOutcomeDecimal,

    /// <summary>
    /// Enum FlowOutcomeFailureCount for "FLOW_OUTCOME_FAILURE_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_FAILURE_COUNT")]
    FlowOutcomeFailureCount,

    /// <summary>
    /// Enum FlowOutcomeFailurePercent for "FLOW_OUTCOME_FAILURE_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_FAILURE_PERCENT")]
    FlowOutcomeFailurePercent,

    /// <summary>
    /// Enum FlowOutcomeSuccessCount for "FLOW_OUTCOME_SUCCESS_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_SUCCESS_COUNT")]
    FlowOutcomeSuccessCount,

    /// <summary>
    /// Enum FlowOutcomeSuccessPercent for "FLOW_OUTCOME_SUCCESS_PERCENT"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_SUCCESS_PERCENT")]
    FlowOutcomeSuccessPercent,

    /// <summary>
    /// Enum FlowOutcomeTotalDuration for "FLOW_OUTCOME_TOTAL_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_TOTAL_DURATION")]
    FlowOutcomeTotalDuration,

    /// <summary>
    /// Enum FlowOutcomeMaxDuration for "FLOW_OUTCOME_MAX_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_MAX_DURATION")]
    FlowOutcomeMaxDuration,

    /// <summary>
    /// Enum FlowOutcomeAvgDuration for "FLOW_OUTCOME_AVG_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_AVG_DURATION")]
    FlowOutcomeAvgDuration,

    /// <summary>
    /// Enum FlowOutcomeMinDuration for "FLOW_OUTCOME_MIN_DURATION"
    /// </summary>
    [EnumMember(Value = "FLOW_OUTCOME_MIN_DURATION")]
    FlowOutcomeMinDuration,

    /// <summary>
    /// Enum OffQueueTime for "OFF_QUEUE_TIME"
    /// </summary>
    [EnumMember(Value = "OFF_QUEUE_TIME")]
    OffQueueTime,

    /// <summary>
    /// Enum OffQueuePercent for "OFF_QUEUE_PERCENT"
    /// </summary>
    [EnumMember(Value = "OFF_QUEUE_PERCENT")]
    OffQueuePercent,

    /// <summary>
    /// Enum AvailableTime for "AVAILABLE_TIME"
    /// </summary>
    [EnumMember(Value = "AVAILABLE_TIME")]
    AvailableTime,

    /// <summary>
    /// Enum AvailablePercent for "AVAILABLE_PERCENT"
    /// </summary>
    [EnumMember(Value = "AVAILABLE_PERCENT")]
    AvailablePercent,

    /// <summary>
    /// Enum BusyTime for "BUSY_TIME"
    /// </summary>
    [EnumMember(Value = "BUSY_TIME")]
    BusyTime,

    /// <summary>
    /// Enum BusyPercent for "BUSY_PERCENT"
    /// </summary>
    [EnumMember(Value = "BUSY_PERCENT")]
    BusyPercent,

    /// <summary>
    /// Enum AwayTime for "AWAY_TIME"
    /// </summary>
    [EnumMember(Value = "AWAY_TIME")]
    AwayTime,

    /// <summary>
    /// Enum AwayPercent for "AWAY_PERCENT"
    /// </summary>
    [EnumMember(Value = "AWAY_PERCENT")]
    AwayPercent,

    /// <summary>
    /// Enum BreakTime for "BREAK_TIME"
    /// </summary>
    [EnumMember(Value = "BREAK_TIME")]
    BreakTime,

    /// <summary>
    /// Enum BreakPercent for "BREAK_PERCENT"
    /// </summary>
    [EnumMember(Value = "BREAK_PERCENT")]
    BreakPercent,

    /// <summary>
    /// Enum MealTime for "MEAL_TIME"
    /// </summary>
    [EnumMember(Value = "MEAL_TIME")]
    MealTime,

    /// <summary>
    /// Enum MealPercent for "MEAL_PERCENT"
    /// </summary>
    [EnumMember(Value = "MEAL_PERCENT")]
    MealPercent,

    /// <summary>
    /// Enum MeetingTime for "MEETING_TIME"
    /// </summary>
    [EnumMember(Value = "MEETING_TIME")]
    MeetingTime,

    /// <summary>
    /// Enum MeetingPercent for "MEETING_PERCENT"
    /// </summary>
    [EnumMember(Value = "MEETING_PERCENT")]
    MeetingPercent,

    /// <summary>
    /// Enum TrainingTime for "TRAINING_TIME"
    /// </summary>
    [EnumMember(Value = "TRAINING_TIME")]
    TrainingTime,

    /// <summary>
    /// Enum TrainingPercent for "TRAINING_PERCENT"
    /// </summary>
    [EnumMember(Value = "TRAINING_PERCENT")]
    TrainingPercent,

    /// <summary>
    /// Enum InteractingTime for "INTERACTING_TIME"
    /// </summary>
    [EnumMember(Value = "INTERACTING_TIME")]
    InteractingTime,

    /// <summary>
    /// Enum InteractingPercent for "INTERACTING_PERCENT"
    /// </summary>
    [EnumMember(Value = "INTERACTING_PERCENT")]
    InteractingPercent,

    /// <summary>
    /// Enum CommunicatingTime for "COMMUNICATING_TIME"
    /// </summary>
    [EnumMember(Value = "COMMUNICATING_TIME")]
    CommunicatingTime,

    /// <summary>
    /// Enum CommunicatingPercent for "COMMUNICATING_PERCENT"
    /// </summary>
    [EnumMember(Value = "COMMUNICATING_PERCENT")]
    CommunicatingPercent,

    /// <summary>
    /// Enum SystemAwayTime for "SYSTEM_AWAY_TIME"
    /// </summary>
    [EnumMember(Value = "SYSTEM_AWAY_TIME")]
    SystemAwayTime,

    /// <summary>
    /// Enum SystemAwayPercent for "SYSTEM_AWAY_PERCENT"
    /// </summary>
    [EnumMember(Value = "SYSTEM_AWAY_PERCENT")]
    SystemAwayPercent,

    /// <summary>
    /// Enum OnQueueTime for "ON_QUEUE_TIME"
    /// </summary>
    [EnumMember(Value = "ON_QUEUE_TIME")]
    OnQueueTime,

    /// <summary>
    /// Enum OnQueuePercent for "ON_QUEUE_PERCENT"
    /// </summary>
    [EnumMember(Value = "ON_QUEUE_PERCENT")]
    OnQueuePercent,

    /// <summary>
    /// Enum IdleTime for "IDLE_TIME"
    /// </summary>
    [EnumMember(Value = "IDLE_TIME")]
    IdleTime,

    /// <summary>
    /// Enum IdlePercent for "IDLE_PERCENT"
    /// </summary>
    [EnumMember(Value = "IDLE_PERCENT")]
    IdlePercent,

    /// <summary>
    /// Enum NotRespondingTime for "NOT_RESPONDING_TIME"
    /// </summary>
    [EnumMember(Value = "NOT_RESPONDING_TIME")]
    NotRespondingTime,

    /// <summary>
    /// Enum NotRespondingPercent for "NOT_RESPONDING_PERCENT"
    /// </summary>
    [EnumMember(Value = "NOT_RESPONDING_PERCENT")]
    NotRespondingPercent,

    /// <summary>
    /// Enum LoggedInTime for "LOGGED_IN_TIME"
    /// </summary>
    [EnumMember(Value = "LOGGED_IN_TIME")]
    LoggedInTime,

    /// <summary>
    /// Enum OccupancyPercent for "OCCUPANCY_PERCENT"
    /// </summary>
    [EnumMember(Value = "OCCUPANCY_PERCENT")]
    OccupancyPercent,

    /// <summary>
    /// Enum MinAlertTime for "MIN_ALERT_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_ALERT_TIME")]
    MinAlertTime,

    /// <summary>
    /// Enum MaxAlertTime for "MAX_ALERT_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_ALERT_TIME")]
    MaxAlertTime,

    /// <summary>
    /// Enum MinHandleTime for "MIN_HANDLE_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_HANDLE_TIME")]
    MinHandleTime,

    /// <summary>
    /// Enum MaxHandleTime for "MAX_HANDLE_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_HANDLE_TIME")]
    MaxHandleTime,

    /// <summary>
    /// Enum MinAnsweredTime for "MIN_ANSWERED_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_ANSWERED_TIME")]
    MinAnsweredTime,

    /// <summary>
    /// Enum MaxAnsweredTime for "MAX_ANSWERED_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_ANSWERED_TIME")]
    MaxAnsweredTime,

    /// <summary>
    /// Enum MinNotRespondingTime for "MIN_NOT_RESPONDING_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_NOT_RESPONDING_TIME")]
    MinNotRespondingTime,

    /// <summary>
    /// Enum MaxNotRespondingTime for "MAX_NOT_RESPONDING_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_NOT_RESPONDING_TIME")]
    MaxNotRespondingTime,

    /// <summary>
    /// Enum MetServiceLevel for "MET_SERVICE_LEVEL"
    /// </summary>
    [EnumMember(Value = "MET_SERVICE_LEVEL")]
    MetServiceLevel,

    /// <summary>
    /// Enum WfmAdherenceStatus for "WFM_ADHERENCE_STATUS"
    /// </summary>
    [EnumMember(Value = "WFM_ADHERENCE_STATUS")]
    WfmAdherenceStatus,

    /// <summary>
    /// Enum WfmScheduledActivity for "WFM_SCHEDULED_ACTIVITY"
    /// </summary>
    [EnumMember(Value = "WFM_SCHEDULED_ACTIVITY")]
    WfmScheduledActivity,

    /// <summary>
    /// Enum WfmAdherenceDuration for "WFM_ADHERENCE_DURATION"
    /// </summary>
    [EnumMember(Value = "WFM_ADHERENCE_DURATION")]
    WfmAdherenceDuration,

    /// <summary>
    /// Enum AgentTitle for "AGENT_TITLE"
    /// </summary>
    [EnumMember(Value = "AGENT_TITLE")]
    AgentTitle,

    /// <summary>
    /// Enum AgentDepartment for "AGENT_DEPARTMENT"
    /// </summary>
    [EnumMember(Value = "AGENT_DEPARTMENT")]
    AgentDepartment,

    /// <summary>
    /// Enum AgentExtension for "AGENT_EXTENSION"
    /// </summary>
    [EnumMember(Value = "AGENT_EXTENSION")]
    AgentExtension,

    /// <summary>
    /// Enum AgentSkills for "AGENT_SKILLS"
    /// </summary>
    [EnumMember(Value = "AGENT_SKILLS")]
    AgentSkills,

    /// <summary>
    /// Enum AgentLocation for "AGENT_LOCATION"
    /// </summary>
    [EnumMember(Value = "AGENT_LOCATION")]
    AgentLocation,

    /// <summary>
    /// Enum AgentReportsTo for "AGENT_REPORTS_TO"
    /// </summary>
    [EnumMember(Value = "AGENT_REPORTS_TO")]
    AgentReportsTo,

    /// <summary>
    /// Enum AgentEmail for "AGENT_EMAIL"
    /// </summary>
    [EnumMember(Value = "AGENT_EMAIL")]
    AgentEmail,

    /// <summary>
    /// Enum AgentRole for "AGENT_ROLE"
    /// </summary>
    [EnumMember(Value = "AGENT_ROLE")]
    AgentRole,

    /// <summary>
    /// Enum AgentGroup for "AGENT_GROUP"
    /// </summary>
    [EnumMember(Value = "AGENT_GROUP")]
    AgentGroup,

    /// <summary>
    /// Enum AgentTimeInStatus for "AGENT_TIME_IN_STATUS"
    /// </summary>
    [EnumMember(Value = "AGENT_TIME_IN_STATUS")]
    AgentTimeInStatus,

    /// <summary>
    /// Enum AgentTimeInRoutingStatus for "AGENT_TIME_IN_ROUTING_STATUS"
    /// </summary>
    [EnumMember(Value = "AGENT_TIME_IN_ROUTING_STATUS")]
    AgentTimeInRoutingStatus,

    /// <summary>
    /// Enum AgentStatus for "AGENT_STATUS"
    /// </summary>
    [EnumMember(Value = "AGENT_STATUS")]
    AgentStatus,

    /// <summary>
    /// Enum AgentSecondaryStatus for "AGENT_SECONDARY_STATUS"
    /// </summary>
    [EnumMember(Value = "AGENT_SECONDARY_STATUS")]
    AgentSecondaryStatus,

    /// <summary>
    /// Enum AgentRoutingStatus for "AGENT_ROUTING_STATUS"
    /// </summary>
    [EnumMember(Value = "AGENT_ROUTING_STATUS")]
    AgentRoutingStatus,

    /// <summary>
    /// Enum AgentMediaTypes for "AGENT_MEDIA_TYPES"
    /// </summary>
    [EnumMember(Value = "AGENT_MEDIA_TYPES")]
    AgentMediaTypes,

    /// <summary>
    /// Enum AcwCount for "ACW_COUNT"
    /// </summary>
    [EnumMember(Value = "ACW_COUNT")]
    AcwCount,

    /// <summary>
    /// Enum AnswerTransferredPercent for "ANSWER_TRANSFERRED_PERCENT"
    /// </summary>
    [EnumMember(Value = "ANSWER_TRANSFERRED_PERCENT")]
    AnswerTransferredPercent,

    /// <summary>
    /// Enum FlowAvgMilestoneDecimal for "FLOW_AVG_MILESTONE_DECIMAL"
    /// </summary>
    [EnumMember(Value = "FLOW_AVG_MILESTONE_DECIMAL")]
    FlowAvgMilestoneDecimal,

    /// <summary>
    /// Enum NotRespondingCount for "NOT_RESPONDING_COUNT"
    /// </summary>
    [EnumMember(Value = "NOT_RESPONDING_COUNT")]
    NotRespondingCount,

    /// <summary>
    /// Enum AvgAcwHandled for "AVG_ACW_HANDLED"
    /// </summary>
    [EnumMember(Value = "AVG_ACW_HANDLED")]
    AvgAcwHandled,

    /// <summary>
    /// Enum AvgContactingTime for "AVG_CONTACTING_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_CONTACTING_TIME")]
    AvgContactingTime,

    /// <summary>
    /// Enum AvgDialingTime for "AVG_DIALING_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_DIALING_TIME")]
    AvgDialingTime,

    /// <summary>
    /// Enum AvgFlowoutTime for "AVG_FLOWOUT_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_FLOWOUT_TIME")]
    AvgFlowoutTime,

    /// <summary>
    /// Enum AvgHoldHandled for "AVG_HOLD_HANDLED"
    /// </summary>
    [EnumMember(Value = "AVG_HOLD_HANDLED")]
    AvgHoldHandled,

    /// <summary>
    /// Enum AvgMonitor for "AVG_MONITOR"
    /// </summary>
    [EnumMember(Value = "AVG_MONITOR")]
    AvgMonitor,

    /// <summary>
    /// Enum BlindTransferCount for "BLIND_TRANSFER_COUNT"
    /// </summary>
    [EnumMember(Value = "BLIND_TRANSFER_COUNT")]
    BlindTransferCount,

    /// <summary>
    /// Enum BlindTransferPercent for "BLIND_TRANSFER_PERCENT"
    /// </summary>
    [EnumMember(Value = "BLIND_TRANSFER_PERCENT")]
    BlindTransferPercent,

    /// <summary>
    /// Enum ConnectedCount for "CONNECTED_COUNT"
    /// </summary>
    [EnumMember(Value = "CONNECTED_COUNT")]
    ConnectedCount,

    /// <summary>
    /// Enum ConsultCount for "CONSULT_COUNT"
    /// </summary>
    [EnumMember(Value = "CONSULT_COUNT")]
    ConsultCount,

    /// <summary>
    /// Enum ConsultTransferCount for "CONSULT_TRANSFER_COUNT"
    /// </summary>
    [EnumMember(Value = "CONSULT_TRANSFER_COUNT")]
    ConsultTransferCount,

    /// <summary>
    /// Enum ConsultTransferPercent for "CONSULT_TRANSFER_PERCENT"
    /// </summary>
    [EnumMember(Value = "CONSULT_TRANSFER_PERCENT")]
    ConsultTransferPercent,

    /// <summary>
    /// Enum ContactingCount for "CONTACTING_COUNT"
    /// </summary>
    [EnumMember(Value = "CONTACTING_COUNT")]
    ContactingCount,

    /// <summary>
    /// Enum DialingCount for "DIALING_COUNT"
    /// </summary>
    [EnumMember(Value = "DIALING_COUNT")]
    DialingCount,

    /// <summary>
    /// Enum ErrorCount for "ERROR_COUNT"
    /// </summary>
    [EnumMember(Value = "ERROR_COUNT")]
    ErrorCount,

    /// <summary>
    /// Enum ExternalMediaCount for "EXTERNAL_MEDIA_COUNT"
    /// </summary>
    [EnumMember(Value = "EXTERNAL_MEDIA_COUNT")]
    ExternalMediaCount,

    /// <summary>
    /// Enum MaxContactingTime for "MAX_CONTACTING_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_CONTACTING_TIME")]
    MaxContactingTime,

    /// <summary>
    /// Enum MaxDialingTime for "MAX_DIALING_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_DIALING_TIME")]
    MaxDialingTime,

    /// <summary>
    /// Enum MaxFlowoutTime for "MAX_FLOWOUT_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_FLOWOUT_TIME")]
    MaxFlowoutTime,

    /// <summary>
    /// Enum FlowMilestoneCount for "FLOW_MILESTONE_COUNT"
    /// </summary>
    [EnumMember(Value = "FLOW_MILESTONE_COUNT")]
    FlowMilestoneCount,

    /// <summary>
    /// Enum MinFlowoutTime for "MIN_FLOWOUT_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_FLOWOUT_TIME")]
    MinFlowoutTime,

    /// <summary>
    /// Enum MaxMonitor for "MAX_MONITOR"
    /// </summary>
    [EnumMember(Value = "MAX_MONITOR")]
    MaxMonitor,

    /// <summary>
    /// Enum MinContactingTime for "MIN_CONTACTING_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_CONTACTING_TIME")]
    MinContactingTime,

    /// <summary>
    /// Enum MinDialingTime for "MIN_DIALING_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_DIALING_TIME")]
    MinDialingTime,

    /// <summary>
    /// Enum MinMonitor for "MIN_MONITOR"
    /// </summary>
    [EnumMember(Value = "MIN_MONITOR")]
    MinMonitor,

    /// <summary>
    /// Enum MonitorCount for "MONITOR_COUNT"
    /// </summary>
    [EnumMember(Value = "MONITOR_COUNT")]
    MonitorCount,

    /// <summary>
    /// Enum MediaCount for "MEDIA_COUNT"
    /// </summary>
    [EnumMember(Value = "MEDIA_COUNT")]
    MediaCount,

    /// <summary>
    /// Enum ServiceLevelTarget for "SERVICE_LEVEL_TARGET"
    /// </summary>
    [EnumMember(Value = "SERVICE_LEVEL_TARGET")]
    ServiceLevelTarget,

    /// <summary>
    /// Enum ServiceLevelTargetCurrent for "SERVICE_LEVEL_TARGET_CURRENT"
    /// </summary>
    [EnumMember(Value = "SERVICE_LEVEL_TARGET_CURRENT")]
    ServiceLevelTargetCurrent,

    /// <summary>
    /// Enum TalkCount for "TALK_COUNT"
    /// </summary>
    [EnumMember(Value = "TALK_COUNT")]
    TalkCount,

    /// <summary>
    /// Enum TotalAbandonTime for "TOTAL_ABANDON_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_ABANDON_TIME")]
    TotalAbandonTime,

    /// <summary>
    /// Enum TotalNotRespondingTime for "TOTAL_NOT_RESPONDING_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_NOT_RESPONDING_TIME")]
    TotalNotRespondingTime,

    /// <summary>
    /// Enum TotalContacting for "TOTAL_CONTACTING"
    /// </summary>
    [EnumMember(Value = "TOTAL_CONTACTING")]
    TotalContacting,

    /// <summary>
    /// Enum TotalDialing for "TOTAL_DIALING"
    /// </summary>
    [EnumMember(Value = "TOTAL_DIALING")]
    TotalDialing,

    /// <summary>
    /// Enum TotalMonitor for "TOTAL_MONITOR"
    /// </summary>
    [EnumMember(Value = "TOTAL_MONITOR")]
    TotalMonitor,

    /// <summary>
    /// Enum TotalWaitTime for "TOTAL_WAIT_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_WAIT_TIME")]
    TotalWaitTime,

    /// <summary>
    /// Enum WaitCount for "WAIT_COUNT"
    /// </summary>
    [EnumMember(Value = "WAIT_COUNT")]
    WaitCount,

    /// <summary>
    /// Enum ParkCount for "PARK_COUNT"
    /// </summary>
    [EnumMember(Value = "PARK_COUNT")]
    ParkCount,

    /// <summary>
    /// Enum AvgParkTime for "AVG_PARK_TIME"
    /// </summary>
    [EnumMember(Value = "AVG_PARK_TIME")]
    AvgParkTime,

    /// <summary>
    /// Enum TotalParkTime for "TOTAL_PARK_TIME"
    /// </summary>
    [EnumMember(Value = "TOTAL_PARK_TIME")]
    TotalParkTime,

    /// <summary>
    /// Enum MinParkTime for "MIN_PARK_TIME"
    /// </summary>
    [EnumMember(Value = "MIN_PARK_TIME")]
    MinParkTime,

    /// <summary>
    /// Enum MaxParkTime for "MAX_PARK_TIME"
    /// </summary>
    [EnumMember(Value = "MAX_PARK_TIME")]
    MaxParkTime
}
