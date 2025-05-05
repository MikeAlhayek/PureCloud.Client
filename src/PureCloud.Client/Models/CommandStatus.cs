using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommandStatus
/// </summary>

public partial class CommandStatus : IEquatable<CommandStatus>
{
    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    
    public enum StatusCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inprogress for "INPROGRESS"
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        Inprogress,

        /// <summary>
        /// Enum Complete for "COMPLETE"
        /// </summary>
        [EnumMember(Value = "COMPLETE")]
        Complete,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error,

        /// <summary>
        /// Enum Canceling for "CANCELING"
        /// </summary>
        [EnumMember(Value = "CANCELING")]
        Canceling,

        /// <summary>
        /// Enum Canceled for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        Canceled
    }
    /// <summary>
    /// Gets or Sets CommandType
    /// </summary>
    
    public enum CommandTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Upload for "UPLOAD"
        /// </summary>
        [EnumMember(Value = "UPLOAD")]
        Upload,

        /// <summary>
        /// Enum Copydocument for "COPYDOCUMENT"
        /// </summary>
        [EnumMember(Value = "COPYDOCUMENT")]
        Copydocument,

        /// <summary>
        /// Enum Movedocument for "MOVEDOCUMENT"
        /// </summary>
        [EnumMember(Value = "MOVEDOCUMENT")]
        Movedocument,

        /// <summary>
        /// Enum Deleteworkspace for "DELETEWORKSPACE"
        /// </summary>
        [EnumMember(Value = "DELETEWORKSPACE")]
        Deleteworkspace,

        /// <summary>
        /// Enum Deletedocument for "DELETEDOCUMENT"
        /// </summary>
        [EnumMember(Value = "DELETEDOCUMENT")]
        Deletedocument,

        /// <summary>
        /// Enum Deletetag for "DELETETAG"
        /// </summary>
        [EnumMember(Value = "DELETETAG")]
        Deletetag,

        /// <summary>
        /// Enum Updatetag for "UPDATETAG"
        /// </summary>
        [EnumMember(Value = "UPDATETAG")]
        Updatetag,

        /// <summary>
        /// Enum Reindex for "REINDEX"
        /// </summary>
        [EnumMember(Value = "REINDEX")]
        Reindex,

        /// <summary>
        /// Enum Cleanup for "CLEANUP"
        /// </summary>
        [EnumMember(Value = "CLEANUP")]
        Cleanup,

        /// <summary>
        /// Enum Replacedocument for "REPLACEDOCUMENT"
        /// </summary>
        [EnumMember(Value = "REPLACEDOCUMENT")]
        Replacedocument
    }
    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [JsonPropertyName("statusCode")]
    public StatusCodeEnum? StatusCode { get; set; }
    /// <summary>
    /// Gets or Sets CommandType
    /// </summary>
    [JsonPropertyName("commandType")]
    public CommandTypeEnum? CommandType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommandStatus" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Expiration">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="StatusCode">StatusCode.</param>
    /// <param name="CommandType">CommandType.</param>
    /// <param name="Document">Document.</param>
    public CommandStatus(string Name = null, DateTime? Expiration = null, string UserId = null, StatusCodeEnum? StatusCode = null, CommandTypeEnum? CommandType = null, Document Document = null)
    {
        this.Name = Name;
        this.Expiration = Expiration;
        this.UserId = UserId;
        this.StatusCode = StatusCode;
        this.CommandType = CommandType;
        this.Document = Document;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("expiration")]
    public DateTime? Expiration { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }







    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    [JsonPropertyName("document")]
    public Document Document { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommandStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Expiration: ").Append(Expiration).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  CommandType: ").Append(CommandType).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as CommandStatus);
    }

    /// <summary>
    /// Returns true if CommandStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of CommandStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommandStatus other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Expiration == other.Expiration ||
                Expiration != null &&
                Expiration.Equals(other.Expiration)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                StatusCode == other.StatusCode ||
                StatusCode != null &&
                StatusCode.Equals(other.StatusCode)
            ) &&
            (
                CommandType == other.CommandType ||
                CommandType != null &&
                CommandType.Equals(other.CommandType)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Expiration != null)
            {
                hash = hash * 59 + Expiration.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (StatusCode != null)
            {
                hash = hash * 59 + StatusCode.GetHashCode();
            }

            if (CommandType != null)
            {
                hash = hash * 59 + CommandType.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
