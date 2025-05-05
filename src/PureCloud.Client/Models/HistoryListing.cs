using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoryListing
/// </summary>

public partial class HistoryListing : IEquatable<HistoryListing>
{
    /// <summary>
    /// Action name
    /// </summary>
    /// <value>Action name</value>
    
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
    /// Action status
    /// </summary>
    /// <value>Action status</value>
    
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
    /// Action name
    /// </summary>
    /// <value>Action name</value>
    [JsonPropertyName("actionName")]
    public ActionNameEnum? ActionName { get; set; }
    /// <summary>
    /// Action status
    /// </summary>
    /// <value>Action status</value>
    [JsonPropertyName("actionStatus")]
    public ActionStatusEnum? ActionStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoryListing" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Complete">Complete.</param>
    /// <param name="User">User.</param>
    /// <param name="Client">Client.</param>
    /// <param name="ErrorMessage">ErrorMessage.</param>
    /// <param name="ErrorCode">ErrorCode.</param>
    /// <param name="ErrorDetails">ErrorDetails.</param>
    /// <param name="ErrorMessageParams">ErrorMessageParams.</param>
    /// <param name="ActionName">Action name.</param>
    /// <param name="ActionStatus">Action status.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="System">System.</param>
    /// <param name="Started">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Completed">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="PageNumber">PageNumber.</param>
    /// <param name="Total">Total.</param>
    /// <param name="Entities">Entities.</param>
    /// <param name="PageCount">PageCount.</param>
    public HistoryListing(string Id = null, bool? Complete = null, User User = null, DomainEntityRef Client = null, string ErrorMessage = null, string ErrorCode = null, List<Detail> ErrorDetails = null, Dictionary<string, string> ErrorMessageParams = null, ActionNameEnum? ActionName = null, ActionStatusEnum? ActionStatus = null, string Name = null, string Description = null, bool? System = null, DateTime? Started = null, DateTime? Completed = null, int? PageSize = null, int? PageNumber = null, long? Total = null, List<HistoryEntry> Entities = null, int? PageCount = null)
    {
        this.Id = Id;
        this.Complete = Complete;
        this.User = User;
        this.Client = Client;
        this.ErrorMessage = ErrorMessage;
        this.ErrorCode = ErrorCode;
        this.ErrorDetails = ErrorDetails;
        this.ErrorMessageParams = ErrorMessageParams;
        this.ActionName = ActionName;
        this.ActionStatus = ActionStatus;
        this.Name = Name;
        this.Description = Description;
        this.System = System;
        this.Started = Started;
        this.Completed = Completed;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Total = Total;
        this.Entities = Entities;
        this.PageCount = PageCount;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Complete
    /// </summary>
    [JsonPropertyName("complete")]
    public bool? Complete { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    [JsonPropertyName("client")]
    public DomainEntityRef Client { get; set; }



    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }



    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets ErrorDetails
    /// </summary>
    [JsonPropertyName("errorDetails")]
    public List<Detail> ErrorDetails { get; set; }



    /// <summary>
    /// Gets or Sets ErrorMessageParams
    /// </summary>
    [JsonPropertyName("errorMessageParams")]
    public Dictionary<string, string> ErrorMessageParams { get; set; }







    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [JsonPropertyName("system")]
    public bool? System { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("started")]
    public DateTime? Started { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("completed")]
    public DateTime? Completed { get; set; }



    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<HistoryEntry> Entities { get; set; }



    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoryListing {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Complete: ").Append(Complete).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
        sb.Append("  ErrorMessageParams: ").Append(ErrorMessageParams).Append("\n");
        sb.Append("  ActionName: ").Append(ActionName).Append("\n");
        sb.Append("  ActionStatus: ").Append(ActionStatus).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  System: ").Append(System).Append("\n");
        sb.Append("  Started: ").Append(Started).Append("\n");
        sb.Append("  Completed: ").Append(Completed).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
        return Equals(obj as HistoryListing);
    }

    /// <summary>
    /// Returns true if HistoryListing instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoryListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoryListing other)
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
                Complete == other.Complete ||
                Complete != null &&
                Complete.Equals(other.Complete)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                ErrorDetails == other.ErrorDetails ||
                ErrorDetails != null &&
                ErrorDetails.SequenceEqual(other.ErrorDetails)
            ) &&
            (
                ErrorMessageParams == other.ErrorMessageParams ||
                ErrorMessageParams != null &&
                ErrorMessageParams.SequenceEqual(other.ErrorMessageParams)
            ) &&
            (
                ActionName == other.ActionName ||
                ActionName != null &&
                ActionName.Equals(other.ActionName)
            ) &&
            (
                ActionStatus == other.ActionStatus ||
                ActionStatus != null &&
                ActionStatus.Equals(other.ActionStatus)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                System == other.System ||
                System != null &&
                System.Equals(other.System)
            ) &&
            (
                Started == other.Started ||
                Started != null &&
                Started.Equals(other.Started)
            ) &&
            (
                Completed == other.Completed ||
                Completed != null &&
                Completed.Equals(other.Completed)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                PageNumber == other.PageNumber ||
                PageNumber != null &&
                PageNumber.Equals(other.PageNumber)
            ) &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
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

            if (Complete != null)
            {
                hash = hash * 59 + Complete.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (ErrorDetails != null)
            {
                hash = hash * 59 + ErrorDetails.GetHashCode();
            }

            if (ErrorMessageParams != null)
            {
                hash = hash * 59 + ErrorMessageParams.GetHashCode();
            }

            if (ActionName != null)
            {
                hash = hash * 59 + ActionName.GetHashCode();
            }

            if (ActionStatus != null)
            {
                hash = hash * 59 + ActionStatus.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (System != null)
            {
                hash = hash * 59 + System.GetHashCode();
            }

            if (Started != null)
            {
                hash = hash * 59 + Started.GetHashCode();
            }

            if (Completed != null)
            {
                hash = hash * 59 + Completed.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            return hash;
        }
    }
}
