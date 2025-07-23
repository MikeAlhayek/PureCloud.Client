using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OAuthAuthorization
{
    public OAuthClient Client { get; set; }
    public IEnumerable<string> Scope { get; set; }
    public IEnumerable<string> Roles { get; set; }
    public DomainEntityRef ResourceOwner { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DomainEntityRef CreatedBy { get; set; }
    public DomainEntityRef ModifiedBy { get; set; }
    public bool? Pending { get; set; }
    public StateEnum? State { get; set; }
    public string SelfUri { get; set; }
    public enum StateEnum { OutdatedSdkVersion, Unauthorized, Requested, Authorized, Revoked }

}
