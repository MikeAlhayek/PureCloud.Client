namespace PureCloud.Client.Models;

public sealed class LimitChangeRequestDetails
{
    public string Id { get; set; }
    public string Key { get; set; }
    public NamespaceEnum? Namespace { get; set; }
    public double? RequestedValue { get; set; }
    public string Description { get; set; }
    public string SupportCaseUrl { get; set; }
    public StatusEnum? Status { get; set; }
    public double? CurrentValue { get; set; }
    public DateTime? DateCreated { get; set; }
    public IEnumerable<StatusChange> StatusHistory { get; set; }
    public DateTime? DateCompleted { get; set; }
    public RejectReasonEnum? RejectReason { get; set; }
    public IEnumerable<ApprovalNamespace> ApprovalNamespaces { get; set; }
    public string SelfUri { get; set; }
    public enum NamespaceEnum { OutdatedSdkVersion, Agentassistant, Analyticsagents, Analyticsalerting, Analytics, Analyticsrealtime, Analyticsreportingsettings, Architect, Audiohook, Audit, Authapi, Authorization, Automationtesting, Bots, Botsvoice, Businessrules, Callback, Cobrowse, Contentmanagement, Conversation, Dataactions, Datatables, Directory, Dsar, Email, Employeeengagement, Eventorchestration, Externalcontacts, Externaleventsdataingestion, Gamification, Gcv, Gdpr, Groups, Historicaladherence, Infrastructureascode, Integrations, Intentminer, Internalmessaging, Journey, Knowledge, Languageunderstanding, Learning, Limitregistry, Marketplace, Mediacommunications, Messaging, Microfrontend, Notifications, Onboarding, Outbound, Platformapi, Predictiverouting, Presence, Quality, Recording, Responsemanagement, Routing, Scim, Search, Secondaryautomationtesting, Skills, Socialmedia, Speechandtextanalytics, Speechintegration, Supportability, Taskmanagement, Telephonyconfiguration, Usage, Users, Webdeployments, Webmessaging, Webchat, Webhooks, Workforcemanagementforecast, Workforcemanagement, System }
    public enum StatusEnum { OutdatedSdkVersion, Approved, Rejected, Rollback, Pending, Open, Secondaryapprovalnamespacesadded, Reviewerapproved, Reviewerrejected, Reviewerrollback, Implementingchange, Changeimplemented, Implementingrollback, Rollbackimplemented }
    public enum RejectReasonEnum { OutdatedSdkVersion, Alternativeexists, Increasenotrequired, Platformmisuse, Platformstability, Otherreason }
}
