using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public partial class AuditTopicAuditLogMessage
{
    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>

    public enum ServiceNameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Languageunderstanding for "LanguageUnderstanding"
        /// </summary>
        [EnumMember(Value = "LanguageUnderstanding")]
        Languageunderstanding,

        /// <summary>
        /// Enum Contentmanagement for "ContentManagement"
        /// </summary>
        [EnumMember(Value = "ContentManagement")]
        Contentmanagement,

        /// <summary>
        /// Enum Peoplepermissions for "PeoplePermissions"
        /// </summary>
        [EnumMember(Value = "PeoplePermissions")]
        Peoplepermissions,

        /// <summary>
        /// Enum Presence for "Presence"
        /// </summary>
        [EnumMember(Value = "Presence")]
        Presence,

        /// <summary>
        /// Enum Architect for "Architect"
        /// </summary>
        [EnumMember(Value = "Architect")]
        Architect,

        /// <summary>
        /// Enum Contactcenter for "ContactCenter"
        /// </summary>
        [EnumMember(Value = "ContactCenter")]
        Contactcenter,

        /// <summary>
        /// Enum Quality for "Quality"
        /// </summary>
        [EnumMember(Value = "Quality")]
        Quality,

        /// <summary>
        /// Enum Speechandtextanalytics for "SpeechAndTextAnalytics"
        /// </summary>
        [EnumMember(Value = "SpeechAndTextAnalytics")]
        Speechandtextanalytics,

        /// <summary>
        /// Enum Predictiveengagement for "PredictiveEngagement"
        /// </summary>
        [EnumMember(Value = "PredictiveEngagement")]
        Predictiveengagement,

        /// <summary>
        /// Enum Knowledge for "Knowledge"
        /// </summary>
        [EnumMember(Value = "Knowledge")]
        Knowledge,

        /// <summary>
        /// Enum Coaching for "Coaching"
        /// </summary>
        [EnumMember(Value = "Coaching")]
        Coaching,

        /// <summary>
        /// Enum Learning for "Learning"
        /// </summary>
        [EnumMember(Value = "Learning")]
        Learning,

        /// <summary>
        /// Enum Gamification for "Gamification"
        /// </summary>
        [EnumMember(Value = "Gamification")]
        Gamification,

        /// <summary>
        /// Enum Employeeengagement for "EmployeeEngagement"
        /// </summary>
        [EnumMember(Value = "EmployeeEngagement")]
        Employeeengagement,

        /// <summary>
        /// Enum Workforcemanagement for "WorkforceManagement"
        /// </summary>
        [EnumMember(Value = "WorkforceManagement")]
        Workforcemanagement,

        /// <summary>
        /// Enum Triggers for "Triggers"
        /// </summary>
        [EnumMember(Value = "Triggers")]
        Triggers,

        /// <summary>
        /// Enum Processautomation for "ProcessAutomation"
        /// </summary>
        [EnumMember(Value = "ProcessAutomation")]
        Processautomation,

        /// <summary>
        /// Enum Responsemanagement for "ResponseManagement"
        /// </summary>
        [EnumMember(Value = "ResponseManagement")]
        Responsemanagement,

        /// <summary>
        /// Enum Groups for "Groups"
        /// </summary>
        [EnumMember(Value = "Groups")]
        Groups,

        /// <summary>
        /// Enum Telephony for "Telephony"
        /// </summary>
        [EnumMember(Value = "Telephony")]
        Telephony,

        /// <summary>
        /// Enum Outbound for "Outbound"
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound,

        /// <summary>
        /// Enum Routing for "Routing"
        /// </summary>
        [EnumMember(Value = "Routing")]
        Routing,

        /// <summary>
        /// Enum Integrations for "Integrations"
        /// </summary>
        [EnumMember(Value = "Integrations")]
        Integrations,

        /// <summary>
        /// Enum Webhooks for "Webhooks"
        /// </summary>
        [EnumMember(Value = "Webhooks")]
        Webhooks,

        /// <summary>
        /// Enum Analyticsreporting for "AnalyticsReporting"
        /// </summary>
        [EnumMember(Value = "AnalyticsReporting")]
        Analyticsreporting,

        /// <summary>
        /// Enum Limits for "Limits"
        /// </summary>
        [EnumMember(Value = "Limits")]
        Limits,

        /// <summary>
        /// Enum Employeeperformance for "EmployeePerformance"
        /// </summary>
        [EnumMember(Value = "EmployeePerformance")]
        Employeeperformance,

        /// <summary>
        /// Enum Datatables for "Datatables"
        /// </summary>
        [EnumMember(Value = "Datatables")]
        Datatables,

        /// <summary>
        /// Enum Messaging for "Messaging"
        /// </summary>
        [EnumMember(Value = "Messaging")]
        Messaging,

        /// <summary>
        /// Enum Webdeployments for "WebDeployments"
        /// </summary>
        [EnumMember(Value = "WebDeployments")]
        Webdeployments,

        /// <summary>
        /// Enum Supportability for "Supportability"
        /// </summary>
        [EnumMember(Value = "Supportability")]
        Supportability,

        /// <summary>
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Directory for "Directory"
        /// </summary>
        [EnumMember(Value = "Directory")]
        Directory,

        /// <summary>
        /// Enum Externalcontacts for "ExternalContacts"
        /// </summary>
        [EnumMember(Value = "ExternalContacts")]
        Externalcontacts,

        /// <summary>
        /// Enum Taskmanagement for "TaskManagement"
        /// </summary>
        [EnumMember(Value = "TaskManagement")]
        Taskmanagement,

        /// <summary>
        /// Enum Scim for "SCIM"
        /// </summary>
        [EnumMember(Value = "SCIM")]
        Scim,

        /// <summary>
        /// Enum Numberpurchasing for "NumberPurchasing"
        /// </summary>
        [EnumMember(Value = "NumberPurchasing")]
        Numberpurchasing,

        /// <summary>
        /// Enum Marketplace for "Marketplace"
        /// </summary>
        [EnumMember(Value = "Marketplace")]
        Marketplace,

        /// <summary>
        /// Enum Logcapture for "LogCapture"
        /// </summary>
        [EnumMember(Value = "LogCapture")]
        Logcapture,

        /// <summary>
        /// Enum Gdpr for "GDPR"
        /// </summary>
        [EnumMember(Value = "GDPR")]
        Gdpr,

        /// <summary>
        /// Enum Externalcontactsexport for "ExternalContactsExport"
        /// </summary>
        [EnumMember(Value = "ExternalContactsExport")]
        Externalcontactsexport,

        /// <summary>
        /// Enum Agentconfig for "AgentConfig"
        /// </summary>
        [EnumMember(Value = "AgentConfig")]
        Agentconfig,

        /// <summary>
        /// Enum Emails for "Emails"
        /// </summary>
        [EnumMember(Value = "Emails")]
        Emails,

        /// <summary>
        /// Enum Scripter for "Scripter"
        /// </summary>
        [EnumMember(Value = "Scripter")]
        Scripter,

        /// <summary>
        /// Enum Billing for "Billing"
        /// </summary>
        [EnumMember(Value = "Billing")]
        Billing,

        /// <summary>
        /// Enum Journeyanalytics for "JourneyAnalytics"
        /// </summary>
        [EnumMember(Value = "JourneyAnalytics")]
        Journeyanalytics,

        /// <summary>
        /// Enum Nerservice for "NerService"
        /// </summary>
        [EnumMember(Value = "NerService")]
        Nerservice,

        /// <summary>
        /// Enum Onboarding for "Onboarding"
        /// </summary>
        [EnumMember(Value = "Onboarding")]
        Onboarding,

        /// <summary>
        /// Enum Sociallistening for "SocialListening"
        /// </summary>
        [EnumMember(Value = "SocialListening")]
        Sociallistening,

        /// <summary>
        /// Enum Businessrules for "BusinessRules"
        /// </summary>
        [EnumMember(Value = "BusinessRules")]
        Businessrules,

        /// <summary>
        /// Enum Socialescalationrules for "SocialEscalationRules"
        /// </summary>
        [EnumMember(Value = "SocialEscalationRules")]
        Socialescalationrules
    }
}
