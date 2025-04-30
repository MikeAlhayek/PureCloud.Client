using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Describes an operation being performed on an Architect object
/// </summary>
[DataContract]
public partial class ArchitectFlowNotificationArchitectOperation : IEquatable<ArchitectFlowNotificationArchitectOperation>
{
    /// <summary>
    /// The action being performed
    /// </summary>
    /// <value>The action being performed</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionNameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Create for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        Create,

        /// <summary>
        /// Enum Checkin for "CHECKIN"
        /// </summary>
        [EnumMember(Value = "CHECKIN")]
        Checkin,

        /// <summary>
        /// Enum Checkout for "CHECKOUT"
        /// </summary>
        [EnumMember(Value = "CHECKOUT")]
        Checkout,

        /// <summary>
        /// Enum Deactivate for "DEACTIVATE"
        /// </summary>
        [EnumMember(Value = "DEACTIVATE")]
        Deactivate,

        /// <summary>
        /// Enum Debug for "DEBUG"
        /// </summary>
        [EnumMember(Value = "DEBUG")]
        Debug,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete,

        /// <summary>
        /// Enum History for "HISTORY"
        /// </summary>
        [EnumMember(Value = "HISTORY")]
        History,

        /// <summary>
        /// Enum Publish for "PUBLISH"
        /// </summary>
        [EnumMember(Value = "PUBLISH")]
        Publish,

        /// <summary>
        /// Enum Revert for "REVERT"
        /// </summary>
        [EnumMember(Value = "REVERT")]
        Revert,

        /// <summary>
        /// Enum Save for "SAVE"
        /// </summary>
        [EnumMember(Value = "SAVE")]
        Save,

        /// <summary>
        /// Enum StateChange for "STATE_CHANGE"
        /// </summary>
        [EnumMember(Value = "STATE_CHANGE")]
        StateChange,

        /// <summary>
        /// Enum Update for "UPDATE"
        /// </summary>
        [EnumMember(Value = "UPDATE")]
        Update,

