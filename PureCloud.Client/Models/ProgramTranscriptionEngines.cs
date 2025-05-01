using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramTranscriptionEngines
/// </summary>
[DataContract]
public partial class ProgramTranscriptionEngines : IEquatable<ProgramTranscriptionEngines>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramTranscriptionEngines" /> class.
    /// </summary>
    /// <param name="Program">The ID of the program.</param>
    /// <param name="TranscriptionEngines">The program transcription engine settings.</param>
    /// <param name="ModifiedBy">The user last modified the record.</param>
    /// <param name="DateModified">The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ProgramTranscriptionEngines(BaseProgramEntity Program = null, List<ProgramTranscriptionEngine> TranscriptionEngines = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
    {
        this.Program = Program;
        this.TranscriptionEngines = TranscriptionEngines;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The ID of the program
    /// </summary>
    /// <value>The ID of the program</value>
    [DataMember(Name = "program", EmitDefaultValue = false)]
    public BaseProgramEntity Program { get; set; }



    /// <summary>
    /// The program transcription engine settings
    /// </summary>
    /// <value>The program transcription engine settings</value>
    [DataMember(Name = "transcriptionEngines", EmitDefaultValue = false)]
    public List<ProgramTranscriptionEngine> TranscriptionEngines { get; set; }



    /// <summary>
    /// The user last modified the record
    /// </summary>
    /// <value>The user last modified the record</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public AddressableEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



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
        sb.Append("class ProgramTranscriptionEngines {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Program: ").Append(Program).Append("\n");
        sb.Append("  TranscriptionEngines: ").Append(TranscriptionEngines).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as ProgramTranscriptionEngines);
    }

    /// <summary>
    /// Returns true if ProgramTranscriptionEngines instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramTranscriptionEngines to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramTranscriptionEngines other)
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
                Program == other.Program ||
                Program != null &&
                Program.Equals(other.Program)
            ) &&
            (
                TranscriptionEngines == other.TranscriptionEngines ||
                TranscriptionEngines != null &&
                TranscriptionEngines.SequenceEqual(other.TranscriptionEngines)
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

            if (Program != null)
            {
                hash = hash * 59 + Program.GetHashCode();
            }

            if (TranscriptionEngines != null)
            {
                hash = hash * 59 + TranscriptionEngines.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
