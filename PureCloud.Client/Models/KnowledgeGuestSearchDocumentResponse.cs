using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestSearchDocumentResponse
/// </summary>
[DataContract]
public partial class KnowledgeGuestSearchDocumentResponse : IEquatable<KnowledgeGuestSearchDocumentResponse>
{
    /// <summary>
    /// State of the document.
    /// </summary>
    /// <value>State of the document.</value>
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
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// Enum Published for "Published"
        /// </summary>
        [EnumMember(Value = "Published")]
        Published,

        /// <summary>
        /// Enum Archived for "Archived"
        /// </summary>
        [EnumMember(Value = "Archived")]
        Archived
    }
    /// <summary>
    /// State of the document.
    /// </summary>
    /// <value>State of the document.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSearchDocumentResponse" /> class.
    /// </summary>
    /// <param name="Title">Document title, having a limit of 500 words..</param>
    /// <param name="Visible">Indicates if the knowledge document should be included in search results..</param>
    /// <param name="Alternatives">List of alternate phrases related to the title which improves search results..</param>
    /// <param name="State">State of the document..</param>
    /// <param name="DateCreated">Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateImported">Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LastPublishedVersionNumber">The last published version number of the document..</param>
    /// <param name="DatePublished">The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DocumentVersion">The version of the document..</param>
    /// <param name="Variations">Variations of the document..</param>
    /// <param name="Answer">The answer to the query..</param>
    public KnowledgeGuestSearchDocumentResponse(string Title = null, bool? Visible = null, List<KnowledgeDocumentAlternative> Alternatives = null, StateEnum? State = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateImported = null, int? LastPublishedVersionNumber = null, DateTime? DatePublished = null, AddressableEntityRef DocumentVersion = null, List<KnowledgeGuestDocumentVariationAnswer> Variations = null, string Answer = null)
    {
        this.Title = Title;
        this.Visible = Visible;
        this.Alternatives = Alternatives;
        this.State = State;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DateImported = DateImported;
        this.LastPublishedVersionNumber = LastPublishedVersionNumber;
        this.DatePublished = DatePublished;
        this.DocumentVersion = DocumentVersion;
        this.Variations = Variations;
        this.Answer = Answer;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Document title, having a limit of 500 words.
    /// </summary>
    /// <value>Document title, having a limit of 500 words.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Indicates if the knowledge document should be included in search results.
    /// </summary>
    /// <value>Indicates if the knowledge document should be included in search results.</value>
    [DataMember(Name = "visible", EmitDefaultValue = false)]
    public bool? Visible { get; set; }



    /// <summary>
    /// List of alternate phrases related to the title which improves search results.
    /// </summary>
    /// <value>List of alternate phrases related to the title which improves search results.</value>
    [DataMember(Name = "alternatives", EmitDefaultValue = false)]
    public List<KnowledgeDocumentAlternative> Alternatives { get; set; }





    /// <summary>
    /// Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateImported", EmitDefaultValue = false)]
    public DateTime? DateImported { get; set; }



    /// <summary>
    /// The last published version number of the document.
    /// </summary>
    /// <value>The last published version number of the document.</value>
    [DataMember(Name = "lastPublishedVersionNumber", EmitDefaultValue = false)]
    public int? LastPublishedVersionNumber { get; set; }



    /// <summary>
    /// The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "datePublished", EmitDefaultValue = false)]
    public DateTime? DatePublished { get; set; }



    /// <summary>
    /// The user who created the document.
    /// </summary>
    /// <value>The user who created the document.</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// The user who modified the document.
    /// </summary>
    /// <value>The user who modified the document.</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; private set; }



    /// <summary>
    /// The version of the document.
    /// </summary>
    /// <value>The version of the document.</value>
    [DataMember(Name = "documentVersion", EmitDefaultValue = false)]
    public AddressableEntityRef DocumentVersion { get; set; }



    /// <summary>
    /// ID of the guest session.
    /// </summary>
    /// <value>ID of the guest session.</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; private set; }



    /// <summary>
    /// The reference to category associated with the document.
    /// </summary>
    /// <value>The reference to category associated with the document.</value>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    public GuestCategoryReference Category { get; private set; }



    /// <summary>
    /// Variations of the document.
    /// </summary>
    /// <value>Variations of the document.</value>
    [DataMember(Name = "variations", EmitDefaultValue = false)]
    public List<KnowledgeGuestDocumentVariationAnswer> Variations { get; set; }



    /// <summary>
    /// The answer to the query.
    /// </summary>
    /// <value>The answer to the query.</value>
    [DataMember(Name = "answer", EmitDefaultValue = false)]
    public string Answer { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeGuestSearchDocumentResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Visible: ").Append(Visible).Append("\n");
        sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateImported: ").Append(DateImported).Append("\n");
        sb.Append("  LastPublishedVersionNumber: ").Append(LastPublishedVersionNumber).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Variations: ").Append(Variations).Append("\n");
        sb.Append("  Answer: ").Append(Answer).Append("\n");
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
        return this.Equals(obj as KnowledgeGuestSearchDocumentResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestSearchDocumentResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestSearchDocumentResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestSearchDocumentResponse other)
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
                this.Title == other.Title ||
                this.Title != null &&
                this.Title.Equals(other.Title)
            ) &&
            (
                this.Visible == other.Visible ||
                this.Visible != null &&
                this.Visible.Equals(other.Visible)
            ) &&
            (
                this.Alternatives == other.Alternatives ||
                this.Alternatives != null &&
                this.Alternatives.SequenceEqual(other.Alternatives)
            ) &&
            (
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.DateImported == other.DateImported ||
                this.DateImported != null &&
                this.DateImported.Equals(other.DateImported)
            ) &&
            (
                this.LastPublishedVersionNumber == other.LastPublishedVersionNumber ||
                this.LastPublishedVersionNumber != null &&
                this.LastPublishedVersionNumber.Equals(other.LastPublishedVersionNumber)
            ) &&
            (
                this.DatePublished == other.DatePublished ||
                this.DatePublished != null &&
                this.DatePublished.Equals(other.DatePublished)
            ) &&
            (
                this.CreatedBy == other.CreatedBy ||
                this.CreatedBy != null &&
                this.CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                this.DocumentVersion == other.DocumentVersion ||
                this.DocumentVersion != null &&
                this.DocumentVersion.Equals(other.DocumentVersion)
            ) &&
            (
                this.SessionId == other.SessionId ||
                this.SessionId != null &&
                this.SessionId.Equals(other.SessionId)
            ) &&
            (
                this.Category == other.Category ||
                this.Category != null &&
                this.Category.Equals(other.Category)
            ) &&
            (
                this.Variations == other.Variations ||
                this.Variations != null &&
                this.Variations.SequenceEqual(other.Variations)
            ) &&
            (
                this.Answer == other.Answer ||
                this.Answer != null &&
                this.Answer.Equals(other.Answer)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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

            if (this.Title != null)
            {
                hash = hash * 59 + this.Title.GetHashCode();
            }

            if (this.Visible != null)
            {
                hash = hash * 59 + this.Visible.GetHashCode();
            }

            if (this.Alternatives != null)
            {
                hash = hash * 59 + this.Alternatives.GetHashCode();
            }

            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.DateImported != null)
            {
                hash = hash * 59 + this.DateImported.GetHashCode();
            }

            if (this.LastPublishedVersionNumber != null)
            {
                hash = hash * 59 + this.LastPublishedVersionNumber.GetHashCode();
            }

            if (this.DatePublished != null)
            {
                hash = hash * 59 + this.DatePublished.GetHashCode();
            }

            if (this.CreatedBy != null)
            {
                hash = hash * 59 + this.CreatedBy.GetHashCode();
            }

            if (this.ModifiedBy != null)
            {
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
            }

            if (this.DocumentVersion != null)
            {
                hash = hash * 59 + this.DocumentVersion.GetHashCode();
            }

            if (this.SessionId != null)
            {
                hash = hash * 59 + this.SessionId.GetHashCode();
            }

            if (this.Category != null)
            {
                hash = hash * 59 + this.Category.GetHashCode();
            }

            if (this.Variations != null)
            {
                hash = hash * 59 + this.Variations.GetHashCode();
            }

            if (this.Answer != null)
            {
                hash = hash * 59 + this.Answer.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
