using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FaxSendRequest
/// </summary>

public partial class FaxSendRequest : IEquatable<FaxSendRequest>
{
    /// <summary>
    /// The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored
    /// </summary>
    /// <value>The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Applicationpdf for "application/pdf"
        /// </summary>
        [EnumMember(Value = "application/pdf")]
        Applicationpdf,

        /// <summary>
        /// Enum Imagetiff for "image/tiff"
        /// </summary>
        [EnumMember(Value = "image/tiff")]
        Imagetiff,

        /// <summary>
        /// Enum Applicationmsword for "application/msword"
        /// </summary>
        [EnumMember(Value = "application/msword")]
        Applicationmsword,

        /// <summary>
        /// Enum Applicationvndoasisopendocumenttext for "application/vnd.oasis.opendocument.text"
        /// </summary>
        [EnumMember(Value = "application/vnd.oasis.opendocument.text")]
        Applicationvndoasisopendocumenttext,

        /// <summary>
        /// Enum Applicationvndopenxmlformatsofficedocumentwordprocessingmldocument for "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        /// </summary>
        [EnumMember(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        Applicationvndopenxmlformatsofficedocumentwordprocessingmldocument
    }
    /// <summary>
    /// The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored
    /// </summary>
    /// <value>The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FaxSendRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FaxSendRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxSendRequest" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Addresses">A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555 (required).</param>
    /// <param name="DocumentId">DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null.</param>
    /// <param name="ContentType">The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored.</param>
    /// <param name="Workspace">Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored.</param>
    /// <param name="CoverSheet">Data for coversheet generation..</param>
    /// <param name="TimeZoneOffsetMinutes">Time zone offset minutes from GMT.</param>
    public FaxSendRequest(string Name = null, List<string> Addresses = null, string DocumentId = null, ContentTypeEnum? ContentType = null, Workspace Workspace = null, CoverSheet CoverSheet = null, int? TimeZoneOffsetMinutes = null)
    {
        this.Name = Name;
        this.Addresses = Addresses;
        this.DocumentId = DocumentId;
        this.ContentType = ContentType;
        this.Workspace = Workspace;
        this.CoverSheet = CoverSheet;
        this.TimeZoneOffsetMinutes = TimeZoneOffsetMinutes;

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
    /// A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555
    /// </summary>
    /// <value>A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555</value>
    [JsonPropertyName("addresses")]
    public List<string> Addresses { get; set; }



    /// <summary>
    /// DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null
    /// </summary>
    /// <value>DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null</value>
    [JsonPropertyName("documentId")]
    public string DocumentId { get; set; }





    /// <summary>
    /// Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored
    /// </summary>
    /// <value>Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored</value>
    [JsonPropertyName("workspace")]
    public Workspace Workspace { get; set; }



    /// <summary>
    /// Data for coversheet generation.
    /// </summary>
    /// <value>Data for coversheet generation.</value>
    [JsonPropertyName("coverSheet")]
    public CoverSheet CoverSheet { get; set; }



    /// <summary>
    /// Time zone offset minutes from GMT
    /// </summary>
    /// <value>Time zone offset minutes from GMT</value>
    [JsonPropertyName("timeZoneOffsetMinutes")]
    public int? TimeZoneOffsetMinutes { get; set; }



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
        sb.Append("class FaxSendRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  CoverSheet: ").Append(CoverSheet).Append("\n");
        sb.Append("  TimeZoneOffsetMinutes: ").Append(TimeZoneOffsetMinutes).Append("\n");
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
        return Equals(obj as FaxSendRequest);
    }

    /// <summary>
    /// Returns true if FaxSendRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of FaxSendRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FaxSendRequest other)
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
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                DocumentId == other.DocumentId ||
                DocumentId != null &&
                DocumentId.Equals(other.DocumentId)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Workspace == other.Workspace ||
                Workspace != null &&
                Workspace.Equals(other.Workspace)
            ) &&
            (
                CoverSheet == other.CoverSheet ||
                CoverSheet != null &&
                CoverSheet.Equals(other.CoverSheet)
            ) &&
            (
                TimeZoneOffsetMinutes == other.TimeZoneOffsetMinutes ||
                TimeZoneOffsetMinutes != null &&
                TimeZoneOffsetMinutes.Equals(other.TimeZoneOffsetMinutes)
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

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (DocumentId != null)
            {
                hash = hash * 59 + DocumentId.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Workspace != null)
            {
                hash = hash * 59 + Workspace.GetHashCode();
            }

            if (CoverSheet != null)
            {
                hash = hash * 59 + CoverSheet.GetHashCode();
            }

            if (TimeZoneOffsetMinutes != null)
            {
                hash = hash * 59 + TimeZoneOffsetMinutes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
