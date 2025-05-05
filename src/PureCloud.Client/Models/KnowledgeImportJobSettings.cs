using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeImportJobSettings
/// </summary>

public partial class KnowledgeImportJobSettings : IEquatable<KnowledgeImportJobSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobSettings" /> class.
    /// </summary>
    /// <param name="ImportAsNew">If enabled import creates a new document even if update is available..</param>
    /// <param name="Visible">If specified, import will override the visibility of the imported documents..</param>
    /// <param name="CategoryId">If specified, import will override the category of the imported documents..</param>
    /// <param name="LabelIds">If specified, import will add this labels to the imported documents..</param>
    public KnowledgeImportJobSettings(bool? ImportAsNew = null, bool? Visible = null, string CategoryId = null, List<string> LabelIds = null)
    {
        this.ImportAsNew = ImportAsNew;
        this.Visible = Visible;
        this.CategoryId = CategoryId;
        this.LabelIds = LabelIds;

    }



    /// <summary>
    /// If enabled import creates a new document even if update is available.
    /// </summary>
    /// <value>If enabled import creates a new document even if update is available.</value>
    [JsonPropertyName("importAsNew")]
    public bool? ImportAsNew { get; set; }



    /// <summary>
    /// If specified, import will override the visibility of the imported documents.
    /// </summary>
    /// <value>If specified, import will override the visibility of the imported documents.</value>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }



    /// <summary>
    /// If specified, import will override the category of the imported documents.
    /// </summary>
    /// <value>If specified, import will override the category of the imported documents.</value>
    [JsonPropertyName("categoryId")]
    public string CategoryId { get; set; }



    /// <summary>
    /// If specified, import will add this labels to the imported documents.
    /// </summary>
    /// <value>If specified, import will add this labels to the imported documents.</value>
    [JsonPropertyName("labelIds")]
    public List<string> LabelIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeImportJobSettings {\n");

        sb.Append("  ImportAsNew: ").Append(ImportAsNew).Append("\n");
        sb.Append("  Visible: ").Append(Visible).Append("\n");
        sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
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
        return Equals(obj as KnowledgeImportJobSettings);
    }

    /// <summary>
    /// Returns true if KnowledgeImportJobSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeImportJobSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeImportJobSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ImportAsNew == other.ImportAsNew ||
                ImportAsNew != null &&
                ImportAsNew.Equals(other.ImportAsNew)
            ) &&
            (
                Visible == other.Visible ||
                Visible != null &&
                Visible.Equals(other.Visible)
            ) &&
            (
                CategoryId == other.CategoryId ||
                CategoryId != null &&
                CategoryId.Equals(other.CategoryId)
            ) &&
            (
                LabelIds == other.LabelIds ||
                LabelIds != null &&
                LabelIds.SequenceEqual(other.LabelIds)
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
            if (ImportAsNew != null)
            {
                hash = hash * 59 + ImportAsNew.GetHashCode();
            }

            if (Visible != null)
            {
                hash = hash * 59 + Visible.GetHashCode();
            }

            if (CategoryId != null)
            {
                hash = hash * 59 + CategoryId.GetHashCode();
            }

            if (LabelIds != null)
            {
                hash = hash * 59 + LabelIds.GetHashCode();
            }

            return hash;
        }
    }
}
