using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PublishProgramTopicsDefinitionsJob
/// </summary>
[DataContract]
public partial class PublishProgramTopicsDefinitionsJob : IEquatable<PublishProgramTopicsDefinitionsJob>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PublishProgramTopicsDefinitionsJob" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="State">State.</param>
    /// <param name="TestTopicPhraseResults">TestTopicPhraseResults.</param>
    public PublishProgramTopicsDefinitionsJob(string Id = null, StateEnum? State = null, List<PublishProgramTestTopicPhraseResults> TestTopicPhraseResults = null)
    {
        this.Id = Id;
        this.State = State;
        this.TestTopicPhraseResults = TestTopicPhraseResults;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets TestTopicPhraseResults
    /// </summary>
    [DataMember(Name = "testTopicPhraseResults", EmitDefaultValue = false)]
    public List<PublishProgramTestTopicPhraseResults> TestTopicPhraseResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PublishProgramTopicsDefinitionsJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  TestTopicPhraseResults: ").Append(TestTopicPhraseResults).Append("\n");
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
        return Equals(obj as PublishProgramTopicsDefinitionsJob);
    }

    /// <summary>
    /// Returns true if PublishProgramTopicsDefinitionsJob instances are equal
    /// </summary>
    /// <param name="other">Instance of PublishProgramTopicsDefinitionsJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PublishProgramTopicsDefinitionsJob other)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                TestTopicPhraseResults == other.TestTopicPhraseResults ||
                TestTopicPhraseResults != null &&
                TestTopicPhraseResults.SequenceEqual(other.TestTopicPhraseResults)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (TestTopicPhraseResults != null)
            {
                hash = hash * 59 + TestTopicPhraseResults.GetHashCode();
            }

            return hash;
        }
    }
}
