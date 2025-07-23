namespace PureCloud.Client.Models;

public sealed class InboundDomain
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string MxRecordStatus { get; set; }
    public bool? SubDomain { get; set; }
    public object MailFromSettings { get; set; }
    public object CustomSMTPServer { get; set; }
    public string SelfUri { get; set; }
}