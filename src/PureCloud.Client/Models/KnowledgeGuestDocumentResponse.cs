using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestDocumentResponse
/// </summary>

public partial class KnowledgeGuestDocumentResponse : IEquatable<KnowledgeGuestDocumentResponse>
{
    /// <summary>
    /// State of the document.
    /// </summary>
    /// <value>State of the document.</value>
    
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
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestDocumentResponse" /> class.
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
    public KnowledgeGuestDocumentResponse(string Title = null, bool? Visible = null, List<KnowledgeDocumentAlternative> Alternatives = null, StateEnum? State = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateImported = null, int? LastPublishedVersionNumber = null, DateTime? DatePublished = null, AddressableEntityRef DocumentVersion = null, List<KnowledgeGuestDocumentVariation> Variations = null)
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

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Document title, having a limit of 500 words.
    /// </summary>
    /// <value>Document title, having a limit of 500 words.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Indicates if the knowledge document should be included in search results.
    /// </summary>
    /// <value>Indicates if the knowledge document should be included in search results.</value>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }



    /// <summary>
    /// List of alternate phrases related to the title which improves search results.
    /// </summary>
    /// <value>List of alternate phrases related to the title which improves search results.</value>
    [JsonPropertyName("alternatives")]
    public List<KnowledgeDocumentAlternative> Alternatives { get; set; }





    /// <summary>
    /// Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateImported")]
    public DateTime? DateImported { get; set; }



    /// <summary>
    /// The last published version number of the document.
    /// </summary>
    /// <value>The last published version number of the document.</value>
    [JsonPropertyName("lastPublishedVersionNumber")]
    public int? LastPublishedVersionNumber { get; set; }



    /// <summary>
    /// The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("datePublished")]
    public DateTime? DatePublished { get; set; }



    /// <summary>
    /// The user who created the document.
    /// </summary>
    /// <value>The user who created the document.</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// The user who modified the document.
    /// </summary>
    /// <value>The user who modified the document.</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; private set; }



    /// <summary>
    /// The version of the document.
    /// </summary>
    /// <value>The version of the document.</value>
    [JsonPropertyName("documentVersion")]
    public AddressableEntityRef DocumentVersion { get; set; }



    /// <summary>
    /// ID of the guest session.
    /// </summary>
    /// <value>ID of the guest session.</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; private set; }



    /// <summary>
    /// The reference to category associated with the document.
    /// </summary>
    /// <value>The reference to category associated with the document.</value>
    [JsonPropertyName("category")]
    public GuestCategoryReference Category { get; private set; }



    /// <summary>
    /// Variations of the document.
    /// </summary>
    /// <value>Variations of the document.</value>
    [JsonPropertyName("variations")]
    public List<KnowledgeGuestDocumentVariation> Variations { get; set; }



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
        sb.Append("class KnowledgeGuestDocumentResponse {\n");

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
        return Equals(obj as KnowledgeGuestDocumentResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestDocumentResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestDocumentResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestDocumentResponse other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Visible == other.Visible ||
                Visible != null &&
                Visible.Equals(other.Visible)
            ) &&
            (
                Alternatives == other.Alternatives ||
                Alternatives != null &&
                Alternatives.SequenceEqual(other.Alternatives)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateImported == other.DateImported ||
                DateImported != null &&
                DateImported.Equals(other.DateImported)
            ) &&
            (
                LastPublishedVersionNumber == other.LastPublishedVersionNumber ||
                LastPublishedVersionNumber != null &&
                LastPublishedVersionNumber.Equals(other.LastPublishedVersionNumber)
            ) &&
            (
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DocumentVersion == other.DocumentVersion ||
                DocumentVersion != null &&
                DocumentVersion.Equals(other.DocumentVersion)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Variations == other.Variations ||
                Variations != null &&
                Variations.SequenceEqual(other.Variations)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Visible != null)
            {
                hash = hash * 59 + Visible.GetHashCode();
            }

            if (Alternatives != null)
            {
                hash = hash * 59 + Alternatives.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateImported != null)
            {
                hash = hash * 59 + DateImported.GetHashCode();
            }

            if (LastPublishedVersionNumber != null)
            {
                hash = hash * 59 + LastPublishedVersionNumber.GetHashCode();
            }

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DocumentVersion != null)
            {
                hash = hash * 59 + DocumentVersion.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Variations != null)
            {
                hash = hash * 59 + Variations.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
