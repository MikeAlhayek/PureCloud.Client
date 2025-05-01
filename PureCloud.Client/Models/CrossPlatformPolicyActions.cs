using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CrossPlatformPolicyActions
/// </summary>
[DataContract]
public partial class CrossPlatformPolicyActions : IEquatable<CrossPlatformPolicyActions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CrossPlatformPolicyActions" /> class.
    /// </summary>
    /// <param name="RetainRecording">true to retain the recording associated with the conversation. Default &#x3D; true.</param>
    /// <param name="DeleteRecording">true to delete the recording associated with the conversation. If retainRecording &#x3D; true, this will be ignored. Default &#x3D; false.</param>
    /// <param name="AlwaysDelete">true to delete the recording associated with the conversation regardless of the values of retainRecording or deleteRecording. Default &#x3D; false.</param>
    /// <param name="AssignEvaluations">AssignEvaluations.</param>
    /// <param name="AssignMeteredEvaluations">AssignMeteredEvaluations.</param>
    /// <param name="AssignMeteredAssignmentByAgent">AssignMeteredAssignmentByAgent.</param>
    /// <param name="AssignCalibrations">AssignCalibrations.</param>
    /// <param name="RetentionDuration">RetentionDuration.</param>
    /// <param name="MediaTranscriptions">MediaTranscriptions.</param>
    /// <param name="IntegrationExport">Policy action for exporting recordings using an integration to 3rd party s3..</param>
    public CrossPlatformPolicyActions(bool? RetainRecording = null, bool? DeleteRecording = null, bool? AlwaysDelete = null, List<EvaluationAssignment> AssignEvaluations = null, List<MeteredEvaluationAssignment> AssignMeteredEvaluations = null, List<MeteredAssignmentByAgent> AssignMeteredAssignmentByAgent = null, List<CalibrationAssignment> AssignCalibrations = null, RetentionDuration RetentionDuration = null, List<MediaTranscription> MediaTranscriptions = null, IntegrationExport IntegrationExport = null)
    {
        this.RetainRecording = RetainRecording;
        this.DeleteRecording = DeleteRecording;
        this.AlwaysDelete = AlwaysDelete;
        this.AssignEvaluations = AssignEvaluations;
        this.AssignMeteredEvaluations = AssignMeteredEvaluations;
        this.AssignMeteredAssignmentByAgent = AssignMeteredAssignmentByAgent;
        this.AssignCalibrations = AssignCalibrations;
        this.RetentionDuration = RetentionDuration;
        this.MediaTranscriptions = MediaTranscriptions;
        this.IntegrationExport = IntegrationExport;

    }



    /// <summary>
    /// true to retain the recording associated with the conversation. Default &#x3D; true
    /// </summary>
    /// <value>true to retain the recording associated with the conversation. Default &#x3D; true</value>
    [DataMember(Name = "retainRecording", EmitDefaultValue = false)]
    public bool? RetainRecording { get; set; }



    /// <summary>
    /// true to delete the recording associated with the conversation. If retainRecording &#x3D; true, this will be ignored. Default &#x3D; false
    /// </summary>
    /// <value>true to delete the recording associated with the conversation. If retainRecording &#x3D; true, this will be ignored. Default &#x3D; false</value>
    [DataMember(Name = "deleteRecording", EmitDefaultValue = false)]
    public bool? DeleteRecording { get; set; }



    /// <summary>
    /// true to delete the recording associated with the conversation regardless of the values of retainRecording or deleteRecording. Default &#x3D; false
    /// </summary>
    /// <value>true to delete the recording associated with the conversation regardless of the values of retainRecording or deleteRecording. Default &#x3D; false</value>
    [DataMember(Name = "alwaysDelete", EmitDefaultValue = false)]
    public bool? AlwaysDelete { get; set; }



    /// <summary>
    /// Gets or Sets AssignEvaluations
    /// </summary>
    [DataMember(Name = "assignEvaluations", EmitDefaultValue = false)]
    public List<EvaluationAssignment> AssignEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets AssignMeteredEvaluations
    /// </summary>
    [DataMember(Name = "assignMeteredEvaluations", EmitDefaultValue = false)]
    public List<MeteredEvaluationAssignment> AssignMeteredEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets AssignMeteredAssignmentByAgent
    /// </summary>
    [DataMember(Name = "assignMeteredAssignmentByAgent", EmitDefaultValue = false)]
    public List<MeteredAssignmentByAgent> AssignMeteredAssignmentByAgent { get; set; }



    /// <summary>
    /// Gets or Sets AssignCalibrations
    /// </summary>
    [DataMember(Name = "assignCalibrations", EmitDefaultValue = false)]
    public List<CalibrationAssignment> AssignCalibrations { get; set; }



    /// <summary>
    /// Gets or Sets RetentionDuration
    /// </summary>
    [DataMember(Name = "retentionDuration", EmitDefaultValue = false)]
    public RetentionDuration RetentionDuration { get; set; }



    /// <summary>
    /// Gets or Sets MediaTranscriptions
    /// </summary>
    [DataMember(Name = "mediaTranscriptions", EmitDefaultValue = false)]
    public List<MediaTranscription> MediaTranscriptions { get; set; }



    /// <summary>
    /// Policy action for exporting recordings using an integration to 3rd party s3.
    /// </summary>
    /// <value>Policy action for exporting recordings using an integration to 3rd party s3.</value>
    [DataMember(Name = "integrationExport", EmitDefaultValue = false)]
    public IntegrationExport IntegrationExport { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CrossPlatformPolicyActions {\n");

        sb.Append("  RetainRecording: ").Append(RetainRecording).Append("\n");
        sb.Append("  DeleteRecording: ").Append(DeleteRecording).Append("\n");
        sb.Append("  AlwaysDelete: ").Append(AlwaysDelete).Append("\n");
        sb.Append("  AssignEvaluations: ").Append(AssignEvaluations).Append("\n");
        sb.Append("  AssignMeteredEvaluations: ").Append(AssignMeteredEvaluations).Append("\n");
        sb.Append("  AssignMeteredAssignmentByAgent: ").Append(AssignMeteredAssignmentByAgent).Append("\n");
        sb.Append("  AssignCalibrations: ").Append(AssignCalibrations).Append("\n");
        sb.Append("  RetentionDuration: ").Append(RetentionDuration).Append("\n");
        sb.Append("  MediaTranscriptions: ").Append(MediaTranscriptions).Append("\n");
        sb.Append("  IntegrationExport: ").Append(IntegrationExport).Append("\n");
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
        return Equals(obj as CrossPlatformPolicyActions);
    }

    /// <summary>
    /// Returns true if CrossPlatformPolicyActions instances are equal
    /// </summary>
    /// <param name="other">Instance of CrossPlatformPolicyActions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CrossPlatformPolicyActions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RetainRecording == other.RetainRecording ||
                RetainRecording != null &&
                RetainRecording.Equals(other.RetainRecording)
            ) &&
            (
                DeleteRecording == other.DeleteRecording ||
                DeleteRecording != null &&
                DeleteRecording.Equals(other.DeleteRecording)
            ) &&
            (
                AlwaysDelete == other.AlwaysDelete ||
                AlwaysDelete != null &&
                AlwaysDelete.Equals(other.AlwaysDelete)
            ) &&
            (
                AssignEvaluations == other.AssignEvaluations ||
                AssignEvaluations != null &&
                AssignEvaluations.SequenceEqual(other.AssignEvaluations)
            ) &&
            (
                AssignMeteredEvaluations == other.AssignMeteredEvaluations ||
                AssignMeteredEvaluations != null &&
                AssignMeteredEvaluations.SequenceEqual(other.AssignMeteredEvaluations)
            ) &&
            (
                AssignMeteredAssignmentByAgent == other.AssignMeteredAssignmentByAgent ||
                AssignMeteredAssignmentByAgent != null &&
                AssignMeteredAssignmentByAgent.SequenceEqual(other.AssignMeteredAssignmentByAgent)
            ) &&
            (
                AssignCalibrations == other.AssignCalibrations ||
                AssignCalibrations != null &&
                AssignCalibrations.SequenceEqual(other.AssignCalibrations)
            ) &&
            (
                RetentionDuration == other.RetentionDuration ||
                RetentionDuration != null &&
                RetentionDuration.Equals(other.RetentionDuration)
            ) &&
            (
                MediaTranscriptions == other.MediaTranscriptions ||
                MediaTranscriptions != null &&
                MediaTranscriptions.SequenceEqual(other.MediaTranscriptions)
            ) &&
            (
                IntegrationExport == other.IntegrationExport ||
                IntegrationExport != null &&
                IntegrationExport.Equals(other.IntegrationExport)
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
            if (RetainRecording != null)
            {
                hash = hash * 59 + RetainRecording.GetHashCode();
            }

            if (DeleteRecording != null)
            {
                hash = hash * 59 + DeleteRecording.GetHashCode();
            }

            if (AlwaysDelete != null)
            {
                hash = hash * 59 + AlwaysDelete.GetHashCode();
            }

            if (AssignEvaluations != null)
            {
                hash = hash * 59 + AssignEvaluations.GetHashCode();
            }

            if (AssignMeteredEvaluations != null)
            {
                hash = hash * 59 + AssignMeteredEvaluations.GetHashCode();
            }

            if (AssignMeteredAssignmentByAgent != null)
            {
                hash = hash * 59 + AssignMeteredAssignmentByAgent.GetHashCode();
            }

            if (AssignCalibrations != null)
            {
                hash = hash * 59 + AssignCalibrations.GetHashCode();
            }

            if (RetentionDuration != null)
            {
                hash = hash * 59 + RetentionDuration.GetHashCode();
            }

            if (MediaTranscriptions != null)
            {
                hash = hash * 59 + MediaTranscriptions.GetHashCode();
            }

            if (IntegrationExport != null)
            {
                hash = hash * 59 + IntegrationExport.GetHashCode();
            }

            return hash;
        }
    }
}