        /// <summary>
        /// Enum Validate for "VALIDATE"
        /// </summary>
        [EnumMember(Value = "VALIDATE")]
        Validate
    }
    /// <summary>
    /// The action status
    /// </summary>
    /// <value>The action status</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Locked for "LOCKED"
        /// </summary>
        [EnumMember(Value = "LOCKED")]
        Locked,

        /// <summary>
        /// Enum Unlocked for "UNLOCKED"
        /// </summary>
        [EnumMember(Value = "UNLOCKED")]
        Unlocked,

        /// <summary>
        /// Enum Started for "STARTED"
        /// </summary>
        [EnumMember(Value = "STARTED")]
        Started,

        /// <summary>
        /// Enum PendingGeneration for "PENDING_GENERATION"
        /// </summary>
        [EnumMember(Value = "PENDING_GENERATION")]
        PendingGeneration,

        /// <summary>
        /// Enum PendingBackendNotification for "PENDING_BACKEND_NOTIFICATION"
        /// </summary>
        [EnumMember(Value = "PENDING_BACKEND_NOTIFICATION")]
        PendingBackendNotification,

        /// <summary>
        /// Enum Success for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// Enum Failure for "FAILURE"
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure
    }
    /// <summary>
    /// The action being performed
    /// </summary>
    /// <value>The action being performed</value>
    [DataMember(Name = "actionName", EmitDefaultValue = false)]
    public ActionNameEnum? ActionName { get; set; }
    /// <summary>
    /// The action status
    /// </summary>
    /// <value>The action status</value>
    [DataMember(Name = "actionStatus", EmitDefaultValue = false)]
    public ActionStatusEnum? ActionStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectFlowNotificationArchitectOperation" /> class.
    /// </summary>
    /// <param name="Id">A unique identifier for this operation, as generated by the initiating client.</param>
    /// <param name="Complete">Indicates if the operation is complete.</param>
    /// <param name="User">User.</param>
    /// <param name="Client">Client.</param>
    /// <param name="ActionName">The action being performed.</param>
    /// <param name="ActionStatus">The action status.</param>
    /// <param name="ErrorMessage">The error message, if the action failed.</param>
    /// <param name="ErrorCode">The error code, if the action failed.</param>
    /// <param name="ErrorMessageParams">ErrorMessageParams.</param>
    /// <param name="ErrorDetails">The error details, if the action failed.</param>
    public ArchitectFlowNotificationArchitectOperation(string Id = null, bool? Complete = null, ArchitectFlowNotificationUser User = null, ArchitectFlowNotificationClient Client = null, ActionNameEnum? ActionName = null, ActionStatusEnum? ActionStatus = null, string ErrorMessage = null, string ErrorCode = null, ArchitectFlowNotificationErrorMessageParams ErrorMessageParams = null, List<ArchitectFlowNotificationErrorDetail> ErrorDetails = null)
    {
        this.Id = Id;
        this.Complete = Complete;
        this.User = User;
        this.Client = Client;
        this.ActionName = ActionName;
        this.ActionStatus = ActionStatus;
        this.ErrorMessage = ErrorMessage;
        this.ErrorCode = ErrorCode;
        this.ErrorMessageParams = ErrorMessageParams;
        this.ErrorDetails = ErrorDetails;

    }



    /// <summary>
    /// A unique identifier for this operation, as generated by the initiating client
    /// </summary>
    /// <value>A unique identifier for this operation, as generated by the initiating client</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Indicates if the operation is complete
    /// </summary>
    /// <value>Indicates if the operation is complete</value>
    [DataMember(Name = "complete", EmitDefaultValue = false)]
    public bool? Complete { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public ArchitectFlowNotificationUser User { get; set; }



    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    [DataMember(Name = "client", EmitDefaultValue = false)]
    public ArchitectFlowNotificationClient Client { get; set; }







    /// <summary>
    /// The error message, if the action failed
    /// </summary>
    /// <value>The error message, if the action failed</value>
    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }



    /// <summary>
    /// The error code, if the action failed
    /// </summary>
    /// <value>The error code, if the action failed</value>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets ErrorMessageParams
    /// </summary>
    [DataMember(Name = "errorMessageParams", EmitDefaultValue = false)]
    public ArchitectFlowNotificationErrorMessageParams ErrorMessageParams { get; set; }



    /// <summary>
    /// The error details, if the action failed
    /// </summary>
    /// <value>The error details, if the action failed</value>
    [DataMember(Name = "errorDetails", EmitDefaultValue = false)]
    public List<ArchitectFlowNotificationErrorDetail> ErrorDetails { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectFlowNotificationArchitectOperation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Complete: ").Append(Complete).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  ActionName: ").Append(ActionName).Append("\n");
        sb.Append("  ActionStatus: ").Append(ActionStatus).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorMessageParams: ").Append(ErrorMessageParams).Append("\n");
        sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
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
        return this.Equals(obj as ArchitectFlowNotificationArchitectOperation);
    }

    /// <summary>
    /// Returns true if ArchitectFlowNotificationArchitectOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectFlowNotificationArchitectOperation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectFlowNotificationArchitectOperation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Complete == other.Complete ||
                this.Complete != null &&
                this.Complete.Equals(other.Complete)
            ) &&
            (
                this.User == other.User ||
                this.User != null &&
                this.User.Equals(other.User)
            ) &&
            (
                this.Client == other.Client ||
                this.Client != null &&
                this.Client.Equals(other.Client)
            ) &&
            (
                this.ActionName == other.ActionName ||
                this.ActionName != null &&
                this.ActionName.Equals(other.ActionName)
            ) &&
            (
                this.ActionStatus == other.ActionStatus ||
                this.ActionStatus != null &&
                this.ActionStatus.Equals(other.ActionStatus)
            ) &&
            (
                this.ErrorMessage == other.ErrorMessage ||
                this.ErrorMessage != null &&
                this.ErrorMessage.Equals(other.ErrorMessage)
            ) &&
            (
                this.ErrorCode == other.ErrorCode ||
                this.ErrorCode != null &&
                this.ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                this.ErrorMessageParams == other.ErrorMessageParams ||
                this.ErrorMessageParams != null &&
                this.ErrorMessageParams.Equals(other.ErrorMessageParams)
            ) &&
            (
                this.ErrorDetails == other.ErrorDetails ||
                this.ErrorDetails != null &&
                this.ErrorDetails.SequenceEqual(other.ErrorDetails)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Complete != null)
            {
                hash = hash * 59 + this.Complete.GetHashCode();
            }

            if (this.User != null)
            {
                hash = hash * 59 + this.User.GetHashCode();
            }

            if (this.Client != null)
            {
                hash = hash * 59 + this.Client.GetHashCode();
            }

            if (this.ActionName != null)
            {
                hash = hash * 59 + this.ActionName.GetHashCode();
            }

            if (this.ActionStatus != null)
            {
                hash = hash * 59 + this.ActionStatus.GetHashCode();
            }

            if (this.ErrorMessage != null)
            {
                hash = hash * 59 + this.ErrorMessage.GetHashCode();
            }

            if (this.ErrorCode != null)
            {
                hash = hash * 59 + this.ErrorCode.GetHashCode();
            }

            if (this.ErrorMessageParams != null)
            {
                hash = hash * 59 + this.ErrorMessageParams.GetHashCode();
            }

            if (this.ErrorDetails != null)
            {
                hash = hash * 59 + this.ErrorDetails.GetHashCode();
            }

            return hash;
        }
    }
}
