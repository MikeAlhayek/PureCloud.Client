using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentTopicLearningAssignmentNotification
/// </summary>

public partial class LearningAssignmentTopicLearningAssignmentNotification : IEquatable<LearningAssignmentTopicLearningAssignmentNotification>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
        /// Enum Assigned for "Assigned"
        /// </summary>
        [EnumMember(Value = "Assigned")]
        Assigned,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted,

        /// <summary>
        /// Enum Notcompleted for "NotCompleted"
        /// </summary>
        [EnumMember(Value = "NotCompleted")]
        Notcompleted,

        /// <summary>
        /// Enum Invalidschedule for "InvalidSchedule"
        /// </summary>
        [EnumMember(Value = "InvalidSchedule")]
        Invalidschedule
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Native for "Native"
        /// </summary>
        [EnumMember(Value = "Native")]
        Native,

        /// <summary>
        /// Enum External for "External"
        /// </summary>
        [EnumMember(Value = "External")]
        External
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentTopicLearningAssignmentNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="User">User.</param>
    /// <param name="Module">Module.</param>
    /// <param name="Version">Version.</param>
    /// <param name="State">State.</param>
    /// <param name="DateRecommendedForCompletion">DateRecommendedForCompletion.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DateModified">DateModified.</param>
    /// <param name="IsOverdue">IsOverdue.</param>
    /// <param name="LengthInMinutes">LengthInMinutes.</param>
    /// <param name="PercentageScore">PercentageScore.</param>
    /// <param name="IsPassed">IsPassed.</param>
    /// <param name="Type">Type.</param>
    public LearningAssignmentTopicLearningAssignmentNotification(string Id = null, LearningAssignmentTopicUserReference User = null, LearningAssignmentTopicLearningModuleReference Module = null, long? Version = null, StateEnum? State = null, DateTime? DateRecommendedForCompletion = null, LearningAssignmentTopicUserReference CreatedBy = null, DateTime? DateCreated = null, LearningAssignmentTopicUserReference ModifiedBy = null, DateTime? DateModified = null, bool? IsOverdue = null, long? LengthInMinutes = null, double? PercentageScore = null, bool? IsPassed = null, TypeEnum? Type = null)
    {
        this.Id = Id;
        this.User = User;
        this.Module = Module;
        this.Version = Version;
        this.State = State;
        this.DateRecommendedForCompletion = DateRecommendedForCompletion;
        this.CreatedBy = CreatedBy;
        this.DateCreated = DateCreated;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;
        this.IsOverdue = IsOverdue;
        this.LengthInMinutes = LengthInMinutes;
        this.PercentageScore = PercentageScore;
        this.IsPassed = IsPassed;
        this.Type = Type;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public LearningAssignmentTopicUserReference User { get; set; }



    /// <summary>
    /// Gets or Sets Module
    /// </summary>
    [JsonPropertyName("module")]
    public LearningAssignmentTopicLearningModuleReference Module { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public long? Version { get; set; }





    /// <summary>
    /// Gets or Sets DateRecommendedForCompletion
    /// </summary>
    [JsonPropertyName("dateRecommendedForCompletion")]
    public DateTime? DateRecommendedForCompletion { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [JsonPropertyName("createdBy")]
    public LearningAssignmentTopicUserReference CreatedBy { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public LearningAssignmentTopicUserReference ModifiedBy { get; set; }



    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets IsOverdue
    /// </summary>
    [JsonPropertyName("isOverdue")]
    public bool? IsOverdue { get; set; }



    /// <summary>
    /// Gets or Sets LengthInMinutes
    /// </summary>
    [JsonPropertyName("lengthInMinutes")]
    public long? LengthInMinutes { get; set; }



    /// <summary>
    /// Gets or Sets PercentageScore
    /// </summary>
    [JsonPropertyName("percentageScore")]
    public double? PercentageScore { get; set; }



    /// <summary>
    /// Gets or Sets IsPassed
    /// </summary>
    [JsonPropertyName("isPassed")]
    public bool? IsPassed { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentTopicLearningAssignmentNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Module: ").Append(Module).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateRecommendedForCompletion: ").Append(DateRecommendedForCompletion).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as LearningAssignmentTopicLearningAssignmentNotification);
    }

    /// <summary>
    /// Returns true if LearningAssignmentTopicLearningAssignmentNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentTopicLearningAssignmentNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentTopicLearningAssignmentNotification other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Module == other.Module ||
                Module != null &&
                Module.Equals(other.Module)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateRecommendedForCompletion == other.DateRecommendedForCompletion ||
                DateRecommendedForCompletion != null &&
                DateRecommendedForCompletion.Equals(other.DateRecommendedForCompletion)
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
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                IsOverdue == other.IsOverdue ||
                IsOverdue != null &&
                IsOverdue.Equals(other.IsOverdue)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                PercentageScore == other.PercentageScore ||
                PercentageScore != null &&
                PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                IsPassed == other.IsPassed ||
                IsPassed != null &&
                IsPassed.Equals(other.IsPassed)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Module != null)
            {
                hash = hash * 59 + Module.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateRecommendedForCompletion != null)
            {
                hash = hash * 59 + DateRecommendedForCompletion.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (IsOverdue != null)
            {
                hash = hash * 59 + IsOverdue.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (PercentageScore != null)
            {
                hash = hash * 59 + PercentageScore.GetHashCode();
            }

            if (IsPassed != null)
            {
                hash = hash * 59 + IsPassed.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
