using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeTraining
/// </summary>

public partial class KnowledgeTraining : IEquatable<KnowledgeTraining>
{
    /// <summary>
    /// Training status.
    /// </summary>
    /// <value>Training status.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.
    /// </summary>
    /// <value>State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.</value>
    
    public enum KnowledgeDocumentsStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Discarded for "Discarded"
        /// </summary>
        [EnumMember(Value = "Discarded")]
        Discarded,

        /// <summary>
        /// Enum Archived for "Archived"
        /// </summary>
        [EnumMember(Value = "Archived")]
        Archived
    }
    /// <summary>
    /// Training status.
    /// </summary>
    /// <value>Training status.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.
    /// </summary>
    /// <value>State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.</value>
    [JsonPropertyName("knowledgeDocumentsState")]
    public KnowledgeDocumentsStateEnum? KnowledgeDocumentsState { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeTraining" /> class.
    /// </summary>
    public KnowledgeTraining()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Trigger date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Trigger date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateTriggered")]
    public DateTime? DateTriggered { get; private set; }



    /// <summary>
    /// Training completed date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Training completed date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; private set; }





    /// <summary>
    /// Language of the documents that are trained.
    /// </summary>
    /// <value>Language of the documents that are trained.</value>
    [JsonPropertyName("languageCode")]
    public string LanguageCode { get; private set; }



    /// <summary>
    /// Knowledge Base that the training belongs to.
    /// </summary>
    /// <value>Knowledge Base that the training belongs to.</value>
    [JsonPropertyName("knowledgeBase")]
    public KnowledgeBase KnowledgeBase { get; private set; }



    /// <summary>
    /// Any error message during the Training or Promote action.
    /// </summary>
    /// <value>Any error message during the Training or Promote action.</value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; private set; }





    /// <summary>
    /// Trained Documents Promoted date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Trained Documents Promoted date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("datePromoted")]
    public DateTime? DatePromoted { get; private set; }



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
        sb.Append("class KnowledgeTraining {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateTriggered: ").Append(DateTriggered).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  KnowledgeDocumentsState: ").Append(KnowledgeDocumentsState).Append("\n");
        sb.Append("  DatePromoted: ").Append(DatePromoted).Append("\n");
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
        return Equals(obj as KnowledgeTraining);
    }

    /// <summary>
    /// Returns true if KnowledgeTraining instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeTraining to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeTraining other)
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
                DateTriggered == other.DateTriggered ||
                DateTriggered != null &&
                DateTriggered.Equals(other.DateTriggered)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                LanguageCode == other.LanguageCode ||
                LanguageCode != null &&
                LanguageCode.Equals(other.LanguageCode)
            ) &&
            (
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
            ) &&
            (
                KnowledgeDocumentsState == other.KnowledgeDocumentsState ||
                KnowledgeDocumentsState != null &&
                KnowledgeDocumentsState.Equals(other.KnowledgeDocumentsState)
            ) &&
            (
                DatePromoted == other.DatePromoted ||
                DatePromoted != null &&
                DatePromoted.Equals(other.DatePromoted)
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

            if (DateTriggered != null)
            {
                hash = hash * 59 + DateTriggered.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (LanguageCode != null)
            {
                hash = hash * 59 + LanguageCode.GetHashCode();
            }

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            if (KnowledgeDocumentsState != null)
            {
                hash = hash * 59 + KnowledgeDocumentsState.GetHashCode();
            }

            if (DatePromoted != null)
            {
                hash = hash * 59 + DatePromoted.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
