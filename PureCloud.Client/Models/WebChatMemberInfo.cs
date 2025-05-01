using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatMemberInfo
/// </summary>
[DataContract]
public partial class WebChatMemberInfo : IEquatable<WebChatMemberInfo>
{
    /// <summary>
    /// The role of the member, one of [agent, customer, acd, workflow]
    /// </summary>
    /// <value>The role of the member, one of [agent, customer, acd, workflow]</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoleEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agent for "AGENT"
        /// </summary>
        [EnumMember(Value = "AGENT")]
        Agent,

        /// <summary>
        /// Enum Customer for "CUSTOMER"
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        Customer,

        /// <summary>
        /// Enum Workflow for "WORKFLOW"
        /// </summary>
        [EnumMember(Value = "WORKFLOW")]
        Workflow,

        /// <summary>
        /// Enum Acd for "ACD"
        /// </summary>
        [EnumMember(Value = "ACD")]
        Acd
    }
    /// <summary>
    /// The connection state of this member.
    /// </summary>
    /// <value>The connection state of this member.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Connected for "CONNECTED"
        /// </summary>
        [EnumMember(Value = "CONNECTED")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "DISCONNECTED"
        /// </summary>
        [EnumMember(Value = "DISCONNECTED")]
        Disconnected,

        /// <summary>
        /// Enum Alerting for "ALERTING"
        /// </summary>
        [EnumMember(Value = "ALERTING")]
        Alerting
    }
    /// <summary>
    /// The role of the member, one of [agent, customer, acd, workflow]
    /// </summary>
    /// <value>The role of the member, one of [agent, customer, acd, workflow]</value>
    [DataMember(Name = "role", EmitDefaultValue = false)]
    public RoleEnum? Role { get; set; }
    /// <summary>
    /// The connection state of this member.
    /// </summary>
    /// <value>The connection state of this member.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatMemberInfo" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebChatMemberInfo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatMemberInfo" /> class.
    /// </summary>
    /// <param name="Id">The communicationId of this member..</param>
    /// <param name="DisplayName">The display name of the member..</param>
    /// <param name="FirstName">The first name of the member..</param>
    /// <param name="LastName">The last name of the member..</param>
    /// <param name="Email">The email address of the member..</param>
    /// <param name="PhoneNumber">The phone number of the member..</param>
    /// <param name="AvatarImageUrl">The url to the avatar image of the member..</param>
    /// <param name="Role">The role of the member, one of [agent, customer, acd, workflow] (required).</param>
    /// <param name="JoinDate">The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LeaveDate">The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AuthenticatedGuest">If true, the guest member is an authenticated guest..</param>
    /// <param name="CustomFields">Any custom fields of information pertaining to this member..</param>
    /// <param name="State">The connection state of this member..</param>
    public WebChatMemberInfo(string Id = null, string DisplayName = null, string FirstName = null, string LastName = null, string Email = null, string PhoneNumber = null, string AvatarImageUrl = null, RoleEnum? Role = null, DateTime? JoinDate = null, DateTime? LeaveDate = null, bool? AuthenticatedGuest = null, Dictionary<string, string> CustomFields = null, StateEnum? State = null)
    {
        this.Id = Id;
        this.DisplayName = DisplayName;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.AvatarImageUrl = AvatarImageUrl;
        this.Role = Role;
        this.JoinDate = JoinDate;
        this.LeaveDate = LeaveDate;
        this.AuthenticatedGuest = AuthenticatedGuest;
        this.CustomFields = CustomFields;
        this.State = State;

    }



    /// <summary>
    /// The communicationId of this member.
    /// </summary>
    /// <value>The communicationId of this member.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The display name of the member.
    /// </summary>
    /// <value>The display name of the member.</value>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }



    /// <summary>
    /// The first name of the member.
    /// </summary>
    /// <value>The first name of the member.</value>
    [DataMember(Name = "firstName", EmitDefaultValue = false)]
    public string FirstName { get; set; }



    /// <summary>
    /// The last name of the member.
    /// </summary>
    /// <value>The last name of the member.</value>
    [DataMember(Name = "lastName", EmitDefaultValue = false)]
    public string LastName { get; set; }



    /// <summary>
    /// The email address of the member.
    /// </summary>
    /// <value>The email address of the member.</value>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public string Email { get; set; }



    /// <summary>
    /// The phone number of the member.
    /// </summary>
    /// <value>The phone number of the member.</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The url to the avatar image of the member.
    /// </summary>
    /// <value>The url to the avatar image of the member.</value>
    [DataMember(Name = "avatarImageUrl", EmitDefaultValue = false)]
    public string AvatarImageUrl { get; set; }





    /// <summary>
    /// The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "joinDate", EmitDefaultValue = false)]
    public DateTime? JoinDate { get; set; }



    /// <summary>
    /// The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "leaveDate", EmitDefaultValue = false)]
    public DateTime? LeaveDate { get; set; }



    /// <summary>
    /// If true, the guest member is an authenticated guest.
    /// </summary>
    /// <value>If true, the guest member is an authenticated guest.</value>
    [DataMember(Name = "authenticatedGuest", EmitDefaultValue = false)]
    public bool? AuthenticatedGuest { get; set; }



    /// <summary>
    /// Any custom fields of information pertaining to this member.
    /// </summary>
    /// <value>Any custom fields of information pertaining to this member.</value>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public Dictionary<string, string> CustomFields { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatMemberInfo {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
        sb.Append("  LeaveDate: ").Append(LeaveDate).Append("\n");
        sb.Append("  AuthenticatedGuest: ").Append(AuthenticatedGuest).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as WebChatMemberInfo);
    }

    /// <summary>
    /// Returns true if WebChatMemberInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatMemberInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatMemberInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                FirstName == other.FirstName ||
                FirstName != null &&
                FirstName.Equals(other.FirstName)
            ) &&
            (
                LastName == other.LastName ||
                LastName != null &&
                LastName.Equals(other.LastName)
            ) &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                AvatarImageUrl == other.AvatarImageUrl ||
                AvatarImageUrl != null &&
                AvatarImageUrl.Equals(other.AvatarImageUrl)
            ) &&
            (
                Role == other.Role ||
                Role != null &&
                Role.Equals(other.Role)
            ) &&
            (
                JoinDate == other.JoinDate ||
                JoinDate != null &&
                JoinDate.Equals(other.JoinDate)
            ) &&
            (
                LeaveDate == other.LeaveDate ||
                LeaveDate != null &&
                LeaveDate.Equals(other.LeaveDate)
            ) &&
            (
                AuthenticatedGuest == other.AuthenticatedGuest ||
                AuthenticatedGuest != null &&
                AuthenticatedGuest.Equals(other.AuthenticatedGuest)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (FirstName != null)
            {
                hash = hash * 59 + FirstName.GetHashCode();
            }

            if (LastName != null)
            {
                hash = hash * 59 + LastName.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (AvatarImageUrl != null)
            {
                hash = hash * 59 + AvatarImageUrl.GetHashCode();
            }

            if (Role != null)
            {
                hash = hash * 59 + Role.GetHashCode();
            }

            if (JoinDate != null)
            {
                hash = hash * 59 + JoinDate.GetHashCode();
            }

            if (LeaveDate != null)
            {
                hash = hash * 59 + LeaveDate.GetHashCode();
            }

            if (AuthenticatedGuest != null)
            {
                hash = hash * 59 + AuthenticatedGuest.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
