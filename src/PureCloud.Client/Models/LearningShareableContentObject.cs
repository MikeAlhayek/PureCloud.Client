using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning assignment SCO (Shareable Content Object)
/// </summary>

public partial class LearningShareableContentObject : IEquatable<LearningShareableContentObject>
{
    /// <summary>
    /// The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.
    /// </summary>
    /// <value>The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.</value>
    
    public enum LessonStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Passed for "Passed"
        /// </summary>
        [EnumMember(Value = "Passed")]
        Passed,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Incomplete for "Incomplete"
        /// </summary>
        [EnumMember(Value = "Incomplete")]
        Incomplete,

        /// <summary>
        /// Enum Browsed for "Browsed"
        /// </summary>
        [EnumMember(Value = "Browsed")]
        Browsed,

        /// <summary>
        /// Enum Notattempted for "NotAttempted"
        /// </summary>
        [EnumMember(Value = "NotAttempted")]
        Notattempted
    }
    /// <summary>
    /// Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.
    /// </summary>
    /// <value>Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.</value>
    
    public enum ExitEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Timeout for "Timeout"
        /// </summary>
        [EnumMember(Value = "Timeout")]
        Timeout,

        /// <summary>
        /// Enum Suspend for "Suspend"
        /// </summary>
        [EnumMember(Value = "Suspend")]
        Suspend,

        /// <summary>
        /// Enum Logout for "Logout"
        /// </summary>
        [EnumMember(Value = "Logout")]
        Logout,

        /// <summary>
        /// Enum Empty for "Empty"
        /// </summary>
        [EnumMember(Value = "Empty")]
        Empty
    }
    /// <summary>
    /// Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.
    /// </summary>
    /// <value>Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.</value>
    
    public enum CreditEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Credit for "Credit"
        /// </summary>
        [EnumMember(Value = "Credit")]
        Credit,

        /// <summary>
        /// Enum Nocredit for "NoCredit"
        /// </summary>
        [EnumMember(Value = "NoCredit")]
        Nocredit
    }
    /// <summary>
    /// Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.
    /// </summary>
    /// <value>Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.</value>
    
    public enum EntryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Abinitio for "AbInitio"
        /// </summary>
        [EnumMember(Value = "AbInitio")]
        Abinitio,

        /// <summary>
        /// Enum Resume for "Resume"
        /// </summary>
        [EnumMember(Value = "Resume")]
        Resume,

        /// <summary>
        /// Enum Empty for "Empty"
        /// </summary>
        [EnumMember(Value = "Empty")]
        Empty
    }
    /// <summary>
    /// Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.
    /// </summary>
    /// <value>Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.</value>
    
    public enum ModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Browse for "Browse"
        /// </summary>
        [EnumMember(Value = "Browse")]
        Browse,

        /// <summary>
        /// Enum Normal for "Normal"
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal,

        /// <summary>
        /// Enum Review for "Review"
        /// </summary>
        [EnumMember(Value = "Review")]
        Review
    }
    /// <summary>
    /// The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.
    /// </summary>
    /// <value>The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.</value>
    [JsonPropertyName("lessonStatus")]
    public LessonStatusEnum? LessonStatus { get; set; }
    /// <summary>
    /// Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.
    /// </summary>
    /// <value>Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.</value>
    [JsonPropertyName("exit")]
    public ExitEnum? Exit { get; set; }
    /// <summary>
    /// Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.
    /// </summary>
    /// <value>Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.</value>
    [JsonPropertyName("credit")]
    public CreditEnum? Credit { get; set; }
    /// <summary>
    /// Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.
    /// </summary>
    /// <value>Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.</value>
    [JsonPropertyName("entry")]
    public EntryEnum? Entry { get; set; }
    /// <summary>
    /// Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.
    /// </summary>
    /// <value>Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.</value>
    [JsonPropertyName("mode")]
    public ModeEnum? Mode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningShareableContentObject" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningShareableContentObject() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningShareableContentObject" /> class.
    /// </summary>
    /// <param name="Id">The ID of the SCO from the course manifest. (required).</param>
    /// <param name="LessonStatus">The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property..</param>
    /// <param name="Exit">Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property..</param>
    /// <param name="Location">The learner’s current location in the SCO. Maps to the SCORM 1.2 cmi.core.lesson_location property..</param>
    /// <param name="ScoreRaw">The score of the most recent attempt on the SCO. Maps to the SCORM 1.2 cmi.core.score.raw property..</param>
    /// <param name="ScoreMax">The maximum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.max property..</param>
    /// <param name="ScoreMin">The minimum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.min property..</param>
    /// <param name="SuspendData">The unique information generated by the SCO from previous uses. Maps to the SCORM 1.2 cmi.suspend_data property..</param>
    /// <param name="SessionTime">The amount of time spent in the SCO in this session expressed as an ISO-8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.session_time property..</param>
    public LearningShareableContentObject(string Id = null, LessonStatusEnum? LessonStatus = null, ExitEnum? Exit = null, string Location = null, float? ScoreRaw = null, float? ScoreMax = null, float? ScoreMin = null, string SuspendData = null, string SessionTime = null)
    {
        this.Id = Id;
        this.LessonStatus = LessonStatus;
        this.Exit = Exit;
        this.Location = Location;
        this.ScoreRaw = ScoreRaw;
        this.ScoreMax = ScoreMax;
        this.ScoreMin = ScoreMin;
        this.SuspendData = SuspendData;
        this.SessionTime = SessionTime;

    }



    /// <summary>
    /// The ID of the SCO from the course manifest.
    /// </summary>
    /// <value>The ID of the SCO from the course manifest.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }







    /// <summary>
    /// The learner’s current location in the SCO. Maps to the SCORM 1.2 cmi.core.lesson_location property.
    /// </summary>
    /// <value>The learner’s current location in the SCO. Maps to the SCORM 1.2 cmi.core.lesson_location property.</value>
    [JsonPropertyName("location")]
    public string Location { get; set; }



    /// <summary>
    /// The score of the most recent attempt on the SCO. Maps to the SCORM 1.2 cmi.core.score.raw property.
    /// </summary>
    /// <value>The score of the most recent attempt on the SCO. Maps to the SCORM 1.2 cmi.core.score.raw property.</value>
    [JsonPropertyName("scoreRaw")]
    public float? ScoreRaw { get; set; }



    /// <summary>
    /// The maximum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.max property.
    /// </summary>
    /// <value>The maximum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.max property.</value>
    [JsonPropertyName("scoreMax")]
    public float? ScoreMax { get; set; }



    /// <summary>
    /// The minimum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.min property.
    /// </summary>
    /// <value>The minimum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.min property.</value>
    [JsonPropertyName("scoreMin")]
    public float? ScoreMin { get; set; }



    /// <summary>
    /// The unique information generated by the SCO from previous uses. Maps to the SCORM 1.2 cmi.suspend_data property.
    /// </summary>
    /// <value>The unique information generated by the SCO from previous uses. Maps to the SCORM 1.2 cmi.suspend_data property.</value>
    [JsonPropertyName("suspendData")]
    public string SuspendData { get; set; }









    /// <summary>
    /// The total amount of time the learner has spent in the SCO expressed as an ISO 8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.total_time property.
    /// </summary>
    /// <value>The total amount of time the learner has spent in the SCO expressed as an ISO 8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.total_time property.</value>
    [JsonPropertyName("totalTime")]
    public string TotalTime { get; set; }



    /// <summary>
    /// The amount of time spent in the SCO in this session expressed as an ISO-8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.session_time property.
    /// </summary>
    /// <value>The amount of time spent in the SCO in this session expressed as an ISO-8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.session_time property.</value>
    [JsonPropertyName("sessionTime")]
    public string SessionTime { get; set; }



    /// <summary>
    /// The href from the course manifest for this SCO.
    /// </summary>
    /// <value>The href from the course manifest for this SCO.</value>
    [JsonPropertyName("href")]
    public string Href { get; set; }



    /// <summary>
    /// The parameters from the course manifest for this SCO.
    /// </summary>
    /// <value>The parameters from the course manifest for this SCO.</value>
    [JsonPropertyName("parameters")]
    public string Parameters { get; set; }



    /// <summary>
    /// The launch data from the course manifest for this SCO.
    /// </summary>
    /// <value>The launch data from the course manifest for this SCO.</value>
    [JsonPropertyName("launchData")]
    public string LaunchData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningShareableContentObject {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  LessonStatus: ").Append(LessonStatus).Append("\n");
        sb.Append("  Exit: ").Append(Exit).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  ScoreRaw: ").Append(ScoreRaw).Append("\n");
        sb.Append("  ScoreMax: ").Append(ScoreMax).Append("\n");
        sb.Append("  ScoreMin: ").Append(ScoreMin).Append("\n");
        sb.Append("  SuspendData: ").Append(SuspendData).Append("\n");
        sb.Append("  Credit: ").Append(Credit).Append("\n");
        sb.Append("  Entry: ").Append(Entry).Append("\n");
        sb.Append("  Mode: ").Append(Mode).Append("\n");
        sb.Append("  TotalTime: ").Append(TotalTime).Append("\n");
        sb.Append("  SessionTime: ").Append(SessionTime).Append("\n");
        sb.Append("  Href: ").Append(Href).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
        sb.Append("  LaunchData: ").Append(LaunchData).Append("\n");
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
        return Equals(obj as LearningShareableContentObject);
    }

    /// <summary>
    /// Returns true if LearningShareableContentObject instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningShareableContentObject to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningShareableContentObject other)
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
                LessonStatus == other.LessonStatus ||
                LessonStatus != null &&
                LessonStatus.Equals(other.LessonStatus)
            ) &&
            (
                Exit == other.Exit ||
                Exit != null &&
                Exit.Equals(other.Exit)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
            ) &&
            (
                ScoreRaw == other.ScoreRaw ||
                ScoreRaw != null &&
                ScoreRaw.Equals(other.ScoreRaw)
            ) &&
            (
                ScoreMax == other.ScoreMax ||
                ScoreMax != null &&
                ScoreMax.Equals(other.ScoreMax)
            ) &&
            (
                ScoreMin == other.ScoreMin ||
                ScoreMin != null &&
                ScoreMin.Equals(other.ScoreMin)
            ) &&
            (
                SuspendData == other.SuspendData ||
                SuspendData != null &&
                SuspendData.Equals(other.SuspendData)
            ) &&
            (
                Credit == other.Credit ||
                Credit != null &&
                Credit.Equals(other.Credit)
            ) &&
            (
                Entry == other.Entry ||
                Entry != null &&
                Entry.Equals(other.Entry)
            ) &&
            (
                Mode == other.Mode ||
                Mode != null &&
                Mode.Equals(other.Mode)
            ) &&
            (
                TotalTime == other.TotalTime ||
                TotalTime != null &&
                TotalTime.Equals(other.TotalTime)
            ) &&
            (
                SessionTime == other.SessionTime ||
                SessionTime != null &&
                SessionTime.Equals(other.SessionTime)
            ) &&
            (
                Href == other.Href ||
                Href != null &&
                Href.Equals(other.Href)
            ) &&
            (
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.Equals(other.Parameters)
            ) &&
            (
                LaunchData == other.LaunchData ||
                LaunchData != null &&
                LaunchData.Equals(other.LaunchData)
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

            if (LessonStatus != null)
            {
                hash = hash * 59 + LessonStatus.GetHashCode();
            }

            if (Exit != null)
            {
                hash = hash * 59 + Exit.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            if (ScoreRaw != null)
            {
                hash = hash * 59 + ScoreRaw.GetHashCode();
            }

            if (ScoreMax != null)
            {
                hash = hash * 59 + ScoreMax.GetHashCode();
            }

            if (ScoreMin != null)
            {
                hash = hash * 59 + ScoreMin.GetHashCode();
            }

            if (SuspendData != null)
            {
                hash = hash * 59 + SuspendData.GetHashCode();
            }

            if (Credit != null)
            {
                hash = hash * 59 + Credit.GetHashCode();
            }

            if (Entry != null)
            {
                hash = hash * 59 + Entry.GetHashCode();
            }

            if (Mode != null)
            {
                hash = hash * 59 + Mode.GetHashCode();
            }

            if (TotalTime != null)
            {
                hash = hash * 59 + TotalTime.GetHashCode();
            }

            if (SessionTime != null)
            {
                hash = hash * 59 + SessionTime.GetHashCode();
            }

            if (Href != null)
            {
                hash = hash * 59 + Href.GetHashCode();
            }

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            if (LaunchData != null)
            {
                hash = hash * 59 + LaunchData.GetHashCode();
            }

            return hash;
        }
    }
}
