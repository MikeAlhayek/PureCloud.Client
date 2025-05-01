using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableTopic
/// </summary>
[DataContract]
public partial class AvailableTopic : IEquatable<AvailableTopic>
{
    /// <summary>
    /// Visibility of this topic (Public or Preview)
    /// </summary>
    /// <value>Visibility of this topic (Public or Preview)</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VisibilityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Public for "Public"
        /// </summary>
        [EnumMember(Value = "Public")]
        Public,

        /// <summary>
        /// Enum Preview for "Preview"
        /// </summary>
        [EnumMember(Value = "Preview")]
        Preview
    }
    /// <summary>
    /// Gets or Sets Transports
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransportsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Websocket for "Websocket"
        /// </summary>
        [EnumMember(Value = "Websocket")]
        Websocket,

        /// <summary>
        /// Enum Eventbridge for "EventBridge"
        /// </summary>
        [EnumMember(Value = "EventBridge")]
        Eventbridge,

        /// <summary>
        /// Enum Processautomation for "ProcessAutomation"
        /// </summary>
        [EnumMember(Value = "ProcessAutomation")]
        Processautomation
    }
    /// <summary>
    /// Visibility of this topic (Public or Preview)
    /// </summary>
    /// <value>Visibility of this topic (Public or Preview)</value>
    [DataMember(Name = "visibility", EmitDefaultValue = false)]
    public VisibilityEnum? Visibility { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableTopic" /> class.
    /// </summary>
    /// <param name="Description">Description.</param>
    /// <param name="Id">Id.</param>
    /// <param name="PermissionDetails">Full detailed permissions required to subscribe to the topic.</param>
    /// <param name="RequiresPermissions">Permissions required to subscribe to the topic.</param>
    /// <param name="RequiresDivisionPermissions">True if the subscribing user must belong to the same division as the topic object ID.</param>
    /// <param name="RequiresAnyValidator">If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met..</param>
    /// <param name="Enforced">Whether or not the permissions on this topic are enforced.</param>
    /// <param name="Visibility">Visibility of this topic (Public or Preview).</param>
    /// <param name="Schema">Schema.</param>
    /// <param name="RequiresCurrentUser">True if the topic user ID is required to match the subscribing user ID.</param>
    /// <param name="RequiresCurrentUserOrPermission">True if permissions are only required when the topic user ID does not match the subscribing user ID.</param>
    /// <param name="Transports">Transports that support events for the topic.</param>
    /// <param name="PublicApiTemplateUriPaths">PublicApiTemplateUriPaths.</param>
    /// <param name="TopicParameters">Parameters in the topic name that can be substituted, in the order they appear in the topic name.</param>
    public AvailableTopic(string Description = null, string Id = null, List<PermissionDetails> PermissionDetails = null, List<string> RequiresPermissions = null, bool? RequiresDivisionPermissions = null, bool? RequiresAnyValidator = null, bool? Enforced = null, VisibilityEnum? Visibility = null, Dictionary<string, object> Schema = null, bool? RequiresCurrentUser = null, bool? RequiresCurrentUserOrPermission = null, List<TransportsEnum> Transports = null, List<string> PublicApiTemplateUriPaths = null, List<string> TopicParameters = null)
    {
        this.Description = Description;
        this.Id = Id;
        this.PermissionDetails = PermissionDetails;
        this.RequiresPermissions = RequiresPermissions;
        this.RequiresDivisionPermissions = RequiresDivisionPermissions;
        this.RequiresAnyValidator = RequiresAnyValidator;
        this.Enforced = Enforced;
        this.Visibility = Visibility;
        this.Schema = Schema;
        this.RequiresCurrentUser = RequiresCurrentUser;
        this.RequiresCurrentUserOrPermission = RequiresCurrentUserOrPermission;
        this.Transports = Transports;
        this.PublicApiTemplateUriPaths = PublicApiTemplateUriPaths;
        this.TopicParameters = TopicParameters;

    }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Full detailed permissions required to subscribe to the topic
    /// </summary>
    /// <value>Full detailed permissions required to subscribe to the topic</value>
    [DataMember(Name = "permissionDetails", EmitDefaultValue = false)]
    public List<PermissionDetails> PermissionDetails { get; set; }



    /// <summary>
    /// Permissions required to subscribe to the topic
    /// </summary>
    /// <value>Permissions required to subscribe to the topic</value>
    [DataMember(Name = "requiresPermissions", EmitDefaultValue = false)]
    public List<string> RequiresPermissions { get; set; }



    /// <summary>
    /// True if the subscribing user must belong to the same division as the topic object ID
    /// </summary>
    /// <value>True if the subscribing user must belong to the same division as the topic object ID</value>
    [DataMember(Name = "requiresDivisionPermissions", EmitDefaultValue = false)]
    public bool? RequiresDivisionPermissions { get; set; }



    /// <summary>
    /// If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met.
    /// </summary>
    /// <value>If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met.</value>
    [DataMember(Name = "requiresAnyValidator", EmitDefaultValue = false)]
    public bool? RequiresAnyValidator { get; set; }



    /// <summary>
    /// Whether or not the permissions on this topic are enforced
    /// </summary>
    /// <value>Whether or not the permissions on this topic are enforced</value>
    [DataMember(Name = "enforced", EmitDefaultValue = false)]
    public bool? Enforced { get; set; }





    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    [DataMember(Name = "schema", EmitDefaultValue = false)]
    public Dictionary<string, object> Schema { get; set; }



    /// <summary>
    /// True if the topic user ID is required to match the subscribing user ID
    /// </summary>
    /// <value>True if the topic user ID is required to match the subscribing user ID</value>
    [DataMember(Name = "requiresCurrentUser", EmitDefaultValue = false)]
    public bool? RequiresCurrentUser { get; set; }



    /// <summary>
    /// True if permissions are only required when the topic user ID does not match the subscribing user ID
    /// </summary>
    /// <value>True if permissions are only required when the topic user ID does not match the subscribing user ID</value>
    [DataMember(Name = "requiresCurrentUserOrPermission", EmitDefaultValue = false)]
    public bool? RequiresCurrentUserOrPermission { get; set; }



    /// <summary>
    /// Transports that support events for the topic
    /// </summary>
    /// <value>Transports that support events for the topic</value>
    [DataMember(Name = "transports", EmitDefaultValue = false)]
    public List<TransportsEnum> Transports { get; set; }



    /// <summary>
    /// Gets or Sets PublicApiTemplateUriPaths
    /// </summary>
    [DataMember(Name = "publicApiTemplateUriPaths", EmitDefaultValue = false)]
    public List<string> PublicApiTemplateUriPaths { get; set; }



    /// <summary>
    /// Parameters in the topic name that can be substituted, in the order they appear in the topic name
    /// </summary>
    /// <value>Parameters in the topic name that can be substituted, in the order they appear in the topic name</value>
    [DataMember(Name = "topicParameters", EmitDefaultValue = false)]
    public List<string> TopicParameters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableTopic {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PermissionDetails: ").Append(PermissionDetails).Append("\n");
        sb.Append("  RequiresPermissions: ").Append(RequiresPermissions).Append("\n");
        sb.Append("  RequiresDivisionPermissions: ").Append(RequiresDivisionPermissions).Append("\n");
        sb.Append("  RequiresAnyValidator: ").Append(RequiresAnyValidator).Append("\n");
        sb.Append("  Enforced: ").Append(Enforced).Append("\n");
        sb.Append("  Visibility: ").Append(Visibility).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  RequiresCurrentUser: ").Append(RequiresCurrentUser).Append("\n");
        sb.Append("  RequiresCurrentUserOrPermission: ").Append(RequiresCurrentUserOrPermission).Append("\n");
        sb.Append("  Transports: ").Append(Transports).Append("\n");
        sb.Append("  PublicApiTemplateUriPaths: ").Append(PublicApiTemplateUriPaths).Append("\n");
        sb.Append("  TopicParameters: ").Append(TopicParameters).Append("\n");
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
        return Equals(obj as AvailableTopic);
    }

    /// <summary>
    /// Returns true if AvailableTopic instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableTopic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableTopic other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                PermissionDetails == other.PermissionDetails ||
                PermissionDetails != null &&
                PermissionDetails.SequenceEqual(other.PermissionDetails)
            ) &&
            (
                RequiresPermissions == other.RequiresPermissions ||
                RequiresPermissions != null &&
                RequiresPermissions.SequenceEqual(other.RequiresPermissions)
            ) &&
            (
                RequiresDivisionPermissions == other.RequiresDivisionPermissions ||
                RequiresDivisionPermissions != null &&
                RequiresDivisionPermissions.Equals(other.RequiresDivisionPermissions)
            ) &&
            (
                RequiresAnyValidator == other.RequiresAnyValidator ||
                RequiresAnyValidator != null &&
                RequiresAnyValidator.Equals(other.RequiresAnyValidator)
            ) &&
            (
                Enforced == other.Enforced ||
                Enforced != null &&
                Enforced.Equals(other.Enforced)
            ) &&
            (
                Visibility == other.Visibility ||
                Visibility != null &&
                Visibility.Equals(other.Visibility)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.SequenceEqual(other.Schema)
            ) &&
            (
                RequiresCurrentUser == other.RequiresCurrentUser ||
                RequiresCurrentUser != null &&
                RequiresCurrentUser.Equals(other.RequiresCurrentUser)
            ) &&
            (
                RequiresCurrentUserOrPermission == other.RequiresCurrentUserOrPermission ||
                RequiresCurrentUserOrPermission != null &&
                RequiresCurrentUserOrPermission.Equals(other.RequiresCurrentUserOrPermission)
            ) &&
            (
                Transports == other.Transports ||
                Transports != null &&
                Transports.SequenceEqual(other.Transports)
            ) &&
            (
                PublicApiTemplateUriPaths == other.PublicApiTemplateUriPaths ||
                PublicApiTemplateUriPaths != null &&
                PublicApiTemplateUriPaths.SequenceEqual(other.PublicApiTemplateUriPaths)
            ) &&
            (
                TopicParameters == other.TopicParameters ||
                TopicParameters != null &&
                TopicParameters.SequenceEqual(other.TopicParameters)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (PermissionDetails != null)
            {
                hash = hash * 59 + PermissionDetails.GetHashCode();
            }

            if (RequiresPermissions != null)
            {
                hash = hash * 59 + RequiresPermissions.GetHashCode();
            }

            if (RequiresDivisionPermissions != null)
            {
                hash = hash * 59 + RequiresDivisionPermissions.GetHashCode();
            }

            if (RequiresAnyValidator != null)
            {
                hash = hash * 59 + RequiresAnyValidator.GetHashCode();
            }

            if (Enforced != null)
            {
                hash = hash * 59 + Enforced.GetHashCode();
            }

            if (Visibility != null)
            {
                hash = hash * 59 + Visibility.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (RequiresCurrentUser != null)
            {
                hash = hash * 59 + RequiresCurrentUser.GetHashCode();
            }

            if (RequiresCurrentUserOrPermission != null)
            {
                hash = hash * 59 + RequiresCurrentUserOrPermission.GetHashCode();
            }

            if (Transports != null)
            {
                hash = hash * 59 + Transports.GetHashCode();
            }

            if (PublicApiTemplateUriPaths != null)
            {
                hash = hash * 59 + PublicApiTemplateUriPaths.GetHashCode();
            }

            if (TopicParameters != null)
            {
                hash = hash * 59 + TopicParameters.GetHashCode();
            }

            return hash;
        }
    }
}
