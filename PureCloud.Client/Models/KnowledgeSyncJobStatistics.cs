using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSyncJobStatistics
/// </summary>
[DataContract]
public partial class KnowledgeSyncJobStatistics : IEquatable<KnowledgeSyncJobStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSyncJobStatistics" /> class.
    /// </summary>
    /// <param name="CountDocumentImportActivityCreate">Number of documents will be created by the sync..</param>
    /// <param name="CountDocumentImportActivityUpdate">Number of documents will be updated by the sync..</param>
    /// <param name="CountDocumentStateDraft">Number of documents will be imported as draft..</param>
    /// <param name="CountDocumentStatePublished">Number of documents will be imported as published..</param>
    /// <param name="CountDocumentImportSuccess">Number of imported documents..</param>
    /// <param name="CountDocumentImportFailure">Number of documents failed to import..</param>
    /// <param name="CountCategoryImportSuccess">Number of imported categories..</param>
    /// <param name="CountCategoryImportFailure">Number of categories failed to import..</param>
    /// <param name="CountLabelImportSuccess">Number of imported labels..</param>
    /// <param name="CountLabelImportFailure">Number of labels failed to import..</param>
    /// <param name="CountDocumentDeleteSuccess">Number of documents will be deleted by the sync..</param>
    /// <param name="CountDocumentDeleteFailure">Number of documents failed to delete..</param>
    /// <param name="CountCategoryDeleteSuccess">Number of successfully deleted categories..</param>
    /// <param name="CountCategoryDeleteFailure">Number of categories failed to delete..</param>
    /// <param name="CountLabelDeleteSuccess">Number of successfully deleted labels..</param>
    /// <param name="CountLabelDeleteFailure">Number of labels failed to delete..</param>
    public KnowledgeSyncJobStatistics(int? CountDocumentImportActivityCreate = null, int? CountDocumentImportActivityUpdate = null, int? CountDocumentStateDraft = null, int? CountDocumentStatePublished = null, int? CountDocumentImportSuccess = null, int? CountDocumentImportFailure = null, int? CountCategoryImportSuccess = null, int? CountCategoryImportFailure = null, int? CountLabelImportSuccess = null, int? CountLabelImportFailure = null, int? CountDocumentDeleteSuccess = null, int? CountDocumentDeleteFailure = null, int? CountCategoryDeleteSuccess = null, int? CountCategoryDeleteFailure = null, int? CountLabelDeleteSuccess = null, int? CountLabelDeleteFailure = null)
    {
        this.CountDocumentImportActivityCreate = CountDocumentImportActivityCreate;
        this.CountDocumentImportActivityUpdate = CountDocumentImportActivityUpdate;
        this.CountDocumentStateDraft = CountDocumentStateDraft;
        this.CountDocumentStatePublished = CountDocumentStatePublished;
        this.CountDocumentImportSuccess = CountDocumentImportSuccess;
        this.CountDocumentImportFailure = CountDocumentImportFailure;
        this.CountCategoryImportSuccess = CountCategoryImportSuccess;
        this.CountCategoryImportFailure = CountCategoryImportFailure;
        this.CountLabelImportSuccess = CountLabelImportSuccess;
        this.CountLabelImportFailure = CountLabelImportFailure;
        this.CountDocumentDeleteSuccess = CountDocumentDeleteSuccess;
        this.CountDocumentDeleteFailure = CountDocumentDeleteFailure;
        this.CountCategoryDeleteSuccess = CountCategoryDeleteSuccess;
        this.CountCategoryDeleteFailure = CountCategoryDeleteFailure;
        this.CountLabelDeleteSuccess = CountLabelDeleteSuccess;
        this.CountLabelDeleteFailure = CountLabelDeleteFailure;

    }



    /// <summary>
    /// Number of documents will be created by the sync.
    /// </summary>
    /// <value>Number of documents will be created by the sync.</value>
    [DataMember(Name = "countDocumentImportActivityCreate", EmitDefaultValue = false)]
    public int? CountDocumentImportActivityCreate { get; set; }



    /// <summary>
    /// Number of documents will be updated by the sync.
    /// </summary>
    /// <value>Number of documents will be updated by the sync.</value>
    [DataMember(Name = "countDocumentImportActivityUpdate", EmitDefaultValue = false)]
    public int? CountDocumentImportActivityUpdate { get; set; }



    /// <summary>
    /// Number of documents will be imported as draft.
    /// </summary>
    /// <value>Number of documents will be imported as draft.</value>
    [DataMember(Name = "countDocumentStateDraft", EmitDefaultValue = false)]
    public int? CountDocumentStateDraft { get; set; }



    /// <summary>
    /// Number of documents will be imported as published.
    /// </summary>
    /// <value>Number of documents will be imported as published.</value>
    [DataMember(Name = "countDocumentStatePublished", EmitDefaultValue = false)]
    public int? CountDocumentStatePublished { get; set; }



    /// <summary>
    /// Number of imported documents.
    /// </summary>
    /// <value>Number of imported documents.</value>
    [DataMember(Name = "countDocumentImportSuccess", EmitDefaultValue = false)]
    public int? CountDocumentImportSuccess { get; set; }



    /// <summary>
    /// Number of documents failed to import.
    /// </summary>
    /// <value>Number of documents failed to import.</value>
    [DataMember(Name = "countDocumentImportFailure", EmitDefaultValue = false)]
    public int? CountDocumentImportFailure { get; set; }



    /// <summary>
    /// Number of imported categories.
    /// </summary>
    /// <value>Number of imported categories.</value>
    [DataMember(Name = "countCategoryImportSuccess", EmitDefaultValue = false)]
    public int? CountCategoryImportSuccess { get; set; }



    /// <summary>
    /// Number of categories failed to import.
    /// </summary>
    /// <value>Number of categories failed to import.</value>
    [DataMember(Name = "countCategoryImportFailure", EmitDefaultValue = false)]
    public int? CountCategoryImportFailure { get; set; }



    /// <summary>
    /// Number of imported labels.
    /// </summary>
    /// <value>Number of imported labels.</value>
    [DataMember(Name = "countLabelImportSuccess", EmitDefaultValue = false)]
    public int? CountLabelImportSuccess { get; set; }



    /// <summary>
    /// Number of labels failed to import.
    /// </summary>
    /// <value>Number of labels failed to import.</value>
    [DataMember(Name = "countLabelImportFailure", EmitDefaultValue = false)]
    public int? CountLabelImportFailure { get; set; }



    /// <summary>
    /// Number of documents will be deleted by the sync.
    /// </summary>
    /// <value>Number of documents will be deleted by the sync.</value>
    [DataMember(Name = "countDocumentDeleteSuccess", EmitDefaultValue = false)]
    public int? CountDocumentDeleteSuccess { get; set; }



    /// <summary>
    /// Number of documents failed to delete.
    /// </summary>
    /// <value>Number of documents failed to delete.</value>
    [DataMember(Name = "countDocumentDeleteFailure", EmitDefaultValue = false)]
    public int? CountDocumentDeleteFailure { get; set; }



    /// <summary>
    /// Number of successfully deleted categories.
    /// </summary>
    /// <value>Number of successfully deleted categories.</value>
    [DataMember(Name = "countCategoryDeleteSuccess", EmitDefaultValue = false)]
    public int? CountCategoryDeleteSuccess { get; set; }



    /// <summary>
    /// Number of categories failed to delete.
    /// </summary>
    /// <value>Number of categories failed to delete.</value>
    [DataMember(Name = "countCategoryDeleteFailure", EmitDefaultValue = false)]
    public int? CountCategoryDeleteFailure { get; set; }



    /// <summary>
    /// Number of successfully deleted labels.
    /// </summary>
    /// <value>Number of successfully deleted labels.</value>
    [DataMember(Name = "countLabelDeleteSuccess", EmitDefaultValue = false)]
    public int? CountLabelDeleteSuccess { get; set; }



    /// <summary>
    /// Number of labels failed to delete.
    /// </summary>
    /// <value>Number of labels failed to delete.</value>
    [DataMember(Name = "countLabelDeleteFailure", EmitDefaultValue = false)]
    public int? CountLabelDeleteFailure { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSyncJobStatistics {\n");

        sb.Append("  CountDocumentImportActivityCreate: ").Append(CountDocumentImportActivityCreate).Append("\n");
        sb.Append("  CountDocumentImportActivityUpdate: ").Append(CountDocumentImportActivityUpdate).Append("\n");
        sb.Append("  CountDocumentStateDraft: ").Append(CountDocumentStateDraft).Append("\n");
        sb.Append("  CountDocumentStatePublished: ").Append(CountDocumentStatePublished).Append("\n");
        sb.Append("  CountDocumentImportSuccess: ").Append(CountDocumentImportSuccess).Append("\n");
        sb.Append("  CountDocumentImportFailure: ").Append(CountDocumentImportFailure).Append("\n");
        sb.Append("  CountCategoryImportSuccess: ").Append(CountCategoryImportSuccess).Append("\n");
        sb.Append("  CountCategoryImportFailure: ").Append(CountCategoryImportFailure).Append("\n");
        sb.Append("  CountLabelImportSuccess: ").Append(CountLabelImportSuccess).Append("\n");
        sb.Append("  CountLabelImportFailure: ").Append(CountLabelImportFailure).Append("\n");
        sb.Append("  CountDocumentDeleteSuccess: ").Append(CountDocumentDeleteSuccess).Append("\n");
        sb.Append("  CountDocumentDeleteFailure: ").Append(CountDocumentDeleteFailure).Append("\n");
        sb.Append("  CountCategoryDeleteSuccess: ").Append(CountCategoryDeleteSuccess).Append("\n");
        sb.Append("  CountCategoryDeleteFailure: ").Append(CountCategoryDeleteFailure).Append("\n");
        sb.Append("  CountLabelDeleteSuccess: ").Append(CountLabelDeleteSuccess).Append("\n");
        sb.Append("  CountLabelDeleteFailure: ").Append(CountLabelDeleteFailure).Append("\n");
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
        return Equals(obj as KnowledgeSyncJobStatistics);
    }

    /// <summary>
    /// Returns true if KnowledgeSyncJobStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSyncJobStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSyncJobStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CountDocumentImportActivityCreate == other.CountDocumentImportActivityCreate ||
                CountDocumentImportActivityCreate != null &&
                CountDocumentImportActivityCreate.Equals(other.CountDocumentImportActivityCreate)
            ) &&
            (
                CountDocumentImportActivityUpdate == other.CountDocumentImportActivityUpdate ||
                CountDocumentImportActivityUpdate != null &&
                CountDocumentImportActivityUpdate.Equals(other.CountDocumentImportActivityUpdate)
            ) &&
            (
                CountDocumentStateDraft == other.CountDocumentStateDraft ||
                CountDocumentStateDraft != null &&
                CountDocumentStateDraft.Equals(other.CountDocumentStateDraft)
            ) &&
            (
                CountDocumentStatePublished == other.CountDocumentStatePublished ||
                CountDocumentStatePublished != null &&
                CountDocumentStatePublished.Equals(other.CountDocumentStatePublished)
            ) &&
            (
                CountDocumentImportSuccess == other.CountDocumentImportSuccess ||
                CountDocumentImportSuccess != null &&
                CountDocumentImportSuccess.Equals(other.CountDocumentImportSuccess)
            ) &&
            (
                CountDocumentImportFailure == other.CountDocumentImportFailure ||
                CountDocumentImportFailure != null &&
                CountDocumentImportFailure.Equals(other.CountDocumentImportFailure)
            ) &&
            (
                CountCategoryImportSuccess == other.CountCategoryImportSuccess ||
                CountCategoryImportSuccess != null &&
                CountCategoryImportSuccess.Equals(other.CountCategoryImportSuccess)
            ) &&
            (
                CountCategoryImportFailure == other.CountCategoryImportFailure ||
                CountCategoryImportFailure != null &&
                CountCategoryImportFailure.Equals(other.CountCategoryImportFailure)
            ) &&
            (
                CountLabelImportSuccess == other.CountLabelImportSuccess ||
                CountLabelImportSuccess != null &&
                CountLabelImportSuccess.Equals(other.CountLabelImportSuccess)
            ) &&
            (
                CountLabelImportFailure == other.CountLabelImportFailure ||
                CountLabelImportFailure != null &&
                CountLabelImportFailure.Equals(other.CountLabelImportFailure)
            ) &&
            (
                CountDocumentDeleteSuccess == other.CountDocumentDeleteSuccess ||
                CountDocumentDeleteSuccess != null &&
                CountDocumentDeleteSuccess.Equals(other.CountDocumentDeleteSuccess)
            ) &&
            (
                CountDocumentDeleteFailure == other.CountDocumentDeleteFailure ||
                CountDocumentDeleteFailure != null &&
                CountDocumentDeleteFailure.Equals(other.CountDocumentDeleteFailure)
            ) &&
            (
                CountCategoryDeleteSuccess == other.CountCategoryDeleteSuccess ||
                CountCategoryDeleteSuccess != null &&
                CountCategoryDeleteSuccess.Equals(other.CountCategoryDeleteSuccess)
            ) &&
            (
                CountCategoryDeleteFailure == other.CountCategoryDeleteFailure ||
                CountCategoryDeleteFailure != null &&
                CountCategoryDeleteFailure.Equals(other.CountCategoryDeleteFailure)
            ) &&
            (
                CountLabelDeleteSuccess == other.CountLabelDeleteSuccess ||
                CountLabelDeleteSuccess != null &&
                CountLabelDeleteSuccess.Equals(other.CountLabelDeleteSuccess)
            ) &&
            (
                CountLabelDeleteFailure == other.CountLabelDeleteFailure ||
                CountLabelDeleteFailure != null &&
                CountLabelDeleteFailure.Equals(other.CountLabelDeleteFailure)
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
            if (CountDocumentImportActivityCreate != null)
            {
                hash = hash * 59 + CountDocumentImportActivityCreate.GetHashCode();
            }

            if (CountDocumentImportActivityUpdate != null)
            {
                hash = hash * 59 + CountDocumentImportActivityUpdate.GetHashCode();
            }

            if (CountDocumentStateDraft != null)
            {
                hash = hash * 59 + CountDocumentStateDraft.GetHashCode();
            }

            if (CountDocumentStatePublished != null)
            {
                hash = hash * 59 + CountDocumentStatePublished.GetHashCode();
            }

            if (CountDocumentImportSuccess != null)
            {
                hash = hash * 59 + CountDocumentImportSuccess.GetHashCode();
            }

            if (CountDocumentImportFailure != null)
            {
                hash = hash * 59 + CountDocumentImportFailure.GetHashCode();
            }

            if (CountCategoryImportSuccess != null)
            {
                hash = hash * 59 + CountCategoryImportSuccess.GetHashCode();
            }

            if (CountCategoryImportFailure != null)
            {
                hash = hash * 59 + CountCategoryImportFailure.GetHashCode();
            }

            if (CountLabelImportSuccess != null)
            {
                hash = hash * 59 + CountLabelImportSuccess.GetHashCode();
            }

            if (CountLabelImportFailure != null)
            {
                hash = hash * 59 + CountLabelImportFailure.GetHashCode();
            }

            if (CountDocumentDeleteSuccess != null)
            {
                hash = hash * 59 + CountDocumentDeleteSuccess.GetHashCode();
            }

            if (CountDocumentDeleteFailure != null)
            {
                hash = hash * 59 + CountDocumentDeleteFailure.GetHashCode();
            }

            if (CountCategoryDeleteSuccess != null)
            {
                hash = hash * 59 + CountCategoryDeleteSuccess.GetHashCode();
            }

            if (CountCategoryDeleteFailure != null)
            {
                hash = hash * 59 + CountCategoryDeleteFailure.GetHashCode();
            }

            if (CountLabelDeleteSuccess != null)
            {
                hash = hash * 59 + CountLabelDeleteSuccess.GetHashCode();
            }

            if (CountLabelDeleteFailure != null)
            {
                hash = hash * 59 + CountLabelDeleteFailure.GetHashCode();
            }

            return hash;
        }
    }
}
