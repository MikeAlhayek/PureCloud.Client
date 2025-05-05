using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecognitionBase
/// </summary>

public partial class RecognitionBase : IEquatable<RecognitionBase>
{
    /// <summary>
    /// The type of recognition
    /// </summary>
    /// <value>The type of recognition</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Thankyou for "ThankYou"
        /// </summary>
        [EnumMember(Value = "ThankYou")]
        Thankyou,

        /// <summary>
        /// Enum Congratulations for "Congratulations"
        /// </summary>
        [EnumMember(Value = "Congratulations")]
        Congratulations,

        /// <summary>
        /// Enum Highperformance for "HighPerformance"
        /// </summary>
        [EnumMember(Value = "HighPerformance")]
        Highperformance,

        /// <summary>
        /// Enum Companyvalues for "CompanyValues"
        /// </summary>
        [EnumMember(Value = "CompanyValues")]
        Companyvalues
    }
    /// <summary>
    /// The context type (optional)
    /// </summary>
    /// <value>The context type (optional)</value>
    
    public enum ContextTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Interaction for "Interaction"
        /// </summary>
        [EnumMember(Value = "Interaction")]
        Interaction,

        /// <summary>
        /// Enum Insights for "Insights"
        /// </summary>
        [EnumMember(Value = "Insights")]
        Insights,

        /// <summary>
        /// Enum Development for "Development"
        /// </summary>
        [EnumMember(Value = "Development")]
        Development,

        /// <summary>
        /// Enum Scorecard for "Scorecard"
        /// </summary>
        [EnumMember(Value = "Scorecard")]
        Scorecard
    }
    /// <summary>
    /// The type of recognition
    /// </summary>
    /// <value>The type of recognition</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The context type (optional)
    /// </summary>
    /// <value>The context type (optional)</value>
    [JsonPropertyName("contextType")]
    public ContextTypeEnum? ContextType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecognitionBase" /> class.
    /// </summary>
    /// <param name="Recipient">The recipient of the recognition.</param>
    /// <param name="CreatedBy">The creator of the recognition.</param>
    /// <param name="DateCreated">The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Type">The type of recognition.</param>
    /// <param name="Title">The recognition title.</param>
    /// <param name="Note">The recognition note.</param>
    /// <param name="ContextType">The context type (optional).</param>
    /// <param name="ContextId">The context id (optional).</param>
    public RecognitionBase(UserReference Recipient = null, UserReference CreatedBy = null, DateTime? DateCreated = null, TypeEnum? Type = null, string Title = null, string Note = null, ContextTypeEnum? ContextType = null, string ContextId = null)
    {
        this.Recipient = Recipient;
        this.CreatedBy = CreatedBy;
        this.DateCreated = DateCreated;
        this.Type = Type;
        this.Title = Title;
        this.Note = Note;
        this.ContextType = ContextType;
        this.ContextId = ContextId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The recipient of the recognition
    /// </summary>
    /// <value>The recipient of the recognition</value>
    [JsonPropertyName("recipient")]
    public UserReference Recipient { get; set; }



    /// <summary>
    /// The creator of the recognition
    /// </summary>
    /// <value>The creator of the recognition</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }





    /// <summary>
    /// The recognition title
    /// </summary>
    /// <value>The recognition title</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The recognition note
    /// </summary>
    /// <value>The recognition note</value>
    [JsonPropertyName("note")]
    public string Note { get; set; }





    /// <summary>
    /// The context id (optional)
    /// </summary>
    /// <value>The context id (optional)</value>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }



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
        sb.Append("class RecognitionBase {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Recipient: ").Append(Recipient).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  ContextType: ").Append(ContextType).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
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
        return Equals(obj as RecognitionBase);
    }

    /// <summary>
    /// Returns true if RecognitionBase instances are equal
    /// </summary>
    /// <param name="other">Instance of RecognitionBase to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecognitionBase other)
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
                Recipient == other.Recipient ||
                Recipient != null &&
                Recipient.Equals(other.Recipient)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Note == other.Note ||
                Note != null &&
                Note.Equals(other.Note)
            ) &&
            (
                ContextType == other.ContextType ||
                ContextType != null &&
                ContextType.Equals(other.ContextType)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
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

            if (Recipient != null)
            {
                hash = hash * 59 + Recipient.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Note != null)
            {
                hash = hash * 59 + Note.GetHashCode();
            }

            if (ContextType != null)
            {
                hash = hash * 59 + ContextType.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
