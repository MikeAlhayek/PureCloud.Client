using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum QueueConversationChatEventTopicLimitNamespaceEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Agentassistant for "agent.assistant"
    /// </summary>
    [EnumMember(Value = "agent.assistant")]
    Agentassistant,

    /// <summary>
    /// Enum Analyticsalerting for "analytics.alerting"
    /// </summary>
    [EnumMember(Value = "analytics.alerting")]
    Analyticsalerting,

    /// <summary>
    /// Enum Analytics for "analytics"
    /// </summary>
    [EnumMember(Value = "analytics")]
    Analytics,

    /// <summary>
    /// Enum Analyticsrealtime for "analytics.realtime"
    /// </summary>
    [EnumMember(Value = "analytics.realtime")]
    Analyticsrealtime,

    /// <summary>
    /// Enum Analyticsreportingsettings for "analytics.reporting.settings"
    /// </summary>
    [EnumMember(Value = "analytics.reporting.settings")]
    Analyticsreportingsettings,

    /// <summary>
    /// Enum Architect for "architect"
    /// </summary>
    [EnumMember(Value = "architect")]
    Architect,

    /// <summary>
    /// Enum Audiohook for "audiohook"
    /// </summary>
    [EnumMember(Value = "audiohook")]
    Audiohook,

    /// <summary>
    /// Enum Audit for "audit"
    /// </summary>
    [EnumMember(Value = "audit")]
    Audit,

    /// <summary>
    /// Enum Authapi for "auth.api"
    /// </summary>
    [EnumMember(Value = "auth.api")]
    Authapi,

    /// <summary>
    /// Enum Authorization for "authorization"
    /// </summary>
    [EnumMember(Value = "authorization")]
    Authorization,

    /// <summary>
    /// Enum Automationtesting for "automation.testing"
    /// </summary>
    [EnumMember(Value = "automation.testing")]
    Automationtesting,

    /// <summary>
    /// Enum Bots for "bots"
    /// </summary>
    [EnumMember(Value = "bots")]
    Bots,

    /// <summary>
    /// Enum Botsvoice for "bots.voice"
    /// </summary>
    [EnumMember(Value = "bots.voice")]
    Botsvoice,

    /// <summary>
    /// Enum Callback for "callback"
    /// </summary>
    [EnumMember(Value = "callback")]
    Callback,

    /// <summary>
    /// Enum Cobrowse for "cobrowse"
    /// </summary>
    [EnumMember(Value = "cobrowse")]
    Cobrowse,

    /// <summary>
    /// Enum Contentmanagement for "content.management"
    /// </summary>
    [EnumMember(Value = "content.management")]
    Contentmanagement,

    /// <summary>
    /// Enum Conversation for "conversation"
    /// </summary>
    [EnumMember(Value = "conversation")]
    Conversation,

    /// <summary>
    /// Enum Dataactions for "dataactions"
    /// </summary>
    [EnumMember(Value = "dataactions")]
    Dataactions,

    /// <summary>
    /// Enum Datatables for "datatables"
    /// </summary>
    [EnumMember(Value = "datatables")]
    Datatables,

    /// <summary>
    /// Enum Directory for "directory"
    /// </summary>
    [EnumMember(Value = "directory")]
    Directory,

    /// <summary>
    /// Enum Email for "email"
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// Enum Eventorchestration for "event.orchestration"
    /// </summary>
    [EnumMember(Value = "event.orchestration")]
    Eventorchestration,

    /// <summary>
    /// Enum Externalcontacts for "external.contacts"
    /// </summary>
    [EnumMember(Value = "external.contacts")]
    Externalcontacts,

    /// <summary>
    /// Enum Gcv for "gcv"
    /// </summary>
    [EnumMember(Value = "gcv")]
    Gcv,

    /// <summary>
    /// Enum Gdpr for "gdpr"
    /// </summary>
    [EnumMember(Value = "gdpr")]
    Gdpr,

    /// <summary>
    /// Enum Groups for "groups"
    /// </summary>
    [EnumMember(Value = "groups")]
    Groups,

    /// <summary>
    /// Enum Historicaladherence for "historical.adherence"
    /// </summary>
    [EnumMember(Value = "historical.adherence")]
    Historicaladherence,

    /// <summary>
    /// Enum Infrastructureascode for "infrastructureascode"
    /// </summary>
    [EnumMember(Value = "infrastructureascode")]
    Infrastructureascode,

    /// <summary>
    /// Enum Integrations for "integrations"
    /// </summary>
    [EnumMember(Value = "integrations")]
    Integrations,

    /// <summary>
    /// Enum Intentminer for "intent.miner"
    /// </summary>
    [EnumMember(Value = "intent.miner")]
    Intentminer,

    /// <summary>
    /// Enum Journey for "journey"
    /// </summary>
    [EnumMember(Value = "journey")]
    Journey,

    /// <summary>
    /// Enum Knowledge for "knowledge"
    /// </summary>
    [EnumMember(Value = "knowledge")]
    Knowledge,

    /// <summary>
    /// Enum Languageunderstanding for "language.understanding"
    /// </summary>
    [EnumMember(Value = "language.understanding")]
    Languageunderstanding,

    /// <summary>
    /// Enum Learning for "learning"
    /// </summary>
    [EnumMember(Value = "learning")]
    Learning,

    /// <summary>
    /// Enum Limitregistry for "limit.registry"
    /// </summary>
    [EnumMember(Value = "limit.registry")]
    Limitregistry,

    /// <summary>
    /// Enum Marketplace for "marketplace"
    /// </summary>
    [EnumMember(Value = "marketplace")]
    Marketplace,

    /// <summary>
    /// Enum Mediacommunications for "media.communications"
    /// </summary>
    [EnumMember(Value = "media.communications")]
    Mediacommunications,

    /// <summary>
    /// Enum Messaging for "messaging"
    /// </summary>
    [EnumMember(Value = "messaging")]
    Messaging,

    /// <summary>
    /// Enum Notifications for "notifications"
    /// </summary>
    [EnumMember(Value = "notifications")]
    Notifications,

    /// <summary>
    /// Enum Onboarding for "onboarding"
    /// </summary>
    [EnumMember(Value = "onboarding")]
    Onboarding,

    /// <summary>
    /// Enum Outbound for "outbound"
    /// </summary>
    [EnumMember(Value = "outbound")]
    Outbound,

    /// <summary>
    /// Enum Platformapi for "platform.api"
    /// </summary>
    [EnumMember(Value = "platform.api")]
    Platformapi,

    /// <summary>
    /// Enum Predictiverouting for "predictive.routing"
    /// </summary>
    [EnumMember(Value = "predictive.routing")]
    Predictiverouting,

    /// <summary>
    /// Enum Presence for "presence"
    /// </summary>
    [EnumMember(Value = "presence")]
    Presence,

    /// <summary>
    /// Enum Quality for "quality"
    /// </summary>
    [EnumMember(Value = "quality")]
    Quality,

    /// <summary>
    /// Enum Recording for "recording"
    /// </summary>
    [EnumMember(Value = "recording")]
    Recording,

    /// <summary>
    /// Enum Responsemanagement for "response.management"
    /// </summary>
    [EnumMember(Value = "response.management")]
    Responsemanagement,

    /// <summary>
    /// Enum Routing for "routing"
    /// </summary>
    [EnumMember(Value = "routing")]
    Routing,

    /// <summary>
    /// Enum Scim for "scim"
    /// </summary>
    [EnumMember(Value = "scim")]
    Scim,

    /// <summary>
    /// Enum Search for "search"
    /// </summary>
    [EnumMember(Value = "search")]
    Search,

    /// <summary>
    /// Enum Secondaryautomationtesting for "secondary.automation.testing"
    /// </summary>
    [EnumMember(Value = "secondary.automation.testing")]
    Secondaryautomationtesting,

    /// <summary>
    /// Enum Skills for "skills"
    /// </summary>
    [EnumMember(Value = "skills")]
    Skills,

    /// <summary>
    /// Enum Speechandtextanalytics for "speech.and.text.analytics"
    /// </summary>
    [EnumMember(Value = "speech.and.text.analytics")]
    Speechandtextanalytics,

    /// <summary>
    /// Enum Speechintegration for "speech.integration"
    /// </summary>
    [EnumMember(Value = "speech.integration")]
    Speechintegration,

    /// <summary>
    /// Enum Supportability for "supportability"
    /// </summary>
    [EnumMember(Value = "supportability")]
    Supportability,

    /// <summary>
    /// Enum Taskmanagement for "task.management"
    /// </summary>
    [EnumMember(Value = "task.management")]
    Taskmanagement,

    /// <summary>
    /// Enum Telephonyconfiguration for "telephony.configuration"
    /// </summary>
    [EnumMember(Value = "telephony.configuration")]
    Telephonyconfiguration,

    /// <summary>
    /// Enum Usage for "usage"
    /// </summary>
    [EnumMember(Value = "usage")]
    Usage,

    /// <summary>
    /// Enum Users for "users"
    /// </summary>
    [EnumMember(Value = "users")]
    Users,

    /// <summary>
    /// Enum Webdeployments for "web.deployments"
    /// </summary>
    [EnumMember(Value = "web.deployments")]
    Webdeployments,

    /// <summary>
    /// Enum Webmessaging for "web.messaging"
    /// </summary>
    [EnumMember(Value = "web.messaging")]
    Webmessaging,

    /// <summary>
    /// Enum Webchat for "webchat"
    /// </summary>
    [EnumMember(Value = "webchat")]
    Webchat,

    /// <summary>
    /// Enum Webhooks for "webhooks"
    /// </summary>
    [EnumMember(Value = "webhooks")]
    Webhooks,

    /// <summary>
    /// Enum Workforcemanagement for "workforce.management"
    /// </summary>
    [EnumMember(Value = "workforce.management")]
    Workforcemanagement
}
