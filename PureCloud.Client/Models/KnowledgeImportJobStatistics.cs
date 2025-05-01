using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeImportJobStatistics
/// </summary>
[DataContract]
public partial class KnowledgeImportJobStatistics : IEquatable<KnowledgeImportJobStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobStatistics" /> class.
    /// </summary>
    /// <param name="CountDocumentImportActivityCreate">Number of documents will be created by the import..</param>
    /// <param name="CountDocumentImportActivityUpdate">Number of documents will be updated by the import..</param>
    /// <param name="CountDocumentStateDraft">Number of documents will be imported as draft..</param>
    /// <param name="CountDocumentStatePublished">Number of documents will be imported as published..</param>
    /// <param name="CountDocumentValidationSuccess">Number of documents that validated successfully for import..</param>
    /// <param name="CountDocumentValidationFailure">Number of documents that failed validation for import..</param>
    /// <param name="CountDocumentImportSuccess">Number of imported documents..</param>
    /// <param name="CountDocumentImportFailure">Number of documents failed to import..</param>
    /// <param name="CountCategoryValidationSuccess">Number of categories that validated successfully for import..</param>
    /// <param name="CountCategoryValidationFailure">Number of categories that failed validation for import..</param>
    /// <param name="CountCategoryImportSuccess">Number of imported categories..</param>
    /// <param name="CountCategoryImportFailure">Number of categories failed to import..</param>
    /// <param name="CountLabelValidationSuccess">Number of labels that validated successfully for import..</param>
    /// <param name="CountLabelValidationFailure">Number of labels that failed validation for import..</param>
    /// <param name="CountLabelImportSuccess">Number of imported labels..</param>
    /// <param name="CountLabelImportFailure">Number of labels failed to import..</param>
    /// <param name="MigrationDetected">Shows whether the import treated as migration or not..</param>
    public KnowledgeImportJobStatistics(int? CountDocumentImportActivityCreate = null, int? CountDocumentImportActivityUpdate = null, int? CountDocumentStateDraft = null, int? CountDocumentStatePublished = null, int? CountDocumentValidationSuccess = null, int? CountDocumentValidationFailure = null, int? CountDocumentImportSuccess = null, int? CountDocumentImportFailure = null, int? CountCategoryValidationSuccess = null, int? CountCategoryValidationFailure = null, int? CountCategoryImportSuccess = null, int? CountCategoryImportFailure = null, int? CountLabelValidationSuccess = null, int? CountLabelValidationFailure = null, int? CountLabelImportSuccess = null, int? CountLabelImportFailure = null, bool? MigrationDetected = null)
    {
        this.CountDocumentImportActivityCreate = CountDocumentImportActivityCreate;
        this.CountDocumentImportActivityUpdate = CountDocumentImportActivityUpdate;
        this.CountDocumentStateDraft = CountDocumentStateDraft;
        this.CountDocumentStatePublished = CountDocumentStatePublished;
        this.CountDocumentValidationSuccess = CountDocumentValidationSuccess;
        this.CountDocumentValidationFailure = CountDocumentValidationFailure;
        this.CountDocumentImportSuccess = CountDocumentImportSuccess;
        this.CountDocumentImportFailure = CountDocumentImportFailure;
        this.CountCategoryValidationSuccess = CountCategoryValidationSuccess;
        this.CountCategoryValidationFailure = CountCategoryValidationFailure;
        this.CountCategoryImportSuccess = CountCategoryImportSuccess;
        this.CountCategoryImportFailure = CountCategoryImportFailure;
        this.CountLabelValidationSuccess = CountLabelValidationSuccess;
        this.CountLabelValidationFailure = CountLabelValidationFailure;
        this.CountLabelImportSuccess = CountLabelImportSuccess;
        this.CountLabelImportFailure = CountLabelImportFailure;
        this.MigrationDetected = MigrationDetected;

    }



    /// <summary>
    /// Number of documents will be created by the import.
    /// </summary>
    /// <value>Number of documents will be created by the import.</value>
    [DataMember(Name = "countDocumentImportActivityCreate", EmitDefaultValue = false)]
    public int? CountDocumentImportActivityCreate { get; set; }



    /// <summary>
    /// Number of documents will be updated by the import.
    /// </summary>
    /// <value>Number of documents will be updated by the import.</value>
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
    /// Number of documents that validated successfully for import.
    /// </summary>
    /// <value>Number of documents that validated successfully for import.</value>
    [DataMember(Name = "countDocumentValidationSuccess", EmitDefaultValue = false)]
    public int? CountDocumentValidationSuccess { get; set; }



    /// <summary>
    /// Number of documents that failed validation for import.
    /// </summary>
    /// <value>Number of documents that failed validation for import.</value>
    [DataMember(Name = "countDocumentValidationFailure", EmitDefaultValue = false)]
    public int? CountDocumentValidationFailure { get; set; }



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
    /// Number of categories that validated successfully for import.
    /// </summary>
    /// <value>Number of categories that validated successfully for import.</value>
    [DataMember(Name = "countCategoryValidationSuccess", EmitDefaultValue = false)]
    public int? CountCategoryValidationSuccess { get; set; }



    /// <summary>
    /// Number of categories that failed validation for import.
    /// </summary>
    /// <value>Number of categories that failed validation for import.</value>
    [DataMember(Name = "countCategoryValidationFailure", EmitDefaultValue = false)]
    public int? CountCategoryValidationFailure { get; set; }



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
    /// Number of labels that validated successfully for import.
    /// </summary>
    /// <value>Number of labels that validated successfully for import.</value>
    [DataMember(Name = "countLabelValidationSuccess", EmitDefaultValue = false)]
    public int? CountLabelValidationSuccess { get; set; }



    /// <summary>
    /// Number of labels that failed validation for import.
    /// </summary>
    /// <value>Number of labels that failed validation for import.</value>
    [DataMember(Name = "countLabelValidationFailure", EmitDefaultValue = false)]
    public int? CountLabelValidationFailure { get; set; }



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
    /// Shows whether the import treated as migration or not.
    /// </summary>
    /// <value>Shows whether the import treated as migration or not.</value>
    [DataMember(Name = "migrationDetected", EmitDefaultValue = false)]
    public bool? MigrationDetected { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeImportJobStatistics {\n");

        sb.Append("  CountDocumentImportActivityCreate: ").Append(CountDocumentImportActivityCreate).Append("\n");
        sb.Append("  CountDocumentImportActivityUpdate: ").Append(CountDocumentImportActivityUpdate).Append("\n");
        sb.Append("  CountDocumentStateDraft: ").Append(CountDocumentStateDraft).Append("\n");
        sb.Append("  CountDocumentStatePublished: ").Append(CountDocumentStatePublished).Append("\n");
        sb.Append("  CountDocumentValidationSuccess: ").Append(CountDocumentValidationSuccess).Append("\n");
        sb.Append("  CountDocumentValidationFailure: ").Append(CountDocumentValidationFailure).Append("\n");
        sb.Append("  CountDocumentImportSuccess: ").Append(CountDocumentImportSuccess).Append("\n");
        sb.Append("  CountDocumentImportFailure: ").Append(CountDocumentImportFailure).Append("\n");
        sb.Append("  CountCategoryValidationSuccess: ").Append(CountCategoryValidationSuccess).Append("\n");
        sb.Append("  CountCategoryValidationFailure: ").Append(CountCategoryValidationFailure).Append("\n");
        sb.Append("  CountCategoryImportSuccess: ").Append(CountCategoryImportSuccess).Append("\n");
        sb.Append("  CountCategoryImportFailure: ").Append(CountCategoryImportFailure).Append("\n");
        sb.Append("  CountLabelValidationSuccess: ").Append(CountLabelValidationSuccess).Append("\n");
        sb.Append("  CountLabelValidationFailure: ").Append(CountLabelValidationFailure).Append("\n");
        sb.Append("  CountLabelImportSuccess: ").Append(CountLabelImportSuccess).Append("\n");
        sb.Append("  CountLabelImportFailure: ").Append(CountLabelImportFailure).Append("\n");
        sb.Append("  MigrationDetected: ").Append(MigrationDetected).Append("\n");
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
        return Equals(obj as KnowledgeImportJobStatistics);
    }

    /// <summary>
    /// Returns true if KnowledgeImportJobStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeImportJobStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeImportJobStatistics other)
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
                CountDocumentValidationSuccess == other.CountDocumentValidationSuccess ||
                CountDocumentValidationSuccess != null &&
                CountDocumentValidationSuccess.Equals(other.CountDocumentValidationSuccess)
            ) &&
            (
                CountDocumentValidationFailure == other.CountDocumentValidationFailure ||
                CountDocumentValidationFailure != null &&
                CountDocumentValidationFailure.Equals(other.CountDocumentValidationFailure)
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
                CountCategoryValidationSuccess == other.CountCategoryValidationSuccess ||
                CountCategoryValidationSuccess != null &&
                CountCategoryValidationSuccess.Equals(other.CountCategoryValidationSuccess)
            ) &&
            (
                CountCategoryValidationFailure == other.CountCategoryValidationFailure ||
                CountCategoryValidationFailure != null &&
                CountCategoryValidationFailure.Equals(other.CountCategoryValidationFailure)
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
                CountLabelValidationSuccess == other.CountLabelValidationSuccess ||
                CountLabelValidationSuccess != null &&
                CountLabelValidationSuccess.Equals(other.CountLabelValidationSuccess)
            ) &&
            (
                CountLabelValidationFailure == other.CountLabelValidationFailure ||
                CountLabelValidationFailure != null &&
                CountLabelValidationFailure.Equals(other.CountLabelValidationFailure)
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
                MigrationDetected == other.MigrationDetected ||
                MigrationDetected != null &&
                MigrationDetected.Equals(other.MigrationDetected)
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

            if (CountDocumentValidationSuccess != null)
            {
                hash = hash * 59 + CountDocumentValidationSuccess.GetHashCode();
            }

            if (CountDocumentValidationFailure != null)
            {
                hash = hash * 59 + CountDocumentValidationFailure.GetHashCode();
            }

            if (CountDocumentImportSuccess != null)
            {
                hash = hash * 59 + CountDocumentImportSuccess.GetHashCode();
            }

            if (CountDocumentImportFailure != null)
            {
                hash = hash * 59 + CountDocumentImportFailure.GetHashCode();
            }

            if (CountCategoryValidationSuccess != null)
            {
                hash = hash * 59 + CountCategoryValidationSuccess.GetHashCode();
            }

            if (CountCategoryValidationFailure != null)
            {
                hash = hash * 59 + CountCategoryValidationFailure.GetHashCode();
            }

            if (CountCategoryImportSuccess != null)
            {
                hash = hash * 59 + CountCategoryImportSuccess.GetHashCode();
            }

            if (CountCategoryImportFailure != null)
            {
                hash = hash * 59 + CountCategoryImportFailure.GetHashCode();
            }

            if (CountLabelValidationSuccess != null)
            {
                hash = hash * 59 + CountLabelValidationSuccess.GetHashCode();
            }

            if (CountLabelValidationFailure != null)
            {
                hash = hash * 59 + CountLabelValidationFailure.GetHashCode();
            }

            if (CountLabelImportSuccess != null)
            {
                hash = hash * 59 + CountLabelImportSuccess.GetHashCode();
            }

            if (CountLabelImportFailure != null)
            {
                hash = hash * 59 + CountLabelImportFailure.GetHashCode();
            }

            if (MigrationDetected != null)
            {
                hash = hash * 59 + MigrationDetected.GetHashCode();
            }

            return hash;
        }
    }
}
