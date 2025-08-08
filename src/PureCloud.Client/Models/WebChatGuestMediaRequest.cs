using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Object representing the guest model of a media request of a chat conversation.
/// </summary>
public sealed class WebChatGuestMediaRequest
{
    /// <summary>
    /// Gets or Sets Types
    /// </summary>
    
    public enum TypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Cobrowse for "COBROWSE"
        /// </summary>
        [EnumMember(Value = "COBROWSE")]
        Cobrowse,

        /// <summary>
        /// Enum Screenshare for "SCREENSHARE"
        /// </summary>
        [EnumMember(Value = "SCREENSHARE")]
        Screenshare
    }
    /// <summary>
    /// The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.
    /// </summary>
    /// <value>The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Accepted for "ACCEPTED"
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        Accepted,

        /// <summary>
        /// Enum Declined for "DECLINED"
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        Declined,

        /// <summary>
        /// Enum Timedout for "TIMEDOUT"
        /// </summary>
        [EnumMember(Value = "TIMEDOUT")]
        Timedout,

        /// <summary>
        /// Enum Cancelled for "CANCELLED"
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        /// Enum Errored for "ERRORED"
        /// </summary>
        [EnumMember(Value = "ERRORED")]
        Errored
    }
    /// <summary>
    /// The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.
    /// </summary>
    /// <value>The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatGuestMediaRequest" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Types">The types of media being requested. (required).</param>
    /// <param name="State">The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED. (required).</param>
    /// <param name="CommunicationId">The ID of the new media communication, if applicable..</param>
    /// <param name="SecurityKey">The security information related to a media request..</param>
    public WebChatGuestMediaRequest(string Name = null, List<TypesEnum> Types = null, StateEnum? State = null, string CommunicationId = null, string SecurityKey = null)
    {
        this.Name = Name;
        this.Types = Types;
        this.State = State;
        this.CommunicationId = CommunicationId;
        this.SecurityKey = SecurityKey;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The types of media being requested.
    /// </summary>
    /// <value>The types of media being requested.</value>
    [JsonPropertyName("types")]
    public List<TypesEnum> Types { get; set; }





    /// <summary>
    /// The ID of the new media communication, if applicable.
    /// </summary>
    /// <value>The ID of the new media communication, if applicable.</value>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// The security information related to a media request.
    /// </summary>
    /// <value>The security information related to a media request.</value>
    [JsonPropertyName("securityKey")]
    public string SecurityKey { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatGuestMediaRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Types: ").Append(Types).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  SecurityKey: ").Append(SecurityKey).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}
