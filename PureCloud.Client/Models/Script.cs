using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Script
/// </summary>
[DataContract]
public partial class Script : IEquatable<Script>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Script" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="VersionId">VersionId.</param>
    /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="PublishedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="VersionDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="StartPageId">StartPageId.</param>
    /// <param name="StartPageName">StartPageName.</param>
    /// <param name="Features">Features.</param>
    /// <param name="Variables">Variables.</param>
    /// <param name="CustomActions">CustomActions.</param>
    /// <param name="Pages">Pages.</param>
    public Script(string Name = null, Division Division = null, string VersionId = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, DateTime? PublishedDate = null, DateTime? VersionDate = null, string StartPageId = null, string StartPageName = null, object Features = null, object Variables = null, object CustomActions = null, List<Page> Pages = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.VersionId = VersionId;
        this.CreatedDate = CreatedDate;
        this.ModifiedDate = ModifiedDate;
        this.PublishedDate = PublishedDate;
        this.VersionDate = VersionDate;
        this.StartPageId = StartPageId;
        this.StartPageName = StartPageName;
        this.Features = Features;
        this.Variables = Variables;
        this.CustomActions = CustomActions;
        this.Pages = Pages;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; set; }



    /// <summary>
    /// Gets or Sets VersionId
    /// </summary>
    [DataMember(Name = "versionId", EmitDefaultValue = false)]
    public string VersionId { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "publishedDate", EmitDefaultValue = false)]
    public DateTime? PublishedDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "versionDate", EmitDefaultValue = false)]
    public DateTime? VersionDate { get; set; }



    /// <summary>
    /// Gets or Sets StartPageId
    /// </summary>
    [DataMember(Name = "startPageId", EmitDefaultValue = false)]
    public string StartPageId { get; set; }



    /// <summary>
    /// Gets or Sets StartPageName
    /// </summary>
    [DataMember(Name = "startPageName", EmitDefaultValue = false)]
    public string StartPageName { get; set; }



    /// <summary>
    /// Gets or Sets Features
    /// </summary>
    [DataMember(Name = "features", EmitDefaultValue = false)]
    public object Features { get; set; }



    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [DataMember(Name = "variables", EmitDefaultValue = false)]
    public object Variables { get; set; }



    /// <summary>
    /// Gets or Sets CustomActions
    /// </summary>
    [DataMember(Name = "customActions", EmitDefaultValue = false)]
    public object CustomActions { get; set; }



    /// <summary>
    /// Gets or Sets Pages
    /// </summary>
    [DataMember(Name = "pages", EmitDefaultValue = false)]
    public List<Page> Pages { get; set; }



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
        sb.Append("class Script {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  VersionId: ").Append(VersionId).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
        sb.Append("  VersionDate: ").Append(VersionDate).Append("\n");
        sb.Append("  StartPageId: ").Append(StartPageId).Append("\n");
        sb.Append("  StartPageName: ").Append(StartPageName).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
        sb.Append("  Variables: ").Append(Variables).Append("\n");
        sb.Append("  CustomActions: ").Append(CustomActions).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
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
        return Equals(obj as Script);
    }

    /// <summary>
    /// Returns true if Script instances are equal
    /// </summary>
    /// <param name="other">Instance of Script to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Script other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                VersionId == other.VersionId ||
                VersionId != null &&
                VersionId.Equals(other.VersionId)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                PublishedDate == other.PublishedDate ||
                PublishedDate != null &&
                PublishedDate.Equals(other.PublishedDate)
            ) &&
            (
                VersionDate == other.VersionDate ||
                VersionDate != null &&
                VersionDate.Equals(other.VersionDate)
            ) &&
            (
                StartPageId == other.StartPageId ||
                StartPageId != null &&
                StartPageId.Equals(other.StartPageId)
            ) &&
            (
                StartPageName == other.StartPageName ||
                StartPageName != null &&
                StartPageName.Equals(other.StartPageName)
            ) &&
            (
                Features == other.Features ||
                Features != null &&
                Features.Equals(other.Features)
            ) &&
            (
                Variables == other.Variables ||
                Variables != null &&
                Variables.Equals(other.Variables)
            ) &&
            (
                CustomActions == other.CustomActions ||
                CustomActions != null &&
                CustomActions.Equals(other.CustomActions)
            ) &&
            (
                Pages == other.Pages ||
                Pages != null &&
                Pages.SequenceEqual(other.Pages)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (VersionId != null)
            {
                hash = hash * 59 + VersionId.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (PublishedDate != null)
            {
                hash = hash * 59 + PublishedDate.GetHashCode();
            }

            if (VersionDate != null)
            {
                hash = hash * 59 + VersionDate.GetHashCode();
            }

            if (StartPageId != null)
            {
                hash = hash * 59 + StartPageId.GetHashCode();
            }

            if (StartPageName != null)
            {
                hash = hash * 59 + StartPageName.GetHashCode();
            }

            if (Features != null)
            {
                hash = hash * 59 + Features.GetHashCode();
            }

            if (Variables != null)
            {
                hash = hash * 59 + Variables.GetHashCode();
            }

            if (CustomActions != null)
            {
                hash = hash * 59 + CustomActions.GetHashCode();
            }

            if (Pages != null)
            {
                hash = hash * 59 + Pages.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
