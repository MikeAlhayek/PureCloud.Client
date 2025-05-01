using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyForm
/// </summary>
[DataContract]
public partial class SurveyForm : IEquatable<SurveyForm>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyForm" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SurveyForm() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyForm" /> class.
    /// </summary>
    /// <param name="Name">The survey form name (required).</param>
    /// <param name="Published">Is this form published.</param>
    /// <param name="Disabled">Is this form disabled.</param>
    /// <param name="Language">Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW (required).</param>
    /// <param name="Header">Markdown text for the top of the form..</param>
    /// <param name="Footer">Markdown text for the bottom of the form..</param>
    /// <param name="QuestionGroups">A list of question groups.</param>
    public SurveyForm(string Name = null, bool? Published = null, bool? Disabled = null, string Language = null, string Header = null, string Footer = null, List<SurveyQuestionGroup> QuestionGroups = null)
    {
        this.Name = Name;
        this.Published = Published;
        this.Disabled = Disabled;
        this.Language = Language;
        this.Header = Header;
        this.Footer = Footer;
        this.QuestionGroups = QuestionGroups;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The survey form name
    /// </summary>
    /// <value>The survey form name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; private set; }



    /// <summary>
    /// Is this form published
    /// </summary>
    /// <value>Is this form published</value>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; set; }



    /// <summary>
    /// Is this form disabled
    /// </summary>
    /// <value>Is this form disabled</value>
    [DataMember(Name = "disabled", EmitDefaultValue = false)]
    public bool? Disabled { get; set; }



    /// <summary>
    /// Unique Id for all versions of this form
    /// </summary>
    /// <value>Unique Id for all versions of this form</value>
    [DataMember(Name = "contextId", EmitDefaultValue = false)]
    public string ContextId { get; private set; }



    /// <summary>
    /// Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW
    /// </summary>
    /// <value>Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// Markdown text for the top of the form.
    /// </summary>
    /// <value>Markdown text for the top of the form.</value>
    [DataMember(Name = "header", EmitDefaultValue = false)]
    public string Header { get; set; }



    /// <summary>
    /// Markdown text for the bottom of the form.
    /// </summary>
    /// <value>Markdown text for the bottom of the form.</value>
    [DataMember(Name = "footer", EmitDefaultValue = false)]
    public string Footer { get; set; }



    /// <summary>
    /// A list of question groups
    /// </summary>
    /// <value>A list of question groups</value>
    [DataMember(Name = "questionGroups", EmitDefaultValue = false)]
    public List<SurveyQuestionGroup> QuestionGroups { get; set; }



    /// <summary>
    /// List of published version of this form
    /// </summary>
    /// <value>List of published version of this form</value>
    [DataMember(Name = "publishedVersions", EmitDefaultValue = false)]
    public DomainEntityListingSurveyForm PublishedVersions { get; private set; }



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
        sb.Append("class SurveyForm {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  Disabled: ").Append(Disabled).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Header: ").Append(Header).Append("\n");
        sb.Append("  Footer: ").Append(Footer).Append("\n");
        sb.Append("  QuestionGroups: ").Append(QuestionGroups).Append("\n");
        sb.Append("  PublishedVersions: ").Append(PublishedVersions).Append("\n");
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
        return Equals(obj as SurveyForm);
    }

    /// <summary>
    /// Returns true if SurveyForm instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyForm to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyForm other)
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
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                Disabled == other.Disabled ||
                Disabled != null &&
                Disabled.Equals(other.Disabled)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Header == other.Header ||
                Header != null &&
                Header.Equals(other.Header)
            ) &&
            (
                Footer == other.Footer ||
                Footer != null &&
                Footer.Equals(other.Footer)
            ) &&
            (
                QuestionGroups == other.QuestionGroups ||
                QuestionGroups != null &&
                QuestionGroups.SequenceEqual(other.QuestionGroups)
            ) &&
            (
                PublishedVersions == other.PublishedVersions ||
                PublishedVersions != null &&
                PublishedVersions.Equals(other.PublishedVersions)
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

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (Disabled != null)
            {
                hash = hash * 59 + Disabled.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Header != null)
            {
                hash = hash * 59 + Header.GetHashCode();
            }

            if (Footer != null)
            {
                hash = hash * 59 + Footer.GetHashCode();
            }

            if (QuestionGroups != null)
            {
                hash = hash * 59 + QuestionGroups.GetHashCode();
            }

            if (PublishedVersions != null)
            {
                hash = hash * 59 + PublishedVersions.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
